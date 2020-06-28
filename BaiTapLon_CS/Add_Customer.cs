using BaiTapLon_CS.DAO;
using System;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName_Customer.Text == "")
            {
                MessageBox.Show("Chưa điền tên khách hàng");
                return;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Chưa điền tuổi");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Chưa điền địa chỉ");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Chưa điền số điện thoại");
                return;
            }
            if (cbTypeSex.SelectedIndex != 0 && cbTypeSex.SelectedIndex != 1)
            {
                MessageBox.Show("Chưa điền giới tính");
                return;
            }
            string query = "EXEC dbo.addCustomer @nameCustomer = N'"+ txtName_Customer.Text 
                    + "',@address = N'"+ txtAddress.Text + "',@sex = "+ cbTypeSex.SelectedIndex 
                    + ",@birthday ="+ txtAge.Text + ",@phone = N'"+ txtPhone.Text + "'";
            AddCustomerDAO.Instance.AddCustomer(query);
            MessageBox.Show("Thêm khách hàng " + txtName_Customer.Text + " thành công");
            txtAddress.Text = "";
            txtAge.Text = "";
            txtName_Customer.Text = "";
            txtPhone.Text = "";
            cbTypeSex.Text = "Chọn";
            txtName_Customer.Focus();
            
        }
    }
}
