namespace GGTech.QuanLyCoSoGietMo.Reports
{
    partial class ThongKeKhachHangThuChiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongKeThuTheoNgayTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.ThongKeThuTheoNgayTableAdapter();
            this.thongKeChiTheoNgayTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.ThongKeChiTheoNgayTableAdapter();
            this.ggTech = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTech();
            this.thongKeThuChiXeKhachHangTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.ThongKeThuChiXeKhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ggTech)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GGTech.QuanLyCoSoGietMo.Reports.ThongKeKhachHangThuChi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 1011);
            this.reportViewer1.TabIndex = 0;
            // 
            // thongKeThuTheoNgayTableAdapter
            // 
            this.thongKeThuTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // thongKeChiTheoNgayTableAdapter
            // 
            this.thongKeChiTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // ggTech
            // 
            this.ggTech.DataSetName = "GGTech";
            this.ggTech.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeThuChiXeKhachHangTableAdapter
            // 
            this.thongKeThuChiXeKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeKhachHangThuChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 1011);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKeKhachHangThuChiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê theo Khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ggTech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _2.Dataset.GGTechTableAdapters.ThongKeThuTheoNgayTableAdapter thongKeThuTheoNgayTableAdapter;
        private _2.Dataset.GGTechTableAdapters.ThongKeChiTheoNgayTableAdapter thongKeChiTheoNgayTableAdapter;
        private _2.Dataset.GGTech ggTech;
        private _2.Dataset.GGTechTableAdapters.ThongKeThuChiXeKhachHangTableAdapter thongKeThuChiXeKhachHangTableAdapter;
    }
}