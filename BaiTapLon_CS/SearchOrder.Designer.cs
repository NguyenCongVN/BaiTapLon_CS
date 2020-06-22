namespace BaiTapLon_CS
{
     partial class SearchOrder
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrder));
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.btnCurrent = new System.Windows.Forms.Button();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.bunifuDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
               this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
               this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
               this.txtID_Invoice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.txtID_Customer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.txtName_Customer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
               this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnPre = new Bunifu.Framework.UI.BunifuThinButton2();
               this.timeOrderSearch = new Bunifu.Framework.UI.BunifuDatepicker();
               this.panel2 = new System.Windows.Forms.Panel();
               this.totalResult = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuDgv)).BeginInit();
               this.panel2.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.White;
               this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(160, 208);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(108, 30);
               this.label1.TabIndex = 0;
               this.label1.Text = "Mã hóa đơn";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.White;
               this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(160, 306);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(85, 30);
               this.label2.TabIndex = 1;
               this.label2.Text = "Thời gian";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.White;
               this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(519, 208);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(131, 30);
               this.label4.TabIndex = 3;
               this.label4.Text = "Mã khách hàng";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.White;
               this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.Black;
               this.label5.Location = new System.Drawing.Point(519, 267);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(135, 30);
               this.label5.TabIndex = 4;
               this.label5.Text = "Tên khách hàng";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.White;
               this.label7.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.Color.Black;
               this.label7.Location = new System.Drawing.Point(519, 311);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(120, 30);
               this.label7.TabIndex = 6;
               this.label7.Text = "Số điện thoại";
               // 
               // btnCurrent
               // 
               this.btnCurrent.Enabled = false;
               this.btnCurrent.Location = new System.Drawing.Point(435, 652);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(67, 43);
               this.btnCurrent.TabIndex = 19;
               this.btnCurrent.UseVisualStyleBackColor = true;
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.Location = new System.Drawing.Point(614, 652);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(67, 43);
               this.btnTotalPage.TabIndex = 21;
               this.btnTotalPage.UseVisualStyleBackColor = true;
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1121, 100);
               this.panel1.TabIndex = 22;
               // 
               // bunifuDgv
               // 
               this.bunifuDgv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
               this.bunifuDgv.AllowUserToAddRows = false;
               dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
               this.bunifuDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
               this.bunifuDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.bunifuDgv.BackgroundColor = System.Drawing.Color.White;
               this.bunifuDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.bunifuDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
               this.bunifuDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(140)))), ((int)(((byte)(224)))));
               dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
               dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(140)))), ((int)(((byte)(224)))));
               dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.bunifuDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
               this.bunifuDgv.ColumnHeadersHeight = 50;
               dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
               dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
               dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.bunifuDgv.DefaultCellStyle = dataGridViewCellStyle7;
               this.bunifuDgv.DoubleBuffered = true;
               this.bunifuDgv.EnableHeadersVisualStyles = false;
               this.bunifuDgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(140)))), ((int)(((byte)(224)))));
               this.bunifuDgv.HeaderForeColor = System.Drawing.Color.White;
               this.bunifuDgv.Location = new System.Drawing.Point(16, 3);
               this.bunifuDgv.Name = "bunifuDgv";
               this.bunifuDgv.ReadOnly = true;
               this.bunifuDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDark;
               dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.bunifuDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
               this.bunifuDgv.RowHeadersWidth = 51;
               this.bunifuDgv.RowTemplate.DividerHeight = 3;
               this.bunifuDgv.RowTemplate.Height = 30;
               this.bunifuDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
               this.bunifuDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.bunifuDgv.Size = new System.Drawing.Size(969, 223);
               this.bunifuDgv.TabIndex = 23;
               // 
               // bunifuElipse1
               // 
               this.bunifuElipse1.ElipseRadius = 10;
               this.bunifuElipse1.TargetControl = this.bunifuDgv;
               // 
               // bunifuCustomLabel1
               // 
               this.bunifuCustomLabel1.AutoSize = true;
               this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lime;
               this.bunifuCustomLabel1.Location = new System.Drawing.Point(57, 146);
               this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
               this.bunifuCustomLabel1.Size = new System.Drawing.Size(134, 34);
               this.bunifuCustomLabel1.TabIndex = 24;
               this.bunifuCustomLabel1.Text = "Tìm kiếm :";
               // 
               // bunifuCustomLabel2
               // 
               this.bunifuCustomLabel2.AutoSize = true;
               this.bunifuCustomLabel2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Lime;
               this.bunifuCustomLabel2.Location = new System.Drawing.Point(57, 351);
               this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
               this.bunifuCustomLabel2.Size = new System.Drawing.Size(126, 34);
               this.bunifuCustomLabel2.TabIndex = 25;
               this.bunifuCustomLabel2.Text = "Kết quả :";
               // 
               // txtID_Invoice
               // 
               this.txtID_Invoice.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txtID_Invoice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
               this.txtID_Invoice.ForeColor = System.Drawing.Color.Black;
               this.txtID_Invoice.HintForeColor = System.Drawing.Color.Empty;
               this.txtID_Invoice.HintText = "";
               this.txtID_Invoice.isPassword = false;
               this.txtID_Invoice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
               this.txtID_Invoice.LineIdleColor = System.Drawing.Color.LightSkyBlue;
               this.txtID_Invoice.LineMouseHoverColor = System.Drawing.Color.MediumSpringGreen;
               this.txtID_Invoice.LineThickness = 3;
               this.txtID_Invoice.Location = new System.Drawing.Point(275, 180);
               this.txtID_Invoice.Margin = new System.Windows.Forms.Padding(4);
               this.txtID_Invoice.Name = "txtID_Invoice";
               this.txtID_Invoice.Size = new System.Drawing.Size(216, 44);
               this.txtID_Invoice.TabIndex = 26;
               this.txtID_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               // 
               // txtID_Customer
               // 
               this.txtID_Customer.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txtID_Customer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
               this.txtID_Customer.ForeColor = System.Drawing.Color.Black;
               this.txtID_Customer.HintForeColor = System.Drawing.Color.Empty;
               this.txtID_Customer.HintText = "";
               this.txtID_Customer.isPassword = false;
               this.txtID_Customer.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
               this.txtID_Customer.LineIdleColor = System.Drawing.Color.LightSkyBlue;
               this.txtID_Customer.LineMouseHoverColor = System.Drawing.Color.MediumSpringGreen;
               this.txtID_Customer.LineThickness = 3;
               this.txtID_Customer.Location = new System.Drawing.Point(663, 181);
               this.txtID_Customer.Margin = new System.Windows.Forms.Padding(4);
               this.txtID_Customer.Name = "txtID_Customer";
               this.txtID_Customer.Size = new System.Drawing.Size(194, 44);
               this.txtID_Customer.TabIndex = 27;
               this.txtID_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               // 
               // txtName_Customer
               // 
               this.txtName_Customer.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txtName_Customer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
               this.txtName_Customer.ForeColor = System.Drawing.Color.Black;
               this.txtName_Customer.HintForeColor = System.Drawing.Color.Empty;
               this.txtName_Customer.HintText = "";
               this.txtName_Customer.isPassword = false;
               this.txtName_Customer.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
               this.txtName_Customer.LineIdleColor = System.Drawing.Color.LightSkyBlue;
               this.txtName_Customer.LineMouseHoverColor = System.Drawing.Color.MediumSpringGreen;
               this.txtName_Customer.LineThickness = 3;
               this.txtName_Customer.Location = new System.Drawing.Point(663, 240);
               this.txtName_Customer.Margin = new System.Windows.Forms.Padding(4);
               this.txtName_Customer.Name = "txtName_Customer";
               this.txtName_Customer.Size = new System.Drawing.Size(194, 44);
               this.txtName_Customer.TabIndex = 28;
               this.txtName_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               // 
               // txtPhone
               // 
               this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
               this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
               this.txtPhone.ForeColor = System.Drawing.Color.Black;
               this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
               this.txtPhone.HintText = "";
               this.txtPhone.isPassword = false;
               this.txtPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
               this.txtPhone.LineIdleColor = System.Drawing.Color.LightSkyBlue;
               this.txtPhone.LineMouseHoverColor = System.Drawing.Color.MediumSpringGreen;
               this.txtPhone.LineThickness = 3;
               this.txtPhone.Location = new System.Drawing.Point(663, 284);
               this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
               this.txtPhone.Name = "txtPhone";
               this.txtPhone.Size = new System.Drawing.Size(194, 44);
               this.txtPhone.TabIndex = 29;
               this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
               // 
               // btnSearch
               // 
               this.btnSearch.ActiveBorderThickness = 1;
               this.btnSearch.ActiveCornerRadius = 20;
               this.btnSearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
               this.btnSearch.ActiveLineColor = System.Drawing.Color.SaddleBrown;
               this.btnSearch.BackColor = System.Drawing.Color.White;
               this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
               this.btnSearch.ButtonText = "Tìm kiếm";
               this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSearch.ForeColor = System.Drawing.Color.White;
               this.btnSearch.IdleBorderThickness = 1;
               this.btnSearch.IdleCornerRadius = 20;
               this.btnSearch.IdleFillColor = System.Drawing.Color.White;
               this.btnSearch.IdleForecolor = System.Drawing.Color.MediumBlue;
               this.btnSearch.IdleLineColor = System.Drawing.Color.Red;
               this.btnSearch.Location = new System.Drawing.Point(909, 243);
               this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
               this.btnSearch.Name = "btnSearch";
               this.btnSearch.Size = new System.Drawing.Size(137, 68);
               this.btnSearch.TabIndex = 30;
               this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
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
               this.btnNext.Location = new System.Drawing.Point(510, 645);
               this.btnNext.Margin = new System.Windows.Forms.Padding(5);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(96, 53);
               this.btnNext.TabIndex = 41;
               this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
               this.btnPre.Location = new System.Drawing.Point(316, 645);
               this.btnPre.Margin = new System.Windows.Forms.Padding(5);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(100, 53);
               this.btnPre.TabIndex = 40;
               this.btnPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
               // 
               // timeOrderSearch
               // 
               this.timeOrderSearch.BackColor = System.Drawing.Color.LightSkyBlue;
               this.timeOrderSearch.BorderRadius = 0;
               this.timeOrderSearch.CausesValidation = false;
               this.timeOrderSearch.Cursor = System.Windows.Forms.Cursors.No;
               this.timeOrderSearch.ForeColor = System.Drawing.Color.Black;
               this.timeOrderSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.timeOrderSearch.FormatCustom = null;
               this.timeOrderSearch.Location = new System.Drawing.Point(275, 284);
               this.timeOrderSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.timeOrderSearch.Name = "timeOrderSearch";
               this.timeOrderSearch.Size = new System.Drawing.Size(216, 44);
               this.timeOrderSearch.TabIndex = 42;
               this.timeOrderSearch.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
               // 
               // panel2
               // 
               this.panel2.Controls.Add(this.bunifuDgv);
               this.panel2.Location = new System.Drawing.Point(47, 417);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(999, 229);
               this.panel2.TabIndex = 43;
               // 
               // totalResult
               // 
               this.totalResult.AutoSize = true;
               this.totalResult.Location = new System.Drawing.Point(204, 363);
               this.totalResult.Name = "totalResult";
               this.totalResult.Size = new System.Drawing.Size(28, 17);
               this.totalResult.TabIndex = 44;
               this.totalResult.Text = "     ";
               // 
               // SearchOrder
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1121, 779);
               this.Controls.Add(this.totalResult);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.timeOrderSearch);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.btnSearch);
               this.Controls.Add(this.txtPhone);
               this.Controls.Add(this.txtName_Customer);
               this.Controls.Add(this.txtID_Customer);
               this.Controls.Add(this.txtID_Invoice);
               this.Controls.Add(this.bunifuCustomLabel2);
               this.Controls.Add(this.bunifuCustomLabel1);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.ForeColor = System.Drawing.Color.Black;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "SearchOrder";
               this.Text = "SearchOrder";
               this.Load += new System.EventHandler(this.SearchOrder_Load);
               ((System.ComponentModel.ISupportInitialize)(this.bunifuDgv)).EndInit();
               this.panel2.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnTotalPage;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuDgv;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID_Invoice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID_Customer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName_Customer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPre;
        private Bunifu.Framework.UI.BunifuDatepicker timeOrderSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalResult;
    }
}