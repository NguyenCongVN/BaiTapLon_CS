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
               this.pnMain = new System.Windows.Forms.Panel();
               this.pnControl.SuspendLayout();
               this.SuspendLayout();
               // 
               // pnControl
               // 
               this.pnControl.Controls.Add(this.pnMain);
               this.pnControl.Location = new System.Drawing.Point(12, 12);
               this.pnControl.Name = "pnControl";
               this.pnControl.Size = new System.Drawing.Size(1205, 766);
               this.pnControl.TabIndex = 0;
               // 
               // pnMain
               // 
               this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
               this.pnMain.ForeColor = System.Drawing.Color.Lime;
               this.pnMain.Location = new System.Drawing.Point(0, 3);
               this.pnMain.Name = "pnMain";
               this.pnMain.Size = new System.Drawing.Size(1202, 760);
               this.pnMain.TabIndex = 1;
               // 
               // FormMenu
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1220, 780);
               this.Controls.Add(this.pnControl);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormMenu";
               this.Text = "FormMenu";
               this.pnControl.ResumeLayout(false);
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnMain;
    }
}