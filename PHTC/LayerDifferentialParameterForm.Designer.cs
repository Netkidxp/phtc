namespace PHTC
{
    partial class LayerDifferentialParameterForm
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
            this.nud_differential = new System.Windows.Forms.NumericUpDown();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.bu_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_differential)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "微分数量";
            // 
            // nud_differential
            // 
            this.nud_differential.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_differential.Location = new System.Drawing.Point(108, 26);
            this.nud_differential.Name = "nud_differential";
            this.nud_differential.Size = new System.Drawing.Size(50, 21);
            this.nud_differential.TabIndex = 1;
            // 
            // bu_cancel
            // 
            this.bu_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bu_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_cancel.Location = new System.Drawing.Point(24, 77);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(75, 23);
            this.bu_cancel.TabIndex = 2;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(121, 77);
            this.bu_ok.Name = "bu_ok";
            this.bu_ok.Size = new System.Drawing.Size(75, 23);
            this.bu_ok.TabIndex = 3;
            this.bu_ok.Text = "确定";
            this.bu_ok.UseVisualStyleBackColor = true;
            this.bu_ok.Click += new System.EventHandler(this.bu_ok_Click);
            // 
            // LayerDifferentialParameterForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(224, 112);
            this.Controls.Add(this.bu_ok);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.nud_differential);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LayerDifferentialParameterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "层微分参数";
            ((System.ComponentModel.ISupportInitialize)(this.nud_differential)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_differential;
        private System.Windows.Forms.Button bu_cancel;
        private System.Windows.Forms.Button bu_ok;
    }
}