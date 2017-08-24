namespace PHTC
{
    partial class ControlParameterForm
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
            this.cb_residual = new System.Windows.Forms.CheckBox();
            this.tb_residual = new System.Windows.Forms.TextBox();
            this.tb_maxstep = new System.Windows.Forms.TextBox();
            this.cb_maxstep = new System.Windows.Forms.CheckBox();
            this.bu_ok = new System.Windows.Forms.Button();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_residual
            // 
            this.cb_residual.AutoSize = true;
            this.cb_residual.Checked = true;
            this.cb_residual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_residual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_residual.Location = new System.Drawing.Point(27, 31);
            this.cb_residual.Name = "cb_residual";
            this.cb_residual.Size = new System.Drawing.Size(45, 16);
            this.cb_residual.TabIndex = 0;
            this.cb_residual.Text = "残差";
            this.cb_residual.UseVisualStyleBackColor = true;
            this.cb_residual.CheckedChanged += new System.EventHandler(this.OnCbResidualCheckChanged);
            // 
            // tb_residual
            // 
            this.tb_residual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_residual.Location = new System.Drawing.Point(107, 29);
            this.tb_residual.Name = "tb_residual";
            this.tb_residual.Size = new System.Drawing.Size(136, 21);
            this.tb_residual.TabIndex = 1;
            // 
            // tb_maxstep
            // 
            this.tb_maxstep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_maxstep.Location = new System.Drawing.Point(107, 67);
            this.tb_maxstep.Name = "tb_maxstep";
            this.tb_maxstep.Size = new System.Drawing.Size(136, 21);
            this.tb_maxstep.TabIndex = 3;
            // 
            // cb_maxstep
            // 
            this.cb_maxstep.AutoSize = true;
            this.cb_maxstep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_maxstep.Location = new System.Drawing.Point(27, 69);
            this.cb_maxstep.Name = "cb_maxstep";
            this.cb_maxstep.Size = new System.Drawing.Size(69, 16);
            this.cb_maxstep.TabIndex = 2;
            this.cb_maxstep.Text = "最大步数";
            this.cb_maxstep.UseVisualStyleBackColor = true;
            this.cb_maxstep.CheckedChanged += new System.EventHandler(this.OnCbMaxstepCheckChanged);
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(168, 107);
            this.bu_ok.Name = "bu_ok";
            this.bu_ok.Size = new System.Drawing.Size(75, 23);
            this.bu_ok.TabIndex = 4;
            this.bu_ok.Text = "确定";
            this.bu_ok.UseVisualStyleBackColor = true;
            this.bu_ok.Click += new System.EventHandler(this.bu_ok_Click);
            // 
            // bu_cancel
            // 
            this.bu_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bu_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_cancel.Location = new System.Drawing.Point(77, 107);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(75, 23);
            this.bu_cancel.TabIndex = 5;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // ControlParameterForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(287, 144);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.bu_ok);
            this.Controls.Add(this.tb_maxstep);
            this.Controls.Add(this.cb_maxstep);
            this.Controls.Add(this.tb_residual);
            this.Controls.Add(this.cb_residual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlParameterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ControlParameterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_residual;
        private System.Windows.Forms.TextBox tb_residual;
        private System.Windows.Forms.TextBox tb_maxstep;
        private System.Windows.Forms.CheckBox cb_maxstep;
        private System.Windows.Forms.Button bu_ok;
        private System.Windows.Forms.Button bu_cancel;
    }
}