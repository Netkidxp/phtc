using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PHTC.UpdateLib
{
    public class AutoUpdater:IUpdater
    {
        private Config config = null;
        private string rootdir = null;
        private bool bNeedRestart = false;
        private bool bDownload = false;
        
        private AutoUpdater() { }

        public AutoUpdater(string root)
        {
            rootdir = root;
        }
        public void Update()
        {
            config = Config.Read(Path.Combine(rootdir, Const.ConfigFilePath));
            if (!config.Enable)
                return;
            string tempname = Path.GetTempFileName();
            bool res=DownLoader.DownloadFile(tempname, config.FileListUrl);
            if(!res)
            {
                throw (new Exception("下载更新列表失败"));
            }
            List<RemoteFile> remoteFileList = Serializer.DeserializeJson<List<RemoteFile>>(tempname);
            List<LocalFile> localFileList = Local.LocalFileList(rootdir);
            List<RemoteFile> needUpdateList = MakeUpdateList(remoteFileList, localFileList);
            if(needUpdateList.Count==0)
            {
                MessageBox.Show("您的软件是最新版本，不需要更新", "不需要更新",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(new UpdateConfirm().ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            StartUpdate(needUpdateList);

        }
        private void StartUpdate(List<RemoteFile> needUpdateList)
        {

        }
        private List<RemoteFile> MakeUpdateList(List<RemoteFile> remoteFileList, List<LocalFile> localFileList)
        {
            List<RemoteFile> list = new List<RemoteFile>();
            foreach(RemoteFile rf in remoteFileList)
            {
                if (IsNeedUpdate(rf, localFileList))
                    list.Add(rf);
            }
            return list;
        }
        private bool IsNeedUpdate(RemoteFile rf, List<LocalFile> list)
        {
            foreach (LocalFile lf in list)
            {
                string lp = lf.Path + "\\" + lf.Name;
                string rp = rf.Path + "\\" + rf.Name;
                if (string.Compare(lp, rp, true) == 0 && lf.Md5 == rf.Md5)
                    return false;
            }
            return true;
        }
        public void RollBack()
        {

        }
    }
}
