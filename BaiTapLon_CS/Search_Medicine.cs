﻿using System;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class Search_Medicine : Form
    {
        public delegate void sendData(string a, string b);
        public sendData sender;
        public void DisplayListView(string query)
        {
            dgvSearchMedicine.DataSource = DAO.Search_MedicineDAO.Instance.DisplayListView(query);
            if (dgvSearchMedicine.DataSource != null)
            {
                dgvSearchMedicine.Columns[0].HeaderText = "Mã thuốc";
                dgvSearchMedicine.Columns[1].HeaderText = "Tên thuốc";
                dgvSearchMedicine.Columns[2].Visible = false;
                dgvSearchMedicine.Columns[3].HeaderText = "Xuất xứ";
                dgvSearchMedicine.Columns[4].HeaderText = "Đóng gói";
                dgvSearchMedicine.Columns[5].HeaderText = "Đơn vị";
                dgvSearchMedicine.Columns[6].HeaderText = "Số đăng ký";
            }
        }
        public Search_Medicine(sendData _sendData)
        {
            InitializeComponent();

            this.sender = _sendData;
            string query = "SELECT * FROM Medicine";
            DisplayListView(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSearchMedicine.DataSource = null;
            if (cBtype.SelectedIndex == 0)
            {
                string query = "SELECT * FROM Medicine WHERE ID_Medicine=" + txtSearch.Text;
                DisplayListView(query);
            }
            else if (cBtype.SelectedIndex == 1)
            {
                string query = "SELECT * FROM Medicine WHERE  Name_Medicine LIKE " + "N'%" + txtSearch.Text + "%'";
                DisplayListView(query);
            }
        }

        private void dgvSearchMedicine_MouseClick(object sender, MouseEventArgs e)
        {
            int row = dgvSearchMedicine.CurrentCell.RowIndex;
            var ID_Medicine = dgvSearchMedicine.Rows[row].Cells[0].Value.ToString();
            var Name_Medicine = dgvSearchMedicine.Rows[row].Cells[1].Value.ToString();
            this.sender(ID_Medicine, Name_Medicine);
            this.Hide();

        }

        private void dgvSearchMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
