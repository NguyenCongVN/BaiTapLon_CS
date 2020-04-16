using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using Microsoft;

namespace BaiTapLon_CS
{
     public partial class History : Form
     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
          private readonly object v1;

          public string getCount_Order()
          {
               string query = "SELECT Count(ID_Invoice) FROM Invoice as inv Where inv.ID_Manager = " + Form1.ID_Manager;
               con.Close();
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
                    con.Close();
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                         DataTable dt = new DataTable();
                         dt.Load(reader);
                         dgvHistory.DataSource = dt;
                         dgvHistory.Columns[0].HeaderText = "Mã hóa đơn";
                         dgvHistory.Columns[1].HeaderText = "Họ tên";
                         dgvHistory.Columns[2].HeaderText = "Mã thuốc";
                         dgvHistory.Columns[3].HeaderText = "Tên thuốc";

                         dgvHistory.Columns[4].HeaderText = "Ngày bán";
                         dgvHistory.Columns[5].HeaderText = "Giá";
                         dgvHistory.Columns[6].HeaderText = "Số lượng";
                         dgvHistory.Columns[7].HeaderText = "Thành tiền";
                         dgvHistory.Columns[5].DefaultCellStyle.Format = "n0";
                         dgvHistory.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
                         dgvHistory.Columns[7].DefaultCellStyle.Format = "n0";
                         dgvHistory.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");

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
               string query = "SELECT inv.ID_Invoice,cu.Name_Customer,me.ID_Medicine,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost * inde.Amount FROM Customer as cu,dbo.Medicine AS me,Invoice as inv, Invoice_Detail as inde where me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice= inv.ID_Invoice AND cu.ID_Customer= inv.ID_Customer";
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

          private void btnExcel_Click(object sender, EventArgs e)
          {



               SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
               //using GemBox library now
               ExcelFile myExcelFile = new ExcelFile();
               ExcelWorksheet excWsheet = myExcelFile.Worksheets.Add("Lịch sử");
               excWsheet.Cells[0, 0].Value = "THỐNG KÊ LỊCH SỬ BÁN HÀNG";
               excWsheet.Cells[0, 0].Style.Borders.SetBorders(MultipleBorders.Bottom, System.Drawing.Color.Red, LineStyle.Thin);
               excWsheet.Cells[0, 1].Style.Borders.SetBorders(MultipleBorders.Bottom, System.Drawing.Color.Red, LineStyle.Thin);


               //for each column
               for (int c = 0; c <dgvHistory.Columns.Count; c++)
               {
                    excWsheet.Columns[c].Width = 25 * 256; //set the width to each column                
               }

               //header row cells
               excWsheet.Rows[2].Cells[0].Value = "Mã hóa đơn";
               excWsheet.Rows[2].Cells[1].Value = "Khách hàng";
               excWsheet.Rows[2].Cells[2].Value = "Tên thuốc";
               excWsheet.Rows[2].Cells[3].Value = "Ngày bán";
               excWsheet.Rows[2].Cells[4].Value = "Đơn giá";
               excWsheet.Rows[2].Cells[5].Value = "Số lượng";

               excWsheet.Rows[2].Cells[6].Value = "Thành tiền";

               for (int i=0;i<dgvHistory.Rows.Count;i++)
               {
                    for(int j=0;j<dgvHistory.Columns.Count;j++)
                    {
                         excWsheet.Rows[i+3].Cells[j].Value = dgvHistory.Rows[i].Cells[j].Value;
                    }
               }
               //stylizing my excel file look
               CellStyle style = new CellStyle(myExcelFile);
               style.HorizontalAlignment = HorizontalAlignmentStyle.Left;
               style.VerticalAlignment = VerticalAlignmentStyle.Center;
               style.Font.Color = Color.DarkRed;
               style.WrapText = true;
               style.Borders.SetBorders(MultipleBorders.Top| MultipleBorders.Left | MultipleBorders.Right| MultipleBorders.Bottom, System.Drawing.Color.Black,LineStyle.Thin);
               myExcelFile.Save("C:\\Users\\PC\\Documents\\myFile.xls");
               MessageBox.Show("Xuất file thành công");
          }
     }
}