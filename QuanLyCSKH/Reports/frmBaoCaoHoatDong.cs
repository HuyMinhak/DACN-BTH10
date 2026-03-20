using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Data.SqlClient;

namespace QuanLyCSKH.Reports
{
    public partial class frmBaoCaoHoatDong : Form
    {
        string chuoiKetNoi = @"Data Source=LAPTOP-3VDNARNT;Initial Catalog=QLCSKH;Integrated Security=True;TrustServerCertificate=True";
        private ReportViewer reportViewer1;

        public frmBaoCaoHoatDong()
        {
            InitializeComponent();

            // 1. Phóng to Form ra full toàn màn hình
            this.WindowState = FormWindowState.Maximized;

            SetupReportViewer();
        }

        private void SetupReportViewer()
        {
            // Tạo khung báo cáo bằng code để nó không bị "rớt xuống khay"
            reportViewer1 = new ReportViewer();
            reportViewer1.Location = new Point(10, 150); // Nằm dưới 2 cái nút
            reportViewer1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 160);
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // 2. Ép nội dung báo cáo tự động phóng to (Zoom) ra cho vừa khít chiều ngang
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            this.Controls.Add(reportViewer1);

            // ÉP 2 CÁI NÚT PHẢI NỔI LÊN TRÊN CÙNG
            btnXemNangSuat.BringToFront();
            btnXemCuocHen.BringToFront();
        }

        // HÀM CHO NÚT 1
        public void btnXemNangSuat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT nv.HoVaTen AS TenNhanVien, COUNT(pc.ID) AS SoLuotChamSoc FROM NhanVien nv INNER JOIN PhanCongChamSoc pc ON nv.ID = pc.NhanVienID GROUP BY nv.HoVaTen";
            RunReport(@"Reports\rptNangSuat.rdlc", "dsNangSuat", sql);
        }

        // HÀM CHO NÚT 2 (Đã fix lỗi SoDienThoai)
        public void btnXemCuocHen_Click(object sender, EventArgs e)
        {
            string sql = "SELECT kh.HoVaTen AS TenKhachHang, kh.DienThoai AS DienThoai, pc.NgayHenLai, pc.NoiDung AS NoiDungChamSoc, nv.HoVaTen AS NhanVienPhuTrach FROM PhanCongChamSoc pc INNER JOIN KhachHang kh ON pc.KhachHangID = kh.ID INNER JOIN NhanVien nv ON pc.NhanVienID = nv.ID WHERE pc.NgayHenLai >= CAST(GETDATE() AS DATE)";
            RunReport(@"Reports\rptCuocHenSapToi.rdlc", "dsCuocHen", sql);
        }

        private void RunReport(string rPath, string dsName, string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    reportViewer1.LocalReport.ReportPath = rPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(dsName, dt));
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}