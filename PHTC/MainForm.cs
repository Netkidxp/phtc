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
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new ProjectForm();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void bu_search_Click(object sender, EventArgs e)
        {
            DataTable dt= Search();
            if (dt == null)
                return;
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dgv_material.DataSource = ds;
            dgv_material.DataMember = dt.TableName;
            dgv_material.Columns[0].HeaderText = "编号";
            //dgv_material.Columns[0].Width = 60;
            dgv_material.Columns[1].HeaderText = "名称";
            //dgv_material.Columns[1].Width = 60;
            dgv_material.Columns[2].HeaderText = "牌号";
            //dgv_material.Columns[2].Width = 60;
            dgv_material.Columns[3].HeaderText = "领域";
            dgv_material.Columns[4].HeaderText = "建立人";
            //dgv_material.Columns[3].Width = 80;
            dgv_material.Columns[5].HeaderText = "备注";
            //dgv_material.Columns[4].Width = 100;
        }
        private DataTable Search()
        {
            DataTable dt;
            if(cb_onlySelf.Checked)
                dt = DbMaterialAdapter.Search(User.CurrentUser.Id, tb_name.Text, tb_code.Text, tb_usefor.Text, cb_onlyShared.Checked);
            else
                dt= DbMaterialAdapter.Search(tb_name.Text, tb_code.Text, tb_usefor.Text, cb_onlyShared.Checked);
            return dt;
        }
    }
}
