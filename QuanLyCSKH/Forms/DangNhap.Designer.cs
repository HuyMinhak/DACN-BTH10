namespace QuanLyCSKH.Forms
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            pictureBox1 = new PictureBox();
            chkHienMatKhau = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 168);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 91);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(248, 204);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(307, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(248, 124);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(307, 27);
            txtTenDangNhap.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.ForeColor = Color.Blue;
            btnDangNhap.Location = new Point(248, 277);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(125, 36);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = Color.Red;
            btnHuyBo.Location = new Point(417, 277);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(125, 36);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3D_Mini_Style_Vector_Illustrations_in_PNG_and_SVG;
            pictureBox1.Location = new Point(12, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(248, 237);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(127, 24);
            chkHienMatKhau.TabIndex = 8;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged_1;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 343);
            Controls.Add(chkHienMatKhau);
            Controls.Add(pictureBox1);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private PictureBox pictureBox1;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
        private CheckBox chkHienMatKhau;
    }
}