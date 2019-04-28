using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGTech.QuanLyCoSoGietMo.Reports
{
    public partial class ThongKeKhachHangThuChiForm : Form
    {
        private DateTime _tuNgay;
        private DateTime _denNgay;
        private int _khachHangId;
        private string _hoTenKhachHang;

        public ThongKeKhachHangThuChiForm(int khachHangId, string hoTenKhachHang, DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            _tuNgay = tuNgay;
            _denNgay = denNgay;
            _khachHangId = khachHangId;
            _hoTenKhachHang = hoTenKhachHang;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thongKeChiTheoNgayTableAdapter.FillByKhachHang(ggTech.ThongKeChiTheoNgay, _tuNgay, _denNgay, _khachHangId);
            thongKeThuChiXeKhachHangTableAdapter.FillByKhachHang(ggTech.ThongKeThuChiXeKhachHang, _tuNgay.ToShortDateString(), _denNgay.ToShortDateString(), _khachHangId);
            ReportParameter[] rParameters = new ReportParameter[]{
                new ReportParameter("TuNgay", _tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", _denNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("HoTenKhachHang", _hoTenKhachHang)
            };
            ReportDataSource rChiDataSource = new ReportDataSource("DsTkKhachHangChiNgay", ggTech.Tables["ThongKeChiTheoNgay"]);
            ReportDataSource rThuDataSource = new ReportDataSource("DsTkKhachHangThuNgay", ggTech.Tables["ThongKeThuChiXeKhachHang"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rChiDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(rThuDataSource);
            this.reportViewer1.LocalReport.SetParameters(rParameters);
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.RefreshReport();
        }
    }
}
