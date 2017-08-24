namespace PHTC
{
    partial class ProjectSaveAsForm
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
            this.cb_share = new System.Windows.Forms.CheckBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.bu_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_share
            // 
            this.cb_share.AutoSize = true;
            this.cb_share.Checked = true;
            this.cb_share.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_share.Location = new System.Drawing.Point(302, 22);
            this.cb_share.Name = "cb_share";
            this.cb_share.Size = new System.Drawing.Size(45, 16);
            this.cb_share.TabIndex = 13;
            this.cb_share.Text = "共享";
            this.cb_share.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Location = new System.Drawing.Point(92, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(192, 21);
            this.tb_name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "工程名称";
            // 
            // bu_cancel
            // 
            this.bu_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bu_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_cancel.Location = new System.Drawing.Point(181, 66);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(75, 23);
            this.bu_cancel.TabIndex = 10;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(272, 66);
            this.bu_ok.Name = "bu_ok";
            this.bu_ok.Size = new System.Drawing.Size(75, 23);
            this.bu_ok.TabIndex = 9;
            this.bu_ok.Text = "确定";
            this.bu_ok.UseVisualStyleBackColor = true;
            this.bu_ok.Click += new System.EventHandler(this.bu_ok_Click);
            // 
            // ProjectSaveAsForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(363, 104);
            this.Controls.Add(this.cb_share);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.bu_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectSaveAsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "保存为...";
            this.Shown += new System.EventHandler(this.OnShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_share;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bu_cancel;
        private System.Windows.Forms.Button bu_ok;
    }
}