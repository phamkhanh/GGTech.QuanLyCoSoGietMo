namespace GGTech.QuanLyCoSoGietMo.Reports
{
    partial class ThongKeChoQuanLyForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.khachHangThuChiViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gGTech = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTech();
            this.ThongKeChiTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.khachHangThuChiViewTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.KhachHangThuChiViewTableAdapter();
            this.thongKeChiTheoNgayTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.ThongKeChiTheoNgayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangThuChiViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeChiTheoNgayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // khachHangThuChiViewBindingSource
            // 
            this.khachHangThuChiViewBindingSource.DataMember = "KhachHangThuChiView";
            this.khachHangThuChiViewBindingSource.DataSource = this.gGTech;
            // 
            // gGTech
            // 
            this.gGTech.DataSetName = "GGTech";
            this.gGTech.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongKeChiTheoNgayBindingSource
            // 
            this.ThongKeChiTheoNgayBindingSource.DataMember = "ThongKeChiTheoNgay";
            this.ThongKeChiTheoNgayBindingSource.DataSource = this.gGTech;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetThongKeChoQuanLy";
            reportDataSource1.Value = this.khachHangThuChiViewBindingSource;
            reportDataSource2.Name = "DatasetChiTheoNgay";
            reportDataSource2.Value = this.ThongKeChiTheoNgayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GGTech.QuanLyCoSoGietMo.Reports.ThongKeChoQuanLy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 1011);
            this.reportViewer1.TabIndex = 0;
            // 
            // khachHangThuChiViewTableAdapter
            // 
            this.khachHangThuChiViewTableAdapter.ClearBeforeFill = true;
            // 
            // thongKeChiTheoNgayTableAdapter
            // 
            this.thongKeChiTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeChoQuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 1011);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKeChoQuanLyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tổng Thu, Chi";
            this.Load += new System.EventHandler(this.ThongKeChoQuanLyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangThuChiViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeChiTheoNgayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _2.Dataset.GGTech gGTech;
        private System.Windows.Forms.BindingSource khachHangThuChiViewBindingSource;
        private _2.Dataset.GGTechTableAdapters.KhachHangThuChiViewTableAdapter khachHangThuChiViewTableAdapter;
        private System.Windows.Forms.BindingSource ThongKeChiTheoNgayBindingSource;
        private _2.Dataset.GGTechTableAdapters.ThongKeChiTheoNgayTableAdapter thongKeChiTheoNgayTableAdapter;
    }
}