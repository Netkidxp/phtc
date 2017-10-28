using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PHTC.DB;
using PHTC.Model;
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
            if(!DbManager.Ins.TestConnection())
            {
                MessageBox.Show("无法连接服务器，请确认您的电脑已经连接濮耐股份局域网", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool notrun = false;
            Mutex m=new Mutex(true, "PHTC",out notrun);
            if(!notrun)
            {
                MessageBox.Show("同一时间只能运行一个PHTC实例，请您关闭已经运行的PHTC实例再试", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User.CurrentUser = null;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string name = UserManager.ReadRememberName();
            string pass = UserManager.ReadRememberPassword();
            LoginForm lf = new LoginForm();
            if (name != null)
                lf.LoginName = name;
            if (pass != null)
                lf.LoginPassword = pass;
            if(name!=null&&pass!=null)
            {
                User u = UserManager.LoginOn(name, pass);
                if (u != null)
                {
                    User.CurrentUser = u;
                    Application.Run(new ProjectForm(args));
                    m.ReleaseMutex();
                    m.Close();
                    return;
                }
            }
            if(User.CurrentUser==null)
            {
                while (lf.ShowDialog() == DialogResult.OK)
                {
                    User u = UserManager.LoginOn(lf.LoginName, lf.LoginPassword);
                    if (u != null)
                    {
                        User.CurrentUser = u;
                        UserManager.WriteRememberName(lf.LoginName);
                        if (lf.Remember)
                        {
                            UserManager.WriteRememberPassword(lf.LoginPassword);
                        }
                        else
                        {
                            UserManager.DeleteRememberPassword();
                        }
                        Application.Run(new ProjectForm(args));
                        m.ReleaseMutex();
                        m.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("用户不存在或者密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
            
        }

    }
}
