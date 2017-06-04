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

        private void FormRegister_Load(object sender, EventArgs e)
        {
            //在开始时获得MailDomain
            GetMailDomain();
        }

        /// <summary>
        /// 从数据库中获取所有的MailDomain
        /// </summary>
        private void GetMailDomain()
        {

            string strSQLGetDomain = string.Empty;
            string strSQLUpdateHotIndex = string.Empty;
            strSQLGetDomain = $"select * from MailAddress order by HotIndex desc";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!",
            };

            conn.Open();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQLGetDomain,
            };

            SqlDataAdapter da = new SqlDataAdapter()
            {
                SelectCommand = cmd,
            };

            DataSet ds = new DataSet();
            da.Fill(ds, "MailAddress");

            conn.Close();

            PrivateIntReaderCount = ds.Tables["MailAddress"].DefaultView.Count;

            try
            {
                for (int i = 0; i < PrivateIntReaderCount; i++)
                {
                    str_MailDomain[i] = Convert.ToString(ds.Tables["MailAddress"].Rows[i][0]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            strMailAddress = txtMailAddress.Text.Trim();
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
                ConnectionString = @"Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!"
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
                //用户选择了不注册, 就什么都不干
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
            //保存在全Form变量中, 以便验证校对
            strVttCode = i.ToString();

            //获取需要发送的邮箱
            string strMailTo = string.Empty;
            strMailTo = txtMailAddress.Text.Trim();

            try
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.163.com",
                    UseDefaultCredentials = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential("xlm46566696", "xlm123")
                };

                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress("xlm46566696@163.com", "徐络溟", Encoding.UTF8),
                    Subject = "徐络溟的验证码测试",
                    Body = "验证码\n"+ strVttCode,
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

        private void txtMailAddress_TextChanged(object sender, EventArgs e)
        {
            lstMailAddress.Items.Clear();

            //在用户没有输入或者删除了输入时使listbox不可见
            if (txtMailAddress.Text.Trim().Equals(string.Empty) != true)
            {
                lstMailAddress.Visible = true;
            }
            else
            {
                lstMailAddress.Visible = false;
            }

            for (int i = 0; i < PrivateIntReaderCount; i++)
            {
                lstMailAddress.Items.Add(txtMailAddress.Text.Trim() + str_MailDomain[i]);
            }
        }

        /// <summary>
        /// 当用户按下BackSpace时, 直接将用户的输入剪切去@后面的东西, 并将光标定位到最后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] strTemp = txtMailAddress.Text.Trim().Split('@');

            if (e.KeyChar == '\b')
            {
                txtMailAddress.Text = strTemp[0];
                //光标定位到最后
                txtMailAddress.Select(txtMailAddress.Text.Length, 1);
            }
        }

        private void lstMailAddress_MouseMove(object sender, MouseEventArgs e)
        {
            ListBox eObj = sender as ListBox;
            eObj.SelectedIndex = eObj.IndexFromPoint(e.Location);
        }

        private void lstMailAddress_Click(object sender, EventArgs e)
        {
            txtMailAddress.Text = lstMailAddress.SelectedItem.ToString();
            lstMailAddress.Visible = false;
            lstMailAddress.Items.Clear();

            //当用户点击了之后将HotIndex增加, 便于在之后的查询中, 用户使用频率最高的排在最高位
            string[] strTemp = txtMailAddress.Text.Trim().Split('@');
            string strHotIndexByAddress = "@" + strTemp[1].ToString();
            string strSQLUpdateHotIndex = string.Empty;
            strSQLUpdateHotIndex = $"update MailAddress set HotIndex +=1 where address='{strHotIndexByAddress}'";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!",
            };

            conn.Open();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQLUpdateHotIndex,
            };

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
