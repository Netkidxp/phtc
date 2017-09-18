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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Html报告", 34, 34);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("结果", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("新建计算", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode9,
            treeNode12,
            treeNode13,
            treeNode16});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cms_N_Material = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_Material_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_N_Layer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_Layer_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_N_ReportWordOrHtml = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_report_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.il_treeview = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_navigation = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pd_main = new PHTC.PhtcDisplay();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.ct_temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ct_thickness = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wb_monitor = new System.Windows.Forms.WebBrowser();
            this.il_ui = new System.Windows.Forms.ImageList(this.components);
            this.cms_N_MarerialItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_MaterialItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_MaterialItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_N_LayerItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_LayerItem_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_LayerItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_LayerItem_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_LayerItem_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_thickness)).BeginInit();
            this.cms_N_MarerialItem.SuspendLayout();
            this.cms_N_LayerItem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_N_Material
            // 
            this.cms_N_Material.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Material_Load});
            this.cms_N_Material.Name = "cms_N_Material";
            this.cms_N_Material.Size = new System.Drawing.Size(160, 26);
            // 
            // mi_Material_Load
            // 
            this.mi_Material_Load.Name = "mi_Material_Load";
            this.mi_Material_Load.Size = new System.Drawing.Size(159, 22);
            this.mi_Material_Load.Text = "数据库载入(&L)...";
            this.mi_Material_Load.Click += new System.EventHandler(this.mi_Material_Load_Click);
            // 
            // cms_N_Layer
            // 
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
            this.splitContainer1.Size = new System.Drawing.Size(1054, 559);
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
            treeNode15.ContextMenuStrip = this.cms_N_ReportWordOrHtml;
            treeNode15.ImageIndex = 34;
            treeNode15.Name = "N_ReportHtml";
            treeNode15.SelectedImageIndex = 34;
            treeNode15.Text = "Html报告";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "N_Result";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "结果";
            treeNode17.ImageIndex = 7;
            treeNode17.Name = "N_Project";
            treeNode17.SelectedImageIndex = 7;
            treeNode17.Text = "新建计算";
            this.tv_navigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.tv_navigation.SelectedImageIndex = 0;
            this.tv_navigation.Size = new System.Drawing.Size(287, 559);
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
            this.splitContainer3.Panel1.Controls.Add(this.pd_main);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(763, 559);
            this.splitContainer3.SplitterDistance = 250;
            this.splitContainer3.TabIndex = 0;
            // 
            // pd_main
            // 
            this.pd_main.BackColor = System.Drawing.Color.White;
            this.pd_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pd_main.Location = new System.Drawing.Point(0, 0);
            this.pd_main.Name = "pd_main";
            this.pd_main.OnColdfaceClick = null;
            this.pd_main.OnHotfaceClick = null;
            this.pd_main.OnLayerDbClick = null;
            this.pd_main.Project = null;
            this.pd_main.Size = new System.Drawing.Size(763, 250);
            this.pd_main.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.wb_monitor);
            this.splitContainer4.Size = new System.Drawing.Size(763, 305);
            this.splitContainer4.SplitterDistance = 387;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.ct_temperature);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.ct_thickness);
            this.splitContainer5.Size = new System.Drawing.Size(387, 305);
            this.splitContainer5.SplitterDistance = 150;
            this.splitContainer5.TabIndex = 0;
            // 
            // ct_temperature
            // 
            chartArea1.Name = "ChartArea1";
            this.ct_temperature.ChartAreas.Add(chartArea1);
            this.ct_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ct_temperature.Location = new System.Drawing.Point(0, 0);
            this.ct_temperature.Name = "ct_temperature";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.ct_temperature.Series.Add(series1);
            this.ct_temperature.Size = new System.Drawing.Size(387, 150);
            this.ct_temperature.TabIndex = 0;
            this.ct_temperature.Text = "chart1";
            // 
            // ct_thickness
            // 
            chartArea2.Name = "ChartArea1";
            this.ct_thickness.ChartAreas.Add(chartArea2);
            this.ct_thickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ct_thickness.Location = new System.Drawing.Point(0, 0);
            this.ct_thickness.Name = "ct_thickness";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.ct_thickness.Series.Add(series2);
            this.ct_thickness.Size = new System.Drawing.Size(387, 151);
            this.ct_thickness.TabIndex = 1;
            this.ct_thickness.Text = "chart2";
            // 
            // wb_monitor
            // 
            this.wb_monitor.AllowNavigation = false;
            this.wb_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_monitor.IsWebBrowserContextMenuEnabled = false;
            this.wb_monitor.Location = new System.Drawing.Point(0, 0);
            this.wb_monitor.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_monitor.Name = "wb_monitor";
            this.wb_monitor.Size = new System.Drawing.Size(372, 305);
            this.wb_monitor.TabIndex = 0;
            this.wb_monitor.Url = new System.Uri("", System.UriKind.Relative);
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
            this.cms_N_MarerialItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_MaterialItem_Show,
            this.mi_MaterialItem_Delete});
            this.cms_N_MarerialItem.Name = "cms_N_MarerialItem";
            this.cms_N_MarerialItem.Size = new System.Drawing.Size(126, 48);
            // 
            // mi_MaterialItem_Show
            // 
            this.mi_MaterialItem_Show.Name = "mi_MaterialItem_Show";
            this.mi_MaterialItem_Show.Size = new System.Drawing.Size(125, 22);
            this.mi_MaterialItem_Show.Text = "详情...(&V)";
            this.mi_MaterialItem_Show.Click += new System.EventHandler(this.mi_MaterialItem_Show_Click);
            // 
            // mi_MaterialItem_Delete
            // 
            this.mi_MaterialItem_Delete.Name = "mi_MaterialItem_Delete";
            this.mi_MaterialItem_Delete.Size = new System.Drawing.Size(125, 22);
            this.mi_MaterialItem_Delete.Text = "删除(&D)";
            this.mi_MaterialItem_Delete.Click += new System.EventHandler(this.mi_MaterialItem_Delete_Click);
            // 
            // cms_N_LayerItem
            // 
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File_New,
            this.mi_File_Load,
            this.toolStripSeparator1,
            this.mi_File_Save,
            this.mi_File_SaveAs,
            this.toolStripSeparator2,
            this.mi_File_Exit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // mi_File_New
            // 
            this.mi_File_New.Name = "mi_File_New";
            this.mi_File_New.Size = new System.Drawing.Size(128, 22);
            this.mi_File_New.Text = "新建(&N)";
            this.mi_File_New.Click += new System.EventHandler(this.mi_File_New_Click);
            // 
            // mi_File_Load
            // 
            this.mi_File_Load.Name = "mi_File_Load";
            this.mi_File_Load.Size = new System.Drawing.Size(128, 22);
            this.mi_File_Load.Text = "载入...(&L)";
            this.mi_File_Load.Click += new System.EventHandler(this.mi_File_Load_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // mi_File_Save
            // 
            this.mi_File_Save.Name = "mi_File_Save";
            this.mi_File_Save.Size = new System.Drawing.Size(128, 22);
            this.mi_File_Save.Text = "保存(&S)";
            this.mi_File_Save.Click += new System.EventHandler(this.mi_File_Save_Click);
            // 
            // mi_File_SaveAs
            // 
            this.mi_File_SaveAs.Name = "mi_File_SaveAs";
            this.mi_File_SaveAs.Size = new System.Drawing.Size(128, 22);
            this.mi_File_SaveAs.Text = "另存为(&A)";
            this.mi_File_SaveAs.Click += new System.EventHandler(this.mi_File_SaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // mi_File_Exit
            // 
            this.mi_File_Exit.Name = "mi_File_Exit";
            this.mi_File_Exit.Size = new System.Drawing.Size(128, 22);
            this.mi_File_Exit.Text = "退出(&X)";
            this.mi_File_Exit.Click += new System.EventHandler(this.mi_File_Exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
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
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 612);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHTC";
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
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ct_temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_thickness)).EndInit();
            this.cms_N_MarerialItem.ResumeLayout(false);
            this.cms_N_LayerItem.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer3;
        private PhtcDisplay pd_main;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_thickness;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.WebBrowser wb_monitor;
        private System.Windows.Forms.TreeView tv_navigation;
        private System.Windows.Forms.ToolStripMenuItem mi_File_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Save;
        private System.Windows.Forms.ToolStripMenuItem mi_File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Load;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cms_N_ReportWordOrHtml;
        private System.Windows.Forms.ToolStripMenuItem mi_report_refresh;
    }
}