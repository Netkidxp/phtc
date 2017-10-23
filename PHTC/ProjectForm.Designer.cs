namespace PHTC
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("材料参数", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("热面参数", 25, 25);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("第一层", 28, 28);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("第二层", 28, 28);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("层列表", 27, 27, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("冷面边界", 14, 14);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("计算模型", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("温度解算收敛准则", 31, 31);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("层微分", 13, 13);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("解算参数", 12, 12, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("计算", 24, 24);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Word报告", 35, 35);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("结果", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("新建计算", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode9,
            treeNode12,
            treeNode13,
            treeNode15});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cms_N_Material = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_Material_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.cmi_material_new = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_N_Layer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_Layer_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_N_ReportWordOrHtml = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_report_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.il_treeview = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_navigation = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.mainDisplay1 = new PHTC.MainDisplay();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_detail = new System.Windows.Forms.TabPage();
            this.rtb_detail = new System.Windows.Forms.RichTextBox();
            this.tp_moniter = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ct_temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_thickness = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tp_console = new System.Windows.Forms.TabPage();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.il_ui = new System.Windows.Forms.ImageList(this.components);
            this.cms_N_MarerialItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_MaterialItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_MaterialItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cmi_materialitem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmi_materialitem_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_N_LayerItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_LayerItem_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_LayerItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_LayerItem_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_LayerItem_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_user_loginoff = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_user_changepassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_user_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_project_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_project_templetenew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_File_SaveLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_SaveAsLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_material = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_material_loadin = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_material_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_material_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_material_detail = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_material_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_material_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_material_managelib = new System.Windows.Forms.ToolStripMenuItem();
            this.计算模型CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_calculatemode_hotface = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_calculatemode_coldboundary = new System.Windows.Forms.ToolStripMenuItem();
            this.层管理LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_layer_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_layer_detail = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_layer_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_layer_move = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_layer_move_up = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_layer_move_down = new System.Windows.Forms.ToolStripMenuItem();
            this.解算参数SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_solveparameter_temperature = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_solveparameter_thickness = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_solveparameter_laydiff = new System.Windows.Forms.ToolStripMenuItem();
            this.解算SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_solve_run = new System.Windows.Forms.ToolStripMenuItem();
            this.结果RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_result_word = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_result_refreshreporter = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_help_doc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_help_update = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_manangement = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_management_user = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_management_report = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_manage_projecttemplete = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_bottom = new System.Windows.Forms.StatusStrip();
            this.db_user = new System.Windows.Forms.ToolStripDropDownButton();
            this.mi_logoff = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_changepassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cms_N_Material.SuspendLayout();
            this.cms_N_Layer.SuspendLayout();
            this.cms_N_ReportWordOrHtml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_detail.SuspendLayout();
            this.tp_moniter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_thickness)).BeginInit();
            this.tp_console.SuspendLayout();
            this.cms_N_MarerialItem.SuspendLayout();
            this.cms_N_LayerItem.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.ss_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_N_Material
            // 
            this.cms_N_Material.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_N_Material.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Material_Load,
            this.cmi_material_new});
            this.cms_N_Material.Name = "cms_N_Material";
            this.cms_N_Material.Size = new System.Drawing.Size(160, 48);
            // 
            // mi_Material_Load
            // 
            this.mi_Material_Load.Name = "mi_Material_Load";
            this.mi_Material_Load.Size = new System.Drawing.Size(159, 22);
            this.mi_Material_Load.Text = "数据库载入...(&L)";
            this.mi_Material_Load.Click += new System.EventHandler(this.mi_Material_Load_Click);
            // 
            // cmi_material_new
            // 
            this.cmi_material_new.Name = "cmi_material_new";
            this.cmi_material_new.Size = new System.Drawing.Size(159, 22);
            this.cmi_material_new.Text = "新建...(&N)";
            this.cmi_material_new.Click += new System.EventHandler(this.cmi_material_new_Click);
            // 
            // cms_N_Layer
            // 
            this.cms_N_Layer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_N_Layer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Layer_Add});
            this.cms_N_Layer.Name = "cms_N_Layer";
            this.cms_N_Layer.Size = new System.Drawing.Size(125, 26);
            // 
            // mi_Layer_Add
            // 
            this.mi_Layer_Add.Name = "mi_Layer_Add";
            this.mi_Layer_Add.Size = new System.Drawing.Size(124, 22);
            this.mi_Layer_Add.Text = "添加层(&I)";
            this.mi_Layer_Add.Click += new System.EventHandler(this.mi_Layer_Add_Click);
            // 
            // cms_N_ReportWordOrHtml
            // 
            this.cms_N_ReportWordOrHtml.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_N_ReportWordOrHtml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_report_refresh});
            this.cms_N_ReportWordOrHtml.Name = "cms_N_ReportWordOrHtml";
            this.cms_N_ReportWordOrHtml.Size = new System.Drawing.Size(117, 26);
            // 
            // mi_report_refresh
            // 
            this.mi_report_refresh.Name = "mi_report_refresh";
            this.mi_report_refresh.Size = new System.Drawing.Size(116, 22);
            this.mi_report_refresh.Text = "刷新(&R)";
            this.mi_report_refresh.Click += new System.EventHandler(this.mi_report_refresh_Click);
            // 
            // il_treeview
            // 
            this.il_treeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_treeview.ImageStream")));
            this.il_treeview.TransparentColor = System.Drawing.Color.Transparent;
            this.il_treeview.Images.SetKeyName(0, "Calculate.png");
            this.il_treeview.Images.SetKeyName(1, "CurveFit16x16.png");
            this.il_treeview.Images.SetKeyName(2, "Delete16x16.png");
            this.il_treeview.Images.SetKeyName(3, "Add_16x16.png");
            this.il_treeview.Images.SetKeyName(4, "Add_16x16.png");
            this.il_treeview.Images.SetKeyName(5, "bin_file.png");
            this.il_treeview.Images.SetKeyName(6, "Delete16x16.png");
            this.il_treeview.Images.SetKeyName(7, "folder.png");
            this.il_treeview.Images.SetKeyName(8, "geometry2_16x16.png");
            this.il_treeview.Images.SetKeyName(9, "materials_16x16.png");
            this.il_treeview.Images.SetKeyName(10, "mesh-generation.png");
            this.il_treeview.Images.SetKeyName(11, "mesh-object-parent.png");
            this.il_treeview.Images.SetKeyName(12, "misc.png");
            this.il_treeview.Images.SetKeyName(13, "model_16x16.PNG");
            this.il_treeview.Images.SetKeyName(14, "Outlet.png");
            this.il_treeview.Images.SetKeyName(15, "pressure_16x16.png");
            this.il_treeview.Images.SetKeyName(16, "result_16x16.png");
            this.il_treeview.Images.SetKeyName(17, "results_16x16.png");
            this.il_treeview.Images.SetKeyName(18, "skip.png");
            this.il_treeview.Images.SetKeyName(19, "solidmodels.png");
            this.il_treeview.Images.SetKeyName(20, "solvercontrol.png");
            this.il_treeview.Images.SetKeyName(21, "start.png");
            this.il_treeview.Images.SetKeyName(22, "stop.png");
            this.il_treeview.Images.SetKeyName(23, "temperature_16x16.png");
            this.il_treeview.Images.SetKeyName(24, "update_16x16.png");
            this.il_treeview.Images.SetKeyName(25, "Wall.png");
            this.il_treeview.Images.SetKeyName(26, "cad_face.png");
            this.il_treeview.Images.SetKeyName(27, "mesh_16x16.png");
            this.il_treeview.Images.SetKeyName(28, "attribute.png");
            this.il_treeview.Images.SetKeyName(29, "meshComponents_16x16.PNG");
            this.il_treeview.Images.SetKeyName(30, "meshcontrol_16x16.png");
            this.il_treeview.Images.SetKeyName(31, "Thermo_Mechanical.png");
            this.il_treeview.Images.SetKeyName(32, "Wall.png");
            this.il_treeview.Images.SetKeyName(33, "solversettings_16x16.png");
            this.il_treeview.Images.SetKeyName(34, "html.png");
            this.il_treeview.Images.SetKeyName(35, "word_1.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_navigation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 658);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 1;
            // 
            // tv_navigation
            // 
            this.tv_navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_navigation.ImageIndex = 0;
            this.tv_navigation.ImageList = this.il_treeview;
            this.tv_navigation.ItemHeight = 22;
            this.tv_navigation.Location = new System.Drawing.Point(0, 0);
            this.tv_navigation.Name = "tv_navigation";
            treeNode1.Name = "N_MaterialDet";
            treeNode1.Text = "节点3";
            treeNode2.Name = "节点4";
            treeNode2.Text = "节点4";
            treeNode3.ContextMenuStrip = this.cms_N_Material;
            treeNode3.ImageIndex = 9;
            treeNode3.Name = "N_Material";
            treeNode3.SelectedImageIndex = 9;
            treeNode3.Text = "材料参数";
            treeNode4.ImageIndex = 25;
            treeNode4.Name = "N_HotfaceParameter";
            treeNode4.SelectedImageIndex = 25;
            treeNode4.Text = "热面参数";
            treeNode5.ImageIndex = 28;
            treeNode5.Name = "节点5";
            treeNode5.SelectedImageIndex = 28;
            treeNode5.Text = "第一层";
            treeNode6.ImageIndex = 28;
            treeNode6.Name = "节点21";
            treeNode6.SelectedImageIndex = 28;
            treeNode6.Text = "第二层";
            treeNode7.ContextMenuStrip = this.cms_N_Layer;
            treeNode7.ImageIndex = 27;
            treeNode7.Name = "N_Layer";
            treeNode7.SelectedImageIndex = 27;
            treeNode7.Text = "层列表";
            treeNode8.ImageIndex = 14;
            treeNode8.Name = "N_ColdfaceBoundary";
            treeNode8.SelectedImageIndex = 14;
            treeNode8.Text = "冷面边界";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "N_CalculateModel";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "计算模型";
            treeNode10.ImageIndex = 31;
            treeNode10.Name = "N_TemperatureCriterion";
            treeNode10.SelectedImageIndex = 31;
            treeNode10.Text = "温度解算收敛准则";
            treeNode11.ImageIndex = 13;
            treeNode11.Name = "N_LayerDifferential";
            treeNode11.SelectedImageIndex = 13;
            treeNode11.Text = "层微分";
            treeNode12.Checked = true;
            treeNode12.ImageIndex = 12;
            treeNode12.Name = "N_SolveParameter";
            treeNode12.SelectedImageIndex = 12;
            treeNode12.Text = "解算参数";
            treeNode13.ImageIndex = 24;
            treeNode13.Name = "N_Solve";
            treeNode13.SelectedImageIndex = 24;
            treeNode13.Text = "计算";
            treeNode14.ContextMenuStrip = this.cms_N_ReportWordOrHtml;
            treeNode14.ImageIndex = 35;
            treeNode14.Name = "N_ReportWord";
            treeNode14.SelectedImageIndex = 35;
            treeNode14.Text = "Word报告";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "N_Result";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "结果";
            treeNode16.ImageIndex = 7;
            treeNode16.Name = "N_Project";
            treeNode16.SelectedImageIndex = 7;
            treeNode16.Text = "新建计算";
            this.tv_navigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.tv_navigation.SelectedImageIndex = 0;
            this.tv_navigation.Size = new System.Drawing.Size(287, 658);
            this.tv_navigation.TabIndex = 1;
            this.tv_navigation.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.BeforeTvNavCollapse);
            this.tv_navigation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.BeforeTvNavExpand);
            this.tv_navigation.DoubleClick += new System.EventHandler(this.OnTvNavigationDoubleClick);
            this.tv_navigation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTvNavKeyDown);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.mainDisplay1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(763, 658);
            this.splitContainer3.SplitterDistance = 300;
            this.splitContainer3.TabIndex = 0;
            // 
            // mainDisplay1
            // 
            this.mainDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDisplay1.BoundaryWidth = 20;
            this.mainDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDisplay1.Location = new System.Drawing.Point(0, 0);
            this.mainDisplay1.Margin = new System.Windows.Forms.Padding(4);
            this.mainDisplay1.MaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainDisplay1.MinColor = System.Drawing.Color.Green;
            this.mainDisplay1.MinWidth = 5;
            this.mainDisplay1.Name = "mainDisplay1";
            this.mainDisplay1.OnColdfaceClick = null;
            this.mainDisplay1.OnHotfaceClick = null;
            this.mainDisplay1.OnLayerDbClick = null;
            this.mainDisplay1.Pro = null;
            this.mainDisplay1.Size = new System.Drawing.Size(763, 300);
            this.mainDisplay1.Space = 5;
            this.mainDisplay1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tp_detail);
            this.tabControl1.Controls.Add(this.tp_moniter);
            this.tabControl1.Controls.Add(this.tp_console);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_detail
            // 
            this.tp_detail.Controls.Add(this.rtb_detail);
            this.tp_detail.Location = new System.Drawing.Point(4, 4);
            this.tp_detail.Name = "tp_detail";
            this.tp_detail.Padding = new System.Windows.Forms.Padding(3);
            this.tp_detail.Size = new System.Drawing.Size(737, 346);
            this.tp_detail.TabIndex = 0;
            this.tp_detail.Text = "详情";
            this.tp_detail.UseVisualStyleBackColor = true;
            // 
            // rtb_detail
            // 
            this.rtb_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_detail.Location = new System.Drawing.Point(3, 3);
            this.rtb_detail.Name = "rtb_detail";
            this.rtb_detail.ReadOnly = true;
            this.rtb_detail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_detail.Size = new System.Drawing.Size(731, 340);
            this.rtb_detail.TabIndex = 0;
            this.rtb_detail.Text = "";
            // 
            // tp_moniter
            // 
            this.tp_moniter.Controls.Add(this.splitContainer2);
            this.tp_moniter.Location = new System.Drawing.Point(4, 4);
            this.tp_moniter.Name = "tp_moniter";
            this.tp_moniter.Padding = new System.Windows.Forms.Padding(3);
            this.tp_moniter.Size = new System.Drawing.Size(737, 346);
            this.tp_moniter.TabIndex = 1;
            this.tp_moniter.Text = "监视";
            this.tp_moniter.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ct_temperature);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ct_thickness);
            this.splitContainer2.Size = new System.Drawing.Size(731, 340);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // ct_temperature
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "步数";
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "温度计算残差";
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.ct_temperature.ChartAreas.Add(chartArea1);
            this.ct_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ct_temperature.Location = new System.Drawing.Point(0, 0);
            this.ct_temperature.Name = "ct_temperature";
            series1.BorderColor = System.Drawing.Color.Maroon;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.ct_temperature.Series.Add(series1);
            this.ct_temperature.Size = new System.Drawing.Size(731, 200);
            this.ct_temperature.TabIndex = 0;
            this.ct_temperature.Text = "chart1";
            // 
            // ct_thickness
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "步数";
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Title = "厚度计算残差";
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.Name = "ChartArea1";
            this.ct_thickness.ChartAreas.Add(chartArea2);
            this.ct_thickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ct_thickness.Location = new System.Drawing.Point(0, 0);
            this.ct_thickness.Name = "ct_thickness";
            series2.BorderColor = System.Drawing.Color.Maroon;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.ct_thickness.Series.Add(series2);
            this.ct_thickness.Size = new System.Drawing.Size(731, 136);
            this.ct_thickness.TabIndex = 1;
            this.ct_thickness.Text = "chart1";
            // 
            // tp_console
            // 
            this.tp_console.Controls.Add(this.rtb_log);
            this.tp_console.Location = new System.Drawing.Point(4, 4);
            this.tp_console.Name = "tp_console";
            this.tp_console.Size = new System.Drawing.Size(737, 346);
            this.tp_console.TabIndex = 2;
            this.tp_console.Text = "日志";
            this.tp_console.UseVisualStyleBackColor = true;
            // 
            // rtb_log
            // 
            this.rtb_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_log.Location = new System.Drawing.Point(0, 0);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_log.Size = new System.Drawing.Size(737, 346);
            this.rtb_log.TabIndex = 0;
            this.rtb_log.Text = "";
            // 
            // il_ui
            // 
            this.il_ui.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_ui.ImageStream")));
            this.il_ui.TransparentColor = System.Drawing.Color.Transparent;
            this.il_ui.Images.SetKeyName(0, "about.png");
            this.il_ui.Images.SetKeyName(1, "Add_16x16.png");
            this.il_ui.Images.SetKeyName(2, "advanced.png");
            this.il_ui.Images.SetKeyName(3, "attribute.png");
            this.il_ui.Images.SetKeyName(4, "backward.png");
            this.il_ui.Images.SetKeyName(5, "bmark_next.png");
            this.il_ui.Images.SetKeyName(6, "bmark_pre.png");
            this.il_ui.Images.SetKeyName(7, "class.png");
            this.il_ui.Images.SetKeyName(8, "computer.png");
            this.il_ui.Images.SetKeyName(9, "copy.png");
            this.il_ui.Images.SetKeyName(10, "cut.png");
            this.il_ui.Images.SetKeyName(11, "Delete16x16.png");
            this.il_ui.Images.SetKeyName(12, "down.png");
            this.il_ui.Images.SetKeyName(13, "element.png");
            this.il_ui.Images.SetKeyName(14, "file.png");
            this.il_ui.Images.SetKeyName(15, "find.png");
            this.il_ui.Images.SetKeyName(16, "findr.png");
            this.il_ui.Images.SetKeyName(17, "folder.png");
            this.il_ui.Images.SetKeyName(18, "folder_16x16.png");
            this.il_ui.Images.SetKeyName(19, "forward.png");
            this.il_ui.Images.SetKeyName(20, "function.png");
            this.il_ui.Images.SetKeyName(21, "harddisk.png");
            this.il_ui.Images.SetKeyName(22, "html_gen.png");
            this.il_ui.Images.SetKeyName(23, "import_16x16.png");
            this.il_ui.Images.SetKeyName(24, "load_button.png");
            this.il_ui.Images.SetKeyName(25, "log.png");
            this.il_ui.Images.SetKeyName(26, "mail.png");
            this.il_ui.Images.SetKeyName(27, "materials_16x16.png");
            this.il_ui.Images.SetKeyName(28, "meshComponents_16x16.PNG");
            this.il_ui.Images.SetKeyName(29, "new.png");
            this.il_ui.Images.SetKeyName(30, "new_button.png");
            this.il_ui.Images.SetKeyName(31, "open.png");
            this.il_ui.Images.SetKeyName(32, "paste.png");
            this.il_ui.Images.SetKeyName(33, "php.png");
            this.il_ui.Images.SetKeyName(34, "plugin.png");
            this.il_ui.Images.SetKeyName(35, "pref.png");
            this.il_ui.Images.SetKeyName(36, "printpre.png");
            this.il_ui.Images.SetKeyName(37, "property.png");
            this.il_ui.Images.SetKeyName(38, "quit.png");
            this.il_ui.Images.SetKeyName(39, "redo.png");
            this.il_ui.Images.SetKeyName(40, "skip.png");
            this.il_ui.Images.SetKeyName(41, "start.png");
            this.il_ui.Images.SetKeyName(42, "stop.png");
            this.il_ui.Images.SetKeyName(43, "text.png");
            this.il_ui.Images.SetKeyName(44, "undo.png");
            this.il_ui.Images.SetKeyName(45, "up.png");
            this.il_ui.Images.SetKeyName(46, "web.png");
            // 
            // cms_N_MarerialItem
            // 
            this.cms_N_MarerialItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_N_MarerialItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_MaterialItem_Show,
            this.mi_MaterialItem_Delete,
            this.toolStripSeparator6,
            this.cmi_materialitem_copy,
            this.cmi_materialitem_update});
            this.cms_N_MarerialItem.Name = "cms_N_MarerialItem";
            this.cms_N_MarerialItem.Size = new System.Drawing.Size(166, 98);
            // 
            // mi_MaterialItem_Show
            // 
            this.mi_MaterialItem_Show.Name = "mi_MaterialItem_Show";
            this.mi_MaterialItem_Show.Size = new System.Drawing.Size(165, 22);
            this.mi_MaterialItem_Show.Text = "详情...(&V)";
            this.mi_MaterialItem_Show.Click += new System.EventHandler(this.mi_MaterialItem_Show_Click);
            // 
            // mi_MaterialItem_Delete
            // 
            this.mi_MaterialItem_Delete.Name = "mi_MaterialItem_Delete";
            this.mi_MaterialItem_Delete.Size = new System.Drawing.Size(165, 22);
            this.mi_MaterialItem_Delete.Text = "删除(&D)";
            this.mi_MaterialItem_Delete.Click += new System.EventHandler(this.mi_MaterialItem_Delete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(162, 6);
            // 
            // cmi_materialitem_copy
            // 
            this.cmi_materialitem_copy.Name = "cmi_materialitem_copy";
            this.cmi_materialitem_copy.Size = new System.Drawing.Size(165, 22);
            this.cmi_materialitem_copy.Text = "复制副本(&C)";
            this.cmi_materialitem_copy.Click += new System.EventHandler(this.cmi_materialitem_copy_Click);
            // 
            // cmi_materialitem_update
            // 
            this.cmi_materialitem_update.Name = "cmi_materialitem_update";
            this.cmi_materialitem_update.Size = new System.Drawing.Size(165, 22);
            this.cmi_materialitem_update.Text = "上载到数据库(&U)";
            this.cmi_materialitem_update.Click += new System.EventHandler(this.cmi_materialitem_update_Click);
            // 
            // cms_N_LayerItem
            // 
            this.cms_N_LayerItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_N_LayerItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_LayerItem_Details,
            this.mi_LayerItem_Delete,
            this.mi_LayerItem_Up,
            this.mi_LayerItem_Down});
            this.cms_N_LayerItem.Name = "cms_N_LayerItem";
            this.cms_N_LayerItem.Size = new System.Drawing.Size(126, 92);
            // 
            // mi_LayerItem_Details
            // 
            this.mi_LayerItem_Details.Name = "mi_LayerItem_Details";
            this.mi_LayerItem_Details.Size = new System.Drawing.Size(125, 22);
            this.mi_LayerItem_Details.Text = "详情...(&V)";
            this.mi_LayerItem_Details.Click += new System.EventHandler(this.mi_LayerItem_Details_Click);
            // 
            // mi_LayerItem_Delete
            // 
            this.mi_LayerItem_Delete.Name = "mi_LayerItem_Delete";
            this.mi_LayerItem_Delete.Size = new System.Drawing.Size(125, 22);
            this.mi_LayerItem_Delete.Text = "删除(&D)";
            this.mi_LayerItem_Delete.Click += new System.EventHandler(this.mi_LayerItem_Delete_Click);
            // 
            // mi_LayerItem_Up
            // 
            this.mi_LayerItem_Up.Name = "mi_LayerItem_Up";
            this.mi_LayerItem_Up.Size = new System.Drawing.Size(125, 22);
            this.mi_LayerItem_Up.Text = "上移(&W)";
            this.mi_LayerItem_Up.Click += new System.EventHandler(this.mi_LayerItem_Up_Click);
            // 
            // mi_LayerItem_Down
            // 
            this.mi_LayerItem_Down.Name = "mi_LayerItem_Down";
            this.mi_LayerItem_Down.Size = new System.Drawing.Size(125, 22);
            this.mi_LayerItem_Down.Text = "下移(&S)";
            this.mi_LayerItem_Down.Click += new System.EventHandler(this.mi_LayerItem_Down_Click);
            // 
            // ms_main
            // 
            this.ms_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.mi_project_new,
            this.mi_material,
            this.计算模型CToolStripMenuItem,
            this.层管理LToolStripMenuItem,
            this.解算参数SToolStripMenuItem,
            this.解算SToolStripMenuItem,
            this.结果RToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.mi_manangement});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(1054, 25);
            this.ms_main.TabIndex = 4;
            this.ms_main.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_user_loginoff,
            this.mi_user_changepassword,
            this.toolStripSeparator3,
            this.mi_user_exit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.系统SToolStripMenuItem.Text = "用户(&U)";
            // 
            // mi_user_loginoff
            // 
            this.mi_user_loginoff.Name = "mi_user_loginoff";
            this.mi_user_loginoff.Size = new System.Drawing.Size(149, 22);
            this.mi_user_loginoff.Text = "注销(&L)";
            this.mi_user_loginoff.Click += new System.EventHandler(this.mi_user_loginoff_Click);
            // 
            // mi_user_changepassword
            // 
            this.mi_user_changepassword.Name = "mi_user_changepassword";
            this.mi_user_changepassword.Size = new System.Drawing.Size(149, 22);
            this.mi_user_changepassword.Text = "修改密码...(&C)";
            this.mi_user_changepassword.Click += new System.EventHandler(this.mi_user_changepassword_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
            // 
            // mi_user_exit
            // 
            this.mi_user_exit.Name = "mi_user_exit";
            this.mi_user_exit.Size = new System.Drawing.Size(149, 22);
            this.mi_user_exit.Text = "退出(&X)";
            this.mi_user_exit.Click += new System.EventHandler(this.mi_user_exit_Click);
            // 
            // mi_project_new
            // 
            this.mi_project_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File_New,
            this.mi_project_templetenew,
            this.toolStripSeparator8,
            this.mi_File_Open,
            this.mi_File_Load,
            this.toolStripSeparator1,
            this.mi_File_SaveLocal,
            this.mi_File_SaveAsLocal,
            this.toolStripSeparator9,
            this.mi_File_Save,
            this.mi_File_SaveAs});
            this.mi_project_new.Name = "mi_project_new";
            this.mi_project_new.Size = new System.Drawing.Size(58, 21);
            this.mi_project_new.Text = "工程(&F)";
            // 
            // mi_File_New
            // 
            this.mi_File_New.Name = "mi_File_New";
            this.mi_File_New.Size = new System.Drawing.Size(165, 22);
            this.mi_File_New.Text = "新建(&N)";
            this.mi_File_New.Click += new System.EventHandler(this.mi_File_New_Click);
            // 
            // mi_project_templetenew
            // 
            this.mi_project_templetenew.Name = "mi_project_templetenew";
            this.mi_project_templetenew.Size = new System.Drawing.Size(165, 22);
            this.mi_project_templetenew.Text = "从模板新建...(&M)";
            this.mi_project_templetenew.Click += new System.EventHandler(this.mi_project_templetenew_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_File_Open
            // 
            this.mi_File_Open.Name = "mi_File_Open";
            this.mi_File_Open.Size = new System.Drawing.Size(165, 22);
            this.mi_File_Open.Text = "打开...(&O)";
            this.mi_File_Open.Click += new System.EventHandler(this.mi_File_Open_Click);
            // 
            // mi_File_Load
            // 
            this.mi_File_Load.Name = "mi_File_Load";
            this.mi_File_Load.Size = new System.Drawing.Size(165, 22);
            this.mi_File_Load.Text = "载入...(&L)";
            this.mi_File_Load.Click += new System.EventHandler(this.mi_File_Load_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_File_SaveLocal
            // 
            this.mi_File_SaveLocal.Name = "mi_File_SaveLocal";
            this.mi_File_SaveLocal.Size = new System.Drawing.Size(165, 22);
            this.mi_File_SaveLocal.Text = "保存(&S)";
            this.mi_File_SaveLocal.Click += new System.EventHandler(this.mi_File_SaveLocal_Click);
            // 
            // mi_File_SaveAsLocal
            // 
            this.mi_File_SaveAsLocal.Name = "mi_File_SaveAsLocal";
            this.mi_File_SaveAsLocal.Size = new System.Drawing.Size(165, 22);
            this.mi_File_SaveAsLocal.Text = "另存为...(&A)";
            this.mi_File_SaveAsLocal.Click += new System.EventHandler(this.mi_File_SaveAsLocal_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_File_Save
            // 
            this.mi_File_Save.Name = "mi_File_Save";
            this.mi_File_Save.Size = new System.Drawing.Size(165, 22);
            this.mi_File_Save.Text = "保存到云(&C)";
            this.mi_File_Save.Click += new System.EventHandler(this.mi_File_Save_Click);
            // 
            // mi_File_SaveAs
            // 
            this.mi_File_SaveAs.Name = "mi_File_SaveAs";
            this.mi_File_SaveAs.Size = new System.Drawing.Size(165, 22);
            this.mi_File_SaveAs.Text = "另存到云...(&Q)";
            this.mi_File_SaveAs.Click += new System.EventHandler(this.mi_File_SaveAs_Click);
            // 
            // mi_material
            // 
            this.mi_material.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_material_loadin,
            this.mi_material_update,
            this.toolStripSeparator4,
            this.mi_material_new,
            this.mi_material_detail,
            this.mi_material_delete,
            this.mi_material_copy,
            this.toolStripSeparator2,
            this.mi_material_managelib});
            this.mi_material.Name = "mi_material";
            this.mi_material.Size = new System.Drawing.Size(64, 21);
            this.mi_material.Text = "材料(&M)";
            this.mi_material.DropDownOpening += new System.EventHandler(this.OnMiMaterialDropDownOpening);
            // 
            // mi_material_loadin
            // 
            this.mi_material_loadin.Name = "mi_material_loadin";
            this.mi_material_loadin.Size = new System.Drawing.Size(165, 22);
            this.mi_material_loadin.Text = "材料库导入...(&L)";
            this.mi_material_loadin.Click += new System.EventHandler(this.mi_material_loadin_Click);
            // 
            // mi_material_update
            // 
            this.mi_material_update.Name = "mi_material_update";
            this.mi_material_update.Size = new System.Drawing.Size(165, 22);
            this.mi_material_update.Text = "上载到数据库(&U)";
            this.mi_material_update.Click += new System.EventHandler(this.mi_material_update_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_material_new
            // 
            this.mi_material_new.Name = "mi_material_new";
            this.mi_material_new.Size = new System.Drawing.Size(165, 22);
            this.mi_material_new.Text = "新建...(&N)";
            this.mi_material_new.Click += new System.EventHandler(this.mi_material_new_Click);
            // 
            // mi_material_detail
            // 
            this.mi_material_detail.Name = "mi_material_detail";
            this.mi_material_detail.Size = new System.Drawing.Size(165, 22);
            this.mi_material_detail.Text = "详情...(&D)";
            this.mi_material_detail.Click += new System.EventHandler(this.mi_material_detail_Click);
            // 
            // mi_material_delete
            // 
            this.mi_material_delete.Name = "mi_material_delete";
            this.mi_material_delete.Size = new System.Drawing.Size(165, 22);
            this.mi_material_delete.Text = "删除(&R)";
            this.mi_material_delete.Click += new System.EventHandler(this.mi_material_delete_Click);
            // 
            // mi_material_copy
            // 
            this.mi_material_copy.Name = "mi_material_copy";
            this.mi_material_copy.Size = new System.Drawing.Size(165, 22);
            this.mi_material_copy.Text = "复制副本(&C)";
            this.mi_material_copy.Click += new System.EventHandler(this.mi_material_copy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // mi_material_managelib
            // 
            this.mi_material_managelib.Name = "mi_material_managelib";
            this.mi_material_managelib.Size = new System.Drawing.Size(165, 22);
            this.mi_material_managelib.Text = "管理材料库...(&M)";
            this.mi_material_managelib.Click += new System.EventHandler(this.mi_material_managelib_Click);
            // 
            // 计算模型CToolStripMenuItem
            // 
            this.计算模型CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_calculatemode_hotface,
            this.mi_calculatemode_coldboundary});
            this.计算模型CToolStripMenuItem.Name = "计算模型CToolStripMenuItem";
            this.计算模型CToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.计算模型CToolStripMenuItem.Text = "计算模型(&C)";
            // 
            // mi_calculatemode_hotface
            // 
            this.mi_calculatemode_hotface.Name = "mi_calculatemode_hotface";
            this.mi_calculatemode_hotface.Size = new System.Drawing.Size(150, 22);
            this.mi_calculatemode_hotface.Text = "热面参数...(&H)";
            this.mi_calculatemode_hotface.Click += new System.EventHandler(this.mi_calculatemode_hotface_Click);
            // 
            // mi_calculatemode_coldboundary
            // 
            this.mi_calculatemode_coldboundary.Name = "mi_calculatemode_coldboundary";
            this.mi_calculatemode_coldboundary.Size = new System.Drawing.Size(150, 22);
            this.mi_calculatemode_coldboundary.Text = "冷面边界...(&C)";
            this.mi_calculatemode_coldboundary.Click += new System.EventHandler(this.mi_calculatemode_coldboundary_Click);
            // 
            // 层管理LToolStripMenuItem
            // 
            this.层管理LToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_layer_new,
            this.mi_layer_detail,
            this.mi_layer_delete,
            this.mi_layer_move});
            this.层管理LToolStripMenuItem.Name = "层管理LToolStripMenuItem";
            this.层管理LToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.层管理LToolStripMenuItem.Text = "层管理(&L)";
            this.层管理LToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnMiLayerDropDownOpening);
            // 
            // mi_layer_new
            // 
            this.mi_layer_new.Name = "mi_layer_new";
            this.mi_layer_new.Size = new System.Drawing.Size(138, 22);
            this.mi_layer_new.Text = "添加层...(&I)";
            this.mi_layer_new.Click += new System.EventHandler(this.mi_layer_new_Click);
            // 
            // mi_layer_detail
            // 
            this.mi_layer_detail.Name = "mi_layer_detail";
            this.mi_layer_detail.Size = new System.Drawing.Size(138, 22);
            this.mi_layer_detail.Text = "层详情...(&D)";
            this.mi_layer_detail.Click += new System.EventHandler(this.mi_layer_detail_Click);
            // 
            // mi_layer_delete
            // 
            this.mi_layer_delete.Name = "mi_layer_delete";
            this.mi_layer_delete.Size = new System.Drawing.Size(138, 22);
            this.mi_layer_delete.Text = "删除层(&R)";
            this.mi_layer_delete.Click += new System.EventHandler(this.mi_layer_delete_Click);
            // 
            // mi_layer_move
            // 
            this.mi_layer_move.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_layer_move_up,
            this.mi_layer_move_down});
            this.mi_layer_move.Name = "mi_layer_move";
            this.mi_layer_move.Size = new System.Drawing.Size(138, 22);
            this.mi_layer_move.Text = "层移动(&M)";
            // 
            // mi_layer_move_up
            // 
            this.mi_layer_move_up.Name = "mi_layer_move_up";
            this.mi_layer_move_up.Size = new System.Drawing.Size(117, 22);
            this.mi_layer_move_up.Text = "上移(&U)";
            this.mi_layer_move_up.Click += new System.EventHandler(this.mi_layer_move_up_Click);
            // 
            // mi_layer_move_down
            // 
            this.mi_layer_move_down.Name = "mi_layer_move_down";
            this.mi_layer_move_down.Size = new System.Drawing.Size(117, 22);
            this.mi_layer_move_down.Text = "下移(&D)";
            this.mi_layer_move_down.Click += new System.EventHandler(this.mi_layer_move_down_Click);
            // 
            // 解算参数SToolStripMenuItem
            // 
            this.解算参数SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_solveparameter_temperature,
            this.mi_solveparameter_thickness,
            this.mi_solveparameter_laydiff});
            this.解算参数SToolStripMenuItem.Name = "解算参数SToolStripMenuItem";
            this.解算参数SToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.解算参数SToolStripMenuItem.Text = "解算参数(&S)";
            this.解算参数SToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnMiSolveParameterDropDownOpening);
            // 
            // mi_solveparameter_temperature
            // 
            this.mi_solveparameter_temperature.Name = "mi_solveparameter_temperature";
            this.mi_solveparameter_temperature.Size = new System.Drawing.Size(198, 22);
            this.mi_solveparameter_temperature.Text = "温度解算收敛准则...(&T)";
            this.mi_solveparameter_temperature.Click += new System.EventHandler(this.mi_solveparameter_temperature_Click);
            // 
            // mi_solveparameter_thickness
            // 
            this.mi_solveparameter_thickness.Name = "mi_solveparameter_thickness";
            this.mi_solveparameter_thickness.Size = new System.Drawing.Size(198, 22);
            this.mi_solveparameter_thickness.Text = "厚度解算收敛准则...(&H)";
            this.mi_solveparameter_thickness.Click += new System.EventHandler(this.mi_solveparameter_thickness_Click);
            // 
            // mi_solveparameter_laydiff
            // 
            this.mi_solveparameter_laydiff.Name = "mi_solveparameter_laydiff";
            this.mi_solveparameter_laydiff.Size = new System.Drawing.Size(198, 22);
            this.mi_solveparameter_laydiff.Text = "层微分...(&L)";
            this.mi_solveparameter_laydiff.Click += new System.EventHandler(this.mi_solveparameter_laydiff_Click);
            // 
            // 解算SToolStripMenuItem
            // 
            this.解算SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_solve_run});
            this.解算SToolStripMenuItem.Name = "解算SToolStripMenuItem";
            this.解算SToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.解算SToolStripMenuItem.Text = "解算(&W)";
            // 
            // mi_solve_run
            // 
            this.mi_solve_run.Name = "mi_solve_run";
            this.mi_solve_run.Size = new System.Drawing.Size(116, 22);
            this.mi_solve_run.Text = "计算(&R)";
            this.mi_solve_run.Click += new System.EventHandler(this.mi_solve_run_Click);
            // 
            // 结果RToolStripMenuItem
            // 
            this.结果RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_result_word,
            this.toolStripSeparator7,
            this.mi_result_refreshreporter});
            this.结果RToolStripMenuItem.Name = "结果RToolStripMenuItem";
            this.结果RToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.结果RToolStripMenuItem.Text = "结果(&R)";
            // 
            // mi_result_word
            // 
            this.mi_result_word.Name = "mi_result_word";
            this.mi_result_word.Size = new System.Drawing.Size(164, 22);
            this.mi_result_word.Text = "Word报表(&W)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // mi_result_refreshreporter
            // 
            this.mi_result_refreshreporter.Name = "mi_result_refreshreporter";
            this.mi_result_refreshreporter.Size = new System.Drawing.Size(164, 22);
            this.mi_result_refreshreporter.Text = "刷新报表模板(&R)";
            this.mi_result_refreshreporter.Click += new System.EventHandler(this.mi_result_refreshreporter_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_help_doc,
            this.toolStripSeparator5,
            this.mi_help_update,
            this.mi_help_about});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // mi_help_doc
            // 
            this.mi_help_doc.Name = "mi_help_doc";
            this.mi_help_doc.Size = new System.Drawing.Size(152, 22);
            this.mi_help_doc.Text = "帮助文档...(&D)";
            this.mi_help_doc.Click += new System.EventHandler(this.mi_help_doc_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_help_update
            // 
            this.mi_help_update.Name = "mi_help_update";
            this.mi_help_update.Size = new System.Drawing.Size(152, 22);
            this.mi_help_update.Text = "检查更新...(&U)";
            this.mi_help_update.Click += new System.EventHandler(this.mi_help_update_Click);
            // 
            // mi_help_about
            // 
            this.mi_help_about.Name = "mi_help_about";
            this.mi_help_about.Size = new System.Drawing.Size(152, 22);
            this.mi_help_about.Text = "关于...(&A)";
            this.mi_help_about.Click += new System.EventHandler(this.mi_help_about_Click);
            // 
            // mi_manangement
            // 
            this.mi_manangement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_management_user,
            this.mi_management_report,
            this.mi_manage_projecttemplete});
            this.mi_manangement.Name = "mi_manangement";
            this.mi_manangement.Size = new System.Drawing.Size(72, 21);
            this.mi_manangement.Text = "管理(&M）";
            // 
            // mi_management_user
            // 
            this.mi_management_user.Name = "mi_management_user";
            this.mi_management_user.Size = new System.Drawing.Size(164, 22);
            this.mi_management_user.Text = "用户管理(&U)";
            this.mi_management_user.Click += new System.EventHandler(this.mi_management_user_Click);
            // 
            // mi_management_report
            // 
            this.mi_management_report.Name = "mi_management_report";
            this.mi_management_report.Size = new System.Drawing.Size(164, 22);
            this.mi_management_report.Text = "报表模板管理(&R)";
            this.mi_management_report.Click += new System.EventHandler(this.mi_management_report_Click);
            // 
            // mi_manage_projecttemplete
            // 
            this.mi_manage_projecttemplete.Name = "mi_manage_projecttemplete";
            this.mi_manage_projecttemplete.Size = new System.Drawing.Size(164, 22);
            this.mi_manage_projecttemplete.Text = "工程模板管理(&P)";
            this.mi_manage_projecttemplete.Click += new System.EventHandler(this.mi_manage_projecttemplete_Click);
            // 
            // ss_bottom
            // 
            this.ss_bottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.db_user,
            this.toolStripStatusLabel1,
            this.tsl_status});
            this.ss_bottom.Location = new System.Drawing.Point(0, 689);
            this.ss_bottom.Name = "ss_bottom";
            this.ss_bottom.Size = new System.Drawing.Size(1054, 23);
            this.ss_bottom.TabIndex = 6;
            this.ss_bottom.Text = "statusStrip1";
            // 
            // db_user
            // 
            this.db_user.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.db_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.db_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_logoff,
            this.mi_changepassword});
            this.db_user.Image = ((System.Drawing.Image)(resources.GetObject("db_user.Image")));
            this.db_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.db_user.Name = "db_user";
            this.db_user.Size = new System.Drawing.Size(57, 21);
            this.db_user.Text = "傅秋华";
            // 
            // mi_logoff
            // 
            this.mi_logoff.Name = "mi_logoff";
            this.mi_logoff.Size = new System.Drawing.Size(124, 22);
            this.mi_logoff.Text = "注销";
            this.mi_logoff.Click += new System.EventHandler(this.mi_logoff_Click);
            // 
            // mi_changepassword
            // 
            this.mi_changepassword.Name = "mi_changepassword";
            this.mi_changepassword.Size = new System.Drawing.Size(124, 22);
            this.mi_changepassword.Text = "修改密码";
            this.mi_changepassword.Click += new System.EventHandler(this.mi_changepassword_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // tsl_status
            // 
            this.tsl_status.Name = "tsl_status";
            this.tsl_status.Size = new System.Drawing.Size(131, 18);
            this.tsl_status.Text = "toolStripStatusLabel2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exit.png");
            this.imageList1.Images.SetKeyName(1, "list.png");
            this.imageList1.Images.SetKeyName(2, "Material.png");
            this.imageList1.Images.SetKeyName(3, "materials management.png");
            this.imageList1.Images.SetKeyName(4, "new.png");
            this.imageList1.Images.SetKeyName(5, "project.png");
            this.imageList1.Images.SetKeyName(6, "save.png");
            this.imageList1.Images.SetKeyName(7, "save_1.png");
            // 
            // toolTip1
            // 
            this.toolTip1.StripAmpersands = true;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 712);
            this.Controls.Add(this.ss_bottom);
            this.Controls.Add(this.ms_main);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHTC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.cms_N_Material.ResumeLayout(false);
            this.cms_N_Layer.ResumeLayout(false);
            this.cms_N_ReportWordOrHtml.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_detail.ResumeLayout(false);
            this.tp_moniter.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ct_temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_thickness)).EndInit();
            this.tp_console.ResumeLayout(false);
            this.cms_N_MarerialItem.ResumeLayout(false);
            this.cms_N_LayerItem.ResumeLayout(false);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ss_bottom.ResumeLayout(false);
            this.ss_bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //FTreeView tv_navigation;
        private System.Windows.Forms.ImageList il_treeview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList il_ui;
        private System.Windows.Forms.ContextMenuStrip cms_N_Material;
        private System.Windows.Forms.ToolStripMenuItem mi_Material_Load;
        private System.Windows.Forms.ContextMenuStrip cms_N_MarerialItem;
        private System.Windows.Forms.ToolStripMenuItem mi_MaterialItem_Show;
        private System.Windows.Forms.ToolStripMenuItem mi_MaterialItem_Delete;
        private System.Windows.Forms.ContextMenuStrip cms_N_Layer;
        private System.Windows.Forms.ToolStripMenuItem mi_Layer_Add;
        private System.Windows.Forms.ContextMenuStrip cms_N_LayerItem;
        private System.Windows.Forms.ToolStripMenuItem mi_LayerItem_Details;
        private System.Windows.Forms.ToolStripMenuItem mi_LayerItem_Delete;
        private System.Windows.Forms.ToolStripMenuItem mi_LayerItem_Up;
        private System.Windows.Forms.ToolStripMenuItem mi_LayerItem_Down;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem mi_project_new;
        private System.Windows.Forms.StatusStrip ss_bottom;
        private System.Windows.Forms.TreeView tv_navigation;
        private System.Windows.Forms.ToolStripMenuItem mi_File_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Save;
        private System.Windows.Forms.ToolStripMenuItem mi_File_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Load;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cms_N_ReportWordOrHtml;
        private System.Windows.Forms.ToolStripMenuItem mi_report_refresh;
        private System.Windows.Forms.ToolStripDropDownButton db_user;
        private System.Windows.Forms.ToolStripMenuItem mi_logoff;
        private System.Windows.Forms.ToolStripMenuItem mi_changepassword;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_user_loginoff;
        private System.Windows.Forms.ToolStripMenuItem mi_user_changepassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mi_user_exit;
        private System.Windows.Forms.ToolStripMenuItem mi_material;
        private System.Windows.Forms.ToolStripMenuItem mi_material_loadin;
        private System.Windows.Forms.ToolStripMenuItem mi_material_new;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mi_material_managelib;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mi_material_detail;
        private System.Windows.Forms.ToolStripMenuItem mi_material_delete;
        private System.Windows.Forms.ToolStripMenuItem 计算模型CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_calculatemode_hotface;
        private System.Windows.Forms.ToolStripMenuItem mi_calculatemode_coldboundary;
        private System.Windows.Forms.ToolStripMenuItem 层管理LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_layer_new;
        private System.Windows.Forms.ToolStripMenuItem mi_layer_detail;
        private System.Windows.Forms.ToolStripMenuItem mi_layer_delete;
        private System.Windows.Forms.ToolStripMenuItem mi_layer_move;
        private System.Windows.Forms.ToolStripMenuItem mi_layer_move_up;
        private System.Windows.Forms.ToolStripMenuItem mi_layer_move_down;
        private System.Windows.Forms.ToolStripMenuItem 解算参数SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_solveparameter_temperature;
        private System.Windows.Forms.ToolStripMenuItem mi_solveparameter_thickness;
        private System.Windows.Forms.ToolStripMenuItem mi_solveparameter_laydiff;
        private System.Windows.Forms.ToolStripMenuItem 解算SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_solve_run;
        private System.Windows.Forms.ToolStripMenuItem 结果RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_result_word;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_help_doc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mi_help_about;
        private System.Windows.Forms.ToolStripMenuItem cmi_material_new;
        private System.Windows.Forms.ToolStripMenuItem mi_material_update;
        private System.Windows.Forms.ToolStripMenuItem mi_material_copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cmi_materialitem_copy;
        private System.Windows.Forms.ToolStripMenuItem cmi_materialitem_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mi_result_refreshreporter;
        private System.Windows.Forms.ToolStripMenuItem mi_help_update;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MainDisplay mainDisplay1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_detail;
        private System.Windows.Forms.TabPage tp_moniter;
        private System.Windows.Forms.TabPage tp_console;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_thickness;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.RichTextBox rtb_detail;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Open;
        private System.Windows.Forms.ToolStripMenuItem mi_File_SaveLocal;
        private System.Windows.Forms.ToolStripMenuItem mi_File_SaveAsLocal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_status;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem mi_manangement;
        private System.Windows.Forms.ToolStripMenuItem mi_management_user;
        private System.Windows.Forms.ToolStripMenuItem mi_management_report;
        private System.Windows.Forms.ToolStripMenuItem mi_manage_projecttemplete;
        private System.Windows.Forms.ToolStripMenuItem mi_project_templetenew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}