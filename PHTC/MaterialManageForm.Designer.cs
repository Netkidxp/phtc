namespace PHTC
{
    partial class MaterialManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialManageForm));
            this.tb_input = new System.Windows.Forms.TextBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filterPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_owner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_usefor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_share = new System.Windows.Forms.CheckBox();
            this.cb_self = new System.Windows.Forms.CheckBox();
            this.cb_filterPlanel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.AutoCompleteCustomSource.AddRange(new string[] {
            "哈哈",
            "测试",
            "刚好 ",
            "浮球"});
            this.tb_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_input.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_input.Location = new System.Drawing.Point(25, 49);
            this.tb_input.Margin = new System.Windows.Forms.Padding(4);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(947, 25);
            this.tb_input.TabIndex = 0;
            this.tb_input.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.AllowUserToOrderColumns = true;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_list.Location = new System.Drawing.Point(25, 277);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.Height = 27;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(1072, 483);
            this.dgv_list.TabIndex = 1;
            this.dgv_list.CurrentCellChanged += new System.EventHandler(this.OnDGVCurrentCellChanged);
            this.dgv_list.DoubleClick += new System.EventHandler(this.OnDGVDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CDetailsToolStripMenuItem,
            this.CLoadToolStripMenuItem,
            this.CDeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 82);
            this.contextMenuStrip1.Text = "载入(&L)";
            // 
            // CDetailsToolStripMenuItem
            // 
            this.CDetailsToolStripMenuItem.Image = global::PHTC.Properties.Resources.style_edit;
            this.CDetailsToolStripMenuItem.Name = "CDetailsToolStripMenuItem";
            this.CDetailsToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.CDetailsToolStripMenuItem.Text = "详情(&T)";
            this.CDetailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // CLoadToolStripMenuItem
            // 
            this.CLoadToolStripMenuItem.Image = global::PHTC.Properties.Resources.Add_16x16;
            this.CLoadToolStripMenuItem.Name = "CLoadToolStripMenuItem";
            this.CLoadToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.CLoadToolStripMenuItem.Text = "载入(&L)";
            this.CLoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // CDeleteToolStripMenuItem
            // 
            this.CDeleteToolStripMenuItem.Image = global::PHTC.Properties.Resources.Delete16x16;
            this.CDeleteToolStripMenuItem.Name = "CDeleteToolStripMenuItem";
            this.CDeleteToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.CDeleteToolStripMenuItem.Text = "删除(&D)";
            this.CDeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.MaterialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.FileToolStripMenuItem.Text = "文件(&F)";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.ExitToolStripMenuItem.Text = "退出(&X)";
            // 
            // MaterialToolStripMenuItem
            // 
            this.MaterialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.DetailsToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.LoadToolStripMenuItem});
            this.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem";
            this.MaterialToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.MaterialToolStripMenuItem.Text = "材料(&M)";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Image = global::PHTC.Properties.Resources._new;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.NewToolStripMenuItem.Text = "新建...(&N)";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // DetailsToolStripMenuItem
            // 
            this.DetailsToolStripMenuItem.Image = global::PHTC.Properties.Resources.style_edit;
            this.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem";
            this.DetailsToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.DetailsToolStripMenuItem.Text = "详情...(&T)";
            this.DetailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::PHTC.Properties.Resources.Delete16x16;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.DeleteToolStripMenuItem.Text = "删除(&D)";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Image = global::PHTC.Properties.Resources.Add_16x16;
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.LoadToolStripMenuItem.Text = "载入(&L)";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add_16x16.png");
            this.imageList1.Images.SetKeyName(1, "Delete16x16.png");
            this.imageList1.Images.SetKeyName(2, "new_button.png");
            this.imageList1.Images.SetKeyName(3, "plugin.png");
            this.imageList1.Images.SetKeyName(4, "solversettings_16x16.png");
            this.imageList1.Images.SetKeyName(5, "style_edit.png");
            this.imageList1.Images.SetKeyName(6, "new.png");
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.groupBox1);
            this.filterPanel.Location = new System.Drawing.Point(25, 92);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1072, 169);
            this.filterPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_owner);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_usefor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.cb_share);
            this.groupBox1.Controls.Add(this.cb_self);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "所有者";
            // 
            // tb_owner
            // 
            this.tb_owner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_owner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_owner.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_owner.Location = new System.Drawing.Point(119, 138);
            this.tb_owner.Name = "tb_owner";
            this.tb_owner.Size = new System.Drawing.Size(828, 25);
            this.tb_owner.TabIndex = 8;
            this.tb_owner.TextChanged += new System.EventHandler(this.OnTbOwnerTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "应用领域";
            // 
            // tb_usefor
            // 
            this.tb_usefor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_usefor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_usefor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_usefor.Location = new System.Drawing.Point(119, 100);
            this.tb_usefor.Name = "tb_usefor";
            this.tb_usefor.Size = new System.Drawing.Size(828, 25);
            this.tb_usefor.TabIndex = 6;
            this.tb_usefor.TextChanged += new System.EventHandler(this.OnTbUseforTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "牌号";
            // 
            // tb_code
            // 
            this.tb_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_code.Location = new System.Drawing.Point(119, 62);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(828, 25);
            this.tb_code.TabIndex = 4;
            this.tb_code.TextChanged += new System.EventHandler(this.OnTbCodeTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // tb_name
            // 
            this.tb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_name.Location = new System.Drawing.Point(119, 24);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(828, 25);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.OnTbNameTextChanged);
            // 
            // cb_share
            // 
            this.cb_share.AutoSize = true;
            this.cb_share.Location = new System.Drawing.Point(977, 65);
            this.cb_share.Name = "cb_share";
            this.cb_share.Size = new System.Drawing.Size(74, 19);
            this.cb_share.TabIndex = 1;
            this.cb_share.Text = "共享的";
            this.cb_share.UseVisualStyleBackColor = true;
            this.cb_share.CheckedChanged += new System.EventHandler(this.OnCbShareCheckedChanged);
            // 
            // cb_self
            // 
            this.cb_self.AutoSize = true;
            this.cb_self.Location = new System.Drawing.Point(977, 27);
            this.cb_self.Name = "cb_self";
            this.cb_self.Size = new System.Drawing.Size(74, 19);
            this.cb_self.TabIndex = 0;
            this.cb_self.Text = "自己的";
            this.cb_self.UseVisualStyleBackColor = true;
            this.cb_self.CheckedChanged += new System.EventHandler(this.OnCbSelfCheckedChanged);
            // 
            // cb_filterPlanel
            // 
            this.cb_filterPlanel.AutoSize = true;
            this.cb_filterPlanel.Location = new System.Drawing.Point(1005, 51);
            this.cb_filterPlanel.Name = "cb_filterPlanel";
            this.cb_filterPlanel.Size = new System.Drawing.Size(89, 19);
            this.cb_filterPlanel.TabIndex = 5;
            this.cb_filterPlanel.Text = "筛选面板";
            this.cb_filterPlanel.UseVisualStyleBackColor = true;
            this.cb_filterPlanel.CheckedChanged += new System.EventHandler(this.OnCBFilterPlanelCheckedChanged);
            // 
            // MaterialManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 787);
            this.Controls.Add(this.cb_filterPlanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaterialManageForm";
            this.Text = "MaterialManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CDeleteToolStripMenuItem;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.CheckBox cb_share;
        private System.Windows.Forms.CheckBox cb_self;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_owner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_usefor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_filterPlanel;
    }
}