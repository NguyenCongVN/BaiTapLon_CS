using BaiTapLon_CS.Class;
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
                    item.Cost.ToString() ,
                    item.Detail ,
                    item.DayCost.ToString()});
                listViewChiTieu.Items.Add(listViewItem);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
