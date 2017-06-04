namespace WindowsFormsAppTest
{
    partial class FrmStuInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuInfo));
            this.txbClass = new System.Windows.Forms.TextBox();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbShi = new System.Windows.Forms.ComboBox();
            this.cmbSheng = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbQu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHoppies = new System.Windows.Forms.TabPage();
            this.tpExperience = new System.Windows.Forms.TabPage();
            this.tpSchool = new System.Windows.Forms.TabPage();
            this.btnSearchByNumber = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.lbl321 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txbClass
            // 
            this.txbClass.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbClass.Location = new System.Drawing.Point(406, 148);
            this.txbClass.Name = "txbClass";
            this.txbClass.Size = new System.Drawing.Size(206, 50);
            this.txbClass.TabIndex = 3;
            // 
            // txbNumber
            // 
            this.txbNumber.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbNumber.Location = new System.Drawing.Point(406, 19);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(206, 50);
            this.txbNumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(213, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "班级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(213, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "学号";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(17, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 51);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "提交";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 51);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "籍贯";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(756, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "市";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(381, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "省";
            // 
            // cmbShi
            // 
            this.cmbShi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShi.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbShi.FormattingEnabled = true;
            this.cmbShi.Location = new System.Drawing.Point(466, 282);
            this.cmbShi.Name = "cmbShi";
            this.cmbShi.Size = new System.Drawing.Size(263, 45);
            this.cmbShi.TabIndex = 7;
            this.cmbShi.SelectedIndexChanged += new System.EventHandler(this.cmbShi_SelectedIndexChanged);
            // 
            // cmbSheng
            // 
            this.cmbSheng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSheng.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSheng.FormattingEnabled = true;
            this.cmbSheng.Location = new System.Drawing.Point(121, 282);
            this.cmbSheng.Name = "cmbSheng";
            this.cmbSheng.Size = new System.Drawing.Size(241, 45);
            this.cmbSheng.TabIndex = 6;
            this.cmbSheng.SelectedIndexChanged += new System.EventHandler(this.CmbSheng_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbQu);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rdbFemale);
            this.panel1.Controls.Add(this.rdbMale);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbNumber);
            this.panel1.Controls.Add(this.cmbShi);
            this.panel1.Controls.Add(this.txbClass);
            this.panel1.Controls.Add(this.cmbSheng);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(99, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 408);
            this.panel1.TabIndex = 26;
            // 
            // cmbQu
            // 
            this.cmbQu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQu.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQu.FormattingEnabled = true;
            this.cmbQu.Location = new System.Drawing.Point(121, 347);
            this.cmbQu.Name = "cmbQu";
            this.cmbQu.Size = new System.Drawing.Size(241, 45);
            this.cmbQu.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(381, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 37);
            this.label11.TabIndex = 30;
            this.label11.Text = "区/县/市";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(406, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 50);
            this.txtName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(215, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 37);
            this.label7.TabIndex = 29;
            this.label7.Text = "姓名";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbFemale.Location = new System.Drawing.Point(443, 218);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 41);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "女";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbMale.Location = new System.Drawing.Point(257, 218);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(85, 41);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "男";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "性别";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(107, 707);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 100);
            this.panel2.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHoppies);
            this.tabControl1.Controls.Add(this.tpExperience);
            this.tabControl1.Controls.Add(this.tpSchool);
            this.tabControl1.Location = new System.Drawing.Point(99, 438);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 248);
            this.tabControl1.TabIndex = 28;
            // 
            // tpHoppies
            // 
            this.tpHoppies.Location = new System.Drawing.Point(8, 39);
            this.tpHoppies.Name = "tpHoppies";
            this.tpHoppies.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoppies.Size = new System.Drawing.Size(520, 201);
            this.tpHoppies.TabIndex = 0;
            this.tpHoppies.Text = "兴趣";
            this.tpHoppies.UseVisualStyleBackColor = true;
            // 
            // tpExperience
            // 
            this.tpExperience.Location = new System.Drawing.Point(8, 39);
            this.tpExperience.Name = "tpExperience";
            this.tpExperience.Padding = new System.Windows.Forms.Padding(3);
            this.tpExperience.Size = new System.Drawing.Size(520, 201);
            this.tpExperience.TabIndex = 1;
            this.tpExperience.Text = "经验";
            this.tpExperience.UseVisualStyleBackColor = true;
            // 
            // tpSchool
            // 
            this.tpSchool.Location = new System.Drawing.Point(8, 39);
            this.tpSchool.Name = "tpSchool";
            this.tpSchool.Size = new System.Drawing.Size(520, 201);
            this.tpSchool.TabIndex = 2;
            this.tpSchool.Text = "学校";
            this.tpSchool.UseVisualStyleBackColor = true;
            // 
            // btnSearchByNumber
            // 
            this.btnSearchByNumber.Location = new System.Drawing.Point(905, 707);
            this.btnSearchByNumber.Name = "btnSearchByNumber";
            this.btnSearchByNumber.Size = new System.Drawing.Size(235, 79);
            this.btnSearchByNumber.TabIndex = 29;
            this.btnSearchByNumber.Text = "依据学号查询成绩";
            this.btnSearchByNumber.UseVisualStyleBackColor = true;
            this.btnSearchByNumber.Click += new System.EventHandler(this.btnSearchByNumber_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1701, 717);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 69);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "删除学生信息";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1701, 610);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(211, 76);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "更新学生信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Dgv
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(1071, 109);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowTemplate.Height = 37;
            this.Dgv.Size = new System.Drawing.Size(867, 216);
            this.Dgv.TabIndex = 32;
            // 
            // lbl321
            // 
            this.lbl321.AutoSize = true;
            this.lbl321.Location = new System.Drawing.Point(1109, 61);
            this.lbl321.Name = "lbl321";
            this.lbl321.Size = new System.Drawing.Size(154, 24);
            this.lbl321.TabIndex = 33;
            this.lbl321.Text = "成绩查询显示";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1003, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 37);
            this.label8.TabIndex = 34;
            this.label8.Text = "课程编号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1003, 601);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 37);
            this.label9.TabIndex = 35;
            this.label9.Text = "成绩";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(1003, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 37);
            this.label10.TabIndex = 36;
            this.label10.Text = "课程名称";
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseNumber.Location = new System.Drawing.Point(1207, 445);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(206, 50);
            this.txtCourseNumber.TabIndex = 8;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseName.Location = new System.Drawing.Point(1207, 532);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(206, 50);
            this.txtCourseName.TabIndex = 9;
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGrade.Location = new System.Drawing.Point(1207, 598);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(206, 50);
            this.txtGrade.TabIndex = 10;
            // 
            // FrmStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1989, 801);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl321);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchByNumber);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStuInfo";
            this.Text = "FrmStuInfo";
            this.Load += new System.EventHandler(this.FrmStuInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbClass;
        public System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbShi;
        public System.Windows.Forms.ComboBox cmbSheng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHoppies;
        private System.Windows.Forms.TabPage tpExperience;
        private System.Windows.Forms.TabPage tpSchool;
        public System.Windows.Forms.RadioButton rdbFemale;
        public System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchByNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label lbl321;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.ComboBox cmbQu;
        private System.Windows.Forms.Label label11;
    }
}