using GGTech.QuanLyCoSoGietMo._1.Common;
using GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace GGTech.QuanLyCoSoGietMo.Reports
{
    public partial class ThongKeChoQuanLyForm : Form
    {
        private DateTime _tuNgay;
        private DateTime _denNgay;

        public ThongKeChoQuanLyForm(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            _tuNgay = tuNgay;
            _denNgay = denNgay;
        }

        private void ThongKeChoQuanLyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gGTech.KhachHangThuChiView' table. You can move, or remove it, as needed.
            this.khachHangThuChiViewTableAdapter.FillByNgayTongThu(this.gGTech.KhachHangThuChiView, _tuNgay, _denNgay);
            this.thongKeChiTheoNgayTableAdapter.FillByNgayChi(gGTech.ThongKeChiTheoNgay, AppCommon.AppSqlDate(_tuNgay), AppCommon.AppSqlDate(_denNgay));
            ReportParameter[] rParameters = new ReportParameter[]{
                new ReportParameter("TuNgay", _tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", _denNgay.ToString("dd/MM/yyyy"))
            };
            this.reportViewer1.LocalReport.SetParameters(rParameters);
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}
