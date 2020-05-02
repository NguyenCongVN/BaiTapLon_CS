using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class SearchOrderDAO
     {
          public static SearchOrderDAO instance;
          public static SearchOrderDAO Instance
          {
               get
               {
                    if (instance == null)
                         return new SearchOrderDAO();
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public string getCountMedicine(string query)
          {
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
     }
     


}
