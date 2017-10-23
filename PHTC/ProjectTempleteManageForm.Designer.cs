namespace PHTC
{
    partial class ProjectTempleteManageForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cb_class3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_class2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_class1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lb_pts = new System.Windows.Forms.ListBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.bu_updatelocal = new System.Windows.Forms.Button();
            this.bu_update = new System.Windows.Forms.Button();
            this.bu_addlocal = new System.Windows.Forms.Button();
            this.bu_add = new System.Windows.Forms.Button();
            this.bu_deleteall = new System.Windows.Forms.Button();
            this.bu_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(776, 508);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.bu_updatelocal);
            this.splitContainer2.Panel2.Controls.Add(this.bu_update);
            this.splitContainer2.Panel2.Controls.Add(this.bu_addlocal);
            this.splitContainer2.Panel2.Controls.Add(this.bu_add);
            this.splitContainer2.Panel2.Controls.Add(this.bu_deleteall);
            this.splitContainer2.Panel2.Controls.Add(this.bu_delete);
            this.splitContainer2.Size = new System.Drawing.Size(776, 475);
            this.splitContainer2.SplitterDistance = 427;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.cb_class3);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.cb_class2);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.cb_class1);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(776, 427);
            this.splitContainer3.SplitterDistance = 188;
            this.splitContainer3.TabIndex = 0;
            // 
            // cb_class3
            // 
            this.cb_class3.FormattingEnabled = true;
            this.cb_class3.Location = new System.Drawing.Point(24, 159);
            this.cb_class3.Name = "cb_class3";
            this.cb_class3.Size = new System.Drawing.Size(142, 20);
            this.cb_class3.TabIndex = 5;
            this.cb_class3.TextChanged += new System.EventHandler(this.OnClass3TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "类别三";
            // 
            // cb_class2
            // 
            this.cb_class2.FormattingEnabled = true;
            this.cb_class2.Location = new System.Drawing.Point(24, 97);
            this.cb_class2.Name = "cb_class2";
            this.cb_class2.Size = new System.Drawing.Size(142, 20);
            this.cb_class2.TabIndex = 3;
            this.cb_class2.TextChanged += new System.EventHandler(this.OnClass2TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类别二";
            // 
            // cb_class1
            // 
            this.cb_class1.FormattingEnabled = true;
            this.cb_class1.Location = new System.Drawing.Point(24, 35);
            this.cb_class1.Name = "cb_class1";
            this.cb_class1.Size = new System.Drawing.Size(142, 20);
            this.cb_class1.TabIndex = 1;
            this.cb_class1.TextChanged += new System.EventHandler(this.OnClass1TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别一";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lb_pts);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tb_description);
            this.splitContainer4.Size = new System.Drawing.Size(584, 427);
            this.splitContainer4.SplitterDistance = 292;
            this.splitContainer4.TabIndex = 0;
            // 
            // lb_pts
            // 
            this.lb_pts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_pts.FormattingEnabled = true;
            this.lb_pts.ItemHeight = 12;
            this.lb_pts.Location = new System.Drawing.Point(0, 0);
            this.lb_pts.Name = "lb_pts";
            this.lb_pts.Size = new System.Drawing.Size(292, 427);
            this.lb_pts.TabIndex = 0;
            this.lb_pts.SelectedIndexChanged += new System.EventHandler(this.OnPtsSelectedChanged);
            // 
            // tb_description
            // 
            this.tb_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_description.Location = new System.Drawing.Point(0, 0);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(288, 427);
            this.tb_description.TabIndex = 0;
            // 
            // bu_updatelocal
            // 
            this.bu_updatelocal.Location = new System.Drawing.Point(396, 11);
            this.bu_updatelocal.Name = "bu_updatelocal";
            this.bu_updatelocal.Size = new System.Drawing.Size(114, 23);
            this.bu_updatelocal.TabIndex = 5;
            this.bu_updatelocal.Text = "更新为本地工程";
            this.bu_updatelocal.UseVisualStyleBackColor = true;
            this.bu_updatelocal.Visible = false;
            // 
            // bu_update
            // 
            this.bu_update.Location = new System.Drawing.Point(268, 11);
            this.bu_update.Name = "bu_update";
            this.bu_update.Size = new System.Drawing.Size(114, 23);
            this.bu_update.TabIndex = 4;
            this.bu_update.Text = "更新为当前工程";
            this.bu_update.UseVisualStyleBackColor = true;
            this.bu_update.Visible = false;
            // 
            // bu_addlocal
            // 
            this.bu_addlocal.Location = new System.Drawing.Point(652, 11);
            this.bu_addlocal.Name = "bu_addlocal";
            this.bu_addlocal.Size = new System.Drawing.Size(114, 23);
            this.bu_addlocal.TabIndex = 3;
            this.bu_addlocal.Text = "添加本地工程";
            this.bu_addlocal.UseVisualStyleBackColor = true;
            this.bu_addlocal.Click += new System.EventHandler(this.bu_addlocal_Click);
            // 
            // bu_add
            // 
            this.bu_add.Location = new System.Drawing.Point(524, 11);
            this.bu_add.Name = "bu_add";
            this.bu_add.Size = new System.Drawing.Size(114, 23);
            this.bu_add.TabIndex = 2;
            this.bu_add.Text = "添加当前工程";
            this.bu_add.UseVisualStyleBackColor = true;
            this.bu_add.Click += new System.EventHandler(this.bu_add_Click);
            // 
            // bu_deleteall
            // 
            this.bu_deleteall.Location = new System.Drawing.Point(140, 11);
            this.bu_deleteall.Name = "bu_deleteall";
            this.bu_deleteall.Size = new System.Drawing.Size(114, 23);
            this.bu_deleteall.TabIndex = 1;
            this.bu_deleteall.Text = "删除本类所有模板";
            this.bu_deleteall.UseVisualStyleBackColor = true;
            this.bu_deleteall.Click += new System.EventHandler(this.bu_deleteall_Click);
            // 
            // bu_delete
            // 
            this.bu_delete.Location = new System.Drawing.Point(12, 11);
            this.bu_delete.Name = "bu_delete";
            this.bu_delete.Size = new System.Drawing.Size(114, 23);
            this.bu_delete.TabIndex = 0;
            this.bu_delete.Text = "删除所选模板";
            this.bu_delete.UseVisualStyleBackColor = true;
            this.bu_delete.Click += new System.EventHandler(this.bu_delete_Click);
            // 
            // ProjectTempleteManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 508);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProjectTempleteManageForm";
            this.Text = "工程模板管理";
            this.Load += new System.EventHandler(this.ProjectTempleteManageForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ComboBox cb_class3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_class2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_class1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox lb_pts;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Button bu_updatelocal;
        private System.Windows.Forms.Button bu_update;
        private System.Windows.Forms.Button bu_addlocal;
        private System.Windows.Forms.Button bu_add;
        private System.Windows.Forms.Button bu_deleteall;
        private System.Windows.Forms.Button bu_delete;
    }
}