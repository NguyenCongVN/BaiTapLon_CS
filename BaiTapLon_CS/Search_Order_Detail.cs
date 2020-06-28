using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
     public partial class Search_Order_Detail : Form
     {
          public Search_Order_Detail()
          {
               InitializeComponent();
               Load_Detail_Invoice();
          }
          private void Load_Detail_Invoice()
          {
               string query = "EXEC searchOrderDetail @idManager=" + Form1.ID_Manager + ",@idInvoice= " + SearchOrder.idInvoice;

               bunifuDgv.DataSource = DAO.DataProvider.Instance.DisplayListView(query);
               if (bunifuDgv.DataSource != null)
               {
                    bunifuDgv.Columns[0].HeaderText = "Mã thuốc";
                    bunifuDgv.Columns[1].HeaderText = "Tên thuốc";
                    bunifuDgv.Columns[2].HeaderText = "Số lượng";
                    bunifuDgv.Columns[3].HeaderText = "Đơn giá";
                    bunifuDgv.Columns[4].HeaderText = "Thành tiền";
                    bunifuDgv.Columns[3].DefaultCellStyle.Format = "n0";
                    bunifuDgv.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
                    bunifuDgv.Columns[4].DefaultCellStyle.Format = "n0";
                    bunifuDgv.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vn-Vn");
               }
          }

        private void bunifuDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
