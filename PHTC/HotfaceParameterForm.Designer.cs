namespace PHTC
{
    partial class HotfaceParameterForm
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
            this.tb_Temperature = new System.Windows.Forms.TextBox();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.bu_ok = new System.Windows.Forms.Button();
            this.tb_RorW = new System.Windows.Forms.TextBox();
            this.lb_RorW = new System.Windows.Forms.Label();
            this.tb_LorH = new System.Windows.Forms.TextBox();
            this.lb_LorH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "温度[℃]";
            // 
            // tb_Temperature
            // 
            this.tb_Temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Temperature.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_Temperature.Location = new System.Drawing.Point(109, 11);
            this.tb_Temperature.Name = "tb_Temperature";
            this.tb_Temperature.Size = new System.Drawing.Size(131, 21);
            this.tb_Temperature.TabIndex = 1;
            this.tb_Temperature.TextChanged += new System.EventHandler(this.OnTemperatureChanged);
            // 
            // bu_cancel
            // 
            this.bu_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bu_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_cancel.Location = new System.Drawing.Point(74, 110);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(75, 23);
            this.bu_cancel.TabIndex = 7;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(165, 110);
            this.bu_ok.Name = "bu_ok";
            this.bu_ok.Size = new System.Drawing.Size(75, 23);
            this.bu_ok.TabIndex = 6;
            this.bu_ok.Text = "确定";
            this.bu_ok.UseVisualStyleBackColor = true;
            this.bu_ok.Click += new System.EventHandler(this.bu_ok_Click);
            // 
            // tb_RorW
            // 
            this.tb_RorW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_RorW.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_RorW.Location = new System.Drawing.Point(109, 41);
            this.tb_RorW.Name = "tb_RorW";
            this.tb_RorW.Size = new System.Drawing.Size(131, 21);
            this.tb_RorW.TabIndex = 9;
            this.tb_RorW.Text = "1.0";
            // 
            // lb_RorW
            // 
            this.lb_RorW.AutoSize = true;
            this.lb_RorW.Location = new System.Drawing.Point(13, 45);
            this.lb_RorW.Name = "lb_RorW";
            this.lb_RorW.Size = new System.Drawing.Size(47, 12);
            this.lb_RorW.TabIndex = 8;
            this.lb_RorW.Text = "半径[m]";
            // 
            // tb_LorH
            // 
            this.tb_LorH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LorH.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_LorH.Location = new System.Drawing.Point(109, 72);
            this.tb_LorH.Name = "tb_LorH";
            this.tb_LorH.Size = new System.Drawing.Size(131, 21);
            this.tb_LorH.TabIndex = 11;
            this.tb_LorH.Text = "1.0";
            // 
            // lb_LorH
            // 
            this.lb_LorH.AutoSize = true;
            this.lb_LorH.Location = new System.Drawing.Point(13, 76);
            this.lb_LorH.Name = "lb_LorH";
            this.lb_LorH.Size = new System.Drawing.Size(71, 12);
            this.lb_LorH.TabIndex = 10;
            this.lb_LorH.Text = "轴向长度[m]";
            // 
            // HotfaceParameterForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(256, 142);
            this.Controls.Add(this.tb_LorH);
            this.Controls.Add(this.lb_LorH);
            this.Controls.Add(this.tb_RorW);
            this.Controls.Add(this.lb_RorW);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.bu_ok);
            this.Controls.Add(this.tb_Temperature);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotfaceParameterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "热面参数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Temperature;
        private System.Windows.Forms.Button bu_cancel;
        private System.Windows.Forms.Button bu_ok;
        private System.Windows.Forms.TextBox tb_RorW;
        private System.Windows.Forms.Label lb_RorW;
        private System.Windows.Forms.TextBox tb_LorH;
        private System.Windows.Forms.Label lb_LorH;
    }
}