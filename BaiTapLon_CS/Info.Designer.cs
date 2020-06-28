namespace BaiTapLon_CS
{
     partial class Info
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
               this.btnChooseImage = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.btnName = new System.Windows.Forms.TextBox();
               this.btnPhone = new System.Windows.Forms.TextBox();
               this.btnSex = new System.Windows.Forms.ComboBox();
               this.button1 = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.btnDateWork = new System.Windows.Forms.TextBox();
               this.picBoxUser = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
               this.SuspendLayout();
               // 
               // btnChooseImage
               // 
               this.btnChooseImage.Location = new System.Drawing.Point(558, 268);
               this.btnChooseImage.Name = "btnChooseImage";
               this.btnChooseImage.Size = new System.Drawing.Size(133, 48);
               this.btnChooseImage.TabIndex = 1;
               this.btnChooseImage.Text = "Chọn ảnh";
               this.btnChooseImage.UseVisualStyleBackColor = true;
               this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(46, 100);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(69, 17);
               this.label1.TabIndex = 2;
               this.label1.Text = "Họ và tên";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(46, 163);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(60, 17);
               this.label2.TabIndex = 3;
               this.label2.Text = "Giới tính";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(46, 227);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(91, 17);
               this.label3.TabIndex = 4;
               this.label3.Text = "Số điện thoại";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(46, 299);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(94, 17);
               this.label5.TabIndex = 6;
               this.label5.Text = "Ngày vào làm";
               // 
               // btnName
               // 
               this.btnName.Location = new System.Drawing.Point(203, 97);
               this.btnName.Name = "btnName";
               this.btnName.Size = new System.Drawing.Size(218, 22);
               this.btnName.TabIndex = 7;
               // 
               // btnPhone
               // 
               this.btnPhone.Location = new System.Drawing.Point(203, 218);
               this.btnPhone.Name = "btnPhone";
               this.btnPhone.Size = new System.Drawing.Size(218, 22);
               this.btnPhone.TabIndex = 8;
               // 
               // btnSex
               // 
               this.btnSex.FormattingEnabled = true;
               this.btnSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
               this.btnSex.Location = new System.Drawing.Point(203, 160);
               this.btnSex.Name = "btnSex";
               this.btnSex.Size = new System.Drawing.Size(218, 24);
               this.btnSex.TabIndex = 11;
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(316, 370);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(150, 56);
               this.button1.TabIndex = 12;
               this.button1.Text = "Cập nhật";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label6.Location = new System.Drawing.Point(196, 23);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(384, 38);
               this.label6.TabIndex = 13;
               this.label6.Text = "THÔNG TIN TÀI KHOẢN";
               // 
               // btnDateWork
               // 
               this.btnDateWork.Location = new System.Drawing.Point(203, 294);
               this.btnDateWork.Name = "btnDateWork";
               this.btnDateWork.ReadOnly = true;
               this.btnDateWork.Size = new System.Drawing.Size(218, 22);
               this.btnDateWork.TabIndex = 14;
               // 
               // picBoxUser
               // 
               this.picBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.picBoxUser.Location = new System.Drawing.Point(523, 97);
               this.picBoxUser.Name = "picBoxUser";
               this.picBoxUser.Size = new System.Drawing.Size(195, 137);
               this.picBoxUser.TabIndex = 0;
               this.picBoxUser.TabStop = false;
               this.picBoxUser.Click += new System.EventHandler(this.picBoxUser_Click);
               // 
               // Info
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(773, 450);
               this.Controls.Add(this.btnDateWork);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.btnSex);
               this.Controls.Add(this.btnPhone);
               this.Controls.Add(this.btnName);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btnChooseImage);
               this.Controls.Add(this.picBoxUser);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
               this.Name = "Info";
               this.Text = "Info";
               this.TopMost = true;
               ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btnName;
        private System.Windows.Forms.TextBox btnPhone;
        private System.Windows.Forms.ComboBox btnSex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btnDateWork;
    }
}