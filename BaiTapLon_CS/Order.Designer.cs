namespace BaiTapLon_CS
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
               this.label1 = new System.Windows.Forms.Label();
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
               this.btnExit = new System.Windows.Forms.Button();
               this.printInvoice = new System.Windows.Forms.Button();
               this.cancelInvoice = new System.Windows.Forms.Button();
               this.btnSaveData = new System.Windows.Forms.Button();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
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
               this.btnAddToInvoice = new System.Windows.Forms.Button();
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
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
               this.label1.Location = new System.Drawing.Point(326, 30);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(395, 39);
               this.label1.TabIndex = 1;
               this.label1.Text = "CHI TIẾT ĐƠN THUỐC";
               this.label1.Click += new System.EventHandler(this.label1_Click);
               // 
               // splitContainer1
               // 
               this.splitContainer1.Location = new System.Drawing.Point(115, 12);
               this.splitContainer1.Name = "splitContainer1";
               this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
               this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
               this.splitContainer1.Panel1.Controls.Add(this.label1);
               this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
               // 
               // splitContainer1.Panel2
               // 
               this.splitContainer1.Panel2.Controls.Add(this.btnExit);
               this.splitContainer1.Panel2.Controls.Add(this.printInvoice);
               this.splitContainer1.Panel2.Controls.Add(this.cancelInvoice);
               this.splitContainer1.Panel2.Controls.Add(this.btnSaveData);
               this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
               this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
               this.splitContainer1.Size = new System.Drawing.Size(1046, 758);
               this.splitContainer1.SplitterDistance = 303;
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
               this.groupBox1.Location = new System.Drawing.Point(30, 91);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(1010, 200);
               this.groupBox1.TabIndex = 2;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin chung";
               this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
               // 
               // txtRemind
               // 
               this.txtRemind.Location = new System.Drawing.Point(825, 119);
               this.txtRemind.Name = "txtRemind";
               this.txtRemind.Size = new System.Drawing.Size(164, 39);
               this.txtRemind.TabIndex = 19;
               this.txtRemind.Text = "";
               // 
               // txtDiagnostic
               // 
               this.txtDiagnostic.Location = new System.Drawing.Point(825, 32);
               this.txtDiagnostic.Name = "txtDiagnostic";
               this.txtDiagnostic.Size = new System.Drawing.Size(164, 35);
               this.txtDiagnostic.TabIndex = 18;
               this.txtDiagnostic.Text = "";
               this.txtDiagnostic.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
               // 
               // txtID_Manager
               // 
               this.txtID_Manager.Location = new System.Drawing.Point(149, 90);
               this.txtID_Manager.Name = "txtID_Manager";
               this.txtID_Manager.ReadOnly = true;
               this.txtID_Manager.Size = new System.Drawing.Size(170, 22);
               this.txtID_Manager.TabIndex = 17;
               // 
               // txtID_Customer
               // 
               this.txtID_Customer.Location = new System.Drawing.Point(149, 45);
               this.txtID_Customer.Name = "txtID_Customer";
               this.txtID_Customer.ReadOnly = true;
               this.txtID_Customer.Size = new System.Drawing.Size(170, 22);
               this.txtID_Customer.TabIndex = 16;
               this.txtID_Customer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox17_MouseClick);
               this.txtID_Customer.TextChanged += new System.EventHandler(this.txtID_Customer_TextChanged);
               this.txtID_Customer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtID_Customer_MouseDown);
               // 
               // txtPhoneOrder
               // 
               this.txtPhoneOrder.Location = new System.Drawing.Point(491, 140);
               this.txtPhoneOrder.Name = "txtPhoneOrder";
               this.txtPhoneOrder.ReadOnly = true;
               this.txtPhoneOrder.Size = new System.Drawing.Size(170, 22);
               this.txtPhoneOrder.TabIndex = 15;
               this.txtPhoneOrder.TextChanged += new System.EventHandler(this.txtPhoneOrder_TextChanged);
               // 
               // txtAddress_Order
               // 
               this.txtAddress_Order.Location = new System.Drawing.Point(491, 90);
               this.txtAddress_Order.Name = "txtAddress_Order";
               this.txtAddress_Order.ReadOnly = true;
               this.txtAddress_Order.Size = new System.Drawing.Size(170, 22);
               this.txtAddress_Order.TabIndex = 14;
               this.txtAddress_Order.TextChanged += new System.EventHandler(this.txtAddress_Order_TextChanged);
               // 
               // txtName_Customer_Order
               // 
               this.txtName_Customer_Order.Location = new System.Drawing.Point(491, 45);
               this.txtName_Customer_Order.Name = "txtName_Customer_Order";
               this.txtName_Customer_Order.ReadOnly = true;
               this.txtName_Customer_Order.Size = new System.Drawing.Size(170, 22);
               this.txtName_Customer_Order.TabIndex = 13;
               this.txtName_Customer_Order.TextChanged += new System.EventHandler(this.txtName_Customer_Order_TextChanged);
               // 
               // txtName_Manager
               // 
               this.txtName_Manager.Location = new System.Drawing.Point(149, 140);
               this.txtName_Manager.Name = "txtName_Manager";
               this.txtName_Manager.ReadOnly = true;
               this.txtName_Manager.Size = new System.Drawing.Size(170, 22);
               this.txtName_Manager.TabIndex = 11;
               // 
               // label18
               // 
               this.label18.AutoSize = true;
               this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label18.Location = new System.Drawing.Point(337, 144);
               this.label18.Name = "label18";
               this.label18.Size = new System.Drawing.Size(84, 18);
               this.label18.TabIndex = 7;
               this.label18.Text = "Điện thoại";
               this.label18.Click += new System.EventHandler(this.label18_Click);
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label7.Location = new System.Drawing.Point(696, 140);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(72, 18);
               this.label7.TabIndex = 5;
               this.label7.Text = "Lời nhắc";
               this.label7.Click += new System.EventHandler(this.label7_Click);
               // 
               // label17
               // 
               this.label17.AutoSize = true;
               this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label17.Location = new System.Drawing.Point(337, 94);
               this.label17.Name = "label17";
               this.label17.Size = new System.Drawing.Size(60, 18);
               this.label17.TabIndex = 6;
               this.label17.Text = "Địa chỉ";
               this.label17.Click += new System.EventHandler(this.label17_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label6.Location = new System.Drawing.Point(696, 49);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(98, 18);
               this.label6.TabIndex = 4;
               this.label6.Text = "Chuẩn đoán";
               this.label6.Click += new System.EventHandler(this.label6_Click);
               // 
               // label15
               // 
               this.label15.AutoSize = true;
               this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label15.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label15.Location = new System.Drawing.Point(337, 49);
               this.label15.Name = "label15";
               this.label15.Size = new System.Drawing.Size(127, 18);
               this.label15.TabIndex = 5;
               this.label15.Text = "Tên khách hàng";
               this.label15.Click += new System.EventHandler(this.label15_Click);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label10.Location = new System.Drawing.Point(12, 45);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(122, 18);
               this.label10.TabIndex = 4;
               this.label10.Text = "Mã khách hàng";
               this.label10.Click += new System.EventHandler(this.label10_Click);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label5.Location = new System.Drawing.Point(12, 94);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(107, 18);
               this.label5.TabIndex = 3;
               this.label5.Text = "Mã nhân viên";
               this.label5.Click += new System.EventHandler(this.label5_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
               this.label4.Location = new System.Drawing.Point(12, 144);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(112, 18);
               this.label4.TabIndex = 2;
               this.label4.Text = "Tên nhân viên";
               this.label4.Click += new System.EventHandler(this.label4_Click);
               // 
               // btnExit
               // 
               this.btnExit.BackColor = System.Drawing.Color.White;
               this.btnExit.Location = new System.Drawing.Point(828, 348);
               this.btnExit.Name = "btnExit";
               this.btnExit.Size = new System.Drawing.Size(85, 58);
               this.btnExit.TabIndex = 9;
               this.btnExit.Text = "Thoát";
               this.btnExit.UseVisualStyleBackColor = false;
               this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
               // 
               // printInvoice
               // 
               this.printInvoice.BackColor = System.Drawing.Color.White;
               this.printInvoice.Location = new System.Drawing.Point(601, 348);
               this.printInvoice.Name = "printInvoice";
               this.printInvoice.Size = new System.Drawing.Size(90, 56);
               this.printInvoice.TabIndex = 8;
               this.printInvoice.Text = "In hóa đơn";
               this.printInvoice.UseVisualStyleBackColor = false;
               this.printInvoice.Click += new System.EventHandler(this.printInvoice_Click);
               // 
               // cancelInvoice
               // 
               this.cancelInvoice.BackColor = System.Drawing.Color.White;
               this.cancelInvoice.Location = new System.Drawing.Point(370, 348);
               this.cancelInvoice.Name = "cancelInvoice";
               this.cancelInvoice.Size = new System.Drawing.Size(101, 58);
               this.cancelInvoice.TabIndex = 7;
               this.cancelInvoice.Text = "Hủy hóa đơn";
               this.cancelInvoice.UseVisualStyleBackColor = false;
               this.cancelInvoice.Click += new System.EventHandler(this.button3_Click);
               // 
               // btnSaveData
               // 
               this.btnSaveData.BackColor = System.Drawing.Color.White;
               this.btnSaveData.Location = new System.Drawing.Point(125, 348);
               this.btnSaveData.Name = "btnSaveData";
               this.btnSaveData.Size = new System.Drawing.Size(102, 58);
               this.btnSaveData.TabIndex = 6;
               this.btnSaveData.Text = "Lưu hóa đơn";
               this.btnSaveData.UseVisualStyleBackColor = false;
               this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
               // 
               // groupBox2
               // 
               this.groupBox2.BackColor = System.Drawing.Color.White;
               this.groupBox2.Controls.Add(this.Total);
               this.groupBox2.Controls.Add(this.txtPrice);
               this.groupBox2.Controls.Add(this.txtNameMedicine);
               this.groupBox2.Controls.Add(this.txtAmount);
               this.groupBox2.Controls.Add(this.txtID_Medicine);
               this.groupBox2.Controls.Add(this.panel1);
               this.groupBox2.Controls.Add(this.label16);
               this.groupBox2.Controls.Add(this.btnAddToInvoice);
               this.groupBox2.Controls.Add(this.label14);
               this.groupBox2.Controls.Add(this.label13);
               this.groupBox2.Controls.Add(this.label12);
               this.groupBox2.Controls.Add(this.label11);
               this.groupBox2.Location = new System.Drawing.Point(30, 3);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(1010, 339);
               this.groupBox2.TabIndex = 0;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Thông tin các mặt hàng";
               this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
               // 
               // Total
               // 
               this.Total.AutoSize = true;
               this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.Total.Location = new System.Drawing.Point(820, 310);
               this.Total.Name = "Total";
               this.Total.Size = new System.Drawing.Size(24, 25);
               this.Total.TabIndex = 10;
               this.Total.Text = "0";
               // 
               // txtPrice
               // 
               this.txtPrice.Location = new System.Drawing.Point(613, 74);
               this.txtPrice.Name = "txtPrice";
               this.txtPrice.Size = new System.Drawing.Size(170, 22);
               this.txtPrice.TabIndex = 12;
               this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
               this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
               // 
               // txtNameMedicine
               // 
               this.txtNameMedicine.Location = new System.Drawing.Point(612, 28);
               this.txtNameMedicine.Name = "txtNameMedicine";
               this.txtNameMedicine.ReadOnly = true;
               this.txtNameMedicine.Size = new System.Drawing.Size(170, 22);
               this.txtNameMedicine.TabIndex = 11;
               // 
               // txtAmount
               // 
               this.txtAmount.Location = new System.Drawing.Point(163, 75);
               this.txtAmount.Name = "txtAmount";
               this.txtAmount.Size = new System.Drawing.Size(170, 22);
               this.txtAmount.TabIndex = 10;
               this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
               // 
               // txtID_Medicine
               // 
               this.txtID_Medicine.Location = new System.Drawing.Point(163, 28);
               this.txtID_Medicine.Name = "txtID_Medicine";
               this.txtID_Medicine.ReadOnly = true;
               this.txtID_Medicine.Size = new System.Drawing.Size(170, 22);
               this.txtID_Medicine.TabIndex = 9;
               this.txtID_Medicine.TextChanged += new System.EventHandler(this.txtID_Medicine_TextChanged);
               this.txtID_Medicine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox7_MouseDown);
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.dgvInvoice);
               this.panel1.Location = new System.Drawing.Point(34, 124);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(938, 177);
               this.panel1.TabIndex = 7;
               // 
               // dgvInvoice
               // 
               this.dgvInvoice.AllowUserToOrderColumns = true;
               this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
               this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
               this.dgvInvoice.ContextMenuStrip = this.contextMenuStrip2;
               this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dgvInvoice.GridColor = System.Drawing.SystemColors.Highlight;
               this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
               this.dgvInvoice.Name = "dgvInvoice";
               this.dgvInvoice.RowHeadersWidth = 51;
               this.dgvInvoice.RowTemplate.Height = 24;
               this.dgvInvoice.Size = new System.Drawing.Size(938, 177);
               this.dgvInvoice.TabIndex = 9;
               this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
               this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
               this.dgvInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellEndEdit);
               this.dgvInvoice.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellValueChanged);
               this.dgvInvoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvInvoice_MouseClick);
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
               // 
               // Column4
               // 
               this.Column4.HeaderText = "Đơn giá";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
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
               this.label16.Location = new System.Drawing.Point(637, 310);
               this.label16.Name = "label16";
               this.label16.Size = new System.Drawing.Size(146, 29);
               this.label16.TabIndex = 4;
               this.label16.Text = "TỔNG TIỀN";
               // 
               // btnAddToInvoice
               // 
               this.btnAddToInvoice.BackColor = System.Drawing.Color.White;
               this.btnAddToInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
               this.btnAddToInvoice.ForeColor = System.Drawing.Color.Black;
               this.btnAddToInvoice.Location = new System.Drawing.Point(836, 28);
               this.btnAddToInvoice.Name = "btnAddToInvoice";
               this.btnAddToInvoice.Size = new System.Drawing.Size(83, 69);
               this.btnAddToInvoice.TabIndex = 5;
               this.btnAddToInvoice.Text = "THÊM";
               this.btnAddToInvoice.UseVisualStyleBackColor = false;
               this.btnAddToInvoice.Click += new System.EventHandler(this.btnAddToInvoice_Click);
               // 
               // label14
               // 
               this.label14.AutoSize = true;
               this.label14.Location = new System.Drawing.Point(73, 30);
               this.label14.Name = "label14";
               this.label14.Size = new System.Drawing.Size(66, 17);
               this.label14.TabIndex = 5;
               this.label14.Text = "Mã thuốc";
               this.label14.Click += new System.EventHandler(this.label14_Click);
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.Location = new System.Drawing.Point(73, 74);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(64, 17);
               this.label13.TabIndex = 4;
               this.label13.Text = "Số lượng";
               this.label13.Click += new System.EventHandler(this.label13_Click);
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Location = new System.Drawing.Point(488, 33);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(72, 17);
               this.label12.TabIndex = 3;
               this.label12.Text = "Tên thuốc";
               this.label12.Click += new System.EventHandler(this.label12_Click);
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Location = new System.Drawing.Point(488, 72);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(57, 17);
               this.label11.TabIndex = 2;
               this.label11.Text = "Đơn giá";
               this.label11.Click += new System.EventHandler(this.label11_Click);
               // 
               // Order
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1211, 758);
               this.Controls.Add(this.splitContainer1);
               this.ForeColor = System.Drawing.Color.RoyalBlue;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Order";
               this.Text = "Order";
               this.Load += new System.EventHandler(this.Order_Load);
               this.splitContainer1.Panel1.ResumeLayout(false);
               this.splitContainer1.Panel1.PerformLayout();
               this.splitContainer1.Panel2.ResumeLayout(false);
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
   //     private QuanLyBanThuocDataSet quanLyBanThuocDataSet;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button printInvoice;
        private System.Windows.Forms.Button cancelInvoice;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnAddToInvoice;
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
    }
}