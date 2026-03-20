namespace QuanLyCSKH.Reports
{
    partial class frmBaoCaoHoatDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoHoatDong));
            btnXemNangSuat = new Button();
            btnXemCuocHen = new Button();
            reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // btnXemNangSuat
            // 
            btnXemNangSuat.Location = new Point(-2, 1);
            btnXemNangSuat.Name = "btnXemNangSuat";
            btnXemNangSuat.Size = new Size(328, 88);
            btnXemNangSuat.TabIndex = 0;
            btnXemNangSuat.Text = "Xem Năng Suất";
            btnXemNangSuat.UseVisualStyleBackColor = true;
            btnXemNangSuat.Click += btnXemNangSuat_Click;
            // 
            // btnXemCuocHen
            // 
            btnXemCuocHen.Location = new Point(332, 1);
            btnXemCuocHen.Name = "btnXemCuocHen";
            btnXemCuocHen.Size = new Size(336, 88);
            btnXemCuocHen.TabIndex = 1;
            btnXemCuocHen.Text = "Cuộc Hẹn Sắp Tới";
            btnXemCuocHen.UseVisualStyleBackColor = true;
            btnXemCuocHen.Click += btnXemCuocHen_Click;
            // 
            // reportViewer2
            // 
            reportViewer2.Location = new Point(0, 0);
            reportViewer2.Name = "ReportViewer";
            reportViewer2.ServerReport.BearerToken = null;
            reportViewer2.Size = new Size(396, 246);
            reportViewer2.TabIndex = 0;
            // 
            // frmBaoCaoHoatDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 332);
            Controls.Add(btnXemCuocHen);
            Controls.Add(btnXemNangSuat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBaoCaoHoatDong";
            Text = "Báo cáo hoạt động nhân viên";
            ResumeLayout(false);
        }

        #endregion

        private Button btnXemNangSuat;
        private Button btnXemCuocHen;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}