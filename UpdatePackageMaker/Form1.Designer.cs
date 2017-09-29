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
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Url";
            // 
            // tb_urlbase
            // 
            this.tb_urlbase.Location = new System.Drawing.Point(151, 116);
            this.tb_urlbase.Name = "tb_urlbase";
            this.tb_urlbase.Size = new System.Drawing.Size(256, 21);
            this.tb_urlbase.TabIndex = 4;
            this.tb_urlbase.Text = "http://";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "更新内容描述";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(151, 167);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(256, 171);
            this.tb_desc.TabIndex = 6;
            // 
            // bu_go
            // 
            this.bu_go.Location = new System.Drawing.Point(332, 369);
            this.bu_go.Name = "bu_go";
            this.bu_go.Size = new System.Drawing.Size(75, 23);
            this.bu_go.TabIndex = 8;
            this.bu_go.Text = "go";
            this.bu_go.UseVisualStyleBackColor = true;
            this.bu_go.Click += new System.EventHandler(this.bu_go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 417);
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
    }
}

