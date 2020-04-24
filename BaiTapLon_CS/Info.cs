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
     public partial class Info : Form
     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
          Bitmap bitmap1;
          OpenFileDialog openFileDialog;
          public void updateInfo(string query)
          {
               try
               {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = query;
                    con.Close();
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cập nhật thành công");

               }
               catch (Exception e)
               {
                    MessageBox.Show("Lỗi cú pháp rồi:" + e);
                    return;
               }
          }
          public void getInfo(string query)
          {
               con.Open();
               using (SqlDataAdapter da = new SqlDataAdapter(query, connect))
               {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    btnName.Text = dt.Rows[0][1].ToString();
                    string image = dt.Rows[0][2].ToString();
                    var n = dt.Rows[0][3].ToString();
                     if (dt.Rows[0][3].ToString() == "True")
                    {
                         btnSex.SelectedIndex = 0;
                    }
                     else

                    {
                         btnSex.SelectedIndex = 1;
                    }
                    btnPhone.Text = dt.Rows[0][4].ToString();
                    btnDateWork.Text = dt.Rows[0][5].ToString();
                    if (image =="")
                    {
                       bitmap1 = new Bitmap(@"C:\\Users\\PC\\Pictures\\Baitaplon\\" + "user" + ".jpg");
                    }
                    else
                    {
                       bitmap1 = new Bitmap(image);
                    }
                    picBoxUser.BackgroundImage = bitmap1;
         
               }
               con.Close();

          }
          public Info()
          {
               InitializeComponent();
               string query = "SELECT * FROM Manager WHERE ID_Manager =" + Form1.ID_Manager;
               getInfo(query);

          }

        private void button1_Click(object sender, EventArgs e)
        {
               Boolean sex;
               if(btnSex.SelectedIndex == 1)
               {
                    sex = false;
               }
               else
               {
                    sex = true;
               }
               string query;
               if (openFileDialog != null)
               {
                    query= "UPDATE Manager SET Name_Manager =N'" + btnName.Text + "', Phone = N'" + btnPhone.Text + "' ,Sex ='" + sex + "',"+"Image='"+ openFileDialog.FileName+"'";
               }else

               {
                    query = "UPDATE Manager SET Name_Manager =N'" + btnName.Text + "', Phone = " + btnPhone.Text + " ,Sex ='" + sex+"'";
               }
               updateInfo(query);
               
        }

          private void btnChooseImage_Click(object sender, EventArgs e)
          {
               openFileDialog = new OpenFileDialog();
               openFileDialog.Filter = "Image Files | *.jpg";
               DialogResult result = openFileDialog.ShowDialog();
               // if a file is selected
               if (result == DialogResult.OK)
               {
                    bitmap1 = new Bitmap(openFileDialog.FileName);
                  
                    picBoxUser.BackgroundImage=bitmap1;
               }
          }
     }
}
