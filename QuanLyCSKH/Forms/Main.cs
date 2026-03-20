using QuanLyCSKH.Data;
using QuanLyCSKH.Reports;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyCSKH.Forms
{
    public partial class Main : Form
    {
        // Khởi tạo ngữ cảnh Database
        QLCSKHbContext context = new QLCSKHbContext();

        // ĐỔI TÊN BIẾN (Thêm dấu _ để không trùng với tên Class Form)
        // Lưu ý: Tên Class vẫn giữ nguyên là SanPham, KhachHang...
        QuanLyCSKH.Forms.SanPham _sanPham = null;
        QuanLyCSKH.Forms.KhachHang _khachHang = null;
        QuanLyCSKH.Forms.NhanVien _nhanVien = null;
        QuanLyCSKH.Forms.HoaDon _hoaDon = null;
        QuanLyCSKH.Forms.PhanCongChamSoc _phanCongChamSoc = null;
        QuanLyCSKH.Forms.DangNhap _dangNhap = null;

        string hoVaTenNhanVien = "";
        int idNhanVienDangNhap = 0;

        public Main()
        {
            InitializeComponent();
            // this.Load += Main_Load;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // 1. Ép PictureBox không được chiếm chỗ và tàng hình đi
            pictureBox1.Dock = DockStyle.None;
            pictureBox1.Visible = false;

            ChuaDangNhap();
            ThucHienDangNhap();

            // 2. Tìm vùng MDI để dán ảnh nền vào
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    // Lấy ảnh từ chính cái PictureBox đang có
                    ctl.BackgroundImage = pictureBox1.Image;
                    ctl.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }
        private void ThucHienDangNhap()
        {
        LamLai:
            if (_dangNhap == null || _dangNhap.IsDisposed)
                _dangNhap = new QuanLyCSKH.Forms.DangNhap();

            if (_dangNhap.ShowDialog() == DialogResult.OK)
            {
                // Truy cập vào TextBox (Nhớ chỉnh Modifiers của TextBox sang Public ở bên Form DangNhap)
                string tenDangNhap = _dangNhap.txtTenDangNhap.Text;
                string matKhau = _dangNhap.txtMatKhau.Text;

                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (string.IsNullOrWhiteSpace(matKhau))
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nv = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                    if (nv == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        // --- ĐÃ SỬA LẠI ĐOẠN KIỂM TRA MẬT KHẨU Ở ĐÂY ---
                        bool matKhauHopLe = false;

                        // Kiểm tra xem mật khẩu trong CSDL có phải là dạng mã hóa BCrypt không
                        if (nv.MatKhau.StartsWith("$2a$") || nv.MatKhau.StartsWith("$2b$") || nv.MatKhau.StartsWith("$2y$"))
                        {
                            // Giải mã và kiểm tra
                            matKhauHopLe = BC.Verify(matKhau, nv.MatKhau);
                        }
                        else
                        {
                            // So sánh bình thường nếu mật khẩu chưa mã hóa (VD: "123456")
                            matKhauHopLe = (matKhau == nv.MatKhau);
                        }

                        if (matKhauHopLe)
                        {
                            hoVaTenNhanVien = nv.HoVaTen;
                            idNhanVienDangNhap = nv.ID;

                            if (nv.QuyenHan == true)
                                QuyenQuanLy();
                            else
                                QuyenNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                        // --- KẾT THÚC PHẦN SỬA ---
                    }
                }
            }
        }
        public void ChuaDangNhap()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuPhanCongChamSoc.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuThongKeSinhNhatKhachHang.Enabled = false;
            mnuBaoCaoHoatDong.Enabled = false;
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuPhanCongChamSoc.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;     // Quản lý được vào xem Nhân Viên
            mnuHoaDon.Enabled = true;
            mnuThongKeSinhNhatKhachHang.Enabled = true;
            mnuBaoCaoHoatDong.Enabled = true;



            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuPhanCongChamSoc.Enabled = false;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSinhNhatKhachHang.Enabled = true;
            mnuBaoCaoHoatDong.Enabled = true;

            mnuNhanVien.Enabled = false;

            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e) => ThucHienDangNhap();

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren) child.Close();
            ChuaDangNhap();
            context = new QuanLyCSKH.Data.QLCSKHbContext();
        }

        private void mnuThoat_Click(object sender, EventArgs e) => this.Close();

        private void mnuPhanCongChamSoc_Click(object sender, EventArgs e)
        {
            if (_phanCongChamSoc == null || _phanCongChamSoc.IsDisposed)
            {
                _phanCongChamSoc = new QuanLyCSKH.Forms.PhanCongChamSoc();
                _phanCongChamSoc.MdiParent = this;
                _phanCongChamSoc.Show();
                _phanCongChamSoc.WindowState = FormWindowState.Maximized;
            }
            else _phanCongChamSoc.Activate();
            _phanCongChamSoc.WindowState = FormWindowState.Maximized;
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (_nhanVien == null || _nhanVien.IsDisposed)
            {
                _nhanVien = new QuanLyCSKH.Forms.NhanVien();
                _nhanVien.MdiParent = this;
                _nhanVien.Show();

                _nhanVien.WindowState = FormWindowState.Maximized;
            }
            else _nhanVien.Activate();

            _nhanVien.WindowState = FormWindowState.Maximized;
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (_khachHang == null || _khachHang.IsDisposed)
            {
                _khachHang = new QuanLyCSKH.Forms.KhachHang();
                _khachHang.MdiParent = this;
                _khachHang.Show();
                _khachHang.WindowState = FormWindowState.Maximized;

            }
            else _khachHang.Activate();
            _khachHang.WindowState = FormWindowState.Maximized;

        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (_sanPham == null || _sanPham.IsDisposed)
            {
                _sanPham = new QuanLyCSKH.Forms.SanPham();
                _sanPham.MdiParent = this;
                _sanPham.Show();
                _sanPham.WindowState = FormWindowState.Maximized;

            }
            else _sanPham.Activate();
            _sanPham.WindowState = FormWindowState.Maximized;

        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (_hoaDon == null || _hoaDon.IsDisposed)
            {
                _hoaDon = new QuanLyCSKH.Forms.HoaDon();
                _hoaDon.MdiParent = this;
                _hoaDon.Show();
                _hoaDon.WindowState = FormWindowState.Maximized;

            }
            else _hoaDon.Activate();
            _hoaDon.WindowState = FormWindowState.Maximized;

        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", "https://fit.agu.edu.vn"));
        }

        // Các sự kiện menu trống
        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau();
            frm.NhanVienID = idNhanVienDangNhap;
            frm.ShowDialog();
        }
        private void mnuHuongDanSuDung_Click(object sender, EventArgs e) 
        {
            try
            {
                // Chị dán cái link copy từ GitHub vào đây
                string url = "https://huyminhak.github.io/HDSD-CSKH/";

                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Dòng này cực kỳ quan trọng để nó mở trình duyệt
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở web: " + ex.Message);
            }
        }
        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            try
            {
                // Chị thay "HuyMinhak" bằng tên GitHub của chị nha
                string url = "https://HuyMinhak.github.io/HDSD-CSKH/about.html";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void lblTrangThai_Click(object sender, EventArgs e) { }




        private void mnuThongKeSinhNhatKhachHang_Click(object sender, EventArgs e)
        {
            QuanLyCSKH.Reports.frmBaoCaoSinhNhat frmBaoCao = new QuanLyCSKH.Reports.frmBaoCaoSinhNhat();

            // Hiển thị báo cáo (Khóa màn hình chính lại cho đến khi xem xong)
            frmBaoCao.ShowDialog();
        }

        private void mnuBaoCaoHoatDong_Click(object sender, EventArgs e)
        {
            frmBaoCaoHoatDong frm = new frmBaoCaoHoatDong();
            frm.ShowDialog(); // Hiển thị Form báo cáo lên
        }

        private void báoCáoThốngKếToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoHiệuQuảChămSócKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gọi Form báo cáo hiệu quả chăm sóc (Nằm trong thư mục Reports)
            // Lưu ý: Chị nhớ kiểm tra lại tên Form xem có đúng là frmBaoCaoHieuQuaChamSoc không nha, nếu chị đặt tên khác thì sửa lại tên ở dòng dưới cho khớp.
            QuanLyCSKH.Reports.frmBaoCaoHieuQua frm = new QuanLyCSKH.Reports.frmBaoCaoHieuQua();

            // Hiển thị Form báo cáo lên
            frm.ShowDialog();
        }
    }
}