using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                if (ds != null && ds.Tables.Count >= 1)
                {
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0] != null && dr[0].ToString().Equals("项目名称"))
                            {
                                continue;
                            }

                            dgvProjects.Rows.Add(dr.ItemArray);
                        }
                        break;
                    }
                }
            }
        }

        private void btnLoadWorkers_Click(object sender, EventArgs e)
        {
            if (ofdExcels.ShowDialog() == DialogResult.OK)
            {
                dgvWorkers.Rows.Clear();
                DataSet ds = ExcelHelper.ExcelToDataSet(ofdExcels.FileName);
                if (ds != null && ds.Tables.Count >= 1)
                {
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0] != null && dr[0].ToString().Equals("专家名称"))
                            {
                                continue;
                            }

                            dgvWorkers.Rows.Add(dr.ItemArray);
                        }

                        break;
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要这样吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvDiff.Rows.Clear();
                foreach (DataGridViewRow drWorker in dgvWorkers.Rows)
                {
                    string workerName = drWorker.Cells[0].Value.ToString();
                    string workerUnit = drWorker.Cells[1].Value.ToString();
                    foreach (DataGridViewRow drProject in dgvProjects.Rows)
                    {
                        string projectName = drProject.Cells[0].Value.ToString();
                        string projectUnit = drProject.Cells[2].Value.ToString();
                        string projectMaster = drProject.Cells[4].Value.ToString();
                        string projectWorker1 = drProject.Cells[5].Value.ToString();
                        string projectWorker2 = drProject.Cells[6].Value.ToString();
                        string projectWorker3 = drProject.Cells[7].Value.ToString();

                        List<string> cells = new List<string>();
                        if (projectMaster != null && workerName != null && projectMaster.Equals(workerName))
                        {
                            cells.Add(projectName);
                            cells.Add(workerName);
                            cells.Add("评审专家是责任导师");
                        }
                        else if (projectWorker1 != null && workerName != null && projectWorker1.Equals(workerName))
                        {
                            cells.Add(projectName);
                            cells.Add(workerName);
                            cells.Add("评审专家是推荐专家");
                        }
                        else if (projectWorker2 != null && workerName != null && projectWorker2.Equals(workerName))
                        {
                            cells.Add(projectName);
                            cells.Add(workerName);
                            cells.Add("评审专家是推荐专家");
                        }
                        else if (projectWorker3 != null && workerName != null && projectWorker3.Equals(workerName))
                        {
                            cells.Add(projectName);
                            cells.Add(workerName);
                            cells.Add("评审专家是推荐专家");
                        }
                        else if (projectUnit != null && workerUnit != null && projectUnit.Equals(workerUnit))
                        {
                            cells.Add(projectName);
                            cells.Add(workerName);
                            cells.Add("申请单位与评审专家单位相同");
                        }

                        if (cells.Count >= 1)
                        {
                            dgvDiff.Rows.Add(cells.ToArray());
                        }
                    }
                }
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
    }
}