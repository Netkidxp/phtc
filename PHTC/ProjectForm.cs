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
    public partial class ProjectForm : Form
    {
        private const string STR_Project = "N_Project";
        private const string STR_Material = "N_Material";
        private const string STR_MaterialItem = "N_MaterialItem";
        private const string STR_Model = "N_Model";
        private const string STR_ModelParameter = "N_ModelParamter";

        private Project pro;
        public Project Pro { get => pro; set => pro = value; }
        
        public ProjectForm(Project _pro)
        {
            pro = _pro;
            InitializeComponent();     
        }
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            tv_navigation.ExpandAll();
        }
        private void RefreshTreeView()
        {

            tv_navigation.Nodes["N_Project"].Text = Pro.Name;
            tv_navigation.Nodes["N_Material"].Text = "材料列表(材料数量:"+Pro.MaterialList.Count.ToString()+")";
            tv_navigation.Nodes["N_Material"].Nodes.Clear();
            foreach (Material mat in Pro.MaterialList)
            {
                TreeNode tn = new TreeNode(mat.Name);
                tn.ImageIndex = 32;
                tv_navigation.Nodes["N_Material"].Nodes.Add(tn);
            }
        }
        private void OnTvNavigationDoubleClick(object sender, EventArgs e)
        {
            switch (tv_navigation.SelectedNode.Name)
            {
                case "N_Material":
                    MaterialManageForm mmf = new MaterialManageForm();
                    mmf.LoadEvent += new LoadEventHandler(AddMaterial);
                    mmf.ShowDialog();
                    break;
            }
        }
        private void AddMaterial(Material mat)
        {
            
        }
        private void BeforeTvNavCollapse(object sender, TreeViewCancelEventArgs e)
        {
            
            if (e.Node.Bounds.Contains(tv_navigation.PointToClient(Cursor.Position)))
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void BeforeTvNavExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Bounds.Contains(tv_navigation.PointToClient(Cursor.Position)))
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
