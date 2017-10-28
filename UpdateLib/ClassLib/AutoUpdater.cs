using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.IO.Compression;

namespace PHTC.UpdateLib
{
    
    public class AutoUpdater:IUpdater
    {
        private Config config = null;
        private string rootdir = null;
        private string lastError = "";
        private WebClient webClient = null;
        private string tempBaseDirName = null;
        private string rollbackDir = null;
        private List<LocalFile> localFileList = null;
        private List<RemoteFile> needUpdateList = null;
        private List<RemoteFile> coverFileList = null;
        private List<RemoteFile> createFileList = null;
        private bool rollPrepared = false;

        public UpdateInformation updateInformation = null;
        
        private ManualResetEvent finished = null;
        public ManualResetEvent Finished { get => finished; }
        public string LastError { get => lastError; }
        public bool IsFinished { get; set; }
        private AutoUpdater() { }
        public delegate void ErrorEventHandler(string information);
        public delegate void InformationEventHandler(string information);
        public delegate void DownloadProgressEventHandler(float progress);
        public delegate void FinishedEventHandler();

        public ErrorEventHandler ErrorEvent = null;
        public InformationEventHandler InformationEvent = null;
        public DownloadProgressEventHandler DownloadProgressEvent = null;
        public FinishedEventHandler FinishedEvent = null;

        
        public AutoUpdater(string root)
        {
            lastError = "";
            rootdir = root;
            finished = new ManualResetEvent(false);
            IsFinished = false;
        }
        private string CreatezTempDir()
        {
            Random r = new Random();
            string name = Path.Combine(Path.GetTempPath(), r.Next().ToString());
            Directory.CreateDirectory(name);
            return name;
        }
        private void LogError(string error)
        {
            if (ErrorEvent != null)
                ErrorEvent(error);
            lastError += error+"\r\n";
        }
        private void LogInformation(string information)
        {
            if (InformationEvent != null)
                InformationEvent(information);
        }
         
        public Config ReadConfig()
        {
            string configPath = Path.Combine(rootdir, Const.ConfigFileName);
            try
            {
                if (File.Exists(configPath))
                {
                    Config c = Config.Read(configPath);
                    LogInformation("读取本地配置成功");
                    return c;
                }
                else
                {
                    LogError("本地配置文件\"" + configPath + "\"不存在");
                    return null;
                }
            }
            catch(Exception e)
            {
                LogError("解析本地配置文件\"" + configPath + "\"失败");
                return null;
            }
            
        }
        public bool WriteConfig(Config c)
        {
            string configPath = Path.Combine(rootdir, Const.ConfigFileName);
            try
            {
                bool res=c.Write(configPath);
                if (res)
                {
                    LogInformation("写入本地配置成功");
                    return true;
                }
                else
                {
                    LogError("写入本地配置文件\"" + configPath + "\"失败");
                    return false;
                }
            }
            catch (Exception e)
            {
                LogError("写入本地配置文件\"" + configPath + "\"失败:"+e.Message);
                return false;
            }
        }
        public string DownloadUpdateInformationFile()
        {
            string tempname = Path.GetTempFileName();
            bool res = DownLoader.DownloadFile(tempname, config.FileListUrl);
            if (!res)
            {
                LogError("下载更新配置文件失败，请检查网络连接");
                return null;
            }
            else
            {
                LogInformation("下载更新配置文件成功");
                return tempname;
            }
                
        }
        public UpdateInformation ResoluteUpdateInfromationFile(string filename)
        {
            try
            {
                UpdateInformation inf = Serializer.DeserializeJson<UpdateInformation>(filename);
                LogInformation("解析更新配置文件成功");
                return inf;
            }
            catch(Exception e)
            {
                LogError("解析更新配置文件错误，信息:" + e.Message);
                return null;
            }
        }
        public void Abort()
        {

        }
        public void Finish()
        {
            finished.Set();
            IsFinished = true;
            if (FinishedEvent != null)
                FinishedEvent();
        }
        public string Download()
        {
            ManualResetEvent downloadEvent = new ManualResetEvent(false);
            string fileName = Path.GetTempFileName();
            webClient = new WebClient();
            webClient.Proxy = WebRequest.DefaultWebProxy;
            webClient.Proxy.Credentials = CredentialCache.DefaultCredentials;
            webClient.Credentials = System.Net.CredentialCache.DefaultCredentials;
            webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
            {
                //formUpdateProgress.CurrentProgress = (float)e.BytesReceived / (float)updateInformation.Size;
                if (DownloadProgressEvent != null)
                    DownloadProgressEvent((float)e.BytesReceived / (float)updateInformation.Size);
            };
            webClient.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs e) =>
            {
                downloadEvent.Set();
            }; 
            try
            {
                LogInformation("开始下载......");
                webClient.DownloadFileAsync(new Uri(updateInformation.Url),fileName);
                downloadEvent.WaitOne();
                LogInformation("下载完毕,正在验证...");
                if(Md5.FileMd5(fileName)==updateInformation.Md5)
                {
                    LogInformation("更新包验证成功");
                    return fileName;
                }
                else
                {
                    LogError("更新包验证失败");
                    return null;
                }
            }
            catch(Exception e)
            {
                LogError("下载更新包失败，请检查网络连接或者过段时间再试");
                return null;
            }
            
        }
        public bool Unzip(string filename,string dir)
        {
            try
            {
                ZipFile.ExtractToDirectory(filename, dir);
                LogInformation("解压更新文件成功");
                return true;
            }
            catch(Exception e)
            {
                LogError("解压失败，信息:" + e.Message);
                return false;
            }
        }
        public bool ValidateUpdateFiles()
        {
            bool res = true;
            foreach (RemoteFile f in needUpdateList)
            {
                string name = Path.Combine(tempBaseDirName, f.Path,f.Name);
                if(Md5.FileMd5(name)!=f.Md5)
                {
                    res = false;
                    LogError("文件" + name + "验证失败");
                }
                else
                {
                    LogInformation("文件" + name + "验证成功");
                }
            }
            LogInformation("验证数据包完成");
            return res;
        }
        public bool PrepareRollback()
        {
            try
            {
                rollbackDir = CreatezTempDir();
                foreach (RemoteFile f in coverFileList)
                {
                    CopyFile(Path.Combine(rootdir, f.Path,f.Name), Path.Combine(rollbackDir, f.Path,f.Name));
                }
                LogInformation("回滚准备完成");
                return true;
            }
            catch(Exception e)
            {
                LogError("回滚准备失败,信息:" + e.Message);
                return false;
            }
        }
        public bool Rollback()
        {
            try
            {
                foreach (RemoteFile f in coverFileList)
                {
                    CopyFile(Path.Combine(rollbackDir, f.Path,f.Name), Path.Combine(rootdir, f.Path,f.Name));
                }
                foreach(RemoteFile f in createFileList)
                {
                    File.Delete(Path.Combine(rootdir, f.Path, f.Name));
                }
                LogInformation("回滚完成");
                return true;
            }
            catch(Exception e)
            {
                LogError("回滚失败,信息:" + e.Message);
                return false;
            }
        }
        public bool UpdateFiles()
        {
            try
            {
                foreach (RemoteFile f in needUpdateList)
                {
                    CopyFile(Path.Combine(tempBaseDirName, f.Path,f.Name), Path.Combine(rootdir, f.Path,f.Name));
                }
                LogInformation("更新完成");
                return true;
            }
            catch(Exception e)
            {
                LogError("复制文件失败,信息:"+e.Message);
                return false;
            }
        }
        private void CopyFile(string srcFileName,string desFileName)
        {
            string desDir = Path.GetDirectoryName(desFileName);
            if (!Directory.Exists(desDir))
                Directory.CreateDirectory(desDir);
            File.Copy(srcFileName, desFileName,true);
        }
        public void StartUpdate()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateProc),false);
        }
        public void StartUpdateSilence()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateProc), true);
        }
        private List<RemoteFile> MakeUpdateList()
        {
            List<RemoteFile> list = new List<RemoteFile>();
            foreach(RemoteFile rf in updateInformation.FileList)
            {
                if (string.Compare(rf.Name, Const.ConfigFileName, true) == 0)
                    continue;
                if (IsNeedUpdate(rf))
                    list.Add(rf);
            }
            return list;
        }
        private List<RemoteFile> MakeCoverFileList()
        {
            List<RemoteFile> list = new List<RemoteFile>();
            foreach(RemoteFile rf in needUpdateList)
            {
                if (IsOldFile(rf))
                    list.Add(rf);
            }
            return list;
        }
        private List<RemoteFile> MakeCreateFileList()
        {
            List<RemoteFile> list = new List<RemoteFile>();
            foreach (RemoteFile rf in needUpdateList)
            {
                if (IsNewFile(rf))
                    list.Add(rf);
            }
            return list;
        }
        private bool IsNewFile(RemoteFile rf)
        {
            foreach(LocalFile lf in localFileList)
            {
                if (string.Compare(lf.Path, rf.Path, true) == 0 && string.Compare(lf.Name, rf.Name, true) == 0)
                    return false;
            }
            return true;
        }
        private bool IsOldFile(RemoteFile rf)
        {
            foreach (LocalFile lf in localFileList)
            {
                if(string.Compare(lf.Path, rf.Path, true) == 0 && string.Compare(lf.Name, rf.Name, true) == 0&& lf.Md5 != rf.Md5)
                    return true;
            }
            return false;
        }
        private bool IsNeedUpdate(RemoteFile rf)
        {
            foreach(LocalFile lf in localFileList)
            {
                if (string.Compare(lf.Path, rf.Path, true) == 0&& string.Compare(lf.Name, rf.Name, true)==0 && lf.Md5 == rf.Md5)
                    return false;
            }
            return true;
        }
        
        public void UpdateProc(object o)
        {

            bool silence = (bool)o;
            IsFinished = false;
            lastError = "";
            finished.Reset();
            config = ReadConfig();
            if (config == null)
            {
                Finish();
                return;
            }
               
            if (!config.Enable)
            {
                Finish();
                return;
            }
            string infpath = DownloadUpdateInformationFile();
            if (infpath == null)
            {
                Finish();
                return;
            }
            updateInformation = ResoluteUpdateInfromationFile(infpath);
            if (updateInformation == null)
            {
                Finish();
                return;
            }
            localFileList = Local.LocalFileList(rootdir);
            needUpdateList = MakeUpdateList();
            createFileList = MakeCreateFileList();
            coverFileList = MakeCoverFileList();
            Version verLocal = new Version(config.LastVer);
            Version verRemote = new Version(updateInformation.Ver);
            if (verLocal>=verRemote)
            {
                LogInformation("您的软件是最新版本，不需要更新");
                Finish();
                return;
            }
            string tempfile = Download();
            if (tempfile == null)
            {
                Finish();
                return;
            }
            tempBaseDirName = CreatezTempDir();
            bool res = Unzip(tempfile, tempBaseDirName);
            if (!res)
            {
                Finish();
                return;
            }
            if (!ValidateUpdateFiles())
            {
                Finish();
                return;
            }
            rollPrepared = PrepareRollback();
            res = UpdateFiles();
            if (!res && rollPrepared)
            {
                res = Rollback();
            }
            else
            {
                config.LastVer = updateInformation.Ver;
                WriteConfig(config);
            }
            Finish();
        }
        public bool CheckUpdate(object o)
        {
            lastError = null;
            //finished.Reset();
            config = ReadConfig();
            if (config == null)
            {
                return false; ;
            }
            string infpath = DownloadUpdateInformationFile();
            if (infpath == null)
            {
                return false;
            }
            updateInformation = ResoluteUpdateInfromationFile(infpath);
            if (updateInformation == null)
            {
                return false;
            }
            localFileList = Local.LocalFileList(rootdir);
            needUpdateList = MakeUpdateList();
            createFileList = MakeCreateFileList();
            coverFileList = MakeCoverFileList();
            Version verLocal = new Version(config.LastVer);
            Version verRemote = new Version(updateInformation.Ver);
            if (verLocal >=verRemote)
            {
                LogInformation("您的软件是最新版本，不需要更新");
                return false;
            }
            return true;
        }
        public bool ProcessUpdate(object o)
        {
            string tempfile = Download();
            if (tempfile == null)
            {
                return false;
            }
            tempBaseDirName = CreatezTempDir();
            bool res = Unzip(tempfile, tempBaseDirName);
            if (!res)
            {
                return false;
            }
            if (!ValidateUpdateFiles())
            {
                return false;
            }
            rollPrepared = PrepareRollback();
            res = UpdateFiles();
            if (!res && rollPrepared)
            {
                res = Rollback();
            }
            else
            {
                config.LastVer = updateInformation.Ver;
                WriteConfig(config);
            }
            return true;
        }
    }
}
