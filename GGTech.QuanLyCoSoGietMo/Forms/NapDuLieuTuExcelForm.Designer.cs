namespace GGTech.QuanLyCoSoGietMo.Forms
{
    partial class NapDuLieuTuExcelForm
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtonFunction = new System.Windows.Forms.Panel();
            this.lbMsgExcelToCSDL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayNhapDuLieu = new System.Windows.Forms.DateTimePicker();
            this.btnTimFile = new System.Windows.Forms.Button();
            this.txtDuongDanFileExcel = new System.Windows.Forms.TextBox();
            this.btnNapDanhMucTheoNgay = new System.Windows.Forms.Button();
            this.btnNapDuLieuTheoNgay = new System.Windows.Forms.Button();
            this.btnMoExcelTheoNgay = new System.Windows.Forms.Button();
            this.btnMoFileExcelMau = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panelTitle.SuspendLayout();
            this.panelButtonFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1005, 38);
            this.panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NẠP DỮ LIỆU TỪ EXCEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonFunction
            // 
            this.panelButtonFunction.BackColor = System.Drawing.SystemColors.Info;
            this.panelButtonFunction.Controls.Add(this.lbMsgExcelToCSDL);
            this.panelButtonFunction.Controls.Add(this.label3);
            this.panelButtonFunction.Controls.Add(this.dtpNgayNhapDuLieu);
            this.panelButtonFunction.Controls.Add(this.btnTimFile);
            this.panelButtonFunction.Controls.Add(this.txtDuongDanFileExcel);
            this.panelButtonFunction.Controls.Add(this.btnNapDanhMucTheoNgay);
            this.panelButtonFunction.Controls.Add(this.btnNapDuLieuTheoNgay);
            this.panelButtonFunction.Controls.Add(this.btnMoExcelTheoNgay);
            this.panelButtonFunction.Controls.Add(this.btnMoFileExcelMau);
            this.panelButtonFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonFunction.Location = new System.Drawing.Point(0, 38);
            this.panelButtonFunction.Name = "panelButtonFunction";
            this.panelButtonFunction.Size = new System.Drawing.Size(1005, 215);
            this.panelButtonFunction.TabIndex = 6;
            // 
            // lbMsgExcelToCSDL
            // 
            this.lbMsgExcelToCSDL.AutoSize = true;
            this.lbMsgExcelToCSDL.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgExcelToCSDL.Location = new System.Drawing.Point(385, 134);
            this.lbMsgExcelToCSDL.Name = "lbMsgExcelToCSDL";
            this.lbMsgExcelToCSDL.Size = new System.Drawing.Size(0, 25);
            this.lbMsgExcelToCSDL.TabIndex = 10;
            this.lbMsgExcelToCSDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày";
            // 
            // dtpNgayNhapDuLieu
            // 
            this.dtpNgayNhapDuLieu.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpNgayNhapDuLieu.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpNgayNhapDuLieu.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpNgayNhapDuLieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhapDuLieu.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpNgayNhapDuLieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhapDuLieu.Location = new System.Drawing.Point(110, 50);
            this.dtpNgayNhapDuLieu.Name = "dtpNgayNhapDuLieu";
            this.dtpNgayNhapDuLieu.Size = new System.Drawing.Size(269, 33);
            this.dtpNgayNhapDuLieu.TabIndex = 8;
            this.dtpNgayNhapDuLieu.TabStop = false;
            // 
            // btnTimFile
            // 
            this.btnTimFile.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimFile.Location = new System.Drawing.Point(12, 11);
            this.btnTimFile.Name = "btnTimFile";
            this.btnTimFile.Size = new System.Drawing.Size(92, 33);
            this.btnTimFile.TabIndex = 1;
            this.btnTimFile.Text = "Tìm file";
            this.btnTimFile.UseVisualStyleBackColor = true;
            this.btnTimFile.Click += new System.EventHandler(this.btnTimFile_Click);
            // 
            // txtDuongDanFileExcel
            // 
            this.txtDuongDanFileExcel.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDanFileExcel.Location = new System.Drawing.Point(110, 11);
            this.txtDuongDanFileExcel.Name = "txtDuongDanFileExcel";
            this.txtDuongDanFileExcel.Size = new System.Drawing.Size(269, 33);
            this.txtDuongDanFileExcel.TabIndex = 5;
            // 
            // btnNapDanhMucTheoNgay
            // 
            this.btnNapDanhMucTheoNgay.BackColor = System.Drawing.Color.Green;
            this.btnNapDanhMucTheoNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDanhMucTheoNgay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNapDanhMucTheoNgay.Location = new System.Drawing.Point(110, 169);
            this.btnNapDanhMucTheoNgay.Name = "btnNapDanhMucTheoNgay";
            this.btnNapDanhMucTheoNgay.Size = new System.Drawing.Size(269, 34);
            this.btnNapDanhMucTheoNgay.TabIndex = 2;
            this.btnNapDanhMucTheoNgay.Text = "Danh mục -> Excel";
            this.btnNapDanhMucTheoNgay.UseVisualStyleBackColor = false;
            this.btnNapDanhMucTheoNgay.Click += new System.EventHandler(this.btnNapDanhMucTheoNgay_Click);
            // 
            // btnNapDuLieuTheoNgay
            // 
            this.btnNapDuLieuTheoNgay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNapDuLieuTheoNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapDuLieuTheoNgay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNapDuLieuTheoNgay.Location = new System.Drawing.Point(110, 129);
            this.btnNapDuLieuTheoNgay.Name = "btnNapDuLieuTheoNgay";
            this.btnNapDuLieuTheoNgay.Size = new System.Drawing.Size(269, 34);
            this.btnNapDuLieuTheoNgay.TabIndex = 2;
            this.btnNapDuLieuTheoNgay.Text = "Excel -> CSDL";
            this.btnNapDuLieuTheoNgay.UseVisualStyleBackColor = false;
            this.btnNapDuLieuTheoNgay.Click += new System.EventHandler(this.btnNapDuLieuTheoNgay_Click);
            // 
            // btnMoExcelTheoNgay
            // 
            this.btnMoExcelTheoNgay.BackColor = System.Drawing.Color.Gold;
            this.btnMoExcelTheoNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoExcelTheoNgay.ForeColor = System.Drawing.Color.Red;
            this.btnMoExcelTheoNgay.Location = new System.Drawing.Point(110, 89);
            this.btnMoExcelTheoNgay.Name = "btnMoExcelTheoNgay";
            this.btnMoExcelTheoNgay.Size = new System.Drawing.Size(269, 34);
            this.btnMoExcelTheoNgay.TabIndex = 2;
            this.btnMoExcelTheoNgay.Text = "Mở Excel theo ngày";
            this.btnMoExcelTheoNgay.UseVisualStyleBackColor = false;
            this.btnMoExcelTheoNgay.Click += new System.EventHandler(this.btnMoExcelTheoNgay_Click);
            // 
            // btnMoFileExcelMau
            // 
            this.btnMoFileExcelMau.BackColor = System.Drawing.Color.Red;
            this.btnMoFileExcelMau.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFileExcelMau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMoFileExcelMau.Location = new System.Drawing.Point(385, 10);
            this.btnMoFileExcelMau.Name = "btnMoFileExcelMau";
            this.btnMoFileExcelMau.Size = new System.Drawing.Size(204, 33);
            this.btnMoFileExcelMau.TabIndex = 2;
            this.btnMoFileExcelMau.Text = "Mở Excel Mẫu";
            this.btnMoFileExcelMau.UseVisualStyleBackColor = false;
            this.btnMoFileExcelMau.Click += new System.EventHandler(this.btnMoFileExcelMau_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 253);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1005, 430);
            this.dgvData.TabIndex = 7;
            // 
            // NapDuLieuTuExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 683);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panelButtonFunction);
            this.Controls.Add(this.panelTitle);
            this.Name = "NapDuLieuTuExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nạp dữ liệu từ Excel";
            this.panelTitle.ResumeLayout(false);
            this.panelButtonFunction.ResumeLayout(false);
            this.panelButtonFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtonFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapDuLieu;
        private System.Windows.Forms.Button btnTimFile;
        private System.Windows.Forms.TextBox txtDuongDanFileExcel;
        private System.Windows.Forms.Button btnMoFileExcelMau;
        private System.Windows.Forms.Button btnMoExcelTheoNgay;
        private System.Windows.Forms.Button btnNapDanhMucTheoNgay;
        private System.Windows.Forms.Button btnNapDuLieuTheoNgay;
        private System.Windows.Forms.Label lbMsgExcelToCSDL;
        private System.Windows.Forms.DataGridView dgvData;
    }
}