namespace BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms
{
    partial class ThemLoaiHang
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
            this.textBoxTenLoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textBoxTenLoai
            // 
            this.textBoxTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTenLoai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxTenLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTenLoai.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxTenLoai.HintText = "";
            this.textBoxTenLoai.isPassword = false;
            this.textBoxTenLoai.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxTenLoai.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxTenLoai.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxTenLoai.LineThickness = 3;
            this.textBoxTenLoai.Location = new System.Drawing.Point(13, 53);
            this.textBoxTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenLoai.Name = "textBoxTenLoai";
            this.textBoxTenLoai.Size = new System.Drawing.Size(370, 44);
            this.textBoxTenLoai.TabIndex = 0;
            this.textBoxTenLoai.Text = "Nhập Vào";
            this.textBoxTenLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(51, 107);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Chấp Nhận";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(254, 107);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(109, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "Hủy";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(183, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nhập Vào Tên Loại Thuốc";
            // 
            // ThemLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 146);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.textBoxTenLoai);
            this.Name = "ThemLoaiHang";
            this.Text = "ThemLoaiHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxTenLoai;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}