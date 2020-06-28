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
            string qq = "exec getCountToday @id ="+LoginDAO.ID_Manager;
            return DataProvider.Instance.DisplayListView(qq).Rows[0][0].ToString();
        }
        public string getCountMonth()
        {     
               string qq = "exec getCountMonth @id="+LoginDAO.ID_Manager;
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
