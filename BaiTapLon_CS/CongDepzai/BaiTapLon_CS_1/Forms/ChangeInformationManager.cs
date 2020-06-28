using BaiTapLon_CS.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms;
using System;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms
{
    public partial class ChangeInformationManager : Form
    {

        public BoolClass check { get; set; }

        public Manager manager { get; set; }
        public ChangeInformationManager(Manager manager, BoolClass boolClass)
        {
            InitializeComponent();
            TextBoxMaNhanVien.Text = manager.ID_Manager.ToString();
            TextBoxTenNhanVien.Text = manager.Name_Manager;
            TextBoxEmail.Text = manager.Email;
            TextBoxDienThoai.Text = manager.Phone;
            //TextBoxMatKhau.Text = manager.Password;
            textBoxNgayVaoLam.Text = manager.DayWork.Day.ToString();
            textBoxThangVaoLam.Text = manager.DayWork.Month.ToString();
            textBoxNamVaoLam.Text = manager.DayWork.Year.ToString();
            textBoxLuong.Text = manager.Salary.ToString();
            comboBoxGioiTinh.SelectedItem = manager.Sex ? comboBoxGioiTinh.Items[0] : comboBoxGioiTinh.Items[1];
            check = boolClass;
            this.manager = manager;
        }

        private void ButtonApDung_Click(object sender, EventArgs e)
        {
            decimal salary = 0;
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
                //if (string.IsNullOrWhiteSpace(TextBoxMatKhau.Text))
                //{
                //    throw new Exception("Mật Khẩu không chính xác");
                //}
                // Gioi Tinh



                // Ngay Vao Lam
                try
                {
                    manager.DayWork = new DateTime(int.Parse(textBoxNamVaoLam.Text), int.Parse(textBoxThangVaoLam.Text), int.Parse(textBoxNgayVaoLam.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhap sai ngày tháng vào làm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Luong
                if (string.IsNullOrWhiteSpace(textBoxLuong.Text) || !decimal.TryParse(textBoxLuong.Text, out salary))
                {
                    throw new Exception("Lương Không Đúng");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            manager.Salary = salary;
            manager.Name_Manager = TextBoxTenNhanVien.Text;
            manager.Phone = TextBoxDienThoai.Text;
            manager.Email = TextBoxEmail.Text;
            //manager.Password = TextBoxMatKhau.Text;
            manager.Salary = salary;
            manager.Sex = comboBoxGioiTinh.SelectedIndex == 0 ? true : false;
            check.isChanged = true;
            this.Close();
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm(manager);
            changePassword.ShowDialog();
        }
    }
}
