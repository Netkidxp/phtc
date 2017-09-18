namespace PHTC
{
    partial class MaterialDetailsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDetailsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_usefor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_owner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_remark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_density = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ct_hc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_hc = new System.Windows.Forms.DataGridView();
            this.rb_hc_function = new System.Windows.Forms.RadioButton();
            this.rb_hc_disperse = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ct_sh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_sh = new System.Windows.Forms.DataGridView();
            this.rb_sh_function = new System.Windows.Forms.RadioButton();
            this.rb_sh_disperse = new System.Windows.Forms.RadioButton();
            this.cb_share = new System.Windows.Forms.CheckBox();
            this.bu_f1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_hc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_sh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "材料名称";
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Location = new System.Drawing.Point(76, 17);
            this.tb_name.MaxLength = 250;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(618, 21);
            this.tb_name.TabIndex = 1;
            // 
            // tb_code
            // 
            this.tb_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_code.Location = new System.Drawing.Point(115, 17);
            this.tb_code.MaxLength = 250;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(614, 21);
            this.tb_code.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "牌号";
            // 
            // tb_usefor
            // 
            this.tb_usefor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_usefor.Location = new System.Drawing.Point(115, 49);
            this.tb_usefor.MaxLength = 250;
            this.tb_usefor.Name = "tb_usefor";
            this.tb_usefor.Size = new System.Drawing.Size(614, 21);
            this.tb_usefor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "应用领域";
            // 
            // tb_owner
            // 
            this.tb_owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_owner.Location = new System.Drawing.Point(115, 81);
            this.tb_owner.MaxLength = 250;
            this.tb_owner.Name = "tb_owner";
            this.tb_owner.ReadOnly = true;
            this.tb_owner.Size = new System.Drawing.Size(614, 21);
            this.tb_owner.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "建立人";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(19, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 366);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_remark);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_density);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_code);
            this.tabPage1.Controls.Add(this.tb_owner);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_usefor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_remark
            // 
            this.tb_remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_remark.Location = new System.Drawing.Point(115, 146);
            this.tb_remark.MaxLength = 250;
            this.tb_remark.Multiline = true;
            this.tb_remark.Name = "tb_remark";
            this.tb_remark.Size = new System.Drawing.Size(614, 175);
            this.tb_remark.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "备注";
            // 
            // tb_density
            // 
            this.tb_density.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_density.Location = new System.Drawing.Point(115, 113);
            this.tb_density.MaxLength = 20;
            this.tb_density.Name = "tb_density";
            this.tb_density.Size = new System.Drawing.Size(614, 21);
            this.tb_density.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "密度[kg m^-3]";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.ct_hc);
            this.tabPage2.Controls.Add(this.dgv_hc);
            this.tabPage2.Controls.Add(this.rb_hc_function);
            this.tabPage2.Controls.Add(this.rb_hc_disperse);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "导热系数";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ct_hc
            // 
            chartArea1.Name = "ChartArea1";
            this.ct_hc.ChartAreas.Add(chartArea1);
            this.ct_hc.Location = new System.Drawing.Point(363, 47);
            this.ct_hc.Name = "ct_hc";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.ct_hc.Series.Add(series1);
            this.ct_hc.Size = new System.Drawing.Size(358, 269);
            this.ct_hc.TabIndex = 4;
            this.ct_hc.Text = "chart1";
            // 
            // dgv_hc
            // 
            this.dgv_hc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_hc.Location = new System.Drawing.Point(18, 47);
            this.dgv_hc.Name = "dgv_hc";
            this.dgv_hc.RowTemplate.Height = 23;
            this.dgv_hc.Size = new System.Drawing.Size(316, 270);
            this.dgv_hc.TabIndex = 3;
            this.dgv_hc.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnHCCellEndEdit);
            this.dgv_hc.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.OnHCDGVCellValidating);
            // 
            // rb_hc_function
            // 
            this.rb_hc_function.AutoSize = true;
            this.rb_hc_function.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_hc_function.Location = new System.Drawing.Point(83, 15);
            this.rb_hc_function.Name = "rb_hc_function";
            this.rb_hc_function.Size = new System.Drawing.Size(58, 16);
            this.rb_hc_function.TabIndex = 2;
            this.rb_hc_function.TabStop = true;
            this.rb_hc_function.Text = "多项式";
            this.rb_hc_function.UseVisualStyleBackColor = true;
            // 
            // rb_hc_disperse
            // 
            this.rb_hc_disperse.AutoSize = true;
            this.rb_hc_disperse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_hc_disperse.Location = new System.Drawing.Point(18, 15);
            this.rb_hc_disperse.Name = "rb_hc_disperse";
            this.rb_hc_disperse.Size = new System.Drawing.Size(58, 16);
            this.rb_hc_disperse.TabIndex = 1;
            this.rb_hc_disperse.TabStop = true;
            this.rb_hc_disperse.Text = "离散点";
            this.rb_hc_disperse.UseVisualStyleBackColor = true;
            this.rb_hc_disperse.CheckedChanged += new System.EventHandler(this.OnRbHcCheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.ct_sh);
            this.tabPage3.Controls.Add(this.dgv_sh);
            this.tabPage3.Controls.Add(this.rb_sh_function);
            this.tabPage3.Controls.Add(this.rb_sh_disperse);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(751, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "比热容";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ct_sh
            // 
            chartArea2.Name = "ChartArea1";
            this.ct_sh.ChartAreas.Add(chartArea2);
            this.ct_sh.Location = new System.Drawing.Point(363, 47);
            this.ct_sh.Name = "ct_sh";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.ct_sh.Series.Add(series2);
            this.ct_sh.Size = new System.Drawing.Size(358, 269);
            this.ct_sh.TabIndex = 4;
            this.ct_sh.Text = "chart2";
            // 
            // dgv_sh
            // 
            this.dgv_sh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sh.Location = new System.Drawing.Point(18, 47);
            this.dgv_sh.Name = "dgv_sh";
            this.dgv_sh.RowTemplate.Height = 23;
            this.dgv_sh.Size = new System.Drawing.Size(316, 270);
            this.dgv_sh.TabIndex = 3;
            this.dgv_sh.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnSHCellEndEdit);
            this.dgv_sh.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.OnSHDGVCellValidating);
            // 
            // rb_sh_function
            // 
            this.rb_sh_function.AutoSize = true;
            this.rb_sh_function.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_sh_function.Location = new System.Drawing.Point(83, 15);
            this.rb_sh_function.Name = "rb_sh_function";
            this.rb_sh_function.Size = new System.Drawing.Size(58, 16);
            this.rb_sh_function.TabIndex = 2;
            this.rb_sh_function.Text = "多项式";
            this.rb_sh_function.UseVisualStyleBackColor = true;
            // 
            // rb_sh_disperse
            // 
            this.rb_sh_disperse.AutoSize = true;
            this.rb_sh_disperse.Checked = true;
            this.rb_sh_disperse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_sh_disperse.Location = new System.Drawing.Point(18, 15);
            this.rb_sh_disperse.Name = "rb_sh_disperse";
            this.rb_sh_disperse.Size = new System.Drawing.Size(58, 16);
            this.rb_sh_disperse.TabIndex = 1;
            this.rb_sh_disperse.TabStop = true;
            this.rb_sh_disperse.Text = "离散点";
            this.rb_sh_disperse.UseVisualStyleBackColor = true;
            this.rb_sh_disperse.CheckedChanged += new System.EventHandler(this.OnRbShCheckedChanged);
            // 
            // cb_share
            // 
            this.cb_share.AutoSize = true;
            this.cb_share.Location = new System.Drawing.Point(724, 18);
            this.cb_share.Name = "cb_share";
            this.cb_share.Size = new System.Drawing.Size(48, 16);
            this.cb_share.TabIndex = 9;
            this.cb_share.Text = "共享";
            this.cb_share.UseVisualStyleBackColor = true;
            // 
            // bu_f1
            // 
            this.bu_f1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_f1.Location = new System.Drawing.Point(677, 431);
            this.bu_f1.Name = "bu_f1";
            this.bu_f1.Size = new System.Drawing.Size(101, 23);
            this.bu_f1.TabIndex = 11;
            this.bu_f1.Text = "f1";
            this.bu_f1.UseVisualStyleBackColor = true;
            this.bu_f1.Click += new System.EventHandler(this.bu_f1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PHTC.Properties.Resources.QQ截图20170915144650;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PHTC.Properties.Resources.QQ截图20170915144650;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "（其中T为温度值,单位为K）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "（其中T为温度值,单位为K）";
            // 
            // MaterialDetailsForm
            // 
            this.AcceptButton = this.bu_f1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 462);
            this.Controls.Add(this.bu_f1);
            this.Controls.Add(this.cb_share);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaterialDetailsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "材料细节";
            this.Load += new System.EventHandler(this.MaterialDetailsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_hc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_sh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_usefor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_owner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_density;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_remark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_hc_function;
        private System.Windows.Forms.RadioButton rb_hc_disperse;
        private System.Windows.Forms.DataGridView dgv_hc;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_hc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_sh;
        private System.Windows.Forms.DataGridView dgv_sh;
        private System.Windows.Forms.RadioButton rb_sh_function;
        private System.Windows.Forms.RadioButton rb_sh_disperse;
        private System.Windows.Forms.CheckBox cb_share;
        private System.Windows.Forms.Button bu_f1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}