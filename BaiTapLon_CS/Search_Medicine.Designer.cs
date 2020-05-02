namespace BaiTapLon_CS
{
     partial class Search_Medicine
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
               this.txtSearch = new System.Windows.Forms.TextBox();
               this.cBtype = new System.Windows.Forms.ComboBox();
               this.btnSearch = new System.Windows.Forms.Button();
               this.dgvSearchMedicine = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMedicine)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(69, 65);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(64, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "Tìm kiếm";
               // 
               // txtSearch
               // 
               this.txtSearch.Location = new System.Drawing.Point(418, 67);
               this.txtSearch.Name = "txtSearch";
               this.txtSearch.Size = new System.Drawing.Size(160, 22);
               this.txtSearch.TabIndex = 1;
               // 
               // cBtype
               // 
               this.cBtype.FormattingEnabled = true;
               this.cBtype.Items.AddRange(new object[] {
            "Mã thuốc",
            "Tên thuốc"});
               this.cBtype.Location = new System.Drawing.Point(206, 65);
               this.cBtype.Name = "cBtype";
               this.cBtype.Size = new System.Drawing.Size(155, 24);
               this.cBtype.TabIndex = 2;
               this.cBtype.Text = "Loại";
               // 
               // btnSearch
               // 
               this.btnSearch.AutoSize = true;
               this.btnSearch.Location = new System.Drawing.Point(636, 58);
               this.btnSearch.Name = "btnSearch";
               this.btnSearch.Size = new System.Drawing.Size(95, 40);
               this.btnSearch.TabIndex = 3;
               this.btnSearch.Text = "Tìm kiếm";
               this.btnSearch.UseVisualStyleBackColor = true;
               this.btnSearch.Click += new System.EventHandler(this.button1_Click);
               // 
               // dgvSearchMedicine
               // 
               this.dgvSearchMedicine.BackgroundColor = System.Drawing.Color.White;
               this.dgvSearchMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvSearchMedicine.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
               this.dgvSearchMedicine.Location = new System.Drawing.Point(39, 203);
               this.dgvSearchMedicine.Name = "dgvSearchMedicine";
               this.dgvSearchMedicine.RowHeadersWidth = 51;
               this.dgvSearchMedicine.RowTemplate.Height = 24;
               this.dgvSearchMedicine.Size = new System.Drawing.Size(692, 186);
               this.dgvSearchMedicine.TabIndex = 4;
               this.dgvSearchMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchMedicine_CellContentClick);
               this.dgvSearchMedicine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSearchMedicine_MouseClick);
               // 
               // Search_Medicine
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(824, 450);
               this.Controls.Add(this.dgvSearchMedicine);
               this.Controls.Add(this.btnSearch);
               this.Controls.Add(this.cBtype);
               this.Controls.Add(this.txtSearch);
               this.Controls.Add(this.label1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
               this.Name = "Search_Medicine";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Search_Medicine";
               ((System.ComponentModel.ISupportInitialize)(this.dgvSearchMedicine)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cBtype;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearchMedicine;
    }
}