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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public string OldPassword
        {
            get
            {
                return tb_oldpassword.Text;
            }
            set
            {
                tb_oldpassword.Text = value;
            }
        }
        public string Password1
        {
            get
            {
                return tb_password1.Text;
            }
            set
            {
                tb_password1.Text = value;
            }
        }
        public string Password2
        {
            get
            {
                return tb_password2.Text;
            }
            set
            {
                tb_password2.Text = value;
            }
        }
        private void bu_ok_Click(object sender, EventArgs e)
        {
            if(OldPassword==""||Password1==""||Password2=="")
            {
                MessageBox.Show("请输入完整信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Password1!=Password2)
            {
                MessageBox.Show("您两次输入的新密码不一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Password1.Length<6)
            {
                MessageBox.Show("您输入的新密码长度不能小于6位", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
