namespace QuanLyCSKH.Forms
{
    partial class HoaDon_ChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon_ChiTiet));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dgvHoaDon_ChiTiet = new DataGridView();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            groupBox2 = new GroupBox();
            btnXacNhanBan = new Button();
            cboSanPham = new ComboBox();
            numDonGiaBan = new NumericUpDown();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboKhachHang = new ComboBox();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            btnXoa = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon_ChiTiet).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 559);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvHoaDon_ChiTiet);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 245);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dgvHoaDon_ChiTiet
            // 
            dgvHoaDon_ChiTiet.AllowUserToAddRows = false;
            dgvHoaDon_ChiTiet.AllowUserToDeleteRows = false;
            dgvHoaDon_ChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon_ChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon_ChiTiet.Columns.AddRange(new DataGridViewColumn[] { TenSanPham, DonGiaBan, ThanhTien });
            dgvHoaDon_ChiTiet.Dock = DockStyle.Fill;
            dgvHoaDon_ChiTiet.Location = new Point(3, 23);
            dgvHoaDon_ChiTiet.Margin = new Padding(2, 1, 2, 1);
            dgvHoaDon_ChiTiet.MultiSelect = false;
            dgvHoaDon_ChiTiet.Name = "dgvHoaDon_ChiTiet";
            dgvHoaDon_ChiTiet.ReadOnly = true;
            dgvHoaDon_ChiTiet.RowHeadersWidth = 82;
            dgvHoaDon_ChiTiet.Size = new Size(961, 219);
            dgvHoaDon_ChiTiet.TabIndex = 2;
            dgvHoaDon_ChiTiet.CellContentClick += dgvHoaDon_ChiTiet_CellContentClick;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            DonGiaBan.HeaderText = "Đơn Giá Bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnLuuHoaDon);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnXuat);
            panel2.Controls.Add(btnNhap);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 86);
            panel2.TabIndex = 9;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.None;
            btnInHoaDon.Location = new Point(348, 26);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(213, 29);
            btnInHoaDon.TabIndex = 46;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.None;
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(112, 26);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(213, 29);
            btnLuuHoaDon.TabIndex = 45;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(794, 26);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 42;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.Location = new Point(694, 26);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 43;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Location = new Point(594, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 44;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboKhachHang);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(label6);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(967, 228);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.None;
            btnXacNhanBan.ForeColor = Color.FromArgb(0, 0, 192);
            btnXacNhanBan.Location = new Point(561, 171);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(94, 29);
            btnXacNhanBan.TabIndex = 37;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // cboSanPham
            // 
            cboSanPham.Anchor = AnchorStyles.None;
            cboSanPham.DropDownWidth = 350;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Items.AddRange(new object[] { "Liệu trình trị mụn chuẩn Y khoa", "Chăm sóc da mặt chuyên sâu", "Phục hồi da mỏng yếu, nổi mao mạch", "Tắm trắng phi thuyền hoàng gia", "Triệt lông nách vĩnh viễn (Trọn gói)", "Triệt lông toàn thân VIP", "Nâng cơ trẻ hóa da công nghệ Hifu", "Massage body đá nóng đả thông kinh lạc", "Phun mày tán bột tự nhiên", "Khử thâm môi Collagen" });
            cboSanPham.Location = new Point(18, 174);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(224, 28);
            cboSanPham.TabIndex = 36;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Anchor = AnchorStyles.None;
            numDonGiaBan.Location = new Point(333, 173);
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(203, 27);
            numDonGiaBan.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(173, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(594, 27);
            textBox1.TabIndex = 34;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(333, 138);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 33;
            label4.Text = "Đơn giá (*):";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(18, 89);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 32;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(18, 138);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 31;
            label2.Text = "Sản phẩm (*):";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.None;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboKhachHang.Location = new Point(551, 44);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(216, 28);
            cboKhachHang.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(427, 49);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 29;
            label1.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.None;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboNhanVien.Location = new Point(173, 41);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(199, 28);
            cboNhanVien.TabIndex = 26;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(673, 173);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(18, 44);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 4;
            label6.Text = "Nhân viên lập (*):";
            // 
            // HoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 559);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HoaDon_ChiTiet";
            Text = "Hóa đơn chi tiết";
            WindowState = FormWindowState.Maximized;
            Load += HoaDon_ChiTiet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon_ChiTiet).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Button btnXacNhanBan;
        private ComboBox cboSanPham;
        private NumericUpDown numDonGiaBan;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboKhachHang;
        private Label label1;
        private ComboBox cboNhanVien;
        private Button btnXoa;
        private Label label6;
        private GroupBox groupBox1;
        private DataGridView dgvHoaDon_ChiTiet;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Panel panel2;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnNhap;
    }
}