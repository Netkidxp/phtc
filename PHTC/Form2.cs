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
    public partial class Form2 : Form
    {

        ProjectProperty projectProperty;
        LayerCollectionProperty layerCollectionProperty;
        public Form2()
        {
            InitializeComponent();
        }
        private void InitDefaultProperty()
        {
            projectProperty = ProjectProperty.Default();
            layerCollectionProperty = LayerCollectionProperty.Default();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            tv_navigation.ExpandAll();
            InitDefaultProperty();
        }

        private void OnNavigationSelected(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "N_Project":
                    NAV_Project();
                    break;
                case "N_Material":
                    NAV_Material();
                    break;
                case "N_MaterialDetails":
                    NAV_MaterialDetails(e.Node.Index);
                    break;
                case "N_CalculateModel":
                    NAV_CalculateModel();
                    break;
                case "N_HotfaceParameter":
                    NAV_HotfaceParameter();
                    break;
                case "N_LayerInformation":
                    NAV_LayerInformation();
                    break;
                case "N_LayerDetails":
                    NAV_LayerDetails(e.Node.Index);
                    break;
                case "N_ColdfaceBoundary":
                    NAV_ColdfaceBoundary();
                    break;
                case "N_SolveParameter":
                    NAV_SolveParameter();
                    break;
                case "N_MainCriterion":
                    NAV_MainCriterion();
                    break;
                case "N_SubCriterion":
                    NAV_SubCriterion();
                    break;
                case "N_LayerDifferential":
                    NAV_LayerDifferential();
                    break;
                case "N_Solve":
                    NAV_Solve();
                    break;
                case "N_Result":
                    NAV_Result();
                    break;

            }
        }
        private void NAV_Project()
        {
            //pg.SelectedObject = projectProperty;
            
        }
        private void NAV_Material()
        {

        }
        private void NAV_MaterialDetails(int index)
        {

        }
        private void NAV_CalculateModel()
        {

        }
        private void NAV_HotfaceParameter()
        {
            
        }
        private void NAV_LayerInformation()
        {
            //pg.SelectedObject = layerCollectionProperty;

        }
        private void NAV_LayerDetails(int index)
        {

        }
        private void NAV_ColdfaceBoundary()
        {

        }
        private void NAV_SolveParameter()
        {

        }
        private void NAV_MainCriterion()
        {

        }
        private void NAV_SubCriterion()
        {

        }
        private void NAV_LayerDifferential()
        {

        }
        private void NAV_Solve()
        {

        }
        private void NAV_Result()
        {

        }

        private void OnPgValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //if(pg.SelectedObject is ProjectProperty)
            //{
               // SwitchNav();
            //}
            //else if(pg.SelectedObject is )
        }
        private void SwitchNav()
        {
            if(projectProperty.Mode==CalculationMode.Temperature)
            {
                TreeNode n = tv_navigation.Nodes[0].Nodes["N_SolveParameter"].Nodes["N_MainCriterion"];
                if (n!=null)
                    n.Remove();
            }
            else if(projectProperty.Mode==CalculationMode.Thickness)
            {
                TreeNode n = tv_navigation.Nodes[0].Nodes["N_SolveParameter"].Nodes["N_MainCriterion"];
                if(n == null)
                    tv_navigation.Nodes[0].Nodes["N_SolveParameter"].Nodes.Insert(0,"N_MainCriterion", "主循环收敛准则", 31, 31);
            }
        }
    }
}
