namespace QuanLyCSKH.Forms
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            dgvSanPham = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numSoLuong = new NumericUpDown();
            label7 = new Label();
            numDonGia = new NumericUpDown();
            cboTenSanPham = new ComboBox();
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 365);
            panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvSanPham);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 365);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, DonGia, SoLuong, HinhAnh });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(3, 23);
            dgvSanPham.Margin = new Padding(2, 1, 2, 1);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(978, 339);
            dgvSanPham.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 275);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(343, -10);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 9;
            label1.Text = "Bảng sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(btnDoiAnh);
            groupBox2.Controls.Add(picHinhAnh);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(cboTenSanPham);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(91, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 254);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.None;
            btnDoiAnh.Location = new Point(483, 199);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 30;
            btnDoiAnh.Text = "Đổi ảnh..";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.None;
            picHinhAnh.Location = new Point(465, 50);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(112, 143);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 29;
            picHinhAnh.TabStop = false;
            // 
            // numSoLuong
            // 
            numSoLuong.Anchor = AnchorStyles.None;
            numSoLuong.Location = new Point(150, 133);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(309, 27);
            numSoLuong.TabIndex = 28;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(43, 135);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 27;
            label7.Text = "Số lượng";
            // 
            // numDonGia
            // 
            numDonGia.Anchor = AnchorStyles.None;
            numDonGia.Location = new Point(150, 93);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(309, 27);
            numDonGia.TabIndex = 26;
            // 
            // cboTenSanPham
            // 
            cboTenSanPham.Anchor = AnchorStyles.None;
            cboTenSanPham.FormattingEnabled = true;
            cboTenSanPham.Items.AddRange(new object[] { "Liệu trình trị mụn chuẩn Y khoa", "Chăm sóc da mặt chuyên sâu", "Phục hồi da mỏng yếu, nổi mao mạch", "Tắm trắng phi thuyền hoàng gia", "Triệt lông nách vĩnh viễn (Trọn gói)", "Triệt lông toàn thân VIP", "Nâng cơ trẻ hóa da công nghệ Hifu", "Massage body đá nóng đả thông kinh lạc", "Phun mày tán bột tự nhiên", "Khử thâm môi Collagen" });
            cboTenSanPham.Location = new Point(150, 50);
            cboTenSanPham.Name = "cboTenSanPham";
            cboTenSanPham.Size = new Size(309, 28);
            cboTenSanPham.TabIndex = 25;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Location = new Point(683, 115);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 24;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.Location = new Point(683, 164);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 23;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Location = new Point(683, 18);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 22;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(683, 69);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.None;
            btnLuu.Location = new Point(583, 164);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(583, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(583, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(583, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.None;
            btnTim.Location = new Point(365, 199);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 16;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Location = new Point(150, 166);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(309, 27);
            txtTimKiem.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(43, 173);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 7;
            label9.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(43, 95);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(43, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 640);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SanPham";
            Text = "Sản phẩm";
            WindowState = FormWindowState.Maximized;
            Load += SanPham_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboNhomKhachHang;
        private DateTimePicker dtNgaySinh;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private GroupBox groupBox1;
        private DataGridView dgvSanPham;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewImageColumn HinhAnh;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private NumericUpDown numSoLuong;
        private Label label7;
        private NumericUpDown numDonGia;
        private ComboBox cboTenSanPham;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnTim;
        private TextBox txtTimKiem;
        private Label label9;
        private Label label3;
        private Label label2;
    }
}