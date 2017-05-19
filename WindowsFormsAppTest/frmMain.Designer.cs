namespace WindowsFormsAppTest
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Login_In = new System.Windows.Forms.Button();
            this.MainExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSheng = new System.Windows.Forms.ComboBox();
            this.cmbShi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbClass = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存储库ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.存储库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.从现有代码创建项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.起始页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.团队ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFromMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除第一行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDateShow = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbPgLa1 = new System.Windows.Forms.ListBox();
            this.lbPgLa2 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSchoolStdShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsListBox.SuspendLayout();
            this.cmsFromMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_In
            // 
            this.Login_In.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_In.Location = new System.Drawing.Point(80, 128);
            this.Login_In.Name = "Login_In";
            this.Login_In.Size = new System.Drawing.Size(310, 107);
            this.Login_In.TabIndex = 0;
            this.Login_In.Text = "登录窗口";
            this.Login_In.UseVisualStyleBackColor = true;
            this.Login_In.Click += new System.EventHandler(this.Login_In_Click);
            // 
            // MainExit
            // 
            this.MainExit.Location = new System.Drawing.Point(1319, 247);
            this.MainExit.Name = "MainExit";
            this.MainExit.Size = new System.Drawing.Size(229, 87);
            this.MainExit.TabIndex = 1;
            this.MainExit.Text = "退出";
            this.MainExit.UseVisualStyleBackColor = true;
            this.MainExit.Click += new System.EventHandler(this.MainExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "性别";
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(38, 28);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(65, 28);
            this.rdbMan.TabIndex = 4;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "男";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(174, 28);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(65, 28);
            this.rdbWoman.TabIndex = 5;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "女";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbMan);
            this.panel1.Controls.Add(this.rdbWoman);
            this.panel1.Location = new System.Drawing.Point(581, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 88);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "籍贯";
            // 
            // cmbSheng
            // 
            this.cmbSheng.FormattingEnabled = true;
            this.cmbSheng.Location = new System.Drawing.Point(641, 278);
            this.cmbSheng.Name = "cmbSheng";
            this.cmbSheng.Size = new System.Drawing.Size(121, 32);
            this.cmbSheng.TabIndex = 7;
            this.cmbSheng.SelectedIndexChanged += new System.EventHandler(this.CmbSheng_SelectedIndexChanged);
            // 
            // cmbShi
            // 
            this.cmbShi.FormattingEnabled = true;
            this.cmbShi.Location = new System.Drawing.Point(883, 275);
            this.cmbShi.Name = "cmbShi";
            this.cmbShi.Size = new System.Drawing.Size(121, 32);
            this.cmbShi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(781, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "省";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1043, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "市";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "学号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "班级";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(643, 348);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(100, 35);
            this.txbNumber.TabIndex = 13;
            // 
            // txbClass
            // 
            this.txbClass.Location = new System.Drawing.Point(643, 428);
            this.txbClass.Name = "txbClass";
            this.txbClass.Size = new System.Drawing.Size(100, 35);
            this.txbClass.TabIndex = 14;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(813, 396);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(203, 53);
            this.btnInput.TabIndex = 15;
            this.btnInput.Text = "录入信息";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1253, 128);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 24);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "lblTime";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.项目ToolStripMenuItem,
            this.生成ToolStripMenuItem,
            this.调试ToolStripMenuItem,
            this.团队ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.测试ToolStripMenuItem,
            this.分析ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 39);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.起始页ToolStripMenuItem,
            this.添加ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目ToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.网站ToolStripMenuItem,
            this.存储库ToolStripMenuItem,
            this.存储库ToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.文件ToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.从现有代码创建项目ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 项目ToolStripMenuItem1
            // 
            this.项目ToolStripMenuItem1.Name = "项目ToolStripMenuItem1";
            this.项目ToolStripMenuItem1.Size = new System.Drawing.Size(329, 38);
            this.项目ToolStripMenuItem1.Text = "项目";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(326, 6);
            // 
            // 网站ToolStripMenuItem
            // 
            this.网站ToolStripMenuItem.Name = "网站ToolStripMenuItem";
            this.网站ToolStripMenuItem.Size = new System.Drawing.Size(329, 38);
            this.网站ToolStripMenuItem.Text = "网站";
            // 
            // 存储库ToolStripMenuItem
            // 
            this.存储库ToolStripMenuItem.Name = "存储库ToolStripMenuItem";
            this.存储库ToolStripMenuItem.Size = new System.Drawing.Size(326, 6);
            // 
            // 存储库ToolStripMenuItem1
            // 
            this.存储库ToolStripMenuItem1.Name = "存储库ToolStripMenuItem1";
            this.存储库ToolStripMenuItem1.Size = new System.Drawing.Size(329, 38);
            this.存储库ToolStripMenuItem1.Text = "存储库";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(326, 6);
            // 
            // 文件ToolStripMenuItem1
            // 
            this.文件ToolStripMenuItem1.Name = "文件ToolStripMenuItem1";
            this.文件ToolStripMenuItem1.Size = new System.Drawing.Size(329, 38);
            this.文件ToolStripMenuItem1.Text = "文件";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(326, 6);
            // 
            // 从现有代码创建项目ToolStripMenuItem
            // 
            this.从现有代码创建项目ToolStripMenuItem.Name = "从现有代码创建项目ToolStripMenuItem";
            this.从现有代码创建项目ToolStripMenuItem.Size = new System.Drawing.Size(329, 38);
            this.从现有代码创建项目ToolStripMenuItem.Text = "从现有代码创建项目";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 起始页ToolStripMenuItem
            // 
            this.起始页ToolStripMenuItem.Name = "起始页ToolStripMenuItem";
            this.起始页ToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.起始页ToolStripMenuItem.Text = "起始页";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 项目ToolStripMenuItem
            // 
            this.项目ToolStripMenuItem.Name = "项目ToolStripMenuItem";
            this.项目ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.项目ToolStripMenuItem.Text = "项目";
            // 
            // 生成ToolStripMenuItem
            // 
            this.生成ToolStripMenuItem.Name = "生成ToolStripMenuItem";
            this.生成ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.生成ToolStripMenuItem.Text = "生成";
            // 
            // 调试ToolStripMenuItem
            // 
            this.调试ToolStripMenuItem.Name = "调试ToolStripMenuItem";
            this.调试ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.调试ToolStripMenuItem.Text = "调试";
            // 
            // 团队ToolStripMenuItem
            // 
            this.团队ToolStripMenuItem.Name = "团队ToolStripMenuItem";
            this.团队ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.团队ToolStripMenuItem.Text = "团队";
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.测试ToolStripMenuItem.Text = "测试";
            // 
            // 分析ToolStripMenuItem
            // 
            this.分析ToolStripMenuItem.Name = "分析ToolStripMenuItem";
            this.分析ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.分析ToolStripMenuItem.Text = "分析";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 869);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1576, 36);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(304, 31);
            this.toolStripStatusLabel1.Text = "版权所有,盗版必究 : 徐络溟";
            // 
            // cmsListBox
            // 
            this.cmsListBox.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem1,
            this.删除ToolStripMenuItem});
            this.cmsListBox.Name = "contextMenuStrip1";
            this.cmsListBox.Size = new System.Drawing.Size(162, 80);
            // 
            // 新建ToolStripMenuItem1
            // 
            this.新建ToolStripMenuItem1.Name = "新建ToolStripMenuItem1";
            this.新建ToolStripMenuItem1.Size = new System.Drawing.Size(161, 38);
            this.新建ToolStripMenuItem1.Text = "新建";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(161, 38);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // cmsFromMain
            // 
            this.cmsFromMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsFromMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.删除第一行ToolStripMenuItem});
            this.cmsFromMain.Name = "contextMenuStrip2";
            this.cmsFromMain.Size = new System.Drawing.Size(234, 80);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 删除第一行ToolStripMenuItem
            // 
            this.删除第一行ToolStripMenuItem.Name = "删除第一行ToolStripMenuItem";
            this.删除第一行ToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.删除第一行ToolStripMenuItem.Text = "删除第一行";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDateShow
            // 
            this.btnDateShow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDateShow.Location = new System.Drawing.Point(80, 384);
            this.btnDateShow.Name = "btnDateShow";
            this.btnDateShow.Size = new System.Drawing.Size(271, 77);
            this.btnDateShow.TabIndex = 21;
            this.btnDateShow.Text = "DateShow";
            this.btnDateShow.UseVisualStyleBackColor = true;
            this.btnDateShow.Click += new System.EventHandler(this.btnDateShow_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(80, 322);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 35);
            this.dtpBirthday.TabIndex = 22;
            // 
            // lbPgLa1
            // 
            this.lbPgLa1.ContextMenuStrip = this.cmsListBox;
            this.lbPgLa1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPgLa1.FormattingEnabled = true;
            this.lbPgLa1.ItemHeight = 24;
            this.lbPgLa1.Items.AddRange(new object[] {
            "C",
            "C#",
            "C++",
            "Java",
            "Python",
            "PHP"});
            this.lbPgLa1.Location = new System.Drawing.Point(0, 0);
            this.lbPgLa1.Name = "lbPgLa1";
            this.lbPgLa1.Size = new System.Drawing.Size(320, 340);
            this.lbPgLa1.TabIndex = 23;
            this.lbPgLa1.DoubleClick += new System.EventHandler(this.lbPgLa1_DoubleClick);
            // 
            // lbPgLa2
            // 
            this.lbPgLa2.ContextMenuStrip = this.cmsListBox;
            this.lbPgLa2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbPgLa2.FormattingEnabled = true;
            this.lbPgLa2.ItemHeight = 24;
            this.lbPgLa2.Location = new System.Drawing.Point(326, 0);
            this.lbPgLa2.Name = "lbPgLa2";
            this.lbPgLa2.Size = new System.Drawing.Size(364, 340);
            this.lbPgLa2.TabIndex = 24;
            this.lbPgLa2.SelectedIndexChanged += new System.EventHandler(this.lbPgLa2_DoubleClick);
            this.lbPgLa2.DoubleClick += new System.EventHandler(this.lbPgLa2_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPgLa1);
            this.panel2.Controls.Add(this.lbPgLa2);
            this.panel2.Location = new System.Drawing.Point(449, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 340);
            this.panel2.TabIndex = 25;
            // 
            // btnSchoolStdShow
            // 
            this.btnSchoolStdShow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSchoolStdShow.Location = new System.Drawing.Point(80, 540);
            this.btnSchoolStdShow.Name = "btnSchoolStdShow";
            this.btnSchoolStdShow.Size = new System.Drawing.Size(303, 90);
            this.btnSchoolStdShow.TabIndex = 26;
            this.btnSchoolStdShow.Text = "学校学生信息显示";
            this.btnSchoolStdShow.UseVisualStyleBackColor = true;
            this.btnSchoolStdShow.Click += new System.EventHandler(this.btnSchoolStdShow_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 905);
            this.ContextMenuStrip = this.cmsFromMain;
            this.Controls.Add(this.btnSchoolStdShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.btnDateShow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txbClass);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbShi);
            this.Controls.Add(this.cmbSheng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainExit);
            this.Controls.Add(this.Login_In);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsListBox.ResumeLayout(false);
            this.cmsFromMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_In;
        private System.Windows.Forms.Button MainExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSheng;
        private System.Windows.Forms.ComboBox cmbShi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbClass;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 网站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 存储库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存储库ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 从现有代码创建项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 起始页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 团队ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsListBox;
        private System.Windows.Forms.ContextMenuStrip cmsFromMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDateShow;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ListBox lbPgLa1;
        private System.Windows.Forms.ListBox lbPgLa2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除第一行ToolStripMenuItem;
        private System.Windows.Forms.Button btnSchoolStdShow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

