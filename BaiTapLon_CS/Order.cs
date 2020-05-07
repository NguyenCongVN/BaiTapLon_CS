using BaiTapLon_CS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
     public partial class Order : Form
     {
         
          public Order()
          {
               InitializeComponent();
               txtID_Manager.Text = LoginDAO.ID_Manager;
               txtName_Manager.Text = LoginDAO.Name_Manager;
          }
          public  void fillCustomer(string a,string b,string c,string d)
          {
               txtID_Customer.Text = a;
               txtName_Customer_Order.Text = b;
               txtAddress_Order.Text = c;
               txtPhoneOrder.Text = d;
               txtID_Medicine.Focus();
              
          }
          public void fillMedicine(string a, string b)
          {
               txtID_Medicine.Text = a;
               txtNameMedicine.Text = b;
               txtAmount.Focus();
          }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

          private void groupBox1_Enter(object sender, EventArgs e)
          {

          }

          private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
          {

          }

          private void groupBox2_Enter(object sender, EventArgs e)
          {

          }

          private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

        private void textBox17_MouseClick(object sender, MouseEventArgs e)
        {
               
               
          }

          private void txtID_Customer_TextChanged(object sender, EventArgs e)
          {
               
          }

          private void textBox7_MouseDown(object sender, MouseEventArgs e)
          {
               Search_Medicine search_Medicine = new Search_Medicine(fillMedicine);
               search_Medicine.Show();
          }

          private void txtID_Customer_MouseDown(object sender, MouseEventArgs e)
          {
               SearchCustomer searchCustomer = new SearchCustomer(fillCustomer);
               searchCustomer.Show();
          }

          private void txtID_Medicine_TextChanged(object sender, EventArgs e)
          {

          }
          
          private void btnAddToInvoice_Click(object sender, EventArgs e) // thêm
          {
                    var index = this.dgvInvoice.Rows.Count;
                    this.dgvInvoice.Rows.Add();
                    this.dgvInvoice.Rows[index - 1].Cells[0].Value = txtID_Medicine.Text;
                    this.dgvInvoice.Rows[index - 1].Cells[1].Value = txtNameMedicine.Text;
                    this.dgvInvoice.Rows[index - 1].Cells[2].Value = txtAmount.Text;
                    this.dgvInvoice.Rows[index - 1].Cells[3].Value = txtPrice.Text;
                    this.dgvInvoice.Rows[index - 1].Cells[4].Value = int.Parse(txtAmount.Text) * decimal.Parse(txtPrice.Text);
                    decimal total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));

               CultureInfo culture = new CultureInfo("en-US");

               Total.Text = String.Format(culture, "{0:N0}", decimal.Parse(total.ToString(), NumberStyles.AllowThousands));
                    txtID_Medicine.Text = "";
                    txtPrice.Text = "";
                    txtAmount.Text = "";
                    txtNameMedicine.Text = "";
                    txtID_Medicine.Focus();
          }

          private void dgvInvoice_MouseClick(object sender, MouseEventArgs e)
          {
               
               
          }

          private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
          {
          }

          private void xóaGiỏHàng_Click(object sender, EventArgs e)
          {
               
               int row = dgvInvoice.CurrentCell.RowIndex;
               this.dgvInvoice.Rows.RemoveAt(row);
               int total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));

               Total.Text = total.ToString();
          }

          private void sửaGiỏHàng_Click(object sender, EventArgs e)
          {
               int row = dgvInvoice.CurrentCell.RowIndex;
               int total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));

               Total.Text = total.ToString();

          }

          private void dgvInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
          {
          }

          private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
          {
              int row = dgvInvoice.CurrentCell.RowIndex;
               int x,y;

               try
               {
                    int ID_Medicine = int.Parse(this.dgvInvoice.Rows[row].Cells[0].Value.ToString());
                    
                    x = int.Parse(this.dgvInvoice.Rows[row].Cells[2].Value.ToString());
                    y = int.Parse(this.dgvInvoice.Rows[row].Cells[3].Value.ToString());
                    
                
                         this.dgvInvoice.Rows[row].Cells[4].Value = x * y;
                         int total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
                         Total.Text = total.ToString();    
               }
               catch (Exception)
               {
                    MessageBox.Show("Mời bạn nhập đúng định dạng là số");
               }
              
           

              
          }

        private void button3_Click(object sender, EventArgs e)
        {
               dgvInvoice.Rows.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

          private void txtName_Customer_Order_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtAddress_Order_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtPhoneOrder_TextChanged(object sender, EventArgs e)
          {

          }

          private void btnSaveData_Click(object sender, EventArgs e)
          {
               if (dgvInvoice.Rows.Count == 1)
               {
                    MessageBox.Show("Bạn cần nhập thuốc vào bảng trước khi lưu");
               }
               else
               {
                    if (txtID_Customer.Text != "")
                    {
                         string id_invoice= "SELECT MAX(ID_Invoice) FROM Invoice";
                         string query = "INSERT INTO Invoice (ID_Customer,Diagnostic,Time_Of_Purchase,ID_Manager,Remind) VALUES(" +
                              int.Parse(txtID_Customer.Text) + ",N'" + txtDiagnostic.Text + "'," + "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',"
                              + int.Parse(txtID_Manager.Text) + ",N'" + txtRemind.Text+"')";
                       OrderDAO.Instance.AddOrder(query);
                         string ID_Invoice = OrderDAO.Instance.getCountID_Invoice(id_invoice);
                         for (int i = 0; i < dgvInvoice.Rows.Count - 1; i++)
                         {
                              string que = "INSERT Invoice_Detail( ID_Invoice ,ID_Medicine ,Cost ,Amount)VALUES("+ int.Parse(ID_Invoice)+"," + int.Parse(this.dgvInvoice.Rows[i].Cells[0].Value.ToString()) + "," + decimal.Parse(dgvInvoice.Rows[i].Cells[3].Value.ToString()) + "," + int.Parse(dgvInvoice.Rows[i].Cells[2].Value.ToString()) + ")";
                              OrderDAO.Instance.AddOrder(que); // lưu vào cơ sở dữ liệu




                         }
                         dgvInvoice.Rows.Clear();
                         txtAddress_Order.Text = "";
                         txtDiagnostic.Text = "";
                         txtName_Customer_Order.Text = "";
                         txtRemind.Text = "";
                         txtPhoneOrder.Text = "";
                         txtAddress_Order.Text = "";
                         txtID_Customer.Text = "";
                         txtID_Customer.Focus();
                         MessageBox.Show("Thêm hóa đơn thành công, bạn có muốn in hóa đơn không");
                    }
                    else
                    {
                         MessageBox.Show("Bạn cần nhập thông tin khách hàng trước");
                    }
               }
          }
          private void Order_Load(object sender, EventArgs e)
          {
          }

          private void label18_Click(object sender, EventArgs e)
          {

          }

          private void label8_Click(object sender, EventArgs e)
          {

          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void label6_Click(object sender, EventArgs e)
          {

          }

          private void label5_Click(object sender, EventArgs e)
          {

          }

          private void label12_Click(object sender, EventArgs e)
          {

          }

          private void printInvoice_Click(object sender, EventArgs e)
          {

          }

          private void label17_Click(object sender, EventArgs e)
          {

          }

          private void label2_Click(object sender, EventArgs e)
          {

          }

          private void label11_Click(object sender, EventArgs e)
          {

          }

          private void btnExit_Click(object sender, EventArgs e)
          {

          }

          private void label15_Click(object sender, EventArgs e)
          {

          }

          private void label13_Click(object sender, EventArgs e)
          {

          }

          private void label7_Click(object sender, EventArgs e)
          {

          }

          private void label3_Click(object sender, EventArgs e)
          {

          }

          private void label14_Click(object sender, EventArgs e)
          {

          }

          private void label10_Click(object sender, EventArgs e)
          {

          }

          private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
          }

          private void txtPrice_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
          }
     }
}
