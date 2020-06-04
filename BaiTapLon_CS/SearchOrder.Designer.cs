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
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.txtID_Invoice = new System.Windows.Forms.TextBox();
               this.txtID_Customer = new System.Windows.Forms.TextBox();
               this.txtName_Customer = new System.Windows.Forms.TextBox();
               this.txtPhone = new System.Windows.Forms.TextBox();
               this.dgvOrder_Search = new System.Windows.Forms.DataGridView();
               this.timeOrderSearch = new System.Windows.Forms.DateTimePicker();
               this.btnCurrent = new System.Windows.Forms.Button();
               this.btnTotalPage = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.btnNext = new System.Windows.Forms.Button();
               this.btnPre = new System.Windows.Forms.Button();
               this.btnSearch = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dgvOrder_Search)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.ForeColor = System.Drawing.Color.White;
               this.label1.Location = new System.Drawing.Point(65, 177);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "Mã hóa đơn";
               this.label1.Click += new System.EventHandler(this.label1_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.ForeColor = System.Drawing.Color.White;
               this.label2.Location = new System.Drawing.Point(65, 311);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(67, 17);
               this.label2.TabIndex = 1;
               this.label2.Text = "Thời gian";
               this.label2.Click += new System.EventHandler(this.label2_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(519, 177);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(105, 17);
               this.label4.TabIndex = 3;
               this.label4.Text = "Mã khách hàng";
               this.label4.Click += new System.EventHandler(this.label4_Click);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.ForeColor = System.Drawing.Color.White;
               this.label5.Location = new System.Drawing.Point(513, 239);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(111, 17);
               this.label5.TabIndex = 4;
               this.label5.Text = "Tên khách hàng";
               this.label5.Click += new System.EventHandler(this.label5_Click);
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.ForeColor = System.Drawing.Color.White;
               this.label7.Location = new System.Drawing.Point(519, 311);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(91, 17);
               this.label7.TabIndex = 6;
               this.label7.Text = "Số điện thoại";
               this.label7.Click += new System.EventHandler(this.label7_Click);
               // 
               // txtID_Invoice
               // 
               this.txtID_Invoice.Location = new System.Drawing.Point(170, 172);
               this.txtID_Invoice.Name = "txtID_Invoice";
               this.txtID_Invoice.Size = new System.Drawing.Size(261, 22);
               this.txtID_Invoice.TabIndex = 7;
               this.txtID_Invoice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               this.txtID_Invoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Medicine_KeyPress);
               // 
               // txtID_Customer
               // 
               this.txtID_Customer.Location = new System.Drawing.Point(663, 174);
               this.txtID_Customer.Name = "txtID_Customer";
               this.txtID_Customer.Size = new System.Drawing.Size(211, 22);
               this.txtID_Customer.TabIndex = 11;
               this.txtID_Customer.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
               this.txtID_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Customer_KeyPress);
               // 
               // txtName_Customer
               // 
               this.txtName_Customer.Location = new System.Drawing.Point(663, 236);
               this.txtName_Customer.Name = "txtName_Customer";
               this.txtName_Customer.Size = new System.Drawing.Size(211, 22);
               this.txtName_Customer.TabIndex = 12;
               this.txtName_Customer.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
               // 
               // txtPhone
               // 
               this.txtPhone.Location = new System.Drawing.Point(663, 306);
               this.txtPhone.Name = "txtPhone";
               this.txtPhone.Size = new System.Drawing.Size(211, 22);
               this.txtPhone.TabIndex = 13;
               this.txtPhone.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
               this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
               // 
               // dgvOrder_Search
               // 
               this.dgvOrder_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvOrder_Search.BackgroundColor = System.Drawing.Color.White;
               this.dgvOrder_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvOrder_Search.Location = new System.Drawing.Point(68, 354);
               this.dgvOrder_Search.Name = "dgvOrder_Search";
               this.dgvOrder_Search.ReadOnly = true;
               this.dgvOrder_Search.RowHeadersWidth = 51;
               this.dgvOrder_Search.RowTemplate.Height = 24;
               this.dgvOrder_Search.Size = new System.Drawing.Size(958, 243);
               this.dgvOrder_Search.TabIndex = 14;
               // 
               // timeOrderSearch
               // 
               this.timeOrderSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.timeOrderSearch.Location = new System.Drawing.Point(170, 311);
               this.timeOrderSearch.Name = "timeOrderSearch";
               this.timeOrderSearch.Size = new System.Drawing.Size(270, 22);
               this.timeOrderSearch.TabIndex = 17;
               this.timeOrderSearch.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
               // 
               // btnCurrent
               // 
               this.btnCurrent.Enabled = false;
               this.btnCurrent.Location = new System.Drawing.Point(454, 645);
               this.btnCurrent.Name = "btnCurrent";
               this.btnCurrent.Size = new System.Drawing.Size(67, 43);
               this.btnCurrent.TabIndex = 19;
               this.btnCurrent.UseVisualStyleBackColor = true;
               // 
               // btnTotalPage
               // 
               this.btnTotalPage.Enabled = false;
               this.btnTotalPage.Location = new System.Drawing.Point(607, 645);
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
               // btnNext
               // 
               this.btnNext.FlatAppearance.BorderSize = 0;
               this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnNext.Image = global::BaiTapLon_CS.Properties.Resources.next2;
               this.btnNext.Location = new System.Drawing.Point(516, 645);
               this.btnNext.Name = "btnNext";
               this.btnNext.Size = new System.Drawing.Size(67, 43);
               this.btnNext.TabIndex = 20;
               this.btnNext.UseVisualStyleBackColor = true;
               this.btnNext.Click += new System.EventHandler(this.button3_Click);
               // 
               // btnPre
               // 
               this.btnPre.FlatAppearance.BorderSize = 0;
               this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnPre.Image = global::BaiTapLon_CS.Properties.Resources.previous;
               this.btnPre.Location = new System.Drawing.Point(373, 645);
               this.btnPre.Name = "btnPre";
               this.btnPre.Size = new System.Drawing.Size(67, 43);
               this.btnPre.TabIndex = 18;
               this.btnPre.UseVisualStyleBackColor = true;
               this.btnPre.Click += new System.EventHandler(this.button1_Click);
               // 
               // btnSearch
               // 
               this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
               this.btnSearch.FlatAppearance.BorderSize = 0;
               this.btnSearch.ForeColor = System.Drawing.Color.White;
               this.btnSearch.Image = global::BaiTapLon_CS.Properties.Resources.plasma_search_icon;
               this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnSearch.Location = new System.Drawing.Point(966, 253);
               this.btnSearch.Name = "btnSearch";
               this.btnSearch.Size = new System.Drawing.Size(111, 80);
               this.btnSearch.TabIndex = 16;
               this.btnSearch.Text = "Tìm kiếm";
               this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnSearch.UseVisualStyleBackColor = false;
               this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
               // 
               // SearchOrder
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
               this.ClientSize = new System.Drawing.Size(1121, 809);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.btnTotalPage);
               this.Controls.Add(this.btnNext);
               this.Controls.Add(this.btnCurrent);
               this.Controls.Add(this.btnPre);
               this.Controls.Add(this.timeOrderSearch);
               this.Controls.Add(this.btnSearch);
               this.Controls.Add(this.dgvOrder_Search);
               this.Controls.Add(this.txtPhone);
               this.Controls.Add(this.txtName_Customer);
               this.Controls.Add(this.txtID_Customer);
               this.Controls.Add(this.txtID_Invoice);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.ForeColor = System.Drawing.Color.White;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "SearchOrder";
               this.Text = "SearchOrder";
               ((System.ComponentModel.ISupportInitialize)(this.dgvOrder_Search)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID_Invoice;
        private System.Windows.Forms.TextBox txtID_Customer;
        private System.Windows.Forms.TextBox txtName_Customer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dgvOrder_Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker timeOrderSearch;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnTotalPage;
        private System.Windows.Forms.Panel panel1;
    }
}