using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class FrmLogin : Form
    {
        private Button Login;
        private Label label1;
        private Label label2;
        private TextBox textID;
        private TextBox textPWD;
        private Button Cancle;

        public FrmLogin()
        {
            InitializeComponent();
            textID.Focus();
        }

        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login.Location = new System.Drawing.Point(100, 236);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(179, 89);
            this.Login.TabIndex = 0;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancle
            // 
            this.Cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancle.Location = new System.Drawing.Point(355, 236);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(173, 85);
            this.Cancle.TabIndex = 1;
            this.Cancle.Text = "取消";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(83, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(280, 62);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(278, 35);
            this.textID.TabIndex = 4;
            this.textID.TextChanged += new System.EventHandler(this.TextID_TextChanged_1);
            // 
            // textPWD
            // 
            this.textPWD.Location = new System.Drawing.Point(280, 142);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(278, 35);
            this.textPWD.TabIndex = 5;
            this.textPWD.TextChanged += new System.EventHandler(this.TextPWD_TextChanged);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.Login;
            this.CancelButton = this.Cancle;
            this.ClientSize = new System.Drawing.Size(676, 417);
            this.Controls.Add(this.textPWD);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Login);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string strID = string.Empty;
            string strPWD = string.Empty;

            strID = textID.Text.Trim();
            strPWD = textPWD.Text.Trim();

            if (strID.Equals("001")&&strPWD.Equals("456"))
            {
                MessageBox.Show("登录成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("不匹配", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            textID.Text = string.Empty;
            textPWD.Text = string.Empty;
            textID.Focus();
        }
    }
}
