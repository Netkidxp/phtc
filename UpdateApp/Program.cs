using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Xml;
using PHTC.UpdateLib;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

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
            bool silence = false;
            bool appnotrun = false;
            Mutex m1 = new Mutex(true, "PHTC.Updater", out notrun);
            if (!notrun)
                return;
            string updatedir = "";
            if (args.Length != 1&&args.Length!=2)
            {
                //updatedir = System.AppDomain.CurrentDomain.BaseDirectory;
                //Console.WriteLine("用法:Update [目标根目录] <-silence>");
                m1.ReleaseMutex();
                m1.Close();
                return;
            }
            else
            {
                updatedir = args[0];
                if(!Directory.Exists(updatedir))
                {
                    //Console.WriteLine("\""+updatedir+"\""+"不是一个合法目录");
                    m1.ReleaseMutex();
                    m1.Close();
                    return;
                }
                if(args.Length==2)
                {
                    if (string.Compare(args[1], "-silence", true) == 0)
                        silence = true;
                    else
                    {
                        //Console.WriteLine("用法:Update [目标根目录] <-silence>");
                        m1.ReleaseMutex();
                        m1.Close();
                        return;
                    }
                }
            }
            AutoUpdater updater = new AutoUpdater(updatedir);
            if (silence)
            {
                notrun = false;
                Mutex mutex = new Mutex(true, "PHTC", out appnotrun);
                if (!appnotrun)
                {
                    mutex.WaitOne();
                }
                else
                {
                    mutex.ReleaseMutex();
                    
                }
                updater.InformationEvent += new AutoUpdater.InformationEventHandler(Log);
                updater.ErrorEvent += new AutoUpdater.ErrorEventHandler(Log);
                updater.DownloadProgressEvent += new AutoUpdater.DownloadProgressEventHandler(Progress);
                updater.StartUpdateSilence();
                updater.Finished.WaitOne();
                mutex.Close();

            }
            else
            {
                if (new WaitForm().ShowDialog() == DialogResult.Cancel)
                {
                    m1.ReleaseMutex();
                    m1.Close();
                    return;
                }
                UpdateProgress up = new UpdateProgress(updater);
                up.ShowDialog();
                if(updater.LastError.Length==0)
                {
                    string exe = Path.Combine(updatedir, "phtc.exe");
                    Process.Start(exe);
                }
            }

            m1.ReleaseMutex();
            m1.Close();
        }
        public static void Log(string inf)
        {
            //Console.WriteLine(inf);
        }
        public static void Progress(float v)
        {
            //Console.SetCursorPosition(0, Console.CursorTop);
            //Console.Write("下载进度:"+((int)(v*100)).ToString("D2")+@"%");
        }
    }
}
