using BaiTapLon_CS.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLon_CS
{
    public partial class Info : Form
    {
        private Bitmap bitmap1;
        private OpenFileDialog openFileDialog;
        public void getInfo()
        {
            DataTable dt = InfoDAO.Instance.getInfo();
            btnName.Text = dt.Rows[0][1].ToString();
            string image = dt.Rows[0][2].ToString();
            var n = dt.Rows[0][3].ToString();
            if (dt.Rows[0][3].ToString() == "True")
            {
                btnSex.SelectedIndex = 0;
            }
            else

            {
                btnSex.SelectedIndex = 1;
            }
            btnPhone.Text = dt.Rows[0][4].ToString();
            btnDateWork.Text = dt.Rows[0][5].ToString();
            if (image == "")
            {
                bitmap1 = new Bitmap(@"C:\\Users\\PC\\Pictures\\Baitaplon\\" + "user" + ".jpg");
            }
            else
            {
                bitmap1 = new Bitmap(image);
            }
            picBoxUser.BackgroundImage = bitmap1;

        }
        public Info()
        {
            InitializeComponent();
            getInfo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean sex;
            if (btnSex.SelectedIndex == 1)
            {
                sex = false;
            }
            else
            {
                sex = true;
            }
            string query;
            if (openFileDialog != null)
            {
                query = "UPDATE Manager SET Name_Manager = N'" + btnName.Text + "', Phone = N'" + btnPhone.Text + "',Sex ='" + sex + "'," + "Image='" + openFileDialog.FileName + "' where ID_Manager =" + LoginDAO.ID_Manager;
            }
            else

            {
                query = "UPDATE Manager SET Name_Manager =N'" + btnName.Text + "', Phone = N'" + btnPhone.Text + "',Sex ='" + sex + "'WHERE ID_Manager =" + LoginDAO.ID_Manager;
            }
            InfoDAO.Instance.updateInfo(query);
            MessageBox.Show("Cập nhật dữ liệu thành công");
            this.Hide();

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *.jpg";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                bitmap1 = new Bitmap(openFileDialog.FileName);

                picBoxUser.BackgroundImage = bitmap1;
            }
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }
    }
}
