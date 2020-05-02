using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class AddCustomerDAO
     {
          public static AddCustomerDAO instance;
          public static AddCustomerDAO Instance
          {
               get
               {
                    if (instance == null)
                         return new AddCustomerDAO();
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public void AddCustomer(string query)
          {
               DataProvider.Instance.Add(query);
          }
     }
}
