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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Trả về kết quả OK để báo cho Form Main biết là người dùng đã bấm nút Đăng nhập
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Trả về kết quả Cancel để Form Main biết và tắt form
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            // Bắt sự kiện khi người dùng gõ xong mật khẩu và nhấn phím Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi thẳng sự kiện click của nút Đăng nhập
                btnDangNhap_Click(sender, e);
            }
        }
        

        private void chkHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }
    }
}