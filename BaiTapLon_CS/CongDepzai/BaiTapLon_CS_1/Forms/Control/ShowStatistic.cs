using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using BaiTapLon_CS.Helper;
using BaiTapLon_CS.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms.Control
{
    public partial class ShowStatistic : UserControl
    {
        public Top1Statistic instance;
        public string ColumnHeader0 { get; set; }
        public string ColumnHeader1 { get; set; }
        public string ColumnHeader2 { get; set; }
        public string ColumnHeader3 { get; set; }
        public void SetColumnHeader(string col1, string col2, string col3, string col4)
        {
            listViewGeneral.Columns[0].Text = col1;
            listViewGeneral.Columns[1].Text = col2;
            listViewGeneral.Columns[2].Text = col3;
            listViewGeneral.Columns[3].Text = col4;
        }

        public ShowStatistic()
        {
            InitializeComponent();
            listViewGeneral.Visible = false;
            ColumnHeader0 = "STT";
            ColumnHeader1 = "Tên";
            ColumnHeader2 = "Đơn hàng đã bán";
            ColumnHeader3 = "Số tiền đã bán";
            SetColumnHeader(ColumnHeader0, ColumnHeader1, ColumnHeader2, ColumnHeader3);
            //foreach (ColumnHeader column in listViewGeneral.Columns)
            //{
            //    column.Width = -2;
            //}
            string query = "exec GetTop1Statistic";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    instance = new Top1Statistic
                    {
                        CustomerName = dataTable.Rows[0].Field<string>("Ten khach hang"),
                        CustomerPhone = dataTable.Rows[0].Field<string>("So dien thoai"),
                        ID_Manager = dataTable.Rows[0].Field<int>("ID_Manager"),
                        ID_Medicine = dataTable.Rows[0].Field<int>("ID_Medicine"),
                        ImageMedicine = dataTable.Rows[0].Field<string>("Image_Medicine"),
                        NameMedicine = dataTable.Rows[0].Field<string>("Name_Medicine"),
                        Name_Manager = dataTable.Rows[0].Field<string>("Name_Manager"),
                        NumberInvoiceOfCustomer = dataTable.Rows[0].Field<int>("Tong so don hang"),
                        Salary = dataTable.Rows[0].Field<decimal>("Luong"),
                        TotalCost = dataTable.Rows[0].Field<decimal>("Tong so tien mua"),
                        TotalInvoiceSold = dataTable.Rows[0].Field<int>("Total invoice"),
                        TotalMedicineBought = dataTable.Rows[0].Field<int>("Tong so hang da mua"),
                        TotalMedicineSold = dataTable.Rows[0].Field<int>("Tong so hang ban"),
                        TotalMoneySold = dataTable.Rows[0].Field<decimal>("Tong so tien ban"),
                        TotalSold = dataTable.Rows[0].Field<int>("Tong so ban duoc"),
                        Image_Manager = dataTable.Rows[0].Field<string>("Image")
                    };
                }
            }
            if (instance.ImageMedicine != null)
            {
                try
                {
                    pictureBoxThuocBanChay.Image = ChangeBitmapHelper.ChangeBitMap(pictureBoxThuocBanChay, instance.ImageMedicine);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    pictureBoxThuocBanChay.Image = ChangeBitmapHelper.ChangeBitMapResource(pictureBoxThuocBanChay, Resources.icons8_pill_240px);
                }
                catch (Exception ex)
                {

                }
            }


            if (instance.Image_Manager != null)
            {
                try
                {
                    pictureBoxNhanVienXuatSac.Image = ChangeBitmapHelper.ChangeBitMap(pictureBoxNhanVienXuatSac, instance.Image_Manager);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    pictureBoxNhanVienXuatSac.Image = ChangeBitmapHelper.ChangeBitMapResource(pictureBoxNhanVienXuatSac, Resources.icons8_manager_100px);
                }
                catch (Exception ex)
                {

                }
            }
            pictureBoxKhachHangThanQuen.Image = ChangeBitmapHelper.ChangeBitMapResource(pictureBoxThuocBanChay, Resources.icons8_user_100px);


            labelKhachHangThanQuen.Text = instance.CustomerName;
            labelNhanVienXuatSac.Text = instance.Name_Manager;
            labelThuocBanChay.Text = instance.NameMedicine;
        }

        private void pictureBoxNhanVienXuatSac_Click_1(object sender, EventArgs e)
        {
            ColumnHeader0 = "STT";
            ColumnHeader1 = "Tên";
            ColumnHeader2 = "Đơn hàng đã bán";
            ColumnHeader3 = "Số tiền đã bán";
            SetColumnHeader(ColumnHeader0, ColumnHeader1, ColumnHeader2, ColumnHeader3);
            listViewGeneral.Columns[listViewGeneral.Columns.Count - 1].Width = 123;

            if (instance.Image_Manager != null)
            {
                try
                {
                    pictureBoxDetail.Image = ChangeBitmapHelper.ChangeBitMap(pictureBoxDetail, instance.Image_Manager);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {

                pictureBoxDetail.Image = ChangeBitmapHelper.ChangeBitMapResource(pictureBoxDetail, Resources.icons8_manager_100px);
            }
                catch (Exception ex)
            {

            }
        }

            labelTen.Text = "Họ Và Tên: " + instance.Name_Manager;
            labelSoDonHang.Text = "Số Đơn Hàng Bán: " + instance.TotalInvoiceSold.ToString();
            labelSoTienBan.Text = "Số Tiền Bán: " + ExtensionHelper.ChangeToCurrency(instance.TotalMoneySold.ToString()) + " VND";
            listViewGeneral.Visible = true;
            List<ManagerStatistic> managers = ThongKeHelper.GetManagerStatistic();
            int i = 0;
            listViewGeneral.Items.Clear();
            foreach (var item in managers)
            {
                i++;
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Name_Manager ,
                    item.TotalInvoice.ToString() ,
                    ExtensionHelper.ChangeToCurrency(item.TotalMoneySold.ToString())
                    });
                listViewGeneral.Items.Add(listViewItem);
            }
        }

        private void pictureBoxKhachHangThanQuen_Click(object sender, EventArgs e)
        {
            ColumnHeader0 = "STT";
            ColumnHeader1 = "Tên";
            ColumnHeader2 = "Đơn hàng đã Mua";
            ColumnHeader3 = "Số tiền đã Mua";
            SetColumnHeader(ColumnHeader0, ColumnHeader1, ColumnHeader2, ColumnHeader3);
            listViewGeneral.Columns[listViewGeneral.Columns.Count - 1].Width = 123;


            //pictureBoxDetail.Image = ChangeBitmapHelper.ChangeBitMap(pictureBoxDetail, instance.)
            labelTen.Text = "Họ Và Tên: " + instance.CustomerName;
            labelSoDonHang.Text = "Số Đơn Hàng Mua: " + instance.NumberInvoiceOfCustomer.ToString();
            labelSoTienBan.Text = "Số Tiền Mua: " + ExtensionHelper.ChangeToCurrency(instance.TotalCost.ToString()) + " VND";
            listViewGeneral.Visible = true;
            List<CustomerStatistic> customer = ThongKeHelper.GetCustomerStatistic();
            int i = 0;
            listViewGeneral.Items.Clear();
            foreach (var item in customer)
            {
                i++;
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Name_Customer ,
                    item.TotalInvoice.ToString() ,
                    ExtensionHelper.ChangeToCurrency(item.TotalMoney.ToString())
                    });
                listViewGeneral.Items.Add(listViewItem);
            }
            pictureBoxDetail.Image = ChangeBitmapHelper.ChangeBitMapResource(pictureBoxDetail, Resources.icons8_user_100px);
        }

        private void labelThuocBanChay_Click(object sender, EventArgs e)
        {
            ColumnHeader0 = "STT";
            ColumnHeader1 = "Tên Thuốc";
            ColumnHeader2 = "Số Đơn vị đã bán";
            ColumnHeader3 = "";
            SetColumnHeader(ColumnHeader0, ColumnHeader1, ColumnHeader2, ColumnHeader3);
            listViewGeneral.Columns[listViewGeneral.Columns.Count - 1].Width = 0;
            labelTen.Text = "Tên Thuốc: " + instance.NameMedicine;
            labelSoDonHang.Text = "Tổng số bán được: " + instance.TotalSold.ToString();
            labelSoTienBan.Text = "";
            if (instance.ImageMedicine != null)
            {
                pictureBoxDetail.Image = ChangeBitmapHelper.ChangeBitMap(pictureBoxDetail, instance.ImageMedicine);
            }
            else
            {
                pictureBoxDetail.Image = ChangeBitmapHelper.ChangeBitMapResource(pictureBoxDetail, Resources.icons8_pill_240px);
            }
            listViewGeneral.Visible = true;

            List<MedicineStatistic> medicines = ThongKeHelper.GetMedicineStatistic();
            int i = 0;
            listViewGeneral.Items.Clear();
            foreach (var item in medicines)
            {
                i++;
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Name_Medicine ,
                    item.TotalSold.ToString()
                    });
                listViewGeneral.Items.Add(listViewItem);
            }
        }
    }
}
