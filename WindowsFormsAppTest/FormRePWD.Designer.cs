namespace WindowsFormsAppTest
{
    /// <summary>
    /// 密码成功忘记之后的重新修改
    /// </summary>
    partial class FormRePWD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRePWD));
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPWDQueston = new System.Windows.Forms.ComboBox();
            this.textPWDAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPWDConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMailAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancle.Location = new System.Drawing.Point(494, 635);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(219, 99);
            this.btnCancle.TabIndex = 23;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(128, 635);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(282, 89);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "确定忘记密码";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(180, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "问题答案";
            // 
            // cmbPWDQueston
            // 
            this.cmbPWDQueston.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPWDQueston.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPWDQueston.FormattingEnabled = true;
            this.cmbPWDQueston.Items.AddRange(new object[] {
            "父母的姓名",
            "喜欢的人",
            "寝室号"});
            this.cmbPWDQueston.Location = new System.Drawing.Point(407, 431);
            this.cmbPWDQueston.Name = "cmbPWDQueston";
            this.cmbPWDQueston.Size = new System.Drawing.Size(278, 45);
            this.cmbPWDQueston.TabIndex = 4;
            // 
            // textPWDAnswer
            // 
            this.textPWDAnswer.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWDAnswer.Location = new System.Drawing.Point(407, 514);
            this.textPWDAnswer.Name = "textPWDAnswer";
            this.textPWDAnswer.Size = new System.Drawing.Size(278, 50);
            this.textPWDAnswer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(137, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "密码提示问题";
            // 
            // textPWDConfirm
            // 
            this.textPWDConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWDConfirm.Location = new System.Drawing.Point(397, 225);
            this.textPWDConfirm.Name = "textPWDConfirm";
            this.textPWDConfirm.PasswordChar = '*';
            this.textPWDConfirm.Size = new System.Drawing.Size(278, 50);
            this.textPWDConfirm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(170, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "密码确认";
            // 
            // textPWD
            // 
            this.textPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWD.Location = new System.Drawing.Point(397, 146);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(278, 50);
            this.textPWD.TabIndex = 2;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(397, 66);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(278, 50);
            this.textID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(200, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(179, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "用户名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(216, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 28;
            this.label6.Text = "邮箱";
            // 
            // TxtMailAddress
            // 
            this.TxtMailAddress.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtMailAddress.Location = new System.Drawing.Point(397, 326);
            this.TxtMailAddress.Name = "TxtMailAddress";
            this.TxtMailAddress.Size = new System.Drawing.Size(278, 50);
            this.TxtMailAddress.TabIndex = 4;
            // 
            // FormRePWD
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(864, 805);
            this.Controls.Add(this.TxtMailAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPWDQueston);
            this.Controls.Add(this.textPWDAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPWDConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPWD);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRePWD";
            this.Text = "FormRePWD";
            this.Load += new System.EventHandler(this.FormRePWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbPWDQueston;
        private System.Windows.Forms.TextBox textPWDAnswer;
        private System.Windows.Forms.TextBox textPWDConfirm;
        private System.Windows.Forms.TextBox textPWD;
        public System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMailAddress;
    }
}