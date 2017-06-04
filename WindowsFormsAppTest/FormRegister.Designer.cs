namespace WindowsFormsAppTest
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.textPWD = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPWDConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPWDAnswer = new System.Windows.Forms.TextBox();
            this.cmbPWDQueston = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.txtMailVerticationCode = new System.Windows.Forms.TextBox();
            this.BtnSendMail = new System.Windows.Forms.Button();
            this.lstMailAddress = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textPWD
            // 
            this.textPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWD.Location = new System.Drawing.Point(350, 145);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(278, 50);
            this.textPWD.TabIndex = 2;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(350, 65);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(278, 50);
            this.textID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(153, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(132, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(123, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码确认";
            // 
            // textPWDConfirm
            // 
            this.textPWDConfirm.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWDConfirm.Location = new System.Drawing.Point(350, 224);
            this.textPWDConfirm.Name = "textPWDConfirm";
            this.textPWDConfirm.PasswordChar = '*';
            this.textPWDConfirm.Size = new System.Drawing.Size(278, 50);
            this.textPWDConfirm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(89, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "密码提示问题";
            // 
            // textPWDAnswer
            // 
            this.textPWDAnswer.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWDAnswer.Location = new System.Drawing.Point(349, 699);
            this.textPWDAnswer.Name = "textPWDAnswer";
            this.textPWDAnswer.Size = new System.Drawing.Size(278, 50);
            this.textPWDAnswer.TabIndex = 8;
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
            this.cmbPWDQueston.Location = new System.Drawing.Point(349, 612);
            this.cmbPWDQueston.Name = "cmbPWDQueston";
            this.cmbPWDQueston.Size = new System.Drawing.Size(278, 45);
            this.cmbPWDQueston.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(132, 702);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "问题答案";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(95, 828);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 89);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancle.Location = new System.Drawing.Point(433, 823);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(219, 99);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(169, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "邮箱";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(141, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "验证码";
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMailAddress.Location = new System.Drawing.Point(316, 312);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(353, 50);
            this.txtMailAddress.TabIndex = 4;
            this.txtMailAddress.TextChanged += new System.EventHandler(this.txtMailAddress_TextChanged);
            this.txtMailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMailAddress_KeyPress);
            // 
            // txtMailVerticationCode
            // 
            this.txtMailVerticationCode.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMailVerticationCode.Location = new System.Drawing.Point(348, 526);
            this.txtMailVerticationCode.Name = "txtMailVerticationCode";
            this.txtMailVerticationCode.Size = new System.Drawing.Size(279, 50);
            this.txtMailVerticationCode.TabIndex = 6;
            // 
            // BtnSendMail
            // 
            this.BtnSendMail.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSendMail.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSendMail.ForeColor = System.Drawing.Color.Red;
            this.BtnSendMail.Location = new System.Drawing.Point(194, 422);
            this.BtnSendMail.Name = "BtnSendMail";
            this.BtnSendMail.Size = new System.Drawing.Size(400, 68);
            this.BtnSendMail.TabIndex = 5;
            this.BtnSendMail.Text = "发送验证邮件";
            this.BtnSendMail.UseVisualStyleBackColor = false;
            this.BtnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // lstMailAddress
            // 
            this.lstMailAddress.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstMailAddress.FormattingEnabled = true;
            this.lstMailAddress.ItemHeight = 37;
            this.lstMailAddress.Location = new System.Drawing.Point(316, 368);
            this.lstMailAddress.Name = "lstMailAddress";
            this.lstMailAddress.Size = new System.Drawing.Size(353, 189);
            this.lstMailAddress.TabIndex = 23;
            this.lstMailAddress.Visible = false;
            this.lstMailAddress.Click += new System.EventHandler(this.lstMailAddress_Click);
            this.lstMailAddress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstMailAddress_MouseMove);
            // 
            // FormRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(776, 1091);
            this.Controls.Add(this.lstMailAddress);
            this.Controls.Add(this.BtnSendMail);
            this.Controls.Add(this.txtMailVerticationCode);
            this.Controls.Add(this.txtMailAddress);
            this.Controls.Add(this.label7);
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
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 此Form全局的VttCode
        /// </summary>
        private string strVttCode = string.Empty;

        /// <summary>
        /// 存放从数据库获取的所有MailDomain
        /// </summary>
        private string[] str_MailDomain = new string[20];

        /// <summary>
        /// 获得MailDomain的个数
        /// </summary>
        private int PrivateIntReaderCount = 0;

        private System.Windows.Forms.TextBox textPWD;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPWDConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPWDAnswer;
        private System.Windows.Forms.ComboBox cmbPWDQueston;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.TextBox txtMailVerticationCode;
        private System.Windows.Forms.Button BtnSendMail;
        private System.Windows.Forms.ListBox lstMailAddress;
    }
}