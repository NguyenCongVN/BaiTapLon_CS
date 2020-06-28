using BaiTapLon_CS.DAO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class MedicineList : Form
    {
        private int pageSize = 7;
        private int page;
        private int pageMax;
        private bool isList = false;
        private bool isSearch = false;
        private string Subquery = "";
        private string searchQuery = "";
        public static int ID_Medicine;
        public static string Name_Medicine;
        public static string Image_Medicine;

        private void Medicine_List(string query)
        {
            dgwMedicineList.DataSource = DataProvider.Instance.DisplayListView(query);
            if (dgwMedicineList.DataSource != null)
            {
                dgwMedicineList.Columns[0].HeaderText = "Mã thuốc";
                dgwMedicineList.Columns[1].HeaderText = "Tên thuốc";
                dgwMedicineList.Columns[2].Visible = false;
                dgwMedicineList.Columns[3].HeaderText = "Xuất xứ";
                dgwMedicineList.Columns[4].HeaderText = "Đóng gói";
                dgwMedicineList.Columns[5].HeaderText = "Đơn vị";
                dgwMedicineList.Columns[6].HeaderText = "Giá bán";
                dgwMedicineList.Columns[7].HeaderText = "Số đăng ký";
                dgwMedicineList.Columns[6].DefaultCellStyle.Format = "n0";
                dgwMedicineList.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
                dgwMedicineList.Columns[8].Visible = false;
               }
            else
               {
                    MessageBox.Show("Không có dữ liệu");
               }
        }
        private void LoadMedicineList(string query)
        {
            Medicine_List(query);
            btnCurrent.ButtonText = page.ToString();
            pageMax = int.Parse(MedicineListDAO.Instance.getCountMedicine());
            totalResult.Text = "Có " + pageMax + " dữ liệu";
            if (pageMax % pageSize == 0)
            {
                pageMax = pageMax / pageSize;
            }
            else
            {
                pageMax = (pageMax / pageSize) + 1;
            }
            btnTotalPage.ButtonText = "of " + pageMax.ToString();
        }
        public MedicineList()
        {
            isList = true;
            isSearch = false;
            page = 1;
            InitializeComponent();
            string query ="EXEC dbo.spGetProduct @pageNumber ="+page+",@pageSize ="+pageSize;
            LoadMedicineList(query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                 isSearch = true;
                 isList = false;
                 dgwMedicineList.DataSource = null;
                 Subquery = "";
                 bool isIndex = true;
                 bool isEnter = false;
            if (txtID_Medicine.Text != "")
            {
                    isEnter = true;
                if (isIndex == true)
                {
                    Subquery += " me.ID_Medicine = " + txtID_Medicine.Text;
                    isIndex = false;
                }
                else
                {
                    Subquery += " and me.ID_Medicine = " + txtID_Medicine.Text;
                }
            }
            else
               {
                    Subquery += " me.ID_Medicine is not null ";
               }
            if (txtName_Medicine.Text != "")
            {
                    isEnter = true;
                if (isIndex == true)
                {
                    Subquery += " and LOWER(me.Name_Medicine) LIKE N'%" + txtName_Medicine.Text.ToLower() + "%'";
                    isIndex = false;
                }
                else
                {
                    Subquery += " and LOWER(me.Name_Medicine) LIKE N'%" + txtName_Medicine.Text.ToLower() + "%'";
                }

            }else
               {
                    Subquery += " and me.Name_Medicine is not null";
               }
            if (cBoxCategoty.SelectedIndex != 0 && cBoxCategoty.SelectedIndex != -1)
            {
                    isEnter = true;
                if (isIndex == true)
                {
                    Subquery += " and ca.Name_Category = N'" + cBoxCategoty.Text + "'";
                    isIndex = false;
                }
                else
                {
                    Subquery += " and ca.Name_Category =N'" + cBoxCategoty.Text + "'"; ;
                }
            }
            else
               {
                    Subquery += " and ca.Name_Category is not null";
               }
            if (cBoxManufacturer.SelectedIndex != 0 && cBoxManufacturer.SelectedIndex != -1)
            {
                    isEnter = true;
                if (isIndex == true)
                {
                    Subquery += " and manu.Name_Manufacturer = N'" + cBoxManufacturer.Text + "'";
                    isIndex = false;
                }
                else
                {
                    Subquery += " and manu.Name_Manufacturer = N'" + cBoxManufacturer.Text + "'";
                }
            }
            else
               {
                    Subquery += " and manu.Name_Manufacturer is not null";
               }
            if (isEnter == false)
            {
                MessageBox.Show("Bạn chưa có nhập thông tin tìm kiếm gì hết nhé");
                btnCurrent.ButtonText = "0";
                btnTotalPage.ButtonText = "of 0";
            }
            else
            {
                page = 1;
                string qu = "ALTER PROC count_Search_Medicine AS BEGIN SELECT COUNT(*) FROM Medicine as me,Category_Detail as cade,Category as Ca,Manufacturer as manu,Manufacturer_Detail as made where " + Subquery + " and me.ID_Medicine = cade.ID_Medicine and ca.ID_Category = cade.ID_Category and made.ID_Category = ca.ID_Category and manu.ID_Manufacturer = made.ID_Manufacturer END";
                DataProvider.Instance.Add(qu);
                string que = "EXEC count_Search_Medicine";
                pageMax = int.Parse(MedicineListDAO.Instance.getCountSearch(que));
                if (pageMax % pageSize == 0)
                {
                    pageMax = pageMax / pageSize;
                }
                else
                {
                    pageMax = (pageMax / pageSize) + 1;
                }
                btnCurrent.ButtonText = page.ToString();
                btnTotalPage.ButtonText = "of " + pageMax.ToString();
                searchQuery = "ALTER PROC searchMedicine @pageNumber INT,@pageSize INT AS BEGIN DECLARE @startRow INT DECLARE @endRow INT SET @startRow = ((@pageNumber - 1) * @pageSize) + 1 SET @endRow = (@pageNumber * @pageSize) SELECT * FROM ( SELECT me.ID_Medicine,me.Name_Medicine,me.Image_Medicine,me.Source,me.Packing,me.Unit,me.Cost,me.Registration_Number, ROW_NUMBER() OVER (ORDER BY me.ID_Medicine ASC) AS RowNumber " +
                         " FROM Medicine as me,Category_Detail as cade,Category as Ca,Manufacturer as manu,Manufacturer_Detail as made where " + Subquery + " and me.ID_Medicine = cade.ID_Medicine and ca.ID_Category = cade.ID_Category" +
                         " and made.ID_Category = ca.ID_Category and manu.ID_Manufacturer = made.ID_Manufacturer)AS temp WHERE temp.RowNumber BETWEEN @startRow AND @endRow END";
                    DataProvider.Instance.Add(searchQuery);
                    string quee = "EXEC dbo.searchMedicine @pageNumber =1,@pageSize ="+pageSize;
                    Medicine_List(quee);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
               isList = true;
               isSearch = false;
               page = 1;
            string query ="EXEC dbo.spGetProduct @pageNumber = "+page+", @pageSize = "+pageSize;
               Medicine_List(query);
            btnCurrent.ButtonText = page.ToString();
            pageMax = int.Parse(MedicineListDAO.Instance.getCountMedicine());
            if (pageMax % pageSize == 0)
            {
                pageMax = pageMax / pageSize;
            }
            else
            {
                pageMax = (pageMax / pageSize) + 1;
            }
            btnTotalPage.ButtonText = "of " + pageMax.ToString();
        }
        private void dgwMedicineList_MouseClick(object sender, MouseEventArgs e)
        {
            int row = dgwMedicineList.CurrentCell.RowIndex;
            ID_Medicine = int.Parse(dgwMedicineList.Rows[row].Cells[0].Value.ToString());
            Name_Medicine = dgwMedicineList.Rows[row].Cells[1].Value.ToString();
            Image_Medicine = dgwMedicineList.Rows[row].Cells[2].Value.ToString();
            Medicine_Detail mede = new Medicine_Detail();
            mede.Show();
        }
        private void txtID_Medicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnPre_Click_1(object sender, EventArgs e)
        {
               if (isList)
               {
                    if (page >= 2)
                    {
                         page -= 1;
                         string query = "EXEC dbo.spGetProduct @pageNumber =" + page + ",@pageSize =" + pageSize;
                         Medicine_List(query);
                         btnCurrent.ButtonText = page.ToString();
                    }
               }
               else if (isSearch)
               {
                    if (page >= 2)
                    {
                         page -= 1;
                         searchQuery = "EXEC dbo.searchMedicine @pageNumber =" + page + ",@pageSize =" + pageSize;
                         Medicine_List(searchQuery);
                         btnCurrent.ButtonText = page.ToString();
                    }
               }
          }

          private void btnNext_Click_1(object sender, EventArgs e)
          {
               if (isList)
               {
                    if (page <= pageMax - 1)
                    {
                         page += 1;
                         string query = "EXEC dbo.spGetProduct @pageNumber =" + page + ",@pageSize =" + pageSize;
                         Medicine_List(query);
                         btnCurrent.ButtonText = page.ToString();
                    }
               }
               else if (isSearch)
               {
                    if (page <= pageMax - 1)
                    {
                         page += 1;
                         searchQuery = "EXEC dbo.searchMedicine @pageNumber =" + page + ",@pageSize =" + pageSize;
                         Medicine_List(searchQuery);
                         btnCurrent.ButtonText = page.ToString();
                    }
               }

          }
     }
}
