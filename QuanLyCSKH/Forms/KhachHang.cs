using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyCSKH.Data; // Chứa QLCSKHbContext và Model KhachHang
using ClosedXML.Excel; // Dùng để Nhập/Xuất Excel

namespace QuanLyCSKH.Forms
{
    public partial class KhachHang : Form
    {
        // Khởi tạo CSDL (Dùng tên context đã sửa thành công ở bài trước)
        QLCSKHbContext context = new QLCSKHbContext();
        bool xuLyThem = false;
        int idKhachHang;

        public KhachHang()
        {
            InitializeComponent();
        }

        // Hàm bật/tắt các điều khiển
        private void BatTatChucNang(bool giaTri)
        {
            // Bật/tắt ô nhập liệu
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            dtNgaySinh.Enabled = giaTri;
            // Giả sử tên ComboBox là cboNhomKhachHang
            cboNhomKhachHang.Enabled = giaTri;

            // Bật/tắt nút bấm
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }



        private void XoaTrangO()
        {
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            dtNgaySinh.Value = DateTime.Now;
            cboNhomKhachHang.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            XoaTrangO();
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy dữ liệu từ Database đổ lên các ô nhập
            idKhachHang = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value);
            var kh = context.KhachHang.Find(idKhachHang);

            if (kh != null)
            {
                txtHoVaTen.Text = kh.HoVaTen;
                txtDienThoai.Text = kh.DienThoai;
                txtDiaChi.Text = kh.DiaChi;

                // Cần đảm bảo Model KhachHang có thuộc tính NgaySinh và NhomKhachHang
                if (kh.NgaySinh != null) dtNgaySinh.Value = kh.NgaySinh.Value;
                cboNhomKhachHang.Text = kh.NhomKhachHang;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                var kh = new Data.KhachHang
                {
                    HoVaTen = txtHoVaTen.Text,
                    DienThoai = txtDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    NgaySinh = dtNgaySinh.Value.Date,
                    NhomKhachHang = cboNhomKhachHang.Text
                };
                context.KhachHang.Add(kh);
            }
            else
            {
                var kh = context.KhachHang.Find(idKhachHang);
                if (kh != null)
                {
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.NgaySinh = dtNgaySinh.Value.Date;
                    kh.NhomKhachHang = cboNhomKhachHang.Text;
                }
            }

            context.SaveChanges();
            BatTatChucNang(false);
            LoadData();
            MessageBox.Show("Lưu dữ liệu thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa khách hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                idKhachHang = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value);
                var kh = context.KhachHang.Find(idKhachHang);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            XoaTrangO();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.ToLower();
            var result = context.KhachHang
                .Where(x => x.HoVaTen.ToLower().Contains(search) || x.DienThoai.Contains(search))
                .ToList();
            dgvKhachHang.DataSource = result;
        }

        // Chức năng Nhập Excel
        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook(ofd.FileName))
                        {
                            var worksheet = workbook.Worksheet(1);
                            var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                            int count = 0;
                            foreach (var row in rows)
                            {
                                var kh = new Data.KhachHang
                                {
                                    // Chú ý: Cột 2, 3, 4 tương ứng với vị trí trong file Excel mẫu
                                    HoVaTen = row.Cell(2).GetValue<string>(),
                                    DienThoai = row.Cell(3).GetValue<string>(),
                                    DiaChi = row.Cell(4).GetValue<string>(),
                                    NhomKhachHang = "Khách mới" // Nhóm mặc định
                                };
                                context.KhachHang.Add(kh);
                                count++;
                            }
                            context.SaveChanges();
                            LoadData();
                            MessageBox.Show($"Đã nhập thành công {count} dòng!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi nhập: " + ex.Message);
                    }
                }
            }
        }

        // Chức năng Xuất Excel
        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("KhachHang");
                // Tạo tiêu đề
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Họ và tên";
                worksheet.Cell(1, 3).Value = "Điện thoại";
                worksheet.Cell(1, 4).Value = "Địa chỉ";
                worksheet.Cell(1, 5).Value = "Ngày sinh";
                worksheet.Cell(1, 6).Value = "Nhóm khách hàng";

                var ds = context.KhachHang.ToList();
                for (int i = 0; i < ds.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = ds[i].ID;
                    worksheet.Cell(i + 2, 2).Value = ds[i].HoVaTen;
                    worksheet.Cell(i + 2, 3).Value = ds[i].DienThoai;
                    worksheet.Cell(i + 2, 4).Value = ds[i].DiaChi;
                    worksheet.Cell(i + 2, 5).Value = ds[i].NgaySinh?.ToString("dd/MM/yyyy");
                    worksheet.Cell(i + 2, 6).Value = ds[i].NhomKhachHang;
                }

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = "DanhSachKhachHang_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
            }
        }

        private void LoadData()
        {
            // Đổi thành true để nó tự tạo cột dựa trên Database
            dgvKhachHang.AutoGenerateColumns = true;
            dgvKhachHang.DataSource = context.KhachHang.ToList();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}