namespace PHTC
{
    partial class ProjectLoadForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_keyword = new System.Windows.Forms.TextBox();
            this.cb_self = new System.Windows.Forms.CheckBox();
            this.cb_share = new System.Windows.Forms.CheckBox();
            this.dgv_projects = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_load = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "筛选";
            // 
            // tb_keyword
            // 
            this.tb_keyword.AutoCompleteCustomSource.AddRange(new string[] {
            "哈哈",
            "测试",
            "刚好 ",
            "浮球"});
            this.tb_keyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_keyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_keyword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_keyword.Location = new System.Drawing.Point(78, 6);
            this.tb_keyword.Name = "tb_keyword";
            this.tb_keyword.Size = new System.Drawing.Size(396, 21);
            this.tb_keyword.TabIndex = 7;
            this.tb_keyword.TextChanged += new System.EventHandler(this.OnTbKeywordChanged);
            // 
            // cb_self
            // 
            this.cb_self.AutoSize = true;
            this.cb_self.Checked = true;
            this.cb_self.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_self.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_self.Location = new System.Drawing.Point(494, 9);
            this.cb_self.Name = "cb_self";
            this.cb_self.Size = new System.Drawing.Size(57, 16);
            this.cb_self.TabIndex = 9;
            this.cb_self.Text = "自己的";
            this.cb_self.UseVisualStyleBackColor = true;
            this.cb_self.CheckedChanged += new System.EventHandler(this.OnCbSelfChanged);
            // 
            // cb_share
            // 
            this.cb_share.AutoSize = true;
            this.cb_share.Checked = true;
            this.cb_share.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_share.Location = new System.Drawing.Point(560, 9);
            this.cb_share.Name = "cb_share";
            this.cb_share.Size = new System.Drawing.Size(57, 16);
            this.cb_share.TabIndex = 10;
            this.cb_share.Text = "共享的";
            this.cb_share.UseVisualStyleBackColor = true;
            this.cb_share.CheckedChanged += new System.EventHandler(this.OnCbShareChanged);
            // 
            // dgv_projects
            // 
            this.dgv_projects.AllowUserToAddRows = false;
            this.dgv_projects.AllowUserToDeleteRows = false;
            this.dgv_projects.AllowUserToOrderColumns = true;
            this.dgv_projects.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projects.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_projects.Location = new System.Drawing.Point(12, 67);
            this.dgv_projects.Name = "dgv_projects";
            this.dgv_projects.ReadOnly = true;
            this.dgv_projects.RowTemplate.Height = 23;
            this.dgv_projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_projects.Size = new System.Drawing.Size(608, 348);
            this.dgv_projects.TabIndex = 11;
            this.dgv_projects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDgvDoubleClick);
            this.dgv_projects.SelectionChanged += new System.EventHandler(this.OnDgvSelectionChanged);
            this.dgv_projects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDgvKeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_load,
            this.mi_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // mi_load
            // 
            this.mi_load.Name = "mi_load";
            this.mi_load.Size = new System.Drawing.Size(117, 22);
            this.mi_load.Text = "载入(&L)";
            this.mi_load.Click += new System.EventHandler(this.mi_load_Click);
            // 
            // mi_delete
            // 
            this.mi_delete.Name = "mi_delete";
            this.mi_delete.Size = new System.Drawing.Size(117, 22);
            this.mi_delete.Text = "删除(&D)";
            this.mi_delete.Click += new System.EventHandler(this.mi_delete_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(78, 37);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(114, 21);
            this.dtp_start.TabIndex = 12;
            this.dtp_start.ValueChanged += new System.EventHandler(this.OnDtpStartChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "保存时间";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(217, 37);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(112, 21);
            this.dtp_end.TabIndex = 14;
            this.dtp_end.ValueChanged += new System.EventHandler(this.OnDtpEndChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "-";
            // 
            // ProjectLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dgv_projects);
            this.Controls.Add(this.cb_share);
            this.Controls.Add(this.cb_self);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_keyword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectLoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工程检索";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_keyword;
        private System.Windows.Forms.CheckBox cb_self;
        private System.Windows.Forms.CheckBox cb_share;
        private System.Windows.Forms.DataGridView dgv_projects;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_load;
        private System.Windows.Forms.ToolStripMenuItem mi_delete;
    }
}