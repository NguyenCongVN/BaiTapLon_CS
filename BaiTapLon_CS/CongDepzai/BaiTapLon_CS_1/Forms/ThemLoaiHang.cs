using BaiTapLon_CS.Class;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms
{
    public partial class ThemLoaiHang : Form
    {
        public BoolClass Value { get; set; }
        public ThemLoaiHang(BoolClass value)
        {
            InitializeComponent();
            Value = value;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Value.isChanged = true;
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                string query = "exec InsertCategory @value";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("value", textBoxTenLoai.Text);
                command.ExecuteScalar();
            }
            this.Close();
        }
    }
}
