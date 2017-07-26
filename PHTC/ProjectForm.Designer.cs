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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.tv_navigation = new System.Windows.Forms.TreeView();
            this.il_treeview = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.il_ui = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_navigation
            // 
            this.tv_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_navigation.ImageIndex = 0;
            this.tv_navigation.ImageList = this.il_treeview;
            this.tv_navigation.Location = new System.Drawing.Point(0, 0);
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
            this.tv_navigation.Size = new System.Drawing.Size(287, 488);
            this.tv_navigation.TabIndex = 0;
            this.tv_navigation.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.BeforeTvNavCollapse);
            this.tv_navigation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.BeforeTvNavExpand);
            this.tv_navigation.DoubleClick += new System.EventHandler(this.OnTvNavigationDoubleClick);
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
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 612);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tv_navigation);
            this.splitContainer2.Size = new System.Drawing.Size(287, 612);
            this.splitContainer2.SplitterDistance = 488;
            this.splitContainer2.TabIndex = 0;
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
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProjectForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_navigation;
        //FTreeView tv_navigation;
        private System.Windows.Forms.ImageList il_treeview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList il_ui;
    }
}