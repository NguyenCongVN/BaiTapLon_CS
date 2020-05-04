using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class Search_MedicineDAO
     {
          public static Search_MedicineDAO instance;
          public static Search_MedicineDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new Search_MedicineDAO();
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
              return DataProvider.Instance.DisplayListView(query);
          }


     }
}
