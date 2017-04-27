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

        private void BtnMath_Click(object sender, EventArgs e)
        {
            frmMath frm = new frmMath();
            frm.Show();
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
            DialogResult ret;
            string strNumber = string.Empty;
            string strClass = string.Empty;

            FrmStuInfo frmStu = new FrmStuInfo();
            frmStu.txbClass.Text = txbClass.Text;
            frmStu.txbNumber.Text = txbNumber.Text;


            ret = frmStu.ShowDialog();
            if (ret == DialogResult.OK)
            {
                txbClass.Text = frmStu.txbClass.Text;
                txbNumber.Text = frmStu.txbNumber.Text;
                cmbSheng.Text = frmStu.cmbSheng.Text;
                cmbShi.Text = frmStu.cmbShi.Text;
            }
            else if(ret==DialogResult.Cancel)
            {
                frmStu.txbNumber.Text = string.Empty;
                frmStu.txbClass.Text = string.Empty;
                frmStu.txbNumber.Focus();
            }
        }
    }
}
