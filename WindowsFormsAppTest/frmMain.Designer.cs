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
            this.btnMath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSheng = new System.Windows.Forms.ComboBox();
            this.cmbShi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbClass = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_In
            // 
            this.Login_In.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_In.Location = new System.Drawing.Point(80, 128);
            this.Login_In.Name = "Login_In";
            this.Login_In.Size = new System.Drawing.Size(310, 107);
            this.Login_In.TabIndex = 0;
            this.Login_In.Text = "登录窗口";
            this.Login_In.UseVisualStyleBackColor = true;
            this.Login_In.Click += new System.EventHandler(this.Login_In_Click);
            // 
            // MainExit
            // 
            this.MainExit.Location = new System.Drawing.Point(101, 641);
            this.MainExit.Name = "MainExit";
            this.MainExit.Size = new System.Drawing.Size(229, 87);
            this.MainExit.TabIndex = 1;
            this.MainExit.Text = "退出";
            this.MainExit.UseVisualStyleBackColor = true;
            this.MainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // btnMath
            // 
            this.btnMath.Location = new System.Drawing.Point(80, 369);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(319, 101);
            this.btnMath.TabIndex = 2;
            this.btnMath.Text = "三阶矩阵求行列式";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.BtnMath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "性别";
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(38, 28);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(65, 28);
            this.rdbMan.TabIndex = 4;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "男";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(174, 28);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(65, 28);
            this.rdbWoman.TabIndex = 5;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "女";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbMan);
            this.panel1.Controls.Add(this.rdbWoman);
            this.panel1.Location = new System.Drawing.Point(855, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 88);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "籍贯";
            // 
            // cmbSheng
            // 
            this.cmbSheng.FormattingEnabled = true;
            this.cmbSheng.Location = new System.Drawing.Point(915, 394);
            this.cmbSheng.Name = "cmbSheng";
            this.cmbSheng.Size = new System.Drawing.Size(121, 32);
            this.cmbSheng.TabIndex = 7;
            this.cmbSheng.SelectedIndexChanged += new System.EventHandler(this.CmbSheng_SelectedIndexChanged);
            // 
            // cmbShi
            // 
            this.cmbShi.FormattingEnabled = true;
            this.cmbShi.Location = new System.Drawing.Point(1157, 391);
            this.cmbShi.Name = "cmbShi";
            this.cmbShi.Size = new System.Drawing.Size(121, 32);
            this.cmbShi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1055, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "省";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1317, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "市";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "学号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 704);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "班级";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(795, 586);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(100, 35);
            this.txbNumber.TabIndex = 13;
            // 
            // txbClass
            // 
            this.txbClass.Location = new System.Drawing.Point(795, 692);
            this.txbClass.Name = "txbClass";
            this.txbClass.Size = new System.Drawing.Size(100, 35);
            this.txbClass.TabIndex = 14;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(945, 790);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(203, 53);
            this.btnInput.TabIndex = 15;
            this.btnInput.Text = "录入信息";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 905);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txbClass);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbShi);
            this.Controls.Add(this.cmbSheng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMath);
            this.Controls.Add(this.MainExit);
            this.Controls.Add(this.Login_In);
            this.Name = "FrmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_In;
        private System.Windows.Forms.Button MainExit;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSheng;
        private System.Windows.Forms.ComboBox cmbShi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbClass;
        private System.Windows.Forms.Button btnInput;
    }
}

