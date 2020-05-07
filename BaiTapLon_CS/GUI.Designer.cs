namespace BaiTapLon_CS
{
    partial class GUI
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
               this.label1 = new System.Windows.Forms.Label();
               this.button7 = new System.Windows.Forms.Button();
               this.button6 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.productList = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.pnlContain = new System.Windows.Forms.Panel();
               this.lbName_Manager = new System.Windows.Forms.Label();
               this.panel2 = new System.Windows.Forms.Panel();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.lbName = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.xemThôngTinTrangCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.chúThíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.panel1.SuspendLayout();
               this.pnlContain.SuspendLayout();
               this.panel2.SuspendLayout();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.Black;
               this.panel1.Controls.Add(this.label1);
               this.panel1.Controls.Add(this.button7);
               this.panel1.Controls.Add(this.button6);
               this.panel1.Controls.Add(this.button5);
               this.panel1.Controls.Add(this.productList);
               this.panel1.Controls.Add(this.button4);
               this.panel1.Controls.Add(this.button2);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel1.ForeColor = System.Drawing.SystemColors.Control;
               this.panel1.Location = new System.Drawing.Point(0, 28);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(258, 1027);
               this.panel1.TabIndex = 2;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.ForeColor = System.Drawing.Color.Red;
               this.label1.Location = new System.Drawing.Point(29, 27);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(196, 38);
               this.label1.TabIndex = 0;
               this.label1.Text = "NHÂN VIÊN";
               // 
               // button7
               // 
               this.button7.BackColor = System.Drawing.SystemColors.ControlText;
               this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button7.ForeColor = System.Drawing.Color.White;
               this.button7.Location = new System.Drawing.Point(5, 651);
               this.button7.Name = "button7";
               this.button7.Size = new System.Drawing.Size(254, 94);
               this.button7.TabIndex = 6;
               this.button7.Text = "LỊCH SỬ BÁN HÀNG";
               this.button7.UseVisualStyleBackColor = false;
               this.button7.Click += new System.EventHandler(this.button7_Click);
               // 
               // button6
               // 
               this.button6.BackColor = System.Drawing.SystemColors.ControlText;
               this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button6.ForeColor = System.Drawing.Color.White;
               this.button6.Location = new System.Drawing.Point(2, 321);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(254, 94);
               this.button6.TabIndex = 3;
               this.button6.Text = "NHẬP ĐƠN";
               this.button6.UseVisualStyleBackColor = false;
               this.button6.Click += new System.EventHandler(this.button10_Click);
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.SystemColors.ControlText;
               this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button5.ForeColor = System.Drawing.Color.White;
               this.button5.Location = new System.Drawing.Point(1, 541);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(254, 94);
               this.button5.TabIndex = 5;
               this.button5.Text = "PHÂN TÍCH BÁN HÀNG";
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // productList
               // 
               this.productList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.productList.BackColor = System.Drawing.SystemColors.ControlText;
               this.productList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.productList.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
               this.productList.FlatAppearance.BorderSize = 100;
               this.productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.productList.ForeColor = System.Drawing.Color.White;
               this.productList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.productList.Location = new System.Drawing.Point(2, 101);
               this.productList.Name = "productList";
               this.productList.Size = new System.Drawing.Size(256, 94);
               this.productList.TabIndex = 1;
               this.productList.Text = "DANH MỤC SẢN PHẨM";
               this.productList.UseVisualStyleBackColor = false;
               this.productList.Click += new System.EventHandler(this.productList_Click);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.SystemColors.ControlText;
               this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button4.ForeColor = System.Drawing.Color.White;
               this.button4.Location = new System.Drawing.Point(0, 431);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(254, 94);
               this.button4.TabIndex = 4;
               this.button4.Text = "TÌM KIẾM HÓA ĐƠN";
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.ControlText;
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button2.ForeColor = System.Drawing.Color.White;
               this.button2.Location = new System.Drawing.Point(2, 211);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(254, 94);
               this.button2.TabIndex = 2;
               this.button2.Text = "THÊM KHÁCH HÀNG";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // pnlContain
               // 
               this.pnlContain.BackColor = System.Drawing.Color.White;
               this.pnlContain.Controls.Add(this.lbName_Manager);
               this.pnlContain.Location = new System.Drawing.Point(300, 41);
               this.pnlContain.Name = "pnlContain";
               this.pnlContain.Size = new System.Drawing.Size(1192, 749);
               this.pnlContain.TabIndex = 3;
               this.pnlContain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
               // 
               // lbName_Manager
               // 
               this.lbName_Manager.AutoSize = true;
               this.lbName_Manager.Location = new System.Drawing.Point(716, 32);
               this.lbName_Manager.Name = "lbName_Manager";
               this.lbName_Manager.Size = new System.Drawing.Size(0, 17);
               this.lbName_Manager.TabIndex = 10;
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.White;
               this.panel2.Controls.Add(this.label4);
               this.panel2.Controls.Add(this.label3);
               this.panel2.Controls.Add(this.lbName);
               this.panel2.Controls.Add(this.label2);
               this.panel2.Location = new System.Drawing.Point(297, 12);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1195, 34);
               this.panel2.TabIndex = 4;
               this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.Location = new System.Drawing.Point(105, 1);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(85, 24);
               this.label4.TabIndex = 3;
               this.label4.Text = "Phiêu Lê";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label3.Location = new System.Drawing.Point(28, 5);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(77, 17);
               this.label3.TabIndex = 2;
               this.label3.Text = "Code by :";
               // 
               // lbName
               // 
               this.lbName.AutoSize = true;
               this.lbName.Location = new System.Drawing.Point(998, 8);
               this.lbName.Name = "lbName";
               this.lbName.Size = new System.Drawing.Size(0, 17);
               this.lbName.TabIndex = 1;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
               this.label2.Location = new System.Drawing.Point(905, 5);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(93, 20);
               this.label2.TabIndex = 0;
               this.label2.Text = "Xin chào, ";
               // 
               // menuStrip1
               // 
               this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.chúThíchToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
               this.menuStrip1.TabIndex = 5;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // thôngTinToolStripMenuItem
               // 
               this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinTrangCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
               this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
               this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
               this.thôngTinToolStripMenuItem.Text = "Chức năng";
               // 
               // xemThôngTinTrangCáNhânToolStripMenuItem
               // 
               this.xemThôngTinTrangCáNhânToolStripMenuItem.Name = "xemThôngTinTrangCáNhânToolStripMenuItem";
               this.xemThôngTinTrangCáNhânToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
               this.xemThôngTinTrangCáNhânToolStripMenuItem.Text = "Xem thông tin trang cá nhân";
               this.xemThôngTinTrangCáNhânToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinTrangCáNhânToolStripMenuItem_Click);
               // 
               // đổiMậtKhẩuToolStripMenuItem
               // 
               this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
               this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
               this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
               this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
               // 
               // đăngXuấtToolStripMenuItem
               // 
               this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
               this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
               this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
               this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
               // 
               // chúThíchToolStripMenuItem
               // 
               this.chúThíchToolStripMenuItem.Name = "chúThíchToolStripMenuItem";
               this.chúThíchToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
               this.chúThíchToolStripMenuItem.Text = "Hướng dẫn sử dụng";
               this.chúThíchToolStripMenuItem.Click += new System.EventHandler(this.chúThíchToolStripMenuItem_Click);
               // 
               // GUI
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1924, 1055);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.pnlContain);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "GUI";
               this.Text = "GUI";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.pnlContain.ResumeLayout(false);
               this.pnlContain.PerformLayout();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button productList;
        private System.Windows.Forms.Panel pnlContain;
        private System.Windows.Forms.Label lbName_Manager;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinTrangCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chúThíchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}