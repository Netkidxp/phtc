using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.UpdateLib
{
    [Serializable]
    public class UpdateInformation
    {
        public string Ver { get; set; }
        public string UpdateDescribe { get; set; }
        public bool NeedReboot { get; set; }
        public List<RemoteFile> FileList { get; set; }
        public string Url { get; set; }
        public long Size { get; set; }
        public string Md5 { get; set; }
        public List<string> Cmds { get; set; }
    }
}
