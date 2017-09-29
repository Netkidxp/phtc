using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Xml;
using PHTC.UpdateLib;
namespace PHTC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool notrun = false;
            Mutex m1 = new Mutex(true, "PHTC.Updater", out notrun);
            if (!notrun)
            {
                MessageBox.Show("同一时间只能运行一个升级程序实例");
                return;
            }
            string updatedir = "";
            if (args.Length == 0)
            {
                updatedir = System.AppDomain.CurrentDomain.BaseDirectory;
            }
            else
            {
                updatedir = args[0];

            }

            AutoUpdater updater = new AutoUpdater(updatedir);
            updater.Update();
            
            m1.ReleaseMutex();
            m1.Close();
        }
    }
}
