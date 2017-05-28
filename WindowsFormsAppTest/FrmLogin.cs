using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL数据库连接的头文件

namespace WindowsFormsAppTest
{
    public partial class FrmLogin : Form
    {
        private Button Login;
        private Label label1;
        private Label label2;
        private TextBox textID;
        private TextBox textPWD;
        private Button btnRegister;
        private Button BtnForgetPWD;
        private Button Cancle;

        public FrmLogin()
        {
            InitializeComponent();
            textID.Focus();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Login = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPWD = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.BtnForgetPWD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login.Location = new System.Drawing.Point(100, 236);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(179, 89);
            this.Login.TabIndex = 3;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancle
            // 
            this.Cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancle.Location = new System.Drawing.Point(631, 236);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(173, 85);
            this.Cancle.TabIndex = 5;
            this.Cancle.Text = "取消";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(176, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(197, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textID.Location = new System.Drawing.Point(394, 66);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(278, 50);
            this.textID.TabIndex = 1;
            // 
            // textPWD
            // 
            this.textPWD.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPWD.Location = new System.Drawing.Point(394, 146);
            this.textPWD.Name = "textPWD";
            this.textPWD.PasswordChar = '*';
            this.textPWD.Size = new System.Drawing.Size(278, 50);
            this.textPWD.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(367, 236);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 89);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // BtnForgetPWD
            // 
            this.BtnForgetPWD.Location = new System.Drawing.Point(727, 428);
            this.BtnForgetPWD.Name = "BtnForgetPWD";
            this.BtnForgetPWD.Size = new System.Drawing.Size(246, 57);
            this.BtnForgetPWD.TabIndex = 6;
            this.BtnForgetPWD.Text = "忘记密码";
            this.BtnForgetPWD.UseVisualStyleBackColor = true;
            this.BtnForgetPWD.Click += new System.EventHandler(this.BtnForgetPWD_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.Login;
            this.CancelButton = this.Cancle;
            this.ClientSize = new System.Drawing.Size(1028, 497);
            this.Controls.Add(this.BtnForgetPWD);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textPWD);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void Login_Click(object sender, EventArgs e)
        {
            string strID = string.Empty;
            string strPWD = string.Empty;
            string strSQL = string.Empty;

            FrmStuInfo frmStuInfo = new FrmStuInfo();

            strID = textID.Text.Trim();
            strPWD = textPWD.Text.Trim();

            strSQL = $"select  * from 用户数据表 " +
                $"where 用户名='{strID}' " +
                $"and 密码='{strPWD}'";

            SqlConnection conn = new SqlConnection//链接数据库
            {
                ConnectionString = @"Data Source = 徐络溟\SQLEXPRESS; Integrated Security = True"
            };

            conn.Open();

            SqlCommand cmd = new SqlCommand//SQL语句的执行,存储,调用
            {
                Connection = conn,
                CommandText = strSQL
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            var count = dt.Rows.Count;

            if (count == 1)
            {
                MessageBox.Show("登录成功!", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.CommandText = $"select * from 学生信息表 where 学号='{strID}'";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                frmStuInfo.txbNumber.Text = Convert.ToString(reader[0]);
                frmStuInfo.txtName.Text = Convert.ToString(reader[1]);
                frmStuInfo.txbClass.Text = Convert.ToString(reader[2]);
                if (Convert.ToString(reader[3]).Equals("男"))
                {
                    frmStuInfo.rdbMale.Checked = true;
                }
                else
                {
                    frmStuInfo.rdbFemale.Checked = true;
                }
                frmStuInfo.cmbSheng.Text = Convert.ToString(reader[4]);

                frmStuInfo.Show();

                conn.Close();
                Close();
            }
            else
            {
                MessageBox.Show("登录失败!\n请重新登录", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textPWD.Text = string.Empty;
                textPWD.Focus();
            }
      }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new FormRegister();
            frmRegister.Show();
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            textPWD.Text = string.Empty;
            textPWD.Focus();
        }

        private void BtnForgetPWD_Click(object sender, EventArgs e)
        {
            DialogResult ret;

            if (textID.Text.Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名\n或者您未注册!", "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ret = MessageBox.Show("您要注册吗?", "提示", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ret.Equals(DialogResult.Yes))
                {
                    FormRegister frmRegister = new FormRegister();
                    frmRegister.Show();

                    Close();
                }

                return;
            }

            ret = MessageBox.Show("您是否还记得密码提示问题", "询问", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (ret.Equals(DialogResult.Yes))
            {
                FormForgetPWD frmForgetPwd = new FormForgetPWD();

                frmForgetPwd.txtUserName.Text = textID.Text.Trim();

                frmForgetPwd.Show();

                Close();

                MessageBox.Show("请输入密码提示问题的答案", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                ret = MessageBox.Show("确定通过邮箱验证身份吗?", "提示", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ret.Equals(DialogResult.Yes))
                {
                    FormForgetPWDByMail frmForgetPwd = new FormForgetPWDByMail();

                    frmForgetPwd.TxtUserName.Text = textID.Text.Trim();

                    frmForgetPwd.Show();

                    Close();
                }
                else
                {
                   
                }

            }
            
        }
    }
}
