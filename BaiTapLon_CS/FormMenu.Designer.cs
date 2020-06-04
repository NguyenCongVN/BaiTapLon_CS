namespace BaiTapLon_CS
{
     partial class FormMenu
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
               this.pnControl = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // pnControl
               // 
               this.pnControl.BackgroundImage = global::BaiTapLon_CS.Properties.Resources.the_nhan_vien_nha_thuoc_2_1024x682;
               this.pnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pnControl.Location = new System.Drawing.Point(12, 89);
               this.pnControl.Name = "pnControl";
               this.pnControl.Size = new System.Drawing.Size(1167, 646);
               this.pnControl.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(380, 42);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(376, 44);
               this.label1.TabIndex = 1;
               this.label1.Text = "NHÀ THUỐC NHÓM 1";
               // 
               // FormMenu
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1187, 769);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.pnControl);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormMenu";
               this.Text = "FormMenu";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label label1;
    }
}