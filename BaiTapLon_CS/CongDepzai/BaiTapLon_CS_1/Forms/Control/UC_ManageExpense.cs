using BaiTapLon_CS.Class;
using BaiTapLon_CS.Forms;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicineShopManagement.UserControls
{
    public partial class UC_ManageExpense : UserControl
    {
        public UC_ManageExpense()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            listViewChiTieu.Items.Clear();
            List<Expense> expenses = ThongKeHelper.GetExpenses();
            int i = 0;
            foreach (var item in expenses)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Type ,
                    ExtensionHelper.ChangeToCurrency(item.Cost.ToString()) ,
                    item.Detail ,
                    item.DayCost.ToString() , item.ID.ToString()});
                listViewChiTieu.Items.Add(listViewItem);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void listViewChiTieu_Click(object sender, EventArgs e)
        {
            int Id = -1;
            try
            {
                Id = int.Parse(listViewChiTieu.SelectedItems[0].SubItems[5].Text);
            }
            catch (Exception ex)
            {

            }
            if (Id != -1)
            {
                ShowTheImportHistoryForm historyForm = new ShowTheImportHistoryForm(Id);
                historyForm.ShowDialog();
            }
        }
    }
}
