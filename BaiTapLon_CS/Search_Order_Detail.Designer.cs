namespace BaiTapLon_CS
{
     partial class Search_Order_Detail
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
               this.bunifuDgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
               this.label1 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuDgv)).BeginInit();
               this.SuspendLayout();
               // 
               // bunifuDgv
               // 
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
               this.bunifuDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.bunifuDgv.BackgroundColor = System.Drawing.Color.White;
               this.bunifuDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.bunifuDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.bunifuDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.bunifuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.bunifuDgv.DoubleBuffered = true;
               this.bunifuDgv.EnableHeadersVisualStyles = false;
               this.bunifuDgv.HeaderBgColor = System.Drawing.Color.SeaGreen;
               this.bunifuDgv.HeaderForeColor = System.Drawing.Color.SeaGreen;
               this.bunifuDgv.Location = new System.Drawing.Point(67, 155);
               this.bunifuDgv.Name = "bunifuDgv";
               this.bunifuDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               this.bunifuDgv.RowHeadersWidth = 51;
               this.bunifuDgv.RowTemplate.Height = 24;
               this.bunifuDgv.Size = new System.Drawing.Size(669, 199);
               this.bunifuDgv.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(12, 56);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(364, 45);
               this.label1.TabIndex = 1;
               this.label1.Text = "Chi tiết tìm kiếm :";
               // 
               // Search_Order_Detail
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.bunifuDgv);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
               this.Name = "Search_Order_Detail";
               this.Text = "Search_Order_Detail";
               ((System.ComponentModel.ISupportInitialize)(this.bunifuDgv)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuDgv;
        private System.Windows.Forms.Label label1;
    }
}