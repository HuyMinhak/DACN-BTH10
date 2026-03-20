using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

// Lưu ý: Đảm bảo Namespace này giống với tên Project của chị
namespace QuanLyCSKH.Reports
{
    public partial class frmBaoCaoHieuQua : Form
    {
        // Kết nối Database
        QuanLyCSKH.Data.QLCSKHbContext context = new QuanLyCSKH.Data.QLCSKHbContext();

        // Khai báo khung báo cáo bằng Code
        private ReportViewer reportViewer1;

        public frmBaoCaoHieuQua()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            this.Load += frmBaoCaoHieuQua_Load; // Lệnh ép Form phải nạp dữ liệu khi mở
        }

        private void frmBaoCaoHieuQua_Load(object sender, EventArgs e)
        {
            // --- BƯỚC 1: TẠO KHUNG BÁO CÁO ---
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);

            try
            {
                // --- BƯỚC 2: RÚT DỮ LIỆU "KẾT QUẢ" VÀO BẢNG ---
                DataTable dataKetQua = new DataTable();
                dataKetQua.Columns.Add("TenDoiTuong", typeof(string));
                dataKetQua.Columns.Add("SoLuong", typeof(int));

                var groupKetQua = context.PhanCongChamSoc
                    .GroupBy(x => x.KetQua)
                    .Select(g => new {
                        Ten = string.IsNullOrEmpty(g.Key) ? "Chưa cập nhật" : g.Key,
                        SL = g.Count()
                    }).ToList();

                foreach (var item in groupKetQua)
                {
                    dataKetQua.Rows.Add(item.Ten, item.SL);
                }

                // --- BƯỚC 3: RÚT DỮ LIỆU "HÌNH THỨC" VÀO BẢNG ---
                DataTable dataHinhThuc = new DataTable();
                dataHinhThuc.Columns.Add("TenDoiTuong", typeof(string));
                dataHinhThuc.Columns.Add("SoLuong", typeof(int));

                var groupHinhThuc = context.PhanCongChamSoc
                    .GroupBy(x => x.HinhThuc)
                    .Select(g => new {
                        Ten = string.IsNullOrEmpty(g.Key) ? "Chưa cập nhật" : g.Key,
                        SL = g.Count()
                    }).ToList();

                foreach (var item in groupHinhThuc)
                {
                    dataHinhThuc.Rows.Add(item.Ten, item.SL);
                }

                // --- BƯỚC 4: LIÊN KẾT ĐƯỜNG DẪN VÀ ĐỔ DỮ LIỆU VÀO BIỂU ĐỒ ---
                string reportPath = Path.Combine(Application.StartupPath, "Reports", "rptHieuQuaChamSoc.rdlc");
                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();

                // HAI TÊN "dsKetQua" VÀ "dsHinhThuc" NÀY PHẢI KHỚP Y CHANG TÊN CHỊ ĐẶT Ở GIAI ĐOẠN 2 NHÉ
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsKetQua", dataKetQua));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsHinhThuc", dataHinhThuc));

                // --- BƯỚC 5: HIỂN THỊ LÊN MÀN HÌNH ---
               // reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chị ơi có lỗi nhỏ: " + ex.Message, "Thông báo");
            }
        }
    }
}