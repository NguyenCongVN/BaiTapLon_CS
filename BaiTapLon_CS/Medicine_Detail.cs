using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
          public Medicine_Detail(){
               InitializeComponent();
               txtID_Medicine.Text = MedicineList.ID_Medicine.ToString();
               txtName_Medicine.Text = MedicineList.Name_Medicine;
               if(MedicineList.Image_Medicine == "")
               {
                    Bitmap bitmap1 = new Bitmap(Properties.Resources._default);
                    pictureBox1.BackgroundImage = bitmap1;
               }
               else
               {
                    Bitmap bitmap1 = new Bitmap(@"C:\\Users\\PC\\Pictures\\Baitaplon\\" + MedicineList.Image_Medicine +".jpg");
                    pictureBox1.BackgroundImage = bitmap1;
               }
               
               string query = "SELECT dbo.Import.Import_Date,imde.Date_Of_Manufacture,imde.Expiry_Date,imde.Amount FROM dbo.Medicine AS me JOIN dbo.Import_Detail as imde ON imde.ID_Medicine = me.ID_Medicine JOIN dbo.Import ON Import.ID_Import = imde.ID_Import and me.ID_Medicine = " + txtID_Medicine.Text;
               DisplayListView(query);



              int total_import = this.dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));

               string query_amount_sell = "SELECT SUM(Amount) FROM Invoice_Detail WHERE ID_Medicine = " + txtID_Medicine.Text;
               if (total_import != 0)
               {
                    txtAmount.Text = (total_import - int.Parse(DAO.Medicine_DetailDAO.Instance.getTotalSell(query_amount_sell))).ToString();
               }
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
