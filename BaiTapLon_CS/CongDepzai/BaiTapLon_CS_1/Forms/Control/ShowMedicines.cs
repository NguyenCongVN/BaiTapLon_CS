using BaiTapLon_CS.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms.Control
{
    public partial class ShowMedicines : UserControl
    {
        public ShowMedicines()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            foreach (ColumnHeader column in ListShow.Columns)
            {
                column.Width = -2;
            }
            ListShow.Items.Clear();
            List<Medicine> medicines = MedicineHelper.GetMedicines();
            int i = 0;
            foreach (var item in medicines)
            {
                i++;
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.ID_Medicine.ToString() ,
                    item.Name_Medicine ,
                    item.Remain_Amount.ToString() ,
                    item.Min_Expiry.Value.ToShortDateString() + " - " + item.Max_Expiry.Value.ToShortDateString() });
                ListShow.Items.Add(listViewItem);
                
            }
            ContextMenuStrip contextMenuStripListShow = new ContextMenuStrip();
            ToolStripMenuItem itemXoa = new ToolStripMenuItem();
            itemXoa.Name = "XoaSanPham";
            itemXoa.Text = "Xóa Sản Phẩm";
            itemXoa.Click += ItemXoa_Click;
            contextMenuStripListShow.Items.Add(itemXoa);
            ListShow.ContextMenuStrip = contextMenuStripListShow;
            InitComboBoxCategory(ComboBoxChonLoai);
        }
        public static void InitComboBoxCategory(ComboBox ComboBoxChonLoai)
        {
            //populate a combobox category
            ComboBoxChonLoai.Items.Clear();
            ComboBoxItem allItem = new ComboBoxItem { Text = "Tất Cả", Value = -1 };
            ComboBoxChonLoai.Items.Add(allItem);
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Category";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        ComboBoxItem item = new ComboBoxItem { Text = row.Field<string>("Name_Category"), Value = row.Field<int>("ID_Category") };
                        ComboBoxChonLoai.Items.Add(item);
                    }
                }
            }

        }

        private void ItemXoa_Click(object sender, EventArgs e)
        {
            if (ListShow.SelectedItems.Count > 0)
            {
                string id = ListShow.SelectedItems[0].SubItems[1].Text;
                string tenSanPham = ListShow.SelectedItems[0].SubItems[2].Text;
                string soLuong = ListShow.SelectedItems[0].SubItems[3].Text;
                DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xóa mặt hàng này không?\nTên Sản Phẩm: {tenSanPham} số lượng: {soLuong}", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult.CompareTo(DialogResult.Yes) == 0)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                    {
                        sqlConnection.Open();
                        string query = "delete from Medicine where ID_Medicine = @value";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("value", id);
                        sqlCommand.ExecuteScalar();
                    }
                    Init();
                }
            }
        }

        private void SelectShowList(object sender, EventArgs e)
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
                ImageShow.Image = ChangeBitmapHelper.ChangeBitMap(ImageShow, medicine1.Image_Medicine);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                ImageShow.Image = null;
            }
            LabelNgaySanXuat.Text = "Ngày Sản Xuất:" + medicine1.Min_Date_Of_Manufacture.Value.ToShortDateString()
                + " - " + medicine1.Max_Date_Of_Manufacture.Value.ToShortDateString();
            LabelDongGoi.Text = "Đóng gói:" + medicine1.Packing;
            LabelSoLuongTrongMoiGoi.Text = "Số Lượng trong mỗi gói:" + medicine1.Unit;
            LabelGiaThanh.Text = "Giá Thành:" + medicine1.Cost.ToString();
            LabelMaDangKi.Text = "Mã Đăng Kí:" + medicine1.Registration_Number;
            LabelXuatXu.Text = "Xuất Xứ:" + medicine1.Source;
            labelGiaNhap.Text = "Giá Nhập:Từ " + medicine1.Min_Import_Cost.ToString() + " tới" + medicine1.Max_Import_Cost.ToString();
        }

        private void ButtonNhapHang_Click(object sender, EventArgs e)
        {
            NhapHang nhapHang = new NhapHang();
            nhapHang.ShowDialog();
            Init();
        }

        private void ButtonSuaThongTinHang_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListShow.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                return;
            }
            BoolClass boolClass = new BoolClass();
            boolClass.isChanged = false;
            Medicine medicine1 = null;
            foreach (var medicine in MedicineHelper.GetMedicines())
            {
                if (medicine.ID_Medicine == Id)
                {
                    medicine1 = medicine;
                    medicine1.ID_Category = new List<int?>();
                    medicine1.Name_Category = new List<string>();
                    foreach(var category in MedicineHelper.GetCategoryOfTheMedicine(medicine.ID_Medicine))
                    {
                        medicine1.ID_Category.Add(category.CategoryID);
                        medicine1.Name_Category.Add(category.NameCategory);
                    }
                    break;
                }
            }
            ChangeInformationMedicine changeInformationMedicine = new ChangeInformationMedicine(medicine1, boolClass);
            changeInformationMedicine.ShowDialog();

            if (boolClass.isChanged == false)
            {
                return;
            }
            else
            {
                MedicineHelper.UpdateMedicine(medicine1, Id);
                MedicineHelper.UpdateCategoryWithMedicine(medicine1);
            }
            ListShow.Items.Clear();
            //button1_Click(PictureBoxDanhMucSanPham, null);
            Init();
            //ComboBoxChonLoai_SelectedValueChanged(ComboBoxChonLoai, null);
            SelectShowList(ListShow, new EventArgsForMedicine { Id = Id });
        }

        private void ButtonChonAnh_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListShow.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return;
            }
            string path = ExtensionHelper.ChoosePath();
            if(path != string.Empty)
            {
                try
                {
                    MedicineHelper.UpdateImage(Id, path);
                    ImageShow.Image = ChangeBitmapHelper.ChangeBitMap(ImageShow, path);
                }
                catch
                {
                    MessageBox.Show("Có Lỗi Xảy Ra!");
                }
            }
        }

        private void ComboBoxChonLoai_SelectedIndexChanged(object sender, EventArgs e)
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

        private void LabelMaDangKi_Click(object sender, EventArgs e)
        {

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

        private void panel1_Click(object sender, EventArgs e)
        {
            NhapHang nhapHang = new NhapHang();
            nhapHang.ShowDialog();
            Init();
        }
    }
}
