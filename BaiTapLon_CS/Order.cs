using BaiTapLon_CS.DAO;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            txtID_Manager.Text = LoginDAO.ID_Manager;
            txtName_Manager.Text = LoginDAO.Name_Manager;
        }
        public void fillCustomer(string a, string b, string c, string d)
        {
            txtID_Customer.Text = a;
            txtName_Customer_Order.Text = b;
            txtAddress_Order.Text = c;
            txtPhoneOrder.Text = d;
            txtID_Medicine.Focus();

        }
        public void fillMedicine(string a, string b)
        {
            txtID_Medicine.Text = a;
            txtNameMedicine.Text = b;
            txtAmount.Focus();
        }
        private void textBox7_MouseDown(object sender, MouseEventArgs e)
        {
            Search_Medicine search_Medicine = new Search_Medicine(fillMedicine);
            search_Medicine.Show();
        }
        private void txtID_Customer_MouseDown(object sender, MouseEventArgs e)
        {
            SearchCustomer searchCustomer = new SearchCustomer(fillCustomer);
            searchCustomer.Show();
        }
        private void xóaGiỏHàng_Click(object sender, EventArgs e)
        {
            int row = dgvInvoice.CurrentCell.RowIndex;
            this.dgvInvoice.Rows.RemoveAt(row);
            int total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
            Total.Text = total.ToString();
        }

        private void sửaGiỏHàng_Click(object sender, EventArgs e)
        {
            int row = dgvInvoice.CurrentCell.RowIndex;
            int total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));

            Total.Text = total.ToString();

        }
        private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvInvoice.CurrentCell.RowIndex;
            int x, y;

            try
            {
                int ID_Medicine = int.Parse(this.dgvInvoice.Rows[row].Cells[0].Value.ToString());

                x = int.Parse(this.dgvInvoice.Rows[row].Cells[2].Value.ToString());
                y = int.Parse(this.dgvInvoice.Rows[row].Cells[3].Value.ToString());


                this.dgvInvoice.Rows[row].Cells[4].Value = x * y;
                int total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
                Total.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Mời bạn nhập đúng định dạng là số");
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
          private void cancelInvoice_Click(object sender, EventArgs e)
          {
               dgvInvoice.Rows.Clear();
          }

          private void btnExit_Click(object sender, EventArgs e)
          {

          }

          private void btnSaveData_Click_1(object sender, EventArgs e)
          {
               if (dgvInvoice.Rows.Count == 1)
               {
                    MessageBox.Show("Bạn cần nhập thuốc vào bảng trước khi lưu");
               }
               else
               {
                    if (txtID_Customer.Text != "")
                    {
                         string id_invoice = "SELECT MAX(ID_Invoice) FROM Invoice";
                         string query ="EXEC dbo.addInvoice @ID_Customer ="+int.Parse(txtID_Customer.Text)+",@Diagnostic= N'" + txtDiagnostic.Text + ",+N',@Time_Of_Purchase ='DateTime.Now.ToString(yyyy-MM-dd HH:mm:ss)',@ID_Manager ="+int.Parse(txtID_Manager.Text)+",@Remind=N'"+txtRemind.Text+"'";
                         OrderDAO.Instance.AddOrder(query);
                         string ID_Invoice = OrderDAO.Instance.getCountID_Invoice(id_invoice);
                         for (int i = 0; i < dgvInvoice.Rows.Count; i++)
                         {
                              string que = "INSERT Invoice_Detail( ID_Invoice ,ID_Medicine ,Cost ,Amount)VALUES(" + int.Parse(ID_Invoice) + "," + int.Parse(this.dgvInvoice.Rows[i].Cells[0].Value.ToString()) + "," + decimal.Parse(dgvInvoice.Rows[i].Cells[3].Value.ToString()) + "," + int.Parse(dgvInvoice.Rows[i].Cells[2].Value.ToString()) + ")";
                              OrderDAO.Instance.AddOrder(que); // lưu vào cơ sở dữ liệu
                         }
                         dgvInvoice.Rows.Clear();
                         txtAddress_Order.Text = "";
                         txtDiagnostic.Text = "";
                         txtName_Customer_Order.Text = "";
                         txtRemind.Text = "";
                         txtPhoneOrder.Text = "";
                         txtAddress_Order.Text = "";
                         txtID_Customer.Text = "";
                         txtID_Customer.Focus();
                         MessageBox.Show("Thêm hóa đơn thành công, bạn có muốn in hóa đơn không");
                    }
                    else
                    {
                         MessageBox.Show("Bạn cần nhập thông tin khách hàng trước");
                    }
               }
          }

          private void btnAddToInvoice_Click(object sender, EventArgs e)
          {
               if (txtID_Medicine.Text != "" && txtNameMedicine.Text != "" && txtAmount.Text != "" && txtPrice.Text != "")
               {
                    var index = this.dgvInvoice.Rows.Count;
                    this.dgvInvoice.Rows.Add();
                    this.dgvInvoice.Rows[index].Cells[0].Value = txtID_Medicine.Text;
                    this.dgvInvoice.Rows[index].Cells[1].Value = txtNameMedicine.Text;
                    this.dgvInvoice.Rows[index].Cells[2].Value = txtAmount.Text;
                    this.dgvInvoice.Rows[index].Cells[3].Value = txtPrice.Text;
                    this.dgvInvoice.Rows[index].Cells[4].Value = int.Parse(txtAmount.Text) * decimal.Parse(txtPrice.Text);
                    decimal total = this.dgvInvoice.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));

                    CultureInfo culture = new CultureInfo("en-US");

                    Total.Text = String.Format(culture, "{0:N0}", decimal.Parse(total.ToString(), NumberStyles.AllowThousands));
                    txtID_Medicine.Text = "";
                    txtPrice.Text = "";
                    txtAmount.Text = "";
                    txtNameMedicine.Text = "";
                    txtID_Medicine.Focus();
               }
               else
               {
                    MessageBox.Show("Mời bạn nhập dữ liệu của hóa đơn");
               }
          }
     }
}
