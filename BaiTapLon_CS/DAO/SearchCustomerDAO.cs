using System.Data;

namespace BaiTapLon_CS.DAO
{
    internal class SearchCustomerDAO
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
