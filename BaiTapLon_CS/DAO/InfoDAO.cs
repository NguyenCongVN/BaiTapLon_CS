using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CS.DAO
{
     class InfoDAO
     {
          public static InfoDAO instance;

          public static InfoDAO Instance
          {
               get
               {
                    if (instance == null)
                    {
                         return new InfoDAO();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }
          public DataTable getInfo()
          {
               string query = "SELECT * FROM Manager WHERE ID_Manager =" + Form1.ID_Manager;
               return DataProvider.Instance.DisplayListView(query);
          }
          public void updateInfo(string query)
          {
               DAO.DataProvider.Instance.Add(query);
          }
     }
}
