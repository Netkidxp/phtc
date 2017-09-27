using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PHTC.UpdateLib
{
    [Serializable]
    public class RemoteFile
    {
        public string Name { set; get; }
        public string Path { set; get; }
        public string Url { set; get; }
        public string Md5 { set; get; }
        public long Size { set; get; }
        public bool Restart { get; set; }
    }
}
