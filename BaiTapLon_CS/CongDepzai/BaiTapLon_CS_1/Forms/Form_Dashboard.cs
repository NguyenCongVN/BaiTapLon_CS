using BaiTapLon_CS.Forms.Control;
using MedicineShopManagement.UserControls;
using System;
using System.Windows.Forms;

namespace MedicineShopManagement.Forms
{
    public partial class Form_Dashboard : Form
    {
        private int PanelWidth;
        private bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnShowMedicines);
            ShowMedicines us = new ShowMedicines();
            AddControlsToPanel(us);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnPurchase);
            UC_PurchaseDetails up = new UC_PurchaseDetails();
            AddControlsToPanel(up);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpense);
            UC_ManageExpense ea = new UC_ManageExpense();
            AddControlsToPanel(ea);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            Managers um = new Managers();
            AddControlsToPanel(um);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
            UC_ViewSales vs = new UC_ViewSales();
            AddControlsToPanel(vs);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //moveSidePanel(btnSettings);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
