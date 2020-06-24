using BaiTapLon_CS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BaiTapLon_CS
{
     public partial class Statistic : Form
     {
          private DateTime dt;
          CultureInfo culture;
          public Statistic()
          {
               culture = new CultureInfo("en-US");
               InitializeComponent();
               Load_DataGridView_TopSale();
               Load_Chart();
               Load_Count();
               Load_Percent();
               Load_ProgessBar();
          }
        private void Statistic_Load(object sender, EventArgs e)
        {

        }
          private void Load_DataGridView_TopSale()
          {
               string query = "EXEC listTopSell @id ="+ Form1.ID_Manager;
               dgvTopSell.DataSource = DataProvider.Instance.DisplayListView(query);
               if (dgvTopSell.DataSource != null)
               {
                    dgvTopSell.Columns[0].HeaderText = "Mã thuốc";
                    dgvTopSell.Columns[1].HeaderText = "Tên thuốc";
                    dgvTopSell.Columns[2].HeaderText = "Số lượng";
               }
          }
          private void Load_Chart()
          {
               dt = DateTime.Now;
               chart1.Series.Add("week2");
               chart1.Series.Add("week3");
               chart1.Series.Add("week4");

               chart1.Series["week2"].ChartType = SeriesChartType.Spline;
               chart1.Series["week3"].ChartType = SeriesChartType.Spline;
               chart1.Series["week4"].ChartType = SeriesChartType.Spline;


               // Trước 1 tuần
               chart1.Series["week1"].Points.AddXY(""+dt.DayOfWeek,StatisticDAO.Instance.get_saled_day(7));
               chart1.Series["week1"].Points.AddXY(""+dt.AddDays(1).DayOfWeek, StatisticDAO.Instance.get_saled_day(6));
               chart1.Series["week1"].Points.AddXY("" + dt.AddDays(2).DayOfWeek, StatisticDAO.Instance.get_saled_day(5));
               chart1.Series["week1"].Points.AddXY("" + dt.AddDays(3).DayOfWeek, StatisticDAO.Instance.get_saled_day(4));
               chart1.Series["week1"].Points.AddXY("" + dt.AddDays(4).DayOfWeek, StatisticDAO.Instance.get_saled_day(3));
               chart1.Series["week1"].Points.AddXY("" + dt.AddDays(5).DayOfWeek, StatisticDAO.Instance.get_saled_day(2));
               chart1.Series["week1"].Points.AddXY("" + dt.AddDays(6).DayOfWeek, StatisticDAO.Instance.get_saled_day(1));


               // Trước 2 tuần
               chart1.Series["week2"].Points.AddXY("" + dt.DayOfWeek, StatisticDAO.Instance.get_saled_day(14));
               chart1.Series["week2"].Points.AddXY("" + dt.AddDays(1).DayOfWeek, StatisticDAO.Instance.get_saled_day(13));
               chart1.Series["week2"].Points.AddXY("" + dt.AddDays(2).DayOfWeek, StatisticDAO.Instance.get_saled_day(12));
               chart1.Series["week2"].Points.AddXY("" + dt.AddDays(3).DayOfWeek, StatisticDAO.Instance.get_saled_day(11));
               chart1.Series["week2"].Points.AddXY("" + dt.AddDays(4).DayOfWeek, StatisticDAO.Instance.get_saled_day(10));
               chart1.Series["week2"].Points.AddXY("" + dt.AddDays(5).DayOfWeek, StatisticDAO.Instance.get_saled_day(9));
               chart1.Series["week2"].Points.AddXY("" + dt.AddDays(6).DayOfWeek, StatisticDAO.Instance.get_saled_day(8));

               // Trước 3 tuần
               chart1.Series["week3"].Points.AddXY("" + dt.DayOfWeek, StatisticDAO.Instance.get_saled_day(21));
               chart1.Series["week3"].Points.AddXY("" + dt.AddDays(1).DayOfWeek, StatisticDAO.Instance.get_saled_day(20));
               chart1.Series["week3"].Points.AddXY("" + dt.AddDays(2).DayOfWeek, StatisticDAO.Instance.get_saled_day(19));
               chart1.Series["week3"].Points.AddXY("" + dt.AddDays(3).DayOfWeek, StatisticDAO.Instance.get_saled_day(18));
               chart1.Series["week3"].Points.AddXY("" + dt.AddDays(4).DayOfWeek, StatisticDAO.Instance.get_saled_day(17));
               chart1.Series["week3"].Points.AddXY("" + dt.AddDays(5).DayOfWeek, StatisticDAO.Instance.get_saled_day(16));
               chart1.Series["week3"].Points.AddXY("" + dt.AddDays(6).DayOfWeek, StatisticDAO.Instance.get_saled_day(15));


               // Trước 4 tuần
               chart1.Series["week4"].Points.AddXY("" + dt.DayOfWeek, StatisticDAO.Instance.get_saled_day(28));
               chart1.Series["week4"].Points.AddXY("" + dt.AddDays(1).DayOfWeek, StatisticDAO.Instance.get_saled_day(27));
               chart1.Series["week4"].Points.AddXY("" + dt.AddDays(2).DayOfWeek, StatisticDAO.Instance.get_saled_day(26));
               chart1.Series["week4"].Points.AddXY("" + dt.AddDays(3).DayOfWeek, StatisticDAO.Instance.get_saled_day(25));
               chart1.Series["week4"].Points.AddXY("" + dt.AddDays(4).DayOfWeek, StatisticDAO.Instance.get_saled_day(24));
               chart1.Series["week4"].Points.AddXY("" + dt.AddDays(5).DayOfWeek, StatisticDAO.Instance.get_saled_day(24));
               chart1.Series["week4"].Points.AddXY("" + dt.AddDays(6).DayOfWeek, StatisticDAO.Instance.get_saled_day(22));

          }
          private void Load_Count()
          {
               

               dataCustomer.Text = StatisticDAO.Instance.getCountCustomer();
               dataSale.Text= StatisticDAO.Instance.getCountInvoice();
               dataMoney.Text = String.Format(culture, "{0:N0}", decimal.Parse(DAO.StatisticDAO.Instance.getMoney(), NumberStyles.AllowThousands));
               dataMedicine.Text = String.Format(culture, "{0:N0}", decimal.Parse(DAO.StatisticDAO.Instance.getAmountMedicine(), NumberStyles.AllowThousands));
          }
          private void Load_Percent() {
               percentCustomer.Text = StatisticDAO.Instance.getCustomerMonth();
               percentMedicine.Text = StatisticDAO.Instance.getAmountMedicineMonth();
               percentMoney.Text = String.Format(culture, "{0:N0}", decimal.Parse(StatisticDAO.Instance.getMoneyMonth(), NumberStyles.AllowThousands));
               percentSale.Text = StatisticDAO.Instance.getInvoiceMonth();

               }
          private void Load_ProgessBar()
          {
              
               customers.Text = StatisticDAO.Instance.getCountProgessbar();
               totalCustomer.Text="/ "+ StatisticDAO.Instance.getCountCustomer();
               bunifuCircleProgressbar1.Value = int.Parse(customers.Text)*100 / int.Parse(StatisticDAO.Instance.getCountCustomer());
          }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
     }
}
