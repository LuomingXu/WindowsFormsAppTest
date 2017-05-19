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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strUserName = string.Empty;
            string strUserPWD = string.Empty;
            string strUserPWDConfirm = string.Empty;
            string strPWDQuestion = string.Empty;
            string strPWDAnswer = string.Empty;

            string strSQL = string.Empty;
            int ret = 0;
            DialogResult retDR;

            strUserName = textID.Text.Trim();
            strUserPWD = textPWD.Text.Trim();
            strUserPWDConfirm = textPWDConfirm.Text.Trim();
            strPWDQuestion = cmbPWDQueston.Text.Trim();
            strPWDAnswer = textPWDAnswer.Text.Trim();

            if (strUserPWD.Equals(strUserPWDConfirm)!=true )
            {
                MessageBox.Show("您输入的密码前后不一样!", "警告", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textPWD.Text = string.Empty;
                textPWDConfirm.Text = string.Empty;
                textPWD.Focus();

                return;
            }

            if (strUserName.Equals(string.Empty)||strUserPWD.Equals(string.Empty)||strUserPWDConfirm.Equals(string.Empty)||strPWDQuestion.Equals(string.Empty)||strPWDAnswer.Equals(string.Empty))
            {
                MessageBox.Show("您有空格没有输入!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            strSQL = $"insert into 用户数据表(用户名,密码,密码提示问题,问题答案)" +
                $"values('{strUserName}','{strUserPWD}','{strPWDQuestion}','{strPWDAnswer}')";

            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source = 徐络溟\SQLEXPRESS; Integrated Security = True"
            };
            conn.Open();

            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = strSQL
            };

            retDR = MessageBox.Show("您确定注册?", "询问",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retDR == DialogResult.Yes)
            {
                try
                {
                    ret = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (ret > 0)
                    {
                        MessageBox.Show("注册成功!", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("没有注册成功", "警告",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("没有注册成功", "警告",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            textID.Text = string.Empty;
            textPWD.Text = string.Empty;
            textPWDConfirm.Text = string.Empty;
            cmbPWDQueston.Text = string.Empty;
            textPWDAnswer.Text = string.Empty;

            textID.Focus();
        }
    }
}
