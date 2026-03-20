namespace QuanLyCSKH.Forms
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            groupBox1 = new GroupBox();
            dgvHoaDon = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            label9 = new Label();
            btnInHoaDon = new Button();
            btnSua = new Button();
            btnLapHoaDon = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            btnTimKiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(dgvHoaDon);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dgvHoaDon.Location = new Point(3, 23);
            dgvHoaDon.Margin = new Padding(2, 1, 2, 1);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 82;
            dgvHoaDon.Size = new Size(864, 355);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLapHoaDon);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnNhap);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 66);
            panel1.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Location = new Point(497, 36);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(215, 27);
            txtTimKiem.TabIndex = 27;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(411, 41);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 26;
            label9.Text = "Tìm kiếm";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.None;
            btnInHoaDon.Location = new Point(12, 36);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(213, 29);
            btnInHoaDon.TabIndex = 19;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(259, 37);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 29);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.None;
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Location = new Point(12, 1);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(213, 29);
            btnLapHoaDon.TabIndex = 18;
            btnLapHoaDon.Text = "Lập hóa đơn mới";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(259, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 29);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(741, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 29);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Location = new Point(411, 2);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(125, 29);
            btnNhap.TabIndex = 23;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.Location = new Point(586, 2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(126, 29);
            btnXuat.TabIndex = 25;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.ForeColor = Color.Blue;
            btnTimKiem.Location = new Point(741, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(119, 29);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 459);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HoaDon";
            Text = "HoaDon";
            WindowState = FormWindowState.Maximized;
            Load += HoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Label label9;
        private Button btnInHoaDon;
        private Button btnSua;
        private Button btnLapHoaDon;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnTimKiem;
    }
}