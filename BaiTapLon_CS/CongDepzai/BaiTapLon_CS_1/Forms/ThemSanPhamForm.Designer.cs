namespace BaiTapLon_CS.Forms
{
    partial class ThemSanPhamForm
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
            this.components = new System.ComponentModel.Container();
            this.ButtonHuy = new System.Windows.Forms.Button();
            this.ButtonThem = new System.Windows.Forms.Button();
            this.TextBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.TextBoxXuatXu = new System.Windows.Forms.TextBox();
            this.TextBoxDongGoi = new System.Windows.Forms.TextBox();
            this.TextBoxSoLuongTrongMoiGoi = new System.Windows.Forms.TextBox();
            this.TextBoxGiaThanh = new System.Windows.Forms.TextBox();
            this.TextBoxMaDangKi = new System.Windows.Forms.TextBox();
            this.LabelTenSanPham = new System.Windows.Forms.Label();
            this.LabelMaDangKi = new System.Windows.Forms.Label();
            this.LabelGiaThanh = new System.Windows.Forms.Label();
            this.LabelSoLuongTrongMoiGoi = new System.Windows.Forms.Label();
            this.LabelDongGoi = new System.Windows.Forms.Label();
            this.LabelXuatXu = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxLoaiHang = new System.Windows.Forms.ComboBox();
            this.ButtonThemLoaiHang = new System.Windows.Forms.Button();
            this.bAITAPLONDataSet = new BaiTapLon_CS.BAITAPLONDataSet();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new BaiTapLon_CS.BAITAPLONDataSetTableAdapters.CategoryTableAdapter();
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Location = new System.Drawing.Point(600, 407);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonHuy.TabIndex = 64;
            this.ButtonHuy.Text = "Hủy";
            this.ButtonHuy.UseVisualStyleBackColor = true;
            this.ButtonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // ButtonThem
            // 
            this.ButtonThem.Location = new System.Drawing.Point(694, 407);
            this.ButtonThem.Name = "ButtonThem";
            this.ButtonThem.Size = new System.Drawing.Size(75, 23);
            this.ButtonThem.TabIndex = 63;
            this.ButtonThem.Text = "Thêm";
            this.ButtonThem.UseVisualStyleBackColor = true;
            this.ButtonThem.Click += new System.EventHandler(this.ButtonThem_Click);
            // 
            // TextBoxTenSanPham
            // 
            this.TextBoxTenSanPham.Location = new System.Drawing.Point(201, 64);
            this.TextBoxTenSanPham.Name = "TextBoxTenSanPham";
            this.TextBoxTenSanPham.Size = new System.Drawing.Size(231, 20);
            this.TextBoxTenSanPham.TabIndex = 62;
            // 
            // TextBoxXuatXu
            // 
            this.TextBoxXuatXu.Location = new System.Drawing.Point(201, 113);
            this.TextBoxXuatXu.Name = "TextBoxXuatXu";
            this.TextBoxXuatXu.Size = new System.Drawing.Size(231, 20);
            this.TextBoxXuatXu.TabIndex = 59;
            // 
            // TextBoxDongGoi
            // 
            this.TextBoxDongGoi.Location = new System.Drawing.Point(201, 171);
            this.TextBoxDongGoi.Name = "TextBoxDongGoi";
            this.TextBoxDongGoi.Size = new System.Drawing.Size(231, 20);
            this.TextBoxDongGoi.TabIndex = 57;
            // 
            // TextBoxSoLuongTrongMoiGoi
            // 
            this.TextBoxSoLuongTrongMoiGoi.Location = new System.Drawing.Point(201, 229);
            this.TextBoxSoLuongTrongMoiGoi.Name = "TextBoxSoLuongTrongMoiGoi";
            this.TextBoxSoLuongTrongMoiGoi.Size = new System.Drawing.Size(231, 20);
            this.TextBoxSoLuongTrongMoiGoi.TabIndex = 56;
            // 
            // TextBoxGiaThanh
            // 
            this.TextBoxGiaThanh.Location = new System.Drawing.Point(201, 283);
            this.TextBoxGiaThanh.Name = "TextBoxGiaThanh";
            this.TextBoxGiaThanh.Size = new System.Drawing.Size(231, 20);
            this.TextBoxGiaThanh.TabIndex = 55;
            // 
            // TextBoxMaDangKi
            // 
            this.TextBoxMaDangKi.Location = new System.Drawing.Point(201, 337);
            this.TextBoxMaDangKi.Name = "TextBoxMaDangKi";
            this.TextBoxMaDangKi.Size = new System.Drawing.Size(231, 20);
            this.TextBoxMaDangKi.TabIndex = 54;
            // 
            // LabelTenSanPham
            // 
            this.LabelTenSanPham.AutoSize = true;
            this.LabelTenSanPham.Location = new System.Drawing.Point(34, 67);
            this.LabelTenSanPham.Name = "LabelTenSanPham";
            this.LabelTenSanPham.Size = new System.Drawing.Size(81, 13);
            this.LabelTenSanPham.TabIndex = 50;
            this.LabelTenSanPham.Text = "Tên Sản Phẩm:";
            // 
            // LabelMaDangKi
            // 
            this.LabelMaDangKi.AutoSize = true;
            this.LabelMaDangKi.Location = new System.Drawing.Point(47, 340);
            this.LabelMaDangKi.Name = "LabelMaDangKi";
            this.LabelMaDangKi.Size = new System.Drawing.Size(68, 13);
            this.LabelMaDangKi.TabIndex = 48;
            this.LabelMaDangKi.Text = "Mã Đăng Kí:";
            // 
            // LabelGiaThanh
            // 
            this.LabelGiaThanh.AutoSize = true;
            this.LabelGiaThanh.Location = new System.Drawing.Point(43, 286);
            this.LabelGiaThanh.Name = "LabelGiaThanh";
            this.LabelGiaThanh.Size = new System.Drawing.Size(60, 13);
            this.LabelGiaThanh.TabIndex = 47;
            this.LabelGiaThanh.Text = "Giá Thành:";
            // 
            // LabelSoLuongTrongMoiGoi
            // 
            this.LabelSoLuongTrongMoiGoi.AutoSize = true;
            this.LabelSoLuongTrongMoiGoi.Location = new System.Drawing.Point(43, 232);
            this.LabelSoLuongTrongMoiGoi.Name = "LabelSoLuongTrongMoiGoi";
            this.LabelSoLuongTrongMoiGoi.Size = new System.Drawing.Size(119, 13);
            this.LabelSoLuongTrongMoiGoi.TabIndex = 46;
            this.LabelSoLuongTrongMoiGoi.Text = "Số Lượng trong mỗi gói:";
            // 
            // LabelDongGoi
            // 
            this.LabelDongGoi.AutoSize = true;
            this.LabelDongGoi.Location = new System.Drawing.Point(43, 174);
            this.LabelDongGoi.Name = "LabelDongGoi";
            this.LabelDongGoi.Size = new System.Drawing.Size(53, 13);
            this.LabelDongGoi.TabIndex = 45;
            this.LabelDongGoi.Text = "Đóng gói:";
            // 
            // LabelXuatXu
            // 
            this.LabelXuatXu.AutoSize = true;
            this.LabelXuatXu.Location = new System.Drawing.Point(43, 120);
            this.LabelXuatXu.Name = "LabelXuatXu";
            this.LabelXuatXu.Size = new System.Drawing.Size(48, 13);
            this.LabelXuatXu.TabIndex = 43;
            this.LabelXuatXu.Text = "Xuất Xứ:";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Loại Hàng";
            // 
            // ComboBoxLoaiHang
            // 
            this.ComboBoxLoaiHang.FormattingEnabled = true;
            this.ComboBoxLoaiHang.Location = new System.Drawing.Point(201, 27);
            this.ComboBoxLoaiHang.Name = "ComboBoxLoaiHang";
            this.ComboBoxLoaiHang.Size = new System.Drawing.Size(132, 21);
            this.ComboBoxLoaiHang.TabIndex = 77;
            // 
            // ButtonThemLoaiHang
            // 
            this.ButtonThemLoaiHang.Location = new System.Drawing.Point(339, 25);
            this.ButtonThemLoaiHang.Name = "ButtonThemLoaiHang";
            this.ButtonThemLoaiHang.Size = new System.Drawing.Size(113, 23);
            this.ButtonThemLoaiHang.TabIndex = 78;
            this.ButtonThemLoaiHang.Text = "Thêm Loại Hàng";
            this.ButtonThemLoaiHang.UseVisualStyleBackColor = true;
            this.ButtonThemLoaiHang.Click += new System.EventHandler(this.ButtonThemLoaiHang_Click);
            // 
            // bAITAPLONDataSet
            // 
            this.bAITAPLONDataSet.DataSetName = "BAITAPLONDataSet";
            this.bAITAPLONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.bAITAPLONDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataMember = "Category";
            this.categoryBindingSource2.DataSource = this.bAITAPLONDataSet;
            // 
            // ThemSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonThemLoaiHang);
            this.Controls.Add(this.ComboBoxLoaiHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonHuy);
            this.Controls.Add(this.ButtonThem);
            this.Controls.Add(this.TextBoxTenSanPham);
            this.Controls.Add(this.TextBoxXuatXu);
            this.Controls.Add(this.TextBoxDongGoi);
            this.Controls.Add(this.TextBoxSoLuongTrongMoiGoi);
            this.Controls.Add(this.TextBoxGiaThanh);
            this.Controls.Add(this.TextBoxMaDangKi);
            this.Controls.Add(this.LabelTenSanPham);
            this.Controls.Add(this.LabelMaDangKi);
            this.Controls.Add(this.LabelGiaThanh);
            this.Controls.Add(this.LabelSoLuongTrongMoiGoi);
            this.Controls.Add(this.LabelDongGoi);
            this.Controls.Add(this.LabelXuatXu);
            this.Name = "ThemSanPhamForm";
            this.Text = "ThemSanPhamForm";
            this.Load += new System.EventHandler(this.ThemSanPhamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonHuy;
        private System.Windows.Forms.Button ButtonThem;
        private System.Windows.Forms.TextBox TextBoxTenSanPham;
        private System.Windows.Forms.TextBox TextBoxXuatXu;
        private System.Windows.Forms.TextBox TextBoxDongGoi;
        private System.Windows.Forms.TextBox TextBoxSoLuongTrongMoiGoi;
        private System.Windows.Forms.TextBox TextBoxGiaThanh;
        private System.Windows.Forms.TextBox TextBoxMaDangKi;
        private System.Windows.Forms.Label LabelTenSanPham;
        private System.Windows.Forms.Label LabelMaDangKi;
        private System.Windows.Forms.Label LabelGiaThanh;
        private System.Windows.Forms.Label LabelSoLuongTrongMoiGoi;
        private System.Windows.Forms.Label LabelDongGoi;
        private System.Windows.Forms.Label LabelXuatXu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private BAITAPLONDataSet bAITAPLONDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private BAITAPLONDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox ComboBoxLoaiHang;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private System.Windows.Forms.Button ButtonThemLoaiHang;
    }
}