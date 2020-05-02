using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class OrderDAO
     {
          public static OrderDAO instance;

          public static OrderDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new OrderDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public void AddOrder(string query)
          {
               DataProvider.Instance.Add(query);
          }
          public string getCountID_Invoice(string query)
          {
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
     }
     
}
