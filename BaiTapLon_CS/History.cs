using BaiTapLon_CS.DAO;
using GemBox.Spreadsheet;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class History : Form
    {
        private int pageSize = 7;
        private int page;
        private int pageMax;
        public void DisplayListView(string query)
        {
            dgvHistory.DataSource = DataProvider.Instance.DisplayListView(query);
            if (dgvHistory.DataSource != null)
            {
                dgvHistory.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHistory.Columns[1].HeaderText = "Họ tên";
                dgvHistory.Columns[2].HeaderText = "Mã thuốc";
                dgvHistory.Columns[3].HeaderText = "Tên thuốc";
                dgvHistory.Columns[4].HeaderText = "Ngày bán";
                dgvHistory.Columns[5].HeaderText = "Giá";
                dgvHistory.Columns[6].HeaderText = "Số lượng";
                dgvHistory.Columns[7].HeaderText = "Thành tiền";
                dgvHistory.Columns[5].DefaultCellStyle.Format = "n0";
                dgvHistory.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
                dgvHistory.Columns[7].DefaultCellStyle.Format = "n0";
                dgvHistory.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
                    
            }
        }
        public History()
        {
            InitializeComponent();
            page = 1;
            string query = "ALTER PROC count_history " +
                    "AS BEGIN " +
                    "SELECT inv.ID_Invoice,cu.Name_Customer,me.ID_Medicine,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost * inde.Amount " +
                    "FROM Customer as cu,dbo.Medicine AS me,Invoice as inv, Invoice_Detail as inde " +
                    "where me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice= inv.ID_Invoice AND cu.ID_Customer= inv.ID_Customer and inv.ID_Manager =" + Form1.ID_Manager + " END";
               DataProvider.Instance.Add(query);
               string qqq = "EXEC count_history";
               DisplayListView(qqq);
               int total = this.dgvHistory.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[7].Value));
            CultureInfo culture = new CultureInfo("en-US");
            txtTotal.Text = String.Format(culture, "{0:N0}", decimal.Parse(total.ToString(), NumberStyles.AllowThousands));
            txtOrder.Text = HistoryDAO.Instance.getCountOrder();
            txtAmount_Product.Text = this.dgvHistory.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[6].Value)).ToString();
            query = "ALTER PROC history @pageNumber INT,@pageSize INT " +
                       "AS BEGIN " +
                       "DECLARE @startRow INT " +
                       "DECLARE @endRow INT " +
                       "SET @startRow = ((@pageNumber - 1) * @pageSize) + 1 " +
                       "SET @endRow = (@pageNumber * @pageSize) " +
                       "SELECT * FROM (SELECT inv.ID_Invoice,cu.Name_Customer,me.ID_Medicine,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost * inde.Amount AS N'Tổng', ROW_NUMBER() OVER (ORDER BY inv.ID_Invoice DESC) AS RowNumber   FROM Customer as cu,dbo.Medicine AS me,Invoice as inv, Invoice_Detail as inde " +
                       "where me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice= inv.ID_Invoice AND cu.ID_Customer= inv.ID_Customer and inv.ID_Manager=" + Form1.ID_Manager + ") AS temp WHERE temp.RowNumber BETWEEN @startRow AND @endRow END";
            DataProvider.Instance.Add(query);
            string qq= "EXEC history @pageNumber = " + page + ", @pageSize = " + pageSize;
            DisplayListView(qq);
               dgvHistory.Columns[8].Visible = false;

               pageMax = int.Parse(HistoryDAO.Instance.getCount_Order_Detail());
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
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string query = "SELECT inv.ID_Invoice,cu.Name_Customer,me.ID_Medicine,me.Name_Medicine,inv.Time_Of_Purchase,inde.Cost,inde.Amount,inde.Cost * inde.Amount FROM Customer as cu,dbo.Medicine AS me,Invoice as inv, Invoice_Detail as inde where me.ID_Medicine = inde.ID_Medicine AND inde.ID_Invoice= inv.ID_Invoice AND cu.ID_Customer= inv.ID_Customer and inv.ID_Manager =" + Form1.ID_Manager;
            DisplayListView(query);
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            ExcelFile myExcelFile = new ExcelFile();
            ExcelWorksheet excWsheet = myExcelFile.Worksheets.Add("Lịch sử");
            excWsheet.Cells[0, 0].Value = "THỐNG KÊ LỊCH SỬ BÁN HÀNG";
            excWsheet.Cells[0, 0].Style.Borders.SetBorders(MultipleBorders.Bottom, System.Drawing.Color.Red, LineStyle.Thin);
            excWsheet.Cells[0, 1].Style.Borders.SetBorders(MultipleBorders.Bottom, System.Drawing.Color.Red, LineStyle.Thin);
            for (int c = 0; c < dgvHistory.Columns.Count; c++)
            {
                excWsheet.Columns[c].Width = 25 * 256; //set the width to each column                
            }
            excWsheet.Rows[2].Cells[0].Value = "Mã hóa đơn";
            excWsheet.Rows[2].Cells[1].Value = "Khách hàng";
            excWsheet.Rows[2].Cells[2].Value = "Tên thuốc";
            excWsheet.Rows[2].Cells[3].Value = "Ngày bán";
            excWsheet.Rows[2].Cells[4].Value = "Đơn giá";
            excWsheet.Rows[2].Cells[5].Value = "Số lượng";
            excWsheet.Rows[2].Cells[6].Value = "Thành tiền";
            for (int i = 0; i < dgvHistory.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHistory.Columns.Count; j++)
                {
                    excWsheet.Rows[i + 3].Cells[j].Value = dgvHistory.Rows[i].Cells[j].Value;
                }
            }
            CellStyle style = new CellStyle(myExcelFile);
            style.HorizontalAlignment = HorizontalAlignmentStyle.Left;
            style.VerticalAlignment = VerticalAlignmentStyle.Center;
            style.Font.Color = Color.DarkRed;
            style.WrapText = true;
            style.Borders.SetBorders(MultipleBorders.Top | MultipleBorders.Left | MultipleBorders.Right | MultipleBorders.Bottom, System.Drawing.Color.Black, LineStyle.Thin);
            myExcelFile.Save("C:\\Users\\PC\\Documents\\History" + DateTime.Now + ".xls");
            MessageBox.Show("Xuất file thành công+ tại C:\\Users\\PC\\Documents\\History" + DateTime.Now + ".xls");
        }

        private void btnPre_Click_1(object sender, EventArgs e)
        {
               if (page >= 2)
               {
                    page -= 1;
                    string query = "EXEC history @pageNumber =" + page + ",@pageSize=" + pageSize;
                    DisplayListView(query);
                    btnCurrent.Text = page.ToString();
                    dgvHistory.Columns[8].Visible = false;
               }
          }

          private void btnNext_Click_1(object sender, EventArgs e)
          {
               if (page <= pageMax - 1)
               {
                    page += 1;
                    string query = "EXEC history @pageNumber =" + page + ",@pageSize=" + pageSize;
                    DisplayListView(query);
                    btnCurrent.Text = page.ToString();
                    dgvHistory.Columns[8].Visible = false;
               }
          }

          private void btnExcel_Click_1(object sender, EventArgs e)
          {

          }
     }
}