using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Forms;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicineShopManagement.UserControls
{
    public partial class UC_ViewSales : UserControl
    {
        public UC_ViewSales()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            // initialize the width of columns
            foreach (ColumnHeader column in listViewSale.Columns)
            {
                column.Width = -2;
            }
            listViewSale.Columns[listViewSale.Columns.Count - 2].Width = 0;
            /////
            listViewSale.Items.Clear();
            List<Invoice> invoices = InvoiceHelper.FindInvoices();
            int i = 0;
            foreach (var item in invoices)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.NameManager ,
                    item.NameCustomer ,
                    item.Cost.ToString() ,
                    item.ID.ToString(),
                item.Time_Of_Purchase.ToShortDateString()});
                listViewSale.Items.Add(listViewItem);
                i++;
            }
        }

        private void listViewSale_Click(object sender, System.EventArgs e)
        {
            int ID = -1;
            try
            {
                ID = int.Parse(listViewSale.SelectedItems[0].SubItems[4].Text);
                if(ID != -1)
                {
                    Invoice invoice = new Invoice
                    {
                        NameManager = listViewSale.SelectedItems[0].SubItems[1].Text,
                        NameCustomer = listViewSale.SelectedItems[0].SubItems[2].Text,
                        Cost = decimal.Parse(listViewSale.SelectedItems[0].SubItems[3].Text),
                        ID = int.Parse(listViewSale.SelectedItems[0].SubItems[4].Text),
                        Time_Of_Purchase = DateTime.Parse(listViewSale.SelectedItems[0].SubItems[5].Text)
                    };
                    ShowInvoiceDetail show = new ShowInvoiceDetail(invoice);
                    show.ShowDialog();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
