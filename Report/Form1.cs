using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Report
{
    public partial class frmCrystalReport : Form
    {
        public frmCrystalReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt_KHOA;
        DataTable dt_SINHVIEN;
        private void frmCrystalReport_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection("Data Source=MASTERMIND-PC;Initial Catalog=QLSINHVIEN;Integrated Security=True");
            //
            da = new SqlDataAdapter("Select * From KHOA", cnn);
            dt_KHOA = new DataTable();
            da.Fill(dt_KHOA);
            //
            da.SelectCommand.CommandText = " Select Sv.*, K.MaKhoa, K.TenKhoa "
                                         + " From (SINHVIEN SV inner join LOP L on SV.MaLop = L.MaLop)"
                                         + " inner join KHOA K on L.MaKhoa = K.MaKhoa";
            dt_SINHVIEN = new DataTable();
            da.Fill(dt_SINHVIEN);
            //
            cb_MaKhoa.DataSource = dt_KHOA;
            cb_MaKhoa.DisplayMember = "TenKhoa";
            cb_MaKhoa.ValueMember = "MaKhoa";
            cb_MaKhoa.SelectedIndex = -1;
            //
            dt_SINHVIEN.DefaultView.RowFilter = "MaKhoa = '" + cb_MaKhoa.SelectedValue.ToString() + "'";
            rpt_DS_SV_KHOA rpt = new rpt_DS_SV_KHOA();
            rpt.SetDataSource(dt_SINHVIEN.DefaultView);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }


        private void bt_Xuat_Report_Click(object sender, EventArgs e)
        {
            dt_SINHVIEN.DefaultView.RowFilter = "MaKhoa = '" + cb_MaKhoa.SelectedValue.ToString() + "'";
            rpt_DS_SV_KHOA rpt = new rpt_DS_SV_KHOA();
            rpt.SetDataSource(dt_SINHVIEN.DefaultView);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
