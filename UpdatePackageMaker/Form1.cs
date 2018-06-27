using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.UpdateLib;
using System.IO.Compression;
using System.IO;
namespace UpdatePackageMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bu_go_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            List<RemoteFile> list = Local.DefaultRemoteFileList(tb_dir.Text, tb_urlbase.Text);
            UpdateInformation inf = new UpdateInformation();
            inf.FileList = list;
            inf.UpdateDescribe = tb_desc.Text;
            inf.Url = tb_urlbase.Text;
            inf.Ver = new Version(tb_ver.Text).ToString();
            string file = Path.Combine(dialog.SelectedPath, "update.pkg");
            if (File.Exists(file))
                File.Delete(file);
            ZipFile.CreateFromDirectory(tb_dir.Text, file);
            inf.Md5 = Md5.FileMd5(file);
            FileInfo fi = new FileInfo(file);
            inf.Size = fi.Length;
            inf.Cmds = new List<string>();
            foreach(Object o in lb_cmds.Items)
            {
                inf.Cmds.Add(o.ToString());
            }
            Serializer.SerializeJson<UpdateInformation>(inf, Path.Combine(dialog.SelectedPath,"update.desc"));
            MessageBox.Show("生成成功，哈哈哈");
        }

        private void bu_dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                tb_dir.Text = dialog.SelectedPath;
                string phtc = Path.Combine(tb_dir.Text, "phtc.exe");
                System.Diagnostics.FileVersionInfo info = System.Diagnostics.FileVersionInfo.GetVersionInfo(phtc);
                tb_ver.Text = info.FileVersion;
            }
        }

        private void bu_addcmd_Click(object sender, EventArgs e)
        {
            lb_cmds.Items.Add(tb_cmd.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_cmds.Items.Clear();
        }
    }
}
