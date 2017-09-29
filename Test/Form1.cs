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
using System.IO;
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config c = new Config(true, @"http://192.168.2.88/update.xml");
            c.Write("e:\\update.config");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Config c = Config.Read("e:\\update.config");
            string s = c.FileListUrl;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory(Path.GetDirectoryName("e:\\hahah\\sdsd\\d.txt"));
            File.Copy("c:\\sss.txt", "e:\\hahah\\sdsd\\d.txt");

        }
    }
}
