using BaiTapLon_CS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class Analytics : Form
    {
        private int page;
        private int pageSize = 6;
        private int pageMax;
        private bool isAnalytic = false;
        private bool today = false;
        private bool month = false;
        private bool isEnter = false;
        private string Subquery = "";
        private void LoadAnalytics(string query)
        {
            dgvAnalytics.DataSource = null;
            dgvAnalytics.DataSource = DataProvider.Instance.DisplayListView(query);
            if (dgvAnalytics.DataSource != null)
            {
                dgvAnalytics.Columns[0].HeaderText = "Mã hóa đơn";
                dgvAnalytics.Columns[1].HeaderText = "Tên thuốc";
                dgvAnalytics.Columns[2].HeaderText = "Ngày bán";
                dgvAnalytics.Columns[3].HeaderText = "Giá";
                dgvAnalytics.Columns[4].HeaderText = "Số lượng";
                dgvAnalytics.Columns[5].HeaderText = "Thành tiền";
                dgvAnalytics.Columns[5].DefaultCellStyle.Format = "n0";
                dgvAnalytics.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
                dgvAnalytics.Columns[3].DefaultCellStyle.Format = "n0";
                dgvAnalytics.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
            }

        }
        public Analytics()
        {
            InitializeComponent();
        }
        private void cboxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategory.Enabled = true;
            var idManufacturer = cboxManufacturer.SelectedIndex + 1;
            List<String> category = DAO.AnalyticsDAO.Instance.getCategoty(idManufacturer);
            cbCategory.Items.Clear();
            cbCategory.Text = "Lựa chọn";
            foreach (var i in category)
            {
                cbCategory.Items.Add(i);
            }
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
               if (isAnalytic == true)
               {
                    if (page >= 2)
                    {
                         page -= 1;
                         string query = "EXEC analyist @pageNumber=" + page + ",@pageSize=" + pageSize;
                         LoadAnalytics(query);
                         dgvAnalytics.Columns[6].Visible = false;
                         btnCurrent.Text = page.ToString();
                    }
                    
               }
               else if (today == true)
               {
                    if (page >= 2)
                    {
                         page -= 1;
                         string query = "EXEC today @pageNumber = " + page + ",@pageSize = " + pageSize;
                         LoadAnalytics(query);
                         dgvAnalytics.Columns[6].Visible = false;
                         btnCurrent.Text = page.ToString();
                    }
                   
               }
               else if (month == true)
               {
                    if (page >= 2)
                    {
                         page -= 1;
                       
                         var query ="EXEC analyist_month @pageNumber = " + page + ",@pageSize = " + pageSize;
                         LoadAnalytics(query);
                         dgvAnalytics.Columns[6].Visible = false;
                         btnCurrent.Text = page.ToString();
                    }
                    
               }
          }
        private void btnNext_Click_1(object sender, EventArgs e)
          {
               if (isAnalytic == true)
               {
                    if (page <= pageMax - 1)
                    {
                         page += 1;
                         string query = "EXEC analyist @pageNumber=" + page + ",@pageSize=" + pageSize;
                         LoadAnalytics(query);
                         dgvAnalytics.Columns[6].Visible = false;
                         btnCurrent.Text = page.ToString();
                    }
                   
               }
               else if (today == true)
               {
                    if (page <= pageMax - 1)
                    {
                         page += 1;
                         string query = "EXEC today @pageNumber = " + page + ",@pageSize = " + pageSize;
                         LoadAnalytics(query);
                         dgvAnalytics.Columns[6].Visible = false;
                         btnCurrent.Text = page.ToString();
                    }
               }
               else if (month)
               {
                    if (page <= pageMax - 1)
                    {
                         page += 1;
                         var query = "EXEC analyist_month @pageNumber = " + page + ",@pageSize = " + pageSize;
                         LoadAnalytics(query);
                         dgvAnalytics.Columns[6].Visible = false;
                         btnCurrent.Text = page.ToString();
                    }
               }
          }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
               isAnalytic = false;
               today = false;
               month = true;
               page = 1;
               pageMax = int.Parse(DAO.AnalyticsDAO.Instance.getCountMonth());
               if (pageMax % pageSize == 0)
               {
                    pageMax = pageMax / pageSize;
               }
               else
               {
                    pageMax = (pageMax / pageSize) + 1;
               }
               btnCurrent.Text = page.ToString();
               btnTotalPage.Text = "of " + pageMax.ToString();

               var query = "ALTER PROC count_month as begin SELECT inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                   "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                   ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + LoginDAO.ID_Manager + " END";
               DataProvider.Instance.Add(query);
               string q = "exec count_month";
               LoadAnalytics(q);
               CultureInfo culture = new CultureInfo("en-US");
               decimal val = decimal.Parse(this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value)).ToString(), NumberStyles.AllowThousands);
               txtTotal.Text = String.Format(culture, "{0:N0}", val);
               if (dgvAnalytics.Rows.Count != 0)
               {
                    txtAmount.Text = (dgvAnalytics.Rows.Count - 1).ToString();
                    txtAmount_Product.Text = this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
                    dgvAnalytics.DataSource = null;
                    var que = "ALTER PROC analyist_month @pageNumber INT,@pageSize INT " +
                              "AS BEGIN" +
                              " DECLARE @startRow INT " +
                              "DECLARE @endRow INT " +
                              "SET @startRow = ((@pageNumber - 1) * @pageSize) + 1 " +
                              "SET @endRow = (@pageNumber * @pageSize)  " +
                         "SELECT * FROM (SELECT inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount as N'Tổng',ROW_NUMBER() OVER (ORDER BY inde.ID_Invoice ASC) AS RowNumber FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                         "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                         ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + LoginDAO.ID_Manager + ")AS temp WHERE temp.RowNumber BETWEEN @startRow AND @endRow END";
                    DataProvider.Instance.Add(que);
                    string qq = "EXEC analyist_month @pageNumber = " + page + ",@pageSize = " + pageSize;
                    LoadAnalytics(qq);
                    dgvAnalytics.Columns[6].Visible = false;
               }
          }

        private void btnAnalytics_Click_1(object sender, EventArgs e)
        {
               page = 1;
               isAnalytic = true;
               today = false;
               month = false;
               Subquery = "";
               dgvAnalytics.DataSource = null;
               var isIndex = true;
               if (cboxManufacturer.SelectedIndex != -1)
               {
                    isEnter = true;
                    if (isIndex == true)
                    {
                         Subquery += " man.Name_Manufacturer = N'" + cboxManufacturer.Text + "'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and man.Name_Manufacturer = N'" + cboxManufacturer.Text + "'";
                    }
               }
               else
               {
                    Subquery += " man.Name_Manufacturer = man.Name_Manufacturer";
               }
               if (cbCategory.SelectedIndex != -1 && cbCategory.SelectedIndex != 0)
               {
                    isEnter = true;
                    if (isIndex == true)
                    {
                         Subquery += " and cat.Name_Category = N'" + cbCategory.Text + "'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and cat.Name_Category = N'" + cbCategory.Text + "'";
                    }
               }
               else
               {
                    Subquery += " and cat.Name_Category = cat.Name_Category";
               }
               if (txtNameProduct.Text != "")
               {
                    isEnter = true;
                    if (isIndex == true)
                    {
                         Subquery += " and me.Name_Medicine LIKE N'%" + txtNameProduct.Text + "%'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and me.Name_Medicine LIKE N'%" + txtNameProduct.Text + "%'";
                    }
               }
               else
               {
                    Subquery += " and me.Name_Medicine = me.Name_Medicine";
               }
               var aDate = new DateTime(2020, 1, 1, 0, 0, 0);
               if (dateTimeFrom.Value != aDate)
               {
                    isEnter = true;
                    if (isIndex == true)
                    {
                         Subquery += " and inde.Time_Of_Purchase <='" + dateTimeTo.Value + "'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and inde.Time_Of_Purchase <='" + dateTimeTo.Value + "'";
                    }
               }
               if (dateTimeFrom.Value <= dateTimeTo.Value)
               {
                    isEnter = true;
                    if (isIndex == true)
                    {
                         Subquery += " and inde.Time_Of_Purchase >= '" + dateTimeFrom.Value + "'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and inde.Time_Of_Purchase >= '" + dateTimeFrom.Value + "'";
                    }
               }
               if (isEnter)
               {
                   
                    string query = "ALTER PROC count_Analyist AS BEGIN SELECT COUNT(*) FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade,Manufacturer as man, Manufacturer_Detail as mande" +
                         " WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and man.ID_Manufacturer = mande.ID_Manufacturer and cat.ID_Category = mande.ID_Category and "
                         + Subquery + " and inde.ID_Manager = " + LoginDAO.ID_Manager + " END";
                    DataProvider.Instance.Add(query);
                    string qu = "Exec count_Analyist";
                    pageMax = int.Parse(AnalyticsDAO.Instance.getCountInvoice(qu));
                    if (pageMax % pageSize == 0)
                    {
                         pageMax = pageMax / pageSize;
                    }
                    else
                    {
                         pageMax = (pageMax / pageSize) + 1;
                    }
                    btnCurrent.Text = page.ToString();
                    btnTotalPage.Text = "of " + pageMax.ToString();
                    query = "ALTER PROC total_Analyist AS BEGIN SELECT inde.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade,Manufacturer as man, Manufacturer_Detail as mande" +
                         " WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and man.ID_Manufacturer = mande.ID_Manufacturer and cat.ID_Category = mande.ID_Category and " + Subquery + " and inde.ID_Manager = " + LoginDAO.ID_Manager + " END";
                    DataProvider.Instance.Add(query);
                    string q = "Exec total_Analyist";
                    LoadAnalytics(q);
                    CultureInfo culture = new CultureInfo("en-US");
                    decimal val = decimal.Parse(this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value)).ToString(), NumberStyles.AllowThousands);
                    txtTotal.Text = String.Format(culture, "{0:N0}", val);
                    if (dgvAnalytics.Rows.Count != 0)
                    {
                         txtAmount.Text = (dgvAnalytics.Rows.Count - 1).ToString();
                    }
                    else
                    {
                         txtAmount.Text = "0";
                    }
                    decimal value = decimal.Parse(this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString(), NumberStyles.AllowThousands);
                    txtAmount_Product.Text = String.Format(culture, "{0:N0}", value);
                    dgvAnalytics.DataSource = null;
                    query = "ALTER PROC analyist @pageNumber INT,@pageSize INT " +
                         "AS BEGIN" +
                         " DECLARE @startRow INT " +
                         "DECLARE @endRow INT " +
                         "SET @startRow = ((@pageNumber - 1) * @pageSize) + 1 " +
                         "SET @endRow = (@pageNumber * @pageSize)  " +
                         "SELECT * FROM ( SELECT inde.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost* inv.Amount as N'Tổng',ROW_NUMBER() OVER (ORDER BY inde.ID_Invoice ASC) AS RowNumber FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade,Manufacturer as man, Manufacturer_Detail as mande" +
                           " WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and man.ID_Manufacturer = mande.ID_Manufacturer and cat.ID_Category = mande.ID_Category and " + Subquery + " and inde.ID_Manager = " + LoginDAO.ID_Manager +
                           ")AS temp WHERE temp.RowNumber BETWEEN @startRow AND @endRow END";
                    DataProvider.Instance.Add(query);
                    q = "EXEC analyist @pageNumber=" + page + ",@pageSize=" + pageSize;
                    LoadAnalytics(q);
                    dgvAnalytics.Columns[6].Visible = false;
               }
               else
               {
                    txtAmount.Text = "0";
                    txtAmount_Product.Text = "0";
                    txtTotal.Text = "0";
                    MessageBox.Show("Bạn cần nhập dữ liệu tìm kiếm");
               }
          }

        private void Analytics_Load(object sender, EventArgs e)
        {

        }

        private void btnToday_Click_1(object sender, EventArgs e)
          {
               isAnalytic = false;
               today = true;
               month = false;
               Subquery = "";
               page = 1;
               btnCurrent.Text = page.ToString();

               pageMax = int.Parse(DAO.AnalyticsDAO.Instance.getCountToday());
               if (pageMax % pageSize == 0)
               {
                    pageMax = pageMax / pageSize;
               }
               else
               {
                    pageMax = (pageMax / pageSize) + 1;
               }
               btnTotalPage.Text = "of " + pageMax.ToString();
               var query = "ALTER PROC count_today as begin SELECT inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + LoginDAO.ID_Manager + " END";
               DataProvider.Instance.Add(query);
               string q = "exec count_today";
               LoadAnalytics(q);
               CultureInfo culture = new CultureInfo("en-US");
               decimal val = decimal.Parse(this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value)).ToString(), NumberStyles.AllowThousands);
               txtTotal.Text = String.Format(culture, "{0:N0}", val);
               if (dgvAnalytics.Rows.Count != 0)
               {
                    txtAmount.Text = (dgvAnalytics.Rows.Count - 1).ToString();
                    txtAmount_Product.Text = this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
                    dgvAnalytics.DataSource = null;
                    query = "ALTER PROC today @pageNumber INT,@pageSize INT " +
                         "AS BEGIN " +
                         " DECLARE @startRow INT " +
                         "DECLARE @endRow INT " +
                         "SET @startRow = ((@pageNumber - 1) * @pageSize) + 1 " +
                         "SET @endRow = (@pageNumber * @pageSize)  " +
                         "SELECT * FROM (SELECT inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount AS N'Tổng',ROW_NUMBER() OVER (ORDER BY inde.ID_Invoice ASC) AS RowNumber FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                         "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                         ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + LoginDAO.ID_Manager + ")AS temp WHERE temp.RowNumber BETWEEN @startRow AND @endRow END";
                    DataProvider.Instance.Add(query);
                    string qq = "EXEC today @pageNumber=" + page + ",@pageSize=" + pageSize;
                    LoadAnalytics(qq);
                    dgvAnalytics.Columns[6].Visible = false;
               }
               else
               {
                    txtAmount.Text = "0";
                    txtAmount_Product.Text = "0";
                    txtTotal.Text = "0";
               }
          }
     }
}
