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

        private void txtArray1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            txtArray1.Text = string.Empty;
            txtArray2.Text = string.Empty;
            txtArray1.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
