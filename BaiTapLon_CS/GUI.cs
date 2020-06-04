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
               pnComponent.Visible = false;
               label5.Text = "TIỆM THUỐC NHÓM 1";
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

        private void button1_Click(object sender, EventArgs e)
        {
               openFormInPanel(new SearchOrder());
               pnComponent.Visible = true;
               pnComponent.Top = button4.Top+24;
               pnComponent.Height = button4.Height;
               label5.Text = "TÌM KIẾM HÓA ĐƠN";
          }

          private void button2_Click(object sender, EventArgs e)
          {
               pnComponent.Visible = true;
               openFormInPanel(new Add_Customer());
               pnComponent.Top = button2.Top+24;
               pnComponent.Height = button2.Height;
               label5.Text = "THÊM KHÁCH HÀNG";

          }

        private void productList_Click(object sender, EventArgs e)
        {
               pnComponent.Visible = true;
               openFormInPanel(new MedicineList());
               pnComponent.Top = productList.Top+24;
               pnComponent.Height = productList.Height;
               label5.Text = "DANH SÁCH SẢN PHẨM";
          }

          private void btnExit_Click(object sender, EventArgs e)
          {
               this.Hide();
               Form1 form = new Form1();
               form.Show();
          }

          private void button10_Click(object sender, EventArgs e)
          {
               pnComponent.Visible = true;
               openFormInPanel(new Order());
               pnComponent.Top = button6.Top+24;
               pnComponent.Height = button6.Height;
               label5.Text = "CHI TIẾT ĐƠN HÀNG";

          }

          
        private void button5_Click(object sender, EventArgs e)
        {
               pnComponent.Visible = true;
               openFormInPanel(new Analytics());
               pnComponent.Top = button5.Top+24;
               pnComponent.Height = button5.Height;
               label5.Text = "PHÂN TÍCH BÁN HÀNG";
          }

          private void button7_Click(object sender, EventArgs e)
          {
               pnComponent.Visible = true;
               openFormInPanel(new History());
               pnComponent.Top = button7.Top+24;
               pnComponent.Height = button7.Height;
               label5.Text = "LỊCH SỬ BÁN HÀNG";
          }

          private void panel2_Paint_1(object sender, PaintEventArgs e)
          {
               lbName.Text = LoginDAO.Name_Manager;
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
             DialogResult result = MessageBox.Show("Bạn có chắc đăng xuất hay không ?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == DialogResult.Yes)
               {
                    
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
               }
          }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
