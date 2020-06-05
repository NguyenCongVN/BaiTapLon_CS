namespace BaiTapLon_CS.Forms
{
    partial class ChangeInformationMedicine
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
            this.LabelMaDangKi = new System.Windows.Forms.Label();
            this.LabelGiaThanh = new System.Windows.Forms.Label();
            this.LabelSoLuongTrongMoiGoi = new System.Windows.Forms.Label();
            this.LabelDongGoi = new System.Windows.Forms.Label();
            this.LabelXuatXu = new System.Windows.Forms.Label();
            this.LabelTenSanPham = new System.Windows.Forms.Label();
            this.LabelSoLuongCon = new System.Windows.Forms.Label();
            this.TextBoxMaDangKi = new System.Windows.Forms.TextBox();
            this.TextBoxGiaThanh = new System.Windows.Forms.TextBox();
            this.TextBoxSoLuongTrongMoiGoi = new System.Windows.Forms.TextBox();
            this.TextBoxDongGoi = new System.Windows.Forms.TextBox();
            this.TextBoxXuatXu = new System.Windows.Forms.TextBox();
            this.TextBoxSoLuongCon = new System.Windows.Forms.TextBox();
            this.TextBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.ButtonApDung = new System.Windows.Forms.Button();
            this.ButtonHuy = new System.Windows.Forms.Button();
            this.LabelMaSanPham = new System.Windows.Forms.Label();
            this.TextBoxMaSanPham = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bAITAPLONDataSet = new BaiTapLon_CS.BAITAPLONDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new BaiTapLon_CS.BAITAPLONDataSetTableAdapters.CategoryTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ListImport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMaDangKi
            // 
            this.LabelMaDangKi.AutoSize = true;
            this.LabelMaDangKi.Location = new System.Drawing.Point(37, 424);
            this.LabelMaDangKi.Name = "LabelMaDangKi";
            this.LabelMaDangKi.Size = new System.Drawing.Size(68, 13);
            this.LabelMaDangKi.TabIndex = 16;
            this.LabelMaDangKi.Text = "Mã Đăng Kí:";
            // 
            // LabelGiaThanh
            // 
            this.LabelGiaThanh.AutoSize = true;
            this.LabelGiaThanh.Location = new System.Drawing.Point(37, 371);
            this.LabelGiaThanh.Name = "LabelGiaThanh";
            this.LabelGiaThanh.Size = new System.Drawing.Size(60, 13);
            this.LabelGiaThanh.TabIndex = 15;
            this.LabelGiaThanh.Text = "Giá Thành:";
            // 
            // LabelSoLuongTrongMoiGoi
            // 
            this.LabelSoLuongTrongMoiGoi.AutoSize = true;
            this.LabelSoLuongTrongMoiGoi.Location = new System.Drawing.Point(35, 315);
            this.LabelSoLuongTrongMoiGoi.Name = "LabelSoLuongTrongMoiGoi";
            this.LabelSoLuongTrongMoiGoi.Size = new System.Drawing.Size(119, 13);
            this.LabelSoLuongTrongMoiGoi.TabIndex = 14;
            this.LabelSoLuongTrongMoiGoi.Text = "Số Lượng trong mỗi gói:";
            // 
            // LabelDongGoi
            // 
            this.LabelDongGoi.AutoSize = true;
            this.LabelDongGoi.Location = new System.Drawing.Point(37, 264);
            this.LabelDongGoi.Name = "LabelDongGoi";
            this.LabelDongGoi.Size = new System.Drawing.Size(53, 13);
            this.LabelDongGoi.TabIndex = 13;
            this.LabelDongGoi.Text = "Đóng gói:";
            // 
            // LabelXuatXu
            // 
            this.LabelXuatXu.AutoSize = true;
            this.LabelXuatXu.Location = new System.Drawing.Point(37, 200);
            this.LabelXuatXu.Name = "LabelXuatXu";
            this.LabelXuatXu.Size = new System.Drawing.Size(48, 13);
            this.LabelXuatXu.TabIndex = 11;
            this.LabelXuatXu.Text = "Xuất Xứ:";
            // 
            // LabelTenSanPham
            // 
            this.LabelTenSanPham.AutoSize = true;
            this.LabelTenSanPham.Location = new System.Drawing.Point(32, 87);
            this.LabelTenSanPham.Name = "LabelTenSanPham";
            this.LabelTenSanPham.Size = new System.Drawing.Size(81, 13);
            this.LabelTenSanPham.TabIndex = 18;
            this.LabelTenSanPham.Text = "Tên Sản Phẩm:";
            // 
            // LabelSoLuongCon
            // 
            this.LabelSoLuongCon.AutoSize = true;
            this.LabelSoLuongCon.Location = new System.Drawing.Point(35, 142);
            this.LabelSoLuongCon.Name = "LabelSoLuongCon";
            this.LabelSoLuongCon.Size = new System.Drawing.Size(78, 13);
            this.LabelSoLuongCon.TabIndex = 20;
            this.LabelSoLuongCon.Text = "Số Lượng Còn:";
            // 
            // TextBoxMaDangKi
            // 
            this.TextBoxMaDangKi.Location = new System.Drawing.Point(202, 421);
            this.TextBoxMaDangKi.Name = "TextBoxMaDangKi";
            this.TextBoxMaDangKi.Size = new System.Drawing.Size(231, 20);
            this.TextBoxMaDangKi.TabIndex = 22;
            // 
            // TextBoxGiaThanh
            // 
            this.TextBoxGiaThanh.Location = new System.Drawing.Point(202, 368);
            this.TextBoxGiaThanh.Name = "TextBoxGiaThanh";
            this.TextBoxGiaThanh.Size = new System.Drawing.Size(231, 20);
            this.TextBoxGiaThanh.TabIndex = 23;
            // 
            // TextBoxSoLuongTrongMoiGoi
            // 
            this.TextBoxSoLuongTrongMoiGoi.Location = new System.Drawing.Point(202, 312);
            this.TextBoxSoLuongTrongMoiGoi.Name = "TextBoxSoLuongTrongMoiGoi";
            this.TextBoxSoLuongTrongMoiGoi.Size = new System.Drawing.Size(231, 20);
            this.TextBoxSoLuongTrongMoiGoi.TabIndex = 24;
            // 
            // TextBoxDongGoi
            // 
            this.TextBoxDongGoi.Location = new System.Drawing.Point(202, 261);
            this.TextBoxDongGoi.Name = "TextBoxDongGoi";
            this.TextBoxDongGoi.Size = new System.Drawing.Size(231, 20);
            this.TextBoxDongGoi.TabIndex = 25;
            // 
            // TextBoxXuatXu
            // 
            this.TextBoxXuatXu.Location = new System.Drawing.Point(199, 193);
            this.TextBoxXuatXu.Name = "TextBoxXuatXu";
            this.TextBoxXuatXu.Size = new System.Drawing.Size(231, 20);
            this.TextBoxXuatXu.TabIndex = 27;
            // 
            // TextBoxSoLuongCon
            // 
            this.TextBoxSoLuongCon.Location = new System.Drawing.Point(202, 139);
            this.TextBoxSoLuongCon.Name = "TextBoxSoLuongCon";
            this.TextBoxSoLuongCon.ReadOnly = true;
            this.TextBoxSoLuongCon.Size = new System.Drawing.Size(231, 20);
            this.TextBoxSoLuongCon.TabIndex = 28;
            // 
            // TextBoxTenSanPham
            // 
            this.TextBoxTenSanPham.Location = new System.Drawing.Point(199, 87);
            this.TextBoxTenSanPham.Name = "TextBoxTenSanPham";
            this.TextBoxTenSanPham.Size = new System.Drawing.Size(231, 20);
            this.TextBoxTenSanPham.TabIndex = 30;
            // 
            // ButtonApDung
            // 
            this.ButtonApDung.Location = new System.Drawing.Point(888, 537);
            this.ButtonApDung.Name = "ButtonApDung";
            this.ButtonApDung.Size = new System.Drawing.Size(75, 23);
            this.ButtonApDung.TabIndex = 31;
            this.ButtonApDung.Text = "Áp Dụng";
            this.ButtonApDung.UseVisualStyleBackColor = true;
            this.ButtonApDung.Click += new System.EventHandler(this.ButtonApDung_Click);
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Location = new System.Drawing.Point(784, 537);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonHuy.TabIndex = 32;
            this.ButtonHuy.Text = "Hủy";
            this.ButtonHuy.UseVisualStyleBackColor = true;
            this.ButtonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // LabelMaSanPham
            // 
            this.LabelMaSanPham.AutoSize = true;
            this.LabelMaSanPham.Location = new System.Drawing.Point(32, 44);
            this.LabelMaSanPham.Name = "LabelMaSanPham";
            this.LabelMaSanPham.Size = new System.Drawing.Size(77, 13);
            this.LabelMaSanPham.TabIndex = 17;
            this.LabelMaSanPham.Text = "Mã Sản Phẩm:";
            // 
            // TextBoxMaSanPham
            // 
            this.TextBoxMaSanPham.Location = new System.Drawing.Point(202, 44);
            this.TextBoxMaSanPham.Name = "TextBoxMaSanPham";
            this.TextBoxMaSanPham.Size = new System.Drawing.Size(231, 20);
            this.TextBoxMaSanPham.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Loại";
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
            // ListImport
            // 
            this.ListImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListImport.FullRowSelect = true;
            this.ListImport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListImport.HideSelection = false;
            this.ListImport.Location = new System.Drawing.Point(452, 44);
            this.ListImport.Name = "ListImport";
            this.ListImport.Size = new System.Drawing.Size(511, 468);
            this.ListImport.TabIndex = 58;
            this.ListImport.UseCompatibleStateImageBehavior = false;
            this.ListImport.View = System.Windows.Forms.View.Details;
            this.ListImport.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListImport_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày Nhập";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sản Xuất";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hạn Sử Dụng";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // ChangeInformationMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 572);
            this.Controls.Add(this.ListImport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ButtonHuy);
            this.Controls.Add(this.ButtonApDung);
            this.Controls.Add(this.TextBoxTenSanPham);
            this.Controls.Add(this.TextBoxSoLuongCon);
            this.Controls.Add(this.TextBoxXuatXu);
            this.Controls.Add(this.TextBoxDongGoi);
            this.Controls.Add(this.TextBoxSoLuongTrongMoiGoi);
            this.Controls.Add(this.TextBoxGiaThanh);
            this.Controls.Add(this.TextBoxMaDangKi);
            this.Controls.Add(this.TextBoxMaSanPham);
            this.Controls.Add(this.LabelSoLuongCon);
            this.Controls.Add(this.LabelTenSanPham);
            this.Controls.Add(this.LabelMaSanPham);
            this.Controls.Add(this.LabelMaDangKi);
            this.Controls.Add(this.LabelGiaThanh);
            this.Controls.Add(this.LabelSoLuongTrongMoiGoi);
            this.Controls.Add(this.LabelDongGoi);
            this.Controls.Add(this.LabelXuatXu);
            this.Name = "ChangeInformationMedicine";
            this.Text = "ChangeInformationMedicine";
            this.Load += new System.EventHandler(this.ChangeInformationMedicine_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeInformationMedicine_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.bAITAPLONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMaDangKi;
        private System.Windows.Forms.Label LabelGiaThanh;
        private System.Windows.Forms.Label LabelSoLuongTrongMoiGoi;
        private System.Windows.Forms.Label LabelDongGoi;
        private System.Windows.Forms.Label LabelXuatXu;
        private System.Windows.Forms.Label LabelTenSanPham;
        private System.Windows.Forms.Label LabelSoLuongCon;
        private System.Windows.Forms.TextBox TextBoxMaDangKi;
        private System.Windows.Forms.TextBox TextBoxGiaThanh;
        private System.Windows.Forms.TextBox TextBoxSoLuongTrongMoiGoi;
        private System.Windows.Forms.TextBox TextBoxDongGoi;
        private System.Windows.Forms.TextBox TextBoxXuatXu;
        private System.Windows.Forms.TextBox TextBoxSoLuongCon;
        private System.Windows.Forms.TextBox TextBoxTenSanPham;
        private System.Windows.Forms.Button ButtonApDung;
        private System.Windows.Forms.Button ButtonHuy;
        private System.Windows.Forms.Label LabelMaSanPham;
        private System.Windows.Forms.TextBox TextBoxMaSanPham;
        private System.Windows.Forms.Label label11;
        private BAITAPLONDataSet bAITAPLONDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private BAITAPLONDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.ListView ListImport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}