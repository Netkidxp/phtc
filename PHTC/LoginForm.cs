using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.Model;
namespace PHTC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string LoginName
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
        public string LoginPassword
        {
            get
            {
                return tb_password.Text;
            }
            set
            {
                tb_password.Text = value;
            }
        }
        public bool Remember
        {
            get
            {
                return cb_remember.Checked;
            }
            set
            {
                cb_remember.Checked = value;
            }
        }
        private void bu_login_Click(object sender, EventArgs e)
        {
            LoginOn();
        }
        public void LoginOn()
        {
            if (tb_name.Text == string.Empty || tb_password.Text == string.Empty)
            {
                MessageBox.Show("请填写完整信息", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
                tb_name.Focus();
            else if (tb_password.Text == "")
                tb_password.Focus();
            else
                bu_login.Focus();
        }
    }
}
