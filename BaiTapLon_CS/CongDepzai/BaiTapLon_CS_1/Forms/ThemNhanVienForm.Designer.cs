namespace BaiTapLon_CS.Forms
{
    partial class ThemNhanVienForm
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
            this.ButtonThem = new System.Windows.Forms.Button();
            this.TextBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxDienThoai = new System.Windows.Forms.TextBox();
            this.TextBoxMatKhau = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelMaSanPham = new System.Windows.Forms.Label();
            this.LabelDongGoi = new System.Windows.Forms.Label();
            this.LabelXuatXu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Location = new System.Drawing.Point(300, 170);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonHuy.TabIndex = 76;
            this.ButtonHuy.Text = "Hủy";
            this.ButtonHuy.UseVisualStyleBackColor = true;
            this.ButtonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // ButtonThem
            // 
            this.ButtonThem.Location = new System.Drawing.Point(410, 170);
            this.ButtonThem.Name = "ButtonThem";
            this.ButtonThem.Size = new System.Drawing.Size(75, 23);
            this.ButtonThem.TabIndex = 75;
            this.ButtonThem.Text = "Thêm";
            this.ButtonThem.UseVisualStyleBackColor = true;
            this.ButtonThem.Click += new System.EventHandler(this.ButtonThem_Click);
            // 
            // TextBoxTenNhanVien
            // 
            this.TextBoxTenNhanVien.Location = new System.Drawing.Point(128, 27);
            this.TextBoxTenNhanVien.Name = "TextBoxTenNhanVien";
            this.TextBoxTenNhanVien.Size = new System.Drawing.Size(231, 20);
            this.TextBoxTenNhanVien.TabIndex = 73;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(128, 59);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(231, 20);
            this.TextBoxEmail.TabIndex = 72;
            // 
            // TextBoxDienThoai
            // 
            this.TextBoxDienThoai.Location = new System.Drawing.Point(128, 91);
            this.TextBoxDienThoai.Name = "TextBoxDienThoai";
            this.TextBoxDienThoai.Size = new System.Drawing.Size(231, 20);
            this.TextBoxDienThoai.TabIndex = 71;
            // 
            // TextBoxMatKhau
            // 
            this.TextBoxMatKhau.Location = new System.Drawing.Point(128, 123);
            this.TextBoxMatKhau.Name = "TextBoxMatKhau";
            this.TextBoxMatKhau.Size = new System.Drawing.Size(231, 20);
            this.TextBoxMatKhau.TabIndex = 70;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Tên Nhân Viên";
            // 
            // LabelMaSanPham
            // 
            this.LabelMaSanPham.AutoSize = true;
            this.LabelMaSanPham.Location = new System.Drawing.Point(29, 59);
            this.LabelMaSanPham.Name = "LabelMaSanPham";
            this.LabelMaSanPham.Size = new System.Drawing.Size(35, 13);
            this.LabelMaSanPham.TabIndex = 67;
            this.LabelMaSanPham.Text = "Email:";
            // 
            // LabelDongGoi
            // 
            this.LabelDongGoi.AutoSize = true;
            this.LabelDongGoi.Location = new System.Drawing.Point(29, 91);
            this.LabelDongGoi.Name = "LabelDongGoi";
            this.LabelDongGoi.Size = new System.Drawing.Size(62, 13);
            this.LabelDongGoi.TabIndex = 66;
            this.LabelDongGoi.Text = "Điện Thoại:";
            // 
            // LabelXuatXu
            // 
            this.LabelXuatXu.AutoSize = true;
            this.LabelXuatXu.Location = new System.Drawing.Point(29, 123);
            this.LabelXuatXu.Name = "LabelXuatXu";
            this.LabelXuatXu.Size = new System.Drawing.Size(56, 13);
            this.LabelXuatXu.TabIndex = 65;
            this.LabelXuatXu.Text = "Mật Khẩu:";
            // 
            // ThemNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 204);
            this.Controls.Add(this.ButtonHuy);
            this.Controls.Add(this.ButtonThem);
            this.Controls.Add(this.TextBoxTenNhanVien);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxDienThoai);
            this.Controls.Add(this.TextBoxMatKhau);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelMaSanPham);
            this.Controls.Add(this.LabelDongGoi);
            this.Controls.Add(this.LabelXuatXu);
            this.Name = "ThemNhanVienForm";
            this.Text = "ThemNhanVienForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonHuy;
        private System.Windows.Forms.Button ButtonThem;
        private System.Windows.Forms.TextBox TextBoxTenNhanVien;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxDienThoai;
        private System.Windows.Forms.TextBox TextBoxMatKhau;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelMaSanPham;
        private System.Windows.Forms.Label LabelDongGoi;
        private System.Windows.Forms.Label LabelXuatXu;
    }
}