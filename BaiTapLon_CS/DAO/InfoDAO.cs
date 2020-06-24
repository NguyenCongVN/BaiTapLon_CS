using System.Data;

namespace BaiTapLon_CS.DAO
{
    internal class InfoDAO
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
            string query = "EXEC getInfo @id =" + Form1.ID_Manager;
            return DataProvider.Instance.DisplayListView(query);
        }
        public void updateInfo(string query)
        {
            DAO.DataProvider.Instance.Add(query);
        }
    }
}
