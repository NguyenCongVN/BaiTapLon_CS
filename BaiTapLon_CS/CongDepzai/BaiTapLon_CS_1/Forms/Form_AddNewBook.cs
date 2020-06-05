using System;
using System.Windows.Forms;

namespace MedicineShopManagement.Forms
{
    public partial class Form_AddNewBook : Form
    {
        public Form_AddNewBook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory ac = new Form_AddCategory())
            {
                ac.ShowDialog();
            }
        }
    }
}
