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
               this.label1 = new System.Windows.Forms.Label();
               this.btnSearch = new System.Windows.Forms.Button();
               this.btnReset = new System.Windows.Forms.Button();
               this.panel2 = new System.Windows.Forms.Panel();
               this.dgwMedicineList = new System.Windows.Forms.DataGridView();
               this.label11 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.txtID_Medicine = new System.Windows.Forms.TextBox();
               this.txtName_Medicine = new System.Windows.Forms.TextBox();
               this.cBoxCategoty = new System.Windows.Forms.ComboBox();
               this.cBoxManufacturer = new System.Windows.Forms.ComboBox();
               this.label5 = new System.Windows.Forms.Label();
               this.btnPre = new System.Windows.Forms.Button();
               this.btnNext = new System.Windows.Forms.Button();
               this.btnCurrent = new System.Windows.Forms.Button();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgwMedicineList)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.ForeColor = System.Drawing.Color.Transparent;
               this.label1.Location = new System.Drawing.Point(61, 104);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(121, 29);
               this.label1.TabIndex = 2;
               this.label1.Text = "Tìm kiếm";
               // 
               // btnSearch
               // 
               this.btnSearch.Location = new System.Drawing.Point(754, 181);
               this.btnSearch.Name = "btnSearch";
               this.btnSearch.Size = new System.Drawing.Size(129, 62);
               this.btnSearch.TabIndex = 4;
               this.btnSearch.Text = "Tìm kiếm";
               this.btnSearch.UseVisualStyleBackColor = true;
               this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
               // 
               // btnReset
               // 
               this.btnReset.Location = new System.Drawing.Point(929, 181);
               this.btnReset.Name = "btnReset";
               this.btnReset.Size = new System.Drawing.Size(122, 62);
               this.btnReset.TabIndex = 5;
               this.btnReset.Text = "Khôi phục";
               this.btnReset.UseVisualStyleBackColor = true;
               this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
               // 
               // panel2
               // 
               this.panel2.Controls.Add(this.dgwMedicineList);
               this.panel2.Location = new System.Drawing.Point(45, 329);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1063, 322);
               this.panel2.TabIndex = 18;
               // 
               // dgwMedicineList
               // 
               this.dgwMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgwMedicineList.BackgroundColor = System.Drawing.Color.White;
               this.dgwMedicineList.ColumnHeadersHeight = 29;
               this.dgwMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.dgwMedicineList.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dgwMedicineList.Location = new System.Drawing.Point(0, 0);
               this.dgwMedicineList.Name = "dgwMedicineList";
               this.dgwMedicineList.RowHeadersWidth = 51;
               this.dgwMedicineList.RowTemplate.Height = 24;
               this.dgwMedicineList.Size = new System.Drawing.Size(1063, 322);
               this.dgwMedicineList.TabIndex = 0;
               this.dgwMedicineList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMedicineList_CellContentClick);
               this.dgwMedicineList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwMedicineList_MouseClick);
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label11.ForeColor = System.Drawing.Color.White;
               this.label11.Location = new System.Drawing.Point(372, 45);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(411, 38);
               this.label11.TabIndex = 19;
               this.label11.Text = "DANH SÁCH SẢN PHẨM";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(95, 169);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(66, 17);
               this.label2.TabIndex = 20;
               this.label2.Text = "Mã thuốc";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(89, 249);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(72, 17);
               this.label3.TabIndex = 21;
               this.label3.Text = "Tên thuốc";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(394, 169);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(72, 17);
               this.label4.TabIndex = 22;
               this.label4.Text = "Danh mục";
               // 
               // txtID_Medicine
               // 
               this.txtID_Medicine.Location = new System.Drawing.Point(181, 166);
               this.txtID_Medicine.Multiline = true;
               this.txtID_Medicine.Name = "txtID_Medicine";
               this.txtID_Medicine.Size = new System.Drawing.Size(158, 36);
               this.txtID_Medicine.TabIndex = 24;
               this.txtID_Medicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Medicine_KeyPress);
               // 
               // txtName_Medicine
               // 
               this.txtName_Medicine.Location = new System.Drawing.Point(181, 246);
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
               this.cBoxCategoty.Location = new System.Drawing.Point(495, 166);
               this.cBoxCategoty.Name = "cBoxCategoty";
               this.cBoxCategoty.Size = new System.Drawing.Size(224, 24);
               this.cBoxCategoty.TabIndex = 28;
               this.cBoxCategoty.Text = "Tùy chọn";
               this.cBoxCategoty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBoxCategoty_MouseClick);
               // 
               // cBoxManufacturer
               // 
               this.cBoxManufacturer.FormattingEnabled = true;
               this.cBoxManufacturer.Items.AddRange(new object[] {
            "Tùy chọn",
            "Công ty TNHH Traphaco Thanh Hóa",
            "Công ty Thuốc Hà Nội",
            "Công ty cổ phần Dược Hà Nội"});
               this.cBoxManufacturer.Location = new System.Drawing.Point(495, 256);
               this.cBoxManufacturer.Name = "cBoxManufacturer";
               this.cBoxManufacturer.Size = new System.Drawing.Size(224, 24);
               this.cBoxManufacturer.TabIndex = 29;
               this.cBoxManufacturer.Text = "Tùy chọn";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(394, 263);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(91, 17);
               this.label5.TabIndex = 30;
               this.label5.Text = "Nhà sản xuất";
               // 
               // btnPre
               // 
               this.btnPre.BackColor = System.Drawing.Color.Blue;
               this.btnPre.ForeColor = System.Drawing.Color.White;
               this.btnPre.Location = new System.Drawing.Point(379, 683);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(57, 36);
               this.btnPre.TabIndex = 31;
               this.btnPre.Text = "<=";
               this.btnPre.UseVisualStyleBackColor = false;
               this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
               // 
               // btnNext
               // 
               this.btnNext.BackColor = System.Drawing.Color.Blue;
               this.btnNext.ForeColor = System.Drawing.Color.White;
               this.btnNext.Location = new System.Drawing.Point(539, 683);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(49, 36);
               this.btnNext.TabIndex = 32;
               this.btnNext.Text = "=>";
               this.btnNext.UseVisualStyleBackColor = false;
               this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
               // 
               // btnCurrent
               // 
               this.btnCurrent.BackColor = System.Drawing.Color.Blue;
               this.btnCurrent.Enabled = false;
               this.btnCurrent.ForeColor = System.Drawing.Color.White;
               this.btnCurrent.Location = new System.Drawing.Point(467, 683);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(51, 36);
               this.btnCurrent.TabIndex = 33;
               this.btnCurrent.UseVisualStyleBackColor = false;
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.BackColor = System.Drawing.Color.Blue;
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.ForeColor = System.Drawing.Color.White;
               this.btnTotalPage.Location = new System.Drawing.Point(616, 683);
               this.btnTotalPage.Name = "btnTotalPage";
               this.btnTotalPage.Size = new System.Drawing.Size(62, 36);
               this.btnTotalPage.TabIndex = 34;
               this.btnTotalPage.Text = "of 11";
               this.btnTotalPage.UseVisualStyleBackColor = false;
               // 
               // MedicineList
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.ClientSize = new System.Drawing.Size(1168, 825);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.cBoxManufacturer);
               this.Controls.Add(this.cBoxCategoty);
               this.Controls.Add(this.txtName_Medicine);
               this.Controls.Add(this.txtID_Medicine);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.btnReset);
               this.Controls.Add(this.btnSearch);
               this.Controls.Add(this.label1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "MedicineList";
               this.Text = "MedicineList";
               this.panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dgwMedicineList)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwMedicineList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID_Medicine;
        private System.Windows.Forms.TextBox txtName_Medicine;
        private System.Windows.Forms.ComboBox cBoxCategoty;
        private System.Windows.Forms.ComboBox cBoxManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnTotalPage;
    }
}