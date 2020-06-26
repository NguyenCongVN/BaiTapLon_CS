using BaiTapLon_CS.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms;
using BaiTapLon_CS.Forms.Control;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms
{
    public partial class NhapHang : Form
    {
        private int i = 1;

        private int iteratorAdd = 1;

        public List<Tuple<Medicine, int>> listToAdd = new List<Tuple<Medicine, int>>();

        public NhapHang()
        {
            InitializeComponent();
            InitilizeManufaturerComboBox();
            ShowMedicines.InitComboBoxCategory(ComboBoxChonLoai);
            ListNhapHang.Columns[5].Width = 0;
            ListShow.Items.Clear();
            List<Medicine> medicines = MedicineHelper.GetMedicines();
            int i = 0;
            foreach (var item in medicines)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.ID_Medicine.ToString() ,
                    item.Name_Medicine ,
                    item.Remain_Amount.ToString() ,
                    item.Expiry_Date.ToString()});
                ListShow.Items.Add(listViewItem);
                i++;
            }
            ContextMenuStrip contextMenuStripListShow = new ContextMenuStrip();
            ToolStripMenuItem itemXoa = new ToolStripMenuItem();
            itemXoa.Name = "XoaSanPham";
            itemXoa.Text = "Xóa Sản Phẩm";
            itemXoa.Click += ItemXoa_Click;
            contextMenuStripListShow.Items.Add(itemXoa);
            ListNhapHang.ContextMenuStrip = contextMenuStripListShow;
        }

        private void ItemXoa_Click(object sender, EventArgs e)
        {
            int idXoa = -1;
            try
            {
                idXoa = int.Parse(ListNhapHang.SelectedItems[0].SubItems[5].Text);
                foreach (var medicine in listToAdd)
                {
                    if (medicine.Item2 == idXoa)
                    {
                        listToAdd.Remove(medicine);
                        break;
                    }
                }
                ListNhapHang.SelectedItems[0].Remove();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ma xoa san pham khong hop le");
            }

        }

        private void ButtonThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            Medicine medicine;
            BoolClass boolClass = new BoolClass() { isChanged = false };
            ThemSanPhamForm themSanPhamForm = new ThemSanPhamForm(boolClass);
            themSanPhamForm.ShowDialog();
            if (boolClass.isChanged == true)
            {
                ListShow.Items.Clear();
                List<Medicine> medicines = MedicineHelper.GetMedicines();
                int i = 0;
                foreach (var item in medicines)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.ID_Medicine.ToString() ,
                    item.Name_Medicine ,
                    item.Remain_Amount.ToString() ,
                    item.Expiry_Date.ToString()});
                    ListShow.Items.Add(listViewItem);
                    i++;
                }
            }
            ShowMedicines.InitComboBoxCategory(ComboBoxChonLoai);
        }

        private void ListShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id;
            try
            {
                if (ListShow.SelectedItems.Count > 0)
                    Id = int.Parse(ListShow.SelectedItems[0].SubItems[1].Text);
                else return;
            }
            catch (Exception ex)
            {
                if (e is EventArgsForMedicine)
                {
                    Id = ((EventArgsForMedicine)e).Id;
                }
                else
                {
                    return;
                }
            }
            Medicine medicine1 = new Medicine();
            foreach (var medicine in MedicineHelper.GetMedicines())
            {
                if (medicine.ID_Medicine == Id)
                {
                    medicine1 = medicine;
                    break;
                }
            }

            if (medicine1.Remain_Amount != null)
            {
                TextBoxSoLuongCon.Text = medicine1.Remain_Amount.Value.ToString();
            }
            TextBoxXuatXu.Text = medicine1.Source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListShow.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                if (e is EventArgsForMedicine)
                {
                    Id = ((EventArgsForMedicine)e).Id;
                }
                else
                {
                    return;
                }
            }
            Medicine medicine1 = new Medicine();

            medicine1 = MedicineHelper.GetMedicineWithId(Id);

            try
            {
                DateTime dateTime = new DateTime(int.Parse(TextBoxNamSanXuat.Text),
                    int.Parse(TextBoxThangSanXuat.Text),
                    int.Parse(TextBoxNgaySanXuat.Text));
                medicine1.Date_Of_Manufacture = dateTime;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                MessageBox.Show("Lỗi Nhập Vào Ngày Sản Xuất !");
                return;
            }

            try
            {
                DateTime dateTime1;
                DateTime dateTime;
                DateTime dateTime2;
                int NgaySuDung = 0;
                int ThangSuDung = 0;
                int NamSuDung = 0;
                try
                {
                    NgaySuDung = int.Parse(TextBoxNgaySuDung.Text);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());

                }

                try
                {
                    ThangSuDung = int.Parse(TextBoxThangSuDung.Text);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }

                try
                {
                    NamSuDung = int.Parse(TextBoxNamSuDung.Text);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }

                if (NgaySuDung == 0 && ThangSuDung == 0 && NamSuDung == 0)
                {
                    throw new Exception("Lỗi Nhập Vào Hạn Sử Dụng !");
                }
                if (medicine1.Date_Of_Manufacture != null)
                {
                    dateTime2 = new DateTime(medicine1.Date_Of_Manufacture.Value.Year,
                   medicine1.Date_Of_Manufacture.Value.Month,
                   medicine1.Date_Of_Manufacture.Value.Day);

                    dateTime1 = new DateTime(dateTime2.AddYears(NamSuDung).Year,
                      dateTime2.AddMonths(ThangSuDung).Month,
                      dateTime2.AddDays(NgaySuDung).Day);
                    medicine1.Expiry_Date = dateTime1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                int amount = int.Parse(textBoxSoLuong.Text);
                medicine1.Remain_Amount = amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Nhập Vào Số Lượng !");
                return;
            }
            medicine1.ID_Category = new List<int?>();
            medicine1.ID_Manufacturer = new List<int?>();
            try
            {
                int idManufacturer = (int)(ComboBoxCongty.SelectedItem as ComboBoxItem).Value;
                if (!medicine1.ID_Manufacturer.Contains(idManufacturer))
                    medicine1.ID_Manufacturer.Add(idManufacturer);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            try
            {
                int idCategory = (ComboBoxChonLoai.SelectedItem as ComboBoxItem).Value;
                if (!medicine1.ID_Category.Contains(idCategory))
                    medicine1.ID_Category.Add(idCategory);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            listToAdd.Add(new Tuple<Medicine, int>(medicine1, iteratorAdd));



            ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , medicine1.ID_Medicine.ToString() ,
                    medicine1.Name_Medicine ,
                    medicine1.Remain_Amount.ToString() ,
                    medicine1.Expiry_Date.ToString() , iteratorAdd.ToString()});
            ListNhapHang.Items.Add(listViewItem);
            iteratorAdd++;
            i++;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAITAPLONDataSet.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.bAITAPLONDataSet.Manufacturer);
            // TODO: This line of code loads data into the 'bAITAPLONDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.bAITAPLONDataSet.Category);

        }


        private void ComboBoxChonLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idCategory = 0;
                idCategory = (ComboBoxChonLoai.SelectedItem as ComboBoxItem).Value;
                ListShow.Items.Clear();

                using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                {
                    if (idCategory > 0)
                    {
                        int i = 0;
                        List<Medicine> medicines = MedicineHelper.GetMedicinesWithCategory(idCategory);
                        foreach (var item in medicines)
                        {
                            ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.ID_Medicine.ToString() ,
                    item.Name_Medicine ,
                    item.Remain_Amount.ToString() ,
                    item.Min_Expiry.Value.ToShortDateString() + " - " + item.Max_Expiry.Value.ToShortDateString() });
                            ListShow.Items.Add(listViewItem);
                            i++;
                        }
                    }
                    else
                    {
                        List<Medicine> medicines = MedicineHelper.GetMedicines();
                        int i = 0;
                        foreach (var item in medicines)
                        {
                            ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.ID_Medicine.ToString() ,
                    item.Name_Medicine ,
                    item.Remain_Amount.ToString() ,
                    item.Min_Expiry.Value.ToShortDateString() + " - " + item.Max_Expiry.Value.ToShortDateString()});
                            ListShow.Items.Add(listViewItem);
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ButtonXacNhan_Click(object sender, EventArgs e)
        {
            foreach (var x in listToAdd)
            {
                MedicineHelper.ImportMedicine(x.Item1);
            }
            this.Dispose();
        }

        private void TextBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            ListShow.Items.Clear();
            List<Medicine> medicines = MedicineHelper.GetMedicines();
            int i = 0;
            foreach (var item in medicines)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.ID_Medicine.ToString() ,
                    item.Name_Medicine ,
                    item.Remain_Amount.ToString() ,
                    item.Min_Expiry.Value.ToShortDateString() + " - " + item.Max_Expiry.Value.ToShortDateString() });
                ListShow.Items.Add(listViewItem);
            }
            foreach (ListViewItem item in ListShow.Items)
            {
                if (!item.SubItems[2].Text.ToLower().Contains(TextBoxTimKiem.Text.ToLower()))
                    ListShow.Items.Remove(item);
            }
        }

        private void buttonThemCongTy_Click(object sender, EventArgs e)
        {
            BoolClass boolClass = new BoolClass { isChanged = false };
            ThemCongTy themCongTy = new ThemCongTy(boolClass);
            themCongTy.ShowDialog();
            if(boolClass.isChanged = true)
            {
                InitilizeManufaturerComboBox();
            }
        }

        private void InitilizeManufaturerComboBox()
        {
            ComboBoxCongty.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manufacturer";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        ComboBoxItem item = new ComboBoxItem { Text = row.Field<string>("Name_Manufacturer"), Value = row.Field<int>("ID_Manufacturer") };
                        ComboBoxCongty.Items.Add(item);
                    }
                }
            }
        }
    }
}
