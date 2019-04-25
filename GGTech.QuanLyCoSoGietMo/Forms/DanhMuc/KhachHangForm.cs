using GGTech.QuanLyCoSoGietMo._1.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGTech.QuanLyCoSoGietMo.Forms.DanhMuc
{
    public partial class KhachHangForm : Form
    {
        public KhachHangForm()
        {
            InitializeComponent();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gGTech.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.gGTech.KhachHang);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Update(gGTech.KhachHang);
            GGTechMsg.Instance.Green(lbMsg, "Lưu dữ liệu thành công.");
            this.khachHangTableAdapter.Fill(this.gGTech.KhachHang);
        }
    }
}
