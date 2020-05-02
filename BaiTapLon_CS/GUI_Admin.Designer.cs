namespace BaiTapLon_CS
{
     partial class GUI_Admin
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
               this.panel1 = new System.Windows.Forms.Panel();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.panel2 = new System.Windows.Forms.Panel();
               this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.chỉnhSửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.chỉnhSửaThôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.panel1.SuspendLayout();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.Location = new System.Drawing.Point(267, 43);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(710, 44);
               this.label1.TabIndex = 0;
               this.label1.Text = "QUẢN LÝ TIỆM THUỐC TÂY ANHTTT53";
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
               this.panel1.Controls.Add(this.button4);
               this.panel1.Controls.Add(this.button5);
               this.panel1.Controls.Add(this.button3);
               this.panel1.Controls.Add(this.button2);
               this.panel1.Controls.Add(this.button1);
               this.panel1.ForeColor = System.Drawing.Color.Red;
               this.panel1.Location = new System.Drawing.Point(26, 121);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(200, 472);
               this.panel1.TabIndex = 1;
               // 
               // button4
               // 
               this.button4.Location = new System.Drawing.Point(27, 301);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(147, 55);
               this.button4.TabIndex = 5;
               this.button4.Text = "Thống kê";
               this.button4.UseVisualStyleBackColor = true;
               // 
               // button5
               // 
               this.button5.Location = new System.Drawing.Point(27, 388);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(147, 55);
               this.button5.TabIndex = 4;
               this.button5.Text = "Xuất file";
               this.button5.UseVisualStyleBackColor = true;
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(27, 212);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(147, 55);
               this.button3.TabIndex = 2;
               this.button3.Text = "Kiểm tra kho hàng";
               this.button3.UseVisualStyleBackColor = true;
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(27, 130);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(147, 55);
               this.button2.TabIndex = 1;
               this.button2.Text = "Danh sách nhân viên";
               this.button2.UseVisualStyleBackColor = true;
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(27, 38);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(147, 55);
               this.button1.TabIndex = 0;
               this.button1.Text = "Danh mục sản phẩm";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // panel2
               // 
               this.panel2.Location = new System.Drawing.Point(259, 121);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(912, 472);
               this.panel2.TabIndex = 2;
               this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
               // 
               // adminToolStripMenuItem
               // 
               this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
               this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
               this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
               this.adminToolStripMenuItem.Text = "Admin";
               // 
               // đăngXuấtToolStripMenuItem
               // 
               this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
               this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
               this.đăngXuấtToolStripMenuItem.Text = "Thêm Nhân Viên";
               this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
               // 
               // đăngXuấtToolStripMenuItem1
               // 
               this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
               this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
               this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
               // 
               // chỉnhSửaThôngTinToolStripMenuItem
               // 
               this.chỉnhSửaThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.chỉnhSửaThôngTinToolStripMenuItem1});
               this.chỉnhSửaThôngTinToolStripMenuItem.Name = "chỉnhSửaThôngTinToolStripMenuItem";
               this.chỉnhSửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
               this.chỉnhSửaThôngTinToolStripMenuItem.Text = "Thông tin tài khoản";
               // 
               // đổiMậtKhẩuToolStripMenuItem
               // 
               this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
               this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
               this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
               // 
               // chỉnhSửaThôngTinToolStripMenuItem1
               // 
               this.chỉnhSửaThôngTinToolStripMenuItem1.Name = "chỉnhSửaThôngTinToolStripMenuItem1";
               this.chỉnhSửaThôngTinToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
               this.chỉnhSửaThôngTinToolStripMenuItem1.Text = "Chỉnh sửa thông tin";
               // 
               // menuStrip1
               // 
               this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.chỉnhSửaThôngTinToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
               this.menuStrip1.TabIndex = 3;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // GUI_Admin
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1232, 653);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "GUI_Admin";
               this.Text = "GUI_Admin";
               this.Load += new System.EventHandler(this.GUI_Admin_Load);
               this.panel1.ResumeLayout(false);
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}