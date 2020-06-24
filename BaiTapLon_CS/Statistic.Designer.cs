namespace BaiTapLon_CS
{
     partial class Statistic
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic));
               this.dgvTopSell = new Bunifu.Framework.UI.BunifuCustomDataGrid();
               this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.dataCustomer = new System.Windows.Forms.Label();
               this.percentCustomer = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.percentSale = new System.Windows.Forms.Label();
               this.dataSale = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label10 = new System.Windows.Forms.Label();
               this.percentMoney = new System.Windows.Forms.Label();
               this.dataMoney = new System.Windows.Forms.Label();
               this.label13 = new System.Windows.Forms.Label();
               this.label14 = new System.Windows.Forms.Label();
               this.percentMedicine = new System.Windows.Forms.Label();
               this.dataMedicine = new System.Windows.Forms.Label();
               this.label17 = new System.Windows.Forms.Label();
               this.label18 = new System.Windows.Forms.Label();
               this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox5 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.label19 = new System.Windows.Forms.Label();
               this.label20 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               this.customers = new System.Windows.Forms.Label();
               this.totalCustomer = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dgvTopSell)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgvTopSell
               // 
               this.dgvTopSell.AllowUserToAddRows = false;
               this.dgvTopSell.AllowUserToDeleteRows = false;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
               this.dgvTopSell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.dgvTopSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvTopSell.BackgroundColor = System.Drawing.Color.WhiteSmoke;
               this.dgvTopSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.dgvTopSell.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvTopSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dgvTopSell.ColumnHeadersHeight = 30;
               this.dgvTopSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.dgvTopSell.DoubleBuffered = true;
               this.dgvTopSell.EnableHeadersVisualStyles = false;
               this.dgvTopSell.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.dgvTopSell.HeaderBgColor = System.Drawing.Color.White;
               this.dgvTopSell.HeaderForeColor = System.Drawing.Color.MediumBlue;
               this.dgvTopSell.Location = new System.Drawing.Point(3, 3);
               this.dgvTopSell.Name = "dgvTopSell";
               this.dgvTopSell.ReadOnly = true;
               this.dgvTopSell.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               this.dgvTopSell.RowHeadersWidth = 51;
               this.dgvTopSell.RowTemplate.Height = 24;
               this.dgvTopSell.ScrollBars = System.Windows.Forms.ScrollBars.None;
               this.dgvTopSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dgvTopSell.Size = new System.Drawing.Size(503, 184);
               this.dgvTopSell.TabIndex = 4;
               // 
               // chart1
               // 
               this.chart1.BackColor = System.Drawing.Color.Silver;
               chartArea1.Name = "ChartArea1";
               this.chart1.ChartAreas.Add(chartArea1);
               legend1.Name = "Legend1";
               this.chart1.Legends.Add(legend1);
               this.chart1.Location = new System.Drawing.Point(660, 163);
               this.chart1.Name = "chart1";
               series1.ChartArea = "ChartArea1";
               series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
               series1.Legend = "Legend1";
               series1.Name = "week1";
               this.chart1.Series.Add(series1);
               this.chart1.Size = new System.Drawing.Size(479, 356);
               this.chart1.TabIndex = 5;
               this.chart1.Text = "chart1";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Red;
               this.label1.Location = new System.Drawing.Point(85, 522);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(404, 26);
               this.label1.TabIndex = 6;
               this.label1.Text = "Top 5 sản phẩm bán chạy trong tháng :";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Silver;
               this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.White;
               this.label2.Location = new System.Drawing.Point(141, 173);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(145, 32);
               this.label2.TabIndex = 7;
               this.label2.Text = "Khách hàng";
               // 
               // dataCustomer
               // 
               this.dataCustomer.AutoSize = true;
               this.dataCustomer.BackColor = System.Drawing.Color.Silver;
               this.dataCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dataCustomer.ForeColor = System.Drawing.Color.Blue;
               this.dataCustomer.Location = new System.Drawing.Point(182, 219);
               this.dataCustomer.Name = "dataCustomer";
               this.dataCustomer.Size = new System.Drawing.Size(48, 25);
               this.dataCustomer.TabIndex = 8;
               this.dataCustomer.Text = "200";
               // 
               // percentCustomer
               // 
               this.percentCustomer.AutoSize = true;
               this.percentCustomer.BackColor = System.Drawing.Color.Silver;
               this.percentCustomer.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.percentCustomer.ForeColor = System.Drawing.Color.MediumSlateBlue;
               this.percentCustomer.Location = new System.Drawing.Point(183, 288);
               this.percentCustomer.Name = "percentCustomer";
               this.percentCustomer.Size = new System.Drawing.Size(55, 22);
               this.percentCustomer.TabIndex = 9;
               this.percentCustomer.Text = "+20%";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.Silver;
               this.label5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(167, 255);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(81, 18);
               this.label5.TabIndex = 10;
               this.label5.Text = "Tháng này";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.Silver;
               this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(455, 255);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(81, 18);
               this.label6.TabIndex = 15;
               this.label6.Text = "Tháng này";
               // 
               // percentSale
               // 
               this.percentSale.AutoSize = true;
               this.percentSale.BackColor = System.Drawing.Color.Silver;
               this.percentSale.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.percentSale.ForeColor = System.Drawing.Color.MediumSlateBlue;
               this.percentSale.Location = new System.Drawing.Point(473, 288);
               this.percentSale.Name = "percentSale";
               this.percentSale.Size = new System.Drawing.Size(55, 22);
               this.percentSale.TabIndex = 14;
               this.percentSale.Text = "+20%";
               // 
               // dataSale
               // 
               this.dataSale.AutoSize = true;
               this.dataSale.BackColor = System.Drawing.Color.Silver;
               this.dataSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dataSale.ForeColor = System.Drawing.Color.Blue;
               this.dataSale.Location = new System.Drawing.Point(465, 219);
               this.dataSale.Name = "dataSale";
               this.dataSale.Size = new System.Drawing.Size(48, 25);
               this.dataSale.TabIndex = 13;
               this.dataSale.Text = "200";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.BackColor = System.Drawing.Color.Silver;
               this.label9.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.White;
               this.label9.Location = new System.Drawing.Point(438, 173);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(122, 32);
               this.label9.TabIndex = 12;
               this.label9.Text = "Đơn hàng";
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.BackColor = System.Drawing.Color.Silver;
               this.label10.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.Location = new System.Drawing.Point(167, 444);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(81, 18);
               this.label10.TabIndex = 25;
               this.label10.Text = "Tháng này";
               // 
               // percentMoney
               // 
               this.percentMoney.AutoSize = true;
               this.percentMoney.BackColor = System.Drawing.Color.Silver;
               this.percentMoney.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.percentMoney.ForeColor = System.Drawing.Color.MediumSlateBlue;
               this.percentMoney.Location = new System.Drawing.Point(166, 480);
               this.percentMoney.Name = "percentMoney";
               this.percentMoney.Size = new System.Drawing.Size(55, 22);
               this.percentMoney.TabIndex = 24;
               this.percentMoney.Text = "+20%";
               // 
               // dataMoney
               // 
               this.dataMoney.AutoSize = true;
               this.dataMoney.BackColor = System.Drawing.Color.Silver;
               this.dataMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dataMoney.ForeColor = System.Drawing.Color.Blue;
               this.dataMoney.Location = new System.Drawing.Point(154, 411);
               this.dataMoney.Name = "dataMoney";
               this.dataMoney.Size = new System.Drawing.Size(48, 25);
               this.dataMoney.TabIndex = 23;
               this.dataMoney.Text = "200";
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.BackColor = System.Drawing.Color.Silver;
               this.label13.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label13.ForeColor = System.Drawing.Color.White;
               this.label13.Location = new System.Drawing.Point(153, 370);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(133, 32);
               this.label13.TabIndex = 22;
               this.label13.Text = "Tiền thuốc";
               // 
               // label14
               // 
               this.label14.AutoSize = true;
               this.label14.BackColor = System.Drawing.Color.Silver;
               this.label14.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label14.Location = new System.Drawing.Point(455, 444);
               this.label14.Name = "label14";
               this.label14.Size = new System.Drawing.Size(81, 18);
               this.label14.TabIndex = 29;
               this.label14.Text = "Tháng này";
               // 
               // percentMedicine
               // 
               this.percentMedicine.AutoSize = true;
               this.percentMedicine.BackColor = System.Drawing.Color.Silver;
               this.percentMedicine.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.percentMedicine.ForeColor = System.Drawing.Color.MediumSlateBlue;
               this.percentMedicine.Location = new System.Drawing.Point(473, 480);
               this.percentMedicine.Name = "percentMedicine";
               this.percentMedicine.Size = new System.Drawing.Size(55, 22);
               this.percentMedicine.TabIndex = 28;
               this.percentMedicine.Text = "+20%";
               // 
               // dataMedicine
               // 
               this.dataMedicine.AutoSize = true;
               this.dataMedicine.BackColor = System.Drawing.Color.Silver;
               this.dataMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dataMedicine.ForeColor = System.Drawing.Color.Blue;
               this.dataMedicine.Location = new System.Drawing.Point(473, 411);
               this.dataMedicine.Name = "dataMedicine";
               this.dataMedicine.Size = new System.Drawing.Size(48, 25);
               this.dataMedicine.TabIndex = 27;
               this.dataMedicine.Text = "200";
               // 
               // label17
               // 
               this.label17.AutoSize = true;
               this.label17.BackColor = System.Drawing.Color.Silver;
               this.label17.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label17.ForeColor = System.Drawing.Color.White;
               this.label17.Location = new System.Drawing.Point(417, 370);
               this.label17.Name = "label17";
               this.label17.Size = new System.Drawing.Size(174, 32);
               this.label17.TabIndex = 26;
               this.label17.Text = "Số lượng thuốc";
               // 
               // label18
               // 
               this.label18.AutoSize = true;
               this.label18.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label18.ForeColor = System.Drawing.Color.Red;
               this.label18.Location = new System.Drawing.Point(655, 529);
               this.label18.Name = "label18";
               this.label18.Size = new System.Drawing.Size(395, 26);
               this.label18.TabIndex = 31;
               this.label18.Text = "Khách hàng thường xuyên trong tháng :";
               // 
               // bunifuCircleProgressbar1
               // 
               this.bunifuCircleProgressbar1.animated = false;
               this.bunifuCircleProgressbar1.animationIterval = 5;
               this.bunifuCircleProgressbar1.animationSpeed = 300;
               this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
               this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
               this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
               this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.DimGray;
               this.bunifuCircleProgressbar1.LabelVisible = true;
               this.bunifuCircleProgressbar1.LineProgressThickness = 8;
               this.bunifuCircleProgressbar1.LineThickness = 5;
               this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(660, 564);
               this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
               this.bunifuCircleProgressbar1.MaxValue = 100;
               this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
               this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
               this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.DodgerBlue;
               this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(190, 190);
               this.bunifuCircleProgressbar1.TabIndex = 30;
               this.bunifuCircleProgressbar1.Value = 6;
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.Silver;
               this.pictureBox2.Location = new System.Drawing.Point(388, 347);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(226, 172);
               this.pictureBox2.TabIndex = 17;
               this.pictureBox2.TabStop = false;
               // 
               // pictureBox3
               // 
               this.pictureBox3.BackColor = System.Drawing.Color.Silver;
               this.pictureBox3.Location = new System.Drawing.Point(101, 347);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(226, 172);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox3.TabIndex = 16;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox5
               // 
               this.pictureBox5.BackColor = System.Drawing.Color.Silver;
               this.pictureBox5.Location = new System.Drawing.Point(388, 163);
               this.pictureBox5.Name = "pictureBox5";
               this.pictureBox5.Size = new System.Drawing.Size(226, 172);
               this.pictureBox5.TabIndex = 11;
               this.pictureBox5.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Silver;
               this.pictureBox1.Location = new System.Drawing.Point(101, 163);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(226, 172);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
               // 
               // label19
               // 
               this.label19.AutoSize = true;
               this.label19.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label19.ForeColor = System.Drawing.Color.Red;
               this.label19.Location = new System.Drawing.Point(105, 121);
               this.label19.Name = "label19";
               this.label19.Size = new System.Drawing.Size(126, 26);
               this.label19.TabIndex = 32;
               this.label19.Text = "Tổng quan :";
               // 
               // label20
               // 
               this.label20.AutoSize = true;
               this.label20.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label20.ForeColor = System.Drawing.Color.Red;
               this.label20.Location = new System.Drawing.Point(655, 121);
               this.label20.Name = "label20";
               this.label20.Size = new System.Drawing.Size(362, 26);
               this.label20.TabIndex = 33;
               this.label20.Text = "Dữ liệu bán hàng 4 tuần gần nhất :";
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.DarkGray;
               this.panel1.Controls.Add(this.dgvTopSell);
               this.panel1.Location = new System.Drawing.Point(101, 563);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(509, 190);
               this.panel1.TabIndex = 34;
               // 
               // bunifuElipse1
               // 
               this.bunifuElipse1.ElipseRadius = 35;
               this.bunifuElipse1.TargetControl = this.pictureBox1;
               // 
               // bunifuElipse2
               // 
               this.bunifuElipse2.ElipseRadius = 35;
               this.bunifuElipse2.TargetControl = this.pictureBox2;
               // 
               // bunifuElipse3
               // 
               this.bunifuElipse3.ElipseRadius = 35;
               this.bunifuElipse3.TargetControl = this.pictureBox3;
               // 
               // bunifuElipse4
               // 
               this.bunifuElipse4.ElipseRadius = 35;
               this.bunifuElipse4.TargetControl = this.pictureBox5;
               // 
               // customers
               // 
               this.customers.AutoSize = true;
               this.customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.customers.ForeColor = System.Drawing.Color.Red;
               this.customers.Location = new System.Drawing.Point(877, 612);
               this.customers.Name = "customers";
               this.customers.Size = new System.Drawing.Size(55, 38);
               this.customers.TabIndex = 35;
               this.customers.Text = "20";
               // 
               // totalCustomer
               // 
               this.totalCustomer.AutoSize = true;
               this.totalCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.totalCustomer.ForeColor = System.Drawing.Color.Red;
               this.totalCustomer.Location = new System.Drawing.Point(900, 650);
               this.totalCustomer.Name = "totalCustomer";
               this.totalCustomer.Size = new System.Drawing.Size(75, 38);
               this.totalCustomer.TabIndex = 36;
               this.totalCustomer.Text = "/ 30";
               // 
               // Statistic
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1168, 765);
               this.Controls.Add(this.totalCustomer);
               this.Controls.Add(this.customers);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.label20);
               this.Controls.Add(this.label19);
               this.Controls.Add(this.label18);
               this.Controls.Add(this.bunifuCircleProgressbar1);
               this.Controls.Add(this.label14);
               this.Controls.Add(this.percentMedicine);
               this.Controls.Add(this.dataMedicine);
               this.Controls.Add(this.label17);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.percentMoney);
               this.Controls.Add(this.dataMoney);
               this.Controls.Add(this.label13);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.percentSale);
               this.Controls.Add(this.dataSale);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.pictureBox5);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.percentCustomer);
               this.Controls.Add(this.dataCustomer);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.chart1);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Statistic";
               this.Text = "Statistic";
               this.Load += new System.EventHandler(this.Statistic_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgvTopSell)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.panel1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dataCustomer;
        private System.Windows.Forms.Label percentCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label percentSale;
        private System.Windows.Forms.Label dataSale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label percentMoney;
        private System.Windows.Forms.Label dataMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label percentMedicine;
        private System.Windows.Forms.Label dataMedicine;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
          private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTopSell;
          private System.Windows.Forms.Panel panel1;
          private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
          private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
          private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
          private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
          private System.Windows.Forms.Label customers;
          private System.Windows.Forms.Label totalCustomer;
     }
}