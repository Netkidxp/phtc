namespace UpdatePackageMaker
{
    partial class Form1
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
            this.bu_dir = new System.Windows.Forms.Button();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.tb_ver = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_urlbase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.bu_go = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_cmds = new System.Windows.Forms.ListBox();
            this.tb_cmd = new System.Windows.Forms.TextBox();
            this.bu_addcmd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bu_dir
            // 
            this.bu_dir.Location = new System.Drawing.Point(44, 26);
            this.bu_dir.Name = "bu_dir";
            this.bu_dir.Size = new System.Drawing.Size(75, 23);
            this.bu_dir.TabIndex = 0;
            this.bu_dir.Text = "选择目录";
            this.bu_dir.UseVisualStyleBackColor = true;
            this.bu_dir.Click += new System.EventHandler(this.bu_dir_Click);
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(151, 27);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.ReadOnly = true;
            this.tb_dir.Size = new System.Drawing.Size(256, 21);
            this.tb_dir.TabIndex = 1;
            // 
            // tb_ver
            // 
            this.tb_ver.Location = new System.Drawing.Point(151, 70);
            this.tb_ver.Name = "tb_ver";
            this.tb_ver.Size = new System.Drawing.Size(256, 21);
            this.tb_ver.TabIndex = 2;
            this.tb_ver.Text = "1.0.0";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(42, 73);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(41, 12);
            this.l1.TabIndex = 3;
            this.l1.Text = "版本号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "更新包Url";
            // 
            // tb_urlbase
            // 
            this.tb_urlbase.Location = new System.Drawing.Point(151, 116);
            this.tb_urlbase.Name = "tb_urlbase";
            this.tb_urlbase.Size = new System.Drawing.Size(256, 21);
            this.tb_urlbase.TabIndex = 4;
            this.tb_urlbase.Text = "http://192.168.2.88/update/update.pkg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "更新内容描述";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(151, 334);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(256, 139);
            this.tb_desc.TabIndex = 6;
            // 
            // bu_go
            // 
            this.bu_go.Location = new System.Drawing.Point(332, 485);
            this.bu_go.Name = "bu_go";
            this.bu_go.Size = new System.Drawing.Size(75, 23);
            this.bu_go.TabIndex = 8;
            this.bu_go.Text = "go";
            this.bu_go.UseVisualStyleBackColor = true;
            this.bu_go.Click += new System.EventHandler(this.bu_go_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cmds";
            // 
            // lb_cmds
            // 
            this.lb_cmds.FormattingEnabled = true;
            this.lb_cmds.ItemHeight = 12;
            this.lb_cmds.Location = new System.Drawing.Point(151, 203);
            this.lb_cmds.Name = "lb_cmds";
            this.lb_cmds.Size = new System.Drawing.Size(256, 112);
            this.lb_cmds.TabIndex = 10;
            // 
            // tb_cmd
            // 
            this.tb_cmd.Location = new System.Drawing.Point(151, 153);
            this.tb_cmd.Name = "tb_cmd";
            this.tb_cmd.Size = new System.Drawing.Size(164, 21);
            this.tb_cmd.TabIndex = 11;
            // 
            // bu_addcmd
            // 
            this.bu_addcmd.Location = new System.Drawing.Point(340, 151);
            this.bu_addcmd.Name = "bu_addcmd";
            this.bu_addcmd.Size = new System.Drawing.Size(29, 23);
            this.bu_addcmd.TabIndex = 12;
            this.bu_addcmd.Text = "+";
            this.bu_addcmd.UseVisualStyleBackColor = true;
            this.bu_addcmd.Click += new System.EventHandler(this.bu_addcmd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "c";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bu_addcmd);
            this.Controls.Add(this.tb_cmd);
            this.Controls.Add(this.lb_cmds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bu_go);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_urlbase);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.tb_ver);
            this.Controls.Add(this.tb_dir);
            this.Controls.Add(this.bu_dir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bu_dir;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.TextBox tb_ver;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_urlbase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Button bu_go;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_cmds;
        private System.Windows.Forms.TextBox tb_cmd;
        private System.Windows.Forms.Button bu_addcmd;
        private System.Windows.Forms.Button button1;
    }
}

