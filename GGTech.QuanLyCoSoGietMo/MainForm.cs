using GGTech.QuanLyCoSoGietMo._1.Common;
using GGTech.QuanLyCoSoGietMo.Forms;
using GGTech.QuanLyCoSoGietMo.Forms.DanhMuc;
using GGTech.QuanLyCoSoGietMo.Forms.QuanLyThuChi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGTech.QuanLyCoSoGietMo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nạpNhanhDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppCommon.AddFormToMdiParent(new NapDuLieuTuExcelForm(), this);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppCommon.AddFormToMdiParent(new KhachHangForm(), this);
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppCommon.AddFormToMdiParent(new ThongKeThuChiForm(), this);
        }
    }
}
