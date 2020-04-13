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
               this.label1 = new System.Windows.Forms.Label();
               this.dgvHistory = new System.Windows.Forms.DataGridView();
               this.txtAmount_Product = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.txtOrder = new System.Windows.Forms.TextBox();
               this.txtTotal = new System.Windows.Forms.TextBox();
               this.btnPrint = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.Location = new System.Drawing.Point(332, 19);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(344, 38);
               this.label1.TabIndex = 0;
               this.label1.Text = "LỊCH SỬ BÁN HÀNG";
               // 
               // dgvHistory
               // 
               this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
               this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvHistory.GridColor = System.Drawing.SystemColors.Highlight;
               this.dgvHistory.Location = new System.Drawing.Point(76, 169);
               this.dgvHistory.Name = "dgvHistory";
               this.dgvHistory.ReadOnly = true;
               this.dgvHistory.RowHeadersWidth = 51;
               this.dgvHistory.RowTemplate.Height = 24;
               this.dgvHistory.Size = new System.Drawing.Size(875, 303);
               this.dgvHistory.TabIndex = 1;
               this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
               // 
               // txtAmount_Product
               // 
               this.txtAmount_Product.BackColor = System.Drawing.Color.White;
               this.txtAmount_Product.Location = new System.Drawing.Point(269, 501);
               this.txtAmount_Product.Multiline = true;
               this.txtAmount_Product.Name = "txtAmount_Product";
               this.txtAmount_Product.ReadOnly = true;
               this.txtAmount_Product.Size = new System.Drawing.Size(158, 38);
               this.txtAmount_Product.TabIndex = 2;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(108, 509);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(107, 17);
               this.label2.TabIndex = 3;
               this.label2.Text = "Tổng sản phẩm";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(111, 590);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(81, 17);
               this.label3.TabIndex = 4;
               this.label3.Text = "Số hóa đơn";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(111, 666);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(74, 17);
               this.label4.TabIndex = 5;
               this.label4.Text = "Doanh thu";
               // 
               // txtOrder
               // 
               this.txtOrder.BackColor = System.Drawing.Color.White;
               this.txtOrder.Location = new System.Drawing.Point(269, 578);
               this.txtOrder.Multiline = true;
               this.txtOrder.Name = "txtOrder";
               this.txtOrder.ReadOnly = true;
               this.txtOrder.Size = new System.Drawing.Size(158, 38);
               this.txtOrder.TabIndex = 6;
               // 
               // txtTotal
               // 
               this.txtTotal.BackColor = System.Drawing.Color.White;
               this.txtTotal.Location = new System.Drawing.Point(269, 652);
               this.txtTotal.Multiline = true;
               this.txtTotal.Name = "txtTotal";
               this.txtTotal.ReadOnly = true;
               this.txtTotal.Size = new System.Drawing.Size(158, 38);
               this.txtTotal.TabIndex = 7;
               // 
               // btnPrint
               // 
               this.btnPrint.Location = new System.Drawing.Point(654, 590);
               this.btnPrint.Name = "btnPrint";
               this.btnPrint.Size = new System.Drawing.Size(108, 49);
               this.btnPrint.TabIndex = 8;
               this.btnPrint.Text = "In";
               this.btnPrint.UseVisualStyleBackColor = true;
               this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
               // 
               // History
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1054, 723);
               this.Controls.Add(this.btnPrint);
               this.Controls.Add(this.txtTotal);
               this.Controls.Add(this.txtOrder);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txtAmount_Product);
               this.Controls.Add(this.dgvHistory);
               this.Controls.Add(this.label1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "History";
               this.Text = "History";
               ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.TextBox txtAmount_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPrint;
    }
}