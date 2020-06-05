using BaiTapLon_CS.Class;
using BaiTapLon_CS.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms.Control
{
    public partial class CategoryListBoxControl : UserControl
    {
        public CategoryListBoxControl(Medicine medicine)
        {
            InitializeComponent();
            List<Category> categories = MedicineHelper.GetCategoryOfTheMedicine(medicine.ID_Medicine);
            foreach (var item in categories)
            {
                if (item != null)
                {
                    checkListBox.Items.Add(item.NameCategory, CheckState.Checked);
                }
            }
            foreach (var item in MedicineHelper.GetAllCategory())
            {
                int check = 1;
                if (item != null)
                {
                    foreach (var x in categories)
                    {
                        if (x.CategoryID.CompareTo(item.CategoryID) == 0)
                        {
                            check = 0;
                            break;
                        }
                    }
                    if (check == 1)
                        checkListBox.Items.Add(item.NameCategory, CheckState.Unchecked);
                }
            }
        }

        private void buttonOpenListBox_Click(object sender, EventArgs e)
        {
            if (checkListBox.Size.Height < 104)
                checkListBox.SetBounds(checkListBox.Location.X, checkListBox.Location.Y
                    , checkListBox.Size.Width, checkListBox.Size.Height * 5);
            this.SetBounds(this.Location.X, this.Location.Y
               , this.Size.Width, checkListBox.Size.Height);
        }
    }
}
