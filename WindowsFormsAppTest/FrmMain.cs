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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmbSheng.Items.Clear();
            cmbSheng.Text = string.Empty;

            cmbSheng.Items.Add("江苏");
            cmbSheng.Items.Add("上海");
            cmbSheng.Items.Add("浙江");
        }

        private void Login_In_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("您是否真的要退出？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (ret==DialogResult.Yes)
            {
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CmbSheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSheng = string.Empty;
            strSheng = cmbSheng.Text;

            cmbShi.Items.Clear();
            cmbShi.Text = string.Empty;

            if (strSheng.Equals("江苏"))
            {
                cmbShi.Items.Add("南京");
                cmbShi.Items.Add("常州");
            }
            if (strSheng.Equals("上海"))
            {
                cmbShi.Items.Add("浦东");
                cmbShi.Items.Add("浦西");
            }
            if (strSheng.Equals("浙江"))
            {
                cmbShi.Items.Add("杭州");
                cmbShi.Items.Add("宁波");
            }
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
           // DialogResult ret;
            string strNumber = string.Empty;
            string strClass = string.Empty;

            FrmStuInfo frmStu = new FrmStuInfo();
            frmStu.txbClass.Text = txbClass.Text;
            frmStu.txbNumber.Text = txbNumber.Text;

            frmStu.Show();

            //在窗体见传递数据的参考代码
            //ret = frmStu.ShowDialog();
            //if (ret == DialogResult.OK)
            //{
            //    txbClass.Text = frmStu.txbClass.Text;
            //    txbNumber.Text = frmStu.txbNumber.Text;
            //    cmbSheng.Text = frmStu.cmbSheng.Text;
            //    cmbShi.Text = frmStu.cmbShi.Text;
            //}
            //else if(ret==DialogResult.Cancel)
            //{
            //    frmStu.txbNumber.Text = string.Empty;
            //    frmStu.txbClass.Text = string.Empty;
            //    frmStu.txbNumber.Focus();
            //}
        }

        /// <summary>
        /// 主页显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// 各种事件显示的测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDateShow_Click(object sender, EventArgs e)
        {
            string strDate = string.Empty;
            strDate = dtpBirthday.Value.ToString();
            MessageBox.Show("dtpBirthday.Value.ToString" + strDate);

            strDate = dtpBirthday.Text.Trim();
            MessageBox.Show("dtpBirthday.Text.Trim" + strDate);

            strDate = DateTime.Now.Date.ToShortDateString();
            MessageBox.Show("DateTime.Now.Date.ToShortDateString" + strDate);

            strDate = DateTime.Now.DayOfWeek.ToString();
            MessageBox.Show("DateTime.Now.DayOfWeek.ToString" + strDate);
        }

        /// <summary>
        /// listBox的尝试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPgLa1_DoubleClick(object sender, EventArgs e)
        {
            //try与catch来避免一个listBox里面全部点没有了之后出现的错误
            try
            {
                string strTemp = string.Empty;

                strTemp = lbPgLa1.SelectedItem.ToString();
                lbPgLa2.Items.Add(strTemp);
                lbPgLa1.Items.Remove(lbPgLa1.SelectedItem);
            }
            catch
            {
            }
            
        }
        private void lbPgLa2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string strTemp = string.Empty;

                strTemp = lbPgLa2.SelectedItem.ToString();
                lbPgLa1.Items.Add(strTemp);
                lbPgLa2.Items.Remove(lbPgLa2.SelectedItem);
            }
            catch
            {
            }
            
        }

        /// <summary>
        /// 所有学生信息的出现的新窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSchoolStdShow_Click(object sender, EventArgs e)
        {
            FormStdInfoInSchool frmstdInfo = new FormStdInfoInSchool();
            frmstdInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=徐络溟\SQLEXPRESS;Integrated Security=True"
            };
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = $"select * from 学生信息表 where 学号='001'"
            };
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            MessageBox.Show(Convert.ToString( reader[0]), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
