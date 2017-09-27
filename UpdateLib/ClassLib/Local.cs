using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.UpdateLib
{
    public class Local
    {
        public static List<LocalFile> LocalFileList(string dir)
        {
            List<LocalFile> list = new List<LocalFile>();
            DirFileList(dir, dir, list);
            return list;
        }
        private static void DirFileList(string basedir, string dir, List<LocalFile> list)
        {
            DirectoryInfo folder = new DirectoryInfo(dir);
            foreach (FileInfo file in folder.GetFiles())
            {
                LocalFile f = new LocalFile();
                f.Name = file.Name;
                f.Path = file.DirectoryName.Remove(0, basedir.Length);
                if (f.Path.Length > 1)
                    f.Path = f.Path.Remove(0, 1);
                f.Size = file.Length;
                f.Md5 = Md5.FileMd5(file.FullName);
                list.Add(f);
            }
            foreach (DirectoryInfo nextdir in folder.GetDirectories())
            {
                DirFileList(basedir, nextdir.FullName, list);
            }
        }
        public static List<RemoteFile> DefaultRemoteFileList(string dir,string urlroot)
        {
            List<LocalFile> ll = Local.LocalFileList(dir);
            List<RemoteFile> list = new List<RemoteFile>();
            foreach (LocalFile lf in ll)
            {
                RemoteFile rf = new RemoteFile();
                rf.Md5 = lf.Md5;
                rf.Name = lf.Name;
                rf.Path = lf.Path;
                rf.Restart = false;
                rf.Size = lf.Size;
                if (lf.Path.Length == 0)
                    rf.Url = urlroot + "/" + lf.Name;
                else
                    rf.Url = urlroot + "/" + lf.Path.Replace('\\', '/') + "/" + lf.Name;
                list.Add(rf);
            }
            return list;
        }
       
        
    }
}
