using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
     public partial class ChangePassword : Form
     {
          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
          public ChangePassword()
          {
               InitializeComponent();
          }
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
          public string MaHoaMD5(string password)
          {
               MD5 mh = MD5.Create();
               //Chuyển kiểu chuổi thành kiểu byte
               byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
               //mã hóa chuỗi đã chuyển
               byte[] hash = mh.ComputeHash(inputBytes);
               //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
               StringBuilder sb = new StringBuilder();

               for (int i = 0; i < hash.Length; i++)
               {
                    sb.Append(hash[i].ToString("x2"));
               }
               return sb.ToString();
          }
          private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

          private void button1_Click(object sender, EventArgs e)
          {
               if(txtConfirmPassword.Text == txtNewPassword.Text)
               {
                     
               }
               else

               {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không chính xác");
               }
          }
     }
}
