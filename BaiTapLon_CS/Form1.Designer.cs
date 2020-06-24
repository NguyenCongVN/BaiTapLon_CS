namespace BaiTapLon_CS
{
    partial class Form1
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
               this.radioBtnCashier = new System.Windows.Forms.RadioButton();
               this.panel1 = new System.Windows.Forms.Panel();
               this.label10 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
               this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
               this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
               this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
               this.txtPassword = new Bunifu.Framework.UI.BunifuTextbox();
               this.txtAccount = new Bunifu.Framework.UI.BunifuTextbox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(101, 190);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(71, 17);
               this.label1.TabIndex = 4;
               this.label1.Text = "Tài khoản";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(101, 274);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(66, 17);
               this.label2.TabIndex = 5;
               this.label2.Text = "Mật khẩu";
               // 
               // radioBtnAdmin
               // 
               this.radioBtnAdmin.AutoSize = true;
               this.radioBtnAdmin.Location = new System.Drawing.Point(718, 170);
               this.radioBtnAdmin.Name = "radioBtnAdmin";
               this.radioBtnAdmin.Size = new System.Drawing.Size(68, 21);
               this.radioBtnAdmin.TabIndex = 1;
               this.radioBtnAdmin.TabStop = true;
               this.radioBtnAdmin.Text = "Admin";
               this.radioBtnAdmin.UseVisualStyleBackColor = true;
               // 
               // radioBtnCashier
               // 
               this.radioBtnCashier.AutoSize = true;
               this.radioBtnCashier.Location = new System.Drawing.Point(515, 170);
               this.radioBtnCashier.Name = "radioBtnCashier";
               this.radioBtnCashier.Size = new System.Drawing.Size(77, 21);
               this.radioBtnCashier.TabIndex = 0;
               this.radioBtnCashier.TabStop = true;
               this.radioBtnCashier.Text = "Cashier";
               this.radioBtnCashier.UseVisualStyleBackColor = true;
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
               this.panel1.Controls.Add(this.pictureBox1);
               this.panel1.Controls.Add(this.label10);
               this.panel1.Controls.Add(this.label9);
               this.panel1.Controls.Add(this.label8);
               this.panel1.Controls.Add(this.label7);
               this.panel1.Controls.Add(this.label6);
               this.panel1.Controls.Add(this.label4);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(322, 648);
               this.panel1.TabIndex = 9;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.ForeColor = System.Drawing.Color.White;
               this.label10.Location = new System.Drawing.Point(57, 442);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(216, 36);
               this.label10.TabIndex = 6;
               this.label10.Text = "2. Nguyễn Thành Công";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.White;
               this.label9.Location = new System.Drawing.Point(57, 474);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(164, 36);
               this.label9.TabIndex = 5;
               this.label9.Text = "3. Phạm Công Tú";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.ForeColor = System.Drawing.Color.White;
               this.label8.Location = new System.Drawing.Point(57, 506);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(207, 36);
               this.label8.TabIndex = 4;
               this.label8.Text = "4. Phạm Mạnh Cường";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.Color.White;
               this.label7.Location = new System.Drawing.Point(57, 542);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(130, 36);
               this.label7.TabIndex = 3;
               this.label7.Text = "5. Hồ Thị Vân";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.White;
               this.label6.Location = new System.Drawing.Point(57, 413);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(147, 36);
               this.label6.TabIndex = 2;
               this.label6.Text = "1. Lê Văn Phiêu";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(12, 355);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(229, 31);
               this.label4.TabIndex = 1;
               this.label4.Text = "Gồm 5 thành viên";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Myanmar Text", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.Crimson;
               this.label5.Location = new System.Drawing.Point(542, 89);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(225, 58);
               this.label5.TabIndex = 10;
               this.label5.Text = "ĐĂNG NHẬP";
               // 
               // bunifuCustomLabel1
               // 
               this.bunifuCustomLabel1.AutoSize = true;
               this.bunifuCustomLabel1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bunifuCustomLabel1.Location = new System.Drawing.Point(510, 212);
               this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
               this.bunifuCustomLabel1.Size = new System.Drawing.Size(58, 25);
               this.bunifuCustomLabel1.TabIndex = 15;
               this.bunifuCustomLabel1.Text = "Email";
               // 
               // bunifuCustomLabel2
               // 
               this.bunifuCustomLabel2.AutoSize = true;
               this.bunifuCustomLabel2.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.bunifuCustomLabel2.Location = new System.Drawing.Point(510, 352);
               this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
               this.bunifuCustomLabel2.Size = new System.Drawing.Size(99, 25);
               this.bunifuCustomLabel2.TabIndex = 16;
               this.bunifuCustomLabel2.Text = "Mật khẩu";
               // 
               // bunifuElipse1
               // 
               this.bunifuElipse1.ElipseRadius = 20;
               this.bunifuElipse1.TargetControl = this.panel1;
               // 
               // btnExit
               // 
               this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnExit.BackColor = System.Drawing.Color.Crimson;
               this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.btnExit.BorderRadius = 0;
               this.btnExit.ButtonText = "THOÁT";
               this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnExit.DisabledColor = System.Drawing.Color.Gray;
               this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
               this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
               this.btnExit.Iconimage_right = null;
               this.btnExit.Iconimage_right_Selected = null;
               this.btnExit.Iconimage_Selected = null;
               this.btnExit.IconMarginLeft = 0;
               this.btnExit.IconMarginRight = 0;
               this.btnExit.IconRightVisible = true;
               this.btnExit.IconRightZoom = 0D;
               this.btnExit.IconVisible = true;
               this.btnExit.IconZoom = 90D;
               this.btnExit.IsTab = false;
               this.btnExit.Location = new System.Drawing.Point(684, 489);
               this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnExit.Name = "btnExit";
               this.btnExit.Normalcolor = System.Drawing.Color.Crimson;
               this.btnExit.OnHovercolor = System.Drawing.Color.DeepPink;
               this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
               this.btnExit.selected = false;
               this.btnExit.Size = new System.Drawing.Size(133, 63);
               this.btnExit.TabIndex = 17;
               this.btnExit.Text = "THOÁT";
               this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnExit.Textcolor = System.Drawing.Color.White;
               this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
               // 
               // btnLogin
               // 
               this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.btnLogin.BorderRadius = 0;
               this.btnLogin.ButtonText = "ĐĂNG NHẬP";
               this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
               this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
               this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
               this.btnLogin.Iconimage_right = null;
               this.btnLogin.Iconimage_right_Selected = null;
               this.btnLogin.Iconimage_Selected = null;
               this.btnLogin.IconMarginLeft = 0;
               this.btnLogin.IconMarginRight = 0;
               this.btnLogin.IconRightVisible = true;
               this.btnLogin.IconRightZoom = 0D;
               this.btnLogin.IconVisible = true;
               this.btnLogin.IconZoom = 90D;
               this.btnLogin.IsTab = false;
               this.btnLogin.Location = new System.Drawing.Point(479, 489);
               this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnLogin.Name = "btnLogin";
               this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
               this.btnLogin.OnHovercolor = System.Drawing.Color.DeepPink;
               this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
               this.btnLogin.selected = false;
               this.btnLogin.Size = new System.Drawing.Size(175, 63);
               this.btnLogin.TabIndex = 14;
               this.btnLogin.Text = "ĐĂNG NHẬP";
               this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnLogin.Textcolor = System.Drawing.Color.White;
               this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
               // 
               // txtPassword
               // 
               this.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
               this.txtPassword.BackColor = System.Drawing.Color.White;
               this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
               this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
               this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
               this.txtPassword.Location = new System.Drawing.Point(510, 381);
               this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtPassword.Name = "txtPassword";
               this.txtPassword.Size = new System.Drawing.Size(294, 53);
               this.txtPassword.TabIndex = 12;
               this.txtPassword.text = "";
               // 
               // txtAccount
               // 
               this.txtAccount.BackColor = System.Drawing.Color.White;
               this.txtAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAccount.BackgroundImage")));
               this.txtAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.txtAccount.ForeColor = System.Drawing.Color.DimGray;
               this.txtAccount.Icon = ((System.Drawing.Image)(resources.GetObject("txtAccount.Icon")));
               this.txtAccount.Location = new System.Drawing.Point(510, 241);
               this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtAccount.Name = "txtAccount";
               this.txtAccount.Size = new System.Drawing.Size(294, 55);
               this.txtAccount.TabIndex = 11;
               this.txtAccount.text = "";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::BaiTapLon_CS.Properties.Resources.nhom1;
               this.pictureBox1.Location = new System.Drawing.Point(3, 159);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(303, 78);
               this.pictureBox1.TabIndex = 7;
               this.pictureBox1.TabStop = false;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(992, 648);
               this.Controls.Add(this.btnExit);
               this.Controls.Add(this.bunifuCustomLabel2);
               this.Controls.Add(this.bunifuCustomLabel1);
               this.Controls.Add(this.btnLogin);
               this.Controls.Add(this.txtPassword);
               this.Controls.Add(this.txtAccount);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.radioBtnAdmin);
               this.Controls.Add(this.radioBtnCashier);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Đăng nhập";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.RadioButton radioBtnCashier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuTextbox txtAccount;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
          public Bunifu.Framework.UI.BunifuTextbox txtPassword;
          private System.Windows.Forms.Label label10;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

