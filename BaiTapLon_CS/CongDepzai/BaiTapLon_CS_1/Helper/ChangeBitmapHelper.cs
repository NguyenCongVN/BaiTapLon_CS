using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLon_CS.Helper
{
    public class ChangeBitmapHelper
    {
        public static Bitmap ChangeBitMap(PictureBox pictureBox, string path)
        {
            Bitmap bitmap = new Bitmap(path);
            Bitmap bitmap1 = new Bitmap(bitmap, new Size(pictureBox.Width, pictureBox.Height));
            return bitmap1;
        }

    }
}
