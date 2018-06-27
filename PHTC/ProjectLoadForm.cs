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
    public partial class ProjectLoadForm : Form
    {
        public delegate void LoadEventHandler(Project pro);
        public event LoadEventHandler LoadEvent;
        private DataTable dt;
        public ProjectLoadForm()
        {
            InitializeComponent();
            dtp_end.Value = DateTime.Now.AddDays(1);
            dtp_start.Value = DateTime.Now.AddMonths(-1);
            dgv_projects.AutoGenerateColumns = false;
            RefreshData();
        }
        public void RefreshData()
        {
            dt = ProjectManager.Search(tb_keyword.Text);
            if(dt==null)
            {
                GlobalTool.LogError("ProjectLoadForm.RefreshData", "检索工程数据出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return;
            }
            dt.Columns["id"].ColumnName = "编号";
            dt.Columns["name"].ColumnName = "名称";
            dt.Columns["owner"].ColumnName = "所有者";
            dt.Columns["mode_"].ColumnName = "计算类型";
            dt.Columns["type_"].ColumnName = "几何类型";
            dt.Columns["share"].ColumnName = "共享";
            dt.Columns["remark"].ColumnName = "备注";
            dt.Columns["time_"].ColumnName = "时间";
            RefreshDataView();
        }
        public void RefreshDataView()
        {
            if (dt == null)
            {
                dgv_projects.DataSource = null;
                return;
            }
            DataView dv = new DataView(dt);
            string filter = "";
            //DateTime dstart= new DateTime(dtp_start.Value.Year, dtp_start.Value.Month, dtp_start.Value.Day, 0, 0, 0);
            //DateTime dend = dstart.AddMonths(1);
            DateTime dstart = dtp_start.Value.Date;
            DateTime dend = dtp_end.Value.Date;
            double start = GlobalTool.ConvertDateTimeInt(dstart);
            double end= GlobalTool.ConvertDateTimeInt(dend);
            filter = "time>=" + start.ToString() + " and time<=" + end.ToString();
            if (cb_share.Checked)
            {
                filter += " and 共享=1";
            }
            if (cb_self.Checked)
                filter += " or 所有者=\'" + User.CurrentUser.Name+"\'";
            
            dv.RowFilter = filter;
            dgv_projects.DataSource = dv;
            dgv_projects.Columns.Clear();
            dgv_projects.Columns.Add("编号", "编号");
            dgv_projects.Columns[0].DataPropertyName = "编号";
            dgv_projects.Columns.Add("名称", "名称");
            dgv_projects.Columns[0].Width = 30;
            dgv_projects.Columns[1].DataPropertyName = "名称";
            dgv_projects.Columns[1].Width = 100;
            dgv_projects.Columns.Add("所有者", "所有者");
            dgv_projects.Columns[2].DataPropertyName = "所有者";
            dgv_projects.Columns[2].Width = 100;
            dgv_projects.Columns.Add("计算类型", "计算类型");
            dgv_projects.Columns[3].DataPropertyName = "计算类型";
            dgv_projects.Columns[3].Width = 80;
            dgv_projects.Columns.Add("几何类型", "计算类型");
            dgv_projects.Columns[4].DataPropertyName = "几何类型";
            dgv_projects.Columns[4].Width = 80;
            dgv_projects.Columns.Add("时间", "时间");
            dgv_projects.Columns[5].DataPropertyName = "时间";
            dgv_projects.Columns[5].Width = 100;
            DataGridViewCheckBoxColumn dgvcbc = new DataGridViewCheckBoxColumn(false);
            dgvcbc.HeaderText = "共享";
            dgv_projects.Columns.Add(dgvcbc);
            dgv_projects.Columns[6].DataPropertyName = "共享";
            dgv_projects.Columns[6].Width = 30;
        }

        
        private void OnTbKeywordChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OnCbSelfChanged(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void OnCbShareChanged(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void OnDtpStartChanged(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void OnDtpEndChanged(object sender, EventArgs e)
        {
            RefreshDataView();
        }

        private void OnDgvSelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dvrc = dgv_projects.SelectedRows;
            if (dvrc.Count == 0)
            {
                mi_delete.Enabled = false;
                mi_load.Enabled = false;
            }
            else if(dvrc.Count>1)
            {
                mi_delete.Enabled = true;
                mi_load.Enabled = false;
            }
            else
            {
                mi_delete.Enabled = true;
                mi_load.Enabled = true;
            }
        }
        private void LoadProject()
        {
            if (LoadEvent != null)
            {
                DataGridViewSelectedRowCollection dvrc = dgv_projects.SelectedRows;
                DataGridViewRow dvr = dvrc[0];
                int id = (int)dvr.Cells[0].Value;
                Project pro = ProjectManager.Load(id);
                if (pro == null)
                {
                    GlobalTool.LogError("ProjectManageForm.mi_load_Click", "读取工程出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return;
                }
                else
                {
                    LoadEvent(pro);
                }
            }
        }
        private void mi_load_Click(object sender, EventArgs e)
        {
            LoadProject();
        }
        private void DeleteProject()
        {
            DataGridViewSelectedRowCollection dvrc = dgv_projects.SelectedRows;
            foreach (DataGridViewRow dvr in dvrc)
            {
                int id = (int)dvr.Cells[0].Value;
                Project pro = ProjectManager.Load(id);
                if (pro == null)
                {
                    GlobalTool.LogError("ProjectManageForm.mi_delete_Click", "删除工程出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    continue;
                }
                else
                {
                    if(pro.OwnerId!=User.CurrentUser.Id)
                    {
                        MessageBox.Show("该工程不为您所有，您无法删除", "警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        bool res = ProjectManager.Delete(id);
                        if (!res)
                        {
                            GlobalTool.LogError("ProjectManageForm.ProjectManager.Delete", "删除工程出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                        }
                    }
                    
                }
            }
            RefreshData(); 
        }
        private void mi_delete_Click(object sender, EventArgs e)
        {
            DeleteProject();
        }

        private void OnDgvKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && mi_delete.Enabled)
                DeleteProject();
            if (e.KeyCode == Keys.Enter && mi_load.Enabled)
                LoadProject();
        }

        private void OnDgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mi_load.Enabled)
                LoadProject();
        }
    }
}
