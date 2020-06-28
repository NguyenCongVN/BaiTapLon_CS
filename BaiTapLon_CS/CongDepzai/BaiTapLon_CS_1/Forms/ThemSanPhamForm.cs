using BaiTapLon_CS.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms;
using BaiTapLon_CS.Forms.Control;
using System;
using System.Collections.Generic;
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
            ShowMedicines.InitComboBoxCategory(ComboBoxLoaiHang);
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

            medicine.ID_Category = new List<int?> { (ComboBoxLoaiHang.SelectedItem as ComboBoxItem).Value };

            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "exec InsertMedicine @name,@source,@packing,@unit,@cost,@registationNumber,@idCategory";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddRange(new SqlParameter[] { new SqlParameter("name" , medicine.Name_Medicine)
                ,new SqlParameter("source" , medicine.Source)
                ,new SqlParameter("packing" , medicine.Packing),new SqlParameter("unit" , medicine.Unit)
                ,new SqlParameter("cost" , medicine.Cost)
                ,new SqlParameter("registationNumber" , medicine.Registration_Number)
                ,new SqlParameter("idCategory" , medicine.ID_Category[0])});
                sqlCommand.ExecuteScalar();
            }
            this.Close();
            boolClass.isChanged = true;
        }

        private void ButtonThemLoaiHang_Click(object sender, EventArgs e)
        {
            ThemLoaiHang themLoai = new ThemLoaiHang(boolClass);
            themLoai.ShowDialog();
            if (boolClass.isChanged == true)
            {
                ShowMedicines.InitComboBoxCategory(ComboBoxLoaiHang);
            }
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
