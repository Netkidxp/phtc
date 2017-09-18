namespace PHTC
{
    partial class ColdBoundaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_class1 = new System.Windows.Forms.TabPage();
            this.tb_C1Hotflow = new System.Windows.Forms.TextBox();
            this.lb_C1Hotflow = new System.Windows.Forms.Label();
            this.tb_C1Temperature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_class2 = new System.Windows.Forms.TabPage();
            this.tb_C2Temperature = new System.Windows.Forms.TextBox();
            this.lb_C2Temperature = new System.Windows.Forms.Label();
            this.tb_C2Hotflow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tp_class3 = new System.Windows.Forms.TabPage();
            this.tb_C3Temperature = new System.Windows.Forms.TextBox();
            this.lb_C3Temperature = new System.Windows.Forms.Label();
            this.bu_Advanced = new System.Windows.Forms.Button();
            this.tb_C3Emissivity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_C3ConvectionFilmCoefficient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_C3AmbientTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bu_Ok = new System.Windows.Forms.Button();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.tc_main.SuspendLayout();
            this.tp_class1.SuspendLayout();
            this.tp_class2.SuspendLayout();
            this.tp_class3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "表面温度",
            "热流密度",
            "对流 辐射"});
            this.cb_type.Location = new System.Drawing.Point(47, 7);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(137, 20);
            this.cb_type.TabIndex = 1;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.OnCbTypeChanged);
            // 
            // tc_main
            // 
            this.tc_main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tc_main.Controls.Add(this.tp_class1);
            this.tc_main.Controls.Add(this.tp_class2);
            this.tc_main.Controls.Add(this.tp_class3);
            this.tc_main.Location = new System.Drawing.Point(-16, 32);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(371, 185);
            this.tc_main.TabIndex = 0;
            // 
            // tp_class1
            // 
            this.tp_class1.Controls.Add(this.tb_C1Hotflow);
            this.tp_class1.Controls.Add(this.lb_C1Hotflow);
            this.tp_class1.Controls.Add(this.tb_C1Temperature);
            this.tp_class1.Controls.Add(this.label2);
            this.tp_class1.Location = new System.Drawing.Point(4, 4);
            this.tp_class1.Name = "tp_class1";
            this.tp_class1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_class1.Size = new System.Drawing.Size(363, 159);
            this.tp_class1.TabIndex = 0;
            this.tp_class1.Text = "tabPage1";
            this.tp_class1.UseVisualStyleBackColor = true;
            // 
            // tb_C1Hotflow
            // 
            this.tb_C1Hotflow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C1Hotflow.Location = new System.Drawing.Point(182, 87);
            this.tb_C1Hotflow.Name = "tb_C1Hotflow";
            this.tb_C1Hotflow.Size = new System.Drawing.Size(129, 21);
            this.tb_C1Hotflow.TabIndex = 5;
            this.tb_C1Hotflow.Text = "2000.0";
            // 
            // lb_C1Hotflow
            // 
            this.lb_C1Hotflow.AutoSize = true;
            this.lb_C1Hotflow.Location = new System.Drawing.Point(46, 91);
            this.lb_C1Hotflow.Name = "lb_C1Hotflow";
            this.lb_C1Hotflow.Size = new System.Drawing.Size(83, 12);
            this.lb_C1Hotflow.TabIndex = 4;
            this.lb_C1Hotflow.Text = "目标热流量[W]";
            // 
            // tb_C1Temperature
            // 
            this.tb_C1Temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C1Temperature.Location = new System.Drawing.Point(182, 40);
            this.tb_C1Temperature.Name = "tb_C1Temperature";
            this.tb_C1Temperature.Size = new System.Drawing.Size(129, 21);
            this.tb_C1Temperature.TabIndex = 1;
            this.tb_C1Temperature.Text = "100.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "温度[℃]";
            // 
            // tp_class2
            // 
            this.tp_class2.Controls.Add(this.tb_C2Temperature);
            this.tp_class2.Controls.Add(this.lb_C2Temperature);
            this.tp_class2.Controls.Add(this.tb_C2Hotflow);
            this.tp_class2.Controls.Add(this.label6);
            this.tp_class2.Location = new System.Drawing.Point(4, 4);
            this.tp_class2.Name = "tp_class2";
            this.tp_class2.Padding = new System.Windows.Forms.Padding(3);
            this.tp_class2.Size = new System.Drawing.Size(363, 159);
            this.tp_class2.TabIndex = 1;
            this.tp_class2.Text = "tabPage2";
            this.tp_class2.UseVisualStyleBackColor = true;
            // 
            // tb_C2Temperature
            // 
            this.tb_C2Temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C2Temperature.Location = new System.Drawing.Point(192, 83);
            this.tb_C2Temperature.Name = "tb_C2Temperature";
            this.tb_C2Temperature.Size = new System.Drawing.Size(123, 21);
            this.tb_C2Temperature.TabIndex = 5;
            this.tb_C2Temperature.Text = "100.0";
            // 
            // lb_C2Temperature
            // 
            this.lb_C2Temperature.AutoSize = true;
            this.lb_C2Temperature.Location = new System.Drawing.Point(47, 87);
            this.lb_C2Temperature.Name = "lb_C2Temperature";
            this.lb_C2Temperature.Size = new System.Drawing.Size(77, 12);
            this.lb_C2Temperature.TabIndex = 4;
            this.lb_C2Temperature.Text = "目标温度[℃]";
            // 
            // tb_C2Hotflow
            // 
            this.tb_C2Hotflow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C2Hotflow.Location = new System.Drawing.Point(192, 40);
            this.tb_C2Hotflow.Name = "tb_C2Hotflow";
            this.tb_C2Hotflow.Size = new System.Drawing.Size(123, 21);
            this.tb_C2Hotflow.TabIndex = 3;
            this.tb_C2Hotflow.Text = "2000.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "热流量[W]";
            // 
            // tp_class3
            // 
            this.tp_class3.Controls.Add(this.tb_C3Temperature);
            this.tp_class3.Controls.Add(this.lb_C3Temperature);
            this.tp_class3.Controls.Add(this.bu_Advanced);
            this.tp_class3.Controls.Add(this.tb_C3Emissivity);
            this.tp_class3.Controls.Add(this.label5);
            this.tp_class3.Controls.Add(this.tb_C3ConvectionFilmCoefficient);
            this.tp_class3.Controls.Add(this.label4);
            this.tp_class3.Controls.Add(this.tb_C3AmbientTemperature);
            this.tp_class3.Controls.Add(this.label3);
            this.tp_class3.Location = new System.Drawing.Point(4, 4);
            this.tp_class3.Name = "tp_class3";
            this.tp_class3.Size = new System.Drawing.Size(363, 159);
            this.tp_class3.TabIndex = 2;
            this.tp_class3.Text = "tabPage3";
            this.tp_class3.UseVisualStyleBackColor = true;
            // 
            // tb_C3Temperature
            // 
            this.tb_C3Temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C3Temperature.Location = new System.Drawing.Point(173, 109);
            this.tb_C3Temperature.Name = "tb_C3Temperature";
            this.tb_C3Temperature.Size = new System.Drawing.Size(123, 21);
            this.tb_C3Temperature.TabIndex = 10;
            this.tb_C3Temperature.Text = "100.0";
            // 
            // lb_C3Temperature
            // 
            this.lb_C3Temperature.AutoSize = true;
            this.lb_C3Temperature.Location = new System.Drawing.Point(36, 111);
            this.lb_C3Temperature.Name = "lb_C3Temperature";
            this.lb_C3Temperature.Size = new System.Drawing.Size(77, 12);
            this.lb_C3Temperature.TabIndex = 9;
            this.lb_C3Temperature.Text = "目标温度[℃]";
            // 
            // bu_Advanced
            // 
            this.bu_Advanced.Location = new System.Drawing.Point(309, 44);
            this.bu_Advanced.Name = "bu_Advanced";
            this.bu_Advanced.Size = new System.Drawing.Size(38, 23);
            this.bu_Advanced.TabIndex = 8;
            this.bu_Advanced.Text = "辅助";
            this.bu_Advanced.UseVisualStyleBackColor = true;
            // 
            // tb_C3Emissivity
            // 
            this.tb_C3Emissivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C3Emissivity.Location = new System.Drawing.Point(173, 75);
            this.tb_C3Emissivity.Name = "tb_C3Emissivity";
            this.tb_C3Emissivity.Size = new System.Drawing.Size(124, 21);
            this.tb_C3Emissivity.TabIndex = 7;
            this.tb_C3Emissivity.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "发射率";
            // 
            // tb_C3ConvectionFilmCoefficient
            // 
            this.tb_C3ConvectionFilmCoefficient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C3ConvectionFilmCoefficient.Location = new System.Drawing.Point(173, 44);
            this.tb_C3ConvectionFilmCoefficient.Name = "tb_C3ConvectionFilmCoefficient";
            this.tb_C3ConvectionFilmCoefficient.Size = new System.Drawing.Size(124, 21);
            this.tb_C3ConvectionFilmCoefficient.TabIndex = 5;
            this.tb_C3ConvectionFilmCoefficient.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "对流换热系数[W/m^2℃]";
            // 
            // tb_C3AmbientTemperature
            // 
            this.tb_C3AmbientTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_C3AmbientTemperature.Location = new System.Drawing.Point(173, 13);
            this.tb_C3AmbientTemperature.Name = "tb_C3AmbientTemperature";
            this.tb_C3AmbientTemperature.Size = new System.Drawing.Size(124, 21);
            this.tb_C3AmbientTemperature.TabIndex = 3;
            this.tb_C3AmbientTemperature.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "环境温度[℃]";
            // 
            // bu_Ok
            // 
            this.bu_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_Ok.Location = new System.Drawing.Point(275, 5);
            this.bu_Ok.Name = "bu_Ok";
            this.bu_Ok.Size = new System.Drawing.Size(64, 23);
            this.bu_Ok.TabIndex = 2;
            this.bu_Ok.Text = "确定";
            this.bu_Ok.UseVisualStyleBackColor = true;
            this.bu_Ok.Click += new System.EventHandler(this.bu_Ok_Click);
            // 
            // bu_cancel
            // 
            this.bu_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bu_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_cancel.Location = new System.Drawing.Point(205, 5);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(64, 23);
            this.bu_cancel.TabIndex = 3;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // ColdBoundaryForm
            // 
            this.AcceptButton = this.bu_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(342, 179);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.bu_Ok);
            this.Controls.Add(this.tc_main);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColdBoundaryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "冷面边界";
            this.tc_main.ResumeLayout(false);
            this.tp_class1.ResumeLayout(false);
            this.tp_class1.PerformLayout();
            this.tp_class2.ResumeLayout(false);
            this.tp_class2.PerformLayout();
            this.tp_class3.ResumeLayout(false);
            this.tp_class3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_class1;
        private System.Windows.Forms.TabPage tp_class2;
        private System.Windows.Forms.TextBox tb_C1Temperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tp_class3;
        private System.Windows.Forms.TextBox tb_C3Emissivity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_C3ConvectionFilmCoefficient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_C3AmbientTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bu_Advanced;
        private System.Windows.Forms.Button bu_Ok;
        private System.Windows.Forms.TextBox tb_C2Hotflow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_C1Hotflow;
        private System.Windows.Forms.Label lb_C1Hotflow;
        private System.Windows.Forms.TextBox tb_C2Temperature;
        private System.Windows.Forms.Label lb_C2Temperature;
        private System.Windows.Forms.Label lb_C3Temperature;
        private System.Windows.Forms.TextBox tb_C3Temperature;
        private System.Windows.Forms.Button bu_cancel;
    }
}