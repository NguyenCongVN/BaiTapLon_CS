﻿namespace BaiTapLon_CS
{
     partial class Medicine_Detail
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
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.panel1 = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.txtID_Medicine = new System.Windows.Forms.TextBox();
               this.txtName_Medicine = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.txtAmount = new System.Windows.Forms.TextBox();
               this.panel3 = new System.Windows.Forms.Panel();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.panel1.SuspendLayout();
               this.panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.panel3.SuspendLayout();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AllowUserToAddRows = false;
               this.dataGridView1.AllowUserToDeleteRows = false;
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(16, 26);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.ReadOnly = true;
               this.dataGridView1.RowHeadersWidth = 51;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
               this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.Size = new System.Drawing.Size(933, 219);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.dataGridView1);
               this.panel1.Location = new System.Drawing.Point(63, 318);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(958, 258);
               this.panel1.TabIndex = 1;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // panel2
               // 
               this.panel2.Controls.Add(this.pictureBox1);
               this.panel2.Location = new System.Drawing.Point(660, 138);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(265, 161);
               this.panel2.TabIndex = 2;
               this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackgroundImage = global::BaiTapLon_CS.Properties.Resources.paracetamol;
               this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox1.Image = global::BaiTapLon_CS.Properties.Resources._default;
               this.pictureBox1.Location = new System.Drawing.Point(19, 3);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(234, 143);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(169, 138);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(66, 17);
               this.label1.TabIndex = 3;
               this.label1.Text = "Mã thuốc";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(169, 211);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(72, 17);
               this.label2.TabIndex = 4;
               this.label2.Text = "Tên thuốc";
               // 
               // txtID_Medicine
               // 
               this.txtID_Medicine.BackColor = System.Drawing.Color.White;
               this.txtID_Medicine.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.txtID_Medicine.Location = new System.Drawing.Point(334, 118);
               this.txtID_Medicine.Multiline = true;
               this.txtID_Medicine.Name = "txtID_Medicine";
               this.txtID_Medicine.ReadOnly = true;
               this.txtID_Medicine.Size = new System.Drawing.Size(214, 40);
               this.txtID_Medicine.TabIndex = 5;
               this.txtID_Medicine.TextChanged += new System.EventHandler(this.txtID_Medicine_TextChanged);
               // 
               // txtName_Medicine
               // 
               this.txtName_Medicine.BackColor = System.Drawing.Color.White;
               this.txtName_Medicine.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.txtName_Medicine.Location = new System.Drawing.Point(334, 186);
               this.txtName_Medicine.Multiline = true;
               this.txtName_Medicine.Name = "txtName_Medicine";
               this.txtName_Medicine.ReadOnly = true;
               this.txtName_Medicine.Size = new System.Drawing.Size(214, 42);
               this.txtName_Medicine.TabIndex = 6;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.Location = new System.Drawing.Point(366, 26);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(279, 38);
               this.label4.TabIndex = 7;
               this.label4.Text = "CHI TIẾT THUỐC";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.ForeColor = System.Drawing.Color.Black;
               this.label5.Location = new System.Drawing.Point(169, 279);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(149, 17);
               this.label5.TabIndex = 8;
               this.label5.Text = "Tổng số lượng hiện tại";
               // 
               // txtAmount
               // 
               this.txtAmount.BackColor = System.Drawing.Color.White;
               this.txtAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.txtAmount.Location = new System.Drawing.Point(334, 254);
               this.txtAmount.Multiline = true;
               this.txtAmount.Name = "txtAmount";
               this.txtAmount.ReadOnly = true;
               this.txtAmount.Size = new System.Drawing.Size(214, 42);
               this.txtAmount.TabIndex = 9;
               // 
               // panel3
               // 
               this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
               this.panel3.Controls.Add(this.label4);
               this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel3.Location = new System.Drawing.Point(0, 0);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(1024, 88);
               this.panel3.TabIndex = 10;
               // 
               // Medicine_Detail
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1024, 586);
               this.Controls.Add(this.panel3);
               this.Controls.Add(this.txtAmount);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.txtName_Medicine);
               this.Controls.Add(this.txtID_Medicine);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.ForeColor = System.Drawing.Color.White;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
               this.Name = "Medicine_Detail";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Chi tiết thuốc";
               this.TopMost = true;
               this.Load += new System.EventHandler(this.Medicine_Detail_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.panel3.ResumeLayout(false);
               this.panel3.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_Medicine;
        private System.Windows.Forms.TextBox txtName_Medicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}