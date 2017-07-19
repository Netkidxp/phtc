namespace PHTC
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("材料参数", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("模型参数", 11, 11);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("热面参数", 25, 25);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("第一层", 28, 28);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("第二层", 28, 28);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("层信息", 27, 27, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("冷面边界", 14, 14);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("计算模型", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("迭代收敛准则", 31, 31);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("层微分", 13, 13);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("解算参数", 12, 12, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("计算", 24, 24);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("结果", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("新建计算", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode10,
            treeNode13,
            treeNode14,
            treeNode15});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("m1");
            this.tv_navigation = new System.Windows.Forms.TreeView();
            this.il_treeview = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.il_ui = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bu_loadmaterial = new System.Windows.Forms.Button();
            this.lv_material = new System.Windows.Forms.ListView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialDetailsControl1 = new PHTC.MaterialDetailsControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_rubbiness = new System.Windows.Forms.RadioButton();
            this.rb_plate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_thickness = new System.Windows.Forms.RadioButton();
            this.rb_temperature = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_hotfacetemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_navigation
            // 
            this.tv_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_navigation.ImageIndex = 0;
            this.tv_navigation.ImageList = this.il_treeview;
            this.tv_navigation.Location = new System.Drawing.Point(0, 0);
            this.tv_navigation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tv_navigation.Name = "tv_navigation";
            treeNode1.Name = "N_MaterialDet";
            treeNode1.Text = "节点3";
            treeNode2.Name = "节点4";
            treeNode2.Text = "节点4";
            treeNode3.ImageIndex = 9;
            treeNode3.Name = "N_Material";
            treeNode3.SelectedImageIndex = 9;
            treeNode3.Text = "材料参数";
            treeNode4.ImageIndex = 11;
            treeNode4.Name = "N_ModelParameter";
            treeNode4.SelectedImageIndex = 11;
            treeNode4.Text = "模型参数";
            treeNode5.ImageIndex = 25;
            treeNode5.Name = "N_HotfaceParameter";
            treeNode5.SelectedImageIndex = 25;
            treeNode5.Text = "热面参数";
            treeNode6.ImageIndex = 28;
            treeNode6.Name = "节点5";
            treeNode6.SelectedImageIndex = 28;
            treeNode6.Text = "第一层";
            treeNode7.ImageIndex = 28;
            treeNode7.Name = "节点21";
            treeNode7.SelectedImageIndex = 28;
            treeNode7.Text = "第二层";
            treeNode8.ImageIndex = 27;
            treeNode8.Name = "N_LayerInformation";
            treeNode8.SelectedImageIndex = 27;
            treeNode8.Text = "层信息";
            treeNode9.ImageIndex = 14;
            treeNode9.Name = "N_CodefaceBoundary";
            treeNode9.SelectedImageIndex = 14;
            treeNode9.Text = "冷面边界";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "N_CalculateModel";
            treeNode10.SelectedImageIndex = 0;
            treeNode10.Text = "计算模型";
            treeNode11.ImageIndex = 31;
            treeNode11.Name = "N_SubCriterion";
            treeNode11.SelectedImageIndex = 31;
            treeNode11.Text = "迭代收敛准则";
            treeNode12.ImageIndex = 13;
            treeNode12.Name = "N_LayerDifferential";
            treeNode12.SelectedImageIndex = 13;
            treeNode12.Text = "层微分";
            treeNode13.Checked = true;
            treeNode13.ImageIndex = 12;
            treeNode13.Name = "N_SolveParameter";
            treeNode13.SelectedImageIndex = 12;
            treeNode13.Text = "解算参数";
            treeNode14.ImageIndex = 24;
            treeNode14.Name = "N_Solve";
            treeNode14.SelectedImageIndex = 24;
            treeNode14.Text = "计算";
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
            this.tv_navigation.Size = new System.Drawing.Size(287, 278);
            this.tv_navigation.TabIndex = 0;
            this.tv_navigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnNavigationSelected);
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
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1445, 765);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tv_navigation);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(287, 765);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.bu_loadmaterial);
            this.tabPage1.Controls.Add(this.lv_material);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(279, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageList = this.il_ui;
            this.button2.Location = new System.Drawing.Point(158, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.ImageList = this.il_ui;
            this.button1.Location = new System.Drawing.Point(88, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "新建...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bu_loadmaterial
            // 
            this.bu_loadmaterial.ImageList = this.il_ui;
            this.bu_loadmaterial.Location = new System.Drawing.Point(4, 408);
            this.bu_loadmaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bu_loadmaterial.Name = "bu_loadmaterial";
            this.bu_loadmaterial.Size = new System.Drawing.Size(76, 29);
            this.bu_loadmaterial.TabIndex = 2;
            this.bu_loadmaterial.Text = "载入...";
            this.bu_loadmaterial.UseVisualStyleBackColor = true;
            // 
            // lv_material
            // 
            this.lv_material.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lv_material.Location = new System.Drawing.Point(4, 8);
            this.lv_material.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lv_material.Name = "lv_material";
            this.lv_material.Size = new System.Drawing.Size(363, 392);
            this.lv_material.TabIndex = 1;
            this.lv_material.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.materialDetailsControl1);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(279, 453);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // materialDetailsControl1
            // 
            this.materialDetailsControl1.Location = new System.Drawing.Point(11, 4);
            this.materialDetailsControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.materialDetailsControl1.Name = "materialDetailsControl1";
            this.materialDetailsControl1.Size = new System.Drawing.Size(331, 590);
            this.materialDetailsControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(279, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_rubbiness);
            this.groupBox2.Controls.Add(this.rb_plate);
            this.groupBox2.Location = new System.Drawing.Point(11, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(339, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "几何类型";
            // 
            // rb_rubbiness
            // 
            this.rb_rubbiness.AutoSize = true;
            this.rb_rubbiness.Location = new System.Drawing.Point(20, 75);
            this.rb_rubbiness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_rubbiness.Name = "rb_rubbiness";
            this.rb_rubbiness.Size = new System.Drawing.Size(88, 19);
            this.rb_rubbiness.TabIndex = 1;
            this.rb_rubbiness.Text = "多层圆筒";
            this.rb_rubbiness.UseVisualStyleBackColor = true;
            // 
            // rb_plate
            // 
            this.rb_plate.AutoSize = true;
            this.rb_plate.Checked = true;
            this.rb_plate.Location = new System.Drawing.Point(20, 36);
            this.rb_plate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_plate.Name = "rb_plate";
            this.rb_plate.Size = new System.Drawing.Size(88, 19);
            this.rb_plate.TabIndex = 0;
            this.rb_plate.TabStop = true;
            this.rb_plate.Text = "多层平壁";
            this.rb_plate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_thickness);
            this.groupBox1.Controls.Add(this.rb_temperature);
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "求解对象";
            // 
            // rb_thickness
            // 
            this.rb_thickness.AutoSize = true;
            this.rb_thickness.Location = new System.Drawing.Point(20, 75);
            this.rb_thickness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_thickness.Name = "rb_thickness";
            this.rb_thickness.Size = new System.Drawing.Size(223, 19);
            this.rb_thickness.TabIndex = 1;
            this.rb_thickness.Text = "某层厚度，各层温度以及热流";
            this.rb_thickness.UseVisualStyleBackColor = true;
            // 
            // rb_temperature
            // 
            this.rb_temperature.AutoSize = true;
            this.rb_temperature.Checked = true;
            this.rb_temperature.Location = new System.Drawing.Point(20, 36);
            this.rb_temperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_temperature.Name = "rb_temperature";
            this.rb_temperature.Size = new System.Drawing.Size(223, 19);
            this.rb_temperature.TabIndex = 0;
            this.rb_temperature.TabStop = true;
            this.rb_temperature.Text = "冷面温度，各层温度以及热流";
            this.rb_temperature.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Controls.Add(this.tb_hotfacetemperature);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(375, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(0, 89);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(372, 350);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Size = new System.Drawing.Size(364, 321);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "热面面积[m^2]";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textBox3);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.textBox2);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage7.Size = new System.Drawing.Size(364, 321);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 122);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 25);
            this.textBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "热面轴向长度[m]";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "热面径向半径[m]";
            // 
            // tb_hotfacetemperature
            // 
            this.tb_hotfacetemperature.Location = new System.Drawing.Point(15, 41);
            this.tb_hotfacetemperature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_hotfacetemperature.Name = "tb_hotfacetemperature";
            this.tb_hotfacetemperature.Size = new System.Drawing.Size(333, 25);
            this.tb_hotfacetemperature.TabIndex = 1;
            this.tb_hotfacetemperature.Text = "1600.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "热面温度[℃]";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(375, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(375, 452);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 765);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_navigation;
        private System.Windows.Forms.ImageList il_treeview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_rubbiness;
        private System.Windows.Forms.RadioButton rb_plate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_thickness;
        private System.Windows.Forms.RadioButton rb_temperature;
        private System.Windows.Forms.ListView lv_material;
        private System.Windows.Forms.Button bu_loadmaterial;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList il_ui;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tb_hotfacetemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage8;
        private MaterialDetailsControl materialDetailsControl1;
    }
}