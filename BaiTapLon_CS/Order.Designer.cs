﻿namespace BaiTapLon_CS
{
     partial class Order
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               this.splitContainer1 = new System.Windows.Forms.SplitContainer();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.txtRemind = new System.Windows.Forms.RichTextBox();
               this.txtDiagnostic = new System.Windows.Forms.RichTextBox();
               this.txtID_Manager = new System.Windows.Forms.TextBox();
               this.txtID_Customer = new System.Windows.Forms.TextBox();
               this.txtPhoneOrder = new System.Windows.Forms.TextBox();
               this.txtAddress_Order = new System.Windows.Forms.TextBox();
               this.txtName_Customer_Order = new System.Windows.Forms.TextBox();
               this.txtName_Manager = new System.Windows.Forms.TextBox();
               this.label18 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label17 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label15 = new System.Windows.Forms.Label();
               this.label10 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
               this.cancelInvoice = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnSaveData = new Bunifu.Framework.UI.BunifuThinButton2();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.btnAddToInvoice = new Bunifu.Framework.UI.BunifuThinButton2();
               this.Total = new System.Windows.Forms.Label();
               this.txtPrice = new System.Windows.Forms.TextBox();
               this.txtNameMedicine = new System.Windows.Forms.TextBox();
               this.txtAmount = new System.Windows.Forms.TextBox();
               this.txtID_Medicine = new System.Windows.Forms.TextBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.dgvInvoice = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.xóaGiỏHàng = new System.Windows.Forms.ToolStripMenuItem();
               this.label16 = new System.Windows.Forms.Label();
               this.label14 = new System.Windows.Forms.Label();
               this.label13 = new System.Windows.Forms.Label();
               this.label12 = new System.Windows.Forms.Label();
               this.label11 = new System.Windows.Forms.Label();
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.quanLyBanThuocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
               this.splitContainer1.Panel1.SuspendLayout();
               this.splitContainer1.Panel2.SuspendLayout();
               this.splitContainer1.SuspendLayout();
               this.groupBox1.SuspendLayout();
               this.groupBox2.SuspendLayout();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
               this.contextMenuStrip2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.quanLyBanThuocDataSetBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // splitContainer1
               // 
               this.splitContainer1.Location = new System.Drawing.Point(12, 12);
               this.splitContainer1.Name = "splitContainer1";
               this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
               this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
               // 
               // splitContainer1.Panel2
               // 
               this.splitContainer1.Panel2.Controls.Add(this.btnExit);
               this.splitContainer1.Panel2.Controls.Add(this.cancelInvoice);
               this.splitContainer1.Panel2.Controls.Add(this.btnSaveData);
               this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
               this.splitContainer1.Size = new System.Drawing.Size(1196, 734);
               this.splitContainer1.SplitterDistance = 293;
               this.splitContainer1.TabIndex = 12;
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.txtRemind);
               this.groupBox1.Controls.Add(this.txtDiagnostic);
               this.groupBox1.Controls.Add(this.txtID_Manager);
               this.groupBox1.Controls.Add(this.txtID_Customer);
               this.groupBox1.Controls.Add(this.txtPhoneOrder);
               this.groupBox1.Controls.Add(this.txtAddress_Order);
               this.groupBox1.Controls.Add(this.txtName_Customer_Order);
               this.groupBox1.Controls.Add(this.txtName_Manager);
               this.groupBox1.Controls.Add(this.label18);
               this.groupBox1.Controls.Add(this.label7);
               this.groupBox1.Controls.Add(this.label17);
               this.groupBox1.Controls.Add(this.label6);
               this.groupBox1.Controls.Add(this.label15);
               this.groupBox1.Controls.Add(this.label10);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
               this.groupBox1.Location = new System.Drawing.Point(0, 102);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(1196, 191);
               this.groupBox1.TabIndex = 2;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "THÔNG TIN CHUNG";
               // 
               // txtRemind
               // 
               this.txtRemind.Location = new System.Drawing.Point(906, 113);
               this.txtRemind.Name = "txtRemind";
               this.txtRemind.Size = new System.Drawing.Size(164, 39);
               this.txtRemind.TabIndex = 19;
               this.txtRemind.Text = "";
               // 
               // txtDiagnostic
               // 
               this.txtDiagnostic.Location = new System.Drawing.Point(906, 38);
               this.txtDiagnostic.Name = "txtDiagnostic";
               this.txtDiagnostic.Size = new System.Drawing.Size(164, 35);
               this.txtDiagnostic.TabIndex = 18;
               this.txtDiagnostic.Text = "";
               // 
               // txtID_Manager
               // 
               this.txtID_Manager.Location = new System.Drawing.Point(260, 80);
               this.txtID_Manager.Name = "txtID_Manager";
               this.txtID_Manager.ReadOnly = true;
               this.txtID_Manager.Size = new System.Drawing.Size(170, 22);
               this.txtID_Manager.TabIndex = 17;
               // 
               // txtID_Customer
               // 
               this.txtID_Customer.Location = new System.Drawing.Point(260, 35);
               this.txtID_Customer.Name = "txtID_Customer";
               this.txtID_Customer.ReadOnly = true;
               this.txtID_Customer.Size = new System.Drawing.Size(170, 22);
               this.txtID_Customer.TabIndex = 16;
               this.txtID_Customer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtID_Customer_MouseDown);
               // 
               // txtPhoneOrder
               // 
               this.txtPhoneOrder.Location = new System.Drawing.Point(584, 127);
               this.txtPhoneOrder.Name = "txtPhoneOrder";
               this.txtPhoneOrder.ReadOnly = true;
               this.txtPhoneOrder.Size = new System.Drawing.Size(170, 22);
               this.txtPhoneOrder.TabIndex = 15;
               // 
               // txtAddress_Order
               // 
               this.txtAddress_Order.Location = new System.Drawing.Point(584, 83);
               this.txtAddress_Order.Name = "txtAddress_Order";
               this.txtAddress_Order.ReadOnly = true;
               this.txtAddress_Order.Size = new System.Drawing.Size(170, 22);
               this.txtAddress_Order.TabIndex = 14;
               // 
               // txtName_Customer_Order
               // 
               this.txtName_Customer_Order.Location = new System.Drawing.Point(584, 39);
               this.txtName_Customer_Order.Name = "txtName_Customer_Order";
               this.txtName_Customer_Order.ReadOnly = true;
               this.txtName_Customer_Order.Size = new System.Drawing.Size(170, 22);
               this.txtName_Customer_Order.TabIndex = 13;
               // 
               // txtName_Manager
               // 
               this.txtName_Manager.Location = new System.Drawing.Point(260, 131);
               this.txtName_Manager.Name = "txtName_Manager";
               this.txtName_Manager.ReadOnly = true;
               this.txtName_Manager.Size = new System.Drawing.Size(170, 22);
               this.txtName_Manager.TabIndex = 11;
               // 
               // label18
               // 
               this.label18.AutoSize = true;
               this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label18.ForeColor = System.Drawing.Color.Black;
               this.label18.Location = new System.Drawing.Point(441, 130);
               this.label18.Name = "label18";
               this.label18.Size = new System.Drawing.Size(84, 18);
               this.label18.TabIndex = 7;
               this.label18.Text = "Điện thoại";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label7.ForeColor = System.Drawing.Color.Black;
               this.label7.Location = new System.Drawing.Point(787, 127);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(72, 18);
               this.label7.TabIndex = 5;
               this.label7.Text = "Lời nhắc";
               // 
               // label17
               // 
               this.label17.AutoSize = true;
               this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label17.ForeColor = System.Drawing.Color.Black;
               this.label17.Location = new System.Drawing.Point(441, 80);
               this.label17.Name = "label17";
               this.label17.Size = new System.Drawing.Size(60, 18);
               this.label17.TabIndex = 6;
               this.label17.Text = "Địa chỉ";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label6.ForeColor = System.Drawing.Color.Black;
               this.label6.Location = new System.Drawing.Point(787, 48);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(98, 18);
               this.label6.TabIndex = 4;
               this.label6.Text = "Chuẩn đoán";
               // 
               // label15
               // 
               this.label15.AutoSize = true;
               this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label15.ForeColor = System.Drawing.Color.Black;
               this.label15.Location = new System.Drawing.Point(436, 39);
               this.label15.Name = "label15";
               this.label15.Size = new System.Drawing.Size(127, 18);
               this.label15.TabIndex = 5;
               this.label15.Text = "Tên khách hàng";
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label10.ForeColor = System.Drawing.Color.Black;
               this.label10.Location = new System.Drawing.Point(105, 39);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(122, 18);
               this.label10.TabIndex = 4;
               this.label10.Text = "Mã khách hàng";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.Black;
               this.label5.Location = new System.Drawing.Point(105, 84);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(107, 18);
               this.label5.TabIndex = 3;
               this.label5.Text = "Mã nhân viên";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(105, 131);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(112, 18);
               this.label4.TabIndex = 2;
               this.label4.Text = "Tên nhân viên";
               // 
               // btnExit
               // 
               this.btnExit.ActiveBorderThickness = 1;
               this.btnExit.ActiveCornerRadius = 20;
               this.btnExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnExit.ActiveForecolor = System.Drawing.Color.White;
               this.btnExit.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnExit.BackColor = System.Drawing.Color.White;
               this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
               this.btnExit.ButtonText = "THOÁT";
               this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.btnExit.IdleBorderThickness = 1;
               this.btnExit.IdleCornerRadius = 20;
               this.btnExit.IdleFillColor = System.Drawing.Color.White;
               this.btnExit.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnExit.IdleLineColor = System.Drawing.Color.Red;
               this.btnExit.Location = new System.Drawing.Point(768, 358);
               this.btnExit.Margin = new System.Windows.Forms.Padding(5);
               this.btnExit.Name = "btnExit";
               this.btnExit.Size = new System.Drawing.Size(117, 71);
               this.btnExit.TabIndex = 12;
               this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
               // 
               // cancelInvoice
               // 
               this.cancelInvoice.ActiveBorderThickness = 1;
               this.cancelInvoice.ActiveCornerRadius = 20;
               this.cancelInvoice.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.cancelInvoice.ActiveForecolor = System.Drawing.Color.White;
               this.cancelInvoice.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.cancelInvoice.BackColor = System.Drawing.Color.White;
               this.cancelInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelInvoice.BackgroundImage")));
               this.cancelInvoice.ButtonText = "HỦY";
               this.cancelInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
               this.cancelInvoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cancelInvoice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.cancelInvoice.IdleBorderThickness = 1;
               this.cancelInvoice.IdleCornerRadius = 20;
               this.cancelInvoice.IdleFillColor = System.Drawing.Color.White;
               this.cancelInvoice.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.cancelInvoice.IdleLineColor = System.Drawing.Color.Red;
               this.cancelInvoice.Location = new System.Drawing.Point(439, 358);
               this.cancelInvoice.Margin = new System.Windows.Forms.Padding(5);
               this.cancelInvoice.Name = "cancelInvoice";
               this.cancelInvoice.Size = new System.Drawing.Size(105, 71);
               this.cancelInvoice.TabIndex = 11;
               this.cancelInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.cancelInvoice.Click += new System.EventHandler(this.cancelInvoice_Click);
               // 
               // btnSaveData
               // 
               this.btnSaveData.ActiveBorderThickness = 1;
               this.btnSaveData.ActiveCornerRadius = 20;
               this.btnSaveData.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnSaveData.ActiveForecolor = System.Drawing.Color.White;
               this.btnSaveData.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnSaveData.BackColor = System.Drawing.Color.White;
               this.btnSaveData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveData.BackgroundImage")));
               this.btnSaveData.ButtonText = "LƯU";
               this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnSaveData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSaveData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.btnSaveData.IdleBorderThickness = 1;
               this.btnSaveData.IdleCornerRadius = 20;
               this.btnSaveData.IdleFillColor = System.Drawing.Color.White;
               this.btnSaveData.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnSaveData.IdleLineColor = System.Drawing.Color.Red;
               this.btnSaveData.Location = new System.Drawing.Point(113, 358);
               this.btnSaveData.Margin = new System.Windows.Forms.Padding(5);
               this.btnSaveData.Name = "btnSaveData";
               this.btnSaveData.Size = new System.Drawing.Size(114, 71);
               this.btnSaveData.TabIndex = 10;
               this.btnSaveData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click_1);
               // 
               // groupBox2
               // 
               this.groupBox2.AutoSize = true;
               this.groupBox2.BackColor = System.Drawing.Color.White;
               this.groupBox2.Controls.Add(this.btnAddToInvoice);
               this.groupBox2.Controls.Add(this.Total);
               this.groupBox2.Controls.Add(this.txtPrice);
               this.groupBox2.Controls.Add(this.txtNameMedicine);
               this.groupBox2.Controls.Add(this.txtAmount);
               this.groupBox2.Controls.Add(this.txtID_Medicine);
               this.groupBox2.Controls.Add(this.panel1);
               this.groupBox2.Controls.Add(this.label16);
               this.groupBox2.Controls.Add(this.label14);
               this.groupBox2.Controls.Add(this.label13);
               this.groupBox2.Controls.Add(this.label12);
               this.groupBox2.Controls.Add(this.label11);
               this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
               this.groupBox2.ForeColor = System.Drawing.Color.Blue;
               this.groupBox2.Location = new System.Drawing.Point(0, 0);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(1196, 351);
               this.groupBox2.TabIndex = 0;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "THÔNG TIN ĐƠN HÀNG";
               // 
               // btnAddToInvoice
               // 
               this.btnAddToInvoice.ActiveBorderThickness = 1;
               this.btnAddToInvoice.ActiveCornerRadius = 20;
               this.btnAddToInvoice.ActiveFillColor = System.Drawing.Color.SeaGreen;
               this.btnAddToInvoice.ActiveForecolor = System.Drawing.Color.White;
               this.btnAddToInvoice.ActiveLineColor = System.Drawing.Color.SeaGreen;
               this.btnAddToInvoice.BackColor = System.Drawing.Color.White;
               this.btnAddToInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToInvoice.BackgroundImage")));
               this.btnAddToInvoice.ButtonText = "THÊM";
               this.btnAddToInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnAddToInvoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnAddToInvoice.ForeColor = System.Drawing.Color.DodgerBlue;
               this.btnAddToInvoice.IdleBorderThickness = 1;
               this.btnAddToInvoice.IdleCornerRadius = 20;
               this.btnAddToInvoice.IdleFillColor = System.Drawing.Color.White;
               this.btnAddToInvoice.IdleForecolor = System.Drawing.Color.SeaGreen;
               this.btnAddToInvoice.IdleLineColor = System.Drawing.Color.Crimson;
               this.btnAddToInvoice.Location = new System.Drawing.Point(874, 40);
               this.btnAddToInvoice.Margin = new System.Windows.Forms.Padding(5);
               this.btnAddToInvoice.Name = "btnAddToInvoice";
               this.btnAddToInvoice.Size = new System.Drawing.Size(143, 71);
               this.btnAddToInvoice.TabIndex = 14;
               this.btnAddToInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnAddToInvoice.Click += new System.EventHandler(this.btnAddToInvoice_Click);
               // 
               // Total
               // 
               this.Total.AutoSize = true;
               this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.Total.Location = new System.Drawing.Point(831, 307);
               this.Total.Name = "Total";
               this.Total.Size = new System.Drawing.Size(24, 25);
               this.Total.TabIndex = 10;
               this.Total.Text = "0";
               // 
               // txtPrice
               // 
               this.txtPrice.Location = new System.Drawing.Point(648, 86);
               this.txtPrice.Name = "txtPrice";
               this.txtPrice.Size = new System.Drawing.Size(170, 22);
               this.txtPrice.TabIndex = 12;
               this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
               // 
               // txtNameMedicine
               // 
               this.txtNameMedicine.Location = new System.Drawing.Point(647, 40);
               this.txtNameMedicine.Name = "txtNameMedicine";
               this.txtNameMedicine.ReadOnly = true;
               this.txtNameMedicine.Size = new System.Drawing.Size(170, 22);
               this.txtNameMedicine.TabIndex = 11;
               // 
               // txtAmount
               // 
               this.txtAmount.Location = new System.Drawing.Point(198, 87);
               this.txtAmount.Name = "txtAmount";
               this.txtAmount.Size = new System.Drawing.Size(170, 22);
               this.txtAmount.TabIndex = 10;
               this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
               // 
               // txtID_Medicine
               // 
               this.txtID_Medicine.Location = new System.Drawing.Point(198, 40);
               this.txtID_Medicine.Name = "txtID_Medicine";
               this.txtID_Medicine.ReadOnly = true;
               this.txtID_Medicine.Size = new System.Drawing.Size(170, 22);
               this.txtID_Medicine.TabIndex = 9;
               this.txtID_Medicine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox7_MouseDown);
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.dgvInvoice);
               this.panel1.Location = new System.Drawing.Point(108, 124);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(864, 177);
               this.panel1.TabIndex = 7;
               // 
               // dgvInvoice
               // 
               this.dgvInvoice.AllowUserToAddRows = false;
               this.dgvInvoice.AllowUserToDeleteRows = false;
               this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
               this.dgvInvoice.ContextMenuStrip = this.contextMenuStrip2;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle2;
               this.dgvInvoice.GridColor = System.Drawing.Color.White;
               this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
               this.dgvInvoice.Name = "dgvInvoice";
               this.dgvInvoice.ReadOnly = true;
               this.dgvInvoice.RowHeadersWidth = 51;
               this.dgvInvoice.RowTemplate.Height = 24;
               this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dgvInvoice.Size = new System.Drawing.Size(861, 177);
               this.dgvInvoice.TabIndex = 9;
               this.dgvInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellEndEdit);
               // 
               // Column1
               // 
               this.Column1.HeaderText = "Mã thuốc";
               this.Column1.MinimumWidth = 6;
               this.Column1.Name = "Column1";
               this.Column1.ReadOnly = true;
               // 
               // Column2
               // 
               this.Column2.HeaderText = "Tên thuốc";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.ReadOnly = true;
               // 
               // Column3
               // 
               this.Column3.HeaderText = "Số lượng";
               this.Column3.MinimumWidth = 6;
               this.Column3.Name = "Column3";
               this.Column3.ReadOnly = true;
               // 
               // Column4
               // 
               this.Column4.HeaderText = "Đơn giá";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
               this.Column4.ReadOnly = true;
               // 
               // Column5
               // 
               this.Column5.HeaderText = "Thành tiền";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.ReadOnly = true;
               // 
               // contextMenuStrip2
               // 
               this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaGiỏHàng});
               this.contextMenuStrip2.Name = "contextMenuStrip2";
               this.contextMenuStrip2.Size = new System.Drawing.Size(105, 28);
               // 
               // xóaGiỏHàng
               // 
               this.xóaGiỏHàng.Name = "xóaGiỏHàng";
               this.xóaGiỏHàng.Size = new System.Drawing.Size(104, 24);
               this.xóaGiỏHàng.Text = "Xóa";
               this.xóaGiỏHàng.Click += new System.EventHandler(this.xóaGiỏHàng_Click);
               // 
               // label16
               // 
               this.label16.AutoSize = true;
               this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label16.ForeColor = System.Drawing.Color.Red;
               this.label16.Location = new System.Drawing.Point(668, 304);
               this.label16.Name = "label16";
               this.label16.Size = new System.Drawing.Size(146, 29);
               this.label16.TabIndex = 4;
               this.label16.Text = "TỔNG TIỀN";
               // 
               // label14
               // 
               this.label14.AutoSize = true;
               this.label14.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label14.ForeColor = System.Drawing.Color.Black;
               this.label14.Location = new System.Drawing.Point(108, 42);
               this.label14.Name = "label14";
               this.label14.Size = new System.Drawing.Size(87, 30);
               this.label14.TabIndex = 5;
               this.label14.Text = "Mã thuốc";
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label13.ForeColor = System.Drawing.Color.Black;
               this.label13.Location = new System.Drawing.Point(108, 86);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(84, 30);
               this.label13.TabIndex = 4;
               this.label13.Text = "Số lượng";
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label12.ForeColor = System.Drawing.Color.Black;
               this.label12.Location = new System.Drawing.Point(523, 45);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(91, 30);
               this.label12.TabIndex = 3;
               this.label12.Text = "Tên thuốc";
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label11.ForeColor = System.Drawing.Color.Black;
               this.label11.Location = new System.Drawing.Point(523, 84);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(76, 30);
               this.label11.TabIndex = 2;
               this.label11.Text = "Đơn giá";
               // 
               // Order
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1187, 769);
               this.Controls.Add(this.splitContainer1);
               this.ForeColor = System.Drawing.Color.RoyalBlue;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Order";
               this.Text = "Order";
               this.splitContainer1.Panel1.ResumeLayout(false);
               this.splitContainer1.Panel2.ResumeLayout(false);
               this.splitContainer1.Panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
               this.splitContainer1.ResumeLayout(false);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               this.panel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
               this.contextMenuStrip2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.quanLyBanThuocDataSetBindingSource)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion
        private System.Windows.Forms.BindingSource quanLyBanThuocDataSetBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName_Manager;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNameMedicine;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtID_Medicine;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtID_Manager;
        private System.Windows.Forms.TextBox txtPhoneOrder;
        private System.Windows.Forms.TextBox txtAddress_Order;
        private System.Windows.Forms.TextBox txtName_Customer_Order;
        public System.Windows.Forms.TextBox txtID_Customer;
          private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
          private System.Windows.Forms.ToolStripMenuItem xóaGiỏHàng;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.Label Total;
        private System.Windows.Forms.RichTextBox txtDiagnostic;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtRemind;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelInvoice;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveData;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddToInvoice;
    }
}