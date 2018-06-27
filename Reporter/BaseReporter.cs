using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.Model;
using System.IO;
namespace PHTC.Reporter
{
    /*public interface IReporter
    {
        string ReporterName();
        string ReporterExtName();
        string ReporterInduction();
        bool Report(Project project,string filename);
    }
    public class HtmlReporter:IReporter
    {
        public HtmlReporter()
        {

        }
        public string ReporterName()
        {
            return "Html报表";
        }
        public string ReporterExtName()
        {
            return ".html";
        }
        public string ReporterInduction()
        {
            return @"将结果导出为html格式报表";
        }
        public bool Report(Project project,string filename)
        {
            return true;
        }
    }*/
    public partial class BaseReporter
    {
        public Project Pro
        {
            get;
            set;
        }
        public string TempletFilePath { get; set; }
        public string ReportFilePath { get; set; }
        public string[] LayerPicturePath { get; set; }

        public BaseReporter(Project _pro)
        {
            Pro = _pro;
        }
        public virtual string ReporterName
        {
            get { return "BaseReport"; }
        }
        public virtual string RepDocExtName
        {
            get { return ".txt"; }
        }
        public virtual string ReporterInduction
        {
            get { return @"文本报告"; }
        }
        public virtual int ReporterId
        {
            get { return 0; }
        }
        public virtual bool Report()
        {
            try
            {
                byte[] buffer = Pro.Serialize();
                FileStream fs = new FileStream(ReportFilePath, FileMode.CreateNew);
                fs.Write(buffer, 0, buffer.Length);
                fs.Flush();
                fs.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
