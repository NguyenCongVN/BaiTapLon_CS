using BaiTapLon_CS.Class;
using BaiTapLon_CS.Forms.Control;
using BaiTapLon_CS.Helper;
using System;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms
{
    public partial class ChangeInformationMedicine : Form
    {
        private Medicine medicine;
        private BoolClass Check;
        private CategoryListBoxControl control;
        public ChangeInformationMedicine(Medicine medicine, BoolClass check)
        {
            InitializeComponent();
            control = new CategoryListBoxControl(medicine);
            control.SetBounds(200, 10, control.Width, control.Height);
            this.Controls.Add(control);
            control.BringToFront();
            TextBoxMaSanPham.Text = medicine.ID_Medicine.ToString();
            TextBoxMaSanPham.ReadOnly = true;
            TextBoxTenSanPham.Text = medicine.Name_Medicine;
            //TextBoxNgayHetHan.Text = medicine.Expiry_Date.Value.Day.ToString();
            //TextBoxNamHetHan.Text = medicine.Expiry_Date.Value.Year.ToString();
            //TextBoxThangHetHan.Text = medicine.Expiry_Date.Value.Month.ToString();
            TextBoxSoLuongCon.Text = medicine.Remain_Amount.ToString();
            TextBoxXuatXu.Text = medicine.Source;
            //TextBoxNgaySanXuat.Text = medicine.Date_Of_Manufacture.Value.Day.ToString();
            //TextBoxThangSanXuat.Text = medicine.Date_Of_Manufacture.Value.Month.ToString();
            //TextBoxNamSanXuat.Text = medicine.Date_Of_Manufacture.Value.Year.ToString();

            //TextBoxNgayNhap.Text = medicine.Import_Date.Value.Day.ToString();
            //TextBoxThangNhap.Text = medicine.Import_Date.Value.Month.ToString();
            //TextBoxNamNhap.Text = medicine.Import_Date.Value.Year.ToString();

            TextBoxDongGoi.Text = medicine.Packing;
            TextBoxSoLuongTrongMoiGoi.Text = medicine.Unit;
            TextBoxGiaThanh.Text = medicine.Cost.ToString();
            TextBoxMaDangKi.Text = medicine.Registration_Number.ToString();
            this.medicine = medicine;
            this.Check = check;
            int i = 1;
            foreach (var item in MedicineHelper.GetImportHistory(medicine.ID_Medicine))
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Import_Date.ToString() ,
                    item.Date_Of_Manufacture.ToShortDateString() ,
                    item.Expiry_Date.ToShortDateString() ,
                    item.ID_Import.ToString()
                    });
                ListImport.Items.Add(listViewItem);
                i++;
            }
        }
        private void ButtonApDung_Click(object sender, EventArgs e)
        {

            medicine.Name_Category.Clear();
            foreach (var x in control.checkListBox.CheckedItems)
                medicine.Name_Category.Add(x.ToString());

            medicine.ID_Category.Clear();
            foreach (var x in medicine.Name_Category)
            {
                medicine.ID_Category.Add(MedicineHelper.GetIdCategoryWithName(x));
            }

            medicine.Name_Medicine = TextBoxTenSanPham.Text;
            try
            {
                //medicine.Expiry_Date = new DateTime(int.Parse(TextBoxNamHetHan.Text),int.Parse(TextBoxThangHetHan.Text)  , int.Parse(TextBoxNgayHetHan.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap sai ngày tháng hết hạn", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            medicine.Source = TextBoxXuatXu.Text;

            try
            {
                //medicine.Expiry_Date = new DateTime(int.Parse(TextBoxNamSanXuat.Text), int.Parse(TextBoxThangSanXuat.Text),  int.Parse(TextBoxNgaySanXuat.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap sai ngày tháng sản xuất", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            medicine.Packing = TextBoxDongGoi.Text;
            medicine.Unit = TextBoxSoLuongTrongMoiGoi.Text;

            try
            {
                medicine.Cost = Decimal.Parse(TextBoxGiaThanh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhap sai thành tiền sản phẩm", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            medicine.Registration_Number = TextBoxMaDangKi.Text;


            Check.isChanged = true;
            this.Close();

        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeInformationMedicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAITAPLONDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.bAITAPLONDataSet.Category);

        }

        private void ChangeInformationMedicine_MouseClick(object sender, MouseEventArgs e)
        {
            int height = control.checkListBox.Height / 5;
            if (height >= 20)
                //Point mousePoint = System.Windows.Forms.Cursor.Position;
                if (control.Cursor.HotSpot.IsEmpty == true)
                {
                    control.checkListBox.SetBounds(control.checkListBox.Location.X, control.checkListBox.Location.Y,
                        control.checkListBox.Width, height + 10);
                    control.SetBounds(control.Location.X, control.Location.Y, control.Width,
                        control.checkListBox.Height);
                }
        }

        private void ListImport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowTheImportHistoryForm history = new ShowTheImportHistoryForm(int.Parse(ListImport.SelectedItems[0].SubItems[4].Text));
            history.ShowDialog();
        }
    }
}
