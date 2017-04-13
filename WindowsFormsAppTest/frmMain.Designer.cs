namespace WindowsFormsAppTest
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_In = new System.Windows.Forms.Button();
            this.MainExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_In
            // 
            this.Login_In.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_In.Location = new System.Drawing.Point(318, 88);
            this.Login_In.Name = "Login_In";
            this.Login_In.Size = new System.Drawing.Size(310, 107);
            this.Login_In.TabIndex = 0;
            this.Login_In.Text = "登录窗口";
            this.Login_In.UseVisualStyleBackColor = true;
            this.Login_In.Click += new System.EventHandler(this.Login_In_Click);
            // 
            // MainExit
            // 
            this.MainExit.Location = new System.Drawing.Point(352, 384);
            this.MainExit.Name = "MainExit";
            this.MainExit.Size = new System.Drawing.Size(229, 87);
            this.MainExit.TabIndex = 1;
            this.MainExit.Text = "退出";
            this.MainExit.UseVisualStyleBackColor = true;
            this.MainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 693);
            this.Controls.Add(this.MainExit);
            this.Controls.Add(this.Login_In);
            this.Name = "FrmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_In;
        private System.Windows.Forms.Button MainExit;
    }
}

