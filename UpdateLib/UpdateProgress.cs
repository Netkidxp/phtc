using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHTC.UpdateLib
{
    public partial class UpdateProgress : Form
    {
        
        public UpdateProgress()
        {
            InitializeComponent();
            
            
        }
        public void LogAdd(string inf)
        {
            tb_log.Invoke(new MethodInvoker(delegate() 
            {
                this.tb_log.Text = this.tb_log.Text + inf;
                this.tb_log.Select(tb_log.Text.Length, 0);
                this.tb_log.ScrollToCaret();
            }));
        }
        public void LogAddNewline(string inf)
        {
            tb_log.Invoke(new MethodInvoker(delegate () 
            {
                if (this.tb_log.Text == "")
                    this.tb_log.Text = inf;
                this.tb_log.Text = this.tb_log.Text + "\r\n" + inf;
                this.tb_log.Select(tb_log.Text.Length, 0);
                this.tb_log.ScrollToCaret();
            }));
        }
        public void LogClear()
        {
            tb_log.Invoke(new MethodInvoker(delegate () { this.tb_log.Text = ""; }));
        }
        public float TotalProgress
        {
            set
            {
                int v = (int)(value * (pgb_total.Maximum - pgb_total.Minimum));
                pgb_total.Invoke(new MethodInvoker(delegate() { pgb_total.Value = v; }));
            }
        }
        public float CurrentProgress
        {
            set
            {
                int v = (int)(value * (pgb_current.Maximum - pgb_current.Minimum));
                pgb_current.Invoke(new MethodInvoker(delegate () { pgb_current.Value = v; }));
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {

        }
    }
}
