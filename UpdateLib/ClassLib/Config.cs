using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PHTC.UpdateLib
{
    [Serializable]
    public class Config
    {
        public bool Enable { get; set; }
        public string LastVer { get; set; }
        public string FileListUrl { get; set; }
        public Config()
        {

        }
        public Config(bool enable,string xmlurl)
        {
            Enable = enable;
            FileListUrl = xmlurl;
        }
        public static Config Read(string path)
        {
            
            Config c = Serializer.DeserializeJson<Config>(path);
            if (c == null)
                return null;
            return c;
        }
        public bool Write(string path)
        {
            return Serializer.SerializeJson<Config>(this, path);
        }
    }
}
