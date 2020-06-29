namespace MedicineShopManagement.UserControls
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soldValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.importCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.amountCustomer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDataViz1 = new Bunifu.DataViz.BunifuDataViz();
            this.button1 = new System.Windows.Forms.Button();
            this.soldCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.importedCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.salaryCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxChonNam = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(324, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cửa Hàng Bán Thuốc";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.soldValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(60, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 102);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // soldValue
            // 
            this.soldValue.AutoSize = true;
            this.soldValue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldValue.ForeColor = System.Drawing.Color.White;
            this.soldValue.Location = new System.Drawing.Point(3, 50);
            this.soldValue.Name = "soldValue";
            this.soldValue.Size = new System.Drawing.Size(54, 23);
            this.soldValue.TabIndex = 0;
            this.soldValue.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền đã bán:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.importCost);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(337, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 102);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // importCost
            // 
            this.importCost.AutoSize = true;
            this.importCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCost.ForeColor = System.Drawing.Color.White;
            this.importCost.Location = new System.Drawing.Point(14, 50);
            this.importCost.Name = "importCost";
            this.importCost.Size = new System.Drawing.Size(54, 23);
            this.importCost.TabIndex = 0;
            this.importCost.Text = "1234";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền thuốc đã mua:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.amountCustomer);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(642, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 102);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(141, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // amountCustomer
            // 
            this.amountCustomer.AutoSize = true;
            this.amountCustomer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountCustomer.ForeColor = System.Drawing.Color.White;
            this.amountCustomer.Location = new System.Drawing.Point(48, 55);
            this.amountCustomer.Name = "amountCustomer";
            this.amountCustomer.Size = new System.Drawing.Size(43, 23);
            this.amountCustomer.TabIndex = 0;
            this.amountCustomer.Text = "512";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số khách đã tiếp cận:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(55, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu Các Tháng:";
            // 
            // bunifuDataViz1
            // 
            this.bunifuDataViz1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuDataViz1.animationEnabled = false;
            this.bunifuDataViz1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDataViz1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDataViz1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDataViz1.Location = new System.Drawing.Point(58, 294);
            this.bunifuDataViz1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(487, 249);
            this.bunifuDataViz1.TabIndex = 2;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            this.bunifuDataViz1.Title = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(885, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 45);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // soldCircleProgressbar1
            // 
            this.soldCircleProgressbar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soldCircleProgressbar1.animated = false;
            this.soldCircleProgressbar1.animationIterval = 5;
            this.soldCircleProgressbar1.animationSpeed = 300;
            this.soldCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.soldCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soldCircleProgressbar1.BackgroundImage")));
            this.soldCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.soldCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.soldCircleProgressbar1.LabelVisible = true;
            this.soldCircleProgressbar1.LineProgressThickness = 8;
            this.soldCircleProgressbar1.LineThickness = 5;
            this.soldCircleProgressbar1.Location = new System.Drawing.Point(561, 384);
            this.soldCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.soldCircleProgressbar1.MaxValue = 100;
            this.soldCircleProgressbar1.Name = "soldCircleProgressbar1";
            this.soldCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.soldCircleProgressbar1.ProgressColor = System.Drawing.Color.DarkViolet;
            this.soldCircleProgressbar1.Size = new System.Drawing.Size(133, 133);
            this.soldCircleProgressbar1.TabIndex = 4;
            this.soldCircleProgressbar1.Value = 60;
            // 
            // importedCircleProgressbar2
            // 
            this.importedCircleProgressbar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importedCircleProgressbar2.animated = false;
            this.importedCircleProgressbar2.animationIterval = 5;
            this.importedCircleProgressbar2.animationSpeed = 300;
            this.importedCircleProgressbar2.BackColor = System.Drawing.Color.White;
            this.importedCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importedCircleProgressbar2.BackgroundImage")));
            this.importedCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.importedCircleProgressbar2.ForeColor = System.Drawing.Color.Crimson;
            this.importedCircleProgressbar2.LabelVisible = true;
            this.importedCircleProgressbar2.LineProgressThickness = 8;
            this.importedCircleProgressbar2.LineThickness = 5;
            this.importedCircleProgressbar2.Location = new System.Drawing.Point(694, 381);
            this.importedCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.importedCircleProgressbar2.MaxValue = 100;
            this.importedCircleProgressbar2.Name = "importedCircleProgressbar2";
            this.importedCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.importedCircleProgressbar2.ProgressColor = System.Drawing.Color.Crimson;
            this.importedCircleProgressbar2.Size = new System.Drawing.Size(133, 133);
            this.importedCircleProgressbar2.TabIndex = 4;
            this.importedCircleProgressbar2.Value = 92;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(589, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "% Tỉ lệ so với tổng các tháng trước trong năm:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(589, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bán Được";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(715, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tiền Nhập";
            // 
            // salaryCircleProgressbar3
            // 
            this.salaryCircleProgressbar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salaryCircleProgressbar3.animated = false;
            this.salaryCircleProgressbar3.animationIterval = 5;
            this.salaryCircleProgressbar3.animationSpeed = 300;
            this.salaryCircleProgressbar3.BackColor = System.Drawing.Color.White;
            this.salaryCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salaryCircleProgressbar3.BackgroundImage")));
            this.salaryCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.salaryCircleProgressbar3.ForeColor = System.Drawing.Color.DarkRed;
            this.salaryCircleProgressbar3.LabelVisible = true;
            this.salaryCircleProgressbar3.LineProgressThickness = 8;
            this.salaryCircleProgressbar3.LineThickness = 5;
            this.salaryCircleProgressbar3.Location = new System.Drawing.Point(826, 376);
            this.salaryCircleProgressbar3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.salaryCircleProgressbar3.MaxValue = 100;
            this.salaryCircleProgressbar3.Name = "salaryCircleProgressbar3";
            this.salaryCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.salaryCircleProgressbar3.ProgressColor = System.Drawing.Color.Maroon;
            this.salaryCircleProgressbar3.Size = new System.Drawing.Size(138, 138);
            this.salaryCircleProgressbar3.TabIndex = 5;
            this.salaryCircleProgressbar3.Value = 60;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(839, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tiền Nhân Viên";
            // 
            // comboBoxChonNam
            // 
            this.comboBoxChonNam.FormattingEnabled = true;
            this.comboBoxChonNam.Location = new System.Drawing.Point(86, 18);
            this.comboBoxChonNam.Name = "comboBoxChonNam";
            this.comboBoxChonNam.Size = new System.Drawing.Size(82, 29);
            this.comboBoxChonNam.TabIndex = 7;
            this.comboBoxChonNam.SelectedIndexChanged += new System.EventHandler(this.comboBoxChonNam_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 24);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Năm";
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboBoxChonNam);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.salaryCircleProgressbar3);
            this.Controls.Add(this.importedCircleProgressbar2);
            this.Controls.Add(this.soldCircleProgressbar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuDataViz1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(985, 580);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label soldValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label importCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label amountCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Bunifu.DataViz.BunifuDataViz bunifuDataViz1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar soldCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar importedCircleProgressbar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCircleProgressbar salaryCircleProgressbar3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxChonNam;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
