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
    public partial class frmMath : Form
    {
        public frmMath()
        {
            InitializeComponent();
        }

        private void TxtArray1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            txtArray1.Text = string.Empty;
            txtArray2.Text = string.Empty;
            txtArray1.Focus();
        }

        double[] doub = new double[512];
        int a = 0;
        string str = string.Empty;

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //string str = txtArray1.Text.Trim().ToString();
            //double doub = 0;
            //if (double.TryParse(str, out doub))
            //{
            //    MessageBox.Show(doub.ToString());

            //}
            //else
            //{
            //    MessageBox.Show(str.ToString());
            //}

 //           private void simpleButton1_Click(object sender, EventArgs e)
 //           {
                a = ++a;
                str = txtArray1.Text.Trim().ToString();

                if (double.TryParse(str, out double doubs))
                {
                    MessageBox.Show("添加成功");
                MessageBox.Show(doub.ToString());
                doub[a] = doubs;
                }
                else
                {
                    MessageBox.Show("类型不正确");
                MessageBox.Show(str.ToString());
            }
            //           }

            txtArray2.Text = str;
        }
    }
}
