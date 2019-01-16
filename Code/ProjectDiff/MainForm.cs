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
                DataSet ds = ExcelHelperForCs.ImportFromExcel(ofdExcels.FileName, 1);
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
                DataSet ds = ExcelHelperForCs.ImportFromExcel(ofdExcels.FileName, 1);
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

        }
    }
}