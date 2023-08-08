
namespace BanMayTinh
{
    partial class ChiTietDatHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMucGiamGia = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtSLMua = new System.Windows.Forms.TextBox();
            this.txtTGBaoHanh = new System.Windows.Forms.MaskedTextBox();
            this.btnThemDH = new System.Windows.Forms.Button();
            this.btnSuaDH = new System.Windows.Forms.Button();
            this.btnXoaDH = new System.Windows.Forms.Button();
            this.btnTimKiemDH = new System.Windows.Forms.Button();
            this.btnBoQuaDH = new System.Windows.Forms.Button();
            this.btnBaoCaoDH = new System.Windows.Forms.Button();
            this.grvDatHang = new System.Windows.Forms.DataGridView();
            this.quanLybanMayTinhDataSet3 = new BanMayTinh.QuanLybanMayTinhDataSet3();
            this.tblChiTietDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblChiTietDatHangTableAdapter = new BanMayTinh.QuanLybanMayTinhDataSet3TableAdapters.tblChiTietDatHangTableAdapter();
            this.iMaHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuongMuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMucGiamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dThGHetBaoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietDatHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Đặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hoá Đơn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Bán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mức Giảm Giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Hàng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Lượng Mua :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời Gian Hết bảo Hành :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(187, 87);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(112, 20);
            this.txtMaHD.TabIndex = 7;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(187, 143);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(112, 20);
            this.txtGiaBan.TabIndex = 8;
            // 
            // txtMucGiamGia
            // 
            this.txtMucGiamGia.Location = new System.Drawing.Point(187, 196);
            this.txtMucGiamGia.Name = "txtMucGiamGia";
            this.txtMucGiamGia.Size = new System.Drawing.Size(112, 20);
            this.txtMucGiamGia.TabIndex = 9;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(514, 87);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(110, 20);
            this.txtMaHang.TabIndex = 10;
            // 
            // txtSLMua
            // 
            this.txtSLMua.Location = new System.Drawing.Point(514, 143);
            this.txtSLMua.Name = "txtSLMua";
            this.txtSLMua.Size = new System.Drawing.Size(110, 20);
            this.txtSLMua.TabIndex = 11;
            // 
            // txtTGBaoHanh
            // 
            this.txtTGBaoHanh.Location = new System.Drawing.Point(514, 196);
            this.txtTGBaoHanh.Mask = "00/00/0000";
            this.txtTGBaoHanh.Name = "txtTGBaoHanh";
            this.txtTGBaoHanh.Size = new System.Drawing.Size(110, 20);
            this.txtTGBaoHanh.TabIndex = 12;
            this.txtTGBaoHanh.ValidatingType = typeof(System.DateTime);
            // 
            // btnThemDH
            // 
            this.btnThemDH.Enabled = false;
            this.btnThemDH.Location = new System.Drawing.Point(86, 253);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(75, 23);
            this.btnThemDH.TabIndex = 13;
            this.btnThemDH.Text = "Thêm";
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // btnSuaDH
            // 
            this.btnSuaDH.Location = new System.Drawing.Point(187, 253);
            this.btnSuaDH.Name = "btnSuaDH";
            this.btnSuaDH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDH.TabIndex = 14;
            this.btnSuaDH.Text = "Sửa";
            this.btnSuaDH.UseVisualStyleBackColor = true;
            this.btnSuaDH.Click += new System.EventHandler(this.btnSuaDH_Click);
            // 
            // btnXoaDH
            // 
            this.btnXoaDH.Location = new System.Drawing.Point(294, 253);
            this.btnXoaDH.Name = "btnXoaDH";
            this.btnXoaDH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDH.TabIndex = 15;
            this.btnXoaDH.Text = "Xoá";
            this.btnXoaDH.UseVisualStyleBackColor = true;
            this.btnXoaDH.Click += new System.EventHandler(this.btnXoaDH_Click);
            // 
            // btnTimKiemDH
            // 
            this.btnTimKiemDH.Location = new System.Drawing.Point(389, 253);
            this.btnTimKiemDH.Name = "btnTimKiemDH";
            this.btnTimKiemDH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemDH.TabIndex = 16;
            this.btnTimKiemDH.Text = "Tìm Kiếm";
            this.btnTimKiemDH.UseVisualStyleBackColor = true;
            this.btnTimKiemDH.Click += new System.EventHandler(this.btnTimKiemDH_Click);
            // 
            // btnBoQuaDH
            // 
            this.btnBoQuaDH.Location = new System.Drawing.Point(494, 253);
            this.btnBoQuaDH.Name = "btnBoQuaDH";
            this.btnBoQuaDH.Size = new System.Drawing.Size(75, 23);
            this.btnBoQuaDH.TabIndex = 17;
            this.btnBoQuaDH.Text = "Bỏ Qua";
            this.btnBoQuaDH.UseVisualStyleBackColor = true;
            this.btnBoQuaDH.Click += new System.EventHandler(this.btnBoQuaDH_Click);
            // 
            // btnBaoCaoDH
            // 
            this.btnBaoCaoDH.Location = new System.Drawing.Point(587, 253);
            this.btnBaoCaoDH.Name = "btnBaoCaoDH";
            this.btnBaoCaoDH.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCaoDH.TabIndex = 18;
            this.btnBaoCaoDH.Text = "Báo Cáo";
            this.btnBaoCaoDH.UseVisualStyleBackColor = true;
            this.btnBaoCaoDH.Click += new System.EventHandler(this.btnBaoCaoDH_Click);
            // 
            // grvDatHang
            // 
            this.grvDatHang.AutoGenerateColumns = false;
            this.grvDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaHDDataGridViewTextBoxColumn,
            this.sMaHangDataGridViewTextBoxColumn,
            this.fGiaBanDataGridViewTextBoxColumn,
            this.iSoLuongMuaDataGridViewTextBoxColumn,
            this.fMucGiamGiaDataGridViewTextBoxColumn,
            this.dThGHetBaoHanhDataGridViewTextBoxColumn});
            this.grvDatHang.DataSource = this.tblChiTietDatHangBindingSource;
            this.grvDatHang.Location = new System.Drawing.Point(0, 291);
            this.grvDatHang.Name = "grvDatHang";
            this.grvDatHang.ShowCellToolTips = false;
            this.grvDatHang.Size = new System.Drawing.Size(799, 178);
            this.grvDatHang.TabIndex = 19;
            // 
            // quanLybanMayTinhDataSet3
            // 
            this.quanLybanMayTinhDataSet3.DataSetName = "QuanLybanMayTinhDataSet3";
            this.quanLybanMayTinhDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietDatHangBindingSource
            // 
            this.tblChiTietDatHangBindingSource.DataMember = "tblChiTietDatHang";
            this.tblChiTietDatHangBindingSource.DataSource = this.quanLybanMayTinhDataSet3;
            // 
            // tblChiTietDatHangTableAdapter
            // 
            this.tblChiTietDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // iMaHDDataGridViewTextBoxColumn
            // 
            this.iMaHDDataGridViewTextBoxColumn.DataPropertyName = "iMaHD";
            this.iMaHDDataGridViewTextBoxColumn.HeaderText = "Mã Hoá Đơn";
            this.iMaHDDataGridViewTextBoxColumn.Name = "iMaHDDataGridViewTextBoxColumn";
            this.iMaHDDataGridViewTextBoxColumn.Width = 120;
            // 
            // sMaHangDataGridViewTextBoxColumn
            // 
            this.sMaHangDataGridViewTextBoxColumn.DataPropertyName = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.sMaHangDataGridViewTextBoxColumn.Name = "sMaHangDataGridViewTextBoxColumn";
            this.sMaHangDataGridViewTextBoxColumn.Width = 120;
            // 
            // fGiaBanDataGridViewTextBoxColumn
            // 
            this.fGiaBanDataGridViewTextBoxColumn.DataPropertyName = "fGiaBan";
            this.fGiaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.fGiaBanDataGridViewTextBoxColumn.Name = "fGiaBanDataGridViewTextBoxColumn";
            this.fGiaBanDataGridViewTextBoxColumn.Width = 120;
            // 
            // iSoLuongMuaDataGridViewTextBoxColumn
            // 
            this.iSoLuongMuaDataGridViewTextBoxColumn.DataPropertyName = "iSoLuongMua";
            this.iSoLuongMuaDataGridViewTextBoxColumn.HeaderText = "Số Lượng Mua";
            this.iSoLuongMuaDataGridViewTextBoxColumn.Name = "iSoLuongMuaDataGridViewTextBoxColumn";
            // 
            // fMucGiamGiaDataGridViewTextBoxColumn
            // 
            this.fMucGiamGiaDataGridViewTextBoxColumn.DataPropertyName = "fMucGiamGia";
            this.fMucGiamGiaDataGridViewTextBoxColumn.HeaderText = "Mức giảm Giá";
            this.fMucGiamGiaDataGridViewTextBoxColumn.Name = "fMucGiamGiaDataGridViewTextBoxColumn";
            // 
            // dThGHetBaoHanhDataGridViewTextBoxColumn
            // 
            this.dThGHetBaoHanhDataGridViewTextBoxColumn.DataPropertyName = "dThGHetBaoHanh";
            this.dThGHetBaoHanhDataGridViewTextBoxColumn.HeaderText = "Tg Hết Bảo Hành";
            this.dThGHetBaoHanhDataGridViewTextBoxColumn.Name = "dThGHetBaoHanhDataGridViewTextBoxColumn";
            this.dThGHetBaoHanhDataGridViewTextBoxColumn.Width = 120;
            // 
            // ChiTietDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.grvDatHang);
            this.Controls.Add(this.btnBaoCaoDH);
            this.Controls.Add(this.btnBoQuaDH);
            this.Controls.Add(this.btnTimKiemDH);
            this.Controls.Add(this.btnXoaDH);
            this.Controls.Add(this.btnSuaDH);
            this.Controls.Add(this.btnThemDH);
            this.Controls.Add(this.txtTGBaoHanh);
            this.Controls.Add(this.txtSLMua);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtMucGiamGia);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietDatHang";
            this.Text = "ChiTietDathang";
            this.Load += new System.EventHandler(this.ChiTietDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietDatHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMucGiamGia;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtSLMua;
        private System.Windows.Forms.MaskedTextBox txtTGBaoHanh;
        private System.Windows.Forms.Button btnThemDH;
        private System.Windows.Forms.Button btnSuaDH;
        private System.Windows.Forms.Button btnXoaDH;
        private System.Windows.Forms.Button btnTimKiemDH;
        private System.Windows.Forms.Button btnBoQuaDH;
        private System.Windows.Forms.Button btnBaoCaoDH;
        private System.Windows.Forms.DataGridView grvDatHang;
        private QuanLybanMayTinhDataSet3 quanLybanMayTinhDataSet3;
        private System.Windows.Forms.BindingSource tblChiTietDatHangBindingSource;
        private QuanLybanMayTinhDataSet3TableAdapters.tblChiTietDatHangTableAdapter tblChiTietDatHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuongMuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMucGiamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dThGHetBaoHanhDataGridViewTextBoxColumn;
    }
}