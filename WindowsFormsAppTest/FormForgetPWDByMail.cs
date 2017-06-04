using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace WindowsFormsAppTest
{
    public partial class FormForgetPWDByMail : Form
    {
        public FormForgetPWDByMail()
        {
            InitializeComponent();
        }

        private void FormForgetPWDByMail_Load(object sender, EventArgs e)
        {
            string strSQL = string.Empty;

            strSQL = $"select 邮箱 from 用户数据表 where 用户名='{TxtUserName.Text.Trim()}'";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!",
            };
            conn.Open();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQL,
            };

            TxtMailAddress.Text = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            TxtVttCode.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            strVttCode = (rd.Next() % 1000000).ToString();

            //获取需要发送的邮箱
            string strMailTo = string.Empty;
            strMailTo = TxtMailAddress.Text;

            try
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.163.com",
                    UseDefaultCredentials = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    //若是这边密码不行的话,可以使用客户端授权码
                    Credentials = new NetworkCredential("xlm46566696", "xlm123")
                };

                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress("xlm46566696@163.com", "徐络溟", Encoding.UTF8),
                    Subject = "徐络溟的验证码测试",
                    Body = "验证码<br/>" + strVttCode,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    Priority = MailPriority.High,                  
                    IsBodyHtml = true,

                };
                //防止被当做垃圾邮件的秘密/抠鼻
                mailMessage.Headers.Add("X-QQ-FEAT", "zA6doese0mJ197rkmu99KEGGq7KYg01VBRljUe6NE1fFR/Dv/P86Z73saQHl+" +
                    "ocTCUB6X9p4jMmSrhA7EmKfSBrqaFSknIVJqMWaXQBuOS/EkrHiUk6jNMEzDd6ySnxFgW1t" +
                    "SZXuYHhJ7hivENLW238mgBZByFb+4UviauuVinsrops07fw80fIQtMScpn2KhoFJoR4NaES" +
                    "oEbWfljklo6CiYl+NaU1aOOf32x8gaaE=");
                mailMessage.Headers.Add("X-QQ-SSF", "00010000000000F000000000000000S");
                mailMessage.Headers.Add("X-HAS-ATTACH", "no");
                mailMessage.Headers.Add("X-QQ-BUSINESS-ORIGIN", "2");
                mailMessage.Headers.Add("X-Originating-IP", "153.101.48.119");
                mailMessage.Headers.Add("X-QQ-mid", "webmail367t1495970966t8880412");
                mailMessage.Headers.Add("X-QQ-MIME", "TCMime 1.0 by Tencent");
                mailMessage.Headers.Add("X-Mailer", "QQMail 2.x");
                mailMessage.Headers.Add("X-QQ-Mailer", "QQMail 2.x");
                mailMessage.Headers.Add("X-QQ-SENDSIZE", "520");
                mailMessage.Headers.Add("X-CM-TRANSID", "e8CowED58UKXtCpZcO1WBA--.15282S3");
                mailMessage.Headers.Add("X-Coremail-Antispam", "1Uf129KBjDUn29KB7ZKAUJUUUUU529EdanIXcx71UUUUU7v73" +
                    "VFW2AGmfu7bjvjm3AaLaJ3UbIYCTnIWIevJa73UjIFyTuYvjxU-SoXUUUUU");

                mailMessage.To.Add(strMailTo);

                client.Send(mailMessage);

                MessageBox.Show("发送成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TxtVttCode.Equals(strVttCode))
            {
                FormRePWD frmRe = new FormRePWD();

                frmRe.textID.Text = TxtUserName.Text.Trim();

                frmRe.Show();

                Close();
            }
            else
            {
                MessageBox.Show("验证码不正确", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
