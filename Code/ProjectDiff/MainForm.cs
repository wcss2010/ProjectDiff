using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ProjectDiff.Util;

namespace ProjectDiff
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btmLoadProjects_Click(object sender, EventArgs e)
        {
            if (ofdExcels.ShowDialog() == DialogResult.OK)
            {
                dgvProjects.Rows.Clear();
                DataSet ds = ExcelHelper.ExcelToDataSet(ofdExcels.FileName);
                if (ds != null && ds.Tables.Count >= 1 && dgvProjects.Columns.Count == ds.Tables[0].Columns.Count)
                {
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0] != null && dr[0].ToString().Equals("项目名称"))
                            {
                                continue;
                            }

                            if (dr.ItemArray != null)
                            {
                                List<string> cells = new List<string>();

                                //统计空格次数
                                int emptyCount = 0;
                                foreach (object o in dr.ItemArray)
                                {
                                    string val = o != null ? o.ToString().Trim().Replace(" ", string.Empty) : string.Empty;
                                    if (string.IsNullOrEmpty(val))
                                    {
                                        emptyCount++;
                                    }

                                    cells.Add(val);
                                }

                                if (emptyCount < cells.Count)
                                {
                                    dgvProjects.Rows.Add(cells.ToArray());
                                }
                            }
                        }
                        break;
                    }

                    MessageBox.Show("导入完成！");
                }
                else
                {
                    MessageBox.Show("对不起，正在导入错误的模板！");
                }
            }
        }

        private void btnLoadWorkers_Click(object sender, EventArgs e)
        {
            if (ofdExcels.ShowDialog() == DialogResult.OK)
            {
                dgvWorkers.Rows.Clear();
                DataSet ds = ExcelHelper.ExcelToDataSet(ofdExcels.FileName);
                if (ds != null && ds.Tables.Count >= 1 && dgvWorkers.Columns.Count == ds.Tables[0].Columns.Count)
                {
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0] != null && dr[0].ToString().Equals("专家名称"))
                            {
                                continue;
                            }
                            
                            if (dr.ItemArray != null)
                            {
                                List<string> cells = new List<string>();

                                //统计空格次数
                                int emptyCount = 0;
                                foreach (object o in dr.ItemArray)
                                {
                                    string val = o != null ? o.ToString().Trim().Replace(" ", string.Empty) : string.Empty;
                                    if (string.IsNullOrEmpty(val))
                                    {
                                        emptyCount++;
                                    }

                                    cells.Add(val);
                                }

                                if (emptyCount < cells.Count)
                                {
                                    dgvWorkers.Rows.Add(cells.ToArray());
                                }
                            }
                        }

                        break;
                    }

                    MessageBox.Show("导入完成！");
                }
                else
                {
                    MessageBox.Show("对不起，正在导入错误的模板!");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dgvDiff.Rows.Clear();
            foreach (DataGridViewRow drWorker in dgvWorkers.Rows)
            {
                string workerName = drWorker.Cells[0].Value.ToString();
                string workerUnit = drWorker.Cells[1].Value.ToString();
                string workerGroup = drWorker.Cells[2].Value.ToString();

                foreach (DataGridViewRow drProject in dgvProjects.Rows)
                {
                    string projectName = drProject.Cells[0].Value.ToString();
                    string projectCreater = drProject.Cells[1].Value.ToString();
                    string projectUnit = drProject.Cells[2].Value.ToString();
                    string projectGroup = drProject.Cells[3].Value.ToString();
                    string projectMaster = drProject.Cells[4].Value != null ? (string.IsNullOrEmpty(drProject.Cells[4].Value.ToString()) ? null : drProject.Cells[4].Value.ToString()) : null;
                    string projectWorker1 = drProject.Cells[5].Value.ToString();
                    string projectWorker2 = drProject.Cells[6].Value.ToString();
                    string projectWorker3 = drProject.Cells[7].Value.ToString();
                    
                    if (projectMaster != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectMaster.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);                        
                        cells.Add(workerName + "是责任导师");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是责任导师");
                    }
                    if (projectWorker1 != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectWorker1.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是推荐专家");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是推荐专家");
                    }
                    if (projectWorker2 != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectWorker2.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是推荐专家");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是推荐专家");
                    }
                    if (projectWorker3 != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectWorker3.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是推荐专家");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是推荐专家");
                    }
                    if (projectUnit != null && workerUnit != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectUnit.Equals(workerUnit))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add("评审专家" + workerName + "与申请人" + projectCreater + "所在单位相同");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:评审专家与" + workerName + "所在单位相同");
                    }
                }
            }
            dgvDiff.Sort(colItemsss1, ListSortDirection.Descending);
            MessageBox.Show("比对完成！");
        }

        private void WriteLog(string log)
        {
            try
            {
                string logPath = Path.Combine(Application.StartupPath, "Log");
                logPath = Path.Combine(logPath, DateTime.Now.Year + "");
                logPath = Path.Combine(logPath, DateTime.Now.Month + "");
                logPath = Path.Combine(logPath, DateTime.Now.Day + "");

                try
                {
                    Directory.CreateDirectory(logPath);
                }
                catch (Exception ex) { }

                string logText = DateTime.Now.ToString() + ":::" + log;
                string logFile = Path.Combine(logPath, "now.log");

                StreamWriter sw = File.AppendText(logFile);
                try
                {
                    sw.WriteLine(logText);
                }
                finally
                {
                    sw.Close();
                }
            }
            catch (Exception exx)
            {
                System.Console.WriteLine(exx.ToString());
            }
        }

        private void btnExportTo_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDgvToTable(dgvDiff);
            ExcelHelper.ExportToExcel(dt);
        }

        public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].HeaderText.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void dgvProjects_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvWorkers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvDiff_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvProjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dgvWorkers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dgvDiff_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnStartForLike_Click(object sender, EventArgs e)
        {
            StringCompute stringCompute = new StringCompute();

            dgvDiff.Rows.Clear();
            foreach (DataGridViewRow drWorker in dgvWorkers.Rows)
            {
                string workerName = drWorker.Cells[0].Value.ToString();
                string workerUnit = drWorker.Cells[1].Value.ToString();
                string workerGroup = drWorker.Cells[2].Value.ToString();
                foreach (DataGridViewRow drProject in dgvProjects.Rows)
                {
                    string projectName = drProject.Cells[0].Value.ToString();
                    string projectCreater = drProject.Cells[1].Value.ToString();
                    string projectUnit = drProject.Cells[2].Value.ToString();
                    string projectGroup = drProject.Cells[3].Value.ToString();
                    string projectMaster = drProject.Cells[4].Value.ToString();
                    string projectWorker1 = drProject.Cells[5].Value.ToString();
                    string projectWorker2 = drProject.Cells[6].Value.ToString();
                    string projectWorker3 = drProject.Cells[7].Value.ToString();

                    List<object> cells = new List<object>();
                    if (workerGroup != null && projectGroup != null && projectGroup.Equals(workerGroup))
                    {
                        stringCompute.SpeedyCompute(workerUnit, projectUnit);    // 计算相似度， 不记录比较时间
                        int rate = (int)(stringCompute.ComputeResult.Rate * 100);         // 相似度百分之几，完全匹配相似度为1

                        if (rate >= txtCheckLine.Value)
                        {
                            cells.Add(projectUnit);
                            cells.Add(projectCreater);
                            cells.Add(projectGroup);
                            cells.Add(projectName);
                            cells.Add(workerName);
                            cells.Add("评审专家单位(" + workerUnit + ")与项目单位(" + projectUnit + ")相似度为" + rate + "%");
                            cells.Add(rate + "%");

                            dgvDiff.Rows.Add(cells.ToArray());

                            WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + "评审专家单位(" + workerUnit + ")与项目单位(" + projectUnit + ")相似度为" + rate + "%");
                        }
                    }
                }
            }

            dgvDiff.Sort(colItemsss1, ListSortDirection.Descending);
            dgvDiff.Sort(colItemsss3, ListSortDirection.Descending);

            MessageBox.Show("比对完成！");
        }

        private void btnStartForPersonFullUnitLike_Click(object sender, EventArgs e)
        {
            dgvDiff.Rows.Clear();
            foreach (DataGridViewRow drWorker in dgvWorkers.Rows)
            {
                string workerName = drWorker.Cells[0].Value.ToString();
                string workerUnit = drWorker.Cells[1].Value.ToString();
                string workerGroup = drWorker.Cells[2].Value.ToString();

                foreach (DataGridViewRow drProject in dgvProjects.Rows)
                {
                    string projectName = drProject.Cells[0].Value.ToString();
                    string projectCreater = drProject.Cells[1].Value.ToString();
                    string projectUnit = drProject.Cells[2].Value.ToString();
                    string projectGroup = drProject.Cells[3].Value.ToString();
                    string projectMaster = drProject.Cells[4].Value != null ? (string.IsNullOrEmpty(drProject.Cells[4].Value.ToString()) ? null : drProject.Cells[4].Value.ToString()) : null;
                    string projectWorker1 = drProject.Cells[5].Value.ToString();
                    string projectWorker2 = drProject.Cells[6].Value.ToString();
                    string projectWorker3 = drProject.Cells[7].Value.ToString();

                    if (projectMaster != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectMaster.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是责任导师");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是责任导师");
                    }
                    if (projectWorker1 != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectWorker1.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是推荐专家");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是推荐专家");
                    }
                    if (projectWorker2 != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectWorker2.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是推荐专家");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是推荐专家");
                    }
                    if (projectWorker3 != null && workerName != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && projectWorker3.Equals(workerName))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add(workerName + "是推荐专家");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:" + workerName + "是推荐专家");
                    }
                    if (projectUnit != null && workerUnit != null && projectGroup != null && workerGroup != null && projectGroup.Equals(workerGroup) && (projectUnit.Contains(workerUnit) || workerUnit.Contains(projectUnit)))
                    {
                        List<string> cells = new List<string>();
                        cells.Add(projectUnit);
                        cells.Add(projectCreater);
                        cells.Add(projectGroup);
                        cells.Add(projectName);
                        cells.Add(workerName);
                        cells.Add("评审专家(" + workerName + ")的单位(" + workerUnit + ")与申请人(" + projectCreater + ")的单位(" + projectUnit + ")关系需要核实");
                        cells.Add("100%");
                        dgvDiff.Rows.Add(cells.ToArray());

                        WriteLog("Group:" + projectGroup + ",Project:" + projectName + ",Worker:" + workerName + ",Result:评审专家与" + workerName + "关系需要核实");
                    }
                }
            }
            dgvDiff.Sort(colItemsss1, ListSortDirection.Descending);
            MessageBox.Show("比对完成！");
        }
    }
}