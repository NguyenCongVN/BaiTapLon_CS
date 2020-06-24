using System;
using System.Collections.Generic;
using System.Data;

namespace BaiTapLon_CS.DAO
{
    internal class AnalyticsDAO
    {
        public static AnalyticsDAO instance;

        public static AnalyticsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    return new AnalyticsDAO();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public string getCountInvoice(string query)
        {
            return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
        }
        public string getCountToday()
        {
            string query = "ALTER PROC getCountToday AS BEGIN " +
                    "SELECT COUNT(*) FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                   "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") " +
                   "and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                   ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + LoginDAO.ID_Manager+" end";
               DataProvider.Instance.Add(query);
             
               string qq = "exec getCountToday";
            return DataProvider.Instance.DisplayListView(qq).Rows[0][0].ToString();
        }
        public string getCountMonth()
        {
            string query = "ALTER PROC getCountMonth AS BEGIN " +
                    " SELECT COUNT(*) FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                  "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice " +
                  "AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                  ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") " +
                  "and inv.ID_Manager =" + LoginDAO.ID_Manager+ " end";
               DataProvider.Instance.Add(query);
              
               string qq = "exec getCountMonth";
               return DataProvider.Instance.DisplayListView(qq).Rows[0][0].ToString();
        }
        public List<String> getCategoty(int id)
        {
            List<string> category = new List<string>();
            List<int> idCategory = new List<int>();
            string query = "EXEC manufacturerr @id ="+id;
            DataTable dt = DataProvider.Instance.DisplayListView(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    idCategory.Add(int.Parse(dr["ID_Category"].ToString()));
                }
            }
            category.Add("Tất cả");
            foreach (var i in idCategory)
            {
                string q = "EXEC Categorry @id=" + i;
                category.Add(DAO.DataProvider.Instance.DisplayListView(q).Rows[0][0].ToString());
            }
            return category;
        }

    }
}
