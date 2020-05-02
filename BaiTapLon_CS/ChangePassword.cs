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
          string Password = null;
          public ChangePassword()
          {
               InitializeComponent();
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
               Password = DAO.ChangePasswordDAO.Instance.confirm();
               if(txtConfirmPassword.Text == txtNewPassword.Text)
               {
                    string password = MaHoaMD5(txtCurrentPassword.Text);
                    string newPassword = MaHoaMD5(txtNewPassword.Text);
                     if (password == Password)
                    {
                         string query = "UPDATE Manager SET Password ='" + newPassword+"'";
                         txtNewPassword.Text = "";
                         txtCurrentPassword.Text = "";
                         txtConfirmPassword.Text = "";
                         txtCurrentPassword.Focus();
                        DAO.ChangePasswordDAO.Instance.updateInfo(query);
                    }
                    else
                    {
                         MessageBox.Show("Đổi mật khẩu không thành công");
                    }
               }
               else

               {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không chính xác");
               }
          }
     }
}
