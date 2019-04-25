using ClosedXML.Excel;
using GGTech.QuanLyCoSoGietMo._1.Common;
using GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static GGTech.QuanLyCoSoGietMo._2.Dataset.GGTech;

namespace GGTech.QuanLyCoSoGietMo.Forms
{
    public partial class NapDuLieuTuExcelForm : Form
    {
        public DateTime NgayNhapDuLieu
        {
            get { return dtpNgayNhapDuLieu.Value; }
            set { dtpNgayNhapDuLieu.Value = value; }
        }

        private string ExcelFileName = "GGTech_Data_";
        private string ExcelTemplate = "GGTech_DataTemplate";
        private string ExcelDataFolder = "\\data\\";
        private string ExcelExt = ".xlsx";

        private string ExcelPath
        {
            get
            {
                return Application.StartupPath + ExcelDataFolder + NgayNhapDuLieu.Year + "\\" + NgayNhapDuLieu.Month + "\\" + ExcelFileName + " " + NgayNhapDuLieu.Day + " " + NgayNhapDuLieu.Month + " " + NgayNhapDuLieu.Year + ExcelExt;
            }
        }

        private string ExcelTemplatePath
        {
            get
            {
                return Application.StartupPath + ExcelDataFolder + ExcelTemplate + ExcelExt;
            }
        }

        public NapDuLieuTuExcelForm()
        {
            InitializeComponent();
        }

        private void btnTimFile_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                FileInfo file = new FileInfo(FD.FileName);
                txtDuongDanFileExcel.Text = file.DirectoryName;
            }
        }

        private void btnMoFileExcelMau_Click(object sender, EventArgs e)
        {
            AppCommon.FileOpen(ExcelTemplatePath);
        }

        private void btnMoExcelTheoNgay_Click(object sender, EventArgs e)
        {
            if (!AppCommon.FileExists(ExcelPath))
            {
                DialogResult dr = MessageBox.Show("File không tồn tại. Bạn có muốn tạo file mới không?",
                      "Quản lý đơn hàng", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        AppCommon.FolderCopyFile(ExcelTemplatePath, ExcelPath);
                        AppCommon.FileOpen(ExcelPath);
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                AppCommon.FileOpen(ExcelPath);
            }
        }

        private async void btnNapDuLieuTheoNgay_Click(object sender, EventArgs e)
        {
            if (!AppCommon.FileExists(ExcelPath))
            {
                DialogResult dr = MessageBox.Show("File không tồn tại. Bạn có muốn tạo file mới không?",
                      "Quản lý đơn hàng", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        AppCommon.FolderCopyFile(ExcelTemplatePath, ExcelPath);
                        AppCommon.FileOpen(ExcelPath);
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                int countRow = 0; // đếm dòng bị lỗi trong excel
                int countError = 0; // đếm lỗi

                using (var workbook = new XLWorkbook(ExcelPath))
                {
                    ThuChiTableAdapter thuChiTableAdapter = new ThuChiTableAdapter();
                    ThuChiDataTable tableThuChi = new ThuChiDataTable();
                    DataRow dr;
                    var workSheetThuChi = workbook.Worksheet("ThuChi");
                    var rows = workSheetThuChi.RangeUsed().RowsUsed().Skip(1); // Skip header row
                    foreach (var row in rows)
                    {
                        try
                        {
                            countRow++;
                            int _KhachHangId = AppCommon.AppIntergerParse(row.Cell("A").Value.ToString()); // KhachHangId
                            string _NoiDung = row.Cell("C").Value.ToString(); // NoiDung
                            string _ThuChi = row.Cell("D").Value.ToString(); // ThuChi
                            decimal _SoTien = AppCommon.AppDecimalParse(row.Cell("G").Value.ToString()); // SoTien
                            string _GhiChu = row.Cell("F").Value.ToString(); // GhiChu

                            if (_KhachHangId <= 0 ||
                                string.IsNullOrEmpty(_NoiDung) ||
                                _SoTien == 0 ||
                                _ThuChi.CompareTo("+") != 0 &&
                                _ThuChi.CompareTo("-") != 0)
                            {
                                row.Style.Fill.BackgroundColor = XLColor.Red;
                                row.Style.Font.FontColor = XLColor.White;
                                workbook.Save();
                                GGTechMsg.Instance.Red(lbMsgExcelToCSDL, String.Format("Lỗi nạp dữ liệu đến CSDL. Dòng thứ {0} Sheet [ThuChi]", countRow));
                                countError++; // lỗi tăng lên 1 đơn vị
                                AppCommon.FileOpen(ExcelTemplatePath);
                                break;
                            }
                            dr = tableThuChi.NewRow();
                            dr["KhachHangId"] = _KhachHangId;
                            dr["NoiDung"] = _NoiDung;
                            dr["ThuChi"] = _ThuChi;
                            dr["SoTien"] = _SoTien;
                            dr["GhiChu"] = _GhiChu;
                            dr["NgayChi"] = NgayNhapDuLieu;
                            dr["NgayTao"] = DateTime.Now;
                            dr["NgayCapNhat"] = DateTime.Now;
                            tableThuChi.Rows.Add(dr);
                        }
                        catch (Exception ex)
                        {
                            countError++; // lỗi tăng lên 1 đơn vị
                            GGTechMsg.Instance.Red(lbMsgExcelToCSDL, "Lỗi nạp dữ liệu đến CSDL.\n" + ex.ToString());
                            break;
                        }
                    }

                    if (countError > 0) return; // nếu có lỗi thì không chạy dòng code bên dưới
                    thuChiTableAdapter.sp_ThuChi_DeleteBy_NgayChi(DateTime.Parse(NgayNhapDuLieu.ToShortDateString()), DateTime.Parse(NgayNhapDuLieu.ToShortDateString() + " 11:59:59 PM"));
                    thuChiTableAdapter.Update(tableThuChi);
                    GGTechMsg.Instance.Green(lbMsgExcelToCSDL, "Cập nhật dữ liệu thành công");
                }
            }
        }

        private async void btnNapDanhMucTheoNgay_Click(object sender, EventArgs e)
        {
            KhachHangTableAdapter khachHangTableAdapter = new KhachHangTableAdapter();
            KhachHangDataTable khachHangTable = new KhachHangDataTable();
            khachHangTableAdapter.ClearBeforeFill = true;
            khachHangTableAdapter.Fill(khachHangTable);

            using (var workbook = new XLWorkbook(ExcelTemplatePath))
            {
                var workSheetKhachHang = workbook.Worksheet("KhachHang");
                int indexRowStart = 2;

                foreach (DataRow row in khachHangTable.Rows)
                {
                    workSheetKhachHang.Cell(String.Format("A{0}", indexRowStart)).Value = row["HoTen"];
                    workSheetKhachHang.Cell(String.Format("B{0}", indexRowStart)).Value = row["Id"];
                    indexRowStart++;
                }
                workbook.Save();
                AppCommon.FileOpen(ExcelTemplatePath);
            }
        }
    }
}