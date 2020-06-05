namespace BaiTapLon_CS.Forms.Control
{
    partial class CategoryListBoxControl
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
            this.checkListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonOpenListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkListBox
            // 
            this.checkListBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.Location = new System.Drawing.Point(0, 0);
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.Size = new System.Drawing.Size(230, 24);
            this.checkListBox.TabIndex = 0;
            // 
            // buttonOpenListBox
            // 
            this.buttonOpenListBox.Location = new System.Drawing.Point(247, 1);
            this.buttonOpenListBox.Name = "buttonOpenListBox";
            this.buttonOpenListBox.Size = new System.Drawing.Size(40, 23);
            this.buttonOpenListBox.TabIndex = 1;
            this.buttonOpenListBox.Text = "...";
            this.buttonOpenListBox.UseVisualStyleBackColor = true;
            this.buttonOpenListBox.Click += new System.EventHandler(this.buttonOpenListBox_Click);
            // 
            // CategoryListBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOpenListBox);
            this.Controls.Add(this.checkListBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CategoryListBoxControl";
            this.Size = new System.Drawing.Size(292, 25);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox checkListBox;
        public System.Windows.Forms.Button buttonOpenListBox;
    }
}
