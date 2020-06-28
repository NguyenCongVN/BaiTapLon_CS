using BaiTapLon_CS.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
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
            //TextBoxTenNhanVien.Text = manager.Name_Manager;
            //TextBoxEmail.Text = manager.Email;
            //TextBoxDienThoai.Text = manager.Phone;
            //TextBoxMatKhau.Text = manager.Password;
            check = boolClass;
            this.manager = manager;

            // init the combobox choose sex
            ComboBoxItem item1 = new ComboBoxItem { Text = "Nam", Value = 1 };
            ComboBoxItem item2 = new ComboBoxItem { Text = "Nữ", Value = 0 };

            comboBox1.Items.Add(item1);
            comboBox1.Items.Add(item2);
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
                try
                {
                    manager.Salary = decimal.Parse(textBoxLuong.Text);
                }
                catch
                {
                    throw new Exception("Thông tin lương không chính xác!");
                }
                try
                {
                    DateTime time = new DateTime(int.Parse(textBoxNamVaoLam.Text),
                        int.Parse(textBoxThangVaoLam.Text), int.Parse(textBoxNgayVaoLam.Text));
                    manager.DayWork = time;
                }
                catch
                {
                    throw new Exception("Thông tin ngày tháng năm vào làm không chính xác!");
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


            if ((comboBox1.SelectedItem as ComboBoxItem).Value == 1)
            {
                manager.Sex = true;
            }
            else
            {
                manager.Sex = false;
            }


            check.isChanged = true;

            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "exec InsertManager @name,@sex,@phone,@day_work,@salary,@email,@password";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddRange(new SqlParameter[] { new SqlParameter("name" , manager.Name_Manager)
                , new SqlParameter("phone" , manager.Phone) , new SqlParameter("email" , manager.Email)
                , new SqlParameter("password" ,Form1.MaHoaMD5(manager.Password)) , new SqlParameter("sex" , manager.Sex) ,
                new SqlParameter("day_work" , manager.DayWork) , new SqlParameter("salary" , manager.Salary)});
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
