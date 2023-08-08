
namespace BanMayTinh
{
    partial class MatHang
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
            this.TenHang = new System.Windows.Forms.Label();
            this.NCC = new System.Windows.Forms.Label();
            this.MaLoaiHang = new System.Windows.Forms.Label();
            this.MaHang = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.Label();
            this.DvTinh = new System.Windows.Forms.Label();
            this.Giaban = new System.Windows.Forms.Label();
            this.TGBaoHanh = new System.Windows.Forms.Label();
            this.DvBaoHanh = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDonViBaoHanh = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTGBaoHanh = new System.Windows.Forms.TextBox();
            this.grvMatHang = new System.Windows.Forms.DataGridView();
            this.tblMatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLybanMayTinhDataSet = new BanMayTinh.QuanLybanMayTinhDataSet();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnTimKiemMh = new System.Windows.Forms.Button();
            this.btnBoQuaMH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCaoMH = new System.Windows.Forms.Button();
            this.tblMatHangTableAdapter = new BanMayTinh.QuanLybanMayTinhDataSetTableAdapters.tblMatHangTableAdapter();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtTinh = new System.Windows.Forms.TextBox();
            this.sMaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDonViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTGBaoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDVBaoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TenHang
            // 
            this.TenHang.AutoSize = true;
            this.TenHang.Location = new System.Drawing.Point(78, 124);
            this.TenHang.Name = "TenHang";
            this.TenHang.Size = new System.Drawing.Size(61, 13);
            this.TenHang.TabIndex = 0;
            this.TenHang.Text = "Tên Hàng :";
            // 
            // NCC
            // 
            this.NCC.AutoSize = true;
            this.NCC.Location = new System.Drawing.Point(38, 176);
            this.NCC.Name = "NCC";
            this.NCC.Size = new System.Drawing.Size(101, 13);
            this.NCC.TabIndex = 1;
            this.NCC.Text = "Mã Nhà Cung Cấp :";
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.AutoSize = true;
            this.MaLoaiHang.Location = new System.Drawing.Point(273, 80);
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Size = new System.Drawing.Size(80, 13);
            this.MaLoaiHang.TabIndex = 2;
            this.MaLoaiHang.Text = "Mã Loại Hàng :";
            // 
            // MaHang
            // 
            this.MaHang.AutoSize = true;
            this.MaHang.Location = new System.Drawing.Point(81, 80);
            this.MaHang.Name = "MaHang";
            this.MaHang.Size = new System.Drawing.Size(57, 13);
            this.MaHang.TabIndex = 3;
            this.MaHang.Text = "Mã Hàng :";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Location = new System.Drawing.Point(293, 124);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(59, 13);
            this.SoLuong.TabIndex = 4;
            this.SoLuong.Text = "Số Lượng :";
            // 
            // DvTinh
            // 
            this.DvTinh.AutoSize = true;
            this.DvTinh.Location = new System.Drawing.Point(282, 176);
            this.DvTinh.Name = "DvTinh";
            this.DvTinh.Size = new System.Drawing.Size(71, 13);
            this.DvTinh.TabIndex = 5;
            this.DvTinh.Text = "Đơn Vị Tính :";
            // 
            // Giaban
            // 
            this.Giaban.AutoSize = true;
            this.Giaban.Location = new System.Drawing.Point(552, 80);
            this.Giaban.Name = "Giaban";
            this.Giaban.Size = new System.Drawing.Size(51, 13);
            this.Giaban.TabIndex = 6;
            this.Giaban.Text = "Giá Bán :";
            // 
            // TGBaoHanh
            // 
            this.TGBaoHanh.AutoSize = true;
            this.TGBaoHanh.Location = new System.Drawing.Point(493, 124);
            this.TGBaoHanh.Name = "TGBaoHanh";
            this.TGBaoHanh.Size = new System.Drawing.Size(110, 13);
            this.TGBaoHanh.TabIndex = 7;
            this.TGBaoHanh.Text = "Thời Gian Bảo Hành :";
            // 
            // DvBaoHanh
            // 
            this.DvBaoHanh.AutoSize = true;
            this.DvBaoHanh.Location = new System.Drawing.Point(507, 176);
            this.DvBaoHanh.Name = "DvBaoHanh";
            this.DvBaoHanh.Size = new System.Drawing.Size(96, 13);
            this.DvBaoHanh.TabIndex = 8;
            this.DvBaoHanh.Text = "Dơn Vị Bảo Hành :";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(144, 77);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaHang.TabIndex = 9;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(144, 121);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenHang.TabIndex = 10;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(145, 173);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(100, 20);
            this.txtNCC.TabIndex = 11;
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(359, 77);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiHang.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(358, 121);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 13;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(359, 173);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(100, 20);
            this.txtDonViTinh.TabIndex = 14;
            // 
            // txtDonViBaoHanh
            // 
            this.txtDonViBaoHanh.Location = new System.Drawing.Point(609, 173);
            this.txtDonViBaoHanh.Name = "txtDonViBaoHanh";
            this.txtDonViBaoHanh.Size = new System.Drawing.Size(100, 20);
            this.txtDonViBaoHanh.TabIndex = 15;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(609, 77);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 16;
            // 
            // txtTGBaoHanh
            // 
            this.txtTGBaoHanh.Location = new System.Drawing.Point(609, 121);
            this.txtTGBaoHanh.Name = "txtTGBaoHanh";
            this.txtTGBaoHanh.Size = new System.Drawing.Size(100, 20);
            this.txtTGBaoHanh.TabIndex = 17;
            // 
            // grvMatHang
            // 
            this.grvMatHang.AutoGenerateColumns = false;
            this.grvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHangDataGridViewTextBoxColumn,
            this.sTenHangDataGridViewTextBoxColumn,
            this.iMaNCCDataGridViewTextBoxColumn,
            this.sMaLoaiHangDataGridViewTextBoxColumn,
            this.iSoLuongDataGridViewTextBoxColumn,
            this.sDonViTinhDataGridViewTextBoxColumn,
            this.fGiaBanDataGridViewTextBoxColumn,
            this.fTGBaoHanhDataGridViewTextBoxColumn,
            this.sDVBaoHanhDataGridViewTextBoxColumn,
            this.sThanhTien});
            this.grvMatHang.DataSource = this.tblMatHangBindingSource;
            this.grvMatHang.Location = new System.Drawing.Point(1, 269);
            this.grvMatHang.Name = "grvMatHang";
            this.grvMatHang.Size = new System.Drawing.Size(1040, 165);
            this.grvMatHang.TabIndex = 18;
            this.grvMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvMatHang_CellContentClick);
            // 
            // tblMatHangBindingSource
            // 
            this.tblMatHangBindingSource.DataMember = "tblMatHang";
            this.tblMatHangBindingSource.DataSource = this.quanLybanMayTinhDataSet;
            // 
            // quanLybanMayTinhDataSet
            // 
            this.quanLybanMayTinhDataSet.DataSetName = "QuanLybanMayTinhDataSet";
            this.quanLybanMayTinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThemMH
            // 
            this.btnThemMH.Enabled = false;
            this.btnThemMH.Location = new System.Drawing.Point(144, 227);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(75, 23);
            this.btnThemMH.TabIndex = 19;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(253, 227);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaMH.TabIndex = 20;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Location = new System.Drawing.Point(359, 227);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaMH.TabIndex = 21;
            this.btnXoaMH.Text = "Xoá";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnTimKiemMh
            // 
            this.btnTimKiemMh.Location = new System.Drawing.Point(460, 227);
            this.btnTimKiemMh.Name = "btnTimKiemMh";
            this.btnTimKiemMh.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemMh.TabIndex = 22;
            this.btnTimKiemMh.Text = "Tìm Kiếm";
            this.btnTimKiemMh.UseVisualStyleBackColor = true;
            this.btnTimKiemMh.Click += new System.EventHandler(this.btnTimKiemMh_Click);
            // 
            // btnBoQuaMH
            // 
            this.btnBoQuaMH.Location = new System.Drawing.Point(555, 227);
            this.btnBoQuaMH.Name = "btnBoQuaMH";
            this.btnBoQuaMH.Size = new System.Drawing.Size(75, 23);
            this.btnBoQuaMH.TabIndex = 23;
            this.btnBoQuaMH.Text = "Bỏ Qua";
            this.btnBoQuaMH.UseVisualStyleBackColor = true;
            this.btnBoQuaMH.Click += new System.EventHandler(this.btnBoQuaMH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản Lý Mặt Hàng";
            // 
            // btnBaoCaoMH
            // 
            this.btnBaoCaoMH.Location = new System.Drawing.Point(649, 227);
            this.btnBaoCaoMH.Name = "btnBaoCaoMH";
            this.btnBaoCaoMH.Size = new System.Drawing.Size(60, 23);
            this.btnBaoCaoMH.TabIndex = 25;
            this.btnBaoCaoMH.Text = "Báo Cáo";
            this.btnBaoCaoMH.UseVisualStyleBackColor = true;
            this.btnBaoCaoMH.Click += new System.EventHandler(this.btnBaoCaoMH_Click);
            // 
            // tblMatHangTableAdapter
            // 
            this.tblMatHangTableAdapter.ClearBeforeFill = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(482, 42);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(96, 20);
            this.btnTinh.TabIndex = 26;
            this.btnTinh.Text = " Tổng Giá Bán";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtTinh
            // 
            this.txtTinh.Location = new System.Drawing.Point(584, 42);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(106, 20);
            this.txtTinh.TabIndex = 27;
            // 
            // sMaHangDataGridViewTextBoxColumn
            // 
            this.sMaHangDataGridViewTextBoxColumn.DataPropertyName = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.sMaHangDataGridViewTextBoxColumn.Name = "sMaHangDataGridViewTextBoxColumn";
            // 
            // sTenHangDataGridViewTextBoxColumn
            // 
            this.sTenHangDataGridViewTextBoxColumn.DataPropertyName = "sTenHang";
            this.sTenHangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.sTenHangDataGridViewTextBoxColumn.Name = "sTenHangDataGridViewTextBoxColumn";
            // 
            // iMaNCCDataGridViewTextBoxColumn
            // 
            this.iMaNCCDataGridViewTextBoxColumn.DataPropertyName = "iMaNCC";
            this.iMaNCCDataGridViewTextBoxColumn.HeaderText = "Nhà Cung Cấp";
            this.iMaNCCDataGridViewTextBoxColumn.Name = "iMaNCCDataGridViewTextBoxColumn";
            // 
            // sMaLoaiHangDataGridViewTextBoxColumn
            // 
            this.sMaLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "sMaLoaiHang";
            this.sMaLoaiHangDataGridViewTextBoxColumn.HeaderText = "Mã Loại Hàng";
            this.sMaLoaiHangDataGridViewTextBoxColumn.Name = "sMaLoaiHangDataGridViewTextBoxColumn";
            // 
            // iSoLuongDataGridViewTextBoxColumn
            // 
            this.iSoLuongDataGridViewTextBoxColumn.DataPropertyName = "iSoLuong";
            this.iSoLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.iSoLuongDataGridViewTextBoxColumn.Name = "iSoLuongDataGridViewTextBoxColumn";
            // 
            // sDonViTinhDataGridViewTextBoxColumn
            // 
            this.sDonViTinhDataGridViewTextBoxColumn.DataPropertyName = "sDonViTinh";
            this.sDonViTinhDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính";
            this.sDonViTinhDataGridViewTextBoxColumn.Name = "sDonViTinhDataGridViewTextBoxColumn";
            // 
            // fGiaBanDataGridViewTextBoxColumn
            // 
            this.fGiaBanDataGridViewTextBoxColumn.DataPropertyName = "fGiaBan";
            this.fGiaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.fGiaBanDataGridViewTextBoxColumn.Name = "fGiaBanDataGridViewTextBoxColumn";
            // 
            // fTGBaoHanhDataGridViewTextBoxColumn
            // 
            this.fTGBaoHanhDataGridViewTextBoxColumn.DataPropertyName = "fTGBaoHanh";
            this.fTGBaoHanhDataGridViewTextBoxColumn.HeaderText = "TG Bảo Hành";
            this.fTGBaoHanhDataGridViewTextBoxColumn.Name = "fTGBaoHanhDataGridViewTextBoxColumn";
            // 
            // sDVBaoHanhDataGridViewTextBoxColumn
            // 
            this.sDVBaoHanhDataGridViewTextBoxColumn.DataPropertyName = "sDVBaoHanh";
            this.sDVBaoHanhDataGridViewTextBoxColumn.HeaderText = "DV Bảo Hành";
            this.sDVBaoHanhDataGridViewTextBoxColumn.Name = "sDVBaoHanhDataGridViewTextBoxColumn";
            // 
            // sThanhTien
            // 
            this.sThanhTien.DataPropertyName = "sThanhTien";
            this.sThanhTien.HeaderText = "Thành Tiền";
            this.sThanhTien.Name = "sThanhTien";
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 435);
            this.Controls.Add(this.txtTinh);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnBaoCaoMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoQuaMH);
            this.Controls.Add(this.btnTimKiemMh);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnSuaMH);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.grvMatHang);
            this.Controls.Add(this.txtTGBaoHanh);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtDonViBaoHanh);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaLoaiHang);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.DvBaoHanh);
            this.Controls.Add(this.TGBaoHanh);
            this.Controls.Add(this.Giaban);
            this.Controls.Add(this.DvTinh);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.MaHang);
            this.Controls.Add(this.MaLoaiHang);
            this.Controls.Add(this.NCC);
            this.Controls.Add(this.TenHang);
            this.Name = "MatHang";
            this.Text = "Mã Hàng :";
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenHang;
        private System.Windows.Forms.Label NCC;
        private System.Windows.Forms.Label MaLoaiHang;
        private System.Windows.Forms.Label MaHang;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.Label DvTinh;
        private System.Windows.Forms.Label Giaban;
        private System.Windows.Forms.Label TGBaoHanh;
        private System.Windows.Forms.Label DvBaoHanh;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDonViBaoHanh;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTGBaoHanh;
        private System.Windows.Forms.DataGridView grvMatHang;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnTimKiemMh;
        private System.Windows.Forms.Button btnBoQuaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCaoMH;
        private QuanLybanMayTinhDataSet quanLybanMayTinhDataSet;
        private System.Windows.Forms.BindingSource tblMatHangBindingSource;
        private QuanLybanMayTinhDataSetTableAdapters.tblMatHangTableAdapter tblMatHangTableAdapter;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDonViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTGBaoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDVBaoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sThanhTien;
    }
}