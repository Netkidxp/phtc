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
using PHTC.Reporter;
using PHTC.DB;
using System.IO;
using System.Diagnostics;
using System.Threading;
using PHTC.UpdateLib;

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
        private const string STR_ReportWord = "N_ReportWord";
        private const string STR_ReportWordItem = "N_ReportWordItem";
        private const string STR_ReportHtml = "N_ReportHtml";
        private const string STR_ReportHtmlItem = "N_ReportHtmlItem";
        private delegate void RefreshTvAndMd();
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
        private TreeNode tn_ReportWord;
        private TreeNode tn_ReportHtml;
        /// <summary>
        /// 
        /// </summary>
        private Project pro;
        private string CurrentFileName = "";
        private bool IsSolving;
        private string[] Args;
        private List<ReportTemplete> WordReportTempletes;
        private List<ReportTemplete> HtmlReportTempletes;
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
        public ProjectForm(string[] args)
        {
            
            InitializeComponent();
            IsSolving = false;
            Args = args;
        }
        private void SetUserLevel()
        {
            User u = User.CurrentUser;
            if(u.Level<4)
            {
                mi_manangement.Visible = true;
                if (u.Level < 4)
                {
                    mi_management_user.Visible = true;
                }
                else
                    mi_management_user.Visible = false;
                if (u.Level < 4)
                {
                    mi_management_report.Visible = true;
                }
                else
                    mi_management_report.Visible = false;
                if (u.Level < 4)
                {
                    mi_manage_projecttemplete.Visible = true;
                }
                else
                    mi_manage_projecttemplete.Visible = false;
            }
            else
                mi_manangement.Visible = false;
        }
        private void InitControls()
        {
            CheckForIllegalCrossThreadCalls = false;
            SetUserLevel();
            pro = ProjectManager.New();
            pro.OwnerId = User.CurrentUser.Id;
            tn_Project = tv_navigation.Nodes[STR_Project];
            tn_Material = tn_Project.Nodes[STR_Material];
            tn_ModelParameter = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_ModelParameter];
            tn_HotfaceParameter = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_HotfaceParameter];
            tn_Layer = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_Layer];
            tn_ColdfaceBoundary = tn_Project.Nodes[STR_CalculateModel].Nodes[STR_ColdfaceBoundary];
            tn_SolveParameter = tn_Project.Nodes[STR_SolveParameter];
            tn_ReportWord = tn_Project.Nodes[STR_Result].Nodes[STR_ReportWord];
            tn_ReportHtml = tn_Project.Nodes[STR_Result].Nodes[STR_ReportHtml];
            mainDisplay1.Pro = Pro;
            mainDisplay1.OnHotfaceClick += new MainDisplay.HotfaceDbClickHandler(ShowHotfaceParameter);
            mainDisplay1.OnColdfaceClick += new MainDisplay.ColdfaceDbClickHandler(ShowColdfaceBoudary);
            mainDisplay1.OnLayerDbClick += new MainDisplay.LayerDbClickHandler(ShowLayer);
            RefreshTreeView();
            db_user.Text = User.CurrentUser.Name;
            tsl_status.Text = "就绪";
        }
        private bool CheckUpdate()
        {
            string basedir = System.Windows.Forms.Application.StartupPath;
            AutoUpdater updater = new AutoUpdater(basedir);
            return updater.CheckUpdate(null);
        }
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            if(CheckUpdate())
            {
                Close();
                UpdateApp();
            }
            InitControls();
            tv_navigation.ExpandAll();
            if(Args.Length>0)
                if(File.Exists(Args[0]))
                {
                    Project p = Project.FromFile(Args[0]);
                    if (p == null)
                    {
                        MessageBox.Show("该文件格式不正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (p.OwnerId != User.CurrentUser.Id && !p.Share)
                    {
                        MessageBox.Show("该工程文件不为您所有，并且被设置为不共享", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Pro = p;
                    Pro.Id = 0;
                    CurrentFileName = Args[0];
                    RefreshTreeView();
                    Modified = false;
                    ClearChartAndConsole();
                }
            //ThreadPool.QueueUserWorkItem(new WaitCallback(CheckUpdate), false);
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
                TreeNode tn = new TreeNode(mat.Name+"("+mat.Index.ToString()+")");
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
            string sHotfaceTemperature = "热面（温度:"+GlobalTool.K2C(Pro.HotfaceTemperature).ToString()+"℃)";
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
                        sThickness = (l.Thickness*1000).ToString()+"mm";
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
            if (Pro.ColdfaceBoundary is Class3Boundary)
                tn_ColdfaceBoundary.Text = "冷面(第三类边界)";
            else if (Pro.ColdfaceBoundary is Class2Boundary)
                tn_ColdfaceBoundary.Text = "冷面(第二类边界)";
            else
                tn_ColdfaceBoundary.Text = "冷面(第一类边界)";
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
            mainDisplay1.Pro = Pro;
            mainDisplay1.Refresh();
            RefreshReportTempleteNode();
            UpdateDetail();
        }
        private void RefreshReportTempleteNode()
        {
            WordReportTempletes = DBReportTempleteAdapter.ListAllTempleteWithType(0);
            HtmlReportTempletes = DBReportTempleteAdapter.ListAllTempleteWithType(1);
            if (WordReportTempletes != null)
            {
                tn_ReportWord.Nodes.Clear();
                mi_result_word.DropDownItems.Clear();
                foreach (ReportTemplete rt in WordReportTempletes)
                {
                    TreeNode tn = new TreeNode(rt.Name, 35, 35);
                    tn.Name = STR_ReportWordItem;
                    tn_ReportWord.Nodes.Add(tn);
                    ToolStripMenuItem mi = new ToolStripMenuItem(rt.Name);
                    mi.Click += new EventHandler(mi_result_word_Click);
                    mi_result_word.DropDownItems.Add(mi);
                }
            }
            /*if (HtmlReportTempletes != null)
            {
                tn_ReportHtml.Nodes.Clear();
                foreach (ReportTemplete rt in HtmlReportTempletes)
                {
                    TreeNode tn = new TreeNode(rt.Name, 34, 34);
                    tn.Name = STR_ReportHtmlItem;
                    tn_ReportWord.Nodes.Add(tn);
                }
            }*/
        }
        private void RefreshProLayersMaterials()
        {
            foreach(Layer l in Pro.LayerList)
            {
                int id = l.Material.Index;
                l.Material = GetLoaclMaterial(id);
            }
        }
        private Material GetLoaclMaterial(int id)
        {
            Material m = null;
            foreach(Material mat in Pro.MaterialList)
            {
                if (mat.Index == id)
                    m = mat;
            }
            return m;
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
                case STR_ReportWordItem:
                    ReportWord(tv_navigation.SelectedNode.Index);
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 

        private string FormatTemperature(double v)
        {
            return string.Format("{0:0000.000}", v);
        }
        private void Log(string information,Color color)
        {
            this.Invoke((EventHandler)delegate {
                rtb_log.SelectionColor = color;
                rtb_log.AppendText(information);
                rtb_log.Select(rtb_log.TextLength, 1);
                rtb_log.ScrollToCaret();
            });
        }
        private void Detail(string information,Color color)
        {
            this.Invoke((EventHandler)delegate {
                rtb_detail.SelectionColor = color;
                rtb_detail.AppendText(information);
            });
        }
        private void UpdateDetail()
        {
            this.Invoke((EventHandler)delegate {
            rtb_detail.Clear();
            });
            string log = "各层温度信息:\r\n";
            Detail(log, Color.DarkBlue);
            log = "  层名称\t\t最高温度[℃]\t最低温度[℃]\t热阻[K/W]\r\n";
            foreach (Layer l in Pro.LayerList)
            {
                log += "  " + l.Name + "\t\t" + FormatTemperature(l.HighTemperature - 273.15) + "\t" + FormatTemperature(l.LowTemperature - 273.15) + "\t" + l.HeatResistance.ToString("F3") + "\r\n";
            }
            log += "  " + "冷面温度[℃]:" + FormatTemperature(Pro.ColdfaceBoundary.Temperature - 273.15) + "\t\t\t热流量[W]:" + Pro.ColdfaceBoundary.Heatflow.ToString("F3") + "\r\n";
            Detail(log, Color.Gray);
            if(Pro.Mode==CalculationMode.Thickness)
            {
                Detail("厚度计算信息:\r\n", Color.DarkBlue);
                if(Pro.LayerList.Count>Pro.TargetLayerIndex)
                {
                    log = string.Format("  目标层:{0}\t厚度[mm]:{1}\r\n", Pro.LayerList[Pro.TargetLayerIndex].Name, Pro.LayerList[Pro.TargetLayerIndex].Thickness * 1000.0);
                    Detail(log, Color.Gray);
                }
                    
            }
            
        }
        private void LogUpdateTemperatureSolver(TemperatureSolverC1 solver)
        {
            
            string log = "  温度计算第"+solver.CurrentStep.ToString()+"步:\r\n";
            Log(log, Color.DarkBlue);
            log = "  层名称\t\t最高温度[℃]\t最低温度[℃]\t热阻[K/W]\r\n";
            foreach (Layer l in solver.CurrentCalculate.LayerList)
            {
                log += "  "+l.Name + "\t\t" + FormatTemperature(l.HighTemperature-273.15) + "\t" + FormatTemperature(l.LowTemperature-273.15) + "\t"+l.HeatResistance.ToString("F3")+"\r\n";
            }
            log += "  "+ "冷面温度[℃]:" + FormatTemperature(solver.CurrentCalculate.Boundary.Temperature-273.15) + "\t\t\t热流量[W]:" + solver.CurrentCalculate.Boundary.Heatflow.ToString("F3") + "\r\n";
            Log(log, Color.Gray);
            
        }
        private void LogUpdateThicknessSolver(ThicknessSolver solver)
        {
            string log = "  厚度计算第" + solver.ThicknessSolveStep.ToString() + "步:\r\n";
            Log(log, Color.DarkBlue);
            log = string.Format("  目标层:{0}\t厚度[mm]:{1}\t残差:{2}\r\n", solver.TemperatureSolver.CurrentCalculate.LayerList[solver.ThicknessCalculate.TargetLayerIndex].Name, solver.TargetLayerThickness * 1000.0, solver.ThicknessSolverResidual);
            Log(log, Color.Gray);
        }
        private void ChartUpdateTemperatureSolver(TemperatureSolverC1 solver)
        {
            ct_temperature.Series[0].Points.AddY(solver.CurrentResidual);
        }
        private void ChartUpdateThicknessSolver(ThicknessSolver solver)
        {
            ct_thickness.Series[0].Points.AddY(solver.ThicknessSolverResidual);
        }
        private void OnTemperatureSolverInitlized(TemperatureSolverC1 solver)
        {

        }
        private void OnTemperatureSolverUpdated(TemperatureSolverC1 solver)
        {
            ChartUpdateTemperatureSolver(solver);
            LogUpdateTemperatureSolver(solver);
            mainDisplay1.Refresh();
            UpdateDetail();
        }
        private void OnTemperatureSolverEnded(TemperatureSolverC1 solver)
        {
            Log("温度解算器结束\r\n", Color.Red);
        }
        private void OnTemperatureSolverStarted(TemperatureSolverC1 solver)
        {
            Log("温度解算器开始计算\r\n", Color.Red);
        }
        private void OnThicknessSolverStarted(ThicknessSolver solver)
        {
            Log("厚度解算器开始计算\r\n", Color.Red);
        }
        private void OnThicknessSolverUpdated(ThicknessSolver solver)
        {
            ChartUpdateThicknessSolver(solver);
            mainDisplay1.Refresh();
            LogUpdateThicknessSolver(solver);
            UpdateDetail();
        }
        private void OnThicknessSolverEnded(ThicknessSolver solver)
        {
            Log("厚度解算器结束\r\n", Color.Red);
        }
        
        private void ClearChartAndConsole()
        {
            ct_thickness.Series[0].Points.Clear();
            ct_temperature.Series[0].Points.Clear();
            rtb_log.Clear();
        }

        private void SolveProc(object o)
        {
            ClearChartAndConsole();
            TemperatureCalculate tc = new TemperatureCalculate(Pro.HotfaceTemperature, Pro.SizeRorW, Pro.SizeRorW, Pro.SizeLorH, Pro.ColdfaceBoundary, Pro.LayerList);
            if (Pro.Mode == CalculationMode.Temperature)
            {
                TemperatureSolverC1 solver = TemperatureSolverFactory.CreateSolver(tc);

                solver.SolveStartEvent += new SolveStartEventHandler(OnTemperatureSolverStarted);
                solver.SolveEndEvent += new SolveEndEventHandler(OnTemperatureSolverEnded);
                solver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdated);

                solver.InitalizeTemperature();
                solver.Solve(Pro.TemperatureSolverControlParameter);
            }
            else
            {
                ThicknessCalculate thc = new ThicknessCalculate(tc, Pro.TargetLayerIndex, Pro.TargetValue, Pro.TemperatureSolverControlParameter, Pro.ThicknessSolverControlParameter);
                ThicknessSolver solver = ThicknessSolverFactory.CreateSolver(thc);
                solver.SolveStartEvent += new ThicknessSolverStartEventHandler(OnThicknessSolverStarted);
                solver.SolveUpdateEvent += new ThicknessSolverUpdateEventHandler(OnThicknessSolverUpdated);
                solver.SolveStopEvent += new ThicknessSolverStopEventHandler(OnThicknessSolverEnded);
                solver.TemperatureSolver.SolveStartEvent += new SolveStartEventHandler(OnTemperatureSolverStarted);
                solver.TemperatureSolver.UpdateTemperatureEndEvent += new UpdateTemperatureEndEventHandler(OnTemperatureSolverUpdated);
                solver.TemperatureSolver.SolveEndEvent += new SolveEndEventHandler(OnTemperatureSolverEnded);

                solver.Solve();
            }
            BehindSolve();
        }
        private void Solve()
        {
            if (!Pro.CheckValidition())
            {
                Log("工程合法性验证失败，错误：\r\n", Color.Gray);
                Log(Pro.ValidityInformation,Color.Red);
                tsl_status.Text = "工程合法性验证失败";
                MessageBox.Show(Pro.ValidityInformation, "工程合法性验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tsl_status.Text = "准备计算";
                Log("工程合法性验证成功，准备计算...\r\n", Color.Gray);
            }
            BeforeSolve();
            ThreadPool.QueueUserWorkItem(new WaitCallback(SolveProc), false);
        }
        private void BeforeSolve()
        {
            
            ms_main.Enabled = false;
            tv_navigation.Enabled = false;
            ss_bottom.Enabled = false;
            tsl_status.Text = "正在计算...";
            IsSolving = true;
        }
        private void BehindSolve()
        {
            ms_main.Enabled = true;
            tv_navigation.Enabled = true;
            ss_bottom.Enabled = true;
            Pro.LastSolveTime = DateTime.Now;
            RefreshTvAndMd refresh = new RefreshTvAndMd(RefreshTreeView);
            this.Invoke(refresh);
            Modified = true;
            tsl_status.Text = "就绪";
            IsSolving = false;
        }
        private void AbortSolve()
        {

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
            MaterialManageForm mmf = new MaterialManageForm(false);
            mmf.LoadEvent += new LoadEventHandler(MaterialLoadEventHandle);
            mmf.Show();
        }
        private void MaterialLoadEventHandle(Material mat)
        {
            Random r = new Random();
            int rid = r.Next();
            mat.Index = rid;
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

            MaterialDetailsForm mdf = new MaterialDetailsForm(Pro.MaterialList[index], MaterialDetailsForm.ButtonType.Modify);
            if(mdf.ShowDialog()==DialogResult.OK)
            {
                Pro.MaterialList[index] = mdf.Material;
                RefreshProLayersMaterials();
                Modified = true;
                RefreshTreeView();
            }    
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
            Layer layer = new Layer(Pro.MaterialList[0], 0.2,1,1);
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
            //待处理
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
            SaveProjectCloud();
        }

        private void mi_File_SaveAs_Click(object sender, EventArgs e)
        {
            SaveProjecteAsCloud();
        }

        private void mi_File_Exit_Click(object sender, EventArgs e)
        {
            
            Close();
        }
        private void SaveProjectCloud()
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
            CurrentFileName = "";
        }
        private void SaveProjecteAsCloud()
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
                SaveProjectCloud();
                RefreshTreeView();
            }
            CurrentFileName = "";
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
                    if (CurrentFileName == "")
                        SaveProjectCloud();
                    else
                        SaveProjectLocal();
                }
            }
            Pro = ProjectManager.New();
            Pro.LastSolveTime =DateTime.MinValue;
            Pro.OwnerId = User.CurrentUser.Id;
            //ShowProjectParameter();
            RefreshTreeView();
            Modified = false;
            ClearChartAndConsole();
            CurrentFileName = "";
            tsl_status.Text = "就绪";
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
                    if (CurrentFileName == "")
                        SaveProjectCloud();
                    else
                        SaveProjectLocal();
                }
            }
            Pro = _pro;
            RefreshTreeView();
            Modified = false;
            ClearChartAndConsole();
            CurrentFileName = "";
            tsl_status.Text = "就绪";
        }
        private void SaveProjectLocal()
        {
            if(CurrentFileName=="")
            {
                SaveProjectAsLocal();
            }
            else
            {
                Project p = (Project)GlobalTool.Clone(Pro);
                p.Id = 0;
                p.OwnerId = User.CurrentUser.Id;
                bool res=p.ToFile(CurrentFileName);
                if(!res)
                {
                    MessageBox.Show("保存文件失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Pro = p;
                    RefreshTreeView();
                    Modified = false;
                }
                
            }
        }
        private void SaveProjectAsLocal()
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.OverwritePrompt = true;
            sd.AddExtension = true;
            sd.DefaultExt = "pht";
            sd.Filter = "PHTC工程文件|*.pht";
            if (sd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Project p = (Project)GlobalTool.Clone(Pro);
            p.Id = 0;
            p.OwnerId = User.CurrentUser.Id;
            bool res = p.ToFile(sd.FileName);
            if (!res)
            {
                MessageBox.Show("保存文件失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Pro = p;
                CurrentFileName = sd.FileName;
                RefreshTreeView();
                Modified = false;
            }
        }
        private void OpenProject()
        {
            if (Modified)
            {
                DialogResult dr = MessageBox.Show("当前工程已经更改，是否更新?", "选择", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    return;
                else if (dr == DialogResult.Yes)
                {
                    if (CurrentFileName == "")
                        SaveProjectCloud();
                    else
                        SaveProjectLocal();
                }
            }
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "PHTC工程文件|*.pht";
            if(fd.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            
            Project p = Project.FromFile(fd.FileName);
            if(p==null)
            {
                MessageBox.Show("该文件格式不正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(p.OwnerId!=User.CurrentUser.Id&&!p.Share)
            {
                MessageBox.Show("该工程文件不为您所有，并且被设置为不共享", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Pro = p;
            Pro.Id = 0;
            CurrentFileName = fd.FileName;
            RefreshTreeView();
            Modified = false;
            ClearChartAndConsole();
            tsl_status.Text = "就绪";
        }
        private void mi_report_refresh_Click(object sender, EventArgs e)
        {
            
            RefreshReportTempleteNode();

        }
        private string WriteDpImage()
        {
            try
            {
                Random r = new Random();
                string path = TempPath + "png";
                Bitmap bp = new Bitmap(mainDisplay1.Bounds.Width, mainDisplay1.Bounds.Height);
                mainDisplay1.DrawToBitmap(bp, mainDisplay1.Bounds);
                bp.Save(path);
                return path;
            }
            catch(Exception)
            {
                return null;
            }
        }
        private void ReportWord(int index)
        {
            ReportTemplete rt = WordReportTempletes[index];
            string templetePath = WriteReportTempleteFile(rt.Id, "dot");
            if(templetePath == null)
            {
                MessageBox.Show("载入模板文件失败，请检查网络连接或者联系管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string reportPath = TempPath + "docx";
            string imgPath = WriteDpImage();
            if (imgPath == null)
            {
                MessageBox.Show("写入图片失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WordReporter wp = new WordReporter(Pro, templetePath, reportPath, imgPath);
            wp.Report();
            System.Diagnostics.Process.Start("Explorer.exe", reportPath);
        }
        private string TempPath
        {
            get
            {
                Random r = new Random();
                string path = System.IO.Path.GetTempPath() + r.Next().ToString() + ".";
                return path;
            }
        }
        private string WriteReportTempleteFile(int id,string extname)
        {
            try
            {
                byte[] buffer = DBReportTempleteAdapter.LoadRawWithId(id);
                Random r = new Random();
                string path= TempPath+extname;
                FileStream fs = new FileStream(path, FileMode.Create);
                fs.Write(buffer, 0, buffer.Length);
                fs.Flush();
                fs.Close();
                return path;
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        private void LogOff()
        {
            if (Modified)
            {
                DialogResult dr = MessageBox.Show("当前工程已经更改，是否更新?", "选择", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    return;
                else if (dr == DialogResult.Yes)
                {
                    SaveProjectCloud();
                }
            }
            LoginForm lf = new LoginForm();
            while (lf.ShowDialog() == DialogResult.OK)
            {
                User u = UserManager.LoginOn(lf.LoginName, lf.LoginPassword);
                if (u != null)
                {
                    User.CurrentUser = u;
                    UserManager.WriteRememberName(lf.LoginName);
                    if (lf.Remember)
                    {
                        UserManager.WriteRememberPassword(lf.LoginPassword);
                    }
                    else
                    {
                        UserManager.DeleteRememberPassword();
                    }
                    InitControls();
                    return;
                }
                else
                {
                    MessageBox.Show("用户不存在或者密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mi_logoff_Click(object sender, EventArgs e)
        {
            LogOff();
        }
        private void ChangePassword()
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            while (cpf.ShowDialog() == DialogResult.OK)
            {
                if (UserManager.ValidateUser(User.CurrentUser.Login_id, cpf.OldPassword))
                {
                    bool res = UserManager.ChangePassword(User.CurrentUser.Login_id, cpf.OldPassword, cpf.Password1);
                    if (res)
                    {
                        MessageBox.Show("修改密码成功", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        GlobalTool.LogError("ProjectForm.ChangePassword", "数据库操作失败，请联系管理员", true);
                        return;
                    }
                }
                else
                    MessageBox.Show("您输入的原密码错误", "密码错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mi_changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void mi_user_loginoff_Click(object sender, EventArgs e)
        {
            mi_logoff_Click(sender, e);
        }

        private void mi_user_changepassword_Click(object sender, EventArgs e)
        {
            mi_changepassword_Click(sender, e);
        }

        private void mi_user_exit_Click(object sender, EventArgs e)
        {
            mi_File_Exit_Click(sender, e);
        }

        private void mi_material_loadin_Click(object sender, EventArgs e)
        {
            mi_Material_Load_Click(sender, e);
        }

        private void cmi_material_new_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rid = r.Next();
            Material mat = Material.Default;
            mat.Index = rid;
            MaterialDetailsForm mdf = new MaterialDetailsForm(mat, MaterialDetailsForm.ButtonType.Modify);
            if (mdf.ShowDialog() == DialogResult.OK)
            {
                Pro.MaterialList.Add(mdf.Material);
                RefreshProLayersMaterials();
                Modified = true;
                RefreshTreeView();
            }
        }

        private void mi_material_new_Click(object sender, EventArgs e)
        {
            cmi_material_new_Click(sender, e);
        }

        private void OnMiMaterialDropDownOpening(object sender, EventArgs e)
        {
            mi_material_delete.Visible = 
                mi_material_detail.Visible = 
                mi_material_update.Visible = 
                mi_material_copy.Visible = 
                IsSelectedNodeName(STR_MaterialItem);
        }
        private bool IsSelectedNodeName(string name)
        {
            TreeNode n = tv_navigation.SelectedNode;
            if (n != null)
                if (n.Name == name)
                    return true;
            return false;
        }
        private void cmi_materialitem_copy_Click(object sender, EventArgs e)
        {
            Material mat = Pro.MaterialList[tv_navigation.SelectedNode.Index];
            Material nmat = (Material)GlobalTool.Clone(mat);
            Random r = new Random();
            int rid = r.Next();
            nmat.Name = nmat.Name + "副本";
            nmat.Index = r.Next();
            nmat.Create_time = nmat.Modify_time = DateTime.Now;
            Pro.MaterialList.Add(nmat);
            RefreshTreeView();
            Modified = true;
        }

        private void cmi_materialitem_update_Click(object sender, EventArgs e)
        {
            Material mat = Pro.MaterialList[tv_navigation.SelectedNode.Index];
            bool res = DbMaterialAdapter.Insert(mat);
            if (!res)
            {
                GlobalTool.LogError("ProjecForm.Update", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
            }
            else
            {
                MessageBox.Show("上传成功", "上传成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mi_material_update_Click(object sender, EventArgs e)
        {
            cmi_materialitem_update_Click(sender, e);
        }

        private void mi_material_detail_Click(object sender, EventArgs e)
        {
            mi_MaterialItem_Show_Click(sender, e);
        }

        private void mi_material_delete_Click(object sender, EventArgs e)
        {
            mi_MaterialItem_Delete_Click(sender, e);
        }

        private void mi_material_copy_Click(object sender, EventArgs e)
        {
            cmi_materialitem_copy_Click(sender, e);
        }

        private void mi_material_managelib_Click(object sender, EventArgs e)
        {
            MaterialManageForm mmf = new MaterialManageForm(true);
            mmf.Show();
        }

        private void mi_calculatemode_hotface_Click(object sender, EventArgs e)
        {
            ShowHotfaceParameter();
        }

        private void mi_calculatemode_coldboundary_Click(object sender, EventArgs e)
        {
            ShowColdfaceBoudary();
        }

        private void OnMiLayerDropDownOpening(object sender, EventArgs e)
        {
            mi_layer_delete.Visible
                = mi_layer_detail.Visible
                = mi_layer_move.Visible
                = IsSelectedNodeName(STR_LayerItem);
        }

        private void mi_layer_new_Click(object sender, EventArgs e)
        {
            AddLayer();
        }

        private void mi_layer_detail_Click(object sender, EventArgs e)
        {
            mi_LayerItem_Details_Click(sender, e);

        }

        private void mi_layer_delete_Click(object sender, EventArgs e)
        {
            mi_LayerItem_Delete_Click(sender, e);
        }

        private void mi_layer_move_up_Click(object sender, EventArgs e)
        {
            mi_LayerItem_Up_Click(sender, e);

        }

        private void mi_layer_move_down_Click(object sender, EventArgs e)
        {
            mi_LayerItem_Down_Click(sender, e);
        }

        private void OnMiSolveParameterDropDownOpening(object sender, EventArgs e)
        {
            mi_solveparameter_thickness.Visible = (Pro.Mode == CalculationMode.Thickness);
        }

        private void mi_solveparameter_temperature_Click(object sender, EventArgs e)
        {
            ShowTemperatureSolveParameter();
        }

        private void mi_solveparameter_thickness_Click(object sender, EventArgs e)
        {
            ShowThicknessSolveParameter();
        }

        private void mi_solveparameter_laydiff_Click(object sender, EventArgs e)
        {
            ShowLayDifferentialCount();
        }

        private void mi_solve_run_Click(object sender, EventArgs e)
        {
            Solve();
        }
        private void mi_result_word_Click(object sender, EventArgs e)
        {
            int index = -1;
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            for(int i=0;i<WordReportTempletes.Count;i++)
            {
                if (WordReportTempletes[i].Name == mi.Text)
                {
                    index = i;
                    break;
                }     
            }
            if(index!=-1)
            {
                ReportWord(index);
            }
        }

        private void mi_result_refreshreporter_Click(object sender, EventArgs e)
        {
            mi_report_refresh_Click(sender, e);
        }
        private void UpdateApp()
        {
            string temp = Path.GetTempFileName() + ".exe";
            string basedir = System.Windows.Forms.Application.StartupPath;
            string app = Path.Combine(basedir, "update.exe");
            if (File.Exists(app))
            {
                File.Copy(app, temp, true);
                File.Copy(Path.Combine(basedir, "PHTC.UpdateLib.dll"), Path.Combine(Path.GetDirectoryName(temp), "PHTC.UpdateLib.dll"), true);
            }
            Process.Start(temp, "\"" + basedir + "\"");
        }
        private void mi_help_update_Click(object sender, EventArgs e)
        {
            //mi_File_Exit_Click(sender, e);
            //UpdateApp();
            if (CheckUpdate())
            {
                mi_File_Exit_Click(sender, e);
                UpdateApp();
            }
            else
            {
                MessageBox.Show("您的软件是最新版");
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsSolving)
            {
                MessageBox.Show("正在计算，不能关闭", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
            if (Modified)
            {
                DialogResult dr = MessageBox.Show("当前工程未保存，您要保存当前工程吗？", "询问", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    e.Cancel = true;
                else if(dr==DialogResult.Yes)
                {
                    if (CurrentFileName == "")
                        SaveProjectCloud();
                    else
                        SaveProjectLocal();
                }
            }
        }

        private void mi_File_Open_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void mi_File_SaveLocal_Click(object sender, EventArgs e)
        {
            SaveProjectLocal();
        }

        private void mi_File_SaveAsLocal_Click(object sender, EventArgs e)
        {
            SaveProjectAsLocal();
        }

        private void mi_help_about_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void mi_management_report_Click(object sender, EventArgs e)
        {
            ReportTempleteManager rtm = new ReportTempleteManager();
            rtm.Show();
        }

        private void mi_management_user_Click(object sender, EventArgs e)
        {
            UserManageForm uf = new UserManageForm();
            uf.Show();
        }

        private void mi_manage_projecttemplete_Click(object sender, EventArgs e)
        {
            ProjectTempleteManageForm ptf = new ProjectTempleteManageForm(this.Pro);
            ptf.ShowDialog();
        }

        private void mi_project_templetenew_Click(object sender, EventArgs e)
        {
            if (Modified)
            {
                DialogResult dr = MessageBox.Show("当前工程已经更改，是否更新?", "选择", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                    return;
                else if (dr == DialogResult.Yes)
                {
                    if (CurrentFileName == "")
                        SaveProjectCloud();
                    else
                        SaveProjectLocal();
                }
            }
            ProjectTempleteForm ptf = new ProjectTempleteForm();
            if (ptf.ShowDialog() == DialogResult.OK)
            {
                Project p = ptf.Pro;
                if (p == null)
                {
                    MessageBox.Show("模板载入失败，请检查网络并联系管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                p.Share = true;
                p.OwnerId = User.CurrentUser.Id;
                Pro = p;
            }
            Pro.LastSolveTime = DateTime.MinValue;
            RefreshTreeView();
            Modified = false;
            ClearChartAndConsole();
            CurrentFileName = "";
            tsl_status.Text = "就绪";
        }

        private void mi_help_doc_Click(object sender, EventArgs e)
        {
            string helpname = "help.pdf";
            string helpdoc = Path.Combine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase,helpname);
            if (File.Exists(helpdoc))
            {
                System.Diagnostics.Process.Start("Explorer.exe", helpdoc);
            }
            else
                MessageBox.Show("无法找到"+helpname,"错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
