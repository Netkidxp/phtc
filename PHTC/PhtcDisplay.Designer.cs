namespace PHTC
{
    partial class PhtcDisplay
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_hotflow = new System.Windows.Forms.Label();
            this.lb_temperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "热流量[W]:";
            // 
            // lb_hotflow
            // 
            this.lb_hotflow.AutoSize = true;
            this.lb_hotflow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_hotflow.Location = new System.Drawing.Point(463, 221);
            this.lb_hotflow.Name = "lb_hotflow";
            this.lb_hotflow.Size = new System.Drawing.Size(11, 12);
            this.lb_hotflow.TabIndex = 1;
            this.lb_hotflow.Text = "0";
            // 
            // lb_temperature
            // 
            this.lb_temperature.AutoSize = true;
            this.lb_temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_temperature.Location = new System.Drawing.Point(654, 221);
            this.lb_temperature.Name = "lb_temperature";
            this.lb_temperature.Size = new System.Drawing.Size(11, 12);
            this.lb_temperature.TabIndex = 3;
            this.lb_temperature.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "点温度[℃]:";
            // 
            // PhtcDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_temperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_hotflow);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PhtcDisplay";
            this.Size = new System.Drawing.Size(783, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_hotflow;
        private System.Windows.Forms.Label lb_temperature;
        private System.Windows.Forms.Label label3;
    }
}
