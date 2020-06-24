using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class StatisticDAO
     {
          public static StatisticDAO instance;

          public static StatisticDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new StatisticDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public decimal get_saled_day(int day)
          {
               string query = "EXEC dbo.day_week @day=" + day;
               if (DAO.DataProvider.Instance.DisplayListView(query) == null)
               {
                    return 0;
               }
               else
               {
                    return decimal.Parse(DAO.DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString());
               }
          }
          public string getCountCustomer()
          {
               string query = "EXEC countCustomer";
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getCountInvoice()
          {
               string query = "EXEC dbo.countInvoice @id ="+ Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getMoney()
          {
               string query = "EXEC dbo.getMoney @id =" + Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getAmountMedicine()
          {
               string query = "EXEC dbo.getCountMedicine @id =" + Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getCustomerMonth()
          {
               string query = "EXEC getCustomerMonth";
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }

          public string getInvoiceMonth()
          {
               string query = "EXEC getInvoiceMonth @id="+Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }

          public string getMoneyMonth()
          {
               string query = "EXEC getMoneyMonth @id=" + Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getAmountMedicineMonth()
          {
               string query = "EXEC getAmountMedicineMonth @id=" + Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getCountProgessbar()
          {
               string query = "EXEC getCountProgessbar @id=" + Form1.ID_Manager;
               string value = DataProvider.Instance.DisplayListView(query).Rows.Count.ToString();
               return value;
          }

     }

}
