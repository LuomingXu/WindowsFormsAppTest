namespace WindowsFormsAppTest
{
    partial class FormForgetPWD
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPWDAnswer = new System.Windows.Forms.TextBox();
            this.txtPWDQuestion = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(117, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码提示问题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(151, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "问题答案";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(151, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(507, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 50);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPWDAnswer
            // 
            this.txtPWDAnswer.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPWDAnswer.Location = new System.Drawing.Point(507, 279);
            this.txtPWDAnswer.Name = "txtPWDAnswer";
            this.txtPWDAnswer.Size = new System.Drawing.Size(232, 50);
            this.txtPWDAnswer.TabIndex = 4;
            // 
            // txtPWDQuestion
            // 
            this.txtPWDQuestion.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPWDQuestion.Location = new System.Drawing.Point(507, 173);
            this.txtPWDQuestion.Name = "txtPWDQuestion";
            this.txtPWDQuestion.ReadOnly = true;
            this.txtPWDQuestion.Size = new System.Drawing.Size(232, 50);
            this.txtPWDQuestion.TabIndex = 5;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(124, 428);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(233, 71);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(526, 428);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(233, 71);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FormForgetPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 585);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.txtPWDQuestion);
            this.Controls.Add(this.txtPWDAnswer);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormForgetPWD";
            this.Text = "FormForgetPWD";
            this.Load += new System.EventHandler(this.FormForgetPWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPWDAnswer;
        private System.Windows.Forms.TextBox txtPWDQuestion;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}