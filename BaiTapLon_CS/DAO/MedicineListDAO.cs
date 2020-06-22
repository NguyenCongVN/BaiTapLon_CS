namespace BaiTapLon_CS.DAO
{
    internal class MedicineListDAO
    {
        public static MedicineListDAO instance;

        public static MedicineListDAO Instance
        {
            get
            {
                if (instance == null)
                {
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
            string query = "EXEC countMedicine";
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
