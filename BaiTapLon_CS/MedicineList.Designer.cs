namespace BaiTapLon_CS
{
     partial class MedicineList
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineList));
               this.panel2 = new System.Windows.Forms.Panel();
               this.dgwMedicineList = new System.Windows.Forms.DataGridView();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.txtID_Medicine = new System.Windows.Forms.TextBox();
               this.txtName_Medicine = new System.Windows.Forms.TextBox();
               this.cBoxCategoty = new System.Windows.Forms.ComboBox();
               this.cBoxManufacturer = new System.Windows.Forms.ComboBox();
               this.label5 = new System.Windows.Forms.Label();
               this.btnCurrent = new System.Windows.Forms.Button();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
               this.label1 = new System.Windows.Forms.Label();
               this.btnNext = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnPre = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnReset = new System.Windows.Forms.Button();
               this.btnSearch = new System.Windows.Forms.Button();
               this.totalResult = new System.Windows.Forms.Label();
               this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
               this.panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgwMedicineList)).BeginInit();
               this.SuspendLayout();
               // 
               // panel2
               // 
               this.panel2.Controls.Add(this.dgwMedicineList);
               this.panel2.Location = new System.Drawing.Point(30, 338);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1077, 327);
               this.panel2.TabIndex = 18;
               // 
               // dgwMedicineList
               // 
               this.dgwMedicineList.AllowUserToAddRows = false;
               this.dgwMedicineList.AllowUserToOrderColumns = true;
               this.dgwMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgwMedicineList.BackgroundColor = System.Drawing.Color.White;
               this.dgwMedicineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.dgwMedicineList.ColumnHeadersHeight = 29;
               this.dgwMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle2.Format = "g";
               dataGridViewCellStyle2.NullValue = null;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgwMedicineList.DefaultCellStyle = dataGridViewCellStyle2;
               this.dgwMedicineList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
               this.dgwMedicineList.GridColor = System.Drawing.Color.Black;
               this.dgwMedicineList.Location = new System.Drawing.Point(20, 32);
               this.dgwMedicineList.Name = "dgwMedicineList";
               this.dgwMedicineList.ReadOnly = true;
               this.dgwMedicineList.RowHeadersWidth = 51;
               this.dgwMedicineList.RowTemplate.Height = 24;
               this.dgwMedicineList.ScrollBars = System.Windows.Forms.ScrollBars.None;
               this.dgwMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dgwMedicineList.Size = new System.Drawing.Size(1032, 282);
               this.dgwMedicineList.TabIndex = 0;
               this.dgwMedicineList.UseWaitCursor = true;
               this.dgwMedicineList.VirtualMode = true;
               this.dgwMedicineList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwMedicineList_MouseClick);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(47, 201);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(82, 23);
               this.label2.TabIndex = 20;
               this.label2.Text = "Mã thuốc";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.Black;
               this.label3.Location = new System.Drawing.Point(47, 257);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(84, 23);
               this.label3.TabIndex = 21;
               this.label3.Text = "Tên thuốc";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(348, 197);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(88, 23);
               this.label4.TabIndex = 22;
               this.label4.Text = "Danh mục";
               // 
               // txtID_Medicine
               // 
               this.txtID_Medicine.Location = new System.Drawing.Point(171, 185);
               this.txtID_Medicine.Multiline = true;
               this.txtID_Medicine.Name = "txtID_Medicine";
               this.txtID_Medicine.Size = new System.Drawing.Size(158, 36);
               this.txtID_Medicine.TabIndex = 24;
               this.txtID_Medicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Medicine_KeyPress);
               // 
               // txtName_Medicine
               // 
               this.txtName_Medicine.Location = new System.Drawing.Point(171, 244);
               this.txtName_Medicine.Multiline = true;
               this.txtName_Medicine.Name = "txtName_Medicine";
               this.txtName_Medicine.Size = new System.Drawing.Size(158, 36);
               this.txtName_Medicine.TabIndex = 25;
               // 
               // cBoxCategoty
               // 
               this.cBoxCategoty.FormattingEnabled = true;
               this.cBoxCategoty.Items.AddRange(new object[] {
            "Tùy chọn",
            "Thuốc ho",
            "Thuốc bổ",
            "Thuốc cảm cúm",
            "Thuốc tim mạch",
            "Thuốc ngoài da",
            "Vitamin",
            "Vitamin và các chất hữu cơ"});
               this.cBoxCategoty.Location = new System.Drawing.Point(490, 197);
               this.cBoxCategoty.Name = "cBoxCategoty";
               this.cBoxCategoty.Size = new System.Drawing.Size(224, 24);
               this.cBoxCategoty.TabIndex = 28;
               this.cBoxCategoty.Text = "Tùy chọn";
               // 
               // cBoxManufacturer
               // 
               this.cBoxManufacturer.FormattingEnabled = true;
               this.cBoxManufacturer.Items.AddRange(new object[] {
            "Tùy chọn",
            "Công ty TNHH Traphaco Thanh Hóa",
            "Công ty Thuốc Hà Nội",
            "Công ty cổ phần Dược Hà Nội"});
               this.cBoxManufacturer.Location = new System.Drawing.Point(490, 256);
               this.cBoxManufacturer.Name = "cBoxManufacturer";
               this.cBoxManufacturer.Size = new System.Drawing.Size(224, 24);
               this.cBoxManufacturer.TabIndex = 29;
               this.cBoxManufacturer.Text = "Tùy chọn";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.Black;
               this.label5.Location = new System.Drawing.Point(348, 256);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(111, 23);
               this.label5.TabIndex = 30;
               this.label5.Text = "Nhà sản xuất";
               // 
               // btnCurrent
               // 
               this.btnCurrent.BackColor = System.Drawing.Color.White;
               this.btnCurrent.Enabled = false;
               this.btnCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnCurrent.ForeColor = System.Drawing.Color.Black;
               this.btnCurrent.Location = new System.Drawing.Point(519, 684);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(51, 36);
               this.btnCurrent.TabIndex = 33;
               this.btnCurrent.UseVisualStyleBackColor = false;
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.BackColor = System.Drawing.Color.White;
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTotalPage.ForeColor = System.Drawing.Color.Black;
               this.btnTotalPage.Location = new System.Drawing.Point(698, 684);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(62, 36);
               this.btnTotalPage.TabIndex = 34;
               this.btnTotalPage.Text = "of";
               this.btnTotalPage.UseVisualStyleBackColor = false;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(47, 298);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(239, 31);
               this.label6.TabIndex = 1;
               this.label6.Text = "Danh sách thuốc :";
               // 
               // flowLayoutPanel1
               // 
               this.flowLayoutPanel1.Location = new System.Drawing.Point(181, 317);
               this.flowLayoutPanel1.Name = "flowLayoutPanel1";
               this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
               this.flowLayoutPanel1.TabIndex = 40;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(47, 140);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(152, 31);
               this.label1.TabIndex = 41;
               this.label1.Text = "Tìm kiếm :";
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
               this.btnNext.Location = new System.Drawing.Point(601, 671);
               this.btnNext.Margin = new System.Windows.Forms.Padding(5);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(89, 61);
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
               this.btnPre.Location = new System.Drawing.Point(389, 673);
               this.btnPre.Margin = new System.Windows.Forms.Padding(5);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(95, 59);
               this.btnPre.TabIndex = 38;
               this.btnPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnPre.Click += new System.EventHandler(this.btnPre_Click_1);
               // 
               // btnReset
               // 
               this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
               this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
               this.btnReset.Image = global::BaiTapLon_CS.Properties.Resources.icons8_reset_48;
               this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnReset.Location = new System.Drawing.Point(951, 201);
               this.btnReset.Name = "btnReset";
               this.btnReset.Size = new System.Drawing.Size(166, 79);
               this.btnReset.TabIndex = 5;
               this.btnReset.Text = "Khôi phục";
               this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnReset.UseVisualStyleBackColor = false;
               this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
               // 
               // btnSearch
               // 
               this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
               this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
               this.btnSearch.Image = global::BaiTapLon_CS.Properties.Resources.icons8_advanced_search_48;
               this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnSearch.Location = new System.Drawing.Point(771, 201);
               this.btnSearch.Name = "btnSearch";
               this.btnSearch.Size = new System.Drawing.Size(156, 79);
               this.btnSearch.TabIndex = 4;
               this.btnSearch.Text = "Tìm kiếm";
               this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnSearch.UseVisualStyleBackColor = false;
               this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
               // 
               // totalResult
               // 
               this.totalResult.AutoSize = true;
               this.totalResult.Location = new System.Drawing.Point(318, 311);
               this.totalResult.Name = "totalResult";
               this.totalResult.Size = new System.Drawing.Size(46, 17);
               this.totalResult.TabIndex = 42;
               this.totalResult.Text = "label7";
               // 
               // bunifuColorTransition1
               // 
               this.bunifuColorTransition1.Color1 = System.Drawing.Color.Crimson;
               this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
               this.bunifuColorTransition1.ProgessValue = 30;
               // 
               // MedicineList
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1168, 765);
               this.Controls.Add(this.totalResult);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.flowLayoutPanel1);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.cBoxManufacturer);
               this.Controls.Add(this.cBoxCategoty);
               this.Controls.Add(this.txtName_Medicine);
               this.Controls.Add(this.txtID_Medicine);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.btnReset);
               this.Controls.Add(this.btnSearch);
               this.ForeColor = System.Drawing.Color.Black;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "MedicineList";
               this.Text = "MedicineList";
               this.panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dgwMedicineList)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwMedicineList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID_Medicine;
        private System.Windows.Forms.TextBox txtName_Medicine;
        private System.Windows.Forms.ComboBox cBoxCategoty;
        private System.Windows.Forms.ComboBox cBoxManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnTotalPage;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNext;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalResult;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
    }
}