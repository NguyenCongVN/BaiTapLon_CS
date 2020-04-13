using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BaiTapLon_CS
{
    public partial class Form1 : Form
    {
          public static string ID_Manager;
          public static string Name_Manager;

          public static string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";

          List<string> name_Permission = new List<string>();

          SqlConnection con = new SqlConnection(connect);
          private string getID(string email, string pass) // Hàm kiểm tra ID
          {
               string id = "";
               try
               {
                    con.Open();
                    string query = "SELECT * FROM Manager WHERE Email='" + email + "' and Password='" + pass + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, connect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                         foreach (DataRow dr in dt.Rows)
                         {
                              id = dr["ID_Manager"].ToString();
                              Name_Manager = dr["Name_Manager"].ToString();
                              ID_Manager = id;

                         }
                    }
               }
               catch (Exception)
               {
                    MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
               }
               finally
               {
                    con.Close();
               }
               return id;
          }

          private string getID_Permission(string ID) // lấy mã quyền của ID
          {
               string id_Permission = "";
               try
               {
                    con.Open();
                    string query = "SELECT * FROM Detail_Permission WHERE ID_Manager='" + ID +"'";
                    SqlDataAdapter da = new SqlDataAdapter(query, connect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                         foreach (DataRow dr in dt.Rows)
                         {
                              id_Permission = dr["ID_Permission"].ToString();
                         }
                    }
               }
               catch (Exception)
               {
                    MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
               }
               finally
               {
                    con.Close();
               }
               return id_Permission;
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

          private List<string> getName_Permission(string ID_Permission) // lấy tên quyền của ID
          {
               List<string> key_Permisson = new List<string>();
               try
               {
                    con.Open();
                    string query = "SELECT * FROM Permission WHERE ID_Permission='" + ID_Permission + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, connect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                         foreach (DataRow dr in dt.Rows)
                         {
                              key_Permisson.Add(dr["Key_Permission"].ToString());
                         }
                    }
               }
               catch (Exception)
               {
                    MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
               }
               finally
               {
                    con.Close();
               }
               return key_Permisson;
          }

          public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

          private void BtnLogin_Click(object sender, EventArgs e)
          {

               ID_Manager = getID(txtAccount.Text,MaHoaMD5(txtPassword.Text));
               
               if (ID_Manager != "")    // Đăng nhập thành công
               {
                    if (radioBtnAdmin.Checked == true) // kiểm tra xem có phải đăng nhập với tư cách admin
                    {
                         name_Permission = getName_Permission(getID_Permission(ID_Manager));
                         foreach (var name in name_Permission)
                         {
                              if (name == "admin")
                              {
                                   GUI_Admin gui_admin = new GUI_Admin();
                                   this.Hide();
                                   gui_admin.Show();
                              }
                              else if (name == "employee")
                              {
                                   MessageBox.Show("Bạn không đủ quyền truy cập");
                              }
                         }

                    }
                    else  // Ngược lại, kiểm tra đăng nhập với tư cách nhân viên
                    {
                         name_Permission = getName_Permission(getID_Permission(ID_Manager)); 
                         foreach (var name in name_Permission)
                         {
                              if (name == "admin" || name =="employee" )
                              {
                                   GUI gui = new GUI();
                                   this.Hide();
                                   gui.Show();
                              }
                              else
                              {
                                   MessageBox.Show("Bạn không đủ quyền truy cập");
                              }
                         }
                    }
               }
               else   // Đăng nhập thất bại
               {
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                    txtAccount.Focus();
                    MessageBox.Show("Tên đăng nhập không chính xác");
               }

          }

          private void btnExit_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }
     }
}
