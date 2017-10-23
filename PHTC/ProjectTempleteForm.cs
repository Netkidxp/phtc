using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.DB;
using PHTC.Model;
namespace PHTC
{
    public partial class ProjectTempleteForm : Form
    {
        private List<ProjectTemplete> pts = null;
        public Project Pro { get; set; }
        public ProjectTempleteForm()
        {
            pts = new List<ProjectTemplete>();
            InitializeComponent();
        }
        private void RefreshData()
        {
            List<string> c1s = DBProjectTempleteAdapter.ListClass1();
            cb_class1.DataSource = c1s;
        }
        private void OnClass1TextChanged(object sender, EventArgs e)
        {
            List<string> c2s = DBProjectTempleteAdapter.ListClass2(cb_class1.Text);
            if (c2s != null)
                cb_class2.DataSource = c2s;
        }

        private void OnClass2TextChanged(object sender, EventArgs e)
        {
            List<string> c3s = DBProjectTempleteAdapter.ListClass3(cb_class1.Text, cb_class2.Text);
            if (c3s != null)
                cb_class3.DataSource = c3s;
        }

        private void OnClass3TextChanged(object sender, EventArgs e)
        {
            pts = DBProjectTempleteAdapter.SearchAllWithClass(cb_class1.Text, cb_class2.Text, cb_class3.Text);
            if (pts == null)
                return;
            List<string> ptnames = new List<string>();
            foreach (ProjectTemplete pt in pts)
            {
                ptnames.Add(pt.Name);
            }
            lb_pts.DataSource = ptnames;
            bu_ok.Enabled = (ptnames.Count>0&&lb_pts.SelectedIndex>-1);
        }
        private void OnPtsSelectedChanged(object sender, EventArgs e)
        {
            tb_description.Text = pts[lb_pts.SelectedIndex].Description;
        }

        private void bu_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bu_ok_Click(object sender, EventArgs e)
        {
            
            int id = pts[lb_pts.SelectedIndex].Id;
            Pro = DBProjectTempleteAdapter.LoadTempleteWithId(id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ProjectTempleteForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OnPtdDoubleClick(object sender, EventArgs e)
        {
            if(lb_pts.Items.Count > 0 && lb_pts.SelectedIndex > -1)
            {
                int id = pts[lb_pts.SelectedIndex].Id;
                Pro = DBProjectTempleteAdapter.LoadTempleteWithId(id);
                DialogResult = DialogResult.OK;
                Close();
            }  
        }
    }
}
