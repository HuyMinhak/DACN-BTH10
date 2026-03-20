using ClosedXML.Excel;
using QuanLyCSKH.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; 

namespace QuanLyCSKH.Forms
{
    public partial class HoaDon_ChiTiet : Form
    {
        QLCSKHbContext context = new QLCSKHbContext();
        int id;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        BindingSource bsHoaDon = new BindingSource();

        public HoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;

            // Đảm bảo Form_Load chỉ chạy 1 lần
            this.Load -= HoaDon_ChiTiet_Load;
            this.Load += HoaDon_ChiTiet_Load;
        }

        public void LayNhanVienVaoComboBox()
        {
            var dsNhanVien = context.NhanVien.ToList();
            if (!dsNhanVien.Any()) MessageBox.Show("Bảng Nhân Viên trong Database đang trống!", "Gợi ý");

            cboNhanVien.DataSource = dsNhanVien;
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            var dsKhachHang = context.KhachHang.ToList();
            if (!dsKhachHang.Any()) MessageBox.Show("Bảng Khách Hàng trong Database đang trống!", "Gợi ý");

            cboKhachHang.DataSource = dsKhachHang;
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LaySanPhamVaoComboBox()
        {
            var dsSanPham = context.SanPham.ToList();
            if (!dsSanPham.Any()) MessageBox.Show("Bảng Sản Phẩm trong Database đang trống!", "Gợi ý");

            cboSanPham.DataSource = dsSanPham;
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }

        public void BatTatChucNang()
        {
            btnLuuHoaDon.Enabled = dgvHoaDon_ChiTiet.Rows.Count > 0;
            btnXoa.Enabled = dgvHoaDon_ChiTiet.Rows.Count > 0;
        }

        private void HoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Load dữ liệu vào các ComboBox trước
                LayNhanVienVaoComboBox();
                LayKhachHangVaoComboBox();
                LaySanPhamVaoComboBox();

                // 2. Cấu hình DataGridView (Chỉ Clear nếu chị muốn tạo cột bằng code)
                dgvHoaDon_ChiTiet.AutoGenerateColumns = false;
                dgvHoaDon_ChiTiet.Columns.Clear();
                dgvHoaDon_ChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSanPham", DataPropertyName = "TenSanPham", HeaderText = "Tên Sản Phẩm", Width = 150 });
                dgvHoaDon_ChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuongBan", DataPropertyName = "SoLuongBan", HeaderText = "Số Lượng", Width = 80 });
                dgvHoaDon_ChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "DonGiaBan", DataPropertyName = "DonGiaBan", HeaderText = "Đơn Giá", Width = 100 });
                dgvHoaDon_ChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "ThanhTien", DataPropertyName = "ThanhTien", HeaderText = "Thành Tiền", Width = 120 });
                dgvHoaDon_ChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "SanPhamID", DataPropertyName = "SanPhamID", Visible = false });

                // 3. Xóa dữ liệu cũ trong danh sách tạm
                hoaDonChiTiet.Clear();

                if (id == 0)
                {
                    this.Text = "LẬP HÓA ĐƠN MỚI";
                    // Thiết lập giá trị mặc định cho hóa đơn mới
                    if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;
                    if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
                }
                else
                {
                    this.Text = "CHI TIẾT HÓA ĐƠN SỐ " + id;

                    // Tìm thông tin hóa đơn tổng quát (Khách hàng, Nhân viên, Ghi chú)
                    var hdGoc = context.HoaDon.FirstOrDefault(x => x.ID == id);
                    if (hdGoc != null)
                    {
                        cboNhanVien.SelectedValue = hdGoc.NhanVienID;
                        cboKhachHang.SelectedValue = hdGoc.KhachHangID;
                        textBox1.Text = hdGoc.GhiChuHoaDon;

                        // QUAN TRỌNG: Lấy dữ liệu sản phẩm từ CSDL nạp vào hoaDonChiTiet
                        var dsSanPhamCuaHoaDon = context.HoaDon_ChiTiet
                            .Where(x => x.HoaDonID == id)
                            .Select(x => new DanhSachHoaDon_ChiTiet
                            {
                                ID = x.ID,
                                HoaDonID = (int)x.HoaDonID,
                                SanPhamID = (int)x.SanPhamID,
                                TenSanPham = x.SanPham.TenSanPham,
                                SoLuongBan = (int)x.SoLuongBan,
                                DonGiaBan = (int)x.DonGiaBan,
                                ThanhTien = (int)(x.SoLuongBan * x.DonGiaBan)
                            }).ToList();

                        // Đổ danh sách vừa tìm được vào BindingList
                        foreach (var item in dsSanPhamCuaHoaDon)
                        {
                            hoaDonChiTiet.Add(item);
                        }
                    }
                }

                // 4. CHỐT HẠ: Gán BindingList vào BindingSource rồi gán vào GridView
                // Phải có dòng này thì CSDL mới hiện lên bảng được!
                bsHoaDon.DataSource = hoaDonChiTiet;
                dgvHoaDon_ChiTiet.DataSource = bsHoaDon;

                // Cập nhật giao diện nút bấm và tổng tiền
                BatTatChucNang();
                TinhTongTienHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
        }
        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue);
            int giaBan = (int)numDonGiaBan.Value;

            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

            if (chiTiet != null)
            {
                chiTiet.SoLuongBan += 1;
                chiTiet.DonGiaBan = giaBan;
                chiTiet.ThanhTien = chiTiet.SoLuongBan * chiTiet.DonGiaBan;
            }
            else
            {
                DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                {
                    ID = 0,
                    HoaDonID = id,
                    SanPhamID = maSanPham,
                    TenSanPham = cboSanPham.Text,
                    SoLuongBan = 1,
                    DonGiaBan = giaBan,
                    ThanhTien = giaBan
                };
                hoaDonChiTiet.Add(ct);
            }

            bsHoaDon.ResetBindings(false);
            dgvHoaDon_ChiTiet.Refresh();

            BatTatChucNang();
            TinhTongTienHoaDon();
        }

        private void TinhTongTienHoaDon()
        {
            long tongTien = hoaDonChiTiet.Sum(x => (long)x.ThanhTien);
            // lblTongTien.Text = string.Format("Tổng thanh toán: {0:N0} VNĐ", tongTien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon_ChiTiet.CurrentRow != null)
            {
                int maSanPham = Convert.ToInt32(dgvHoaDon_ChiTiet.CurrentRow.Cells["SanPhamID"].Value);
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                if (chiTiet != null)
                {
                    hoaDonChiTiet.Remove(chiTiet);
                    bsHoaDon.ResetBindings(false);
                }
                BatTatChucNang();
                TinhTongTienHoaDon();
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn phải có ít nhất một sản phẩm!", "Thông báo");
                return;
            }

            try
            {
                QuanLyCSKH.Data.HoaDon hd;

                if (id == 0)
                {
                    hd = new QuanLyCSKH.Data.HoaDon();
                    hd.NgayLap = DateTime.Now;
                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.GhiChuHoaDon = textBox1.Text;

                    context.HoaDon.Add(hd);
                    context.SaveChanges();
                }
                else
                {
                    hd = context.HoaDon.Find(id);
                    if (hd == null) return;

                    hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.GhiChuHoaDon = textBox1.Text;

                    var oldDetails = context.HoaDon_ChiTiet.Where(x => x.HoaDonID == id);
                    context.HoaDon_ChiTiet.RemoveRange(oldDetails);
                }

                foreach (var item in hoaDonChiTiet)
                {
                    context.HoaDon_ChiTiet.Add(new QuanLyCSKH.Data.HoaDon_ChiTiet
                    {
                        HoaDonID = hd.ID,
                        SanPhamID = item.SanPhamID,
                        SoLuongBan = item.SoLuongBan,
                        DonGiaBan = item.DonGiaBan
                    });
                }

                context.SaveChanges();
                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi khi lưu: " + errorMsg, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                if (int.TryParse(cboSanPham.SelectedValue.ToString(), out int maSanPham))
                {
                    var sanPham = context.SanPham.Find(maSanPham);
                    if (sanPham != null)
                    {
                        numDonGiaBan.Value = sanPham.DonGia;
                    }
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                QuanLyCSKH.Data.HoaDon_ChiTiet ct = new QuanLyCSKH.Data.HoaDon_ChiTiet();
                                ct.HoaDonID = Convert.ToInt32(r["HoaDonID"]);
                                ct.SanPhamID = Convert.ToInt32(r["SanPhamID"]);
                                ct.SoLuongBan = Convert.ToInt32(r["SoLuongBan"]);
                                ct.DonGiaBan = Convert.ToInt32(r["DonGiaBan"]);
                                context.HoaDon_ChiTiet.Add(ct);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HoaDon_ChiTiet_Load(sender, e);
                        }
                        if (firstRow) MessageBox.Show("Tập tin Excel rỗng.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "HoaDonChiTiet_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoaDonID", typeof(int)),
                        new DataColumn("SanPhamID", typeof(int)),
                        new DataColumn("SoLuongBan", typeof(int)),
                        new DataColumn("DonGiaBan", typeof(int))
                    });

                    var chiTiet = context.HoaDon_ChiTiet.ToList();
                    foreach (var p in chiTiet)
                    {
                        table.Rows.Add(p.ID, p.HoaDonID, p.SanPhamID, p.SoLuongBan, p.DonGiaBan);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HoaDonChiTiet");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Xuất Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            
            if (id == 0)
            {
                MessageBox.Show("Vui lòng 'Lưu hóa đơn' trước khi in biên lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = $"BienLai_HD{id}.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("Biên Lai");

                            // 3. Truy vấn dữ liệu đầy đủ từ Database
                            var hd = context.HoaDon
                                            .Include(h => h.KhachHang)
                                            .Include(h => h.NhanVien)
                                            .FirstOrDefault(h => h.ID == id);

                            var chiTietList = context.HoaDon_ChiTiet
                                                     .Include(ct => ct.SanPham)
                                                     .Where(x => x.HoaDonID == id)
                                                     .ToList();

                            if (hd == null) return;

                            // 4. Ghi Thông tin Header (Thông tin cửa hàng & Hóa đơn)
                            ws.Cell("A1").Value = "CỬA HÀNG QUẢN LÝ CSKH";
                            ws.Cell("A1").Style.Font.Bold = true;
                            ws.Cell("A1").Style.Font.FontSize = 16;

                            ws.Cell("A3").Value = $"Mã Hóa Đơn: {hd.ID}";
                            ws.Cell("A4").Value = $"Ngày lập: {hd.NgayLap.ToString("dd/MM/yyyy HH:mm")}";
                            ws.Cell("A5").Value = $"Khách hàng: {hd.KhachHang?.HoVaTen}";
                            ws.Cell("A6").Value = $"Nhân viên lập: {hd.NhanVien?.HoVaTen}";
                            ws.Cell("A7").Value = $"Ghi chú: {hd.GhiChuHoaDon}";

                            // 5. Ghi tiêu đề bảng danh sách sản phẩm
                            ws.Cell("A9").Value = "Tên Sản Phẩm";
                            ws.Cell("B9").Value = "Số Lượng";
                            ws.Cell("C9").Value = "Đơn Giá";
                            ws.Cell("D9").Value = "Thành Tiền";

                            var headerRange = ws.Range("A9:D9");
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                            headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                            // 6. Ghi danh sách sản phẩm
                            int currentRow = 10;
                            double tongCong = 0;

                            foreach (var ct in chiTietList)
                            {
                                ws.Cell(currentRow, 1).Value = ct.SanPham?.TenSanPham;
                                ws.Cell(currentRow, 2).Value = ct.SoLuongBan;
                                ws.Cell(currentRow, 3).Value = ct.DonGiaBan;

                                double thanhTien = (double)(ct.SoLuongBan * ct.DonGiaBan);
                                ws.Cell(currentRow, 4).Value = thanhTien;

                                // Kẻ khung cho dòng
                                ws.Range(currentRow, 1, currentRow, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                                tongCong += thanhTien;
                                currentRow++;
                            }

                            // 7. Ghi Tổng cộng
                            int rowTong = currentRow + 1;
                            ws.Cell(rowTong, 3).Value = "TỔNG CỘNG:";
                            ws.Cell(rowTong, 3).Style.Font.Bold = true;
                            ws.Cell(rowTong, 4).Value = tongCong;
                            ws.Cell(rowTong, 4).Style.Font.Bold = true;
                            ws.Cell(rowTong, 4).Style.Font.FontColor = XLColor.Red;
                            // 8. Định dạng và Lưu
                            ws.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);

                            MessageBox.Show("Xuất biên lai Excel thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tự động mở file để khách xem luôn cho "oai"
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dgvHoaDon_ChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class DanhSachHoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; }
    }
}