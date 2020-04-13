using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CS
{

     public partial class SearchCustomer : Form
     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
         
          
          public delegate void sendData(string a,string b,string c,string d);
          public sendData sender;
          public void DisplayListView(string query)
          {

               SqlCommand com = new SqlCommand();
               com.Connection = con;
               com.CommandText = query;
               con.Open();
               SqlDataReader reader = com.ExecuteReader();
               if (reader.HasRows)
               {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvSearchCustomer.DataSource = dt;
                    dgvSearchCustomer.Columns[0].HeaderText = "Mã KH";
                    dgvSearchCustomer.Columns[1].HeaderText = "Tên KH";
                    dgvSearchCustomer.Columns[2].HeaderText = "Giới tính";
                    dgvSearchCustomer.Columns[3].HeaderText = "Địa chỉ";
                    dgvSearchCustomer.Columns[4].HeaderText = "Tuổi";
               }
               con.Close();
          }
          public SearchCustomer(sendData _sender)
          {
               
               
               InitializeComponent();
               this.sender = _sender;
               string query = "SELECT * FROM Customer";
               DisplayListView(query);
          }
          

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void btnSearchCustomer_Click(object sender, EventArgs e)
          {
               dgvSearchCustomer.DataSource = null;
               if (cbTypeSearch.SelectedIndex == 0) // tìm kiếm theo mã khách hàng
               {
                    string query = "SELECT * FROM Customer WHERE ID_Customer= " + txtSearchCustomer.Text;
                    DisplayListView(query);


               }
               if (cbTypeSearch.SelectedIndex == 1) // tìm kiếm theo họ tên 
               {
                    string query = "SELECT * FROM Customer WHERE  Name_Customer LIKE " + "N'%" + txtSearchCustomer.Text + "%'";
                    DisplayListView(query);
               }
               if (cbTypeSearch.SelectedIndex == 2) // tìm kiếm theo địa chỉ
               {
                    string query = "SELECT * FROM Customer WHERE  Phone LIKE " + "N'%" + txtSearchCustomer.Text + "%'";
                    DisplayListView(query);
               }
               if (cbTypeSearch.SelectedIndex == 3) // tìm kiếm theo địa chỉ
               {
                    string query = "SELECT * FROM Customer WHERE  Email LIKE " + "N'%" + txtSearchCustomer.Text + "%'";
                    DisplayListView(query);
               }
          }

          private void dgvSearchCustomer_MouseClick(object sender, MouseEventArgs e)
          {
                    int row = dgvSearchCustomer.CurrentCell.RowIndex;
                    var ID_Customer= dgvSearchCustomer.Rows[row].Cells[0].Value.ToString();
                    var Name_Customer= dgvSearchCustomer.Rows[row].Cells[1].Value.ToString();
                    var Address_Customer= dgvSearchCustomer.Rows[row].Cells[3].Value.ToString();
                    var Phone_Customer=dgvSearchCustomer.Rows[row].Cells[5].Value.ToString();
                     this.sender(ID_Customer, Name_Customer, Address_Customer, Phone_Customer);
                    this.Hide();
          }
     }
}
