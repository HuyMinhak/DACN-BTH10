namespace QuanLyCSKH.Forms
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtNgaySinh = new DateTimePicker();
            cboNhomKhachHang = new ComboBox();
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
            txtDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtHoVaTen = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dgvKhachHang = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            NhomKhachHang = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 290);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(313, 5);
            label1.Name = "label1";
            label1.Size = new Size(295, 46);
            label1.TabIndex = 6;
            label1.Text = "Bảng khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dtNgaySinh);
            groupBox2.Controls.Add(cboNhomKhachHang);
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
            groupBox2.Controls.Add(txtDienThoai);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(txtHoVaTen);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(61, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 262);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(391, 40);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(194, 27);
            dtNgaySinh.TabIndex = 27;
            // 
            // cboNhomKhachHang
            // 
            cboNhomKhachHang.FormattingEnabled = true;
            cboNhomKhachHang.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboNhomKhachHang.Location = new Point(444, 81);
            cboNhomKhachHang.Name = "cboNhomKhachHang";
            cboNhomKhachHang.Size = new Size(141, 28);
            cboNhomKhachHang.TabIndex = 26;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(700, 124);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 24;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(700, 173);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 23;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(700, 27);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 22;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(700, 78);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(600, 173);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(600, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(600, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(600, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(465, 166);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 16;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(150, 166);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(309, 27);
            txtTimKiem.TabIndex = 15;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(150, 80);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(150, 27);
            txtDienThoai.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(150, 127);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(150, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(150, 40);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(150, 27);
            txtHoVaTen.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 173);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 7;
            label9.Text = "Tìm kiếm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 89);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 4;
            label6.Text = "Nhóm khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 43);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 3;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 127);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvKhachHang);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(922, 256);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, NgaySinh, NhomKhachHang });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(3, 23);
            dgvKhachHang.Margin = new Padding(2, 1, 2, 1);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 82;
            dgvKhachHang.Size = new Size(916, 230);
            dgvKhachHang.TabIndex = 1;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và Tên";
            HoVaTen.MinimumWidth = 10;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 10;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // NhomKhachHang
            // 
            NhomKhachHang.DataPropertyName = "NhomKhachHang";
            NhomKhachHang.HeaderText = "Nhóm khách hàng";
            NhomKhachHang.MinimumWidth = 6;
            NhomKhachHang.Name = "NhomKhachHang";
            NhomKhachHang.ReadOnly = true;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 546);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KhachHang";
            Text = "KhachHang";
            WindowState = FormWindowState.Maximized;
            Load += KhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private Label label8;
        private Label label7;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dtNgaySinh;
        private ComboBox cboNhomKhachHang;
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
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn NhomKhachHang;
    }
}