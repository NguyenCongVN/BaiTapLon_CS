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
     public partial class Search_Medicine : Form

     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);


          public delegate void sendData(string a, string b);
          public sendData sender;
          public void DisplayListView(string query)
          {
               try
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

                         dgvSearchMedicine.DataSource = dt;
                         dgvSearchMedicine.Columns[0].HeaderText = "Mã thuốc";
                         dgvSearchMedicine.Columns[1].HeaderText = "Tên thuốc";
                         dgvSearchMedicine.Columns[2].Visible = false;

                         dgvSearchMedicine.Columns[3].HeaderText = "Xuất xứ";

                         dgvSearchMedicine.Columns[4].HeaderText = "Đóng gói";
                         dgvSearchMedicine.Columns[5].HeaderText = "Đơn vị";
                         dgvSearchMedicine.Columns[6].HeaderText = "Số đăng ký";
                    }
                    con.Close();
               }
               catch (Exception e)
               {
                    MessageBox.Show("Dữ liệu bạn tìm không có, vui lòng thử lại");
                    return;
               }
          }
               public Search_Medicine(sendData _sendData)
               {
                    InitializeComponent();

               this.sender = _sendData;
               string query = "SELECT * FROM Medicine";
               DisplayListView(query);
          }

          private void button1_Click(object sender, EventArgs e)
        {
               dgvSearchMedicine.DataSource = null;
               if(cBtype.SelectedIndex == 0)
               {
                    string query = "SELECT * FROM Medicine WHERE ID_Medicine="+txtSearch.Text;
                    DisplayListView(query);
               }
               else if (cBtype.SelectedIndex == 1)
               {
                    string query = "SELECT * FROM Medicine WHERE  Name_Medicine LIKE " + "N'%" + txtSearch.Text + "%'";
                    DisplayListView(query);
               }
        }

          private void dgvSearchMedicine_MouseClick(object sender, MouseEventArgs e)
          {
               int row = dgvSearchMedicine.CurrentCell.RowIndex;
               var ID_Medicine = dgvSearchMedicine.Rows[row].Cells[0].Value.ToString();
               var Name_Medicine = dgvSearchMedicine.Rows[row].Cells[1].Value.ToString();
               this.sender(ID_Medicine, Name_Medicine);
               this.Hide();
               
          }
     }
}
