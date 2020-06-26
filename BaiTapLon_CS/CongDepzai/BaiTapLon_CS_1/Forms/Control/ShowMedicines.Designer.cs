namespace BaiTapLon_CS.Forms.Control
{
    partial class ShowMedicines
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelSanPham = new System.Windows.Forms.Panel();
            this.labelGiaNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxTimKiem = new System.Windows.Forms.TextBox();
            this.ButtonSuaThongTinHang = new System.Windows.Forms.Button();
            this.ButtonChonAnh = new System.Windows.Forms.Button();
            this.LabelMaDangKi = new System.Windows.Forms.Label();
            this.LabelGiaThanh = new System.Windows.Forms.Label();
            this.LabelSoLuongTrongMoiGoi = new System.Windows.Forms.Label();
            this.LabelDongGoi = new System.Windows.Forms.Label();
            this.LabelNgaySanXuat = new System.Windows.Forms.Label();
            this.LabelXuatXu = new System.Windows.Forms.Label();
            this.ComboBoxChonLoai = new System.Windows.Forms.ComboBox();
            this.ListShow = new System.Windows.Forms.ListView();
            this.BoxStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxSl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxNgayhethan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageShow = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAITAPLONDataSet = new BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.BAITAPLONDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.BAITAPLONDataSetTableAdapters.CategoryTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PanelSanPham.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSanPham
            // 
            this.PanelSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSanPham.Controls.Add(this.labelGiaNhap);
            this.PanelSanPham.Controls.Add(this.panel1);
            this.PanelSanPham.Controls.Add(this.label4);
            this.PanelSanPham.Controls.Add(this.label3);
            this.PanelSanPham.Controls.Add(this.TextBoxTimKiem);
            this.PanelSanPham.Controls.Add(this.ButtonSuaThongTinHang);
            this.PanelSanPham.Controls.Add(this.ButtonChonAnh);
            this.PanelSanPham.Controls.Add(this.LabelMaDangKi);
            this.PanelSanPham.Controls.Add(this.LabelGiaThanh);
            this.PanelSanPham.Controls.Add(this.LabelSoLuongTrongMoiGoi);
            this.PanelSanPham.Controls.Add(this.LabelDongGoi);
            this.PanelSanPham.Controls.Add(this.LabelNgaySanXuat);
            this.PanelSanPham.Controls.Add(this.LabelXuatXu);
            this.PanelSanPham.Controls.Add(this.ComboBoxChonLoai);
            this.PanelSanPham.Controls.Add(this.ListShow);
            this.PanelSanPham.Controls.Add(this.ImageShow);
            this.PanelSanPham.Controls.Add(this.label2);
            this.PanelSanPham.Location = new System.Drawing.Point(0, 0);
            this.PanelSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.PanelSanPham.Name = "PanelSanPham";
            this.PanelSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.PanelSanPham.Size = new System.Drawing.Size(985, 580);
            this.PanelSanPham.TabIndex = 3;
            // 
            // labelGiaNhap
            // 
            this.labelGiaNhap.AutoSize = true;
            this.labelGiaNhap.Location = new System.Drawing.Point(628, 507);
            this.labelGiaNhap.Name = "labelGiaNhap";
            this.labelGiaNhap.Size = new System.Drawing.Size(94, 16);
            this.labelGiaNhap.TabIndex = 17;
            this.labelGiaNhap.Text = "Giá Nhập Kho:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 63);
            this.panel1.TabIndex = 16;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiTapLon_CS.Properties.Resources.icons8_add_property_48px_2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Hàng";
            this.label1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loại Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tìm Kiếm";
            // 
            // TextBoxTimKiem
            // 
            this.TextBoxTimKiem.Location = new System.Drawing.Point(411, 247);
            this.TextBoxTimKiem.Name = "TextBoxTimKiem";
            this.TextBoxTimKiem.Size = new System.Drawing.Size(157, 22);
            this.TextBoxTimKiem.TabIndex = 13;
            this.TextBoxTimKiem.TextChanged += new System.EventHandler(this.TextBoxTimKiem_TextChanged);
            // 
            // ButtonSuaThongTinHang
            // 
            this.ButtonSuaThongTinHang.Location = new System.Drawing.Point(796, 275);
            this.ButtonSuaThongTinHang.Name = "ButtonSuaThongTinHang";
            this.ButtonSuaThongTinHang.Size = new System.Drawing.Size(111, 23);
            this.ButtonSuaThongTinHang.TabIndex = 12;
            this.ButtonSuaThongTinHang.Text = "Sửa Thông Tin";
            this.ButtonSuaThongTinHang.UseVisualStyleBackColor = true;
            this.ButtonSuaThongTinHang.Click += new System.EventHandler(this.ButtonSuaThongTinHang_Click);
            // 
            // ButtonChonAnh
            // 
            this.ButtonChonAnh.Location = new System.Drawing.Point(796, 239);
            this.ButtonChonAnh.Name = "ButtonChonAnh";
            this.ButtonChonAnh.Size = new System.Drawing.Size(79, 23);
            this.ButtonChonAnh.TabIndex = 11;
            this.ButtonChonAnh.Text = "Chọn Ảnh";
            this.ButtonChonAnh.UseVisualStyleBackColor = true;
            this.ButtonChonAnh.Click += new System.EventHandler(this.ButtonChonAnh_Click);
            // 
            // LabelMaDangKi
            // 
            this.LabelMaDangKi.AutoSize = true;
            this.LabelMaDangKi.Location = new System.Drawing.Point(628, 542);
            this.LabelMaDangKi.Name = "LabelMaDangKi";
            this.LabelMaDangKi.Size = new System.Drawing.Size(79, 16);
            this.LabelMaDangKi.TabIndex = 10;
            this.LabelMaDangKi.Text = "Mã Đăng Kí:";
            this.LabelMaDangKi.Click += new System.EventHandler(this.LabelMaDangKi_Click);
            // 
            // LabelGiaThanh
            // 
            this.LabelGiaThanh.AutoSize = true;
            this.LabelGiaThanh.Location = new System.Drawing.Point(628, 473);
            this.LabelGiaThanh.Name = "LabelGiaThanh";
            this.LabelGiaThanh.Size = new System.Drawing.Size(80, 16);
            this.LabelGiaThanh.TabIndex = 9;
            this.LabelGiaThanh.Text = "Giá Bán Ra:";
            // 
            // LabelSoLuongTrongMoiGoi
            // 
            this.LabelSoLuongTrongMoiGoi.AutoSize = true;
            this.LabelSoLuongTrongMoiGoi.Location = new System.Drawing.Point(628, 430);
            this.LabelSoLuongTrongMoiGoi.Name = "LabelSoLuongTrongMoiGoi";
            this.LabelSoLuongTrongMoiGoi.Size = new System.Drawing.Size(148, 16);
            this.LabelSoLuongTrongMoiGoi.TabIndex = 8;
            this.LabelSoLuongTrongMoiGoi.Text = "Số Lượng trong mỗi gói:";
            // 
            // LabelDongGoi
            // 
            this.LabelDongGoi.AutoSize = true;
            this.LabelDongGoi.Location = new System.Drawing.Point(628, 383);
            this.LabelDongGoi.Name = "LabelDongGoi";
            this.LabelDongGoi.Size = new System.Drawing.Size(65, 16);
            this.LabelDongGoi.TabIndex = 7;
            this.LabelDongGoi.Text = "Đóng gói:";
            // 
            // LabelNgaySanXuat
            // 
            this.LabelNgaySanXuat.AutoSize = true;
            this.LabelNgaySanXuat.Location = new System.Drawing.Point(628, 342);
            this.LabelNgaySanXuat.Name = "LabelNgaySanXuat";
            this.LabelNgaySanXuat.Size = new System.Drawing.Size(100, 16);
            this.LabelNgaySanXuat.TabIndex = 6;
            this.LabelNgaySanXuat.Text = "Ngày Sản Xuất:";
            // 
            // LabelXuatXu
            // 
            this.LabelXuatXu.AutoSize = true;
            this.LabelXuatXu.Location = new System.Drawing.Point(628, 305);
            this.LabelXuatXu.Name = "LabelXuatXu";
            this.LabelXuatXu.Size = new System.Drawing.Size(55, 16);
            this.LabelXuatXu.TabIndex = 5;
            this.LabelXuatXu.Text = "Xuất Xứ:";
            // 
            // ComboBoxChonLoai
            // 
            this.ComboBoxChonLoai.FormattingEnabled = true;
            this.ComboBoxChonLoai.Location = new System.Drawing.Point(123, 247);
            this.ComboBoxChonLoai.Name = "ComboBoxChonLoai";
            this.ComboBoxChonLoai.Size = new System.Drawing.Size(152, 24);
            this.ComboBoxChonLoai.TabIndex = 4;
            this.ComboBoxChonLoai.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChonLoai_SelectedIndexChanged);
            // 
            // ListShow
            // 
            this.ListShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BoxStt,
            this.BoxId,
            this.BoxTen,
            this.BoxSl,
            this.BoxNgayhethan});
            this.ListShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListShow.FullRowSelect = true;
            this.ListShow.GridLines = true;
            this.ListShow.HideSelection = false;
            this.ListShow.Location = new System.Drawing.Point(42, 274);
            this.ListShow.Name = "ListShow";
            this.ListShow.Size = new System.Drawing.Size(555, 284);
            this.ListShow.TabIndex = 3;
            this.ListShow.UseCompatibleStateImageBehavior = false;
            this.ListShow.View = System.Windows.Forms.View.Details;
            this.ListShow.SelectedIndexChanged += new System.EventHandler(this.SelectShowList);
            // 
            // BoxStt
            // 
            this.BoxStt.Text = "STT";
            this.BoxStt.Width = 35;
            // 
            // BoxId
            // 
            this.BoxId.Text = "Mã Sản Phẩm";
            this.BoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxId.Width = 82;
            // 
            // BoxTen
            // 
            this.BoxTen.Text = "Tên Sản Phẩm";
            this.BoxTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxTen.Width = 125;
            // 
            // BoxSl
            // 
            this.BoxSl.Text = "Số Lượng";
            this.BoxSl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxSl.Width = 58;
            // 
            // BoxNgayhethan
            // 
            this.BoxNgayhethan.Text = "Ngày Hết Hạn";
            this.BoxNgayhethan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNgayhethan.Width = 136;
            // 
            // ImageShow
            // 
            this.ImageShow.InitialImage = null;
            this.ImageShow.Location = new System.Drawing.Point(622, 163);
            this.ImageShow.Name = "ImageShow";
            this.ImageShow.Size = new System.Drawing.Size(153, 99);
            this.ImageShow.TabIndex = 2;
            this.ImageShow.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Mục Sản Phẩm";
            // 
            // bAITAPLONDataSet
            // 
            this.bAITAPLONDataSet.DataSetName = "BAITAPLONDataSet";
            this.bAITAPLONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.bAITAPLONDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.bAITAPLONDataSet;
            // 
            // ShowMedicines
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PanelSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShowMedicines";
            this.Size = new System.Drawing.Size(985, 580);
            this.PanelSanPham.ResumeLayout(false);
            this.PanelSanPham.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxTimKiem;
        private System.Windows.Forms.Button ButtonSuaThongTinHang;
        private System.Windows.Forms.Button ButtonChonAnh;
        private System.Windows.Forms.Label LabelMaDangKi;
        private System.Windows.Forms.Label LabelGiaThanh;
        private System.Windows.Forms.Label LabelSoLuongTrongMoiGoi;
        private System.Windows.Forms.Label LabelDongGoi;
        private System.Windows.Forms.Label LabelNgaySanXuat;
        private System.Windows.Forms.Label LabelXuatXu;
        private System.Windows.Forms.ComboBox ComboBoxChonLoai;
        private System.Windows.Forms.ListView ListShow;
        private System.Windows.Forms.ColumnHeader BoxStt;
        private System.Windows.Forms.ColumnHeader BoxId;
        private System.Windows.Forms.ColumnHeader BoxTen;
        private System.Windows.Forms.ColumnHeader BoxSl;
        private System.Windows.Forms.ColumnHeader BoxNgayhethan;
        private System.Windows.Forms.PictureBox ImageShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CongDepzai.BaiTapLon_CS_1.BAITAPLONDataSet bAITAPLONDataSet;
        private CongDepzai.BaiTapLon_CS_1.BAITAPLONDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.Label labelGiaNhap;
    }
}
