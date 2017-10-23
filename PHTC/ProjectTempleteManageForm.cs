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
    public partial class ProjectTempleteManageForm : Form
    {
        private Project pro = null;
        private List<ProjectTemplete> pts = null;
        public ProjectTempleteManageForm(Project p)
        {
            pro = p;
            pts = new List<ProjectTemplete>() ;
            InitializeComponent();
        }
        private void RefreshData()
        {
            List<string> c1s = DBProjectTempleteAdapter.ListClass1();
            cb_class1.DataSource = c1s;
        }

        private void bu_add_Click(object sender, EventArgs e)
        {
            if(cb_class1.Text==""||cb_class2.Text==""||cb_class3.Text=="")
            {
                MessageBox.Show("您必须选择或者输入类别", "错误");
                return;
            }
            ProjectTemplete pt = new ProjectTemplete();
            pt.Class1 = cb_class1.Text;
            pt.Class2 = cb_class2.Text;
            pt.Class3 = cb_class3.Text;
            pt.Description = pro.Remark;
            pt.Name = pro.Name;
            pt.Raw = pro.Serialize();
            pt.Id = 0;
            bool res=DBProjectTempleteAdapter.Insert(pt);
            if(!res)
            {
                MessageBox.Show("建立新模板错误，请检查您的网络或者联系管理员", "错误");
                return;
            }
            RefreshData();
        }

        private void bu_addlocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "PHTC工程文件|*.pht";
            if (fd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Project p = Project.FromFile(fd.FileName);
            if (p == null)
            {
                MessageBox.Show("该文件格式不正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cb_class1.Text == "" || cb_class2.Text == "" || cb_class3.Text == "")
            {
                MessageBox.Show("您必须选择或者输入类别", "错误");
                return;
            }
            ProjectTemplete pt = new ProjectTemplete();
            pt.Class1 = cb_class1.Text;
            pt.Class2 = cb_class2.Text;
            pt.Class3 = cb_class3.Text;
            pt.Description = p.Remark;
            pt.Name = p.Name;
            pt.Raw = p.Serialize();
            pt.Id = 0;
            bool res = DBProjectTempleteAdapter.Insert(pt);
            if (!res)
            {
                MessageBox.Show("建立新模板错误，请检查您的网络或者联系管理员", "错误");
                return;
            }
            RefreshData();
        }

        private void ProjectTempleteManageForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OnClass1TextChanged(object sender, EventArgs e)
        {
            List<string> c2s = DBProjectTempleteAdapter.ListClass2(cb_class1.Text);
            if(c2s!=null)
                cb_class2.DataSource = c2s;
        }

        private void OnClass2TextChanged(object sender, EventArgs e)
        {
            List<string> c3s = DBProjectTempleteAdapter.ListClass3(cb_class1.Text, cb_class2.Text);
            if(c3s!=null)
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
        }

        private void OnPtsSelectedChanged(object sender, EventArgs e)
        {
            tb_description.Text = pts[lb_pts.SelectedIndex].Description;
        }

        private void bu_delete_Click(object sender, EventArgs e)
        {
            int id = pts[lb_pts.SelectedIndex].Id;
            DBProjectTempleteAdapter.DeleteWithId(id);
            RefreshData();
        }

        private void bu_deleteall_Click(object sender, EventArgs e)
        {
            foreach(ProjectTemplete pt in pts)
            {
                DBProjectTempleteAdapter.DeleteWithId(pt.Id);
            }
            RefreshData();
        }
    }
}
