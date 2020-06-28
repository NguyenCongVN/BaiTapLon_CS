using BaiTapLon_CS.Class;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MedicineShopManagement.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            LoadChart();
        }

        private Random rand = new Random();

        private void LoadChart()
        {
            List<MoneyInMonth> revenues = new List<MoneyInMonth>();
            revenues = ThongKeHelper.GetRevenueInMonths(2020);
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);
            foreach (var revenue in revenues)
            {
                switch (revenue.Month)
                {
                    case 1:
                        dataPoint.addLabely("Tháng 1", revenue.Money.ToString());
                        break;
                    case 2:
                        dataPoint.addLabely("Tháng 2", revenue.Money.ToString());
                        break;
                    case 3:
                        dataPoint.addLabely("Tháng 3", revenue.Money.ToString());
                        break;
                    case 4:
                        dataPoint.addLabely("Tháng 4", revenue.Money.ToString());
                        break;
                    case 5:
                        dataPoint.addLabely("Tháng 5", revenue.Money.ToString());
                        break;
                    case 6:
                        dataPoint.addLabely("Tháng 6", revenue.Money.ToString());
                        break;
                    case 7:
                        dataPoint.addLabely("Tháng 7", revenue.Money.ToString());
                        break;
                    case 8:
                        dataPoint.addLabely("Tháng 8", revenue.Money.ToString());
                        break;
                    case 9:
                        dataPoint.addLabely("Tháng 9", revenue.Money.ToString());
                        break;
                    case 10:
                        dataPoint.addLabely("Tháng 10", revenue.Money.ToString());
                        break;
                    case 11:
                        dataPoint.addLabely("Tháng 11", revenue.Money.ToString());
                        break;
                    case 12:
                        dataPoint.addLabely("Tháng 12", revenue.Money.ToString());
                        break;
                }


            }

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);


            List<MoneyInMonth> salaries = new List<MoneyInMonth>();
            salaries = ThongKeHelper.GetSalaryInMonths(2020);
            decimal thisMonth = 0;
            decimal total = 0;
            foreach (var salary in salaries)
            {
                if (salary.Month == DateTime.Now.Month)
                {
                    thisMonth = salary.Money;
                    total += salary.Money;
                }
                else
                {
                    total += salary.Money;
                }
            }
            decimal x = (thisMonth / total);
            x *= 100;
            salaryCircleProgressbar3.Value = (int)x;


            List<MoneyInMonth> importedCosts = new List<MoneyInMonth>();
            importedCosts = ThongKeHelper.GetImportCostInMonth(2020);
            decimal thisMonth1 = 0;
            decimal total1 = 0;
            decimal x1 = 0;
            foreach (var imported in importedCosts)
            {
                if (imported.Month == DateTime.Now.Month)
                {
                    thisMonth1 = imported.Money;
                    total1 += imported.Money;
                }
                else
                {
                    total1 += imported.Money;
                }
            }
            if (total1 != 0)
            {
                x1 = (thisMonth1 / total1);
                x1 *= 100;
            }
            importedCircleProgressbar2.Value = (int)x1;

            List<MoneyInMonth> soldValues = new List<MoneyInMonth>();
            soldValues = ThongKeHelper.GetMoneyInMonth(2020);
            decimal thisMonth2 = 0;
            decimal total2 = 0;
            foreach (var value in soldValues)
            {
                if (value.Month == DateTime.Now.Month)
                {
                    thisMonth2 = value.Money;
                    total2 += value.Money;
                }
                else
                {
                    total2 += value.Money;
                }
            }
            decimal x2 = (thisMonth2 / total2);
            x2 *= 100;
            soldCircleProgressbar1.Value = (int)x2;

            importCost.Text = ExtensionHelper.ChangeToCurrency(total1.ToString()) + " VNĐ";
            soldValue.Text = ExtensionHelper.ChangeToCurrency(total2.ToString()) + " VNĐ";
            amountCustomer.Text = ThongKeHelper.NumberOfCustomerInYear(2020).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
