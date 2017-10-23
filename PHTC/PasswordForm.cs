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
    public partial class PasswordForm : Form
    {
        public string Pass { get; set; }
        public PasswordForm()
        {
            InitializeComponent();
        }
        private void bu_ok_Click(object sender, EventArgs e)
        {
            Pass = UserManager.GetMD5(tb_pass.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
