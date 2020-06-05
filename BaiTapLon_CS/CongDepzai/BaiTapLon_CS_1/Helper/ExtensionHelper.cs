using System;
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
    }
}
