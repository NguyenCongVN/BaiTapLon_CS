using BaiTapLon_CS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
     public partial class DashBoard : Form
     {
          private DateTime dt;
          public DashBoard()
          {
               InitializeComponent();
               dt = DateTime.Now;
               Load_Chart();
               Load_Count_Medicine();
               Load_Amount_Customer();
               Load_Out_Of_Medicine();
              
          }
          void Load_Chart()
          {
               chart1.Series["week"].Points.AddXY("" + dt.DayOfWeek, DashBoardDAO.Instance.get_saled_day(7));
               chart1.Series["week"].Points.AddXY("" + dt.AddDays(1).DayOfWeek, DashBoardDAO.Instance.get_saled_day(6));
               chart1.Series["week"].Points.AddXY("" + dt.AddDays(2).DayOfWeek, DashBoardDAO.Instance.get_saled_day(5));
               chart1.Series["week"].Points.AddXY("" + dt.AddDays(3).DayOfWeek, DashBoardDAO.Instance.get_saled_day(4));
               chart1.Series["week"].Points.AddXY("" + dt.AddDays(4).DayOfWeek, DashBoardDAO.Instance.get_saled_day(3));
               chart1.Series["week"].Points.AddXY("" + dt.AddDays(5).DayOfWeek, DashBoardDAO.Instance.get_saled_day(2));
               chart1.Series["week"].Points.AddXY("" + dt.AddDays(6).DayOfWeek, DashBoardDAO.Instance.get_saled_day(1));
               
          }
          void Load_Count_Medicine()
          {
               product.Text = MedicineListDAO.Instance.getCountMedicine();
               totalMedicine.Text="/ "+MedicineListDAO.Instance.getCountMedicine();
               saled.Text = DashBoardDAO.Instance.get_count_saled();
               circleMonth.Value= Int32.Parse(saled.Text)*100 / Int32.Parse(MedicineListDAO.Instance.getCountMedicine());

          }
          void Load_Out_Of_Medicine()
          {
               outOfProduct.Text = DashBoardDAO.Instance.getCount_Out_Of_Medicine();
          }
          void Load_Amount_Customer()
          {
               customer.Text = DashBoardDAO.Instance.getCountCustomer();
          }
          private void product_Click(object sender, EventArgs e)
          {

          }

          private void pictureBox4_Click(object sender, EventArgs e)
          {

          }

          private void label1_Click(object sender, EventArgs e)
          {

          }
     }
}
