namespace BaiTapLon_CS.DAO
{
    internal class ChangePasswordDAO
    {
        public static ChangePasswordDAO instance;

        public static ChangePasswordDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    return new ChangePasswordDAO();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public string confirm()
        {
            string query = "SELECT Password FROM Manager";
            return DataProvider.Instance.DisplayListView(query).Rows[0][0].ToString();
        }
        public void updateInfo(string query)
        {
            DAO.DataProvider.Instance.Add(query);
        }

    }
}
