using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class Medicine_Detail : Form
    {
        public void DisplayListView(string query)
        {

            dataGridView1.DataSource = DAO.Medicine_DetailDAO.Instance.DisplatListView(query);
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[0].HeaderText = "Ngày nhập";
                dataGridView1.Columns[1].HeaderText = "Ngày sản xuất";
                dataGridView1.Columns[2].HeaderText = "Hạn sử dụng";
                dataGridView1.Columns[3].HeaderText = "Số lượng";
            }
        }

        public Medicine_Detail()
        {
            Hide();
            InitializeComponent();
            txtID_Medicine.Text = MedicineList.ID_Medicine.ToString();
            txtName_Medicine.Text = MedicineList.Name_Medicine;
            if (MedicineList.Image_Medicine == "")
            {
                Bitmap bitmap1 = new Bitmap(Properties.Resources._default);
                pictureBox1.BackgroundImage = bitmap1;
            }
            else
            {
                Bitmap bitmap1 = new Bitmap(@"C:\\Users\\PC\\Pictures\\Baitaplon\\" + MedicineList.Image_Medicine + ".jpg");
                pictureBox1.BackgroundImage = bitmap1;
            }

            string query = "getImportDetail @id="+txtID_Medicine.Text;
            DisplayListView(query);

               string q = "SELECT dbo.fuAmountImport("+ txtID_Medicine.Text + ") - dbo.fuSell("+ txtID_Medicine.Text + ")";
               txtAmount.Text = DAO.DataProvider.Instance.DisplayListView(q).Rows[0][0].ToString(); 
          }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_Medicine_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Medicine_Detail_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
