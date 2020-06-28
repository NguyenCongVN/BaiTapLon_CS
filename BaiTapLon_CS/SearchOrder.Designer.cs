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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrder));
               this.label1 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.bunifuDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
               this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
               this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.totalResult = new System.Windows.Forms.Label();
               this.txtName_Customer = new Bunifu.Framework.UI.BunifuTextbox();
               this.txtPhone = new Bunifu.Framework.UI.BunifuTextbox();
               this.txtID_Customer = new Bunifu.Framework.UI.BunifuTextbox();
               this.txtID_Invoice = new Bunifu.Framework.UI.BunifuTextbox();
               this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnPre = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnTotalPage = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnCurrent = new Bunifu.Framework.UI.BunifuThinButton2();
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
               this.label1.Location = new System.Drawing.Point(137, 203);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(108, 30);
               this.label1.TabIndex = 0;
               this.label1.Text = "Mã hóa đơn";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.White;
               this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(137, 289);
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
               this.label5.Location = new System.Drawing.Point(519, 203);
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
               this.label7.Location = new System.Drawing.Point(519, 289);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(120, 30);
               this.label7.TabIndex = 6;
               this.label7.Text = "Số điện thoại";
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
               this.bunifuDgv.AllowUserToDeleteRows = false;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
               this.bunifuDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.bunifuDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.bunifuDgv.BackgroundColor = System.Drawing.Color.White;
               this.bunifuDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.bunifuDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
               this.bunifuDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(140)))), ((int)(((byte)(224)))));
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.bunifuDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.bunifuDgv.ColumnHeadersHeight = 50;
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.bunifuDgv.DefaultCellStyle = dataGridViewCellStyle3;
               this.bunifuDgv.Dock = System.Windows.Forms.DockStyle.Fill;
               this.bunifuDgv.DoubleBuffered = true;
               this.bunifuDgv.EnableHeadersVisualStyles = false;
               this.bunifuDgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(140)))), ((int)(((byte)(224)))));
               this.bunifuDgv.HeaderForeColor = System.Drawing.Color.White;
               this.bunifuDgv.Location = new System.Drawing.Point(0, 0);
               this.bunifuDgv.Name = "bunifuDgv";
               this.bunifuDgv.ReadOnly = true;
               this.bunifuDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDark;
               dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.bunifuDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
               this.bunifuDgv.RowHeadersWidth = 51;
               this.bunifuDgv.RowTemplate.DividerHeight = 3;
               this.bunifuDgv.RowTemplate.Height = 30;
               this.bunifuDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
               this.bunifuDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.bunifuDgv.Size = new System.Drawing.Size(999, 240);
               this.bunifuDgv.TabIndex = 23;
               this.bunifuDgv.Click += new System.EventHandler(this.bunifuDgv_Click);
               // 
               // bunifuElipse1
               // 
               this.bunifuElipse1.ElipseRadius = 10;
               this.bunifuElipse1.TargetControl = this.bunifuDgv;
               // 
               // bunifuCustomLabel1
               // 
               this.bunifuCustomLabel1.AutoSize = true;
               this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lime;
               this.bunifuCustomLabel1.Location = new System.Drawing.Point(57, 146);
               this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
               this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 32);
               this.bunifuCustomLabel1.TabIndex = 24;
               this.bunifuCustomLabel1.Text = "Tìm kiếm :";
               // 
               // bunifuCustomLabel2
               // 
               this.bunifuCustomLabel2.AutoSize = true;
               this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Lime;
               this.bunifuCustomLabel2.Location = new System.Drawing.Point(57, 332);
               this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
               this.bunifuCustomLabel2.Size = new System.Drawing.Size(128, 32);
               this.bunifuCustomLabel2.TabIndex = 25;
               this.bunifuCustomLabel2.Text = "Kết quả :";
               // 
               // panel2
               // 
               this.panel2.Controls.Add(this.bunifuDgv);
               this.panel2.Location = new System.Drawing.Point(47, 383);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(999, 240);
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
               // txtName_Customer
               // 
               this.txtName_Customer.BackColor = System.Drawing.Color.White;
               this.txtName_Customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName_Customer.BackgroundImage")));
               this.txtName_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.txtName_Customer.ForeColor = System.Drawing.Color.Black;
               this.txtName_Customer.Icon = ((System.Drawing.Image)(resources.GetObject("txtName_Customer.Icon")));
               this.txtName_Customer.Location = new System.Drawing.Point(661, 181);
               this.txtName_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtName_Customer.Name = "txtName_Customer";
               this.txtName_Customer.Size = new System.Drawing.Size(218, 52);
               this.txtName_Customer.TabIndex = 48;
               this.txtName_Customer.text = "";
               // 
               // txtPhone
               // 
               this.txtPhone.BackColor = System.Drawing.Color.White;
               this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
               this.txtPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.txtPhone.ForeColor = System.Drawing.Color.Black;
               this.txtPhone.Icon = ((System.Drawing.Image)(resources.GetObject("txtPhone.Icon")));
               this.txtPhone.Location = new System.Drawing.Point(661, 267);
               this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtPhone.Name = "txtPhone";
               this.txtPhone.Size = new System.Drawing.Size(218, 52);
               this.txtPhone.TabIndex = 47;
               this.txtPhone.text = "";
               // 
               // txtID_Customer
               // 
               this.txtID_Customer.BackColor = System.Drawing.Color.White;
               this.txtID_Customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtID_Customer.BackgroundImage")));
               this.txtID_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.txtID_Customer.ForeColor = System.Drawing.Color.Black;
               this.txtID_Customer.Icon = ((System.Drawing.Image)(resources.GetObject("txtID_Customer.Icon")));
               this.txtID_Customer.Location = new System.Drawing.Point(273, 267);
               this.txtID_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtID_Customer.Name = "txtID_Customer";
               this.txtID_Customer.Size = new System.Drawing.Size(218, 52);
               this.txtID_Customer.TabIndex = 46;
               this.txtID_Customer.text = "";
               // 
               // txtID_Invoice
               // 
               this.txtID_Invoice.AccessibleDescription = "";
               this.txtID_Invoice.BackColor = System.Drawing.Color.White;
               this.txtID_Invoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtID_Invoice.BackgroundImage")));
               this.txtID_Invoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.txtID_Invoice.ForeColor = System.Drawing.Color.Black;
               this.txtID_Invoice.Icon = ((System.Drawing.Image)(resources.GetObject("txtID_Invoice.Icon")));
               this.txtID_Invoice.Location = new System.Drawing.Point(273, 181);
               this.txtID_Invoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtID_Invoice.Name = "txtID_Invoice";
               this.txtID_Invoice.Size = new System.Drawing.Size(218, 52);
               this.txtID_Invoice.TabIndex = 45;
               this.txtID_Invoice.text = "";
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
               this.btnNext.Location = new System.Drawing.Point(504, 631);
               this.btnNext.Margin = new System.Windows.Forms.Padding(5);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(74, 49);
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
               this.btnPre.Location = new System.Drawing.Point(326, 631);
               this.btnPre.Margin = new System.Windows.Forms.Padding(5);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(72, 49);
               this.btnPre.TabIndex = 40;
               this.btnPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
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
               this.btnSearch.Location = new System.Drawing.Point(909, 251);
               this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
               this.btnSearch.Name = "btnSearch";
               this.btnSearch.Size = new System.Drawing.Size(137, 68);
               this.btnSearch.TabIndex = 30;
               this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.ActiveBorderThickness = 1;
               this.btnTotalPage.ActiveCornerRadius = 20;
               this.btnTotalPage.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnTotalPage.ActiveForecolor = System.Drawing.Color.White;
               this.btnTotalPage.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnTotalPage.BackColor = System.Drawing.Color.White;
               this.btnTotalPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalPage.BackgroundImage")));
               this.btnTotalPage.ButtonText = "of 1";
               this.btnTotalPage.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnTotalPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnTotalPage.ForeColor = System.Drawing.Color.Blue;
               this.btnTotalPage.IdleBorderThickness = 1;
               this.btnTotalPage.IdleCornerRadius = 20;
               this.btnTotalPage.IdleFillColor = System.Drawing.Color.White;
               this.btnTotalPage.IdleForecolor = System.Drawing.Color.MediumBlue;
               this.btnTotalPage.IdleLineColor = System.Drawing.Color.Crimson;
               this.btnTotalPage.Location = new System.Drawing.Point(604, 631);
               this.btnTotalPage.Margin = new System.Windows.Forms.Padding(5);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(79, 49);
               this.btnTotalPage.TabIndex = 50;
               this.btnTotalPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // btnCurrent
               // 
               this.btnCurrent.ActiveBorderThickness = 1;
               this.btnCurrent.ActiveCornerRadius = 20;
               this.btnCurrent.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnCurrent.ActiveForecolor = System.Drawing.Color.White;
               this.btnCurrent.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnCurrent.BackColor = System.Drawing.Color.White;
               this.btnCurrent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCurrent.BackgroundImage")));
               this.btnCurrent.ButtonText = "1";
               this.btnCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnCurrent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnCurrent.ForeColor = System.Drawing.Color.Blue;
               this.btnCurrent.IdleBorderThickness = 1;
               this.btnCurrent.IdleCornerRadius = 20;
               this.btnCurrent.IdleFillColor = System.Drawing.Color.White;
               this.btnCurrent.IdleForecolor = System.Drawing.Color.MediumBlue;
               this.btnCurrent.IdleLineColor = System.Drawing.Color.Crimson;
               this.btnCurrent.Location = new System.Drawing.Point(425, 631);
               this.btnCurrent.Margin = new System.Windows.Forms.Padding(5);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(46, 49);
               this.btnCurrent.TabIndex = 49;
               this.btnCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // SearchOrder
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1121, 779);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.txtName_Customer);
               this.Controls.Add(this.txtPhone);
               this.Controls.Add(this.txtID_Customer);
               this.Controls.Add(this.txtID_Invoice);
               this.Controls.Add(this.totalResult);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.btnSearch);
               this.Controls.Add(this.bunifuCustomLabel2);
               this.Controls.Add(this.bunifuCustomLabel1);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label1);
               this.ForeColor = System.Drawing.Color.Black;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "SearchOrder";
               this.Text = "SearchOrder";
               ((System.ComponentModel.ISupportInitialize)(this.bunifuDgv)).EndInit();
               this.panel2.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuDgv;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalResult;
        private Bunifu.Framework.UI.BunifuTextbox txtID_Invoice;
        private Bunifu.Framework.UI.BunifuTextbox txtID_Customer;
        private Bunifu.Framework.UI.BunifuTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuTextbox txtName_Customer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTotalPage;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCurrent;
    }
}