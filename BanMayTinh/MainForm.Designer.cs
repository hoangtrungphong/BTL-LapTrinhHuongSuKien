
namespace BanMayTinh
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLChiTiếtNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLChiTiếtĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLKháchHàngToolStripMenuItem,
            this.QLNhânViênToolStripMenuItem,
            this.QLMặtHàngToolStripMenuItem,
            this.QLChiTiếtNhậpHàngToolStripMenuItem,
            this.QLChiTiếtĐặtHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // QLKháchHàngToolStripMenuItem
            // 
            this.QLKháchHàngToolStripMenuItem.Name = "QLKháchHàngToolStripMenuItem";
            this.QLKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.QLKháchHàngToolStripMenuItem.Text = "Quản Lý Khách hàng";
            this.QLKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.QLKháchHàngToolStripMenuItem_Click);
            // 
            // QLNhânViênToolStripMenuItem
            // 
            this.QLNhânViênToolStripMenuItem.Name = "QLNhânViênToolStripMenuItem";
            this.QLNhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.QLNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.QLNhânViênToolStripMenuItem.Click += new System.EventHandler(this.QLNhânViênToolStripMenuItem_Click);
            // 
            // QLMặtHàngToolStripMenuItem
            // 
            this.QLMặtHàngToolStripMenuItem.Name = "QLMặtHàngToolStripMenuItem";
            this.QLMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.QLMặtHàngToolStripMenuItem.Text = "Quản Lý Mặt Hàng";
            this.QLMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.QLMặtHàngToolStripMenuItem_Click);
            // 
            // QLChiTiếtNhậpHàngToolStripMenuItem
            // 
            this.QLChiTiếtNhậpHàngToolStripMenuItem.Name = "QLChiTiếtNhậpHàngToolStripMenuItem";
            this.QLChiTiếtNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.QLChiTiếtNhậpHàngToolStripMenuItem.Text = "Quản Lý Chi Tiết Nhập Hàng";
            this.QLChiTiếtNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.QLChiTiếtNhậpHàngToolStripMenuItem_Click);
            // 
            // QLChiTiếtĐặtHàngToolStripMenuItem
            // 
            this.QLChiTiếtĐặtHàngToolStripMenuItem.Name = "QLChiTiếtĐặtHàngToolStripMenuItem";
            this.QLChiTiếtĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.QLChiTiếtĐặtHàngToolStripMenuItem.Text = "Quản Lý Chi Tiết Đặt Hàng";
            this.QLChiTiếtĐặtHàngToolStripMenuItem.Click += new System.EventHandler(this.QLChiTiếtĐặtHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanMayTinh.Properties.Resources.phan_mem_quan_ly;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLChiTiếtNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLChiTiếtĐặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}