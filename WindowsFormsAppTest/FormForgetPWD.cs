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
    public partial class FormForgetPWD : Form
    {
        public FormForgetPWD()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormForgetPWD_Load(object sender, EventArgs e)
        {
            txtPWDAnswer.Focus();

            string strUserName = string.Empty;
            string strPWDQuestion = string.Empty;
            string strSQL = string.Empty;

            strUserName = txtUserName.Text.Trim();

            strSQL = $"select 密码提示问题 from 用户数据表 " +
                $"where 用户名='{strUserName}' ";

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

            //从数据库中读取数据
            strPWDQuestion = Convert.ToString(cmd.ExecuteScalar());

            txtPWDQuestion.Text = strPWDQuestion;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string strUserName = string.Empty;
            string strPWDAnswer = string.Empty;
            string strSQL = string.Empty;

            strUserName = txtUserName.Text.Trim();
            strPWDAnswer = txtPWDAnswer.Text.Trim();

            if (strUserName.Equals(string.Empty) || strPWDAnswer.Equals(string.Empty))
            {
                MessageBox.Show("您有空格没有输入!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            strSQL = $"select * from 用户数据表" +
                $" where 用户名='{strUserName}'" +
                $"and 问题答案='{strPWDAnswer}'";


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
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            var count = dt.Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("忘记密码成功!\n请重新注册!", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormRePWD frmRePWD = new FormRePWD();
                
                //传递用户名
                frmRePWD.textID.Text = txtUserName.Text.Trim();

                frmRePWD.Show();

                Close();
                //提示用户要干什么
                MessageBox.Show("请输入新的密码!", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("忘记密码失败!", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtPWDAnswer.Text = string.Empty;

            txtPWDQuestion.Focus();
        }
    }
}
