namespace ProjectDiff
{
    partial class MainForm
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
            this.nvTabs = new System.Windows.Forms.TabControl();
            this.kpProject = new System.Windows.Forms.TabPage();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.colItem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItems3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plButtons1 = new System.Windows.Forms.GroupBox();
            this.btmLoadProjects = new System.Windows.Forms.Button();
            this.kpWorker = new System.Windows.Forms.TabPage();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.colItemss1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemss2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemss3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plButtons2 = new System.Windows.Forms.GroupBox();
            this.btnLoadWorkers = new System.Windows.Forms.Button();
            this.kpDiff = new System.Windows.Forms.TabPage();
            this.dgvDiff = new System.Windows.Forms.DataGridView();
            this.colProjectUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectCreater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsss6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsss1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsss2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsss3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsss7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plButtons3 = new System.Windows.Forms.GroupBox();
            this.btnExportTo = new System.Windows.Forms.Button();
            this.btnStartForPersonFullUnitLike = new System.Windows.Forms.Button();
            this.kryptonLabel2 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new System.Windows.Forms.Label();
            this.txtCheckLine = new System.Windows.Forms.NumericUpDown();
            this.btnStartForFull = new System.Windows.Forms.Button();
            this.btnStartForLike = new System.Windows.Forms.Button();
            this.ofdExcels = new System.Windows.Forms.OpenFileDialog();
            this.sfdExcels = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nvTabs
            // 
            this.nvTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvTabs.Location = new System.Drawing.Point(0, 0);
            this.nvTabs.Name = "nvTabs";
            this.nvTabs.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
            this.kpProject,
            this.kpWorker,
            this.kpDiff});
            this.nvTabs.SelectedIndex = 0;
            this.nvTabs.Size = new System.Drawing.Size(823, 523);
            this.nvTabs.TabIndex = 0;
            this.nvTabs.Text = "kryptonNavigator1";
            // 
            // kpProject
            // 
            this.kpProject.Controls.Add(this.dgvProjects);
            this.kpProject.Controls.Add(this.plButtons1);
            this.kpProject.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpProject.Name = "kpProject";
            this.kpProject.Size = new System.Drawing.Size(821, 496);
            this.kpProject.Text = "项目汇总";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem1,
            this.colItem2,
            this.colItems3,
            this.colItem4,
            this.colItem5,
            this.colItem6,
            this.colItem7,
            this.colItem8});
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 49);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowTemplate.Height = 23;
            this.dgvProjects.Size = new System.Drawing.Size(821, 447);
            this.dgvProjects.TabIndex = 3;
            this.dgvProjects.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProjects_RowPostPaint);
            this.dgvProjects.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProjects_RowsAdded);
            // 
            // colItem1
            // 
            this.colItem1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem1.HeaderText = "项目名称";
            this.colItem1.Name = "colItem1";
            this.colItem1.ReadOnly = true;
            this.colItem1.Width = 98;
            // 
            // colItem2
            // 
            this.colItem2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem2.HeaderText = "候选对象";
            this.colItem2.Name = "colItem2";
            this.colItem2.ReadOnly = true;
            this.colItem2.Width = 97;
            // 
            // colItems3
            // 
            this.colItems3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItems3.HeaderText = "单位";
            this.colItems3.Name = "colItems3";
            this.colItems3.ReadOnly = true;
            this.colItems3.Width = 98;
            // 
            // colItem4
            // 
            this.colItem4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem4.HeaderText = "分组";
            this.colItem4.Name = "colItem4";
            this.colItem4.ReadOnly = true;
            this.colItem4.Width = 97;
            // 
            // colItem5
            // 
            this.colItem5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem5.HeaderText = "责任导师";
            this.colItem5.Name = "colItem5";
            this.colItem5.ReadOnly = true;
            this.colItem5.Width = 98;
            // 
            // colItem6
            // 
            this.colItem6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem6.HeaderText = "推荐专家";
            this.colItem6.Name = "colItem6";
            this.colItem6.ReadOnly = true;
            this.colItem6.Width = 97;
            // 
            // colItem7
            // 
            this.colItem7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem7.HeaderText = "推荐专家";
            this.colItem7.Name = "colItem7";
            this.colItem7.ReadOnly = true;
            this.colItem7.Width = 98;
            // 
            // colItem8
            // 
            this.colItem8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem8.HeaderText = "推荐专家";
            this.colItem8.Name = "colItem8";
            this.colItem8.ReadOnly = true;
            this.colItem8.Width = 97;
            // 
            // plButtons1
            // 
            this.plButtons1.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons1.Location = new System.Drawing.Point(0, 0);
            this.plButtons1.Name = "plButtons1";
            // 
            // plButtons1.Panel
            // 
            this.plButtons1.Controls.Add(this.btmLoadProjects);
            this.plButtons1.Size = new System.Drawing.Size(821, 49);
            this.plButtons1.TabIndex = 2;
            // 
            // btmLoadProjects
            // 
            this.btmLoadProjects.Dock = System.Windows.Forms.DockStyle.Right;
            this.btmLoadProjects.Location = new System.Drawing.Point(706, 0);
            this.btmLoadProjects.Name = "btmLoadProjects";
            this.btmLoadProjects.Size = new System.Drawing.Size(111, 43);
            this.btmLoadProjects.TabIndex = 0;
            this.btmLoadProjects.Text = "载入项目信息";
            this.btmLoadProjects.Click += new System.EventHandler(this.btmLoadProjects_Click);
            // 
            // kpWorker
            // 
            this.kpWorker.Controls.Add(this.dgvWorkers);
            this.kpWorker.Controls.Add(this.plButtons2);
            this.kpWorker.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpWorker.Name = "kpWorker";
            this.kpWorker.Size = new System.Drawing.Size(821, 496);
            this.kpWorker.Text = "评审专家信息";
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemss1,
            this.colItemss2,
            this.colItemss3});
            this.dgvWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkers.Location = new System.Drawing.Point(0, 49);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowTemplate.Height = 23;
            this.dgvWorkers.Size = new System.Drawing.Size(821, 447);
            this.dgvWorkers.TabIndex = 3;
            this.dgvWorkers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvWorkers_RowPostPaint);
            this.dgvWorkers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvWorkers_RowsAdded);
            // 
            // colItemss1
            // 
            this.colItemss1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemss1.HeaderText = "专家姓名";
            this.colItemss1.Name = "colItemss1";
            this.colItemss1.ReadOnly = true;
            this.colItemss1.Width = 260;
            // 
            // colItemss2
            // 
            this.colItemss2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemss2.HeaderText = "专家单位";
            this.colItemss2.Name = "colItemss2";
            this.colItemss2.ReadOnly = true;
            this.colItemss2.Width = 260;
            // 
            // colItemss3
            // 
            this.colItemss3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemss3.HeaderText = "专家分组";
            this.colItemss3.Name = "colItemss3";
            this.colItemss3.ReadOnly = true;
            this.colItemss3.Width = 260;
            // 
            // plButtons2
            // 
            this.plButtons2.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons2.Location = new System.Drawing.Point(0, 0);
            this.plButtons2.Name = "plButtons2";
            // 
            // plButtons2.Panel
            // 
            this.plButtons2.Controls.Add(this.btnLoadWorkers);
            this.plButtons2.Size = new System.Drawing.Size(821, 49);
            this.plButtons2.TabIndex = 2;
            // 
            // btnLoadWorkers
            // 
            this.btnLoadWorkers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadWorkers.Location = new System.Drawing.Point(727, 0);
            this.btnLoadWorkers.Name = "btnLoadWorkers";
            this.btnLoadWorkers.Size = new System.Drawing.Size(90, 43);
            this.btnLoadWorkers.TabIndex = 0;
            this.btnLoadWorkers.Text = "载入专家信息";
            this.btnLoadWorkers.Click += new System.EventHandler(this.btnLoadWorkers_Click);
            // 
            // kpDiff
            // 
            this.kpDiff.Controls.Add(this.dgvDiff);
            this.kpDiff.Controls.Add(this.plButtons3);
            this.kpDiff.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpDiff.Name = "kpDiff";
            this.kpDiff.Size = new System.Drawing.Size(821, 496);
            this.kpDiff.Text = "功能比对";
            // 
            // dgvDiff
            // 
            this.dgvDiff.AllowUserToAddRows = false;
            this.dgvDiff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectUnit,
            this.colProjectCreater,
            this.colItemsss6,
            this.colItemsss1,
            this.colItemsss2,
            this.colItemsss3,
            this.colItemsss7});
            this.dgvDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiff.Location = new System.Drawing.Point(0, 49);
            this.dgvDiff.Name = "dgvDiff";
            this.dgvDiff.RowTemplate.Height = 23;
            this.dgvDiff.Size = new System.Drawing.Size(821, 447);
            this.dgvDiff.TabIndex = 1;
            this.dgvDiff.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDiff_RowPostPaint);
            this.dgvDiff.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDiff_RowsAdded);
            // 
            // colProjectUnit
            // 
            this.colProjectUnit.HeaderText = "项目单位";
            this.colProjectUnit.Name = "colProjectUnit";
            // 
            // colProjectCreater
            // 
            this.colProjectCreater.HeaderText = "项目申请人";
            this.colProjectCreater.Name = "colProjectCreater";
            // 
            // colItemsss6
            // 
            this.colItemsss6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsss6.HeaderText = "分组";
            this.colItemsss6.Name = "colItemsss6";
            this.colItemsss6.ReadOnly = true;
            this.colItemsss6.Width = 60;
            // 
            // colItemsss1
            // 
            this.colItemsss1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsss1.HeaderText = "项目";
            this.colItemsss1.Name = "colItemsss1";
            this.colItemsss1.ReadOnly = true;
            this.colItemsss1.Width = 60;
            // 
            // colItemsss2
            // 
            this.colItemsss2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsss2.HeaderText = "专家";
            this.colItemsss2.Name = "colItemsss2";
            this.colItemsss2.ReadOnly = true;
            this.colItemsss2.Width = 60;
            // 
            // colItemsss3
            // 
            this.colItemsss3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemsss3.HeaderText = "原因";
            this.colItemsss3.Name = "colItemsss3";
            this.colItemsss3.ReadOnly = true;
            this.colItemsss3.Width = 328;
            // 
            // colItemsss7
            // 
            this.colItemsss7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsss7.HeaderText = "相似度";
            this.colItemsss7.Name = "colItemsss7";
            this.colItemsss7.ReadOnly = true;
            this.colItemsss7.Width = 72;
            // 
            // plButtons3
            // 
            this.plButtons3.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons3.Location = new System.Drawing.Point(0, 0);
            this.plButtons3.Name = "plButtons3";
            // 
            // plButtons3.Panel
            // 
            this.plButtons3.Controls.Add(this.btnExportTo);
            this.plButtons3.Controls.Add(this.btnStartForPersonFullUnitLike);
            this.plButtons3.Controls.Add(this.kryptonLabel2);
            this.plButtons3.Controls.Add(this.kryptonLabel1);
            this.plButtons3.Controls.Add(this.txtCheckLine);
            this.plButtons3.Controls.Add(this.btnStartForFull);
            this.plButtons3.Controls.Add(this.btnStartForLike);
            this.plButtons3.Size = new System.Drawing.Size(821, 49);
            this.plButtons3.TabIndex = 0;
            // 
            // btnExportTo
            // 
            this.btnExportTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportTo.Location = new System.Drawing.Point(469, 0);
            this.btnExportTo.Name = "btnExportTo";
            this.btnExportTo.Size = new System.Drawing.Size(90, 43);
            this.btnExportTo.TabIndex = 1;
            this.btnExportTo.Text = "导出到Excel";
            this.btnExportTo.Click += new System.EventHandler(this.btnExportTo_Click);
            // 
            // btnStartForPersonFullUnitLike
            // 
            this.btnStartForPersonFullUnitLike.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartForPersonFullUnitLike.Location = new System.Drawing.Point(559, 0);
            this.btnStartForPersonFullUnitLike.Name = "btnStartForPersonFullUnitLike";
            this.btnStartForPersonFullUnitLike.Size = new System.Drawing.Size(71, 43);
            this.btnStartForPersonFullUnitLike.TabIndex = 5;
            this.btnStartForPersonFullUnitLike.Text = "单位包含";
            this.btnStartForPersonFullUnitLike.Click += new System.EventHandler(this.btnStartForPersonFullUnitLike_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(193, 10);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(21, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Text = "%";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(135, 20);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Text = "模糊匹配相似度阀值：";
            // 
            // txtCheckLine
            // 
            this.txtCheckLine.Location = new System.Drawing.Point(144, 10);
            this.txtCheckLine.Name = "txtCheckLine";
            this.txtCheckLine.Size = new System.Drawing.Size(46, 22);
            this.txtCheckLine.TabIndex = 3;
            this.txtCheckLine.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // btnStartForFull
            // 
            this.btnStartForFull.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartForFull.Location = new System.Drawing.Point(630, 0);
            this.btnStartForFull.Name = "btnStartForFull";
            this.btnStartForFull.Size = new System.Drawing.Size(97, 43);
            this.btnStartForFull.TabIndex = 0;
            this.btnStartForFull.Text = "全部精确匹配";
            this.btnStartForFull.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStartForLike
            // 
            this.btnStartForLike.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartForLike.Location = new System.Drawing.Point(727, 0);
            this.btnStartForLike.Name = "btnStartForLike";
            this.btnStartForLike.Size = new System.Drawing.Size(90, 43);
            this.btnStartForLike.TabIndex = 2;
            this.btnStartForLike.Text = "单位模糊匹配";
            this.btnStartForLike.Click += new System.EventHandler(this.btnStartForLike_Click);
            // 
            // ofdExcels
            // 
            this.ofdExcels.Filter = "*.xlsx|*.xlsx";
            // 
            // sfdExcels
            // 
            this.sfdExcels.FileName = "*.xlsx|*.xlsx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 523);
            this.Controls.Add(this.nvTabs);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专家信息比对  ";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl nvTabs;
        private System.Windows.Forms.TabPage kpProject;
        private System.Windows.Forms.TabPage kpWorker;
        private System.Windows.Forms.TabPage kpDiff;
        private System.Windows.Forms.DataGridView dgvDiff;
        private System.Windows.Forms.GroupBox plButtons3;
        private System.Windows.Forms.Button btnStartForFull;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.GroupBox plButtons2;
        private System.Windows.Forms.Button btnLoadWorkers;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.GroupBox plButtons1;
        private System.Windows.Forms.Button btmLoadProjects;
        private System.Windows.Forms.OpenFileDialog ofdExcels;
        private System.Windows.Forms.SaveFileDialog sfdExcels;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemss1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemss2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemss3;
        private System.Windows.Forms.Button btnExportTo;
        private System.Windows.Forms.Button btnStartForLike;
        private System.Windows.Forms.NumericUpDown txtCheckLine;
        private System.Windows.Forms.Label kryptonLabel1;
        private System.Windows.Forms.Label kryptonLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCreater;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsss6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsss1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsss2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsss3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsss7;
        private System.Windows.Forms.Button btnStartForPersonFullUnitLike;
    }
}