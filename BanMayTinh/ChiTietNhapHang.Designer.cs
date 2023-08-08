
namespace BanMayTinh
{
    partial class ChiTietNhapHang
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
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.btnNhapCT = new System.Windows.Forms.Button();
            this.btnTimKiemCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnBoQuaCT = new System.Windows.Forms.Button();
            this.btnBaoCaoCT = new System.Windows.Forms.Button();
            this.grvCTNhapHang = new System.Windows.Forms.DataGridView();
            this.iMaHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuongNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblChiTietNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLybanMayTinhDataSet4 = new BanMayTinh.QuanLybanMayTinhDataSet4();
            this.tblChiTietNhapHangTableAdapter = new BanMayTinh.QuanLybanMayTinhDataSet4TableAdapters.tblChiTietNhapHangTableAdapter();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietNhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hoá Đơn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá Nhập  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Nhập :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chi Tiết Nhập Hàng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(191, 99);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(123, 20);
            this.txtMaHD.TabIndex = 5;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(191, 144);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(123, 20);
            this.txtGiaNhap.TabIndex = 6;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(445, 22);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(128, 20);
            this.txtMaHang.TabIndex = 7;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(445, 148);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(128, 20);
            this.txtSLNhap.TabIndex = 8;
            // 
            // btnNhapCT
            // 
            this.btnNhapCT.Enabled = false;
            this.btnNhapCT.Location = new System.Drawing.Point(51, 200);
            this.btnNhapCT.Name = "btnNhapCT";
            this.btnNhapCT.Size = new System.Drawing.Size(75, 23);
            this.btnNhapCT.TabIndex = 9;
            this.btnNhapCT.Text = "Nhập";
            this.btnNhapCT.UseVisualStyleBackColor = true;
            this.btnNhapCT.Click += new System.EventHandler(this.btnNhapCT_Click);
            // 
            // btnTimKiemCT
            // 
            this.btnTimKiemCT.Location = new System.Drawing.Point(146, 200);
            this.btnTimKiemCT.Name = "btnTimKiemCT";
            this.btnTimKiemCT.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemCT.TabIndex = 10;
            this.btnTimKiemCT.Text = "Tìm Kiếm ";
            this.btnTimKiemCT.UseVisualStyleBackColor = true;
            this.btnTimKiemCT.Click += new System.EventHandler(this.btnTimKiemCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(239, 200);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCT.TabIndex = 11;
            this.btnXoaCT.Text = "Xoá";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(332, 200);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCT.TabIndex = 12;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnBoQuaCT
            // 
            this.btnBoQuaCT.Location = new System.Drawing.Point(430, 200);
            this.btnBoQuaCT.Name = "btnBoQuaCT";
            this.btnBoQuaCT.Size = new System.Drawing.Size(75, 23);
            this.btnBoQuaCT.TabIndex = 13;
            this.btnBoQuaCT.Text = "Bỏ Qua";
            this.btnBoQuaCT.UseVisualStyleBackColor = true;
            this.btnBoQuaCT.Click += new System.EventHandler(this.btnBoQuaCT_Click);
            // 
            // btnBaoCaoCT
            // 
            this.btnBaoCaoCT.Location = new System.Drawing.Point(530, 200);
            this.btnBaoCaoCT.Name = "btnBaoCaoCT";
            this.btnBaoCaoCT.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCaoCT.TabIndex = 14;
            this.btnBaoCaoCT.Text = "Báo Cáo";
            this.btnBaoCaoCT.UseVisualStyleBackColor = true;
            this.btnBaoCaoCT.Click += new System.EventHandler(this.btnBaoCaoCT_Click_1);
            // 
            // grvCTNhapHang
            // 
            this.grvCTNhapHang.AutoGenerateColumns = false;
            this.grvCTNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCTNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaHDDataGridViewTextBoxColumn,
            this.sMaHangDataGridViewTextBoxColumn,
            this.fGiaNhapDataGridViewTextBoxColumn,
            this.iSoLuongNhapDataGridViewTextBoxColumn});
            this.grvCTNhapHang.DataSource = this.tblChiTietNhapHangBindingSource;
            this.grvCTNhapHang.Location = new System.Drawing.Point(0, 243);
            this.grvCTNhapHang.Name = "grvCTNhapHang";
            this.grvCTNhapHang.Size = new System.Drawing.Size(680, 144);
            this.grvCTNhapHang.TabIndex = 15;
            // 
            // iMaHDDataGridViewTextBoxColumn
            // 
            this.iMaHDDataGridViewTextBoxColumn.DataPropertyName = "iMaHD";
            this.iMaHDDataGridViewTextBoxColumn.HeaderText = "Mã Hoá Đơn";
            this.iMaHDDataGridViewTextBoxColumn.Name = "iMaHDDataGridViewTextBoxColumn";
            this.iMaHDDataGridViewTextBoxColumn.Width = 150;
            // 
            // sMaHangDataGridViewTextBoxColumn
            // 
            this.sMaHangDataGridViewTextBoxColumn.DataPropertyName = "sMaHang";
            this.sMaHangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.sMaHangDataGridViewTextBoxColumn.Name = "sMaHangDataGridViewTextBoxColumn";
            this.sMaHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // fGiaNhapDataGridViewTextBoxColumn
            // 
            this.fGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "fGiaNhap";
            this.fGiaNhapDataGridViewTextBoxColumn.HeaderText = "Giá Nhập";
            this.fGiaNhapDataGridViewTextBoxColumn.Name = "fGiaNhapDataGridViewTextBoxColumn";
            this.fGiaNhapDataGridViewTextBoxColumn.Width = 150;
            // 
            // iSoLuongNhapDataGridViewTextBoxColumn
            // 
            this.iSoLuongNhapDataGridViewTextBoxColumn.DataPropertyName = "iSoLuongNhap";
            this.iSoLuongNhapDataGridViewTextBoxColumn.HeaderText = "Số Lượng Nhập";
            this.iSoLuongNhapDataGridViewTextBoxColumn.Name = "iSoLuongNhapDataGridViewTextBoxColumn";
            this.iSoLuongNhapDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblChiTietNhapHangBindingSource
            // 
            this.tblChiTietNhapHangBindingSource.DataMember = "tblChiTietNhapHang";
            this.tblChiTietNhapHangBindingSource.DataSource = this.quanLybanMayTinhDataSet4;
            // 
            // quanLybanMayTinhDataSet4
            // 
            this.quanLybanMayTinhDataSet4.DataSetName = "QuanLybanMayTinhDataSet4";
            this.quanLybanMayTinhDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietNhapHangTableAdapter
            // 
            this.tblChiTietNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(445, 78);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 16;
            // 
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 388);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.grvCTNhapHang);
            this.Controls.Add(this.btnBaoCaoCT);
            this.Controls.Add(this.btnBoQuaCT);
            this.Controls.Add(this.btnSuaCT);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnTimKiemCT);
            this.Controls.Add(this.btnNhapCT);
            this.Controls.Add(this.txtSLNhap);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietNhapHang";
            this.Text = "ChiTietNhapHang";
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietNhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLybanMayTinhDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Button btnNhapCT;
        private System.Windows.Forms.Button btnTimKiemCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnBoQuaCT;
        private System.Windows.Forms.Button btnBaoCaoCT;
        private System.Windows.Forms.DataGridView grvCTNhapHang;
        private QuanLybanMayTinhDataSet4 quanLybanMayTinhDataSet4;
        private System.Windows.Forms.BindingSource tblChiTietNhapHangBindingSource;
        private QuanLybanMayTinhDataSet4TableAdapters.tblChiTietNhapHangTableAdapter tblChiTietNhapHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuongNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}