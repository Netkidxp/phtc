using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PHTC.UpdateLib
{
    public partial class WaitForm : Form
    {
        Thread wait;
        Mutex mutex;
        public WaitForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            wait = new Thread(Run);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            if (wait.IsAlive)
                wait.Abort();
            Close();
        }

        private void OnShown(object sender, EventArgs e)
        {
            bool notrun = false;
            mutex = new Mutex(true, "PHTC", out notrun);
            if (notrun)
            {
                DialogResult = DialogResult.OK;
                mutex.ReleaseMutex();
                mutex.Close();
                Close();
            }
            else
            {
                wait.Start();
            }
        }
        private void Run()
        {
            mutex.WaitOne();
            DialogResult = DialogResult.OK;
            Close();
            
        }
        private void MyClose()
        {
           this.Close();
        }
    }
}
