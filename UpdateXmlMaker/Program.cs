using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace UpdateXmlMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length!=2)
            {
                Console.WriteLine("用法:");
                Console.WriteLine("UpdateXmlMaker <文件目录> <务器地址>");
                return;
            }
            XmlDocument xmldoc = new XmlDocument();
            XmlDeclaration theFirstRowOfXml = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmldoc.AppendChild(theFirstRowOfXml);
            XmlNode root = xmldoc.CreateElement("updateFiels");
            xmldoc.AppendChild(root);
            MakeDirNode(args[0],args[0], xmldoc, args[1]);
            xmldoc.Save("AutoupdateService.xml");
            Console.WriteLine("生成AutoupdateService.xml成功！");
        }

        public static string FileMd5(string path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("FileMd5() fail,error:" + ex.Message);
            }
        }

        static void MakeDirNode(string basedir,string dir,XmlDocument xml,string server)
        {
            DirectoryInfo folder = new DirectoryInfo(dir);
            foreach (FileInfo file in folder.GetFiles())
            {
                System.Diagnostics.FileVersionInfo info = System.Diagnostics.FileVersionInfo.GetVersionInfo(file.FullName);
                string path = file.FullName.Remove(0, basedir.Length+1);
                XmlNode node = xml.CreateNode(XmlNodeType.Element, "file",null);
                XmlAttribute xa_path = xml.CreateAttribute("path");
                xa_path.Value = path;
                node.Attributes.Append(xa_path);
                XmlAttribute xa_url = xml.CreateAttribute("url");
                xa_url.Value = server+"/files/"+path.Replace('\\','/');
                node.Attributes.Append(xa_url);
                XmlAttribute xa_version = xml.CreateAttribute("lastver");
                xa_version.Value = info.ProductVersion;
                node.Attributes.Append(xa_version);
                XmlAttribute xa_size = xml.CreateAttribute("size");
                xa_size.Value = file.Length.ToString();
                node.Attributes.Append(xa_size);
                XmlAttribute xa_needRestart = xml.CreateAttribute("needRestart");
                xa_needRestart.Value = "False";
                node.Attributes.Append(xa_needRestart);
                XmlAttribute xa_md5 = xml.CreateAttribute("md5");
                xa_md5.Value = FileMd5(file.FullName);
                node.Attributes.Append(xa_md5);
                xml.ChildNodes[1].AppendChild(node);
            }
            foreach (DirectoryInfo nextdir in folder.GetDirectories())
            {
                MakeDirNode(basedir,nextdir.FullName, xml, server);
            }
        } 
    }
}
