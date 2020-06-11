namespace BaiTapLon_CS.Forms
{
    partial class NhapHang
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxTimKiem = new System.Windows.Forms.TextBox();
            this.ComboBoxChonLoai = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAITAPLONDataSet = new BaiTapLon_CS.BAITAPLONDataSet();
            this.ListShow = new System.Windows.Forms.ListView();
            this.BoxStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoxSl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListNhapHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonXacNhan = new System.Windows.Forms.Button();
            this.ButtonHuy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxThangSanXuat = new System.Windows.Forms.TextBox();
            this.TextBoxNamSanXuat = new System.Windows.Forms.TextBox();
            this.TextBoxSoLuongCon = new System.Windows.Forms.TextBox();
            this.TextBoxXuatXu = new System.Windows.Forms.TextBox();
            this.TextBoxNgaySanXuat = new System.Windows.Forms.TextBox();
            this.LabelSoLuongCon = new System.Windows.Forms.Label();
            this.LabelNgaySanXuat = new System.Windows.Forms.Label();
            this.LabelXuatXu = new System.Windows.Forms.Label();
            this.ButtonThemVaoDanhSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new BaiTapLon_CS.BAITAPLONDataSetTableAdapters.CategoryTableAdapter();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxCongty = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAITAPLONDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new BaiTapLon_CS.BAITAPLONDataSetTableAdapters.ManufacturerTableAdapter();
            this.buttonThemCongTy = new System.Windows.Forms.Button();
            this.LabelNgayHetHan = new System.Windows.Forms.Label();
            this.TextBoxNgaySuDung = new System.Windows.Forms.TextBox();
            this.TextBoxNamSuDung = new System.Windows.Forms.TextBox();
            this.TextBoxThangSuDung = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Loại Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tìm Kiếm";
            // 
            // TextBoxTimKiem
            // 
            this.TextBoxTimKiem.Location = new System.Drawing.Point(71, 7);
            this.TextBoxTimKiem.Name = "TextBoxTimKiem";
            this.TextBoxTimKiem.Size = new System.Drawing.Size(157, 20);
            this.TextBoxTimKiem.TabIndex = 18;
            // 
            // ComboBoxChonLoai
            // 
            this.ComboBoxChonLoai.DataSource = this.categoryBindingSource;
            this.ComboBoxChonLoai.DisplayMember = "Name_Category";
            this.ComboBoxChonLoai.FormattingEnabled = true;
            this.ComboBoxChonLoai.Location = new System.Drawing.Point(77, 38);
            this.ComboBoxChonLoai.Name = "ComboBoxChonLoai";
            this.ComboBoxChonLoai.Size = new System.Drawing.Size(101, 21);
            this.ComboBoxChonLoai.TabIndex = 17;
            this.ComboBoxChonLoai.ValueMember = "ID_Category";
            this.ComboBoxChonLoai.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChonLoai_SelectedValueChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.bAITAPLONDataSet;
            // 
            // bAITAPLONDataSet
            // 
            this.bAITAPLONDataSet.DataSetName = "BAITAPLONDataSet";
            this.bAITAPLONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListShow
            // 
            this.ListShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BoxStt,
            this.BoxId,
            this.BoxTen,
            this.BoxSl});
            this.ListShow.FullRowSelect = true;
            this.ListShow.GridLines = true;
            this.ListShow.HideSelection = false;
            this.ListShow.Location = new System.Drawing.Point(12, 64);
            this.ListShow.Name = "ListShow";
            this.ListShow.Size = new System.Drawing.Size(312, 250);
            this.ListShow.TabIndex = 16;
            this.ListShow.UseCompatibleStateImageBehavior = false;
            this.ListShow.View = System.Windows.Forms.View.Details;
            this.ListShow.SelectedIndexChanged += new System.EventHandler(this.ListShow_SelectedIndexChanged);
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
            // ListNhapHang
            // 
            this.ListNhapHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListNhapHang.FullRowSelect = true;
            this.ListNhapHang.GridLines = true;
            this.ListNhapHang.HideSelection = false;
            this.ListNhapHang.Location = new System.Drawing.Point(501, 38);
            this.ListNhapHang.Name = "ListNhapHang";
            this.ListNhapHang.Size = new System.Drawing.Size(442, 366);
            this.ListNhapHang.TabIndex = 21;
            this.ListNhapHang.UseCompatibleStateImageBehavior = false;
            this.ListNhapHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Sản Phẩm";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Sản Phẩm";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Hết Hạn";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 136;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(498, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Đang Nhập";
            // 
            // ButtonXacNhan
            // 
            this.ButtonXacNhan.Location = new System.Drawing.Point(877, 440);
            this.ButtonXacNhan.Name = "ButtonXacNhan";
            this.ButtonXacNhan.Size = new System.Drawing.Size(66, 23);
            this.ButtonXacNhan.TabIndex = 23;
            this.ButtonXacNhan.Text = "Xác Nhận";
            this.ButtonXacNhan.UseVisualStyleBackColor = true;
            this.ButtonXacNhan.Click += new System.EventHandler(this.ButtonXacNhan_Click);
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Location = new System.Drawing.Point(788, 440);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(64, 23);
            this.ButtonHuy.TabIndex = 24;
            this.ButtonHuy.Text = "Hủy";
            this.ButtonHuy.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxThangSanXuat
            // 
            this.TextBoxThangSanXuat.Location = new System.Drawing.Point(304, 434);
            this.TextBoxThangSanXuat.Name = "TextBoxThangSanXuat";
            this.TextBoxThangSanXuat.Size = new System.Drawing.Size(24, 20);
            this.TextBoxThangSanXuat.TabIndex = 57;
            // 
            // TextBoxNamSanXuat
            // 
            this.TextBoxNamSanXuat.Location = new System.Drawing.Point(368, 434);
            this.TextBoxNamSanXuat.Name = "TextBoxNamSanXuat";
            this.TextBoxNamSanXuat.Size = new System.Drawing.Size(52, 20);
            this.TextBoxNamSanXuat.TabIndex = 56;
            // 
            // TextBoxSoLuongCon
            // 
            this.TextBoxSoLuongCon.Location = new System.Drawing.Point(188, 367);
            this.TextBoxSoLuongCon.Name = "TextBoxSoLuongCon";
            this.TextBoxSoLuongCon.ReadOnly = true;
            this.TextBoxSoLuongCon.Size = new System.Drawing.Size(232, 20);
            this.TextBoxSoLuongCon.TabIndex = 49;
            // 
            // TextBoxXuatXu
            // 
            this.TextBoxXuatXu.Location = new System.Drawing.Point(188, 406);
            this.TextBoxXuatXu.Name = "TextBoxXuatXu";
            this.TextBoxXuatXu.ReadOnly = true;
            this.TextBoxXuatXu.Size = new System.Drawing.Size(232, 20);
            this.TextBoxXuatXu.TabIndex = 48;
            // 
            // TextBoxNgaySanXuat
            // 
            this.TextBoxNgaySanXuat.Location = new System.Drawing.Point(226, 434);
            this.TextBoxNgaySanXuat.Name = "TextBoxNgaySanXuat";
            this.TextBoxNgaySanXuat.Size = new System.Drawing.Size(24, 20);
            this.TextBoxNgaySanXuat.TabIndex = 47;
            // 
            // LabelSoLuongCon
            // 
            this.LabelSoLuongCon.AutoSize = true;
            this.LabelSoLuongCon.Location = new System.Drawing.Point(21, 367);
            this.LabelSoLuongCon.Name = "LabelSoLuongCon";
            this.LabelSoLuongCon.Size = new System.Drawing.Size(78, 13);
            this.LabelSoLuongCon.TabIndex = 46;
            this.LabelSoLuongCon.Text = "Số Lượng Còn:";
            // 
            // LabelNgaySanXuat
            // 
            this.LabelNgaySanXuat.AutoSize = true;
            this.LabelNgaySanXuat.Location = new System.Drawing.Point(15, 438);
            this.LabelNgaySanXuat.Name = "LabelNgaySanXuat";
            this.LabelNgaySanXuat.Size = new System.Drawing.Size(82, 13);
            this.LabelNgaySanXuat.TabIndex = 44;
            this.LabelNgaySanXuat.Text = "Ngày Sản Xuất:";
            // 
            // LabelXuatXu
            // 
            this.LabelXuatXu.AutoSize = true;
            this.LabelXuatXu.Location = new System.Drawing.Point(18, 406);
            this.LabelXuatXu.Name = "LabelXuatXu";
            this.LabelXuatXu.Size = new System.Drawing.Size(48, 13);
            this.LabelXuatXu.TabIndex = 43;
            this.LabelXuatXu.Text = "Xuất Xứ:";
            // 
            // ButtonThemVaoDanhSach
            // 
            this.ButtonThemVaoDanhSach.Location = new System.Drawing.Point(194, 38);
            this.ButtonThemVaoDanhSach.Name = "ButtonThemVaoDanhSach";
            this.ButtonThemVaoDanhSach.Size = new System.Drawing.Size(130, 23);
            this.ButtonThemVaoDanhSach.TabIndex = 61;
            this.ButtonThemVaoDanhSach.Text = "Thêm vào Danh Sách";
            this.ButtonThemVaoDanhSach.UseVisualStyleBackColor = true;
            this.ButtonThemVaoDanhSach.Click += new System.EventHandler(this.ButtonThemVaoDanhSach_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(368, 211);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoLuong.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Số Lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Công Ty";
            // 
            // ComboBoxCongty
            // 
            this.ComboBoxCongty.DataSource = this.manufacturerBindingSource;
            this.ComboBoxCongty.DisplayMember = "Name_Manufacturer";
            this.ComboBoxCongty.FormattingEnabled = true;
            this.ComboBoxCongty.Location = new System.Drawing.Point(188, 474);
            this.ComboBoxCongty.Name = "ComboBoxCongty";
            this.ComboBoxCongty.Size = new System.Drawing.Size(93, 21);
            this.ComboBoxCongty.TabIndex = 66;
            this.ComboBoxCongty.ValueMember = "ID_Manufacturer";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.bAITAPLONDataSetBindingSource;
            // 
            // bAITAPLONDataSetBindingSource
            // 
            this.bAITAPLONDataSetBindingSource.DataSource = this.bAITAPLONDataSet;
            this.bAITAPLONDataSetBindingSource.Position = 0;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // buttonThemCongTy
            // 
            this.buttonThemCongTy.Location = new System.Drawing.Point(321, 471);
            this.buttonThemCongTy.Name = "buttonThemCongTy";
            this.buttonThemCongTy.Size = new System.Drawing.Size(99, 23);
            this.buttonThemCongTy.TabIndex = 67;
            this.buttonThemCongTy.Text = "Thêm Công Ty";
            this.buttonThemCongTy.UseVisualStyleBackColor = true;
            // 
            // LabelNgayHetHan
            // 
            this.LabelNgayHetHan.AutoSize = true;
            this.LabelNgayHetHan.Location = new System.Drawing.Point(21, 325);
            this.LabelNgayHetHan.Name = "LabelNgayHetHan";
            this.LabelNgayHetHan.Size = new System.Drawing.Size(99, 13);
            this.LabelNgayHetHan.TabIndex = 45;
            this.LabelNgayHetHan.Text = "Thời Hạn Sử Dụng:";
            // 
            // TextBoxNgaySuDung
            // 
            this.TextBoxNgaySuDung.Location = new System.Drawing.Point(188, 322);
            this.TextBoxNgaySuDung.Name = "TextBoxNgaySuDung";
            this.TextBoxNgaySuDung.Size = new System.Drawing.Size(24, 20);
            this.TextBoxNgaySuDung.TabIndex = 50;
            // 
            // TextBoxNamSuDung
            // 
            this.TextBoxNamSuDung.Location = new System.Drawing.Point(331, 325);
            this.TextBoxNamSuDung.Name = "TextBoxNamSuDung";
            this.TextBoxNamSuDung.Size = new System.Drawing.Size(52, 20);
            this.TextBoxNamSuDung.TabIndex = 51;
            // 
            // TextBoxThangSuDung
            // 
            this.TextBoxThangSuDung.Location = new System.Drawing.Point(261, 325);
            this.TextBoxThangSuDung.Name = "TextBoxThangSuDung";
            this.TextBoxThangSuDung.Size = new System.Drawing.Size(24, 20);
            this.TextBoxThangSuDung.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ngày";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Năm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tháng";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IdAdd";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.buttonThemCongTy);
            this.Controls.Add(this.ComboBoxCongty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonThemVaoDanhSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxThangSanXuat);
            this.Controls.Add(this.TextBoxNamSanXuat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxThangSuDung);
            this.Controls.Add(this.TextBoxNamSuDung);
            this.Controls.Add(this.TextBoxNgaySuDung);
            this.Controls.Add(this.TextBoxSoLuongCon);
            this.Controls.Add(this.TextBoxXuatXu);
            this.Controls.Add(this.TextBoxNgaySanXuat);
            this.Controls.Add(this.LabelSoLuongCon);
            this.Controls.Add(this.LabelNgayHetHan);
            this.Controls.Add(this.LabelNgaySanXuat);
            this.Controls.Add(this.LabelXuatXu);
            this.Controls.Add(this.ButtonHuy);
            this.Controls.Add(this.ButtonXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListNhapHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxTimKiem);
            this.Controls.Add(this.ComboBoxChonLoai);
            this.Controls.Add(this.ListShow);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxTimKiem;
        private System.Windows.Forms.ComboBox ComboBoxChonLoai;
        private System.Windows.Forms.ListView ListShow;
        private System.Windows.Forms.ColumnHeader BoxStt;
        private System.Windows.Forms.ColumnHeader BoxId;
        private System.Windows.Forms.ColumnHeader BoxTen;
        private System.Windows.Forms.ColumnHeader BoxSl;
        private System.Windows.Forms.ListView ListNhapHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonXacNhan;
        private System.Windows.Forms.Button ButtonHuy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxThangSanXuat;
        private System.Windows.Forms.TextBox TextBoxNamSanXuat;
        private System.Windows.Forms.TextBox TextBoxSoLuongCon;
        private System.Windows.Forms.TextBox TextBoxXuatXu;
        private System.Windows.Forms.TextBox TextBoxNgaySanXuat;
        private System.Windows.Forms.Label LabelSoLuongCon;
        private System.Windows.Forms.Label LabelNgaySanXuat;
        private System.Windows.Forms.Label LabelXuatXu;
        private System.Windows.Forms.Button ButtonThemVaoDanhSach;
        private System.Windows.Forms.Button button1;
        private BAITAPLONDataSet bAITAPLONDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private BAITAPLONDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboBoxCongty;
        private System.Windows.Forms.BindingSource bAITAPLONDataSetBindingSource;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private BAITAPLONDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.Button buttonThemCongTy;
        private System.Windows.Forms.Label LabelNgayHetHan;
        private System.Windows.Forms.TextBox TextBoxNgaySuDung;
        private System.Windows.Forms.TextBox TextBoxNamSuDung;
        private System.Windows.Forms.TextBox TextBoxThangSuDung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}