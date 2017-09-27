using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace PHTC.UpdateLib
{
    public class Serializer
    {
        public static bool Serialize<T>(T obj,string path)
        {
            try
            {
                Stream stream = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, obj);
                byte[] data = new byte[stream.Length];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(data, 0, (int)stream.Length);
                stream.Close();
                FileStream fs = new FileStream(path, FileMode.Create);
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public static T Deserialize<T>(string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            
            
            T o = (T)bf.Deserialize(fs);
            return o;
        }
        public static bool SerializeJson<T>(T obj,string path)
        {
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                StringBuilder sb = new StringBuilder();
                jss.Serialize(obj, sb);
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static T DeserializeJson<T>(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.UTF8) ;
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string str = sr.ReadToEnd();
            T obj = jss.Deserialize<T>(str);
            sr.Close();
            return obj;
        }
    }
}
