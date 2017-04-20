namespace WindowsFormsAppTest
{
    partial class frmMath
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
            this.txtArray1 = new System.Windows.Forms.TextBox();
            this.txtArray2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArray1
            // 
            this.txtArray1.Location = new System.Drawing.Point(162, 412);
            this.txtArray1.Multiline = true;
            this.txtArray1.Name = "txtArray1";
            this.txtArray1.Size = new System.Drawing.Size(401, 187);
            this.txtArray1.TabIndex = 0;
            this.txtArray1.TextChanged += new System.EventHandler(this.txtArray1_TextChanged);
            // 
            // txtArray2
            // 
            this.txtArray2.Location = new System.Drawing.Point(668, 412);
            this.txtArray2.Multiline = true;
            this.txtArray2.Name = "txtArray2";
            this.txtArray2.Size = new System.Drawing.Size(401, 187);
            this.txtArray2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "在此输入第一个行列式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "在此输入第二个行列式";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(284, 700);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(204, 72);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "开始计算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(764, 700);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(225, 67);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // frmMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 877);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArray2);
            this.Controls.Add(this.txtArray1);
            this.Name = "frmMath";
            this.Text = "frmMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArray1;
        private System.Windows.Forms.TextBox txtArray2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
    }
}