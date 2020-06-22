using BaiTapLon_CS.DAO;
using System;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class SearchOrder : Form
    {
        private int pageSize = 4;
        private int page;
        private string Subquery = "";
        private int pageMax;
          private bool isEnter = false;

        private void searchMedicine_List_Search(string query)
        {
            bunifuDgv.DataSource = DataProvider.Instance.DisplayListView(query);
            if (bunifuDgv.DataSource != null)
            {
                bunifuDgv.Columns[0].Visible = false;
                    bunifuDgv.Columns[1].HeaderText = "Tên KH";
                bunifuDgv.Columns[2].HeaderText = "GT";
                 
                    bunifuDgv.Columns[3].HeaderText = "Địa chỉ";
               
                    bunifuDgv.Columns[4].HeaderText = "Tuổi";
               
                    bunifuDgv.Columns[5].HeaderText = "Số ĐT";
                
                    bunifuDgv.Columns[6].HeaderText = "Mã HĐ";
               
                    bunifuDgv.Columns[7].Visible = false;
                bunifuDgv.Columns[8].HeaderText = "Chuẩn đoán";
                bunifuDgv.Columns[9].HeaderText = "TG mua";
           
                    bunifuDgv.Columns[10].HeaderText = "Mã NV";
             
                    bunifuDgv.Columns[11].Visible = false;
            }
        }

        public SearchOrder()
        {
            InitializeComponent();
        }
        private void txtID_Medicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtID_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
               bunifuDgv.DataSource = null;
            Subquery = "";
            var isIndex = true;
            if (txtID_Invoice.Text != "")
            {
                    isEnter = true;
                if (isIndex == true)
                {
                    Subquery += " inv.ID_Invoice=" + txtID_Invoice.Text;
                    isIndex = false;
                }
                else
                {
                    Subquery += " and inv.ID_Invoice=" + txtID_Invoice.Text;
                }
            }
            else
               {
                    Subquery += " inv.ID_Invoice is not null";
               }
            if (txtName_Customer.Text != "")
            {
                    isEnter = true;
                    if (isIndex == true)
                {
                    Subquery += " and cu.Name_Customer LIKE N'%" + txtName_Customer.Text + "%'";
                    isIndex = false;
                }
                else
                {
                    Subquery += " and cu.Name_Customer LIKE N'%" + txtName_Customer.Text + "%'";
                }

            }
            else
               {
                    Subquery += " and cu.Name_Customer is not null";
               }
            if (txtPhone.Text != "")
            {
                    isEnter = true;
                    if (isIndex == true)
                {
                    Subquery += " and cu.Phone= N'" + txtPhone.Text+"'";
                    isIndex = false;
                }
                else
                {
                    Subquery += " and cu.Phone= N'" + txtPhone.Text+"'";

                }
            }
            else
               {
                    Subquery += " and cu.Phone = cu.Phone";
               }
            if (txtID_Customer.Text != "")
            {
                    isEnter = true;
                    if (isIndex == true)
                {
                    Subquery += " and cu.ID_Customer =" + txtID_Customer.Text;
                    isIndex = false;
                }
                else
                {
                    Subquery += " and cu.ID_Customer =" + txtID_Customer.Text;
                }
            }
            else
               {
                    Subquery += " and cu.ID_Customer = cu.ID_Customer";
               }
            var aDate = new DateTime(2020, 1, 1, 0, 0, 0);
            if (timeOrderSearch.Value != aDate)
            {
                    isEnter = true;
                    if (isIndex == true)
                {
                    Subquery += "YEAR(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Year + " and MONTH(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Month + " and DAY(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Day;
                    isIndex = false;
                }
                else
                {
                    Subquery += " and YEAR(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Year + " and MONTH(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Month + " and DAY(inv.Time_Of_Purchase)=" + timeOrderSearch.Value.Day;
                }
            }
               string query = "ALTER PROC searchInvoice @pageNumber INT,@pageSize INT AS BEGIN DECLARE @startRow INT DECLARE @endRow INT SET @startRow = ((@pageNumber - 1) * @pageSize) + 1 SET @endRow = (@pageNumber * @pageSize) " +
                    "SELECT * FROM (SELECT inv.Remind,cu.Name_Customer,cu.Sex,cu.Address,cu.Birthday,cu.Phone,inv.ID_Invoice,inv.ID_Customer,inv.Diagnostic,inv.Time_Of_Purchase,inv.ID_Manager,ROW_NUMBER() OVER (ORDER BY inv.ID_Invoice ASC) as RowNumber FROM Customer AS cu JOIN Invoice AS inv ON " + Subquery + " and cu.ID_Customer = inv.ID_Customer) as temp WHERE temp.RowNumber BETWEEN @startRow AND @endRow END";
               if (isEnter == false)
               {
                    MessageBox.Show("Bạn chưa nhập thông tin gì cả nhaaaaa");
               }
               else
               {
                    DataProvider.Instance.Add(query);
                    query = "EXEC dbo.searchInvoice @pageNumber = 1,@pageSize = "+pageSize;
                    searchMedicine_List_Search(query);
                    page = 1;
                    string q = "SELECT COUNT(*) FROM Customer AS cu JOIN Invoice AS inv ON " + Subquery + " and cu.ID_Customer = inv.ID_Customer";
                    pageMax = int.Parse(SearchOrderDAO.Instance.getCountMedicine(q));
                    totalResult.Text = "Có " + pageMax + " dữ liệu được tìm thấy";
                    if (pageMax == 0)
                    {
                         MessageBox.Show("Dữ liệu bạn tìm kiếm không có");
                    }
                    else
                    {
                         if (pageMax % pageSize == 0)
                         {
                              pageMax = pageMax / pageSize;
                         }
                         else
                         {
                              pageMax = (pageMax / pageSize) + 1;
                         }
                         btnTotalPage.Text = "of " + pageMax.ToString();
                         btnCurrent.Text = page.ToString();
                    }
               }
        }

          private void btnPre_Click(object sender, EventArgs e)
          {
               if (page >= 2)
               {
                    page -= 1;
                    string query = "EXEC dbo.searchInvoice @pageNumber =" + page + ",@pageSize=" + pageSize;
                    searchMedicine_List_Search(query);
                    btnCurrent.Text = page.ToString();
               }
          }

          private void btnNext_Click(object sender, EventArgs e)
          {
               if (page <= pageMax - 1)
               {
                    page += 1;
                    string query = "EXEC dbo.searchInvoice @pageNumber =" + page + ",@pageSize=" + pageSize;
                    searchMedicine_List_Search(query);
                    btnCurrent.Text = page.ToString();
               }
          }

          private void SearchOrder_Load(object sender, EventArgs e)
          {

          }
     }
}
