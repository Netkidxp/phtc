using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace ServerSetup
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FMT_CONN_STR= @"Data Source = {0}; Port={1};Initial Catalog = phtc; User ID = PHTC; Password=punai123+";
        private const string FMT_UPDATE_URL = @"http://{0}/update/update.desc";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = PHTC.GlobalTool.GetConnectStringsLanConfig();
                string[] infs = str.Split(';');
                string str_db = infs[0].Substring(infs[0].IndexOf('=') + 1);
                string str_port = infs[1].Substring(infs[1].IndexOf('=') + 1);
                tb_db.Text = str_db;
                tb_port.Text = str_port;
            }
            catch(Exception)
            {
                MessageBox.Show("Can not read Database server config");
            }
            try
            {
                PHTC.UpdateLib.Config c = PHTC.UpdateLib.Config.Read("ServerConfig.config");
                string url= c.FileListUrlLan;
                url = url.Substring(7);
                url = url.Substring(0, url.IndexOf('/'));
                tb_update.Text = url;
            }
            catch(Exception)
            {
                MessageBox.Show("Can not read file: Server.config");
            }

        }

        private void bu_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bu_ok_Click(object sender, RoutedEventArgs e)
        {
            int t=0;
            if (tb_db.Text.Length == 0 || !int.TryParse(tb_port.Text, out t) || tb_update.Text.Length == 0)
                MessageBox.Show("Please check your input");
            else
            {
                string str = String.Format(FMT_CONN_STR, tb_db.Text, tb_port.Text);
                PHTC.GlobalTool.SetConnectionStringLan(str);
                try
                {
                    PHTC.UpdateLib.Config c = PHTC.UpdateLib.Config.Read("ServerConfig.config");
                    c.FileListUrlLan = string.Format(FMT_UPDATE_URL,tb_update.Text);
                    c.Write("ServerConfig.config");
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not read/write file: Server.config");
                }
            }
        }
    }
}
