﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PHTC.DB;
using PHTC.Model;
namespace PHTC
{
    public delegate void LoadEventHandler(Material mat);
  
    public partial class MaterialManageForm : Form
    {
        bool isManage = false;
        bool filterPanelShow;
        DataTable dt_input;
        int FILTER_PLANEL_HEIGHT = 0;
        public event LoadEventHandler LoadEvent;
        public MaterialManageForm(bool manage)
        {
            isManage = manage;
            InitializeComponent();
            FILTER_PLANEL_HEIGHT = filterPanel.Height;
            dt_input = null;
            FilterPanelShow = false;
            cb_filterPlanel.Checked = false;
            tb_input.Text = "%";
            CNewToolStripMenuItem.Visible = isManage;
            CCopyToolStripMenuItem.Visible = isManage;
            CDeleteToolStripMenuItem.Visible = isManage;
            CLoadToolStripMenuItem.Visible = !isManage;

        }
        public bool FilterPanelShow
        { get => filterPanelShow;
          set
            {
                filterPanelShow = value;
                if(!filterPanelShow)
                {
                    filterPanel.Height = 0;
                    Point p = filterPanel.Location;
                    p.Offset(0, 10);
                    dgv_list.Location = p;
                    this.Height -= FILTER_PLANEL_HEIGHT+10;
                }
                else
                {
                    filterPanel.Height = FILTER_PLANEL_HEIGHT;
                    dgv_list.Location = new Point(filterPanel.Location.X,filterPanel.Location.Y+ FILTER_PLANEL_HEIGHT + 10);
                    this.Height += FILTER_PLANEL_HEIGHT+10;
                }
            }
        }

        private void OnInputChanged(object sender, EventArgs e)
       {
            RefreshData(); 

        }
        public static List<T> GetColumnValues<T>(DataTable dtSource, string filedName)
        {
            return (from r in dtSource.AsEnumerable() select r.Field<T>(filedName)).ToList<T>();
        }
        public static AutoCompleteStringCollection ListToCollection(List<String> list)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach(string s in list)
            {
                collection.Add(s);
            }
            return collection;
        }
        private void RefreshData()
        {
            if (tb_input.Text.Length == 0)
            {
                dgv_list.DataSource = null;
                return;
            }
            dt_input = DbMaterialAdapter.Search(tb_input.Text);
            if (dt_input != null)
            {
                dt_input.Columns[0].ColumnName = "编号";
                dt_input.Columns[1].ColumnName = "名称";
                dt_input.Columns[2].ColumnName = "牌号";
                dt_input.Columns[3].ColumnName = "使用领域";
                dt_input.Columns[4].ColumnName = "所有者";
                dt_input.Columns[5].ColumnName = "备注";
                dt_input.Columns[6].ColumnName = "共享";
                dt_input.Columns[7].ColumnName = "修改时间";
                dgv_list.DataSource = dt_input.DefaultView;
                dgv_list.Columns[0].Width = 30;
                dgv_list.Columns[1].Width = 100;
                dgv_list.Columns[2].Width = 100;
                dgv_list.Columns[3].Width = 100;
                dgv_list.Columns[4].Width = 100;
                dgv_list.Columns[5].Width = 100;
                dgv_list.Columns[6].Width = 30;
                dgv_list.Columns[7].Width = 120;
                tb_name.AutoCompleteCustomSource = ListToCollection(GetColumnValues<string>(dt_input, "名称"));
                tb_code.AutoCompleteCustomSource = ListToCollection(GetColumnValues<string>(dt_input, "牌号"));
                tb_usefor.AutoCompleteCustomSource= ListToCollection(GetColumnValues<string>(dt_input, "使用领域"));
                tb_owner.AutoCompleteCustomSource= ListToCollection(GetColumnValues<string>(dt_input, "所有者"));
                tb_code.Text = "";
                tb_name.Text = "";
                tb_usefor.Text = "";
                tb_owner.Text = "";
            }
            else
            {
                GlobalTool.LogError("MaterialManageForm.RefreshData", "检索材料数据出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return;
            }
            
        }
        private void OnDGVDoubleClick(object sender, EventArgs e)
        {
            LoadMaterial();
        }

        
        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        private int NewMaterial()
        {
            
            Material mat = Material.Default;
            MaterialDetailsForm mdf = new MaterialDetailsForm(mat, MaterialDetailsForm.ButtonType.Update);
            if(mdf.ShowDialog()==DialogResult.OK)
            {
                mat = mdf.Material;
                mat.Owner = User.CurrentUser;
                mat.OwnerId = User.CurrentUser.Id;
                bool res=DbMaterialAdapter.Insert(mat);
                if(!res)
                {
                    GlobalTool.LogError("MaterialManageForm.NewMaterial", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return -1;
                }
                return mat.Index;
            }
            return 0;
            
        }
        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        private void DeleteMaterial()
        {
            int id = (int)dgv_list.CurrentRow.Cells[0].Value;
            Material mat = DbMaterialAdapter.LoadWithId(id);
            if (mat == null)
            {
                GlobalTool.LogError("MaterialManageForm.DeleteMaterial", "读取材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return;
            }
            if (mat.OwnerId == User.CurrentUser.Id)
            {
                bool res = DbMaterialAdapter.Delete(id);
                if (!res)
                {
                    GlobalTool.LogError("MaterialManageForm.DeleteMaterial", "删除材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return;
                }
                return;

            }
            else
            {
                MessageBox.Show("该材料不为您所有，您无法删除！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        /// <summary>
        /// ////////////////////////////////////////
        /// </summary>
        private void ShowMaterial()
        {
            int id = (int)dgv_list.CurrentRow.Cells[0].Value;
            Material mat = DbMaterialAdapter.LoadWithId(id);
            if(mat==null)
            {
                GlobalTool.LogError("MaterialManageForm.ShowMaterial", "读取材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return ;
            }
            if(mat.OwnerId!=User.CurrentUser.Id&&!mat.Share)
            {
                MessageBox.Show("该材料所有者不共享材料信息，请您联系材料所有者！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }
            MaterialDetailsForm mdf = new MaterialDetailsForm(mat, MaterialDetailsForm.ButtonType.Update);
            if(mdf.ShowDialog()==DialogResult.OK)
            {
                Material nm = mdf.Material;
                if(mat.OwnerId!=User.CurrentUser.Id)
                {
                    MessageBox.Show("该材料不为您所有，您将保存为自己的副本!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nm.OwnerId = User.CurrentUser.Id;
                    nm.Owner = User.CurrentUser;
                    nm.Create_time = DateTime.Now;
                    nm.Modify_time = DateTime.Now;
                    bool res = DbMaterialAdapter.Insert(nm);
                    if (!res)
                    {
                        GlobalTool.LogError("MaterialManageForm.ShowMaterial", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    }
                }
                else
                {
                    nm.OwnerId = User.CurrentUser.Id;
                    nm.Owner = User.CurrentUser;
                    nm.Modify_time = DateTime.Now;
                    nm.Index = mat.Index;
                    bool res = DbMaterialAdapter.Update(nm);
                    if (!res)
                    {
                        GlobalTool.LogError("MaterialManageForm.ShowMaterial", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    }
                }
            }
        }
        

        private void OnDGVCurrentCellChanged(object sender, EventArgs e)
        {
            //CDeleteToolStripMenuItem.Enabled = (dgv_list.CurrentRow != null);
            //CDetailsToolStripMenuItem.Enabled = (dgv_list.CurrentRow != null);
            //CLoadToolStripMenuItem.Enabled = (dgv_list.CurrentRow != null);
            //CCopyToolStripMenuItem.Enabled= (dgv_list.CurrentRow != null);
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMaterial();
            RefreshData();
        }
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id=NewMaterial();
            RefreshData();
            if (id > 0)
                SetSelectCell(id);
        }
        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMaterial();
            RefreshData();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMaterial();
        }
        private int CopyMaterial()
        {
            int id = (int)dgv_list.CurrentRow.Cells[0].Value;
            Material mat = DbMaterialAdapter.LoadWithId(id);
            if(mat==null)
            {
                GlobalTool.LogError("MaterialManageForm.CopyMaterial", "读取材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return -1;
            }
            if (mat.OwnerId == User.CurrentUser.Id || mat.Share)
            {
                mat.OwnerId = User.CurrentUser.Id;
                mat.Name = mat.Name + " 副本";
                bool res = DbMaterialAdapter.Insert(mat);
                if (!res)
                {
                    GlobalTool.LogError("MaterialManageForm.NewMaterial", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return -1;
                }
                return mat.Index;
            }
            else
            {
                MessageBox.Show("该材料所有者不共享材料信息，请您联系材料所有者！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }
        private void LoadMaterial()
        {
            if (LoadEvent != null)
            {
                int id = (int)dgv_list.CurrentRow.Cells[0].Value;
                Material mat = DbMaterialAdapter.LoadWithId(id);
                if (mat == null)
                {
                    GlobalTool.LogError("MaterialManageForm.ShowMaterial", "读取材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return;
                }
                if (mat.OwnerId == User.CurrentUser.Id || mat.Share)
                {
                    LoadEvent(mat);
                }
                else
                {
                    MessageBox.Show("该材料所有者不共享材料信息，请您联系材料所有者！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }
        private void FavorateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void RefreshView()
        {
            if (dt_input == null)
                return;
            string filterString = "";
            if (tb_name.Text.Length != 0)
                filterString += "名称 like \'*"+tb_name.Text+"*\'";
            if(tb_code.Text.Length!=0)
            {
                if (filterString.Length > 0)
                    filterString += " and 牌号 like \'*" + tb_code.Text + "*\'";
                else
                    filterString += "牌号 like \'*" + tb_code.Text + "*\'";
            }
            if (tb_usefor.Text.Length != 0)
            {
                if (filterString.Length > 0)
                    filterString += " and 使用领域 like \'*" + tb_usefor.Text + "*\'";
                else
                    filterString += "使用领域 like \'*" + tb_usefor.Text + "*\'";
            }
            if (tb_owner.Text.Length != 0)
            {
                if (filterString.Length > 0)
                    filterString += " and 所有者 like \'*" + tb_owner.Text + "*\'";
                else
                    filterString += "所有者 like \'*" + tb_owner.Text + "*\'";
            }
            if(cb_self.Checked)
            {
                if (filterString.Length > 0)
                    filterString += " and 所有者 = \'" + User.CurrentUser.Name+ "\'";
                else
                    filterString += "所有者 = \'" + User.CurrentUser.Name+ "\'";
            }
            if(cb_share.Checked)
            {
                if (filterString.Length > 0)
                    filterString += " and 共享 = 1";
                else
                    filterString += "共享 = 1";
            }
            DataView dv = new DataView(dt_input);
            dv.RowFilter = filterString;
            dgv_list.DataSource = dv;
            
        }
        private void OnTbNameTextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnTbCodeTextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnTbUseforTextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnTbOwnerTextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnCbSelfCheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnCbShareCheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OnCBFilterPlanelCheckedChanged(object sender, EventArgs e)
        {
            FilterPanelShow = cb_filterPlanel.Checked;
        }

        private void OnContentMenuOpened(object sender, EventArgs e)
        {
            CDeleteToolStripMenuItem.Visible = (dgv_list.CurrentRow != null&&isManage);
            CDetailsToolStripMenuItem.Visible = (dgv_list.CurrentRow != null);
            CLoadToolStripMenuItem.Visible = (dgv_list.CurrentRow != null&& LoadEvent != null&&!isManage);
            CCopyToolStripMenuItem.Visible = (dgv_list.CurrentRow != null&&isManage);
            CNewToolStripMenuItem.Visible = isManage;
        }

        private void CCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            int id=CopyMaterial();
            RefreshData();
            if(id>0)
                SetSelectCell(id);
        }
        private void SetSelectCell(int id)
        {
            dgv_list.CurrentCell = null;
            foreach (DataGridViewRow r in dgv_list.Rows)
            {
                if ((int)(r.Cells[0].Value) == id)
                    r.Selected = true;
            }
        }
    }
}
