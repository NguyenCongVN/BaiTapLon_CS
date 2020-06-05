using System;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void openFormInPanel(object FormChild)
        {
            // neu panelContain dang chua cai gi thi xoa di de hien thi form moi len
            if (this.pnControl.Controls.Count > 0)
            {
                this.pnControl.Controls.RemoveAt(0);
            }
            Form fc = FormChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.pnControl.Controls.Add(fc);
            this.pnControl.Tag = fc;
            fc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormInPanel(new Order());
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            openFormInPanel(new MedicineList());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
