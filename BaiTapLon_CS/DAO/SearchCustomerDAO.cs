using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class SearchCustomerDAO
     {
          public static SearchCustomerDAO instance;

          public static SearchCustomerDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new SearchCustomerDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public DataTable DisplayListView(string query)
          {
               return DAO.DataProvider.Instance.DisplayListView(query);
          }
     }
}
