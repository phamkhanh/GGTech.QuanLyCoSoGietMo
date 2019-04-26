namespace GGTech.QuanLyCoSoGietMo.Forms.QuanLyThuChi
{
    partial class ThongKeThuChiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtonFunction = new System.Windows.Forms.Panel();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gGTech = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTech();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtnThuChiTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtnThuChiDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXuatKhachHang = new System.Windows.Forms.Button();
            this.btnXuatQuanLy = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.khachHangTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.KhachHangTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHangId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangThuChiViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangThuChiViewTableAdapter = new GGTech.QuanLyCoSoGietMo._2.Dataset.GGTechTableAdapters.KhachHangThuChiViewTableAdapter();
            this.panelTitle.SuspendLayout();
            this.panelButtonFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangThuChiViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1241, 38);
            this.panelTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1241, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THU - CHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonFunction
            // 
            this.panelButtonFunction.BackColor = System.Drawing.SystemColors.Info;
            this.panelButtonFunction.Controls.Add(this.cbbKhachHang);
            this.panelButtonFunction.Controls.Add(this.label2);
            this.panelButtonFunction.Controls.Add(this.label4);
            this.panelButtonFunction.Controls.Add(this.label3);
            this.panelButtonFunction.Controls.Add(this.dtnThuChiTuNgay);
            this.panelButtonFunction.Controls.Add(this.dtnThuChiDenNgay);
            this.panelButtonFunction.Controls.Add(this.btnXuatKhachHang);
            this.panelButtonFunction.Controls.Add(this.btnXuatQuanLy);
            this.panelButtonFunction.Controls.Add(this.btnXem);
            this.panelButtonFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonFunction.Location = new System.Drawing.Point(0, 38);
            this.panelButtonFunction.Name = "panelButtonFunction";
            this.panelButtonFunction.Size = new System.Drawing.Size(352, 547);
            this.panelButtonFunction.TabIndex = 7;
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKhachHang.DataSource = this.khachHangBindingSource;
            this.cbbKhachHang.DisplayMember = "HoTen";
            this.cbbKhachHang.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(139, 11);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(193, 33);
            this.cbbKhachHang.TabIndex = 10;
            this.cbbKhachHang.ValueMember = "Id";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.gGTech;
            // 
            // gGTech
            // 
            this.gGTech.DataSetName = "GGTech";
            this.gGTech.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // dtnThuChiTuNgay
            // 
            this.dtnThuChiTuNgay.CalendarForeColor = System.Drawing.Color.Red;
            this.dtnThuChiTuNgay.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtnThuChiTuNgay.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtnThuChiTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtnThuChiTuNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtnThuChiTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtnThuChiTuNgay.Location = new System.Drawing.Point(139, 50);
            this.dtnThuChiTuNgay.Name = "dtnThuChiTuNgay";
            this.dtnThuChiTuNgay.Size = new System.Drawing.Size(193, 33);
            this.dtnThuChiTuNgay.TabIndex = 8;
            this.dtnThuChiTuNgay.TabStop = false;
            // 
            // dtnThuChiDenNgay
            // 
            this.dtnThuChiDenNgay.CalendarForeColor = System.Drawing.Color.Red;
            this.dtnThuChiDenNgay.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtnThuChiDenNgay.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtnThuChiDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtnThuChiDenNgay.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtnThuChiDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtnThuChiDenNgay.Location = new System.Drawing.Point(139, 89);
            this.dtnThuChiDenNgay.Name = "dtnThuChiDenNgay";
            this.dtnThuChiDenNgay.Size = new System.Drawing.Size(193, 33);
            this.dtnThuChiDenNgay.TabIndex = 8;
            this.dtnThuChiDenNgay.TabStop = false;
            // 
            // btnXuatKhachHang
            // 
            this.btnXuatKhachHang.BackColor = System.Drawing.Color.Salmon;
            this.btnXuatKhachHang.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnXuatKhachHang.Location = new System.Drawing.Point(17, 206);
            this.btnXuatKhachHang.Name = "btnXuatKhachHang";
            this.btnXuatKhachHang.Size = new System.Drawing.Size(315, 33);
            this.btnXuatKhachHang.TabIndex = 1;
            this.btnXuatKhachHang.Text = "Xuất phiếu theo khách hàng";
            this.btnXuatKhachHang.UseVisualStyleBackColor = false;
            this.btnXuatKhachHang.Click += new System.EventHandler(this.btnXuatKhachHang_Click);
            // 
            // btnXuatQuanLy
            // 
            this.btnXuatQuanLy.BackColor = System.Drawing.Color.Blue;
            this.btnXuatQuanLy.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatQuanLy.ForeColor = System.Drawing.Color.Transparent;
            this.btnXuatQuanLy.Location = new System.Drawing.Point(17, 167);
            this.btnXuatQuanLy.Name = "btnXuatQuanLy";
            this.btnXuatQuanLy.Size = new System.Drawing.Size(315, 33);
            this.btnXuatQuanLy.TabIndex = 1;
            this.btnXuatQuanLy.Text = "Xuất phiếu Tổng thu chi";
            this.btnXuatQuanLy.UseVisualStyleBackColor = false;
            this.btnXuatQuanLy.Click += new System.EventHandler(this.btnXuatQuanLy_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(139, 128);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(193, 33);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.KhachHangId,
            this.hoTenDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.thuChiDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.ngayChiDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.ngayCapNhatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachHangThuChiViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(352, 38);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(889, 547);
            this.dataGridView1.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // KhachHangId
            // 
            this.KhachHangId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.KhachHangId.DataPropertyName = "KhachHangId";
            this.KhachHangId.HeaderText = "KhachHangId";
            this.KhachHangId.Name = "KhachHangId";
            this.KhachHangId.ReadOnly = true;
            this.KhachHangId.Width = 5;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 105;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.Width = 126;
            // 
            // thuChiDataGridViewTextBoxColumn
            // 
            this.thuChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.thuChiDataGridViewTextBoxColumn.DataPropertyName = "ThuChi";
            this.thuChiDataGridViewTextBoxColumn.HeaderText = "ThuChi";
            this.thuChiDataGridViewTextBoxColumn.Name = "thuChiDataGridViewTextBoxColumn";
            this.thuChiDataGridViewTextBoxColumn.Width = 112;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.soTienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.soTienDataGridViewTextBoxColumn.HeaderText = "SoTien";
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.Width = 110;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 113;
            // 
            // ngayChiDataGridViewTextBoxColumn
            // 
            this.ngayChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ngayChiDataGridViewTextBoxColumn.DataPropertyName = "NgayChi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.ngayChiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ngayChiDataGridViewTextBoxColumn.HeaderText = "NgayChi";
            this.ngayChiDataGridViewTextBoxColumn.Name = "ngayChiDataGridViewTextBoxColumn";
            this.ngayChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.ngayTaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            // 
            // ngayCapNhatDataGridViewTextBoxColumn
            // 
            this.ngayCapNhatDataGridViewTextBoxColumn.DataPropertyName = "NgayCapNhat";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.ngayCapNhatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ngayCapNhatDataGridViewTextBoxColumn.HeaderText = "NgayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.Name = "ngayCapNhatDataGridViewTextBoxColumn";
            // 
            // khachHangThuChiViewBindingSource
            // 
            this.khachHangThuChiViewBindingSource.DataMember = "KhachHangThuChiView";
            this.khachHangThuChiViewBindingSource.DataSource = this.gGTech;
            // 
            // khachHangThuChiViewTableAdapter
            // 
            this.khachHangThuChiViewTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeThuChiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelButtonFunction);
            this.Controls.Add(this.panelTitle);
            this.Name = "ThongKeThuChiForm";
            this.Text = "THỐNG KÊ THU, CHI";
            this.Load += new System.EventHandler(this.ThongKeThuChiForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelButtonFunction.ResumeLayout(false);
            this.panelButtonFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangThuChiViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtonFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtnThuChiDenNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.Label label2;
        private _2.Dataset.GGTech gGTech;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private _2.Dataset.GGTechTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.Button btnXuatQuanLy;
        private System.Windows.Forms.Button btnXuatKhachHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource khachHangThuChiViewBindingSource;
        private _2.Dataset.GGTechTableAdapters.KhachHangThuChiViewTableAdapter khachHangThuChiViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtnThuChiTuNgay;
    }
}