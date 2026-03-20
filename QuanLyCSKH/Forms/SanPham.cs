using ClosedXML.Excel;
using QuanLyCSKH.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace QuanLyCSKH.Forms
{
    public partial class SanPham : Form
    {
        // 1. Khởi tạo ngữ cảnh CSDL
        private QLCSKHbContext context = new QLCSKHbContext();
        private bool xuLyThem = false;
        private int id;
        string duongDanAnhTam = ""; // Dùng để lưu đường dẫn ảnh khi đang Thêm mới
        // Lưu ID sản phẩm đang chọn để Sửa/Xóa
        string imagesFolder = Path.Combine(Application.StartupPath, "Images"); public SanPham()
        {
            InitializeComponent();
        }


        // 2. Hàm điều khiển trạng thái các nút chức năng
        private void BatTatChucNang(bool giaTri)
        {
            // Các nút điều khiển khi đang nhập liệu
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            // Các ô nhập liệu
            cboTenSanPham.Enabled = giaTri;
            numDonGia.Enabled = giaTri;

            // Các nút chức năng chính (vô hiệu hóa khi đang thêm/sửa)
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTim.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            dgvSanPham.Enabled = !giaTri;
        }

        // 3. Load dữ liệu và thiết lập Binding

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Giả sử cột ảnh của bạn có Name hoặc DataPropertyName là "HinhAnh"
            if (dgvSanPham.Columns[e.ColumnIndex].DataPropertyName == "HinhAnh" && e.Value != null)
            {
                string fileName = e.Value.ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    string fullPath = Path.Combine(imagesFolder, fileName);
                    if (File.Exists(fullPath))
                    {
                        // Biến tên file thành hình ảnh thực tế để hiển thị vào ô
                        e.Value = Image.FromFile(fullPath);
                    }
                    else
                    {
                        e.Value = null; // Hoặc một ảnh "No Image" mặc định
                    }
                }
            }
        }
        // 4. Nút Thêm mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Xóa trắng dữ liệu nhập liệu
            cboTenSanPham.Text = string.Empty;
            numDonGia.Value = 0;
            cboTenSanPham.Focus();
        }

        // 5. Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID từ dòng đang chọn trong DataGridView
            id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["ID"].Value);
        }

        // 6. Nút Lưu (Thêm hoặc Cập nhật)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tenFileAnh = "";
                // Nếu người dùng có bấm "Đổi ảnh" và chọn file
                if (!string.IsNullOrEmpty(duongDanAnhTam))
                {
                    tenFileAnh = Path.GetFileName(duongDanAnhTam);
                    string pathLuu = Path.Combine(imagesFolder, tenFileAnh);

                    if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);
                    File.Copy(duongDanAnhTam, pathLuu, true);
                }

                if (xuLyThem)
                {
                    var spMoi = new QuanLyCSKH.Data.SanPham
                    {
                        TenSanPham = cboTenSanPham.Text.Trim(),
                        DonGia = (int)numDonGia.Value,
                        HinhAnh = tenFileAnh // Lưu tên file (vd: hoa.jpg)
                    };
                    context.SanPham.Add(spMoi);
                }
                else
                {
                    var spSua = context.SanPham.Find(id);
                    if (spSua != null)
                    {
                        spSua.TenSanPham = cboTenSanPham.Text.Trim();
                        spSua.DonGia = (int)numDonGia.Value;
                        if (!string.IsNullOrEmpty(tenFileAnh))
                            spSua.HinhAnh = tenFileAnh;
                    }
                }

                context.SaveChanges();
                duongDanAnhTam = ""; // Reset đường dẫn tạm
                MessageBox.Show("Lưu thành công!");
                SanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }        // 7. Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            string tenSP = dgvSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm '{tenSP}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["ID"].Value);
                    var spXoa = context.SanPham.Find(id);
                    if (spXoa != null)
                    {
                        context.SanPham.Remove(spXoa);
                        context.SaveChanges();
                        SanPham_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này (có thể đã có trong hóa đơn). Chi tiết: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 8. Tìm kiếm
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = cboTenSanPham.Text.Trim().ToLower();

            var ketQua = context.SanPham
                .Where(s => string.IsNullOrEmpty(tuKhoa) || s.TenSanPham.ToLower().Contains(tuKhoa))
                .Select(s => new { s.ID, s.TenSanPham, s.DonGia })
                .ToList();

            dgvSanPham.DataSource = ketQua;

            if (ketQua.Count == 0)
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 9. Xuất dữ liệu ra Excel
        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = $"SanPham_{DateTime.Now:yyyyMMdd}.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ID", typeof(int));
                        dt.Columns.Add("TenSanPham", typeof(string));
                        dt.Columns.Add("DonGia", typeof(int));

                        var data = context.SanPham.ToList();
                        foreach (var item in data)
                        {
                            dt.Rows.Add(item.ID, item.TenSanPham, item.DonGia);
                        }

                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add(dt, "DanhSachSanPham");
                            ws.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        // 10. Nhập dữ liệu từ Excel
        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            var worksheet = workbook.Worksheet(1);
                            var rows = worksheet.RowsUsed().Skip(1); // Bỏ qua dòng tiêu đề

                            foreach (var row in rows)
                            {
                                var sp = new QuanLyCSKH.Data.SanPham
                                {
                                    // Giả định: Cột 2 là Tên, Cột 3 là Đơn giá (Cột 1 là ID tự tăng nên bỏ qua)
                                    TenSanPham = row.Cell(2).GetValue<string>(),
                                    DonGia = row.Cell(3).GetValue<int>()
                                };
                                context.SanPham.Add(sp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Nhập dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SanPham_Load(sender, e);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi nhập file: " + ex.Message); }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => SanPham_Load(sender, e);
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        // Vì tệp Data/SanPham.cs của bạn đã xóa trường HinhAnh, nút này hiện không có tác dụng
        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // 1. Hiển thị ảnh lên PictureBox để người dùng xem trước
                picHinhAnh.ImageLocation = open.FileName;

                // 2. Lưu đường dẫn vào biến tạm
                duongDanAnhTam = open.FileName;
            }
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                // Lấy đường dẫn file từ cột HinhAnh của dòng đang chọn
                var path = dgvSanPham.CurrentRow.Cells["HinhAnh"].Value?.ToString();

                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    // Nếu file tồn tại thì nạp vào PictureBox
                    picHinhAnh.Image = Image.FromFile(path);
                }
                else
                {
                    // Nếu không có ảnh hoặc đường dẫn sai thì xóa ảnh cũ
                    picHinhAnh.Image = null;
                }
            }
        }


        private void SanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvSanPham.AutoGenerateColumns = false;

            // QUAN TRỌNG: Đăng ký sự kiện vẽ ảnh nếu bạn chưa làm trong Designer
            dgvSanPham.CellFormatting -= dgvSanPham_CellFormatting;
            dgvSanPham.CellFormatting += dgvSanPham_CellFormatting;

            var danhSachSP = context.SanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachSP;

            // Binding Text và Number
            cboTenSanPham.DataBindings.Clear();
            cboTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", true, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never);

            // Binding ảnh cho PictureBox (Khung xem bên trên)
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh", true);
            hinhAnhBinding.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrEmpty(ev.Value.ToString()))
                {
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnhBinding);

            dgvSanPham.DataSource = bindingSource;
        }
    }
}