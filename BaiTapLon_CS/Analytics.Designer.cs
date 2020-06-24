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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.txtNameProduct = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.txtAmount_Product = new System.Windows.Forms.TextBox();
               this.txtAmount = new System.Windows.Forms.TextBox();
               this.txtTotal = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.cboxManufacturer = new System.Windows.Forms.ComboBox();
               this.label10 = new System.Windows.Forms.Label();
               this.cbCategory = new System.Windows.Forms.ComboBox();
               this.dateTimeFrom = new Bunifu.Framework.UI.BunifuDatepicker();
               this.dateTimeTo = new Bunifu.Framework.UI.BunifuDatepicker();
               this.dgvAnalytics = new System.Windows.Forms.DataGridView();
               this.panel1 = new System.Windows.Forms.Panel();
               this.btnPre = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
               this.btnAnalytics = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnToday = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnMonth = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.btnCurrent = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).BeginInit();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.LimeGreen;
               this.label1.Location = new System.Drawing.Point(127, 162);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(127, 26);
               this.label1.TabIndex = 0;
               this.label1.Text = "Tìm kiếm :";
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
               this.txtNameProduct.Location = new System.Drawing.Point(293, 387);
               this.txtNameProduct.Multiline = true;
               this.txtNameProduct.Name = "txtNameProduct";
               this.txtNameProduct.Size = new System.Drawing.Size(250, 37);
               this.txtNameProduct.TabIndex = 4;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.SteelBlue;
               this.label4.Location = new System.Drawing.Point(822, 465);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(137, 30);
               this.label4.TabIndex = 8;
               this.label4.Text = "Tổng sản phẩm";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.SteelBlue;
               this.label5.Location = new System.Drawing.Point(822, 548);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(127, 30);
               this.label5.TabIndex = 9;
               this.label5.Text = "Tổng số lượng";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.SteelBlue;
               this.label6.Location = new System.Drawing.Point(822, 629);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(95, 30);
               this.label6.TabIndex = 10;
               this.label6.Text = "Doanh thu";
               // 
               // txtAmount_Product
               // 
               this.txtAmount_Product.BackColor = System.Drawing.Color.White;
               this.txtAmount_Product.ForeColor = System.Drawing.Color.Black;
               this.txtAmount_Product.Location = new System.Drawing.Point(1003, 445);
               this.txtAmount_Product.Multiline = true;
               this.txtAmount_Product.Name = "txtAmount_Product";
               this.txtAmount_Product.ReadOnly = true;
               this.txtAmount_Product.Size = new System.Drawing.Size(57, 50);
               this.txtAmount_Product.TabIndex = 16;
               // 
               // txtAmount
               // 
               this.txtAmount.BackColor = System.Drawing.Color.White;
               this.txtAmount.ForeColor = System.Drawing.Color.Black;
               this.txtAmount.Location = new System.Drawing.Point(1003, 528);
               this.txtAmount.Multiline = true;
               this.txtAmount.Name = "txtAmount";
               this.txtAmount.ReadOnly = true;
               this.txtAmount.Size = new System.Drawing.Size(57, 50);
               this.txtAmount.TabIndex = 17;
               // 
               // txtTotal
               // 
               this.txtTotal.BackColor = System.Drawing.Color.White;
               this.txtTotal.ForeColor = System.Drawing.Color.Black;
               this.txtTotal.Location = new System.Drawing.Point(1003, 619);
               this.txtTotal.Multiline = true;
               this.txtTotal.Name = "txtTotal";
               this.txtTotal.ReadOnly = true;
               this.txtTotal.Size = new System.Drawing.Size(122, 50);
               this.txtTotal.TabIndex = 18;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
               this.label8.Location = new System.Drawing.Point(136, 399);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(125, 30);
               this.label8.TabIndex = 20;
               this.label8.Text = "Tên sản phẩm";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
               this.label9.Location = new System.Drawing.Point(136, 276);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(118, 30);
               this.label9.TabIndex = 21;
               this.label9.Text = "Nhà sản xuất";
               // 
               // cboxManufacturer
               // 
               this.cboxManufacturer.FormattingEnabled = true;
               this.cboxManufacturer.Items.AddRange(new object[] {
            "Công ty TNHH Traphaco Thanh Hóa",
            "Công ty Thuốc Hà Nội",
            "Công ty cổ phần dược Hà Nội"});
               this.cboxManufacturer.Location = new System.Drawing.Point(293, 282);
               this.cboxManufacturer.Name = "cboxManufacturer";
               this.cboxManufacturer.Size = new System.Drawing.Size(250, 24);
               this.cboxManufacturer.TabIndex = 27;
               this.cboxManufacturer.Text = "Lựa chọn";
               this.cboxManufacturer.SelectedIndexChanged += new System.EventHandler(this.cboxManufacturer_SelectedIndexChanged);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
               this.label10.Location = new System.Drawing.Point(136, 339);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(93, 30);
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
               this.cbCategory.Location = new System.Drawing.Point(293, 339);
               this.cbCategory.Name = "cbCategory";
               this.cbCategory.Size = new System.Drawing.Size(250, 24);
               this.cbCategory.TabIndex = 29;
               this.cbCategory.Text = "Danh mục";
               // 
               // dateTimeFrom
               // 
               this.dateTimeFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.dateTimeFrom.BorderRadius = 0;
               this.dateTimeFrom.ForeColor = System.Drawing.Color.White;
               this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
               this.dateTimeFrom.FormatCustom = null;
               this.dateTimeFrom.Location = new System.Drawing.Point(293, 184);
               this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dateTimeFrom.Name = "dateTimeFrom";
               this.dateTimeFrom.Size = new System.Drawing.Size(281, 70);
               this.dateTimeFrom.TabIndex = 30;
               this.dateTimeFrom.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
               // 
               // dateTimeTo
               // 
               this.dateTimeTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.dateTimeTo.BorderRadius = 0;
               this.dateTimeTo.ForeColor = System.Drawing.Color.White;
               this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
               this.dateTimeTo.FormatCustom = null;
               this.dateTimeTo.Location = new System.Drawing.Point(601, 184);
               this.dateTimeTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dateTimeTo.Name = "dateTimeTo";
               this.dateTimeTo.Size = new System.Drawing.Size(290, 70);
               this.dateTimeTo.TabIndex = 31;
               this.dateTimeTo.Value = new System.DateTime(2020, 6, 10, 16, 52, 17, 870);
               // 
               // dgvAnalytics
               // 
               this.dgvAnalytics.AllowUserToAddRows = false;
               this.dgvAnalytics.AllowUserToDeleteRows = false;
               this.dgvAnalytics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvAnalytics.BackgroundColor = System.Drawing.Color.White;
               this.dgvAnalytics.BorderStyle = System.Windows.Forms.BorderStyle.None;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvAnalytics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dgvAnalytics.ColumnHeadersHeight = 29;
               this.dgvAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle2.Format = "g";
               dataGridViewCellStyle2.NullValue = null;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aqua;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgvAnalytics.DefaultCellStyle = dataGridViewCellStyle2;
               this.dgvAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dgvAnalytics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
               this.dgvAnalytics.GridColor = System.Drawing.Color.Black;
               this.dgvAnalytics.Location = new System.Drawing.Point(0, 0);
               this.dgvAnalytics.Name = "dgvAnalytics";
               this.dgvAnalytics.ReadOnly = true;
               this.dgvAnalytics.RowHeadersWidth = 51;
               this.dgvAnalytics.RowTemplate.Height = 24;
               this.dgvAnalytics.ScrollBars = System.Windows.Forms.ScrollBars.None;
               this.dgvAnalytics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dgvAnalytics.Size = new System.Drawing.Size(630, 224);
               this.dgvAnalytics.TabIndex = 34;
               this.dgvAnalytics.UseWaitCursor = true;
               this.dgvAnalytics.VirtualMode = true;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.dgvAnalytics);
               this.panel1.ForeColor = System.Drawing.Color.Black;
               this.panel1.Location = new System.Drawing.Point(142, 445);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(630, 224);
               this.panel1.TabIndex = 35;
               // 
               // btnPre
               // 
               this.btnPre.ActiveBorderThickness = 1;
               this.btnPre.ActiveCornerRadius = 20;
               this.btnPre.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnPre.ActiveForecolor = System.Drawing.Color.White;
               this.btnPre.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnPre.BackColor = System.Drawing.Color.White;
               this.btnPre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPre.BackgroundImage")));
               this.btnPre.ButtonText = "Sau";
               this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnPre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnPre.ForeColor = System.Drawing.Color.SeaGreen;
               this.btnPre.IdleBorderThickness = 1;
               this.btnPre.IdleCornerRadius = 20;
               this.btnPre.IdleFillColor = System.Drawing.Color.White;
               this.btnPre.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnPre.IdleLineColor = System.Drawing.Color.SeaGreen;
               this.btnPre.Location = new System.Drawing.Point(202, 703);
               this.btnPre.Margin = new System.Windows.Forms.Padding(5);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(82, 50);
               this.btnPre.TabIndex = 36;
               this.btnPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
               // 
               // btnNext
               // 
               this.btnNext.ActiveBorderThickness = 1;
               this.btnNext.ActiveCornerRadius = 20;
               this.btnNext.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnNext.ActiveForecolor = System.Drawing.Color.White;
               this.btnNext.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnNext.BackColor = System.Drawing.Color.White;
               this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
               this.btnNext.ButtonText = "Tiếp";
               this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnNext.ForeColor = System.Drawing.Color.SeaGreen;
               this.btnNext.IdleBorderThickness = 1;
               this.btnNext.IdleCornerRadius = 20;
               this.btnNext.IdleFillColor = System.Drawing.Color.White;
               this.btnNext.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnNext.IdleLineColor = System.Drawing.Color.SeaGreen;
               this.btnNext.Location = new System.Drawing.Point(402, 703);
               this.btnNext.Margin = new System.Windows.Forms.Padding(5);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(94, 50);
               this.btnNext.TabIndex = 37;
               this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
               // 
               // btnExcel
               // 
               this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.btnExcel.BorderRadius = 0;
               this.btnExcel.ButtonText = "Xuất Excel";
               this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
               this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
               this.btnExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcel.Iconimage")));
               this.btnExcel.Iconimage_right = null;
               this.btnExcel.Iconimage_right_Selected = null;
               this.btnExcel.Iconimage_Selected = null;
               this.btnExcel.IconMarginLeft = 0;
               this.btnExcel.IconMarginRight = 0;
               this.btnExcel.IconRightVisible = true;
               this.btnExcel.IconRightZoom = 0D;
               this.btnExcel.IconVisible = true;
               this.btnExcel.IconZoom = 90D;
               this.btnExcel.IsTab = false;
               this.btnExcel.Location = new System.Drawing.Point(827, 694);
               this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnExcel.Name = "btnExcel";
               this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
               this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
               this.btnExcel.selected = false;
               this.btnExcel.Size = new System.Drawing.Size(150, 59);
               this.btnExcel.TabIndex = 38;
               this.btnExcel.Text = "Xuất Excel";
               this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnExcel.Textcolor = System.Drawing.Color.White;
               this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
               // 
               // btnAnalytics
               // 
               this.btnAnalytics.ActiveBorderThickness = 1;
               this.btnAnalytics.ActiveCornerRadius = 20;
               this.btnAnalytics.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnAnalytics.ActiveForecolor = System.Drawing.Color.White;
               this.btnAnalytics.ActiveLineColor = System.Drawing.Color.Orange;
               this.btnAnalytics.BackColor = System.Drawing.Color.White;
               this.btnAnalytics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnalytics.BackgroundImage")));
               this.btnAnalytics.ButtonText = "Thống kê";
               this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnAnalytics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnAnalytics.ForeColor = System.Drawing.Color.Red;
               this.btnAnalytics.IdleBorderThickness = 1;
               this.btnAnalytics.IdleCornerRadius = 20;
               this.btnAnalytics.IdleFillColor = System.Drawing.Color.White;
               this.btnAnalytics.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnAnalytics.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
               this.btnAnalytics.Location = new System.Drawing.Point(619, 364);
               this.btnAnalytics.Margin = new System.Windows.Forms.Padding(5);
               this.btnAnalytics.Name = "btnAnalytics";
               this.btnAnalytics.Size = new System.Drawing.Size(153, 60);
               this.btnAnalytics.TabIndex = 39;
               this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click_1);
               // 
               // btnToday
               // 
               this.btnToday.ActiveBorderThickness = 1;
               this.btnToday.ActiveCornerRadius = 20;
               this.btnToday.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnToday.ActiveForecolor = System.Drawing.Color.White;
               this.btnToday.ActiveLineColor = System.Drawing.Color.Orange;
               this.btnToday.BackColor = System.Drawing.Color.White;
               this.btnToday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToday.BackgroundImage")));
               this.btnToday.ButtonText = "Hôm nay";
               this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnToday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnToday.ForeColor = System.Drawing.Color.Red;
               this.btnToday.IdleBorderThickness = 1;
               this.btnToday.IdleCornerRadius = 20;
               this.btnToday.IdleFillColor = System.Drawing.Color.White;
               this.btnToday.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnToday.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
               this.btnToday.Location = new System.Drawing.Point(782, 364);
               this.btnToday.Margin = new System.Windows.Forms.Padding(5);
               this.btnToday.Name = "btnToday";
               this.btnToday.Size = new System.Drawing.Size(153, 60);
               this.btnToday.TabIndex = 40;
               this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnToday.Click += new System.EventHandler(this.btnToday_Click_1);
               // 
               // btnMonth
               // 
               this.btnMonth.ActiveBorderThickness = 1;
               this.btnMonth.ActiveCornerRadius = 20;
               this.btnMonth.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnMonth.ActiveForecolor = System.Drawing.Color.White;
               this.btnMonth.ActiveLineColor = System.Drawing.Color.Orange;
               this.btnMonth.BackColor = System.Drawing.Color.White;
               this.btnMonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMonth.BackgroundImage")));
               this.btnMonth.ButtonText = "Tháng này";
               this.btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnMonth.ForeColor = System.Drawing.Color.Red;
               this.btnMonth.IdleBorderThickness = 1;
               this.btnMonth.IdleCornerRadius = 20;
               this.btnMonth.IdleFillColor = System.Drawing.Color.White;
               this.btnMonth.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnMonth.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
               this.btnMonth.Location = new System.Drawing.Point(944, 364);
               this.btnMonth.Margin = new System.Windows.Forms.Padding(5);
               this.btnMonth.Name = "btnMonth";
               this.btnMonth.Size = new System.Drawing.Size(153, 60);
               this.btnMonth.TabIndex = 41;
               this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.Location = new System.Drawing.Point(535, 711);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(50, 42);
               this.btnTotalPage.TabIndex = 26;
               this.btnTotalPage.UseVisualStyleBackColor = true;
               // 
               // btnCurrent
               // 
               this.btnCurrent.Enabled = false;
               this.btnCurrent.Location = new System.Drawing.Point(319, 711);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(43, 42);
               this.btnCurrent.TabIndex = 24;
               this.btnCurrent.UseVisualStyleBackColor = true;
               // 
               // Analytics
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1179, 799);
               this.Controls.Add(this.btnMonth);
               this.Controls.Add(this.btnToday);
               this.Controls.Add(this.btnAnalytics);
               this.Controls.Add(this.btnExcel);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.dateTimeTo);
               this.Controls.Add(this.dateTimeFrom);
               this.Controls.Add(this.cbCategory);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.cboxManufacturer);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.txtTotal);
               this.Controls.Add(this.txtAmount);
               this.Controls.Add(this.txtAmount_Product);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.txtNameProduct);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.ForeColor = System.Drawing.Color.White;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Analytics";
               this.Text = "Analytics";
               this.Load += new System.EventHandler(this.Analytics_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgvAnalytics)).EndInit();
               this.panel1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount_Product;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxManufacturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCategory;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimeFrom;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimeTo;
        private System.Windows.Forms.DataGridView dgvAnalytics;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAnalytics;
        private Bunifu.Framework.UI.BunifuThinButton2 btnToday;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMonth;
        private System.Windows.Forms.Button btnTotalPage;
        private System.Windows.Forms.Button btnCurrent;
    }
}