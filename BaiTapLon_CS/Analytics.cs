using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
     public partial class Analytics : Form
     {
          int page;
          int pageSize = 5;
          int pageMax;

          bool isAnalytic = false;
          bool today = false;
          bool month = false;


          string Subquery = "";
         
          void LoadAnalytics(string query)
          {
               dgvAnalytics.DataSource = DAO.DataProvider.Instance.DisplayListView(query);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
               page = 1;
               isAnalytic = true;
               today = false;
               month = false;
               Subquery ="";
               dgvAnalytics.DataSource = null;
               
               
               var isIndex = true;
               if (txtNameManufacturer.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "cat.Name_Category LIKE N'%" + txtNameManufacturer.Text;
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and cat.Name_Category LIKE N'%" + txtNameManufacturer.Text;
                    }
               }
               if (txtNameProduct.Text != "")
               {
                    if (isIndex == true)
                    {
                         Subquery += "me.Name_Medicine LIKE N'%" + txtNameProduct.Text + "%'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and me.Name_Medicine LIKE N'%" + txtNameProduct.Text + "%'";
                    }

               }
               var aDate = new DateTime(2020, 1, 1, 0, 0, 0);
               if (dateTimeTo.Value != aDate)
               {
                    if (isIndex == true)
                    {
                         Subquery += "inde.Time_Of_Purchase <= '" + dateTimeTo.Value+"'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and inde.Time_Of_Purchase <='" + dateTimeTo.Value+"'";
                    }
               }
               if(dateTimeFrom.Value <= dateTimeTo.Value)
               {
                    if (isIndex == true)
                    {
                         Subquery += "inde.Time_Of_Purchase >= '" + dateTimeFrom.Value+"'";
                         isIndex = false;
                    }
                    else
                    {
                         Subquery += " and inde.Time_Of_Purchase >= '" + dateTimeFrom.Value+"'";
                    }
               }


               if (Subquery != "")
               {
                    string query = "SELECT COUNT(*) FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;

                    pageMax = int.Parse(DAO.AnalyticsDAO.Instance.getCountInvoice(query));
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


                    query = "SELECT inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;
                    LoadAnalytics(query);

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

                    query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager +
                              " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;
                    
                    
                    LoadAnalytics(query);

                    
                    
               }
               else
               {
                    MessageBox.Show("Bạn cần nhập dữ liệu tìm kiếm");
               }

          }

          private void btnToday_Click(object sender, EventArgs e)
          {
               isAnalytic = false;
               today = true;
               month = false;
               Subquery = "";
               page = 1;
               btnPre.Enabled = false;
               btnNext.Enabled = true;
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
               var query = "SELECT inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
               LoadAnalytics(query);
               CultureInfo culture = new CultureInfo("en-US");
               decimal val = decimal.Parse(this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value)).ToString(), NumberStyles.AllowThousands);

               txtTotal.Text = String.Format(culture, "{0:N0}", val);
               if (dgvAnalytics.Rows.Count != 0)
               {
                    txtAmount.Text = (dgvAnalytics.Rows.Count - 1).ToString();
                    txtAmount_Product.Text = this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
                    dgvAnalytics.DataSource = null;
                    query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                         "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                         ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +

                         " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                         "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                         ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                    LoadAnalytics(query);
               }
               else
               {
                    txtAmount.Text = "0";
                    txtAmount_Product.Text = "0";
                    txtTotal.Text = "0";
               }
              
          }

          private void btnWeek_Click(object sender, EventArgs e)
          {
               isAnalytic = false;
               today = false;
               month = true;
               page = 1;
               btnPre.Enabled = false;
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

               dgvAnalytics.DataSource = null;
               var query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +
                    " EXCEPT SELECT TOP(" + pageSize * (page-1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;

               LoadAnalytics(query);

               CultureInfo culture = new CultureInfo("en-US");
               decimal val = decimal.Parse(this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value)).ToString(), NumberStyles.AllowThousands);

               txtTotal.Text = String.Format(culture, "{0:N0}", val);

               int total = this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));


               if (dgvAnalytics.Rows.Count != 0)
               {
                    txtAmount.Text = (dgvAnalytics.Rows.Count - 1).ToString();
               }
               else
               {
                    txtAmount.Text = "0";
               }
               txtAmount_Product.Text = this.dgvAnalytics.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value)).ToString();
          }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
          {
               if (isAnalytic == true)
               {
                    if (page > 2)
                    {
                         page -= 1;
                         btnNext.Enabled = true;
                         string query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager +
                                   " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnPre.Enabled = true;
                         btnCurrent.Text = page.ToString();
                    }
                    else if (page == 2)
                    {
                         page -= 1;
                         btnPre.Enabled = false;
                         btnNext.Enabled = true;
                         string query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager +
                                   " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnCurrent.Text = page.ToString();
                    }
               }  
               else if (today == true)
               {
                    if (page > 2)
                    {
                         page -= 1;
                         btnNext.Enabled = true;
                         string query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +

                     " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnPre.Enabled = true;
                         btnCurrent.Text = page.ToString();
                    }
                    else if (page == 2)
                    {
                         page -= 1;
                         btnPre.Enabled = false;
                         btnNext.Enabled = true;
                         string query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                         "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                         ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +

                         " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                         "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                         ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnCurrent.Text = page.ToString();
                    }
               }
               else if(month==true)
               {
                    if (page > 2)
                    {
                         page -= 1;
                         btnNext.Enabled = true;
                         var query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +
                     " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnPre.Enabled = true;
                         btnCurrent.Text = page.ToString();
                    }
                    else if (page == 2)
                    {
                         page -= 1;
                         btnPre.Enabled = false;
                         btnNext.Enabled = true;
                         var query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +
                     " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnCurrent.Text = page.ToString();
                    }
               }
          }
          private void btnNext_Click(object sender, EventArgs e)
          {
               if (isAnalytic == true)
               {
                    if (page < pageMax - 1)
                    {
                         page += 1;
                         string query = "SELECT TOP(" + pageSize*page + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager +
                              " EXCEPT SELECT TOP(" + pageSize*(page-1) + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnPre.Enabled = true;
                         btnNext.Enabled = true;
                         btnCurrent.Text = page.ToString();
                    }
                    else
                    {
                         page += 1;
                         btnNext.Enabled = false;
                         btnPre.Enabled = true;
                         string query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager +
                               " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inde.Time_Of_Purchase,inv.Cost,inv.Amount,inv.Cost*inv.Amount FROM dbo.Medicine AS me,dbo.Category AS cat ,dbo.Invoice_Detail AS inv,dbo.Invoice as inde,dbo.Category_Detail AS cade WHERE inv.ID_Medicine = me.ID_Medicine AND cat.ID_Category = cade.ID_Category AND me.ID_Medicine = cade.ID_Medicine and inde.ID_Invoice = inv.ID_Invoice and " + Subquery + " and inde.ID_Manager = " + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnCurrent.Text = page.ToString();
                    }
               }
               else if (today == true)
               {
                    if (page < pageMax - 1)
                    {
                         page += 1;
                         string query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +

                    " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnPre.Enabled = true;
                         btnNext.Enabled = true;
                         btnCurrent.Text = page.ToString();
                    }
                    else
                    {
                         page += 1;
                         btnNext.Enabled = false;
                         btnPre.Enabled = true;
                         var query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +

                    " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND DAY(inv.Time_Of_Purchase) = DAY(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnCurrent.Text = page.ToString();
                    }
               }
               else if(month)
               {
                    if (page < pageMax - 1)
                    {
                         page += 1;
                         var query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +
                     " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                     "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                     ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnPre.Enabled = true;
                         btnNext.Enabled = true;
                         btnCurrent.Text = page.ToString();
                    }
                    else
                    {
                         page += 1;
                         btnNext.Enabled = false;
                         btnPre.Enabled = true;
                         var query = "SELECT TOP(" + pageSize * page + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager +
                    " EXCEPT SELECT TOP(" + pageSize * (page - 1) + ") inv.ID_Invoice,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost*inde.Amount FROM dbo.Medicine AS me,dbo.Invoice AS inv, dbo.Invoice_Detail AS inde " +
                    "WHERE me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice = inv.ID_Invoice AND MONTH(inv.Time_Of_Purchase) = MONTH(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                    ") AND YEAR(inv.Time_Of_Purchase) = YEAR(" + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" + ") and inv.ID_Manager =" + Form1.ID_Manager;
                         LoadAnalytics(query);
                         btnCurrent.Text = page.ToString();
                    }
               }
          }

        private void dgvAnalytics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
