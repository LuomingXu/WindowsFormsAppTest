namespace WindowsFormsAppTest
{
    partial class FrmStuInfo
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
            this.txbClass = new System.Windows.Forms.TextBox();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbShi = new System.Windows.Forms.ComboBox();
            this.cmbSheng = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHoppies = new System.Windows.Forms.TabPage();
            this.tpExperience = new System.Windows.Forms.TabPage();
            this.tpSchool = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbClass
            // 
            this.txbClass.Location = new System.Drawing.Point(156, 101);
            this.txbClass.Name = "txbClass";
            this.txbClass.Size = new System.Drawing.Size(218, 35);
            this.txbClass.TabIndex = 18;
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(156, 22);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(206, 35);
            this.txbNumber.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "班级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "学号";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(17, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 51);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "提交";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 51);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "籍贯";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "市";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "省";
            // 
            // cmbShi
            // 
            this.cmbShi.FormattingEnabled = true;
            this.cmbShi.Location = new System.Drawing.Point(364, 199);
            this.cmbShi.Name = "cmbShi";
            this.cmbShi.Size = new System.Drawing.Size(121, 32);
            this.cmbShi.TabIndex = 23;
            // 
            // cmbSheng
            // 
            this.cmbSheng.FormattingEnabled = true;
            this.cmbSheng.Location = new System.Drawing.Point(142, 196);
            this.cmbSheng.Name = "cmbSheng";
            this.cmbSheng.Size = new System.Drawing.Size(121, 32);
            this.cmbSheng.TabIndex = 22;
            this.cmbSheng.SelectedIndexChanged += new System.EventHandler(this.CmbSheng_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbNumber);
            this.panel1.Controls.Add(this.cmbShi);
            this.panel1.Controls.Add(this.txbClass);
            this.panel1.Controls.Add(this.cmbSheng);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(109, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 250);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(109, 654);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 100);
            this.panel2.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHoppies);
            this.tabControl1.Controls.Add(this.tpExperience);
            this.tabControl1.Controls.Add(this.tpSchool);
            this.tabControl1.Location = new System.Drawing.Point(109, 348);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 248);
            this.tabControl1.TabIndex = 28;
            // 
            // tpHoppies
            // 
            this.tpHoppies.Location = new System.Drawing.Point(8, 39);
            this.tpHoppies.Name = "tpHoppies";
            this.tpHoppies.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoppies.Size = new System.Drawing.Size(520, 201);
            this.tpHoppies.TabIndex = 0;
            this.tpHoppies.Text = "兴趣";
            this.tpHoppies.UseVisualStyleBackColor = true;
            // 
            // tpExperience
            // 
            this.tpExperience.Location = new System.Drawing.Point(8, 39);
            this.tpExperience.Name = "tpExperience";
            this.tpExperience.Padding = new System.Windows.Forms.Padding(3);
            this.tpExperience.Size = new System.Drawing.Size(520, 201);
            this.tpExperience.TabIndex = 1;
            this.tpExperience.Text = "经验";
            this.tpExperience.UseVisualStyleBackColor = true;
            // 
            // tpSchool
            // 
            this.tpSchool.Location = new System.Drawing.Point(8, 39);
            this.tpSchool.Name = "tpSchool";
            this.tpSchool.Size = new System.Drawing.Size(520, 201);
            this.tpSchool.TabIndex = 2;
            this.tpSchool.Text = "学校";
            this.tpSchool.UseVisualStyleBackColor = true;
            // 
            // FrmStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 801);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStuInfo";
            this.Text = "FrmStuInfo";
            this.Load += new System.EventHandler(this.FrmStuInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txbClass;
        public System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbShi;
        public System.Windows.Forms.ComboBox cmbSheng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHoppies;
        private System.Windows.Forms.TabPage tpExperience;
        private System.Windows.Forms.TabPage tpSchool;
    }
}