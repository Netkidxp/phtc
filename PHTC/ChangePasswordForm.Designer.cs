namespace PHTC
{
    partial class ChangePasswordForm
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
            this.tb_oldpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bu_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_oldpassword
            // 
            this.tb_oldpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_oldpassword.Location = new System.Drawing.Point(107, 31);
            this.tb_oldpassword.Name = "tb_oldpassword";
            this.tb_oldpassword.PasswordChar = '*';
            this.tb_oldpassword.Size = new System.Drawing.Size(116, 21);
            this.tb_oldpassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "原密码";
            // 
            // tb_password1
            // 
            this.tb_password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password1.Location = new System.Drawing.Point(107, 67);
            this.tb_password1.Name = "tb_password1";
            this.tb_password1.PasswordChar = '*';
            this.tb_password1.Size = new System.Drawing.Size(116, 21);
            this.tb_password1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "新密码";
            // 
            // tb_password2
            // 
            this.tb_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password2.Location = new System.Drawing.Point(107, 103);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.PasswordChar = '*';
            this.tb_password2.Size = new System.Drawing.Size(116, 21);
            this.tb_password2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "重复";
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(187, 150);
            this.bu_ok.Name = "bu_ok";
            this.bu_ok.Size = new System.Drawing.Size(75, 23);
            this.bu_ok.TabIndex = 12;
            this.bu_ok.Text = "修改";
            this.bu_ok.UseVisualStyleBackColor = true;
            this.bu_ok.Click += new System.EventHandler(this.bu_ok_Click);
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 185);
            this.Controls.Add(this.bu_ok);
            this.Controls.Add(this.tb_password2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_oldpassword);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_oldpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_password1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bu_ok;
    }
}