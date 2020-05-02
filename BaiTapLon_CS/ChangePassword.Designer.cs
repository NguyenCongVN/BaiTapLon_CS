namespace BaiTapLon_CS
{
     partial class ChangePassword
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
               this.txtCurrentPassword = new System.Windows.Forms.TextBox();
               this.txtNewPassword = new System.Windows.Forms.TextBox();
               this.txtConfirmPassword = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // txtCurrentPassword
               // 
               this.txtCurrentPassword.Location = new System.Drawing.Point(330, 144);
               this.txtCurrentPassword.Multiline = true;
               this.txtCurrentPassword.Name = "txtCurrentPassword";
               this.txtCurrentPassword.Size = new System.Drawing.Size(218, 31);
               this.txtCurrentPassword.TabIndex = 8;
               this.txtCurrentPassword.UseSystemPasswordChar = true;
               // 
               // txtNewPassword
               // 
               this.txtNewPassword.Location = new System.Drawing.Point(330, 197);
               this.txtNewPassword.Multiline = true;
               this.txtNewPassword.Name = "txtNewPassword";
               this.txtNewPassword.Size = new System.Drawing.Size(218, 30);
               this.txtNewPassword.TabIndex = 9;
               this.txtNewPassword.UseSystemPasswordChar = true;
               // 
               // txtConfirmPassword
               // 
               this.txtConfirmPassword.Location = new System.Drawing.Point(330, 249);
               this.txtConfirmPassword.Multiline = true;
               this.txtConfirmPassword.Name = "txtConfirmPassword";
               this.txtConfirmPassword.Size = new System.Drawing.Size(218, 29);
               this.txtConfirmPassword.TabIndex = 10;
               this.txtConfirmPassword.UseSystemPasswordChar = true;
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(340, 325);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(135, 46);
               this.button1.TabIndex = 11;
               this.button1.Text = "Đổi mật khẩu";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(270, 36);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(267, 43);
               this.label1.TabIndex = 12;
               this.label1.Text = "ĐỔI MẬT KHẨU";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(159, 153);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(116, 17);
               this.label2.TabIndex = 13;
               this.label2.Text = "Mật khẩu hiện tại";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(159, 210);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(92, 17);
               this.label3.TabIndex = 14;
               this.label3.Text = "Mật khẩu mới";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(159, 259);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(122, 17);
               this.label4.TabIndex = 15;
               this.label4.Text = "Nhập lại mật khẩu";
               // 
               // ChangePassword
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.txtConfirmPassword);
               this.Controls.Add(this.txtNewPassword);
               this.Controls.Add(this.txtCurrentPassword);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
               this.Name = "ChangePassword";
               this.Text = "ĐỔI MẬT KHẨU";
               this.Load += new System.EventHandler(this.ChangePassword_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}