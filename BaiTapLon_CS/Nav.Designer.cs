namespace BaiTapLon_CS
{
     partial class Nav
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.button1 = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.button1.Location = new System.Drawing.Point(0, 33);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(217, 82);
               this.button1.TabIndex = 0;
               this.button1.Text = "Danh sách sản phẩm";
               this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.button1.UseVisualStyleBackColor = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.pictureBox1.BackgroundImage = global::BaiTapLon_CS.Properties.Resources.images;
               this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox1.Location = new System.Drawing.Point(14, 48);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(51, 50);
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // Nav
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.button1);
               this.Name = "Nav";
               this.Size = new System.Drawing.Size(257, 770);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
