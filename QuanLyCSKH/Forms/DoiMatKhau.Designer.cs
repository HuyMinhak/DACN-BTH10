namespace QuanLyCSKH.Forms
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhan = new TextBox();
            chkHienMatKhau = new CheckBox();
            btnHuy = new Button();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(207, 21);
            label1.Name = "label1";
            label1.Size = new Size(401, 67);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 123);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu củ(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 171);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 216);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập mật khẩu mới:";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(286, 116);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(331, 27);
            txtMatKhauCu.TabIndex = 4;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(286, 168);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(331, 27);
            txtMatKhauMoi.TabIndex = 5;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(286, 216);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(331, 27);
            txtXacNhan.TabIndex = 6;
            txtXacNhan.UseSystemPasswordChar = true;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(285, 263);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(127, 24);
            chkHienMatKhau.TabIndex = 7;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnHuy
            // 
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(469, 323);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(139, 57);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.ForeColor = Color.Blue;
            btnXacNhan.Location = new Point(285, 323);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(139, 57);
            btnXacNhan.TabIndex = 9;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXacNhan);
            Controls.Add(btnHuy);
            Controls.Add(chkHienMatKhau);
            Controls.Add(txtXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhan;
        private CheckBox chkHienMatKhau;
        private Button btnHuy;
        private Button btnXacNhan;
    }
}