using ClosedXML.Excel;
using QuanLyCSKH.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace QuanLyCSKH.Forms
{
    public partial class HoaDon : Form
    {
        QLCSKHbContext context = new QLCSKHbContext();

        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadData()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            // Load lại context để cập nhật dữ liệu mới nhất từ DB
            context = new QLCSKHbContext();

            var danhSachHoaDon = context.HoaDon.Select(r => new
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                KhachHangID = r.KhachHangID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                // Tính tổng tiền từ bảng chi tiết
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (double?)ct.SoLuongBan * (double?)ct.DonGiaBan) ?? 0,
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dgvHoaDon.DataSource = danhSachHoaDon;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            int idSelected = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value);

            using (HoaDon_ChiTiet f = new HoaDon_ChiTiet(idSelected))
            {
                f.ShowDialog();
            }
            LoadData();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (HoaDon_ChiTiet f = new HoaDon_ChiTiet(0))
            {
                f.ShowDialog();
            }
            LoadData();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "Chi tiết" || dgvHoaDon.Columns[e.ColumnIndex].HeaderText == "Chi tiết")
            {
                int idSelected = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["ID"].Value);

                using (HoaDon_ChiTiet f = new HoaDon_ChiTiet(idSelected))
                {
                    f.ShowDialog();
                }

                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này và tất cả chi tiết của nó?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idXoa = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value);
                var hd = context.HoaDon.Find(idXoa);

                if (hd != null)
                {
                    var chiTiets = context.HoaDon_ChiTiet.Where(x => x.HoaDonID == idXoa);
                    context.HoaDon_ChiTiet.RemoveRange(chiTiets);

                    context.HoaDon.Remove(hd);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa hóa đơn thành công!");
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower().Trim();
            var ketQua = context.HoaDon.Select(r => new
            {
                ID = r.ID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (double?)ct.SoLuongBan * (double?)ct.DonGiaBan) ?? 0,
                XemChiTiet = "Xem chi tiết"
            }).Where(x => x.HoVaTenNhanVien.ToLower().Contains(keyword)
                        || x.HoVaTenKhachHang.ToLower().Contains(keyword)
                        || x.ID.ToString() == keyword).ToList();

            dgvHoaDon.DataSource = ketQua;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            var worksheet = workbook.Worksheet(1); // Lấy sheet đầu tiên
                            var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Bỏ qua dòng tiêu đề

                            int count = 0;
                            foreach (var row in rows)
                            {
                                
                                int idNhanVien;
                                int idKhachHang;
                                DateTime ngayLap;

                                bool parseNV = int.TryParse(row.Cell(1).Value.ToString(), out idNhanVien);
                                bool parseKH = int.TryParse(row.Cell(2).Value.ToString(), out idKhachHang);
                                bool parseNgay = DateTime.TryParse(row.Cell(3).Value.ToString(), out ngayLap);

                                if (parseNV && parseKH)
                                {
                                    var hdMoi = new QuanLyCSKH.Data.HoaDon()
                                    {
                                        NhanVienID = idNhanVien,
                                        KhachHangID = idKhachHang,
                                        NgayLap = parseNgay ? ngayLap : DateTime.Now
                                    };
                                    context.HoaDon.Add(hdMoi);
                                    count++;
                                }
                            }

                            context.SaveChanges(); // Lưu tất cả vào Database
                            LoadData(); // Tải lại bảng

                            MessageBox.Show($"Đã nhập thành công {count} hóa đơn mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi đọc file Excel. Vui lòng kiểm tra lại định dạng file! \nChi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trong bảng để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHoaDon = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value);

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = $"HoaDon_{idHoaDon}.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("Biên Lai");

                            // Lấy dữ liệu hóa đơn từ DB (Đã sửa lại để lấy đầy đủ Tên)
                            var hd = context.HoaDon
                                            .Include(h => h.KhachHang)
                                            .Include(h => h.NhanVien)
                                            .FirstOrDefault(h => h.ID == idHoaDon);

                            var chiTietList = context.HoaDon_ChiTiet
                                                     .Include(ct => ct.SanPham)
                                                     .Where(x => x.HoaDonID == idHoaDon)
                                                     .ToList();

                            // Ghi Header Biên lai
                            ws.Cell("A1").Value = "CỬA HÀNG ABC";
                            ws.Cell("A1").Style.Font.Bold = true;
                            ws.Cell("A2").Value = $"Mã Hóa Đơn: {hd.ID}";
                            ws.Cell("A3").Value = $"Ngày lập: {hd.NgayLap.ToString("dd/MM/yyyy HH:mm")}";
                            ws.Cell("A4").Value = $"Khách hàng: {hd.KhachHang?.HoVaTen}";
                            ws.Cell("A5").Value = $"Nhân viên: {hd.NhanVien?.HoVaTen}";

                            // Ghi tiêu đề bảng chi tiết
                            ws.Cell("A7").Value = "Tên Sản Phẩm";
                            ws.Cell("B7").Value = "Số Lượng";
                            ws.Cell("C7").Value = "Đơn Giá";
                            ws.Cell("D7").Value = "Thành Tiền";
                            ws.Range("A7:D7").Style.Font.Bold = true;
                            ws.Range("A7:D7").Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                            // Ghi dữ liệu chi tiết
                            int row = 8;
                            double tongTien = 0;
                            foreach (var ct in chiTietList)
                            {
                                ws.Cell(row, 1).Value = ct.SanPham?.TenSanPham; // Đã lấy được tên sản phẩm
                                ws.Cell(row, 2).Value = ct.SoLuongBan;
                                ws.Cell(row, 3).Value = ct.DonGiaBan;

                                double thanhTien = (double)(ct.SoLuongBan * ct.DonGiaBan);
                                ws.Cell(row, 4).Value = thanhTien;
                                tongTien += thanhTien;
                                row++;
                            }

                            // Ghi tổng tiền
                            ws.Cell(row + 1, 3).Value = "TỔNG CỘNG:";
                            ws.Cell(row + 1, 3).Style.Font.Bold = true;
                            ws.Cell(row + 1, 4).Value = tongTien;
                            ws.Cell(row + 1, 4).Style.Font.Bold = true;

                            ws.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);

                            MessageBox.Show("Đã xuất biên lai thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tự động mở file Excel vừa tạo
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi in: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở hộp thoại chọn nơi lưu file
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "DanhSachHoaDon.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Hóa Đơn");

                            // 1. Tạo dòng Tiêu đề (Header) từ DataGridView
                            for (int i = 0; i < dgvHoaDon.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgvHoaDon.Columns[i].HeaderText;
                                worksheet.Cell(1, i + 1).Style.Font.Bold = true; // In đậm tiêu đề
                                worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                            }

                            // 2. Đổ dữ liệu từ các dòng vào Excel
                            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvHoaDon.Columns.Count; j++)
                                {
                                    // Tránh lỗi null data
                                    worksheet.Cell(i + 2, j + 1).Value = dgvHoaDon.Rows[i].Cells[j].Value?.ToString() ?? "";
                                }
                            }

                            // Căn chỉnh tự động độ rộng cột cho đẹp
                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất file Excel thành công rực rỡ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file (Nhớ tắt file Excel nếu đang mở): \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}