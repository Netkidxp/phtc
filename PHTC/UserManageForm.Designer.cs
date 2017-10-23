namespace PHTC
{
    partial class UserManageForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ok = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_paste = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(675, 413);
            this.dgv.TabIndex = 0;
            this.dgv.DoubleClick += new System.EventHandler(this.OnDbClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_refresh,
            this.mi_ok,
            this.mi_delete,
            this.toolStripSeparator1,
            this.mi_copy,
            this.mi_paste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 120);
            // 
            // mi_refresh
            // 
            this.mi_refresh.Name = "mi_refresh";
            this.mi_refresh.Size = new System.Drawing.Size(152, 22);
            this.mi_refresh.Text = "刷新";
            this.mi_refresh.Click += new System.EventHandler(this.mi_refresh_Click);
            // 
            // mi_ok
            // 
            this.mi_ok.Name = "mi_ok";
            this.mi_ok.Size = new System.Drawing.Size(152, 22);
            this.mi_ok.Text = "确认修改";
            this.mi_ok.Click += new System.EventHandler(this.mi_ok_Click);
            // 
            // mi_delete
            // 
            this.mi_delete.Name = "mi_delete";
            this.mi_delete.Size = new System.Drawing.Size(152, 22);
            this.mi_delete.Text = "删除用户";
            this.mi_delete.Click += new System.EventHandler(this.mi_delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_copy
            // 
            this.mi_copy.Name = "mi_copy";
            this.mi_copy.Size = new System.Drawing.Size(152, 22);
            this.mi_copy.Text = "拷贝";
            this.mi_copy.Click += new System.EventHandler(this.mi_copy_Click);
            // 
            // mi_paste
            // 
            this.mi_paste.Name = "mi_paste";
            this.mi_paste.Size = new System.Drawing.Size(152, 22);
            this.mi_paste.Text = "粘贴";
            this.mi_paste.Click += new System.EventHandler(this.mi_paste_Click);
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.dgv);
            this.Name = "UserManageForm";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_refresh;
        private System.Windows.Forms.ToolStripMenuItem mi_ok;
        private System.Windows.Forms.ToolStripMenuItem mi_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_copy;
        private System.Windows.Forms.ToolStripMenuItem mi_paste;
    }
}