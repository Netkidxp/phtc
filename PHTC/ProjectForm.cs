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
        /// <summary>
        /// 
        /// </summary>
        private const string STR_Project = "N_Project";
        private const string STR_Material = "N_Material";
        private const string STR_MaterialItem = "N_MaterialItem";
        private const string STR_CalculateModel = "N_CalculateModel";
        private const string STR_ModelParameter = "N_ModelParameter";
        private const string STR_HotfaceParameter = "N_HotfaceParameter";
        private const string STR_Layer = "N_Layer";
        private const string STR_LayerItem = "N_LayerItem";
        private const string STR_ColdfaceBoundary = "N_ColdfaceBoundary";
        private const string STR_SolveParameter = "N_SolveParameter";
        private const string STR_TemperatureCriterion = "N_TemperatureCriterion";
        private const string STR_ThicknessCriterion = "N_ThicknessCriterion";
        private const string STR_LayDifferentialCount = "N_LayDifferentialCount";
        private const string STR_Solve = "N_Solve";
        private const string STR_Result = "N_Result";
        /// <summary>
        /// 
        /// </summary>
        private TreeNode tn_Project;
        private TreeNode tn_Material;
        private TreeNode tn_ModelParameter;
        private TreeNode tn_HotfaceParameter;
        private TreeNode tn_Layer;
        private TreeNode tn_ColdfaceBoundary;
        private TreeNode tn_SolveParameter;
        private TreeNode tn_TemperatureCriterion;
        private TreeNode tn_ThicknessCriterion;
        private TreeNode tn_LayDifferentialCount;
        /// <summary>
        /// 
        /// </summary>
        private Project pro;
        private bool Modified
        {
            get;
            set;
        }
        public Project Pro { get => pro; set => pro = value; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_pro"></param>
        public ProjectForm()
        {
            pro = ProjectManager.New();
            InitializeComponent();
            tn_Project = tv_navigation.Nodes[STR_Project];
            tn_Material = tn_Project.Nodes[STR_Material];
            tn_ModelParameter = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_ModelParameter];
            tn_HotfaceParameter = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_HotfaceParameter];
            tn_Layer = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_Layer];
            tn_ColdfaceBoundary = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_ColdfaceBoundary];
            tn_SolveParameter = tn_Project.Nodes[STR_SolveParameter];

            pd_main.Project = Pro;
            pd_main.OnHotfaceClick += new PhtcDisplay.HotfaceDbClickHandler(ShowHotfaceParameter);
            pd_main.OnColdfaceClick += new PhtcDisplay.ColdfaceDbClickHandler(ShowColdfaceBoudary);
            pd_main.OnLayerDbClick += new PhtcDisplay.LayerDbClickHandler(ShowLayer);
            RefreshTreeView();
        }
        
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            tv_navigation.ExpandAll();
        }
        /// <summary>
        /// 
        /// </summary>
        private void RefreshTreeView()
        {
            TreeNode old_tn = tv_navigation.SelectedNode;
            tn_Project.Text = Pro.Name;
            tn_Material.Text = "材料列表(材料数量:"+Pro.MaterialList.Count.ToString()+")";
            tn_Material.Nodes.Clear();
            foreach (Material mat in Pro.MaterialList)
            {
                TreeNode tn = new TreeNode(mat.Name+"(所有者:"+mat.Owner.Name+")");
                tn.Name = STR_MaterialItem;
                tn.ImageIndex = 33;
                tn.SelectedImageIndex = 33;
                tn.ContextMenuStrip = cms_N_MarerialItem;
                tn_Material.Nodes.Add(tn);
            }
            string sModelParameter = "";
            if (Pro.Mode == CalculationMode.Temperature)
                sModelParameter += "计算类型:温度;";
            else
                sModelParameter += "计算类型:厚度;";
            if (Pro.Schema == GeometrySchema.Plate)
                sModelParameter += "几何类型:平板";
            else
                sModelParameter += "几何类型:圆筒";
            sModelParameter = "(" + sModelParameter + ")";
            tn_Project.Text = Pro.Name+sModelParameter;
            string sHotfaceTemperature = "(热面温度:"+GlobalTool.K2C(Pro.HotfaceTemperature).ToString()+"℃)";
            tn_HotfaceParameter.Text = sHotfaceTemperature;
            tn_Layer.Nodes.Clear();
            tn_Layer.Text = "层列表(层数量:" + Pro.LayerList.Count.ToString() + ")";
            int i = 0;
            foreach(Layer l in Pro.LayerList)
            {
                string sLayer = "";
                if (l is ResistanceLayer)
                    sLayer = "类型:热阻层;热阻:"+l.HeatResistance.ToString()+"KW^-1";
                else
                {
                    string sThickness = "";
                    if (Pro.Mode == CalculationMode.Thickness && i == Pro.TargetLayerIndex)
                        sThickness = "待求";
                    else
                        sThickness = l.Thickness.ToString();
                    sLayer = "材料:" + l.Material.Name + ";厚度:" + sThickness;
                }
                TreeNode tn = new TreeNode(l.Name+"("+sLayer+")");
                tn.Name = STR_LayerItem;
                tn.ImageIndex = 28;
                tn.SelectedImageIndex = 28;
                tn.ContextMenuStrip = cms_N_LayerItem;
                tn_Layer.Nodes.Add(tn);
                i++;
            }

            tn_SolveParameter.Nodes.Clear();
            tn_TemperatureCriterion = new TreeNode("温度收敛准则");
            tn_TemperatureCriterion.Name = STR_TemperatureCriterion;
            tn_TemperatureCriterion.ImageIndex = 31;
            tn_TemperatureCriterion.SelectedImageIndex = 31;
            tn_SolveParameter.Nodes.Add(tn_TemperatureCriterion);
            if(Pro.Mode==CalculationMode.Thickness)
            {
                tn_ThicknessCriterion = new TreeNode("厚度收敛准则");
                tn_ThicknessCriterion.Name = STR_ThicknessCriterion;
                tn_ThicknessCriterion.SelectedImageIndex = 31;
                tn_ThicknessCriterion.ImageIndex = 31;
                tn_SolveParameter.Nodes.Add(tn_ThicknessCriterion);
            }
            tn_LayDifferentialCount = new TreeNode("层微分参数");
            tn_LayDifferentialCount.Name = STR_LayDifferentialCount;
            tn_LayDifferentialCount.ImageIndex = tn_LayDifferentialCount.SelectedImageIndex = 13;
            tn_SolveParameter.Nodes.Add(tn_LayDifferentialCount);
            if (old_tn != null)
                tv_navigation.SelectedNode = old_tn;
            pd_main.Project = Pro;
            pd_main.Refresh();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool IsMaterialUsed(int index)
        {
            foreach(Layer l in Pro.LayerList)
            {
                if (l.Material == Pro.MaterialList[index])
                    return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTvNavigationDoubleClick(object sender, EventArgs e)
        {
            if (!tv_navigation.SelectedNode.Bounds.Contains(tv_navigation.PointToClient(Cursor.Position)))
            {
                return;
            }
            switch (tv_navigation.SelectedNode.Name)
            {
                case STR_ModelParameter:
                    ShowProjectParameter();
                    break;
                case STR_Project:
                    ShowProjectParameter();
                    break;
                case STR_HotfaceParameter:
                    ShowHotfaceParameter();
                    break;
                case STR_MaterialItem:
                    ShowMaterial(tv_navigation.SelectedNode.Index);
                    break;
                case STR_Material:
                    LoadMaterial();
                    break;
                case STR_Layer:
                    AddLayer();
                    break;
                case STR_LayerItem:
                    ShowLayer(tv_navigation.SelectedNode.Index);
                    break;
                case STR_ColdfaceBoundary:
                    ShowColdfaceBoudary();
                    break;
                case STR_TemperatureCriterion:
                    ShowTemperatureSolveParameter();
                    break;
                case STR_ThicknessCriterion:
                    ShowThicknessSolveParameter();
                    break;
                case STR_LayDifferentialCount:
                    ShowLayDifferentialCount();
                    break;
                case STR_Solve:
                    Solve();
                    break;
                case STR_Result:
                    Result();
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void Solve()
        {
            TemperatureCalculate tc = new TemperatureCalculate(Pro.HotfaceTemperature,Pro.SizeRorW,Pro.SizeRorW,Pro.SizeLorH ,Pro.ColdfaceBoundary, Pro.LayerList);
            if (Pro.Mode==CalculationMode.Temperature)
            {
                TemperatureSolverC1 solver = TemperatureSolverFactory.CreateSolver(tc);
                solver.InitalizeTemperature();
                solver.Solve(Pro.TemperatureSolverControlParameter);
            }
            else
            {
                ThicknessCalculate thc = new ThicknessCalculate(tc, Pro.TargetLayerIndex, Pro.TargetValue, Pro.TemperatureSolverControlParameter, Pro.ThicknessSolverControlParameter);
                ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(thc);
                solver.Solve();
            }
            RefreshTreeView();
            Modified = true;
        }
        private void Result()
        {
            MessageBox.Show("Res");
        }
        private void ShowLayDifferentialCount()
        {
            LayerDifferentialParameterForm ldpf = new LayerDifferentialParameterForm(Pro.TemperatureSolverControlParameter.IntegrateCount);
            if(ldpf.ShowDialog()==DialogResult.OK)
            {
                Pro.TemperatureSolverControlParameter.IntegrateCount = ldpf.DifferentialCount;
                Modified = true;
            }
        }
        private void ShowTemperatureSolveParameter()
        {
            ControlParameterForm cpf = new ControlParameterForm(Pro.TemperatureSolverControlParameter);
            cpf.Text = "温度收敛准则";
            if(cpf.ShowDialog()==DialogResult.OK)
            {
                Pro.TemperatureSolverControlParameter = cpf.ControlParameter;
                Modified = true;
            }
        }
        private void ShowThicknessSolveParameter()
        {
            ControlParameterForm cpf = new ControlParameterForm(Pro.ThicknessSolverControlParameter);
            cpf.Text = "厚度收敛准则";
            if (cpf.ShowDialog() == DialogResult.OK)
            {
                Pro.ThicknessSolverControlParameter = cpf.ControlParameter;
                Modified = true;
            }
        }
        private void ShowHotfaceParameter()
        {
            HotfaceParameterForm hpf = new HotfaceParameterForm(Pro.Schema, Pro.SizeRorW, Pro.SizeLorH);
            hpf.Temperature = Pro.HotfaceTemperature;
            if (hpf.ShowDialog() == DialogResult.OK)
            {
                Pro.HotfaceTemperature = hpf.Temperature;
                Pro.SizeRorW = hpf.Radius;
                Pro.SizeLorH = hpf.Length;
                RefreshTreeView();
                Modified = true;
            }
        }
        private void ShowProjectParameter()
        {
            ProjectParameterForm mpf = new ProjectParameterForm();
            mpf.SolverType = Pro.Mode;
            mpf.Schema = Pro.Schema;
            mpf.ProjectName = Pro.Name;
            mpf.Share = Pro.Share;
            mpf.Remark = Pro.Remark;
            if(mpf.ShowDialog()==DialogResult.OK)
            {
                Pro.Mode = mpf.SolverType;
                if(Pro.Schema==GeometrySchema.Plate&&mpf.Schema==GeometrySchema.Tubbiness)
                {
                    MessageBox.Show("几何类型由平板变为圆筒，请您设置热面半径","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                Pro.Schema = mpf.Schema;
                if (Pro.Mode == CalculationMode.Thickness )
                {
                    if(Pro.ThicknessSolverControlParameter == null)
                        Pro.ThicknessSolverControlParameter = SolverControlParameter.Default;
                }
                Pro.Name = mpf.ProjectName;
                Pro.Share = mpf.Share;
                Pro.Remark = mpf.Remark;
                Modified = true;
            }
            RefreshTreeView();
        }
        private void ShowColdfaceBoudary()
        {
            ColdBoundaryForm cbf = new ColdBoundaryForm(Pro.ColdfaceBoundary,Pro.Mode);
            cbf.TargetValue = Pro.TargetValue;
            if(cbf.ShowDialog()==DialogResult.OK)
            {
                Pro.ColdfaceBoundary = cbf.Boundary;
                if (Pro.Mode == CalculationMode.Thickness)
                    Pro.TargetValue = cbf.TargetValue;
                Modified = true;
                RefreshTreeView();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void LoadMaterial()
        {
            MaterialManageForm mmf = new MaterialManageForm();
            mmf.LoadEvent += new LoadEventHandler(MaterialLoadEventHandle);
            mmf.Show();
        }
        private void MaterialLoadEventHandle(Material mat)
        {
            Pro.MaterialList.Add(mat);
            RefreshTreeView();
            Modified = true;
        }
        private void DeleteMaterial(int index)
        {
            if(IsMaterialUsed(index))
            {
                MessageBox.Show("改材料在使用中，删除前请确认没有层在使用该材料", "错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Pro.MaterialList.RemoveAt(index);
            RefreshTreeView();
            Modified = true;
        }
        private void ShowMaterial(int index)
        {
            int id = MaterialManager.ShowMaterial(Pro.MaterialList[index].Index);
            if(id!=0)
            {
                Pro.MaterialList[index] = MaterialManager.LoadMaterial(id);
            }
            RefreshTreeView();
            Modified = true;
        }
        /// <summary>
        /// 
        /// </summary>
        private void AddLayer()
        {
            if (Pro.MaterialList.Count == 0)
            {
                DialogResult dr = MessageBox.Show("您还没有载入任何材料参数，现在要载入材质吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    LoadMaterial();
                }
                return;
            }
            Layer layer = new Layer(Pro.MaterialList[0], 1.0,1,1);
            layer.Name = "新建层"+ (Pro.LayerList.Count+1).ToString();
            LayerForm lf = new LayerForm(layer, Pro.Mode, Pro.Schema, Pro.MaterialList, false);
            if(lf.ShowDialog()==DialogResult.OK)
            {
                Pro.LayerList.Add(lf.Layer);
                if(lf.IsTarget)
                {
                    Pro.TargetLayerIndex = Pro.LayerList.Count - 1;
                }
            }
            RefreshTreeView();
            Modified = true;
        }
        private void ShowLayer(int index)
        {
            Layer l = Pro.LayerList[index];
            LayerForm lf = new LayerForm(l, Pro.Mode, Pro.Schema, Pro.MaterialList, index == Pro.TargetLayerIndex);
            if(lf.ShowDialog()==DialogResult.OK)
            {
                Pro.LayerList[index] = lf.Layer;
                if(lf.IsTarget)
                {
                    Pro.TargetLayerIndex = index;
                }
            }
            RefreshTreeView();
            tv_navigation.SelectedNode = tn_Layer.Nodes[index];
            Modified = true;
        }
        private void DeleteLayer(int index)
        {
            Pro.LayerList.RemoveAt(index);
            /*if (index == Pro.TargetLayerIndex)
            {
                Pro.TargetLayerIndex = 0;

            }*/
                
            RefreshTreeView();
            Modified = true;
        }
        private void MoveUpLayer(int index)
        {
            if (index == 0)
                return;
            Layer lOldLeft = Pro.LayerList[index - 1];
            Layer lOld = Pro.LayerList[index];
            Pro.LayerList[index - 1] = lOld;
            Pro.LayerList[index] = lOldLeft;
            if (Pro.TargetLayerIndex == index)
                Pro.TargetLayerIndex -= 1;
            else if (Pro.TargetLayerIndex == index - 1)
                Pro.TargetLayerIndex += 1;
            RefreshTreeView();
            tv_navigation.SelectedNode = tn_Layer.Nodes[index-1];
            Modified = true;
        }
        private void MoveDownLayer(int index)
        {
            if (index == Pro.LayerList.Count-1)
                return;
            Layer lOldRight = Pro.LayerList[index + 1];
            Layer lOld = Pro.LayerList[index];
            Pro.LayerList[index + 1] = lOld;
            Pro.LayerList[index] = lOldRight;
            if (Pro.TargetLayerIndex == index)
                Pro.TargetLayerIndex += 1;
            else if (Pro.TargetLayerIndex == index + 1)
                Pro.TargetLayerIndex -= 1;
            RefreshTreeView();
            tv_navigation.SelectedNode = tn_Layer.Nodes[index + 1];
            Modified = true;
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void mi_Material_Load_Click(object sender, EventArgs e)
        {
            LoadMaterial();
        }

        private void mi_MaterialItem_Show_Click(object sender, EventArgs e)
        {
            ShowMaterial(tv_navigation.SelectedNode.Index);
        }

        private void mi_MaterialItem_Delete_Click(object sender, EventArgs e)
        {
            DeleteMaterial(tv_navigation.SelectedNode.Index);
        }

        private void OnTvNavigationKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void OnTvNavKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                OnTvNavigationDoubleClick(sender, e);
            }
            else if(e.KeyCode==Keys.Up)
            {
                if (e.Control && tv_navigation.SelectedNode.Name == STR_LayerItem)
                    MoveUpLayer(tv_navigation.SelectedNode.Index);
            }
            else if(e.KeyCode==Keys.Down)
            {
                if (e.Control && tv_navigation.SelectedNode.Name == STR_LayerItem)
                    MoveDownLayer(tv_navigation.SelectedNode.Index);
            }
            else if(e.KeyCode==Keys.Delete)
            {
                switch (tv_navigation.SelectedNode.Name)
                {
                    case STR_MaterialItem:
                        DeleteMaterial(tv_navigation.SelectedNode.Index);
                        break;
                    case STR_LayerItem:
                        DeleteLayer(tv_navigation.SelectedNode.Index);
                        break;
                }
            }
            
            
        }

        private void mi_Layer_Add_Click(object sender, EventArgs e)
        {
            AddLayer();
        }
        
        private void mi_LayerItem_Details_Click(object sender, EventArgs e)
        {
            ShowLayer(tv_navigation.SelectedNode.Index);
        }

        private void mi_LayerItem_Delete_Click(object sender, EventArgs e)
        {
            DeleteLayer(tv_navigation.SelectedNode.Index);
        }

        private void mi_LayerItem_Up_Click(object sender, EventArgs e)
        {
            MoveUpLayer(tv_navigation.SelectedNode.Index);
        }

        private void mi_LayerItem_Down_Click(object sender, EventArgs e)
        {
            MoveDownLayer(tv_navigation.SelectedNode.Index);
        }

        private void mi_File_New_Click(object sender, EventArgs e)
        {
            NewProject();
        }
        
        
        private void mi_File_Load_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void mi_File_Save_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void mi_File_SaveAs_Click(object sender, EventArgs e)
        {
            SaveProjecteAs();
        }

        private void mi_File_Exit_Click(object sender, EventArgs e)
        {
            if(Modified)
                if(MessageBox.Show("当前工程未保存，您要保存当前工程吗？","询问",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    SaveProject();
                }
            Close();
        }
        private void SaveProject()
        {
            if (Pro.OwnerId != User.CurrentUser.Id)
            {
                MessageBox.Show("该工程不为您所有，您将保存为自己的副本", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pro.Id = 0;
                Pro.OwnerId = User.CurrentUser.Id;
                ProjectManager.Insert(Pro);
            }
            else
            {
                if(Pro.Id==0)
                    ProjectManager.Insert(Pro);
                else
                    ProjectManager.Update(Pro);
            
            }
            Modified = false;   
        }
        private void SaveProjecteAs()
        {
            ProjectSaveAsForm psaf = new ProjectSaveAsForm();
            psaf.ProjectName = Pro.Name;
            psaf.Share = Pro.Share;
            if(psaf.ShowDialog()==DialogResult.OK)
            {
                Pro.Name = psaf.ProjectName;
                Pro.Share = psaf.Share;
                Pro.Id = 0;
                pro.OwnerId = User.CurrentUser.Id;
                SaveProject();
                RefreshTreeView();
            }
            
            
        }
        private void NewProject()
        {
            if (Modified)
            {
                DialogResult dr = MessageBox.Show("当前工程已经更改，是否更新?", "选择", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    return;
                else if (dr == DialogResult.Yes)
                {
                    SaveProject();
                }
            }
            Pro = ProjectManager.New();
            Pro.OwnerId = User.CurrentUser.Id;
            ShowProjectParameter();
            RefreshTreeView();
            Modified = false;
        }
        private void LoadProject()
        {
            ProjectLoadForm plf = new ProjectLoadForm();
            plf.LoadEvent += new ProjectLoadForm.LoadEventHandler(OnLoadProject);
            plf.Show();
        }
        private void OnLoadProject(Project _pro)
        {
            if (Modified)
            {
                DialogResult dr = MessageBox.Show("当前工程已经更改，是否更新?", "选择", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    return;
                else if (dr == DialogResult.Yes)
                {
                    SaveProject();
                }
            }
            Pro = _pro;
            RefreshTreeView();
            Modified = false;
        }
    }
}
