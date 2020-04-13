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
     public partial class SearchOrder : Form
     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
          public void DisplayListView(string query)
          {
               try
               {
                    SqlCommand com = new SqlCommand();

                    com.Connection = con;

                    com.CommandText = query;
                    con.Close();
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)

                    {
                         DataTable dt = new DataTable();
                         dt.Load(reader);
                         dgvOrder_Search.DataSource = dt;
                         dgvOrder_Search.Columns[0].Visible = false;
                         dgvOrder_Search.Columns[1].HeaderText = "Tên KH";
                         dgvOrder_Search.Columns[2].HeaderText = "Địa chỉ";
                         dgvOrder_Search.Columns[3].HeaderText = "Giới tính";
                         dgvOrder_Search.Columns[4].HeaderText = "Tuổi";
                         dgvOrder_Search.Columns[5].HeaderText = "Số ĐT";
                         dgvOrder_Search.Columns[6].HeaderText = "Mã HĐ";
                         dgvOrder_Search.Columns[7].Visible =false;
                         dgvOrder_Search.Columns[8].HeaderText = "Chuẩn đoán";
                         dgvOrder_Search.Columns[9].HeaderText = "TG mua";
                         dgvOrder_Search.Columns[10].HeaderText = "Mã NV";
                         dgvOrder_Search.Columns[12].Visible = false;
                         dgvOrder_Search.Columns[11].Visible =false;



                    }
                    else
                    {
                         MessageBox.Show("Dữ liệu bạn vừa nhập vào không tìm thấy");
                    }
                    con.Close();
               }
               catch (Exception e)
               {
                    MessageBox.Show("Lỗi cú pháp rồi "+e);
                    return;
               }
          }
          public SearchOrder()
          {
               InitializeComponent();
          }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
               dgvOrder_Search.DataSource = null;
               var Subquery = "";
               var isIndex = true;
               if(txtID_Invoice.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "inv.ID_Invoice=" + txtID_Invoice.Text;
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and inv.ID_Invoice=" + txtID_Invoice.Text;
                    }
               }
               if(txtName_Customer.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "cu.Name_Customer LIKE N'%" + txtName_Customer.Text+"%'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and cu.Name_Customer LIKE N'%" + txtName_Customer.Text + "%'";
                    }

               }
               if(txtPhone.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "cu.Phone=" + txtPhone.Text;
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and cu.Phone=" + txtPhone.Text;

                    }
               }
               if(txtID_Customer.Text!= "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "cu.ID_Customer=" + txtID_Customer.Text;
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and cu.ID_Customer=" + txtID_Customer.Text;
                    }
               }
               var aDate = new DateTime(2015, 1, 1,0,0,0);
               if (timeOrderSearch.Value != aDate)
               {
                    if (isIndex == true)
                    {
                         Subquery += "YEAR(inv.Time_Of_Purchase)="+ timeOrderSearch.Value.Year+" and MONTH(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Month+" and DAY(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Day;
                         isIndex = false;
                    }
                    else
                    {
                        Subquery += " and YEAR(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Year + " and MONTH(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Month + " and DAY(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Day;
                    }
               }
               string query = "SELECT * FROM Customer AS cu JOIN Invoice AS inv ON " + Subquery+" and cu.ID_Customer = inv.ID_Customer";
               if (Subquery == "")
               {
                    MessageBox.Show("Bạn chưa nhập thông tin gì cả nhaaaaa");
               }
               else
               {
                    DisplayListView(query);
               }

        }

          private void txtID_Medicine_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
          }

          private void txtID_Customer_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
          }

          private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
          }
     }
}
