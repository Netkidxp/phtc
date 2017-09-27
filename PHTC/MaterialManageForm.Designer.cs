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
            this.CNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_input.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_input.Location = new System.Drawing.Point(106, 10);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(564, 21);
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
            this.dgv_list.Location = new System.Drawing.Point(11, 190);
            this.dgv_list.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.Height = 27;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(764, 345);
            this.dgv_list.TabIndex = 1;
            this.dgv_list.CurrentCellChanged += new System.EventHandler(this.OnDGVCurrentCellChanged);
            this.dgv_list.DoubleClick += new System.EventHandler(this.OnDGVDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CNewToolStripMenuItem,
            this.CCopyToolStripMenuItem,
            this.toolStripSeparator1,
            this.CDetailsToolStripMenuItem,
            this.CLoadToolStripMenuItem,
            this.toolStripSeparator2,
            this.CDeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 126);
            this.contextMenuStrip1.Text = "载入(&L)";
            this.contextMenuStrip1.Opened += new System.EventHandler(this.OnContentMenuOpened);
            // 
            // CNewToolStripMenuItem
            // 
            this.CNewToolStripMenuItem.Name = "CNewToolStripMenuItem";
            this.CNewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CNewToolStripMenuItem.Text = "新建(&N)...";
            this.CNewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // CCopyToolStripMenuItem
            // 
            this.CCopyToolStripMenuItem.Name = "CCopyToolStripMenuItem";
            this.CCopyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CCopyToolStripMenuItem.Text = "复制副本(&C)";
            this.CCopyToolStripMenuItem.Click += new System.EventHandler(this.CCopyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // CDetailsToolStripMenuItem
            // 
            this.CDetailsToolStripMenuItem.Name = "CDetailsToolStripMenuItem";
            this.CDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CDetailsToolStripMenuItem.Text = "详情(&T)...";
            this.CDetailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // CLoadToolStripMenuItem
            // 
            this.CLoadToolStripMenuItem.Name = "CLoadToolStripMenuItem";
            this.CLoadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CLoadToolStripMenuItem.Text = "载入(&L)";
            this.CLoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // CDeleteToolStripMenuItem
            // 
            this.CDeleteToolStripMenuItem.Name = "CDeleteToolStripMenuItem";
            this.CDeleteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CDeleteToolStripMenuItem.Text = "删除(&D)";
            this.CDeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
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
            this.filterPanel.Location = new System.Drawing.Point(9, 35);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(766, 142);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(756, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "所有者";
            // 
            // tb_owner
            // 
            this.tb_owner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_owner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_owner.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_owner.Location = new System.Drawing.Point(89, 110);
            this.tb_owner.Margin = new System.Windows.Forms.Padding(2);
            this.tb_owner.Name = "tb_owner";
            this.tb_owner.Size = new System.Drawing.Size(564, 21);
            this.tb_owner.TabIndex = 8;
            this.tb_owner.TextChanged += new System.EventHandler(this.OnTbOwnerTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "应用领域";
            // 
            // tb_usefor
            // 
            this.tb_usefor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_usefor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_usefor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_usefor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_usefor.Location = new System.Drawing.Point(89, 80);
            this.tb_usefor.Margin = new System.Windows.Forms.Padding(2);
            this.tb_usefor.Name = "tb_usefor";
            this.tb_usefor.Size = new System.Drawing.Size(564, 21);
            this.tb_usefor.TabIndex = 6;
            this.tb_usefor.TextChanged += new System.EventHandler(this.OnTbUseforTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "牌号";
            // 
            // tb_code
            // 
            this.tb_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_code.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_code.Location = new System.Drawing.Point(89, 50);
            this.tb_code.Margin = new System.Windows.Forms.Padding(2);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(564, 21);
            this.tb_code.TabIndex = 4;
            this.tb_code.TextChanged += new System.EventHandler(this.OnTbCodeTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // tb_name
            // 
            this.tb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_name.Location = new System.Drawing.Point(89, 19);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(564, 21);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.OnTbNameTextChanged);
            // 
            // cb_share
            // 
            this.cb_share.AutoSize = true;
            this.cb_share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_share.Location = new System.Drawing.Point(676, 52);
            this.cb_share.Margin = new System.Windows.Forms.Padding(2);
            this.cb_share.Name = "cb_share";
            this.cb_share.Size = new System.Drawing.Size(57, 16);
            this.cb_share.TabIndex = 1;
            this.cb_share.Text = "共享的";
            this.cb_share.UseVisualStyleBackColor = true;
            this.cb_share.CheckedChanged += new System.EventHandler(this.OnCbShareCheckedChanged);
            // 
            // cb_self
            // 
            this.cb_self.AutoSize = true;
            this.cb_self.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_self.Location = new System.Drawing.Point(676, 22);
            this.cb_self.Margin = new System.Windows.Forms.Padding(2);
            this.cb_self.Name = "cb_self";
            this.cb_self.Size = new System.Drawing.Size(57, 16);
            this.cb_self.TabIndex = 0;
            this.cb_self.Text = "自己的";
            this.cb_self.UseVisualStyleBackColor = true;
            this.cb_self.CheckedChanged += new System.EventHandler(this.OnCbSelfCheckedChanged);
            // 
            // cb_filterPlanel
            // 
            this.cb_filterPlanel.AutoSize = true;
            this.cb_filterPlanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_filterPlanel.Location = new System.Drawing.Point(693, 14);
            this.cb_filterPlanel.Margin = new System.Windows.Forms.Padding(2);
            this.cb_filterPlanel.Name = "cb_filterPlanel";
            this.cb_filterPlanel.Size = new System.Drawing.Size(69, 16);
            this.cb_filterPlanel.TabIndex = 5;
            this.cb_filterPlanel.Text = "筛选面板";
            this.cb_filterPlanel.UseVisualStyleBackColor = true;
            this.cb_filterPlanel.CheckedChanged += new System.EventHandler(this.OnCBFilterPlanelCheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "关键词";
            // 
            // MaterialManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_filterPlanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.tb_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaterialManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "材料库管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem CNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CCopyToolStripMenuItem;
    }
}