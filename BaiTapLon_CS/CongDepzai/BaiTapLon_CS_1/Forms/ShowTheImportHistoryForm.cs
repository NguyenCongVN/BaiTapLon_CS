using BaiTapLon_CS.Helper;
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
            string query = "exec ShowImportDetail @value";


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
                textBoxTongTien.Text = ExtensionHelper.ChangeToCurrency(total.ToString());
            }
        }


        public void ShowList()
        {
            string query = "exec GetImportHistoryDetail @value";

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
                    item.Field<DateTime>("Date_Of_Manufacture").ToShortDateString(),
                    item.Field<DateTime>("Expiry_Date").ToShortDateString() ,
                    item.Field<int>("Amount").ToString()
                    });
                    listView1.Items.Add(listViewItem);
                }
            }
        }
    }


}
