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
//下面是发送邮件添加的using
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.IO;

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
            string strMailAddress = string.Empty;
            string strUserPWDConfirm = string.Empty;
            string strPWDQuestion = string.Empty;
            string strPWDAnswer = string.Empty;
            
            string strSQL = string.Empty;
            int ret = 0;
            DialogResult retDR;
            
            strUserName = textID.Text.Trim();
            strUserPWD = textPWD.Text.Trim();
            strMailAddress = txtMailAddress.Text.Trim() + "@" + cmbMailStmp.Text;
            strUserPWDConfirm = textPWDConfirm.Text.Trim();
            strPWDQuestion = cmbPWDQueston.Text.Trim();
            strPWDAnswer = textPWDAnswer.Text.Trim();

            if (strUserPWD.Equals(strUserPWDConfirm) != true )
            {
                MessageBox.Show("您输入的密码前后不一样!", "警告", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textPWD.Text = string.Empty;
                textPWDConfirm.Text = string.Empty;
                textPWD.Focus();

                return;
            }

            if (strUserName.Equals(string.Empty)||strUserPWD.Equals(string.Empty)||strMailAddress.Equals(string.Empty)||strUserPWDConfirm.Equals(string.Empty)||strPWDQuestion.Equals(string.Empty)||strPWDAnswer.Equals(string.Empty))
            {
                MessageBox.Show("您有选项没有输入!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (cmbMailStmp.Text.Equals(string.Empty))
            {
                MessageBox.Show("邮箱域名没有输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (txtMailVerticationCode.Text.Trim().Equals(strVttCode) == false)
            {
                MessageBox.Show("验证码不正确!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            strSQL = $"insert into 用户数据表(用户名,密码,邮箱,密码提示问题,问题答案)" +
                $"values('{strUserName}','{strUserPWD}','{strMailAddress}','{strPWDQuestion}','{strPWDAnswer}')";

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

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textID.Text = string.Empty;
                    textID.Focus();
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

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            //随机出一个6位验证码
            Random RdNumber = new Random();
            int i = RdNumber.Next();
            i %= 1000000;
            strVttCode = i.ToString();

            //获取需要发送的邮箱
            string strMailTo = string.Empty;
            string[] strTemp = txtMailAddress.Text.Trim().Split('@');
            strMailTo = strTemp[0].ToString() + "@" + cmbMailStmp.Text.Trim();

            try
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.163.com",
                    UseDefaultCredentials = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential("xjy46566696", "2536065441~!Q")
                };

                MailMessage Message = new MailMessage()
                {
                    From = new MailAddress("xjy46566696@163.com", "徐络溟", Encoding.UTF8),
                    Subject = "徐络溟的验证码测试",
                    Body = "验证码\n"+ strVttCode,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    Priority = MailPriority.High,
                    IsBodyHtml = true,
                };
                Message.To.Add(strMailTo);

                client.Send(Message);

                MessageBox.Show("发送成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
