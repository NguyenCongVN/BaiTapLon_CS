using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class AnalyticsDAO
     {
          public static AnalyticsDAO instance;

          public static AnalyticsDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new AnalyticsDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
         public string getCountInvoice(string query)
          {
               return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
          }
          public string getCountToday()
          {
               string query = "SELECT  COUNT(*) FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                      "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                      ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
               return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
          }
          public string getCountMonth()
          {
               string query = "SELECT COUNT(*) FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
               return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
          }
     }
}
