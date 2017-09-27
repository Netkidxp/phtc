namespace PHTC
{
    partial class ProjectParameterForm
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
            this.cb_SolverType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_GeometrySchema = new System.Windows.Forms.ComboBox();
            this.bu_ok = new System.Windows.Forms.Button();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_share = new System.Windows.Forms.CheckBox();
            this.tb_remark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_SolverType
            // 
            this.cb_SolverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SolverType.FormattingEnabled = true;
            this.cb_SolverType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cb_SolverType.Items.AddRange(new object[] {
            "温度",
            "厚度"});
            this.cb_SolverType.Location = new System.Drawing.Point(87, 54);
            this.cb_SolverType.Name = "cb_SolverType";
            this.cb_SolverType.Size = new System.Drawing.Size(192, 20);
            this.cb_SolverType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "几何类型";
            // 
            // cb_GeometrySchema
            // 
            this.cb_GeometrySchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GeometrySchema.FormattingEnabled = true;
            this.cb_GeometrySchema.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cb_GeometrySchema.Items.AddRange(new object[] {
            "平板",
            "圆筒"});
            this.cb_GeometrySchema.Location = new System.Drawing.Point(87, 85);
            this.cb_GeometrySchema.Name = "cb_GeometrySchema";
            this.cb_GeometrySchema.Size = new System.Drawing.Size(192, 20);
            this.cb_GeometrySchema.TabIndex = 2;
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(257, 237);
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
            this.bu_cancel.Location = new System.Drawing.Point(166, 237);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(75, 23);
            this.bu_cancel.TabIndex = 5;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "工程名称";
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Location = new System.Drawing.Point(87, 23);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(192, 21);
            this.tb_name.TabIndex = 7;
            // 
            // cb_share
            // 
            this.cb_share.AutoSize = true;
            this.cb_share.Checked = true;
            this.cb_share.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_share.Location = new System.Drawing.Point(297, 25);
            this.cb_share.Name = "cb_share";
            this.cb_share.Size = new System.Drawing.Size(45, 16);
            this.cb_share.TabIndex = 8;
            this.cb_share.Text = "共享";
            this.cb_share.UseVisualStyleBackColor = true;
            // 
            // tb_remark
            // 
            this.tb_remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_remark.Location = new System.Drawing.Point(87, 118);
            this.tb_remark.Multiline = true;
            this.tb_remark.Name = "tb_remark";
            this.tb_remark.Size = new System.Drawing.Size(192, 101);
            this.tb_remark.TabIndex = 10;
            this.tb_remark.Text = "这是...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "备注";
            // 
            // ProjectParameterForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(358, 274);
            this.Controls.Add(this.tb_remark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_share);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.bu_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_GeometrySchema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_SolverType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectParameterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工程参数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_SolverType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_GeometrySchema;
        private System.Windows.Forms.Button bu_ok;
        private System.Windows.Forms.Button bu_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.CheckBox cb_share;
        private System.Windows.Forms.TextBox tb_remark;
        private System.Windows.Forms.Label label4;
    }
}