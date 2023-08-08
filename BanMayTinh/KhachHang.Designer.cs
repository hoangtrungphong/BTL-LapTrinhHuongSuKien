
namespace BanMayTinh
{
    partial class KhachHang
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
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDienThoaiKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.Nam = new System.Windows.Forms.Label();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.Nu = new System.Windows.Forms.Label();
            this.txtNgaySinhKH = new System.Windows.Forms.MaskedTextBox();
            this.grvKhachHang = new System.Windows.Forms.DataGridView();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLybanMayTinhDataSet2 = new BanMayTinh.QuanLybanMayTinhDataSet2();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBoQuaKH = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBaoCaoKH = new System.Windows.Forms.Button();
            this.tblKhachHangTableAdapter = new BanMayTinh.QuanLybanMayTinhDataSet2TableAdapters.tblKhachHangTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTuoi1 = new System.Windows.Forms.TextBox();
            this.txtTuoi2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sMaKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện Thoại :";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Location = new System.Drawing.Point(215, 167);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(57, 13);
            this.txtGioiTinh.TabIndex = 4;
            this.txtGioiTinh.Text = "Giới Tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Sinh :";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(185, 75);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(135, 20);
            this.txtMaKhachHang.TabIndex = 6;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(185, 126);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(135, 20);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // txtDienThoaiKH
            // 
            this.txtDienThoaiKH.Location = new System.Drawing.Point(447, 125);
            this.txtDienThoaiKH.Name = "txtDienThoaiKH";
            this.txtDienThoaiKH.Size = new System.Drawing.Size(114, 20);
            this.txtDienThoaiKH.TabIndex = 8;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(185, 192);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(376, 20);
            this.txtDiaChiKH.TabIndex = 9;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(278, 169);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(14, 13);
            this.rbNam.TabIndex = 10;
            this.rbNam.TabStop = true;
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(293, 169);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(29, 13);
            this.Nam.TabIndex = 11;
            this.Nam.Text = "Nam";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(330, 167);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(28, 17);
            this.rbNu.TabIndex = 12;
            this.rbNu.TabStop = true;
            this.rbNu.Text = " ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Location = new System.Drawing.Point(346, 169);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(21, 13);
            this.Nu.TabIndex = 13;
            this.Nu.Text = "Nữ";
            // 
            // txtNgaySinhKH
            // 
            this.txtNgaySinhKH.Location = new System.Drawing.Point(448, 74);
            this.txtNgaySinhKH.Mask = "00/00/0000";
            this.txtNgaySinhKH.Name = "txtNgaySinhKH";
            this.txtNgaySinhKH.Size = new System.Drawing.Size(113, 20);
            this.txtNgaySinhKH.TabIndex = 14;
            this.txtNgaySinhKH.ValidatingType = typeof(System.DateTime);
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.AutoGenerateColumns = false;
            this.grvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKHDataGridViewTextBoxColumn,
            this.sTenKHDataGridViewTextBoxColumn,
            this.sGioiTinhDataGridViewTextBoxColumn,
            this.dNgaySinhDataGridViewTextBoxColumn,
            this.sDiaChiDataGridViewTextBoxColumn,
            this.sSDTDataGridViewTextBoxColumn,
            this.Stuoi});
            this.grvKhachHang.DataSource = this.tblKhachHangBindingSource;
            this.grvKhachHang.Location = new System.Drawing.Point(1, 265);
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.Size = new System.Drawing.Size(843, 157);
            this.grvKhachHang.TabIndex = 15;
            this.grvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvKhachHang_CellContentClick);
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tblKhachHang";
            this.tblKhachHangBindingSource.DataSource = this.quanLybanMayTinhDataSet2;
            // 
            // quanLybanMayTinhDataSet2
            // 
            this.quanLybanMayTinhDataSet2.DataSetName = "QuanLybanMayTinhDataSet2";
            this.quanLybanMayTinhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Enabled = false;
            this.btnThemKH.Location = new System.Drawing.Point(125, 236);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(66, 23);
            this.btnThemKH.TabIndex = 16;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click_1);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(245, 234);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(65, 23);
            this.btnSuaKH.TabIndex = 17;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(353, 234);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(60, 23);
            this.btnXoaKH.TabIndex = 18;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(468, 235);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 23);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBoQuaKH
            // 
            this.btnBoQuaKH.Location = new System.Drawing.Point(587, 236);
            this.btnBoQuaKH.Name = "btnBoQuaKH";
            this.btnBoQuaKH.Size = new System.Drawing.Size(67, 23);
            this.btnBoQuaKH.TabIndex = 20;
            this.btnBoQuaKH.Text = "Bỏ Qua";
            this.btnBoQuaKH.UseVisualStyleBackColor = true;
            this.btnBoQuaKH.Click += new System.EventHandler(this.btnBoQuaKH_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quản Lý Khách Hàng";
            // 
            // btnBaoCaoKH
            // 
            this.btnBaoCaoKH.Location = new System.Drawing.Point(587, 192);
            this.btnBaoCaoKH.Name = "btnBaoCaoKH";
            this.btnBaoCaoKH.Size = new System.Drawing.Size(67, 23);
            this.btnBaoCaoKH.TabIndex = 22;
            this.btnBaoCaoKH.Text = "Báo Cáo";
            this.btnBaoCaoKH.UseVisualStyleBackColor = true;
            this.btnBaoCaoKH.Click += new System.EventHandler(this.btnBaoCaoKH_Click);
            // 
            // tblKhachHangTableAdapter
            // 
            this.tblKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Đến";
            // 
            // txtTuoi1
            // 
            this.txtTuoi1.Location = new System.Drawing.Point(426, 163);
            this.txtTuoi1.Name = "txtTuoi1";
            this.txtTuoi1.Size = new System.Drawing.Size(55, 20);
            this.txtTuoi1.TabIndex = 25;
            // 
            // txtTuoi2
            // 
            this.txtTuoi2.Location = new System.Drawing.Point(525, 164);
            this.txtTuoi2.Name = "txtTuoi2";
            this.txtTuoi2.Size = new System.Drawing.Size(70, 20);
            this.txtTuoi2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tuổi";
            // 
            // sMaKHDataGridViewTextBoxColumn
            // 
            this.sMaKHDataGridViewTextBoxColumn.DataPropertyName = "sMaKH";
            this.sMaKHDataGridViewTextBoxColumn.HeaderText = "Mã Khách Hàng";
            this.sMaKHDataGridViewTextBoxColumn.Name = "sMaKHDataGridViewTextBoxColumn";
            this.sMaKHDataGridViewTextBoxColumn.Width = 120;
            // 
            // sTenKHDataGridViewTextBoxColumn
            // 
            this.sTenKHDataGridViewTextBoxColumn.DataPropertyName = "sTenKH";
            this.sTenKHDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.sTenKHDataGridViewTextBoxColumn.Name = "sTenKHDataGridViewTextBoxColumn";
            this.sTenKHDataGridViewTextBoxColumn.Width = 120;
            // 
            // sGioiTinhDataGridViewTextBoxColumn
            // 
            this.sGioiTinhDataGridViewTextBoxColumn.DataPropertyName = "sGioiTinh";
            this.sGioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.sGioiTinhDataGridViewTextBoxColumn.Name = "sGioiTinhDataGridViewTextBoxColumn";
            // 
            // dNgaySinhDataGridViewTextBoxColumn
            // 
            this.dNgaySinhDataGridViewTextBoxColumn.DataPropertyName = "dNgaySinh";
            this.dNgaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.dNgaySinhDataGridViewTextBoxColumn.Name = "dNgaySinhDataGridViewTextBoxColumn";
            this.dNgaySinhDataGridViewTextBoxColumn.Width = 120;
            // 
            // sDiaChiDataGridViewTextBoxColumn
            // 
            this.sDiaChiDataGridViewTextBoxColumn.DataPropertyName = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.sDiaChiDataGridViewTextBoxColumn.Name = "sDiaChiDataGridViewTextBoxColumn";
            this.sDiaChiDataGridViewTextBoxColumn.Width = 120;
            // 
            // sSDTDataGridViewTextBoxColumn
            // 
            this.sSDTDataGridViewTextBoxColumn.DataPropertyName = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sSDTDataGridViewTextBoxColumn.Name = "sSDTDataGridViewTextBoxColumn";
            this.sSDTDataGridViewTextBoxColumn.Width = 120;
            // 
            // Stuoi
            // 
            this.Stuoi.DataPropertyName = "Stuoi";
            this.Stuoi.HeaderText = "Tuổi";
            this.Stuoi.Name = "Stuoi";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 425);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTuoi2);
            this.Controls.Add(this.txtTuoi1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBaoCaoKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBoQuaKH);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.grvKhachHang);
            this.Controls.Add(this.txtNgaySinhKH);
            this.Controls.Add(this.Nu);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtDienThoaiKH);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDienThoaiKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label Nu;
        private System.Windows.Forms.MaskedTextBox txtNgaySinhKH;
        private System.Windows.Forms.DataGridView grvKhachHang;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBoQuaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBaoCaoKH;
        private QuanLybanMayTinhDataSet2 quanLybanMayTinhDataSet2;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private QuanLybanMayTinhDataSet2TableAdapters.tblKhachHangTableAdapter tblKhachHangTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTuoi1;
        private System.Windows.Forms.TextBox txtTuoi2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stuoi;
    }
}