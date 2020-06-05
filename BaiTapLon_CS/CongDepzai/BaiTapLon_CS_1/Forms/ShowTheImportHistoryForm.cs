using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms
{
    public partial class ShowTheImportHistoryForm : Form
    {
        public int importID;
        public ShowTheImportHistoryForm(int ImportID)
        {
            importID = ImportID;
            InitializeComponent();
            ShowList();
            FillTheTextBox();
        }

        public void FillTheTextBox()
        {
            string query = "select manager.Name_Manager, " +
"import.Import_Date, " +
"import.ID_Import, " +
"sum(Cost) as 'Total' " +
"from Import import " +
"inner " +
"join Manager manager " +
"on import.ID_Manager = manager.ID_Manager " +
"inner " +
"join Import_Detail detail " +
"on detail.ID_Import = import.ID_Import " +
"where import.ID_Import = @value " +
"group by manager.Name_Manager, " +
"import.Import_Date, " +
"import.ID_Import";


            SqlConnection connection = new SqlConnection(Form1.connect);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("value", importID);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                string nameManager = table.Rows[0].Field<string>("Name_Manager");
                DateTime importDate = table.Rows[0].Field<DateTime>("Import_Date");
                decimal total = table.Rows[0].Field<decimal>("Total");
                textBoxMaNhap.Text = importID.ToString();
                textBoxNguoiNhap.Text = nameManager;
                TextBoxNgayNhap.Text = importDate.Day.ToString();
                TextBoxThangNhap.Text = importDate.Month.ToString();
                TextBoxNamNhap.Text = importDate.Year.ToString();
                textBoxTongTien.Text = total.ToString();
            }
        }


        public void ShowList()
        {
            string query = "select detail.Date_Of_Manufacture, " +
    "detail.Expiry_Date, " +
    "detail.Amount, " +
    "detail.Cost, " +
    "medicine.Name_Medicine " +
    "from Import import inner join " +
    "Import_Detail detail " +
    "on import.ID_Import = detail.ID_Import " +
    "inner join Manager manager " +
    "on manager.ID_Manager = import.ID_Manager " +
    "inner join Medicine medicine " +
    "on detail.ID_Medicine = medicine.ID_Medicine " +
    "where import.ID_Import = @value";

            SqlConnection connection = new SqlConnection(Form1.connect);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("value", importID);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow item in table.Rows)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {item.Field<string>("Name_Medicine") ,
                    item.Field<DateTime>("Date_Of_Manufacture").ToString() ,
                    item.Field<DateTime>("Expiry_Date").ToString() ,
                    item.Field<int>("Amount").ToString()
                    });
                    listView1.Items.Add(listViewItem);
                }
            }
        }
    }


}
