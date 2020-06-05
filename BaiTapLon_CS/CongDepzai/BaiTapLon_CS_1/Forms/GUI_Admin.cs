using BaiTapLon_CS.Class;
using BaiTapLon_CS.Forms;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class GUI_Admin : Form
    {

        public static bool listIsShow = false;
        public GUI_Admin()
        {
            InitializeComponent();

            PictureBoxDanhMucSanPham.Image =
                ChangeBitmapHelper.ChangeBitMap(PictureBoxDanhMucSanPham, @"C:\Users\chubo\Documents\BaiTapLon_CS\BaiTapLon_CS\Resource\Icon\LookupIcon.png");

            PictureBoxDanhSachNhanVien.Image =
                ChangeBitmapHelper.ChangeBitMap(PictureBoxDanhSachNhanVien, @"C:\Users\chubo\Documents\BaiTapLon_CS\BaiTapLon_CS\Resource\Icon\EmployeeIcon.png"); ;

            PictureBoxThongKe.Image =
                ChangeBitmapHelper.ChangeBitMap(PictureBoxThongKe, @"C:\Users\chubo\Documents\BaiTapLon_CS\BaiTapLon_CS\Resource\Icon\TaskIcon.png"); ;

            PictureBoxXuatFile.Image =
                ChangeBitmapHelper.ChangeBitMap(PictureBoxXuatFile, @"C:\Users\chubo\Documents\BaiTapLon_CS\BaiTapLon_CS\Resource\Icon\ExportFileIcon.png"); ; ;

        }

        private void GUI_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAITAPLONDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.bAITAPLONDataSet.Category);
            // TODO: This line of code loads data into the 'bAITAPLONDataSet.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.bAITAPLONDataSet.Medicine);
            // TODO: This line of code loads data into the 'quanLyBanThuocDataSet.Category' table. You can move, or remove it, as needed.

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //0, 2
        private void button1_Click(object sender, EventArgs e)
        {
            GUI_Admin.listIsShow = true;
            panelDanhSachNhanVien.Visible = false;
            PanelSanPham.Visible = true;
            PanelSanPham.BringToFront();
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
                    button1_Click(PictureBoxDanhMucSanPham, null);
                }
            }
        }

        private void ItemThem_Click(object sender, EventArgs e)
        {
            BoolClass boolClass = new BoolClass();
            boolClass.isChanged = false;
            ThemSanPhamForm themSanPhamForm = new ThemSanPhamForm(boolClass);
            themSanPhamForm.ShowDialog();
            if (boolClass.isChanged == true)
            {
                ListShow.Items.Clear();
                try
                {
                    int selected = (ComboBoxChonLoai.SelectedItem as DataRowView).Row.Field<int>("ID_Category");
                    string query = "select * from Medicine a left join Category b on a.ID_Category = b.ID_Category where b.ID_Category = @value";
                    using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                    {
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("value", selected);
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            ListShow.Items.Clear();
                            int i = 1;
                            foreach (DataRow item in dataTable.Rows)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Field<int>("Id_Medicine").ToString() , item.Field<string>("Name_Medicine") ,
                        item.Field<int>("Amount").ToString() , item.Field<DateTime>("Experition_Date").ToString()});
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
        }
        //Set The Medicine Interface
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
        // Set The Image Of medicine
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


        //Change the medicine information
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
            button1_Click(PictureBoxDanhMucSanPham, null);
            ComboBoxChonLoai_SelectedValueChanged(ComboBoxChonLoai, null);
            SelectShowList(ListShow, new EventArgsForMedicine { Id = Id });
        }

        private void ComboBoxChonLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            if (GUI_Admin.listIsShow)
                try
                {
                    int idCategory = 0;
                    idCategory = (ComboBoxChonLoai.SelectedItem as DataRowView).Row.Field<int>("ID_Category");
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
                    item.Expiry_Date.ToString()});
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
                    item.Expiry_Date.ToString()});
                                ListShow.Items.Add(listViewItem);
                                i++;
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Debug.WriteLine(ex.StackTrace);
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ComboBoxChonLoai_SelectedValueChanged(ComboBoxChonLoai, null);
            foreach (ListViewItem item in ListShow.Items)
            {
                if (!item.SubItems[2].Text.ToLower().Contains(TextBoxTimKiem.Text.ToLower()))
                    ListShow.Items.Remove(item);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            PanelSanPham.Visible = false;
            //PanelSanPham.SendToBack();
            panelDanhSachNhanVien.Visible = true;
            panelDanhSachNhanVien.BringToFront();
            ListViewDanhSachNhanVien.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manager";
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    int i = 1;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow item in dataTable.Rows)
                    {
                        ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Field<int>("ID_Manager").ToString() , item.Field<string>("Name_Manager")
                        , item.Field<string>("Email")});
                        ListViewDanhSachNhanVien.Items.Add(listViewItem);
                        i++;
                    }
                }
            }
            ContextMenuStrip contextMenuStripListShow = new ContextMenuStrip();
            ToolStripMenuItem itemThem = new ToolStripMenuItem();
            itemThem.Name = "ThemNhanVien";
            itemThem.Text = "Thêm Nhân Viên";
            itemThem.Click += ItemThemNhanVien_Click;

            ToolStripMenuItem itemXoa = new ToolStripMenuItem();
            itemXoa.Name = "XoaNhanVien";
            itemXoa.Text = "Xóa Nhân Viên";
            itemXoa.Click += ItemXoaNhanVien_Click;
            contextMenuStripListShow.Items.Add(itemThem);
            contextMenuStripListShow.Items.Add(itemXoa);
            ListViewDanhSachNhanVien.ContextMenuStrip = contextMenuStripListShow;
        }

        private void ItemXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (ListViewDanhSachNhanVien.SelectedItems[0] != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                    {
                        string query = "delete from Manager where ID_Manager = @value";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("value", ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1]);
                        sqlCommand.ExecuteScalar();
                    }
                }
            }
        }

        private void ItemThemNhanVien_Click(object sender, EventArgs e)
        {
            BoolClass boolClass = new BoolClass();
            boolClass.isChanged = false;
            Manager manager = new Manager();
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm(manager, boolClass);
            themNhanVienForm.ShowDialog();
            if (boolClass.isChanged == true)
            {
                PictureBoxDanhSachNhanVien_Click(PictureBoxDanhSachNhanVien, null);
            }
        }

        private void ListViewDanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Id;
            try
            {
                Id = int.Parse(ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
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
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manager where ID_Manager = @value";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    Manager manager = new Manager
                    {
                        Email = dataTable.Rows[0].Field<string>("Email"),
                        ID_Manager = dataTable.Rows[0].Field<int>("ID_Manager"),
                        Name_Manager = dataTable.Rows[0].Field<string>("Name_Manager"),
                        Password = dataTable.Rows[0].Field<string>("Password"),
                        Phone = dataTable.Rows[0].Field<string>("Phone"),
                        Image = dataTable.Rows[0].Field<string>("Image")
                    };
                    LabelTenNhanVien.Text = "Tên:" + manager.Name_Manager;
                    LabelMaNhanVien.Text = "Mã Nhân Viên:" + manager.ID_Manager.ToString();
                    LabelEmail.Text = "Email:" + manager.Email;
                    LabelDienThoai.Text = "Điện Thoại:" + manager.Phone;
                    try
                    {
                        Bitmap bitmap = new Bitmap(manager.Image);
                        Bitmap bitmap1 = new Bitmap(bitmap, PictureBoxNhanVien.Width, PictureBoxNhanVien.Height);
                        PictureBoxNhanVien.Image = bitmap1;
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void ButtonChonAnhNhanVien_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jfif;*.png| Select All | *";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                {
                    sqlConnection.Open();
                    string query = "update Manager set Image =@value where ID_Manager = @selectedId";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("value", path);
                    sqlCommand.Parameters.AddWithValue("selectedId", Id);
                    sqlCommand.ExecuteScalar();
                }
                Bitmap bitmap = new Bitmap(path);
                Bitmap resizedBitmap = new Bitmap(bitmap, new Size(PictureBoxNhanVien.Width, PictureBoxNhanVien.Height));
                PictureBoxNhanVien.Image = resizedBitmap;
            }
        }

        private void ThayDoiThongTinNhanVien_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                return;
            }
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manager where ID_Manager = @value";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    Manager manager = new Manager
                    {
                        Email = dataTable.Rows[0].Field<string>("Email"),
                        ID_Manager = dataTable.Rows[0].Field<int>("ID_Manager"),
                        Name_Manager = dataTable.Rows[0].Field<string>("Name_Manager"),
                        Password = dataTable.Rows[0].Field<string>("Password"),
                        Phone = dataTable.Rows[0].Field<string>("Phone"),
                        Image = dataTable.Rows[0].Field<string>("Image"),
                        DayWork = dataTable.Rows[0].Field<DateTime>("Day_Work"),
                        Salary = dataTable.Rows[0].Field<decimal>("Salary"),
                        Sex = dataTable.Rows[0].Field<bool>("Sex")
                    };
                    BoolClass boolClass = new BoolClass();
                    boolClass.isChanged = false;
                    ChangeInformationManager changeInformationManager = new ChangeInformationManager(manager, boolClass);
                    changeInformationManager.ShowDialog();

                    if (boolClass.isChanged == false)
                    {
                        return;
                    }
                    else
                    {
                        sqlConnection.Open();
                        string query1 = "update Manager set Name_Manager = @name, " +
                                        "Phone = @phone, " +
                                        "Email = @email " +
                                        ",Password = @password " +
                                        ",Day_Work = @daywork " +
                                        ",Salary = @salary " +
                                        ",Sex = @sex " +
                                        "where ID_Manager = @old_Id";
                        SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
                        sqlCommand1.Parameters.AddWithValue("name", manager.Name_Manager);
                        sqlCommand1.Parameters.AddWithValue("Phone", manager.Phone);
                        sqlCommand1.Parameters.AddWithValue("Email", manager.Email);
                        sqlCommand1.Parameters.AddWithValue("Password", manager.Password);
                        sqlCommand1.Parameters.AddWithValue("daywork", manager.DayWork);
                        sqlCommand1.Parameters.AddWithValue("salary", manager.Salary);
                        sqlCommand1.Parameters.AddWithValue("sex", manager.Sex);
                        sqlCommand1.Parameters.AddWithValue("old_Id", Id);
                        sqlCommand1.ExecuteScalar();
                    }
                }
                ListViewDanhSachNhanVien.Items.Clear();
                PictureBoxDanhSachNhanVien_Click(PictureBoxDanhSachNhanVien, null);
                ListViewDanhSachNhanVien_SelectedIndexChanged(ListViewDanhSachNhanVien, null);
            }
        }

        private void TextBoxTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            PictureBoxDanhSachNhanVien_Click(PictureBoxDanhSachNhanVien, null);
            foreach (ListViewItem item in ListViewDanhSachNhanVien.Items)
            {
                if (!item.SubItems[2].Text.ToLower().Contains(TextBoxTimKiemNhanVien.Text.ToLower()))
                {
                    ListViewDanhSachNhanVien.Items.Remove(item);
                }
            }
        }

        private void PictureBoxThongKe_Click(object sender, EventArgs e)
        {
            panelThongKe.Visible = true;
            List<MoneyInMonth> revenues = ThongKeHelper.GetRevenueInMonths(2020);
            List<MoneyInMonth> salaries = ThongKeHelper.GetSalaryInMonths(2020);
            List<MoneyInMonth> importCosts = ThongKeHelper.GetImportCostInMonth(2020);
            List<MoneyInMonth> soldMoney = ThongKeHelper.GetMoneyInMonth(2020);
            foreach (var item in revenues)
            {
                chartThongKeDoanhThu.Series["Lợi Nhuận Trong Tháng"].Points.AddXY("Tháng " + item.Month.ToString(), item.Money);
            }

            foreach (var item in salaries)
            {
                chartThongKeDoanhThu.Series["Lương Nhân Viên"].Points.AddXY("Tháng " + item.Month.ToString(), item.Money);
            }

            foreach (var item in importCosts)
            {
                chartThongKeDoanhThu.Series["Nhập Kho"].Points.AddXY("Tháng " + item.Month.ToString(), item.Money);
            }
            foreach (var item in soldMoney)
            {
                chartThongKeDoanhThu.Series["Bán ra"].Points.AddXY("Tháng " + item.Month.ToString(), item.Money);
            }
        }

        private void ButtonNhapHang_Click(object sender, EventArgs e)
        {
            NhapHang nhapHang = new NhapHang();
            nhapHang.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
