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
    public partial class FrmStuInfo : Form
    {
        public FrmStuInfo()
        {
            InitializeComponent();
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

        private void FrmStuInfo_Load(object sender, EventArgs e)
        {
            cmbSheng.Items.Clear();
            cmbSheng.Text = string.Empty;

            cmbSheng.Items.Add("江苏");
            cmbSheng.Items.Add("上海");
            cmbSheng.Items.Add("浙江");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strNumber = string.Empty;
            string strName = string.Empty;
            string strClass = string.Empty;
            string strGender = string.Empty;
            string strAddress = string.Empty;

            string strSQL = string.Empty;

            strNumber = txbNumber.Text.Trim();
            strName = txtName.Text.Trim();
            strClass = txbClass.Text.Trim();
            if (rdbMale.Checked)
            {
                strGender = "男";
            }
            else
            {
                strGender = "女";
            }
            strAddress = cmbSheng.Text.Trim() + cmbShi.Text.Trim();

            strSQL = $"insert into 学生信息表(学号,姓名,班级,性别,家庭住址) " +
                $"values('{strNumber}','{strName}', '{strClass}','{strGender}','{strAddress}')";
        }

        private void btnSearchByNumber_Click(object sender, EventArgs e)
        {
            string strNumber = string.Empty;

            string strSQL = string.Empty;

            strNumber = txbNumber.Text.Trim();

            strSQL = $"select 学生信息表.学号,学生信息表.姓名,课程信息表.课程编号,成绩表.成绩  " +
                $"from 学生信息表,课程信息表,成绩表  " +
                $"where 学生信息表.学号='{strNumber}' and 成绩表.学号='{strNumber}' " +
                $"and 课程信息表.课程编号=成绩表.课程编号";

        }
    }
}
