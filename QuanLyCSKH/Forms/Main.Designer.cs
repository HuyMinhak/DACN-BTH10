namespace QuanLyCSKH.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            qaunrLýToolStripMenuItem = new ToolStripMenuItem();
            mnuPhanCongChamSoc = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            báoCáoThốngKếToolStripMenuItem = new ToolStripMenuItem();
            mnuThongKeSinhNhatKhachHang = new ToolStripMenuItem();
            mnuBaoCaoHoatDong = new ToolStripMenuItem();
            báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, qaunrLýToolStripMenuItem, báoCáoThốngKếToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(898, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(183, 26);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(183, 26);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(183, 26);
            mnuDoiMatKhau.Text = "Đổi mật khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(183, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // qaunrLýToolStripMenuItem
            // 
            qaunrLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuPhanCongChamSoc, mnuNhanVien, mnuKhachHang, mnuSanPham, mnuHoaDon });
            qaunrLýToolStripMenuItem.Name = "qaunrLýToolStripMenuItem";
            qaunrLýToolStripMenuItem.Size = new Size(73, 24);
            qaunrLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuPhanCongChamSoc
            // 
            mnuPhanCongChamSoc.Name = "mnuPhanCongChamSoc";
            mnuPhanCongChamSoc.Size = new Size(232, 26);
            mnuPhanCongChamSoc.Text = "Phâm công chăm sóc";
            mnuPhanCongChamSoc.Click += mnuPhanCongChamSoc_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(232, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(232, 26);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(232, 26);
            mnuSanPham.Text = "Sản phẩm";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(232, 26);
            mnuHoaDon.Text = "Hóa đơn";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // báoCáoThốngKếToolStripMenuItem
            // 
            báoCáoThốngKếToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSinhNhatKhachHang, mnuBaoCaoHoatDong, báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem });
            báoCáoThốngKếToolStripMenuItem.Name = "báoCáoThốngKếToolStripMenuItem";
            báoCáoThốngKếToolStripMenuItem.Size = new Size(139, 24);
            báoCáoThốngKếToolStripMenuItem.Text = "Báo cáo thống kế";
            báoCáoThốngKếToolStripMenuItem.Click += báoCáoThốngKếToolStripMenuItem_Click;
            // 
            // mnuThongKeSinhNhatKhachHang
            // 
            mnuThongKeSinhNhatKhachHang.Name = "mnuThongKeSinhNhatKhachHang";
            mnuThongKeSinhNhatKhachHang.Size = new Size(352, 26);
            mnuThongKeSinhNhatKhachHang.Text = "Thống kê sinh nhật khách hàng";
            mnuThongKeSinhNhatKhachHang.Click += mnuThongKeSinhNhatKhachHang_Click;
            // 
            // mnuBaoCaoHoatDong
            // 
            mnuBaoCaoHoatDong.Name = "mnuBaoCaoHoatDong";
            mnuBaoCaoHoatDong.Size = new Size(352, 26);
            mnuBaoCaoHoatDong.Text = "Báo cáo hoạt động";
            mnuBaoCaoHoatDong.Click += mnuBaoCaoHoatDong_Click;
            // 
            // báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem
            // 
            báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem.Name = "báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem";
            báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem.Size = new Size(352, 26);
            báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem.Text = "Báo cáo hiệu quả chăm sóc khách hàng";
            báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem.Click += báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(281, 26);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            mnuHuongDanSuDung.Click += mnuHuongDanSuDung_Click;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(281, 26);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm";
            mnuThongTinPhanMem.Click += mnuThongTinPhanMem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, toolStripStatusLabel3, lblLienKet });
            statusStrip1.Location = new Point(0, 494);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(898, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(125, 20);
            lblTrangThai.Text = "Chưa đăng nhập. ";
            lblTrangThai.Click += lblTrangThai_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(673, 20);
            toolStripStatusLabel3.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(85, 20);
            lblLienKet.Text = "© 2024 FIT ";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(898, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 520);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý chăm sóc khách hàng";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem qaunrLýToolStripMenuItem;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuPhanCongChamSoc;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem báoCáoThốngKếToolStripMenuItem;
        private ToolStripMenuItem mnuThongKeSinhNhatKhachHang;
        private ToolStripMenuItem mnuBaoCaoHoatDong;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblLienKet;
        private PictureBox pictureBox1;
        private ToolStripMenuItem báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem;
    }
}