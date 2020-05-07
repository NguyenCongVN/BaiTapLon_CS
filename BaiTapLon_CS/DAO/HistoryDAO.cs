using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class HistoryDAO
     {
          public static HistoryDAO instance;

          public static HistoryDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new HistoryDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public string getCountOrder()
          {
               string query = "SELECT Count(ID_Invoice) FROM Invoice as inv Where inv.ID_Manager = " + LoginDAO.ID_Manager;
               return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
          }
          public string getCount_Order_Detail()
          {
               string query = "SELECT Count(*) FROM Invoice as inv,Invoice_Detail as inde Where inv.ID_Invoice = inde.ID_Invoice and inv.ID_Manager = " + LoginDAO.ID_Manager;
               return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
          }

     }
}
