using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Helper;
using BaiTapLon_CS.Helper;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms
{
    public partial class ShowInvoiceDetail : Form
    {
        public Invoice invoice { get; set; }
        public ShowInvoiceDetail(Invoice invoice)
        {
            this.invoice = invoice;
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            textBoxMaNhap.Text = invoice.ID.ToString();
            textBoxTongTien.Text = ExtensionHelper.ChangeToCurrency(invoice.Cost.ToString());
            textBoxNguoiMua.Text = invoice.NameCustomer;
            textBoxNguoiBan.Text = invoice.NameManager;
            TextBoxNgayNhap.Text = invoice.Time_Of_Purchase.Day.ToString();
            TextBoxThangNhap.Text = invoice.Time_Of_Purchase.Month.ToString();
            TextBoxNamNhap.Text = invoice.Time_Of_Purchase.Year.ToString();
            // initialize the width of columns
            foreach (ColumnHeader column in listViewDetail.Columns)
            {
                column.Width = -2;
            }
            //listViewDetail.Columns[listViewDetail.Columns.Count - 1].Width = 0;
            /////

            List<MedicineInvoiceDetail> details = InvoiceHelper.FindMedicineInvoiceDetails(invoice.ID);
            int i = 0;
            foreach (var item in details)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Name_Medicine ,
                    item.Amount.ToString() ,
                    ExtensionHelper.ChangeToCurrency(item.Cost.ToString())});
                listViewDetail.Items.Add(listViewItem);
                i++;
            }

        }

    }
}
