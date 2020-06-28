using System;
using System.Globalization;
using System.Windows.Forms;

namespace BaiTapLon_CS.Helper
{
    public class ExtensionHelper
    {
        public static string ChoosePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File |*.jfif;*.png | Select All | *";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                return path;
            }
            else
                return null;
        }

        public static string ChangeToCurrency(string total)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string Total = String.Format(culture, "{0:N0}", decimal.Parse(total.ToString(), NumberStyles.AllowThousands));
            return Total;
        }

        public static string ChangeToNormalDecimal(string currency)
        {
            return currency.Replace(",", "");
        }
    }
}
