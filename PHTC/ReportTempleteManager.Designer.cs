namespace PHTC
{
    partial class ReportTempleteManager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bu_add = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bu_path = new System.Windows.Forms.Button();
            this.tb_induction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.cms_list = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.cms_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bu_add);
            this.splitContainer1.Panel1.Controls.Add(this.tb_path);
            this.splitContainer1.Panel1.Controls.Add(this.bu_path);
            this.splitContainer1.Panel1.Controls.Add(this.tb_induction);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tb_name);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cb_type);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_list);
            this.splitContainer1.Size = new System.Drawing.Size(769, 429);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // bu_add
            // 
            this.bu_add.Location = new System.Drawing.Point(139, 379);
            this.bu_add.Name = "bu_add";
            this.bu_add.Size = new System.Drawing.Size(75, 23);
            this.bu_add.TabIndex = 8;
            this.bu_add.Text = "添加";
            this.bu_add.UseVisualStyleBackColor = true;
            this.bu_add.Click += new System.EventHandler(this.bu_add_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(15, 329);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(199, 21);
            this.tb_path.TabIndex = 7;
            // 
            // bu_path
            // 
            this.bu_path.Location = new System.Drawing.Point(13, 300);
            this.bu_path.Name = "bu_path";
            this.bu_path.Size = new System.Drawing.Size(71, 23);
            this.bu_path.TabIndex = 6;
            this.bu_path.Text = "模板文件";
            this.bu_path.UseVisualStyleBackColor = true;
            this.bu_path.Click += new System.EventHandler(this.bu_path_Click);
            // 
            // tb_induction
            // 
            this.tb_induction.Location = new System.Drawing.Point(93, 117);
            this.tb_induction.Multiline = true;
            this.tb_induction.Name = "tb_induction";
            this.tb_induction.Size = new System.Drawing.Size(121, 161);
            this.tb_induction.TabIndex = 5;
            this.tb_induction.Text = "新模板";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "简介";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(93, 73);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 21);
            this.tb_name.TabIndex = 3;
            this.tb_name.Text = "新模板";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Word模板(类型0)",
            "Html模板(类型1)"});
            this.cb_type.Location = new System.Drawing.Point(93, 28);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 20);
            this.cb_type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型";
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.ContextMenuStrip = this.cms_list;
            this.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_list.Location = new System.Drawing.Point(0, 0);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(509, 429);
            this.dgv_list.TabIndex = 0;
            // 
            // cms_list
            // 
            this.cms_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_refresh,
            this.toolStripSeparator1,
            this.mi_delete});
            this.cms_list.Name = "cms_list";
            this.cms_list.Size = new System.Drawing.Size(153, 76);
            // 
            // mi_refresh
            // 
            this.mi_refresh.Name = "mi_refresh";
            this.mi_refresh.Size = new System.Drawing.Size(152, 22);
            this.mi_refresh.Text = "刷新";
            this.mi_refresh.Click += new System.EventHandler(this.mi_refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // mi_delete
            // 
            this.mi_delete.Name = "mi_delete";
            this.mi_delete.Size = new System.Drawing.Size(152, 22);
            this.mi_delete.Text = "删除";
            this.mi_delete.Click += new System.EventHandler(this.mi_delete_Click);
            // 
            // ReportTempleteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 429);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportTempleteManager";
            this.Text = "报表模板管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.cms_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_induction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bu_add;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button bu_path;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ContextMenuStrip cms_list;
        private System.Windows.Forms.ToolStripMenuItem mi_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_delete;
    }
}

