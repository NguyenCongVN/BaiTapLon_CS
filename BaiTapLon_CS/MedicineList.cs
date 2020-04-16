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
     public partial class MedicineList : Form
     {
          int pageSize = 5;
          int page;
          int pageMax;
          public static int ID_Medicine;
          public static string Name_Medicine;
          public static string Image_Medicine;
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);

          public string getCountMedicine()
          {
               string query = "SELECT COUNT(*) FROM Medicine";
               con.Open();
               string count;
               using (SqlDataAdapter da = new SqlDataAdapter(query, connect))
               {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    count = dt.Rows[0][0].ToString();
               }
               return count;

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

                         dgwMedicineList.DataSource = dt;
                         dgwMedicineList.Columns[0].HeaderText = "Mã thuốc";
                         dgwMedicineList.Columns[1].HeaderText = "Tên thuốc";
                         dgwMedicineList.Columns[2].Visible = false;

                         dgwMedicineList.Columns[3].HeaderText = "Xuất xứ";

                         dgwMedicineList.Columns[4].HeaderText = "Đóng gói";
                         dgwMedicineList.Columns[5].HeaderText = "Đơn vị";
                         dgwMedicineList.Columns[6].HeaderText = "Giá bán";
                         dgwMedicineList.Columns[7].HeaderText = "Số đăng ký";

                         dgwMedicineList.Columns[6].DefaultCellStyle.Format = "n0";
                         dgwMedicineList.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");


                    }
                    else
                    {
                         MessageBox.Show("Dữ liệu bạn tìm không có, vui lòng thử lại");
                    }
                    con.Close();
               }
               catch (Exception e)
               {
                    MessageBox.Show("Lỗi cú pháp rồi " + e);
                    return;
               }
             

          }
          public MedicineList()
          {
               page = 1;
               InitializeComponent();
               string query ="SELECT TOP("+pageSize * page + ") * FROM dbo.Medicine EXCEPT SELECT TOP(" + pageSize * (page-1) + ") * FROM dbo.Medicine";
               DisplayListView(query);
               btnPre.Enabled = false;
               btnCurrent.Text =page.ToString();
               pageMax = int.Parse(getCountMedicine());
               if (pageMax % pageSize == 0)
               {
                    pageMax = pageMax / pageSize;
               }
               else
               {
                    pageMax = (pageMax / pageSize) + 1;
               }
               btnTotalPage.Text ="of "+pageMax.ToString();
               con.Close();
          }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void cBType_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

          private void txtSearch_TextChanged(object sender, EventArgs e)
          {
               
          }

          private void btnSearch_Click(object sender, EventArgs e)
          {
               dgwMedicineList.DataSource = null;
               var Subquery = "";
               var isIndex = true;
               if (txtID_Medicine.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "me.ID_Medicine = " + txtID_Medicine.Text;
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and me.ID_Medicine = " + txtID_Medicine.Text;
                    }
               }
               if (txtName_Medicine.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "LOWER(me.Name_Medicine) LIKE N'%" + txtName_Medicine.Text.ToLower() + "%'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and LOWER(me.Name_Medicine) LIKE N'%" + txtName_Medicine.Text.ToLower() + "%'";
                    }

               }
               if (cBoxCategoty.SelectedIndex != 0 && cBoxCategoty.SelectedIndex != -1) {
                    if(isIndex == true)
                    {
                         Subquery += "ca.Name_Category = N'" + cBoxCategoty.Text+"'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and ca.Name_Category =N'" + cBoxCategoty.Text+"'";;
                    }
               }
               if(cBoxManufacturer.SelectedIndex != 0 && cBoxManufacturer.SelectedIndex != -1)
               {
                    if (isIndex == true)
                    {
                         Subquery += "manu.Name_Manufacturer = N'" + cBoxManufacturer.Text + "'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and manu.Name_Manufacturer = N'" + cBoxManufacturer.Text + "'";
                    }
               }
               if (Subquery == "")
               {
                    string queryy = "SELECT TOP("+pageSize+")* FROM Medicine";
                    DisplayListView(queryy);
               }
               else
               {
                    string query = "SELECT me.ID_Medicine,me.Name_Medicine,me.Image_Medicine,me.Source,me.Packing,me.Unit,me.Cost,me.Registration_Number FROM Medicine as me,Category_Detail as cade,Category as Ca,Manufacturer as manu,Manufacturer_Detail as made where " + Subquery + " and me.ID_Medicine = cade.ID_Medicine and ca.ID_Category = cade.ID_Category and made.ID_Category = ca.ID_Category and manu.ID_Manufacturer = made.ID_Manufacturer";
                    DisplayListView(query);
               }
          }

          private void btnReset_Click(object sender, EventArgs e)
          {
               // listViewMedicine.Items.Clear();
               string query = "SELECT TOP(+"+pageSize+") * FROM dbo.Medicine";
               DisplayListView(query);
               btnPre.Enabled = false;
               //btnNext.Enabled = true;
          }

          private void listViewMedicine_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void listViewMedicine_MouseClick(object sender, MouseEventArgs e)
          {

              
          }

          private void dgwMedicineList_MouseClick(object sender, MouseEventArgs e)
          {
               int row = dgwMedicineList.CurrentCell.RowIndex;
               ID_Medicine = int.Parse(dgwMedicineList.Rows[row].Cells[0].Value.ToString());
               Name_Medicine = dgwMedicineList.Rows[row].Cells[1].Value.ToString();
               Image_Medicine= dgwMedicineList.Rows[row].Cells[2].Value.ToString();

               // Image_Medicine=dgwMedicineList.Rows[row].Cells[2].Value.ToString();
               Medicine_Detail mede = new Medicine_Detail();
               mede.Show();
          }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

          private void cBoxCategoty_MouseClick(object sender, MouseEventArgs e)
          {

          }

          private void dgwMedicineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void btnNext_Click(object sender, EventArgs e)
          {
               if (page < pageMax-1)
               {
                    page += 1;
                    string query = "SELECT TOP(" + pageSize * page + ") * FROM dbo.Medicine EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") * FROM dbo.Medicine";
                    DisplayListView(query);
                    btnPre.Enabled = true;
                    btnNext.Enabled = true;
                    btnCurrent.Text = page.ToString();
               }
               else
               {
                    page += 1;
                    btnNext.Enabled = false;
                    btnPre.Enabled = true;
                    string query = "SELECT TOP(" + pageSize * page + ") * FROM dbo.Medicine EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") * FROM dbo.Medicine";
                    DisplayListView(query);
                    btnCurrent.Text = page.ToString();
               }

          }

          private void btnPre_Click(object sender, EventArgs e)
          {
               if (page > 2)
               {
                    page -= 1;
                    btnNext.Enabled = true;
                    string query = "SELECT TOP(" + pageSize * page + ") * FROM dbo.Medicine EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") * FROM dbo.Medicine";
                    DisplayListView(query);
                    btnPre.Enabled = true;
                    btnCurrent.Text = page.ToString();
               }
               else if(page == 2)
               {
                    page -= 1;
                    btnPre.Enabled = false;
                    btnNext.Enabled = true;
                    string query = "SELECT TOP(" + pageSize + ") * FROM dbo.Medicine ";
                    DisplayListView(query);
                    btnCurrent.Text = page.ToString();
               }
          }

          private void txtID_Medicine_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
               {
                    e.Handled = true;
               }

               // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
               if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
               {
                    e.Handled = true;
               }
          }
     }
}
