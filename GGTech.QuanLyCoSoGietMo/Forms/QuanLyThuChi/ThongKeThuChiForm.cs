using GGTech.QuanLyCoSoGietMo._1.Common;
using System;
using System.Windows.Forms;

namespace GGTech.QuanLyCoSoGietMo.Forms.QuanLyThuChi
{
    public partial class ThongKeThuChiForm : Form
    {
        public ThongKeThuChiForm()
        {
            InitializeComponent();
        }

        private void ThongKeThuChiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gGTech.KhachHangThuChiView' table. You can move, or remove it, as needed.
            this.khachHangThuChiViewTableAdapter.FillByNgayThuChi(this.gGTech.KhachHangThuChiView, dtnThuChiTuNgay.Value, dtnThuChiDenNgay.Value);
            // TODO: This line of code loads data into the 'gGTech.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.gGTech.KhachHang);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.khachHangThuChiViewTableAdapter.FillByKhachHangNgayThuChi(this.gGTech.KhachHangThuChiView, dtnThuChiTuNgay.Value, dtnThuChiDenNgay.Value, AppCommon.AppIntergerParse(AppCommon.ComboBoxGetValueMember(cbbKhachHang).ToString()));
        }

        private void btnXuatQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}