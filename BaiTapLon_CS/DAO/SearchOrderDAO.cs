using System;

namespace BaiTapLon_CS.DAO
{
    internal class SearchOrderDAO
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
               try
               {
                    string value = DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
                    return value;
               }
               catch (Exception e)
               {
                         return null;
               }
           
        }
    }



}
