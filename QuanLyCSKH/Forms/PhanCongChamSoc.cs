using ClosedXML.Excel;
using QuanLyCSKH.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCSKH.Forms
{
    public partial class PhanCongChamSoc : Form
    {
        QLCSKHbContext context = new QLCSKHbContext();
        int idPhanCongHienTai = 0;
        bool isThemMoi = false;

        public PhanCongChamSoc()
        {
            InitializeComponent();
            this.Load += PhanCongChamSoc_Load;
        }

        private void PhanCongChamSoc_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDataGidView();
            BatTatChucNang(false);
            SetButtonState(true);
        }

        public void LoadComboBoxes()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";

            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";

            cboHinhThuc.Items.Clear();
            cboHinhThuc.Items.AddRange(new string[] { "Gọi điện thoại", "Nhắn tin Zalo/SMS", "Gặp trực tiếp", "Gửi Email" });
            if (cboHinhThuc.Items.Count > 0) cboHinhThuc.SelectedIndex = 0;

            cboKetQua.Items.Clear();
            cboKetQua.Items.AddRange(new string[] { "Chưa liên lạc được", "Đang suy nghĩ", "Chốt lịch hẹn thành công", "Từ chối", "Sai số/Thuê bao" });
            if (cboKetQua.Items.Count > 0) cboKetQua.SelectedIndex = 0;
        }

        public void LoadDataGidView()
        {
            // Làm sạch bộ nhớ đệm để lấy dữ liệu mới nhất từ DB
            context.ChangeTracker.Clear();

            dgvPhanCong.AutoGenerateColumns = false;

            var danhSach = context.PhanCongChamSoc
                .Select(p => new DanhSachPhanCong
                {
                    ID = p.ID,
                    TenNhanVien = p.NhanVien.HoVaTen,
                    TenKhachHang = p.KhachHang.HoVaTen,
                    NgayChamSoc = p.NgayChamSoc,
                    NgayHenLai = p.NgayHenLai,
                    HinhThuc = p.HinhThuc,
                    NoiDung = p.NoiDung,
                    KetQua = p.KetQua
                }).ToList();

            dgvPhanCong.DataSource = new BindingList<DanhSachPhanCong>(danhSach);
        }
        public void BatTatChucNang(bool state)
        {
            cboNhanVien.Enabled = state;
            cboKhachHang.Enabled = state;
            cboHinhThuc.Enabled = state;
            cboKetQua.Enabled = state;
            dtpNgayChamSoc.Enabled = state;
            dtpNgayHenLai.Enabled = state; // <-- Bổ sung
            txtNoiDung.Enabled = state;
        }

        public void SetButtonState(bool normalState)
        {
            btnThem.Enabled = normalState;
            btnSua.Enabled = normalState;
            btnXoa.Enabled = normalState;
            btnLuu.Enabled = !normalState;
            btnHuy.Enabled = !normalState;
        }

        public void ClearInputs()
        {
            txtNoiDung.Clear();
            dtpNgayChamSoc.Value = DateTime.Now;
            dtpNgayHenLai.Value = DateTime.Now; // <-- Bổ sung
            if (cboHinhThuc.Items.Count > 0) cboHinhThuc.SelectedIndex = 0;
            if (cboKetQua.Items.Count > 0) cboKetQua.SelectedIndex = 0;
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];
                // Sử dụng chuỗi hằng số hoặc kiểm tra chính xác tên Column Name trong Designer
                if (row.Cells["ID"].Value != null)
                {
                    idPhanCongHienTai = Convert.ToInt32(row.Cells["ID"].Value);
                    LoadDetailToControls(idPhanCongHienTai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chọn dòng: {ex.Message}", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDetailToControls(int id)
        {
            // Tạo context mới hoặc refresh để tránh dữ liệu rác (Stale Data)
            using (var db = new QLCSKHbContext())
            {
                var pc = db.PhanCongChamSoc.Find(id);
                if (pc != null)
                {
                    cboNhanVien.SelectedValue = pc.NhanVienID;
                    cboKhachHang.SelectedValue = pc.KhachHangID;
                    dtpNgayChamSoc.Value = pc.NgayChamSoc;
                    dtpNgayHenLai.Value = pc.NgayHenLai ?? DateTime.Now;
                    cboHinhThuc.Text = pc.HinhThuc;
                    cboKetQua.Text = pc.KetQua;
                    txtNoiDung.Text = pc.NoiDung;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            isThemMoi = true;
            ClearInputs();
            BatTatChucNang(true);
            SetButtonState(false);
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvPhanCong.CurrentRow == null || dgvPhanCong.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần chỉnh sửa từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID trực tiếp từ dòng đang chọn
            idPhanCongHienTai = Convert.ToInt32(dgvPhanCong.CurrentRow.Cells["ID"].Value);

            // Nạp lại dữ liệu lên các controls để đảm bảo dữ liệu mới nhất
            LoadDetailToControls(idPhanCongHienTai);

            isThemMoi = false;
            BatTatChucNang(true);
            SetButtonState(false);
            txtNoiDung.Focus();
        }

        // --- NÚT XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.CurrentRow == null || dgvPhanCong.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idXoa = Convert.ToInt32(dgvPhanCong.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Sử dụng context để xóa
                    var pc = context.PhanCongChamSoc.Find(idXoa);
                    if (pc != null)
                    {
                        context.PhanCongChamSoc.Remove(pc);
                        context.SaveChanges();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGidView();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung chăm sóc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }

            if (isThemMoi)
            {
                var pc = new QuanLyCSKH.Data.PhanCongChamSoc
                {
                    NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue),
                    KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                    NgayChamSoc = dtpNgayChamSoc.Value,
                    NgayHenLai = dtpNgayHenLai.Value, // <-- Bổ sung khi thêm mới
                    HinhThuc = cboHinhThuc.Text,
                    KetQua = cboKetQua.Text,
                    NoiDung = txtNoiDung.Text
                };
                context.PhanCongChamSoc.Add(pc);
            }
            else
            {
                var pc = context.PhanCongChamSoc.Find(idPhanCongHienTai);
                if (pc != null)
                {
                    pc.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    pc.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    pc.NgayChamSoc = dtpNgayChamSoc.Value;
                    pc.NgayHenLai = dtpNgayHenLai.Value; // <-- Bổ sung khi sửa
                    pc.HinhThuc = cboHinhThuc.Text;
                    pc.KetQua = cboKetQua.Text;
                    pc.NoiDung = txtNoiDung.Text;
                    context.PhanCongChamSoc.Update(pc);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGidView();
            BatTatChucNang(false);
            SetButtonState(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            SetButtonState(true);
            ClearInputs();
            idPhanCongHienTai = 0;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachPhanCong_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[8] // Tăng lên 8 cột
                    {
                        new DataColumn("Mã PC", typeof(int)),
                        new DataColumn("Tên Nhân Viên", typeof(string)),
                        new DataColumn("Tên Khách Hàng", typeof(string)),
                        new DataColumn("Ngày Chăm Sóc", typeof(string)),
                        new DataColumn("Ngày Hẹn Lại", typeof(string)), // <-- Cột mới
                        new DataColumn("Hình Thức", typeof(string)),
                        new DataColumn("Nội Dung", typeof(string)),
                        new DataColumn("Kết Quả", typeof(string))
                    });

                    var data = context.PhanCongChamSoc.Select(p => new
                    {
                        p.ID,
                        TenNV = p.NhanVien.HoVaTen,
                        TenKH = p.KhachHang.HoVaTen,
                        p.NgayChamSoc,
                        p.NgayHenLai, // <-- Bổ sung lấy dữ liệu
                        p.HinhThuc,
                        p.NoiDung,
                        p.KetQua
                    }).ToList();

                    foreach (var p in data)
                    {
                        table.Rows.Add(p.ID, p.TenNV, p.TenKH,
                                       p.NgayChamSoc.ToString("dd/MM/yyyy"),
                                       p.NgayHenLai?.ToString("dd/MM/yyyy") ?? "", // Cột Hẹn lại
                                       p.HinhThuc, p.NoiDung, p.KetQua);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "PhanCong");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Xuất Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                            int count = 0;
                            foreach (DataRow r in table.Rows)
                            {
                                string tenNV = r[1].ToString().Trim();
                                string tenKH = r[2].ToString().Trim();

                                var nv = context.NhanVien.FirstOrDefault(x => x.HoVaTen == tenNV);
                                var kh = context.KhachHang.FirstOrDefault(x => x.HoVaTen == tenKH);

                                if (nv != null && kh != null)
                                {
                                    DateTime parsedDateCS, parsedDateHL;
                                    bool isDateCSValid = DateTime.TryParse(r[3].ToString(), out parsedDateCS);
                                    bool isDateHLValid = DateTime.TryParse(r[4].ToString(), out parsedDateHL); // Cột 4 là Hẹn lại

                                    QuanLyCSKH.Data.PhanCongChamSoc pc = new QuanLyCSKH.Data.PhanCongChamSoc();
                                    pc.NhanVienID = nv.ID;
                                    pc.KhachHangID = kh.ID;
                                    pc.NgayChamSoc = isDateCSValid ? parsedDateCS : DateTime.Now;
                                    pc.NgayHenLai = isDateHLValid ? parsedDateHL : (DateTime?)null; // <-- Bổ sung
                                    pc.HinhThuc = r[5].ToString().Trim(); // Lưu ý: Tăng index các cột sau lên
                                    pc.NoiDung = r[6].ToString().Trim();
                                    pc.KetQua = r[7].ToString().Trim();

                                    context.PhanCongChamSoc.Add(pc);
                                    count++;
                                }
                            }
                            context.SaveChanges();
                            MessageBox.Show($"Đã nhập thành công {count} dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataGidView();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PhanCongChamSoc_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class DanhSachPhanCong
    {
        public int ID { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgayChamSoc { get; set; }
        public DateTime? NgayHenLai { get; set; } // <-- Thêm vào DTO (dùng ? để chấp nhận null)
        public string HinhThuc { get; set; }
        public string NoiDung { get; set; }
        public string KetQua { get; set; }
    }
}