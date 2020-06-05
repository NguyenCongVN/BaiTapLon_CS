using BaiTapLon_CS.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms
{
    public partial class ThemNhanVienForm : Form
    {
        public BoolClass check { get; set; }

        public Manager manager { get; set; }
        public ThemNhanVienForm(Manager manager, BoolClass boolClass)
        {
            InitializeComponent();
            TextBoxTenNhanVien.Text = manager.Name_Manager;
            TextBoxEmail.Text = manager.Email;
            TextBoxDienThoai.Text = manager.Phone;
            TextBoxMatKhau.Text = manager.Password;
            check = boolClass;
            this.manager = manager;
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBoxTenNhanVien.Text))
                {
                    throw new Exception("Lỗi Thông tin tên nhân viên");
                }
                if (!TextBoxEmail.Text.Contains("@") || !TextBoxEmail.Text.Contains("."))
                {
                    if (!string.IsNullOrEmpty(TextBoxEmail.Text))
                        throw new Exception("Lỗi Thông tin Email");
                }
                if (string.IsNullOrWhiteSpace(TextBoxMatKhau.Text))
                {
                    throw new Exception("Mật Khẩu không chính xác");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            manager.Name_Manager = TextBoxTenNhanVien.Text;
            manager.Phone = TextBoxDienThoai.Text;
            manager.Email = TextBoxEmail.Text;
            manager.Password = TextBoxMatKhau.Text;
            check.isChanged = true;

            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "insert into Manager values (@name , @phone , @email , @password , null )";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddRange(new SqlParameter[] { new SqlParameter("name" , manager.Name_Manager)
                , new SqlParameter("phone" , manager.Phone) , new SqlParameter("email" , manager.Email)
                , new SqlParameter("password" , manager.Password)});
                sqlCommand.ExecuteScalar();
            }
            this.Close();
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
