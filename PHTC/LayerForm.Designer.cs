namespace PHTC
{
    partial class LayerForm
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cb_Material = new System.Windows.Forms.ComboBox();
            this.lb_Material = new System.Windows.Forms.Label();
            this.lb_Thickness = new System.Windows.Forms.Label();
            this.tb_Thickness = new System.Windows.Forms.TextBox();
            this.cb_TargetThickness = new System.Windows.Forms.CheckBox();
            this.bu_cancel = new System.Windows.Forms.Button();
            this.bu_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.tb_Resistance = new System.Windows.Forms.TextBox();
            this.lb_Resistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Location = new System.Drawing.Point(114, 29);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(172, 21);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.Text = "新建层...";
            this.tb_Name.TextChanged += new System.EventHandler(this.OnTbNameChanged);
            // 
            // cb_Material
            // 
            this.cb_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Material.FormattingEnabled = true;
            this.cb_Material.Location = new System.Drawing.Point(114, 96);
            this.cb_Material.Name = "cb_Material";
            this.cb_Material.Size = new System.Drawing.Size(172, 20);
            this.cb_Material.TabIndex = 2;
            this.cb_Material.SelectedValueChanged += new System.EventHandler(this.OnCbMaterialChanged);
            // 
            // lb_Material
            // 
            this.lb_Material.AutoSize = true;
            this.lb_Material.Location = new System.Drawing.Point(39, 99);
            this.lb_Material.Name = "lb_Material";
            this.lb_Material.Size = new System.Drawing.Size(29, 12);
            this.lb_Material.TabIndex = 3;
            this.lb_Material.Text = "材料";
            // 
            // lb_Thickness
            // 
            this.lb_Thickness.AutoSize = true;
            this.lb_Thickness.Location = new System.Drawing.Point(39, 132);
            this.lb_Thickness.Name = "lb_Thickness";
            this.lb_Thickness.Size = new System.Drawing.Size(47, 12);
            this.lb_Thickness.TabIndex = 4;
            this.lb_Thickness.Text = "厚度[m]";
            // 
            // tb_Thickness
            // 
            this.tb_Thickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Thickness.Location = new System.Drawing.Point(114, 129);
            this.tb_Thickness.Name = "tb_Thickness";
            this.tb_Thickness.Size = new System.Drawing.Size(108, 21);
            this.tb_Thickness.TabIndex = 5;
            this.tb_Thickness.Text = "1.0";
            this.tb_Thickness.TextChanged += new System.EventHandler(this.OnTbThicknessChanged);
            // 
            // cb_TargetThickness
            // 
            this.cb_TargetThickness.AutoSize = true;
            this.cb_TargetThickness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TargetThickness.Location = new System.Drawing.Point(243, 131);
            this.cb_TargetThickness.Name = "cb_TargetThickness";
            this.cb_TargetThickness.Size = new System.Drawing.Size(45, 16);
            this.cb_TargetThickness.TabIndex = 6;
            this.cb_TargetThickness.Text = "待求";
            this.cb_TargetThickness.UseVisualStyleBackColor = true;
            this.cb_TargetThickness.CheckedChanged += new System.EventHandler(this.OnCbTargetChanged);
            // 
            // bu_cancel
            // 
            this.bu_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bu_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_cancel.Location = new System.Drawing.Point(120, 202);
            this.bu_cancel.Name = "bu_cancel";
            this.bu_cancel.Size = new System.Drawing.Size(75, 23);
            this.bu_cancel.TabIndex = 8;
            this.bu_cancel.Text = "取消";
            this.bu_cancel.UseVisualStyleBackColor = true;
            // 
            // bu_ok
            // 
            this.bu_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu_ok.Location = new System.Drawing.Point(211, 202);
            this.bu_ok.Name = "bu_ok";
            this.bu_ok.Size = new System.Drawing.Size(75, 23);
            this.bu_ok.TabIndex = 7;
            this.bu_ok.Text = "确定";
            this.bu_ok.UseVisualStyleBackColor = true;
            this.bu_ok.Click += new System.EventHandler(this.bu_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "类型";
            // 
            // cb_Type
            // 
            this.cb_Type.AutoCompleteCustomSource.AddRange(new string[] {
            "普通层",
            "热阻层"});
            this.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "普通层",
            "热阻层"});
            this.cb_Type.Location = new System.Drawing.Point(114, 63);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(172, 20);
            this.cb_Type.TabIndex = 9;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.OnCbTypeSelectedChanged);
            // 
            // tb_Resistance
            // 
            this.tb_Resistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Resistance.Location = new System.Drawing.Point(114, 163);
            this.tb_Resistance.Name = "tb_Resistance";
            this.tb_Resistance.Size = new System.Drawing.Size(108, 21);
            this.tb_Resistance.TabIndex = 12;
            this.tb_Resistance.Text = "1.0";
            this.tb_Resistance.TextChanged += new System.EventHandler(this.OnTbResidualChanged);
            // 
            // lb_Resistance
            // 
            this.lb_Resistance.AutoSize = true;
            this.lb_Resistance.Location = new System.Drawing.Point(39, 165);
            this.lb_Resistance.Name = "lb_Resistance";
            this.lb_Resistance.Size = new System.Drawing.Size(71, 12);
            this.lb_Resistance.TabIndex = 11;
            this.lb_Resistance.Text = "热阻[KW^-1]";
            // 
            // LayerForm
            // 
            this.AcceptButton = this.bu_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bu_cancel;
            this.ClientSize = new System.Drawing.Size(337, 246);
            this.Controls.Add(this.tb_Resistance);
            this.Controls.Add(this.lb_Resistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.bu_cancel);
            this.Controls.Add(this.bu_ok);
            this.Controls.Add(this.cb_TargetThickness);
            this.Controls.Add(this.tb_Thickness);
            this.Controls.Add(this.lb_Thickness);
            this.Controls.Add(this.lb_Material);
            this.Controls.Add(this.cb_Material);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "LayerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "层信息";
            this.Load += new System.EventHandler(this.LayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cb_Material;
        private System.Windows.Forms.Label lb_Material;
        private System.Windows.Forms.Label lb_Thickness;
        private System.Windows.Forms.TextBox tb_Thickness;
        private System.Windows.Forms.CheckBox cb_TargetThickness;
        private System.Windows.Forms.Button bu_cancel;
        private System.Windows.Forms.Button bu_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox tb_Resistance;
        private System.Windows.Forms.Label lb_Resistance;
    }
}