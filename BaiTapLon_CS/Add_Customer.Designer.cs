namespace BaiTapLon_CS
{
     partial class Add_Customer
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
               this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
               this.cbTypeSex = new System.Windows.Forms.ComboBox();
               this.label6 = new System.Windows.Forms.Label();
               this.txtPhone = new System.Windows.Forms.TextBox();
               this.txtAddress = new System.Windows.Forms.TextBox();
               this.txtAge = new System.Windows.Forms.TextBox();
               this.txtName_Customer = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.White;
               this.panel1.Controls.Add(this.btnSave);
               this.panel1.Controls.Add(this.cbTypeSex);
               this.panel1.Controls.Add(this.label6);
               this.panel1.Controls.Add(this.txtPhone);
               this.panel1.Controls.Add(this.txtAddress);
               this.panel1.Controls.Add(this.txtAge);
               this.panel1.Controls.Add(this.txtName_Customer);
               this.panel1.Controls.Add(this.label5);
               this.panel1.Controls.Add(this.label4);
               this.panel1.Controls.Add(this.label3);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.ForeColor = System.Drawing.Color.Black;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1224, 769);
               this.panel1.TabIndex = 0;
               // 
               // btnSave
               // 
               this.btnSave.BackColor = System.Drawing.Color.White;
               this.btnSave.Depth = 0;
               this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
               this.btnSave.Location = new System.Drawing.Point(590, 649);
               this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
               this.btnSave.Name = "btnSave";
               this.btnSave.Primary = true;
               this.btnSave.Size = new System.Drawing.Size(153, 40);
               this.btnSave.TabIndex = 13;
               this.btnSave.Text = "LƯU";
               this.btnSave.UseVisualStyleBackColor = false;
               this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
               // 
               // cbTypeSex
               // 
               this.cbTypeSex.FormattingEnabled = true;
               this.cbTypeSex.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
               this.cbTypeSex.Location = new System.Drawing.Point(549, 295);
               this.cbTypeSex.Name = "cbTypeSex";
               this.cbTypeSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
               this.cbTypeSex.Size = new System.Drawing.Size(234, 24);
               this.cbTypeSex.TabIndex = 11;
               this.cbTypeSex.Text = "Chọn";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.ForeColor = System.Drawing.Color.Black;
               this.label6.Location = new System.Drawing.Point(385, 302);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(60, 17);
               this.label6.TabIndex = 10;
               this.label6.Text = "Giới tính";
               // 
               // txtPhone
               // 
               this.txtPhone.Location = new System.Drawing.Point(549, 500);
               this.txtPhone.Multiline = true;
               this.txtPhone.Name = "txtPhone";
               this.txtPhone.Size = new System.Drawing.Size(234, 34);
               this.txtPhone.TabIndex = 8;
               this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
               // 
               // txtAddress
               // 
               this.txtAddress.Location = new System.Drawing.Point(549, 425);
               this.txtAddress.Multiline = true;
               this.txtAddress.Name = "txtAddress";
               this.txtAddress.Size = new System.Drawing.Size(234, 38);
               this.txtAddress.TabIndex = 7;
               // 
               // txtAge
               // 
               this.txtAge.Location = new System.Drawing.Point(549, 359);
               this.txtAge.Multiline = true;
               this.txtAge.Name = "txtAge";
               this.txtAge.Size = new System.Drawing.Size(234, 39);
               this.txtAge.TabIndex = 6;
               this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
               // 
               // txtName_Customer
               // 
               this.txtName_Customer.Location = new System.Drawing.Point(549, 217);
               this.txtName_Customer.Multiline = true;
               this.txtName_Customer.Name = "txtName_Customer";
               this.txtName_Customer.Size = new System.Drawing.Size(234, 36);
               this.txtName_Customer.TabIndex = 5;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.ForeColor = System.Drawing.Color.Black;
               this.label5.Location = new System.Drawing.Point(387, 381);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(67, 17);
               this.label5.TabIndex = 4;
               this.label5.Text = "Năm sinh";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(394, 446);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(51, 17);
               this.label4.TabIndex = 3;
               this.label4.Text = "Địa chỉ";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.ForeColor = System.Drawing.Color.Black;
               this.label3.Location = new System.Drawing.Point(387, 517);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(91, 17);
               this.label3.TabIndex = 2;
               this.label3.Text = "Số điện thoại";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(385, 236);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(69, 17);
               this.label2.TabIndex = 1;
               this.label2.Text = "Họ và tên";
               // 
               // Add_Customer
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1224, 810);
               this.Controls.Add(this.panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Add_Customer";
               this.Text = "Add_Customer";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName_Customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypeSex;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
    }
}