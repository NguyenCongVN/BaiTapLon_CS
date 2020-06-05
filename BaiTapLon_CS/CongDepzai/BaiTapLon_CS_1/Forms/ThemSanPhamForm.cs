using BaiTapLon_CS.Class;
using BaiTapLon_CS.Forms.Control;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms
{
    public partial class ThemSanPhamForm : Form
    {
        private CategoryListBoxControl control;
        public BoolClass boolClass;
        public Medicine medicine;
        public ThemSanPhamForm(BoolClass boolClass)
        {
            InitializeComponent();
            this.boolClass = boolClass;

        }

        private void ThemSanPhamForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAITAPLONDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.bAITAPLONDataSet.Category);
            // TODO: This line of code loads data into the 'quanLyBanThuocDataSet.Category' table. You can move, or remove it, as needed.
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            if (medicine == null)
            {
                medicine = new Medicine();
                control = new CategoryListBoxControl(medicine);
            }
            medicine.Name_Medicine = TextBoxTenSanPham.Text;
            medicine.Source = TextBoxXuatXu.Text;
            medicine.Packing = TextBoxDongGoi.Text;
            medicine.Unit = TextBoxSoLuongTrongMoiGoi.Text;

            try
            {
                medicine.Cost = Decimal.Parse(TextBoxGiaThanh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap sai thành tiền sản phẩm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            medicine.Registration_Number = TextBoxMaDangKi.Text;

            medicine.ID_Category.Add((ComboBoxLoaiHang.SelectedItem as DataRowView).Row.Field<int>("ID_Category"));

            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "insert into Medicine values (@name,null,@manufactureDate,@experitationDate,@source,@packing,@unit,@cost,@amount,@registationNumber,@idCategory)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddRange(new SqlParameter[] { new SqlParameter("name" , medicine.Name_Medicine)
                ,new SqlParameter("source" , medicine.Source)
                ,new SqlParameter("packing" , medicine.Packing),new SqlParameter("unit" , medicine.Unit)
                ,new SqlParameter("cost" , medicine.Cost)
                ,new SqlParameter("registationNumber" , medicine.Registration_Number)
                ,new SqlParameter("idCategory" , medicine.ID_Category)});
                sqlCommand.ExecuteScalar();
            }
            this.Close();
            boolClass.isChanged = true;
        }
    }
}
