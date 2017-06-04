using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    public partial class FormRePWD : Form
    {
        public FormRePWD()
        {
            InitializeComponent();
        }

        private void FormRePWD_Load(object sender, EventArgs e)
        {
            textPWD.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strUserName = string.Empty;
            string strUserPWD = string.Empty;
            string strUserPWDConfirm = string.Empty;
            string strMailAddress = string.Empty;
            string strPWDQuestion = string.Empty;
            string strPWDAnswer = string.Empty;

            string strSQL = string.Empty;
            int ret = 0;
            DialogResult retDR;

            strUserName = textID.Text.Trim();
            strUserPWD = textPWD.Text.Trim();
            strUserPWDConfirm = textPWDConfirm.Text.Trim();
            strMailAddress = TxtMailAddress.Text.Trim();
            strPWDQuestion = cmbPWDQueston.Text.Trim();
            strPWDAnswer = textPWDAnswer.Text.Trim();

            if (strUserPWD.Equals(strUserPWDConfirm) != true)
            {
                MessageBox.Show("您输入的密码前后不一样!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textPWD.Text = string.Empty;
                textPWDConfirm.Text = string.Empty;
                textPWD.Focus();

                return;
            }

            if (strUserPWD.Equals(string.Empty) || strUserPWDConfirm.Equals(string.Empty) || strPWDQuestion.Equals(string.Empty) || strPWDAnswer.Equals(string.Empty))
            {
                MessageBox.Show("您有选项没有输入!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            strSQL = $"update 用户数据表 " +
                $"set 密码='{strUserPWD}',邮箱='{strMailAddress}',密码提示问题='{strPWDQuestion}',问题答案='{strPWDAnswer}'" +
                $"where 用户名='{strUserName}'";

            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!"
            };
            conn.Open();

            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = strSQL
            };

            retDR = MessageBox.Show("确定?", "询问",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retDR == DialogResult.Yes)
            {
                try
                {
                    ret = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (ret > 0)
                    {
                        MessageBox.Show("忘记密码成功!", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("失败", "警告",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            textPWD.Text = string.Empty;
            textPWDConfirm.Text = string.Empty;
            cmbPWDQueston.Text = string.Empty;
            textPWDAnswer.Text = string.Empty;

            textPWD.Focus();
        }
    }
}
