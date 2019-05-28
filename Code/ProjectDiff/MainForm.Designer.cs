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
            this.nvTabs = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kpProject = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.dgvProjects = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colItem1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItem2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItems3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItem4 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItem5 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItem6 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItem7 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItem8 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.plButtons1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btmLoadProjects = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kpWorker = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.dgvWorkers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colItemss1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItemss2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItemss3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.plButtons2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnLoadWorkers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kpDiff = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.dgvDiff = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.plButtons3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCheckLine = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnExportTo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStartForFull = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnStartForLike = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ofdExcels = new System.Windows.Forms.OpenFileDialog();
            this.sfdExcels = new System.Windows.Forms.SaveFileDialog();
            this.colProjectUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectCreater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsss6 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItemsss1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItemsss2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItemsss7 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colItemsss3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nvTabs)).BeginInit();
            this.nvTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpProject)).BeginInit();
            this.kpProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons1.Panel)).BeginInit();
            this.plButtons1.Panel.SuspendLayout();
            this.plButtons1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpWorker)).BeginInit();
            this.kpWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons2.Panel)).BeginInit();
            this.plButtons2.Panel.SuspendLayout();
            this.plButtons2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpDiff)).BeginInit();
            this.kpDiff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons3.Panel)).BeginInit();
            this.plButtons3.Panel.SuspendLayout();
            this.plButtons3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nvTabs
            // 
            this.nvTabs.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.nvTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvTabs.Location = new System.Drawing.Point(0, 0);
            this.nvTabs.Name = "nvTabs";
            this.nvTabs.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
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
            this.kpProject.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpProject.Controls.Add(this.dgvProjects);
            this.kpProject.Controls.Add(this.plButtons1);
            this.kpProject.Flags = 65534;
            this.kpProject.LastVisibleSet = true;
            this.kpProject.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpProject.Name = "kpProject";
            this.kpProject.Size = new System.Drawing.Size(821, 496);
            this.kpProject.Text = "项目汇总";
            this.kpProject.ToolTipTitle = "Page ToolTip";
            this.kpProject.UniqueName = "99520EB0D9264031FABAF4552A8C1428";
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
            this.plButtons1.Panel.Controls.Add(this.btmLoadProjects);
            this.plButtons1.Size = new System.Drawing.Size(821, 49);
            this.plButtons1.TabIndex = 2;
            this.plButtons1.Values.Heading = "";
            // 
            // btmLoadProjects
            // 
            this.btmLoadProjects.Dock = System.Windows.Forms.DockStyle.Right;
            this.btmLoadProjects.Location = new System.Drawing.Point(706, 0);
            this.btmLoadProjects.Name = "btmLoadProjects";
            this.btmLoadProjects.Size = new System.Drawing.Size(111, 43);
            this.btmLoadProjects.TabIndex = 0;
            this.btmLoadProjects.Values.Text = "载入项目信息";
            this.btmLoadProjects.Click += new System.EventHandler(this.btmLoadProjects_Click);
            // 
            // kpWorker
            // 
            this.kpWorker.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpWorker.Controls.Add(this.dgvWorkers);
            this.kpWorker.Controls.Add(this.plButtons2);
            this.kpWorker.Flags = 65534;
            this.kpWorker.LastVisibleSet = true;
            this.kpWorker.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpWorker.Name = "kpWorker";
            this.kpWorker.Size = new System.Drawing.Size(821, 496);
            this.kpWorker.Text = "评审专家信息";
            this.kpWorker.ToolTipTitle = "Page ToolTip";
            this.kpWorker.UniqueName = "C433756FA1B5481A3D9643875B24FA6A";
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
            this.plButtons2.Panel.Controls.Add(this.btnLoadWorkers);
            this.plButtons2.Size = new System.Drawing.Size(821, 49);
            this.plButtons2.TabIndex = 2;
            this.plButtons2.Values.Heading = "";
            // 
            // btnLoadWorkers
            // 
            this.btnLoadWorkers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadWorkers.Location = new System.Drawing.Point(727, 0);
            this.btnLoadWorkers.Name = "btnLoadWorkers";
            this.btnLoadWorkers.Size = new System.Drawing.Size(90, 43);
            this.btnLoadWorkers.TabIndex = 0;
            this.btnLoadWorkers.Values.Text = "载入专家信息";
            this.btnLoadWorkers.Click += new System.EventHandler(this.btnLoadWorkers_Click);
            // 
            // kpDiff
            // 
            this.kpDiff.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpDiff.Controls.Add(this.dgvDiff);
            this.kpDiff.Controls.Add(this.plButtons3);
            this.kpDiff.Flags = 65534;
            this.kpDiff.LastVisibleSet = true;
            this.kpDiff.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpDiff.Name = "kpDiff";
            this.kpDiff.Size = new System.Drawing.Size(821, 496);
            this.kpDiff.Text = "功能比对";
            this.kpDiff.ToolTipTitle = "Page ToolTip";
            this.kpDiff.UniqueName = "26E920A4234742D5F6980439F1F5717B";
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
            this.colItemsss7,
            this.colItemsss3});
            this.dgvDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiff.Location = new System.Drawing.Point(0, 49);
            this.dgvDiff.Name = "dgvDiff";
            this.dgvDiff.RowTemplate.Height = 23;
            this.dgvDiff.Size = new System.Drawing.Size(821, 447);
            this.dgvDiff.TabIndex = 1;
            this.dgvDiff.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDiff_RowPostPaint);
            this.dgvDiff.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDiff_RowsAdded);
            // 
            // plButtons3
            // 
            this.plButtons3.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons3.Location = new System.Drawing.Point(0, 0);
            this.plButtons3.Name = "plButtons3";
            // 
            // plButtons3.Panel
            // 
            this.plButtons3.Panel.Controls.Add(this.kryptonLabel2);
            this.plButtons3.Panel.Controls.Add(this.kryptonLabel1);
            this.plButtons3.Panel.Controls.Add(this.txtCheckLine);
            this.plButtons3.Panel.Controls.Add(this.btnExportTo);
            this.plButtons3.Panel.Controls.Add(this.btnStartForFull);
            this.plButtons3.Panel.Controls.Add(this.btnStartForLike);
            this.plButtons3.Size = new System.Drawing.Size(821, 49);
            this.plButtons3.TabIndex = 0;
            this.plButtons3.Values.Heading = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(193, 10);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(21, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "%";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(135, 20);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "模糊匹配相似度阀值：";
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
            // btnExportTo
            // 
            this.btnExportTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportTo.Location = new System.Drawing.Point(540, 0);
            this.btnExportTo.Name = "btnExportTo";
            this.btnExportTo.Size = new System.Drawing.Size(90, 43);
            this.btnExportTo.TabIndex = 1;
            this.btnExportTo.Values.Text = "导出到Excel";
            this.btnExportTo.Click += new System.EventHandler(this.btnExportTo_Click);
            // 
            // btnStartForFull
            // 
            this.btnStartForFull.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartForFull.Location = new System.Drawing.Point(630, 0);
            this.btnStartForFull.Name = "btnStartForFull";
            this.btnStartForFull.Size = new System.Drawing.Size(97, 43);
            this.btnStartForFull.TabIndex = 0;
            this.btnStartForFull.Values.Text = "全部精确匹配";
            this.btnStartForFull.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStartForLike
            // 
            this.btnStartForLike.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartForLike.Location = new System.Drawing.Point(727, 0);
            this.btnStartForLike.Name = "btnStartForLike";
            this.btnStartForLike.Size = new System.Drawing.Size(90, 43);
            this.btnStartForLike.TabIndex = 2;
            this.btnStartForLike.Values.Text = "单位模糊匹配";
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
            // colItemsss7
            // 
            this.colItemsss7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsss7.HeaderText = "相似度";
            this.colItemsss7.Name = "colItemsss7";
            this.colItemsss7.ReadOnly = true;
            this.colItemsss7.Width = 72;
            // 
            // colItemsss3
            // 
            this.colItemsss3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemsss3.HeaderText = "原因";
            this.colItemsss3.Name = "colItemsss3";
            this.colItemsss3.ReadOnly = true;
            this.colItemsss3.Width = 328;
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
            ((System.ComponentModel.ISupportInitialize)(this.nvTabs)).EndInit();
            this.nvTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpProject)).EndInit();
            this.kpProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons1.Panel)).EndInit();
            this.plButtons1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plButtons1)).EndInit();
            this.plButtons1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpWorker)).EndInit();
            this.kpWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons2.Panel)).EndInit();
            this.plButtons2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plButtons2)).EndInit();
            this.plButtons2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpDiff)).EndInit();
            this.kpDiff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons3.Panel)).EndInit();
            this.plButtons3.Panel.ResumeLayout(false);
            this.plButtons3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plButtons3)).EndInit();
            this.plButtons3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator nvTabs;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpProject;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpWorker;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpDiff;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvDiff;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox plButtons3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStartForFull;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvWorkers;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox plButtons2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoadWorkers;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProjects;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox plButtons1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btmLoadProjects;
        private System.Windows.Forms.OpenFileDialog ofdExcels;
        private System.Windows.Forms.SaveFileDialog sfdExcels;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItems3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem6;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem7;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItem8;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemss1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemss2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemss3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExportTo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStartForLike;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown txtCheckLine;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCreater;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemsss6;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemsss1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemsss2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemsss7;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colItemsss3;
    }
}

