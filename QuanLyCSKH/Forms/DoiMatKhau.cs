using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCSKH.Forms
{
    public partial class DoiMatKhau : Form
    {
        public int NhanVienID { get; set; } = 1;
        string chuoiKetNoi = @"Data Source=LAPTOP-3VDNARNT;Initial Catalog=QLCSKH;Integrated Security=True;TrustServerCertificate=True";
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra mật khẩu mới có khớp không
            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới và Nhập lại mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. DÙNG ENTITY FRAMEWORK ĐỂ ĐỔI MẬT KHẨU
            try
            {
                using (var db = new QuanLyCSKH.Data.QLCSKHbContext())
                {
                    // Tìm nhân viên theo ID được Form Main truyền sang
                    var nv = db.NhanVien.Find(NhanVienID);

                    if (nv == null) return;

                    // Kiểm tra mật khẩu cũ
                    if (nv.MatKhau != txtMatKhauCu.Text)
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Gán mật khẩu mới và lưu xuống Database
                    nv.MatKhau = txtMatKhauMoi.Text;
                    db.SaveChanges(); // Lệnh này mới quyết định việc lưu nè chị

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đổi xong tự đóng Form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Tích vào thì bỏ ẩn (False), bỏ tích thì ẩn đi (True)
            bool isHide = !chkHienMatKhau.Checked;

            txtMatKhauCu.UseSystemPasswordChar = isHide;
            txtMatKhauMoi.UseSystemPasswordChar = isHide;
            txtXacNhan.UseSystemPasswordChar = isHide;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hỏi lại trước khi thoát cho chắc ăn
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy bỏ thao tác đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
