namespace BaiTapLon_CS
{
     partial class SearchCustomer
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
               this.panel1 = new System.Windows.Forms.Panel();
               this.btnSearchCustomer = new System.Windows.Forms.Button();
               this.txtSearchCustomer = new System.Windows.Forms.TextBox();
               this.cbTypeSearch = new System.Windows.Forms.ComboBox();
               this.label1 = new System.Windows.Forms.Label();
               this.dgvSearchCustomer = new System.Windows.Forms.DataGridView();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCustomer)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.btnSearchCustomer);
               this.panel1.Controls.Add(this.txtSearchCustomer);
               this.panel1.Controls.Add(this.cbTypeSearch);
               this.panel1.Controls.Add(this.label1);
               this.panel1.Location = new System.Drawing.Point(28, 29);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(740, 138);
               this.panel1.TabIndex = 0;
               // 
               // btnSearchCustomer
               // 
               this.btnSearchCustomer.Location = new System.Drawing.Point(586, 57);
               this.btnSearchCustomer.Name = "btnSearchCustomer";
               this.btnSearchCustomer.Size = new System.Drawing.Size(132, 24);
               this.btnSearchCustomer.TabIndex = 3;
               this.btnSearchCustomer.Text = "Tìm kiếm";
               this.btnSearchCustomer.UseVisualStyleBackColor = true;
               this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
               // 
               // txtSearchCustomer
               // 
               this.txtSearchCustomer.Location = new System.Drawing.Point(358, 58);
               this.txtSearchCustomer.Name = "txtSearchCustomer";
               this.txtSearchCustomer.Size = new System.Drawing.Size(185, 22);
               this.txtSearchCustomer.TabIndex = 2;
               this.txtSearchCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // cbTypeSearch
               // 
               this.cbTypeSearch.FormattingEnabled = true;
               this.cbTypeSearch.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Số điện thoại",
            "Email"});
               this.cbTypeSearch.Location = new System.Drawing.Point(155, 57);
               this.cbTypeSearch.Name = "cbTypeSearch";
               this.cbTypeSearch.Size = new System.Drawing.Size(165, 24);
               this.cbTypeSearch.TabIndex = 1;
               this.cbTypeSearch.Text = "Loại";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(33, 61);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(64, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "Tìm kiếm";
               // 
               // dgvSearchCustomer
               // 
               this.dgvSearchCustomer.BackgroundColor = System.Drawing.Color.White;
               this.dgvSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvSearchCustomer.Location = new System.Drawing.Point(28, 187);
               this.dgvSearchCustomer.Name = "dgvSearchCustomer";
               this.dgvSearchCustomer.RowHeadersWidth = 51;
               this.dgvSearchCustomer.RowTemplate.Height = 24;
               this.dgvSearchCustomer.Size = new System.Drawing.Size(740, 227);
               this.dgvSearchCustomer.TabIndex = 1;
               this.dgvSearchCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSearchCustomer_MouseClick);
               // 
               // SearchCustomer
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.dgvSearchCustomer);
               this.Controls.Add(this.panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
               this.Name = "SearchCustomer";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "SearchCustomer";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCustomer)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.ComboBox cbTypeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchCustomer;
    }
}