using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Xml;
namespace PHTC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool notrun = false;
            Mutex m1 = new Mutex(true, "PHTC.Updater", out notrun);
            if (!notrun)
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool bHasError = false;
            IAutoUpdater autoUpdater = new AutoUpdater();
            string path= System.IO.Directory.GetCurrentDirectory();
            try
            {
                autoUpdater.Update(path);
            }
            catch (WebException exp)
            {
                GlobalTool.LogError("UpdateApp.WebException", exp.Message, false);
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
                GlobalTool.LogError("UpdateApp.XmlException", exp.Message, false);
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                GlobalTool.LogError("UpdateApp.NotSupportedException", exp.Message, false);
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                GlobalTool.LogError("UpdateApp.ArgumentException", exp.Message, false);
            }
            catch (Exception exp)
            {
                bHasError = true;
                GlobalTool.LogError("UpdateApp.Other", exp.Message, false);
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        autoUpdater.RollBack();
                    }
                    catch (Exception exp)
                    {
                        GlobalTool.LogError("UpdateApp.Rollback", exp.Message, true);
                    }
                }
            }
            m1.ReleaseMutex();
            m1.Close();
        }
    }
}
