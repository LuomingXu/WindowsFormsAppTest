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
            this.SuspendLayout();
            // 
            // txbClass
            // 
            this.txbClass.Location = new System.Drawing.Point(301, 130);
            this.txbClass.Name = "txbClass";
            this.txbClass.Size = new System.Drawing.Size(218, 35);
            this.txbClass.TabIndex = 18;
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(301, 51);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(206, 35);
            this.txbNumber.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "班级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "学号";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(109, 460);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 51);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "提交";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 51);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "籍贯";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "市";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "省";
            // 
            // cmbShi
            // 
            this.cmbShi.FormattingEnabled = true;
            this.cmbShi.Location = new System.Drawing.Point(509, 228);
            this.cmbShi.Name = "cmbShi";
            this.cmbShi.Size = new System.Drawing.Size(121, 32);
            this.cmbShi.TabIndex = 23;
            // 
            // cmbSheng
            // 
            this.cmbSheng.FormattingEnabled = true;
            this.cmbSheng.Location = new System.Drawing.Point(287, 225);
            this.cmbSheng.Name = "cmbSheng";
            this.cmbSheng.Size = new System.Drawing.Size(121, 32);
            this.cmbSheng.TabIndex = 22;
            this.cmbSheng.SelectedIndexChanged += new System.EventHandler(this.CmbSheng_SelectedIndexChanged);
            // 
            // FrmStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbShi);
            this.Controls.Add(this.cmbSheng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbClass);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FrmStuInfo";
            this.Text = "FrmStuInfo";
            this.Load += new System.EventHandler(this.FrmStuInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}