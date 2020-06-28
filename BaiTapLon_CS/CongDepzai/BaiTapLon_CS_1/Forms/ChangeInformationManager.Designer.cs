namespace BaiTapLon_CS.Forms
{
    partial class ChangeInformationManager
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
            this.ButtonHuy = new System.Windows.Forms.Button();
            this.ButtonApDung = new System.Windows.Forms.Button();
            this.TextBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.TextBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxDienThoai = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelMaSanPham = new System.Windows.Forms.Label();
            this.LabelDongGoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNgayVaoLam = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLuong = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDoiMatKhau = new System.Windows.Forms.Button();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.textBoxNamVaoLam = new System.Windows.Forms.MaskedTextBox();
            this.textBoxThangVaoLam = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Location = new System.Drawing.Point(300, 338);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonHuy.TabIndex = 64;
            this.ButtonHuy.Text = "Hủy";
            this.ButtonHuy.UseVisualStyleBackColor = true;
            this.ButtonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // ButtonApDung
            // 
            this.ButtonApDung.Location = new System.Drawing.Point(393, 338);
            this.ButtonApDung.Name = "ButtonApDung";
            this.ButtonApDung.Size = new System.Drawing.Size(75, 23);
            this.ButtonApDung.TabIndex = 63;
            this.ButtonApDung.Text = "Áp Dụng";
            this.ButtonApDung.UseVisualStyleBackColor = true;
            this.ButtonApDung.Click += new System.EventHandler(this.ButtonApDung_Click);
            // 
            // TextBoxMaNhanVien
            // 
            this.TextBoxMaNhanVien.Location = new System.Drawing.Point(111, 23);
            this.TextBoxMaNhanVien.Name = "TextBoxMaNhanVien";
            this.TextBoxMaNhanVien.ReadOnly = true;
            this.TextBoxMaNhanVien.Size = new System.Drawing.Size(231, 20);
            this.TextBoxMaNhanVien.TabIndex = 62;
            // 
            // TextBoxTenNhanVien
            // 
            this.TextBoxTenNhanVien.Location = new System.Drawing.Point(111, 55);
            this.TextBoxTenNhanVien.Name = "TextBoxTenNhanVien";
            this.TextBoxTenNhanVien.Size = new System.Drawing.Size(231, 20);
            this.TextBoxTenNhanVien.TabIndex = 60;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(111, 87);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(231, 20);
            this.TextBoxEmail.TabIndex = 59;
            // 
            // TextBoxDienThoai
            // 
            this.TextBoxDienThoai.Location = new System.Drawing.Point(111, 119);
            this.TextBoxDienThoai.Name = "TextBoxDienThoai";
            this.TextBoxDienThoai.Size = new System.Drawing.Size(231, 20);
            this.TextBoxDienThoai.TabIndex = 57;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 23);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(78, 13);
            this.Label.TabIndex = 52;
            this.Label.Text = "Mã Nhân Viên:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "Tên Nhân Viên";
            // 
            // LabelMaSanPham
            // 
            this.LabelMaSanPham.AutoSize = true;
            this.LabelMaSanPham.Location = new System.Drawing.Point(12, 87);
            this.LabelMaSanPham.Name = "LabelMaSanPham";
            this.LabelMaSanPham.Size = new System.Drawing.Size(35, 13);
            this.LabelMaSanPham.TabIndex = 49;
            this.LabelMaSanPham.Text = "Email:";
            // 
            // LabelDongGoi
            // 
            this.LabelDongGoi.AutoSize = true;
            this.LabelDongGoi.Location = new System.Drawing.Point(12, 119);
            this.LabelDongGoi.Name = "LabelDongGoi";
            this.LabelDongGoi.Size = new System.Drawing.Size(62, 13);
            this.LabelDongGoi.TabIndex = 45;
            this.LabelDongGoi.Text = "Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày Vào Làm:";
            // 
            // textBoxNgayVaoLam
            // 
            this.textBoxNgayVaoLam.Location = new System.Drawing.Point(149, 195);
            this.textBoxNgayVaoLam.Name = "textBoxNgayVaoLam";
            this.textBoxNgayVaoLam.Size = new System.Drawing.Size(30, 20);
            this.textBoxNgayVaoLam.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Lương:";
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Location = new System.Drawing.Point(111, 237);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(46, 20);
            this.textBoxLuong.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "/Tháng";
            // 
            // buttonDoiMatKhau
            // 
            this.buttonDoiMatKhau.Location = new System.Drawing.Point(15, 285);
            this.buttonDoiMatKhau.Name = "buttonDoiMatKhau";
            this.buttonDoiMatKhau.Size = new System.Drawing.Size(91, 23);
            this.buttonDoiMatKhau.TabIndex = 72;
            this.buttonDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.buttonDoiMatKhau.UseVisualStyleBackColor = true;
            this.buttonDoiMatKhau.Click += new System.EventHandler(this.buttonDoiMatKhau_Click);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(111, 162);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(68, 21);
            this.comboBoxGioiTinh.TabIndex = 73;
            // 
            // textBoxNamVaoLam
            // 
            this.textBoxNamVaoLam.Location = new System.Drawing.Point(335, 195);
            this.textBoxNamVaoLam.Name = "textBoxNamVaoLam";
            this.textBoxNamVaoLam.Size = new System.Drawing.Size(51, 20);
            this.textBoxNamVaoLam.TabIndex = 74;
            // 
            // textBoxThangVaoLam
            // 
            this.textBoxThangVaoLam.Location = new System.Drawing.Point(245, 195);
            this.textBoxThangVaoLam.Name = "textBoxThangVaoLam";
            this.textBoxThangVaoLam.Size = new System.Drawing.Size(30, 20);
            this.textBoxThangVaoLam.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Năm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Tháng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Ngày:";
            // 
            // ChangeInformationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 373);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxThangVaoLam);
            this.Controls.Add(this.textBoxNamVaoLam);
            this.Controls.Add(this.comboBoxGioiTinh);
            this.Controls.Add(this.buttonDoiMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNgayVaoLam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonHuy);
            this.Controls.Add(this.ButtonApDung);
            this.Controls.Add(this.TextBoxMaNhanVien);
            this.Controls.Add(this.TextBoxTenNhanVien);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxDienThoai);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelMaSanPham);
            this.Controls.Add(this.LabelDongGoi);
            this.Name = "ChangeInformationManager";
            this.Text = "ChangeInformationManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonHuy;
        private System.Windows.Forms.Button ButtonApDung;
        private System.Windows.Forms.TextBox TextBoxMaNhanVien;
        private System.Windows.Forms.TextBox TextBoxTenNhanVien;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxDienThoai;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelMaSanPham;
        private System.Windows.Forms.Label LabelDongGoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox textBoxNgayVaoLam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textBoxLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDoiMatKhau;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.MaskedTextBox textBoxNamVaoLam;
        private System.Windows.Forms.MaskedTextBox textBoxThangVaoLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}