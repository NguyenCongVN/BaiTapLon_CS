namespace BaiTapLon_CS.Forms
{
    partial class ShowTheImportHistoryForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxThangNhap = new System.Windows.Forms.TextBox();
            this.TextBoxNamNhap = new System.Windows.Forms.TextBox();
            this.TextBoxNgayNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMaNhap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNguoiNhap = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Năm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Tháng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Ngày";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxThangNhap
            // 
            this.TextBoxThangNhap.Location = new System.Drawing.Point(297, 73);
            this.TextBoxThangNhap.Name = "TextBoxThangNhap";
            this.TextBoxThangNhap.ReadOnly = true;
            this.TextBoxThangNhap.Size = new System.Drawing.Size(23, 20);
            this.TextBoxThangNhap.TabIndex = 68;
            // 
            // TextBoxNamNhap
            // 
            this.TextBoxNamNhap.Location = new System.Drawing.Point(361, 76);
            this.TextBoxNamNhap.Name = "TextBoxNamNhap";
            this.TextBoxNamNhap.ReadOnly = true;
            this.TextBoxNamNhap.Size = new System.Drawing.Size(51, 20);
            this.TextBoxNamNhap.TabIndex = 67;
            // 
            // TextBoxNgayNhap
            // 
            this.TextBoxNgayNhap.Location = new System.Drawing.Point(219, 76);
            this.TextBoxNgayNhap.Name = "TextBoxNgayNhap";
            this.TextBoxNgayNhap.ReadOnly = true;
            this.TextBoxNgayNhap.Size = new System.Drawing.Size(23, 20);
            this.TextBoxNgayNhap.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Ngày Nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Mã Nhập:";
            // 
            // textBoxMaNhap
            // 
            this.textBoxMaNhap.Location = new System.Drawing.Point(172, 18);
            this.textBoxMaNhap.Name = "textBoxMaNhap";
            this.textBoxMaNhap.ReadOnly = true;
            this.textBoxMaNhap.Size = new System.Drawing.Size(42, 20);
            this.textBoxMaNhap.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Người Nhập:";
            // 
            // textBoxNguoiNhap
            // 
            this.textBoxNguoiNhap.Location = new System.Drawing.Point(172, 50);
            this.textBoxNguoiNhap.Name = "textBoxNguoiNhap";
            this.textBoxNguoiNhap.ReadOnly = true;
            this.textBoxNguoiNhap.Size = new System.Drawing.Size(183, 20);
            this.textBoxNguoiNhap.TabIndex = 75;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 276);
            this.listView1.TabIndex = 76;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Thuốc";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày Sản Xuất";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hạn Sử Dụng";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tổng Tiền:";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(172, 115);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(90, 20);
            this.textBoxTongTien.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Bao Gồm :";
            // 
            // ShowTheImportHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxNguoiNhap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxMaNhap);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextBoxThangNhap);
            this.Controls.Add(this.TextBoxNamNhap);
            this.Controls.Add(this.TextBoxNgayNhap);
            this.Controls.Add(this.label7);
            this.Name = "ShowTheImportHistoryForm";
            this.Text = "ShowTheImportHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxThangNhap;
        private System.Windows.Forms.TextBox TextBoxNamNhap;
        private System.Windows.Forms.TextBox TextBoxNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMaNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNguoiNhap;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label2;
    }
}