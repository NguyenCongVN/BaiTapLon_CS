using BaiTapLon_CS.Class;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
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
            //GUI_Admin.listIsShow = true;
            //panelDanhSachNhanVien.Visible = false;
            //PanelSanPham.Visible = true;
            //PanelSanPham.BringToFront();
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
            ListShow.ContextMenuStrip = contextMenuStripListShow;
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
            LabelNgaySanXuat.Text = "Ngày Sản Xuất:" + medicine1.Date_Of_Manufacture.ToString();
            LabelDongGoi.Text = "Đóng gói:" + medicine1.Packing;
            LabelSoLuongTrongMoiGoi.Text = "Số Lượng trong mỗi gói:" + medicine1.Unit;
            LabelGiaThanh.Text = "Giá Thành:" + medicine1.Cost.ToString();
            LabelMaDangKi.Text = "Mã Đăng Kí:" + medicine1.Registration_Number;
            LabelXuatXu.Text = "Xuất Xứ:" + medicine1.Source;
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
            MedicineHelper.UpdateImage(Id, path);
            ImageShow.Image = ChangeBitmapHelper.ChangeBitMap(ImageShow, path);
        }
    }
}
