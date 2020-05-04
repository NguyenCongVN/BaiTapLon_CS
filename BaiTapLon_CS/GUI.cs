using BaiTapLon_CS.DAO;
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
    public partial class GUI : Form
    {
          

          public GUI()
        {
            InitializeComponent();
            openFormInPanel(new FormMenu());
        }
         private void openFormInPanel(object FormChild)
          {
               
               if (this.pnlContain.Controls.Count > 0)
               {
                    this.pnlContain.Controls.RemoveAt(0);
               }
               Form fc = FormChild as Form;
               fc.TopLevel = false;
               fc.Dock = DockStyle.Fill;
               this.pnlContain.Controls.Add(fc);
               this.pnlContain.Tag = fc;
               fc.Show();
          }
          private void BtnListProduct_Click(object sender, EventArgs e)
        {
               openFormInPanel(new MedicineList());
              
          }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               openFormInPanel(new SearchOrder());
          }

          private void button2_Click(object sender, EventArgs e)
          {
               openFormInPanel(new Add_Customer());
                
          }

        private void productList_Click(object sender, EventArgs e)
        {
               openFormInPanel(new MedicineList());
          }

          private void btnExit_Click(object sender, EventArgs e)
          {
               this.Hide();
               Form1 form = new Form1();
               form.Show();
          }

          private void button10_Click(object sender, EventArgs e)
          {
               openFormInPanel(new Order());
          }

          private void label2_Click(object sender, EventArgs e)
          {

          }

        private void button2_Click_1(object sender, EventArgs e)
        {
               
        }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {

          }

        private void button5_Click(object sender, EventArgs e)
        {
               openFormInPanel(new Analytics());
        }

          private void button7_Click(object sender, EventArgs e)
          {
               openFormInPanel(new History());
          }

          private void panel2_Paint_1(object sender, PaintEventArgs e)
          {
               lbName.Text = LoginDAO.Name_Manager;
          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {

          }

        private void xemThôngTinTrangCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
               Info info = new Info();
               info.ShowDialog();
       
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
               ChangePassword changePassword = new ChangePassword();
               changePassword.ShowDialog();
        }

          private void chúThíchToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Tutorial tutorial = new Tutorial();
               tutorial.Show();
          }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
               this.Hide();
               Form1 form = new Form1();
               form.Show();
          }
    }
}
