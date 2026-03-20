using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Data.SqlClient;

namespace QuanLyCSKH.Reports
{
    public partial class frmBaoCaoSinhNhat : Form
    {
        public frmBaoCaoSinhNhat()
        {
            InitializeComponent();
            reportViewer1 = new ReportViewer();

            reportViewer1.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer1);
        }

        private void frmBaoCaoSinhNhat_Load(object sender, EventArgs e)
        {
            // 1. Phóng to cái Form ra full toàn màn hình
            this.WindowState = FormWindowState.Maximized;

            // 2. Ép nội dung báo cáo tự động phóng to (Zoom) ra cho vừa khít chiều ngang
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            // 3. Trỏ đường dẫn và gọi dữ liệu (Đã xóa các dòng bị copy trùng lặp)
            reportViewer1.LocalReport.ReportPath = @"Reports\rptSinhNhatKhachHang.rdlc";
            LoadDuLieuBaoCao();
        }

        private void LoadDuLieuBaoCao()
        {
            string chuoiKetNoi = @"Data Source=LAPTOP-3VDNARNT;Initial Catalog=QLCSKH;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                // ==============================================================
                // Lấy sinh nhật THÁNG NÀY và THÁNG TỚI, Sắp xếp LIÊN TỤC theo ngày tháng
                // ==============================================================
                string query = @"
                    SELECT * FROM KhachHang 
                    WHERE MONTH(NgaySinh) IN (MONTH(GETDATE()), MONTH(DATEADD(month, 1, GETDATE())))
                    ORDER BY MONTH(NgaySinh), DAY(NgaySinh)";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Xóa dữ liệu cũ nếu có
                reportViewer1.LocalReport.DataSources.Clear();

                // LƯU Ý KỸ: Chữ "DataSetSinhNhat" này phải GIỐNG HỆT với tên DataSet lúc chị thiết kế file rdlc nha!
                ReportDataSource rds = new ReportDataSource("DataSetSinhNhat", dt);

                // Bơm dữ liệu vào ReportViewer
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Ra lệnh hiển thị báo cáo
                reportViewer1.RefreshReport();
            }
        }
    }
}