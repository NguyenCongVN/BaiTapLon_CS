using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class Medicine_DetailDAO
     {
          public static Medicine_DetailDAO instance;
          public static Medicine_DetailDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new Medicine_DetailDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public DataTable DisplatListView(string query)
          {
               return DAO.DataProvider.Instance.DisplayListView(query);
          }
          public string getTotalSell(string query)
          {
               return DAO.DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
          }
     }
}
