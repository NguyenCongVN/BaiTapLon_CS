using BaiTapLon_CS.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public Manager manager { get; set; }
        public ChangePasswordForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (Form1.MaHoaMD5(textBoxMatKhauCu.Text).CompareTo(manager.Password) == 0)
            {
                if (textBoxMatKhauMoi.Text.CompareTo(textBoxXacNhan.Text) == 0)
                {
                    string query = "exec ChangePassword @id,@password";
                    using (SqlConnection connection = new SqlConnection(Form1.connect))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connection);
                        sqlCommand.Parameters.AddWithValue("id", manager.ID_Manager);
                        sqlCommand.Parameters.AddWithValue("password", Form1.MaHoaMD5(textBoxMatKhauMoi.Text));
                        sqlCommand.ExecuteScalar();
                    }
                    MessageBox.Show("Đổi mật khẩu thành công");
                    manager.Password = Form1.MaHoaMD5(textBoxMatKhauMoi.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Xác Nhận Sai");
                }
            }
            else
            {
                MessageBox.Show("Mật Khẩu Nhập Vào Sai");
            }
        }
    }
}
