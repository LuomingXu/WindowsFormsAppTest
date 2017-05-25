using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL数据库连接的头文件

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
            string strShengID = string.Empty;
            string[] strPvovinceID1 = cmbSheng.Text.Split(':');
            string strProvinceID = strPvovinceID1[0];
            
            string strSQL = string.Empty;
            int intRecordCount = 0;

            cmbShi.Items.Clear();
            cmbShi.Text = string.Empty;
            cmbQu.Items.Clear();
            cmbQu.Text = string.Empty;

            strSQL = $"select CityID,CityName from S_City where ProvinceID='{strProvinceID}'";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=徐络溟\SQLEXPRESS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQL,
            };

            SqlDataAdapter da = new SqlDataAdapter()
            {
                SelectCommand = cmd
            };

            DataSet ds = new DataSet();

            da.Fill(ds, "市表");

            intRecordCount = ds.Tables["市表"].DefaultView.Count;

            if (intRecordCount > 0)
            {
                for (int i = 0; i < intRecordCount; i++)
                {
                    cmbShi.Items.Add(ds.Tables["市表"].Rows[i][0].ToString() +
                        ": " +
                        ds.Tables["市表"].Rows[i][1]).ToString();
                }
            }
        }

        private void cmbShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strQuID = string.Empty;
            string[] strCityID1 = cmbShi.Text.Split(':');
            string strCityID = strCityID1[0];

            string strSQL = string.Empty;
            int intRecordCount = 0;

            cmbQu.Items.Clear();
            cmbQu.Text = string.Empty;

            strSQL = $"select DistrictID,DistrictName from S_District where CityID='{strCityID}'";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=徐络溟\SQLEXPRESS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQL,
            };

            SqlDataAdapter da = new SqlDataAdapter()
            {
                SelectCommand = cmd
            };

            DataSet ds = new DataSet();

            da.Fill(ds, "区表");

            intRecordCount = ds.Tables["区表"].DefaultView.Count;

            if (intRecordCount > 0)
            {
                for (int i = 0; i < intRecordCount; i++)
                {
                    cmbQu.Items.Add(ds.Tables["区表"].Rows[i][0].ToString() +
                        ": " +
                        ds.Tables["区表"].Rows[i][1]).ToString();
                }
            }
        }

        private void FrmStuInfo_Load(object sender, EventArgs e)
        {
            cmbSheng.Items.Clear();
            //cmbSheng.Text = string.Empty;

            string strSQL = string.Empty;
            int intRecordCount = 0;

            strSQL = $"select ProvinceID,ProvinceName from S_Province";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source=徐络溟\SQLEXPRESS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQL,
            };

            SqlDataAdapter da = new SqlDataAdapter()
            {
                SelectCommand = cmd
            };

            DataSet ds = new DataSet();

            da.Fill(ds, "省表");

            intRecordCount = ds.Tables["省表"].DefaultView.Count;

            conn.Close();

            if (intRecordCount > 0)
            {
                //MessageBox.Show("成功查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < intRecordCount; i++)
                {
                    cmbSheng.Items.Add(ds.Tables["省表"].Rows[i][0].ToString() +
                        ": " +
                        ds.Tables["省表"].Rows[i][1].ToString());
                }

            }
            else
            {
                MessageBox.Show("不存在此学号", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //学生信息表
            string strNumber = string.Empty;
            string strName = string.Empty;
            string strClass = string.Empty;
            string strGender = string.Empty;
            string strAddress = string.Empty;
            //成绩表
            string strCourseNumber = string.Empty;
            string strCourseName = string.Empty;
            string strGrade = string.Empty;
            //内部temp
            int ret = 0;
            string strSQLStu = string.Empty;
            string strSQLGrade = string.Empty;
            string strSQLCourseName = string.Empty;

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
            string[] strText1 = cmbSheng.Text.Split(':');
            string[] strText2 = cmbShi.Text.Split(':');
            string[] strText3 = cmbQu.Text.Split(':');
            strAddress = strText1[0] + strText2[0] + strText3[0];

            strSQLStu = $"insert into 学生信息表(学号,姓名,班级,性别,生源地) " +
                $"values('{strNumber}','{strName}', '{strClass}','{strGender}','{strAddress}')";

            SqlConnection connSQL = new SqlConnection()
            {
                ConnectionString = @"Data Source = 徐络溟\SQLEXPRESS; Integrated Security = True",
            };

            connSQL.Open();

            SqlCommand cmdSQL = new SqlCommand()
            {
                Connection = connSQL,
                CommandText = strSQLStu,
            };

            if (txbNumber.Text.Equals(string.Empty)||txtCourseNumber.Text.Equals(string.Empty))
            {
                MessageBox.Show("学号和课程编号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            ret = cmdSQL.ExecuteNonQuery();

            //依据课程编号获取课程名称
            strCourseNumber = txtCourseNumber.Text.Trim();

            strSQLCourseName = $"select 课程名称 from 课程信息表 " +
                $"where 课程编号='{strCourseNumber}'";

            cmdSQL.CommandText = strSQLCourseName;
            SqlDataReader reader = cmdSQL.ExecuteReader();
            reader.Read();
            strCourseName =Convert.ToString(reader[0]);
            reader.Close();

            //添加成绩信息
            strGrade = txtGrade.Text.Trim();

            strSQLGrade = $"insert into 成绩表(学号,课程编号,课程名称,成绩) " +
                $"values('{strNumber}','{strCourseNumber}','{strCourseName}','{strGrade}')";

            cmdSQL.CommandText = strSQLGrade;
            ret += cmdSQL.ExecuteNonQuery();

            connSQL.Close();

            if (ret > 1)
            {
                DialogResult DiaRet;
                MessageBox.Show("学生信息添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DiaRet = MessageBox.Show("是否继续添加学生信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DiaRet.Equals(DialogResult.No))
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("错误!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchByNumber_Click(object sender, EventArgs e)
        {
            string strNumber = string.Empty;

            string strSQL = string.Empty;

            int intRecordCount = 0;

            strNumber = txbNumber.Text.Trim();

            strSQL = $"select 学生信息表.学号,学生信息表.姓名,课程信息表.课程编号,成绩表.成绩  " +
                $"from 学生信息表,课程信息表,成绩表  " +
                $"where 学生信息表.学号='{strNumber}' and 成绩表.学号='{strNumber}' " +
                $"and 课程信息表.课程编号=成绩表.课程编号";

            SqlConnection conn = new SqlConnection()
            {
                ConnectionString = @"Data Source = 徐络溟\SQLEXPRESS; Integrated Security = True"
            };

            conn.Open();

            SqlCommand cmd = new SqlCommand()
            {
                Connection = conn,
                CommandText = strSQL
            };

            SqlDataAdapter daSql = new SqlDataAdapter()
            {
                SelectCommand = cmd
            };

            DataSet ds = new DataSet();

            daSql.Fill(ds, "成绩查询");

            intRecordCount = ds.Tables["成绩查询"].DefaultView.Count;

            conn.Close();

            if (intRecordCount > 0)
            {
                MessageBox.Show("成功查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dgv.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("不存在此学号", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strNumber = string.Empty;
            int ret = 0;
            string strSQL = string.Empty;

            strNumber = txbNumber.Text.Trim();

            strSQL = $"delete from 学生信息表 " +
                $"where 学号='{strNumber}'";

            //数据库连接
            SqlConnection connSQL = new SqlConnection();
            connSQL.ConnectionString = @"Data Source = 徐络溟\SQLEXPRESS; Integrated Security = True";
            connSQL.Open();
            //封装SQL命令
            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Connection = connSQL;
            cmdSQL.CommandText = strSQL;

            DialogResult retDR;
            retDR = MessageBox.Show("您确定删除吗？", "警告",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retDR==DialogResult.Yes)
            {
                //执行SQL命令并得到执行结果
                ret = cmdSQL.ExecuteNonQuery();
                //断开数据库的连接
                connSQL.Close();
                //
                if (ret > 0)
                {
                    MessageBox.Show("学生信息删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("不存在此学号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strNumber = string.Empty;
            string strName = string.Empty;
            string strClass = string.Empty;
            string strGender = string.Empty;
            string strAddress = string.Empty;
            int ret = 0;
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

            strSQL = $"update 学生信息表 " +
                $"set 姓名='{strName}',班级='{strClass}',性别='{strGender}',生源地='{strAddress}'" +
                $"where 学号='{strNumber}'";

            //数据库连接
            SqlConnection connSQL = new SqlConnection()
            {
                ConnectionString = @"Data Source = 徐络溟\SQLEXPRESS; Integrated Security = True"
            };
            connSQL.Open();
            //封装SQL命令
            SqlCommand cmdSQL = new SqlCommand()
            {
                Connection = connSQL,
                CommandText = strSQL
            };

            //是否真的要修改
            DialogResult retDR;
            retDR = MessageBox.Show("您是否真的要修改？", "警告", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retDR==DialogResult.Yes)
            {
                //执行SQL命令并得到执行结果
                ret = cmdSQL.ExecuteNonQuery();
                //断开数据库的连接
                connSQL.Close();
                if (ret > 0)
                {
                    MessageBox.Show("学生信息修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("不存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                
            }     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbClass.Text = string.Empty;
            txbNumber.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            txtCourseNumber.Text = string.Empty;
            txtGrade.Text = string.Empty;
            txtName.Text = string.Empty;
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
            cmbSheng.Text = string.Empty;
            cmbShi.Text = string.Empty;

            txbNumber.Focus();
        }


    }
}
