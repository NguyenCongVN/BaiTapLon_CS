namespace BaiTapLon_CS
{
     partial class History
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
               this.dgvHistory = new System.Windows.Forms.DataGridView();
               this.txtAmount_Product = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.txtOrder = new System.Windows.Forms.TextBox();
               this.txtTotal = new System.Windows.Forms.TextBox();
               this.btnCurrent = new System.Windows.Forms.Button();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnPre = new Bunifu.Framework.UI.BunifuThinButton2();
               this.label1 = new System.Windows.Forms.Label();
               this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
               ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgvHistory
               // 
               this.dgvHistory.AllowUserToAddRows = false;
               this.dgvHistory.AllowUserToDeleteRows = false;
               this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
               this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
               this.dgvHistory.GridColor = System.Drawing.Color.White;
               this.dgvHistory.Location = new System.Drawing.Point(6, 16);
               this.dgvHistory.Name = "dgvHistory";
               this.dgvHistory.ReadOnly = true;
               this.dgvHistory.RowHeadersWidth = 51;
               this.dgvHistory.RowTemplate.Height = 24;
               this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dgvHistory.Size = new System.Drawing.Size(800, 199);
               this.dgvHistory.TabIndex = 1;
               // 
               // txtAmount_Product
               // 
               this.txtAmount_Product.BackColor = System.Drawing.Color.White;
               this.txtAmount_Product.Location = new System.Drawing.Point(267, 491);
               this.txtAmount_Product.Multiline = true;
               this.txtAmount_Product.Name = "txtAmount_Product";
               this.txtAmount_Product.ReadOnly = true;
               this.txtAmount_Product.Size = new System.Drawing.Size(75, 27);
               this.txtAmount_Product.TabIndex = 2;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.White;
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(103, 501);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(107, 17);
               this.label2.TabIndex = 3;
               this.label2.Text = "Tổng sản phẩm";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.White;
               this.label3.ForeColor = System.Drawing.Color.Black;
               this.label3.Location = new System.Drawing.Point(103, 557);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(81, 17);
               this.label3.TabIndex = 4;
               this.label3.Text = "Số hóa đơn";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.White;
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(103, 610);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(74, 17);
               this.label4.TabIndex = 5;
               this.label4.Text = "Doanh thu";
               // 
               // txtOrder
               // 
               this.txtOrder.BackColor = System.Drawing.Color.White;
               this.txtOrder.Location = new System.Drawing.Point(267, 544);
               this.txtOrder.Multiline = true;
               this.txtOrder.Name = "txtOrder";
               this.txtOrder.ReadOnly = true;
               this.txtOrder.Size = new System.Drawing.Size(75, 30);
               this.txtOrder.TabIndex = 6;
               // 
               // txtTotal
               // 
               this.txtTotal.BackColor = System.Drawing.Color.White;
               this.txtTotal.Location = new System.Drawing.Point(267, 600);
               this.txtTotal.Multiline = true;
               this.txtTotal.Name = "txtTotal";
               this.txtTotal.ReadOnly = true;
               this.txtTotal.Size = new System.Drawing.Size(75, 27);
               this.txtTotal.TabIndex = 7;
               // 
               // btnCurrent
               // 
               this.btnCurrent.Enabled = false;
               this.btnCurrent.ForeColor = System.Drawing.Color.White;
               this.btnCurrent.Location = new System.Drawing.Point(390, 432);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(51, 40);
               this.btnCurrent.TabIndex = 11;
               this.btnCurrent.UseVisualStyleBackColor = true;
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.ForeColor = System.Drawing.Color.White;
               this.btnTotalPage.Location = new System.Drawing.Point(546, 432);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(75, 40);
               this.btnTotalPage.TabIndex = 13;
               this.btnTotalPage.UseVisualStyleBackColor = true;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.dgvHistory);
               this.panel1.Location = new System.Drawing.Point(52, 187);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(827, 218);
               this.panel1.TabIndex = 14;
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
               this.btnNext.Location = new System.Drawing.Point(480, 432);
               this.btnNext.Margin = new System.Windows.Forms.Padding(5);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(49, 46);
               this.btnNext.TabIndex = 39;
               this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
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
               this.btnPre.Location = new System.Drawing.Point(309, 432);
               this.btnPre.Margin = new System.Windows.Forms.Padding(5);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(52, 46);
               this.btnPre.TabIndex = 38;
               this.btnPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnPre.Click += new System.EventHandler(this.btnPre_Click_1);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
               this.label1.Location = new System.Drawing.Point(46, 118);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(127, 31);
               this.label1.TabIndex = 40;
               this.label1.Text = "Kết quả:";
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
               this.btnExcel.Location = new System.Drawing.Point(546, 568);
               this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnExcel.Name = "btnExcel";
               this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
               this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
               this.btnExcel.selected = false;
               this.btnExcel.Size = new System.Drawing.Size(136, 59);
               this.btnExcel.TabIndex = 42;
               this.btnExcel.Text = "Xuất Excel";
               this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnExcel.Textcolor = System.Drawing.Color.White;
               this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
               // 
               // History
               // 
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1054, 727);
               this.Controls.Add(this.btnExcel);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.txtTotal);
               this.Controls.Add(this.txtOrder);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txtAmount_Product);
               this.ForeColor = System.Drawing.Color.Black;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "History";
               this.Text = "History";
               ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
               this.panel1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.TextBox txtAmount_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnTotalPage;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPre;
          private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
    }
}