using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHTC
{
    public partial class ProjectSaveAsForm : Form
    {
        public ProjectSaveAsForm()
        {
            InitializeComponent();
        }
        public string ProjectName
        {
            get
            {
                return tb_name.Text;
            }
            set
            {
                tb_name.Text = value;
            }
        }
        public bool Share
        {
            get
            {
                return cb_share.Checked;
            }
            set
            {
                cb_share.Checked = value;
            }
        }
        private void bu_ok_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Length != 0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("工程名称不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OnShown(object sender, EventArgs e)
        {
            tb_name.Focus();
            tb_name.SelectAll();
        }
    }
}
