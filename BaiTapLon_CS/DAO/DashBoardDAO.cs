using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class DashBoardDAO
     {
          public static DashBoardDAO instance;

          public static DashBoardDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new DashBoardDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public string getCountCustomer()
          {
               string query = "EXEC countCustomer";
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string getCount_Out_Of_Medicine()
          {
               string query = "EXEC Out_of_Medicine";
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public string get_count_saled()
          {
               string query = "EXEC saled";
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
          public decimal get_saled_day(int day)
          {
               string query = "EXEC dbo.day_week @day="+day;
               if (DAO.DataProvider.Instance.DisplayListView(query) == null)
               {
                    return 0;
               }
               else
               {
                   return decimal.Parse(DAO.DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString());
               }
          }
     }
}
