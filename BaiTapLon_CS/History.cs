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
     public partial class History : Form
     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
          public string getCount_Order()
          {
               string query = "SELECT Count(ID_Invoice) FROM Invoice as inv Where inv.ID_Manager = "+ Form1.ID_Manager;
               con.Open();
               string ID_Order;
               using (SqlDataAdapter da = new SqlDataAdapter(query, connect))
               {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ID_Order = dt.Rows[0][0].ToString();
               }
               return ID_Order;

          }
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
                         dgvHistory.DataSource = dt;
                         dgvHistory.Columns[0].HeaderText = "Mã hóa đơn";
                         dgvHistory.Columns[1].HeaderText = "Họ tên";
                         dgvHistory.Columns[2].HeaderText = "Tên thuốc";

                         dgvHistory.Columns[3].HeaderText = "Ngày bán";
                         dgvHistory.Columns[4].HeaderText = "Giá";
                         dgvHistory.Columns[5].HeaderText = "Số lượng";
                         dgvHistory.Columns[6].HeaderText = "Thành tiền";

                         con.Close();
                    }
                    else
                    {
                         MessageBox.Show("Chưa có dữ liệu cho danh mục bạn cần thống kê");
                    }
               }
               catch (Exception e)
               {
                    MessageBox.Show("Lỗi " + e);
               }


          }
          public History()
          {
               InitializeComponent();
               string query = "SELECT inv.ID_Invoice,cu.Name_Customer,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost * inde.Amount FROM Customer as cu,dbo.Medicine AS me,Invoice as inv, Invoice_Detail as inde where me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice= inv.ID_Invoice AND cu.ID_Customer= inv.ID_Customer";
               DisplayListView(query);
               int total = this.dgvHistory.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[6].Value));
               txtTotal.Text = total.ToString();

               txtOrder.Text = getCount_Order();

               txtAmount_Product.Text = this.dgvHistory.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value)).ToString();
          }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
