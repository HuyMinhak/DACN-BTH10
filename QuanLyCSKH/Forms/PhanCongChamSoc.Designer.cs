namespace QuanLyCSKH.Forms
{
    partial class PhanCongChamSoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongChamSoc));
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtpNgayHenLai = new DateTimePicker();
            label8 = new Label();
            txtNoiDung = new TextBox();
            label7 = new Label();
            cboKetQua = new ComboBox();
            label3 = new Label();
            cboHinhThuc = new ComboBox();
            label4 = new Label();
            dtpNgayChamSoc = new DateTimePicker();
            label5 = new Label();
            cboKhachHang = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            label6 = new Label();
            btnNhap = new Button();
            btnXuat = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            dgvPhanCong = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NgayChamSoc = new DataGridViewTextBoxColumn();
            NgayHenLai = new DataGridViewTextBoxColumn();
            HinhThuc = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 286);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(258, 3);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 12;
            label1.Text = "Bảng phân công";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dtpNgayHenLai);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtNoiDung);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cboKetQua);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboHinhThuc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpNgayChamSoc);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboKhachHang);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboNhanVien);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnNhap);
            groupBox2.Controls.Add(btnXuat);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Location = new Point(6, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 259);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phân công";
            // 
            // dtpNgayHenLai
            // 
            dtpNgayHenLai.Anchor = AnchorStyles.None;
            dtpNgayHenLai.Location = new Point(181, 153);
            dtpNgayHenLai.Name = "dtpNgayHenLai";
            dtpNgayHenLai.Size = new Size(199, 27);
            dtpNgayHenLai.TabIndex = 44;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(26, 153);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 43;
            label8.Text = "Ngày hẹn lại:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Anchor = AnchorStyles.None;
            txtNoiDung.Location = new Point(557, 121);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(199, 22);
            txtNoiDung.TabIndex = 42;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(419, 121);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 41;
            label7.Text = "Nội dung:";
            // 
            // cboKetQua
            // 
            cboKetQua.Anchor = AnchorStyles.None;
            cboKetQua.FormattingEnabled = true;
            cboKetQua.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboKetQua.Location = new Point(557, 74);
            cboKetQua.Name = "cboKetQua";
            cboKetQua.Size = new Size(199, 28);
            cboKetQua.TabIndex = 40;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(419, 77);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 39;
            label3.Text = "Kết quả:";
            // 
            // cboHinhThuc
            // 
            cboHinhThuc.Anchor = AnchorStyles.None;
            cboHinhThuc.FormattingEnabled = true;
            cboHinhThuc.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboHinhThuc.Location = new Point(181, 74);
            cboHinhThuc.Name = "cboHinhThuc";
            cboHinhThuc.Size = new Size(199, 28);
            cboHinhThuc.TabIndex = 38;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(26, 77);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 37;
            label4.Text = "Hình thức:";
            // 
            // dtpNgayChamSoc
            // 
            dtpNgayChamSoc.Anchor = AnchorStyles.None;
            dtpNgayChamSoc.Location = new Point(181, 116);
            dtpNgayChamSoc.Name = "dtpNgayChamSoc";
            dtpNgayChamSoc.Size = new Size(199, 27);
            dtpNgayChamSoc.TabIndex = 36;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(26, 116);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 35;
            label5.Text = "Ngày chăm sóc:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.None;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboKhachHang.Location = new Point(557, 30);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(199, 28);
            cboKhachHang.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(419, 33);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 33;
            label2.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.None;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Items.AddRange(new object[] { "Khách vãng lai", "Khách hàng mới", "Khách hàng thân thiết", "Khách VIP", "Khách lâu chưa quay lại" });
            cboNhanVien.Location = new Point(181, 30);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(199, 28);
            cboNhanVien.TabIndex = 32;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(26, 33);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 31;
            label6.Text = "Nhân viên lập (*):";
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Location = new Point(503, 186);
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
            btnXuat.Location = new Point(603, 186);
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
            btnHuy.Location = new Point(403, 186);
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
            btnThoat.Location = new Point(703, 186);
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
            btnLuu.Location = new Point(303, 186);
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
            btnXoa.Location = new Point(203, 186);
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
            btnThem.Location = new Point(3, 186);
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
            btnSua.Location = new Point(103, 186);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 293);
            panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dgvPhanCong);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 293);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phân công";
            // 
            // dgvPhanCong
            // 
            dgvPhanCong.AllowUserToAddRows = false;
            dgvPhanCong.AllowUserToDeleteRows = false;
            dgvPhanCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhanCong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhanCong.Columns.AddRange(new DataGridViewColumn[] { ID, TenNhanVien, TenKhachHang, NgayChamSoc, NgayHenLai, HinhThuc, NoiDung });
            dgvPhanCong.Location = new Point(5, 24);
            dgvPhanCong.Margin = new Padding(2, 1, 2, 1);
            dgvPhanCong.MultiSelect = false;
            dgvPhanCong.Name = "dgvPhanCong";
            dgvPhanCong.ReadOnly = true;
            dgvPhanCong.RowHeadersWidth = 82;
            dgvPhanCong.Size = new Size(812, 259);
            dgvPhanCong.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 27.2193642F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.FillWeight = 117.801353F;
            TenNhanVien.HeaderText = "Nhân Viên Chăm Sóc";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.FillWeight = 89.51728F;
            TenKhachHang.HeaderText = "Khách Hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // NgayChamSoc
            // 
            NgayChamSoc.DataPropertyName = "NgayChamSoc";
            NgayChamSoc.FillWeight = 124.21949F;
            NgayChamSoc.HeaderText = "Ngày Chăm Sóc";
            NgayChamSoc.MinimumWidth = 6;
            NgayChamSoc.Name = "NgayChamSoc";
            NgayChamSoc.ReadOnly = true;
            // 
            // NgayHenLai
            // 
            NgayHenLai.DataPropertyName = "NgayHenLai";
            NgayHenLai.FillWeight = 115.343758F;
            NgayHenLai.HeaderText = "Ngày hẹn lại";
            NgayHenLai.MinimumWidth = 6;
            NgayHenLai.Name = "NgayHenLai";
            NgayHenLai.ReadOnly = true;
            // 
            // HinhThuc
            // 
            HinhThuc.DataPropertyName = "HinhThuc";
            HinhThuc.FillWeight = 109.657028F;
            HinhThuc.HeaderText = "Hình Thức";
            HinhThuc.MinimumWidth = 6;
            HinhThuc.Name = "HinhThuc";
            HinhThuc.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.FillWeight = 116.241554F;
            NoiDung.HeaderText = "Nội Dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // PhanCongChamSoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 585);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PhanCongChamSoc";
            Text = "PhanCongChamSoc";
            WindowState = FormWindowState.Maximized;
            Load += PhanCongChamSoc_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dtpNgayHenLai;
        private Label label8;
        private TextBox txtNoiDung;
        private Label label7;
        private ComboBox cboKetQua;
        private Label label3;
        private ComboBox cboHinhThuc;
        private Label label4;
        private DateTimePicker dtpNgayChamSoc;
        private Label label5;
        private ComboBox cboKhachHang;
        private Label label2;
        private ComboBox cboNhanVien;
        private Label label6;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Panel panel2;
        private GroupBox groupBox1;
        private DataGridView dgvPhanCong;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NgayChamSoc;
        private DataGridViewTextBoxColumn NgayHenLai;
        private DataGridViewTextBoxColumn HinhThuc;
        private DataGridViewTextBoxColumn NoiDung;
    }
}