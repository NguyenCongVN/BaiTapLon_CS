namespace BaiTapLon_CS
{
     partial class Analytics
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
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.txtNameProduct = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.button3 = new System.Windows.Forms.Button();
               this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
               this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
               this.label7 = new System.Windows.Forms.Label();
               this.txtAmount_Product = new System.Windows.Forms.TextBox();
               this.txtAmount = new System.Windows.Forms.TextBox();
               this.txtTotal = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.dgvAnalytics = new System.Windows.Forms.DataGridView();
               this.btnCurrent = new System.Windows.Forms.Button();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.cboxManufacturer = new System.Windows.Forms.ComboBox();
               this.label10 = new System.Windows.Forms.Label();
               this.cbCategory = new System.Windows.Forms.ComboBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.btnNext = new System.Windows.Forms.Button();
               this.btnPre = new System.Windows.Forms.Button();
               this.btnExcel = new System.Windows.Forms.Button();
               this.btnAnalytics = new System.Windows.Forms.Button();
               this.btnMonth = new System.Windows.Forms.Button();
               this.btnToday = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).BeginInit();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.LimeGreen;
               this.label1.Location = new System.Drawing.Point(66, 137);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(108, 26);
               this.label1.TabIndex = 0;
               this.label1.Text = "Tìm kiếm";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.ForeColor = System.Drawing.Color.White;
               this.label2.Location = new System.Drawing.Point(181, 145);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(25, 17);
               this.label2.TabIndex = 1;
               this.label2.Text = "Từ";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.ForeColor = System.Drawing.Color.White;
               this.label3.Location = new System.Drawing.Point(473, 144);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(34, 17);
               this.label3.TabIndex = 2;
               this.label3.Text = "Đến";
               // 
               // txtNameProduct
               // 
               this.txtNameProduct.Location = new System.Drawing.Point(222, 298);
               this.txtNameProduct.Multiline = true;
               this.txtNameProduct.Name = "txtNameProduct";
               this.txtNameProduct.Size = new System.Drawing.Size(250, 37);
               this.txtNameProduct.TabIndex = 4;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(797, 387);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(107, 17);
               this.label4.TabIndex = 8;
               this.label4.Text = "Tổng sản phẩm";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.ForeColor = System.Drawing.Color.White;
               this.label5.Location = new System.Drawing.Point(797, 487);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(99, 17);
               this.label5.TabIndex = 9;
               this.label5.Text = "Tổng số lượng";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.ForeColor = System.Drawing.Color.White;
               this.label6.Location = new System.Drawing.Point(805, 578);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(74, 17);
               this.label6.TabIndex = 10;
               this.label6.Text = "Doanh thu";
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
               this.button3.Location = new System.Drawing.Point(1015, 622);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(116, 47);
               this.button3.TabIndex = 11;
               this.button3.Text = "In";
               this.button3.UseVisualStyleBackColor = false;
               // 
               // dateTimeFrom
               // 
               this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.dateTimeFrom.Location = new System.Drawing.Point(222, 139);
               this.dateTimeFrom.Name = "dateTimeFrom";
               this.dateTimeFrom.Size = new System.Drawing.Size(200, 22);
               this.dateTimeFrom.TabIndex = 12;
               this.dateTimeFrom.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
               this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
               // 
               // dateTimeTo
               // 
               this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.dateTimeTo.Location = new System.Drawing.Point(513, 139);
               this.dateTimeTo.Name = "dateTimeTo";
               this.dateTimeTo.Size = new System.Drawing.Size(200, 22);
               this.dateTimeTo.TabIndex = 13;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.Color.White;
               this.label7.Location = new System.Drawing.Point(446, 35);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(338, 40);
               this.label7.TabIndex = 15;
               this.label7.Text = "PHÂN TÍCH BÁN HÀNG";
               // 
               // txtAmount_Product
               // 
               this.txtAmount_Product.ForeColor = System.Drawing.Color.White;
               this.txtAmount_Product.Location = new System.Drawing.Point(984, 371);
               this.txtAmount_Product.Multiline = true;
               this.txtAmount_Product.Name = "txtAmount_Product";
               this.txtAmount_Product.ReadOnly = true;
               this.txtAmount_Product.Size = new System.Drawing.Size(82, 50);
               this.txtAmount_Product.TabIndex = 16;
               // 
               // txtAmount
               // 
               this.txtAmount.ForeColor = System.Drawing.Color.White;
               this.txtAmount.Location = new System.Drawing.Point(984, 454);
               this.txtAmount.Multiline = true;
               this.txtAmount.Name = "txtAmount";
               this.txtAmount.ReadOnly = true;
               this.txtAmount.Size = new System.Drawing.Size(82, 50);
               this.txtAmount.TabIndex = 17;
               // 
               // txtTotal
               // 
               this.txtTotal.ForeColor = System.Drawing.Color.White;
               this.txtTotal.Location = new System.Drawing.Point(984, 545);
               this.txtTotal.Multiline = true;
               this.txtTotal.Name = "txtTotal";
               this.txtTotal.ReadOnly = true;
               this.txtTotal.Size = new System.Drawing.Size(147, 50);
               this.txtTotal.TabIndex = 18;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.ForeColor = System.Drawing.Color.White;
               this.label8.Location = new System.Drawing.Point(68, 318);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(99, 17);
               this.label8.TabIndex = 20;
               this.label8.Text = "Tên sản phẩm";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.ForeColor = System.Drawing.Color.White;
               this.label9.Location = new System.Drawing.Point(68, 195);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(91, 17);
               this.label9.TabIndex = 21;
               this.label9.Text = "Nhà sản xuất";
               // 
               // dgvAnalytics
               // 
               this.dgvAnalytics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvAnalytics.BackgroundColor = System.Drawing.Color.White;
               this.dgvAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvAnalytics.Location = new System.Drawing.Point(51, 371);
               this.dgvAnalytics.Name = "dgvAnalytics";
               this.dgvAnalytics.ReadOnly = true;
               this.dgvAnalytics.RowHeadersWidth = 51;
               this.dgvAnalytics.RowTemplate.Height = 24;
               this.dgvAnalytics.Size = new System.Drawing.Size(632, 224);
               this.dgvAnalytics.TabIndex = 5;
               this.dgvAnalytics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnalytics_CellContentClick);
               // 
               // btnCurrent
               // 
               this.btnCurrent.Enabled = false;
               this.btnCurrent.Location = new System.Drawing.Point(272, 628);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(52, 41);
               this.btnCurrent.TabIndex = 24;
               this.btnCurrent.UseVisualStyleBackColor = true;
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.Location = new System.Drawing.Point(414, 628);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(75, 41);
               this.btnTotalPage.TabIndex = 26;
               this.btnTotalPage.UseVisualStyleBackColor = true;
               // 
               // cboxManufacturer
               // 
               this.cboxManufacturer.FormattingEnabled = true;
               this.cboxManufacturer.Items.AddRange(new object[] {
            "Công ty TNHH Traphaco Thanh Hóa",
            "Công ty Thuốc Hà Nội",
            "Công ty cổ phần dược Hà Nội"});
               this.cboxManufacturer.Location = new System.Drawing.Point(222, 192);
               this.cboxManufacturer.Name = "cboxManufacturer";
               this.cboxManufacturer.Size = new System.Drawing.Size(250, 24);
               this.cboxManufacturer.TabIndex = 27;
               this.cboxManufacturer.Text = "Nhà sản xuất";
               this.cboxManufacturer.SelectedIndexChanged += new System.EventHandler(this.cboxManufacturer_SelectedIndexChanged);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.ForeColor = System.Drawing.Color.White;
               this.label10.Location = new System.Drawing.Point(68, 257);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(72, 17);
               this.label10.TabIndex = 28;
               this.label10.Text = "Danh mục";
               // 
               // cbCategory
               // 
               this.cbCategory.Enabled = false;
               this.cbCategory.FormattingEnabled = true;
               this.cbCategory.Items.AddRange(new object[] {
            "Công ty TNHH Traphaco Thanh Hóa",
            "Công ty Thuốc Hà Nội",
            "Công ty cổ phần dược Hà Nội"});
               this.cbCategory.Location = new System.Drawing.Point(222, 250);
               this.cbCategory.Name = "cbCategory";
               this.cbCategory.Size = new System.Drawing.Size(250, 24);
               this.cbCategory.TabIndex = 29;
               this.cbCategory.Text = "Danh mục";
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
               this.panel1.Controls.Add(this.label7);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1254, 91);
               this.panel1.TabIndex = 30;
               // 
               // btnNext
               // 
               this.btnNext.FlatAppearance.BorderSize = 0;
               this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnNext.Image = global::BaiTapLon_CS.Properties.Resources.next2;
               this.btnNext.Location = new System.Drawing.Point(341, 628);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(50, 41);
               this.btnNext.TabIndex = 25;
               this.btnNext.UseVisualStyleBackColor = true;
               this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
               // 
               // btnPre
               // 
               this.btnPre.FlatAppearance.BorderSize = 0;
               this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnPre.Image = global::BaiTapLon_CS.Properties.Resources.previous;
               this.btnPre.Location = new System.Drawing.Point(184, 628);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(44, 41);
               this.btnPre.TabIndex = 23;
               this.btnPre.UseVisualStyleBackColor = true;
               this.btnPre.Click += new System.EventHandler(this.button1_Click);
               // 
               // btnExcel
               // 
               this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
               this.btnExcel.Image = global::BaiTapLon_CS.Properties.Resources.Export_To_File_icon;
               this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnExcel.Location = new System.Drawing.Point(808, 622);
               this.btnExcel.Name = "btnExcel";
               this.btnExcel.Size = new System.Drawing.Size(134, 47);
               this.btnExcel.TabIndex = 22;
               this.btnExcel.Text = "Xuất Excel";
               this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnExcel.UseVisualStyleBackColor = false;
               this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
               // 
               // btnAnalytics
               // 
               this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnAnalytics.Image = global::BaiTapLon_CS.Properties.Resources.analyist1;
               this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnAnalytics.Location = new System.Drawing.Point(668, 278);
               this.btnAnalytics.Name = "btnAnalytics";
               this.btnAnalytics.Size = new System.Drawing.Size(116, 54);
               this.btnAnalytics.TabIndex = 14;
               this.btnAnalytics.Text = "Thống kê";
               this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnAnalytics.UseVisualStyleBackColor = true;
               this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
               // 
               // btnMonth
               // 
               this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnMonth.Image = global::BaiTapLon_CS.Properties.Resources.month;
               this.btnMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnMonth.Location = new System.Drawing.Point(984, 278);
               this.btnMonth.Name = "btnMonth";
               this.btnMonth.Size = new System.Drawing.Size(147, 54);
               this.btnMonth.TabIndex = 7;
               this.btnMonth.Text = "Tháng này";
               this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnMonth.UseVisualStyleBackColor = true;
               this.btnMonth.Click += new System.EventHandler(this.btnWeek_Click);
               // 
               // btnToday
               // 
               this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnToday.Image = global::BaiTapLon_CS.Properties.Resources.today;
               this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnToday.Location = new System.Drawing.Point(825, 278);
               this.btnToday.Name = "btnToday";
               this.btnToday.Size = new System.Drawing.Size(127, 54);
               this.btnToday.TabIndex = 6;
               this.btnToday.Text = "Hôm nay";
               this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnToday.UseVisualStyleBackColor = true;
               this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
               // 
               // Analytics
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
               this.ClientSize = new System.Drawing.Size(1254, 725);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.cbCategory);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.cboxManufacturer);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.btnExcel);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.txtTotal);
               this.Controls.Add(this.txtAmount);
               this.Controls.Add(this.txtAmount_Product);
               this.Controls.Add(this.btnAnalytics);
               this.Controls.Add(this.dateTimeTo);
               this.Controls.Add(this.dateTimeFrom);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.btnMonth);
               this.Controls.Add(this.btnToday);
               this.Controls.Add(this.dgvAnalytics);
               this.Controls.Add(this.txtNameProduct);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.ForeColor = System.Drawing.Color.White;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Analytics";
               this.Text = "Analytics";
               ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount_Product;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAnalytics;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnTotalPage;
        private System.Windows.Forms.ComboBox cboxManufacturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel1;
    }
}