using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace PHTC
{
    public static class GlobalTool
    {
        private static string mainConnectString = "main";
        //private static readonly object lockHelper = new object();
        public static string GetConnectStringsConfig()
        {
            return ConfigurationManager.ConnectionStrings[mainConnectString].ConnectionString.ToString();
        }
        public static string GetErrorLogFileNameConfig()
        {

            return ConfigurationManager.AppSettings["ErrorFileName"];
        }
        public static void LogError(String errSru,String errStr,Boolean showMsgBox)
        {
            String errString = DateTime.Now.ToString() + "||source:" + errSru + "||Information:" + errStr+"\n";
            if(showMsgBox)
            {
                System.Windows.Forms.MessageBox.Show("错误来源:" + errSru + "\n" + "错误信息:" + errStr, "错误", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            LogIntoFile(GetErrorLogFileNameConfig(), errString);

        }
        public static void LogIntoFile(String fileName,String str)
        {
            String filePath = System.Windows.Forms.Application.StartupPath + "\\" + fileName;
            FileStream fs;
            StreamWriter sw;
            try
            {
                fs= new FileStream(filePath, FileMode.OpenOrCreate);
                fs.Seek(0, SeekOrigin.End);
                sw= new StreamWriter(fs);
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("读写文件"+fileName+"失败:"+e.Message,"错误",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                
            }
        }
        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">double 型数字</param>
        /// <returns>DateTime</returns>
        public static System.DateTime ConvertIntDateTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(d);
            return time;
        }

        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>double</returns>
        public static double ConvertDateTimeInt(System.DateTime time)
        {
            double intResult = 0;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            intResult = (time - startTime).TotalSeconds;
            return intResult;
        }
        public static double K2C(double k)
        {
            return k - 273.15;
        }
        public static double C2K(double c)
        {
            return c + 273.15;
        }
        
    }
}
