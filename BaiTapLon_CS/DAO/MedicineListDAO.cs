using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class MedicineListDAO
     {
          public static MedicineListDAO instance;

          public static MedicineListDAO Instance
          {
               get{ 
                    if (instance == null) {
                         return new MedicineListDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public string getCountMedicine()
          {
               string query = "SELECT COUNT(*) FROM Medicine";
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }

          public string getCountSearch(string query)
          {
               string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
               return value;
          }
     }
}
