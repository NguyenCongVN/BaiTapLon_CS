namespace BaiTapLon_CS.DAO
{
    internal class HistoryDAO
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
            string query = "EXEC getCountInvoice @id = " + LoginDAO.ID_Manager;
            return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
        }
        public string getCount_Order_Detail()
        {
            string query = "EXEC getCount_Order_Detail @id=" + LoginDAO.ID_Manager;
            return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
        }

    }
}
