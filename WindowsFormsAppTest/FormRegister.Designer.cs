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
            this.SuspendLayout();
            // 
            // textPWD
            // 
            this.textPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWD.Location = new System.Drawing.Point(350, 145);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(278, 50);
            this.textPWD.TabIndex = 9;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(350, 65);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(278, 50);
            this.textID.TabIndex = 8;
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
            this.textPWDConfirm.Size = new System.Drawing.Size(278, 50);
            this.textPWDConfirm.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(80, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "密码提示问题";
            // 
            // textPWDAnswer
            // 
            this.textPWDAnswer.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWDAnswer.Location = new System.Drawing.Point(350, 399);
            this.textPWDAnswer.Name = "textPWDAnswer";
            this.textPWDAnswer.Size = new System.Drawing.Size(278, 50);
            this.textPWDAnswer.TabIndex = 13;
            // 
            // cmbPWDQueston
            // 
            this.cmbPWDQueston.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPWDQueston.FormattingEnabled = true;
            this.cmbPWDQueston.Items.AddRange(new object[] {
            "父母的姓名",
            "喜欢的人",
            "寝室号"});
            this.cmbPWDQueston.Location = new System.Drawing.Point(350, 316);
            this.cmbPWDQueston.Name = "cmbPWDQueston";
            this.cmbPWDQueston.Size = new System.Drawing.Size(278, 45);
            this.cmbPWDQueston.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(123, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "问题答案";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(97, 520);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 89);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancle.Location = new System.Drawing.Point(437, 520);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(219, 99);
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 669);
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
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}