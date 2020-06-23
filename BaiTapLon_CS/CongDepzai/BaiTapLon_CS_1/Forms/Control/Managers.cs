using BaiTapLon_CS.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLon_CS.Forms.Control
{
    public partial class Managers : UserControl
    {
        public Managers()
        {
            InitializeComponent();
            Load();
        }

        public void Init(object sender, EventArgs e)
        {
            Load();
        }

        private void Load()
        {
            ListViewDanhSachNhanVien.Items.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manager";
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    int i = 1;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow item in dataTable.Rows)
                    {
                        ListViewItem listViewItem = new ListViewItem(new string[] {i.ToString() , item.Field<int>("ID_Manager").ToString() , item.Field<string>("Name_Manager")
                        , item.Field<string>("Email")});
                        ListViewDanhSachNhanVien.Items.Add(listViewItem);
                        i++;
                    }
                }
            }
            ContextMenuStrip contextMenuStripListShow = new ContextMenuStrip();
            ToolStripMenuItem itemThem = new ToolStripMenuItem();


            ToolStripMenuItem itemXoa = new ToolStripMenuItem();
            itemXoa.Name = "XoaNhanVien";
            itemXoa.Text = "Xóa Nhân Viên";
            itemXoa.Click += ItemXoaNhanVien_Click;

            contextMenuStripListShow.Items.Add(itemXoa);
            ListViewDanhSachNhanVien.ContextMenuStrip = contextMenuStripListShow;
        }

        private void ItemXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (ListViewDanhSachNhanVien.SelectedItems[0] != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                    {
                        sqlConnection.Open();
                        string query = "delete from Manager where ID_Manager = @value";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("value", ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
                        sqlCommand.ExecuteScalar();
                    }
                    Load();
                }
            }
        }

        private void ItemThemNhanVien_Click()
        {
            BoolClass boolClass = new BoolClass();
            boolClass.isChanged = false;
            Manager manager = new Manager();
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm(manager, boolClass);
            themNhanVienForm.ShowDialog();
            if (boolClass.isChanged == true)
            {
                Load();
            }
        }

        private void ListViewDanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Id;
            try
            {
                Id = int.Parse(ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                if (e is EventArgsForMedicine)
                {
                    Id = ((EventArgsForMedicine)e).Id;
                }
                else
                {
                    return;
                }
            }
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manager where ID_Manager = @value";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    Manager manager = new Manager
                    {
                        Email = dataTable.Rows[0].Field<string>("Email"),
                        ID_Manager = dataTable.Rows[0].Field<int>("ID_Manager"),
                        Name_Manager = dataTable.Rows[0].Field<string>("Name_Manager"),
                        Password = dataTable.Rows[0].Field<string>("Password"),
                        Phone = dataTable.Rows[0].Field<string>("Phone"),
                        Image = dataTable.Rows[0].Field<string>("Image")
                    };
                    LabelTenNhanVien.Text = "Tên:" + manager.Name_Manager;
                    LabelMaNhanVien.Text = "Mã Nhân Viên:" + manager.ID_Manager.ToString();
                    LabelEmail.Text = "Email:" + manager.Email;
                    LabelDienThoai.Text = "Điện Thoại:" + manager.Phone;
                    try
                    {
                        Bitmap bitmap = new Bitmap(manager.Image);
                        Bitmap bitmap1 = new Bitmap(bitmap, PictureBoxNhanVien.Width, PictureBoxNhanVien.Height);
                        PictureBoxNhanVien.Image = bitmap1;
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void ButtonChonAnhNhanVien_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.jfif;*.png| Select All | *";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;
                    using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                    {
                        sqlConnection.Open();
                        string query = "update Manager set Image =@value where ID_Manager = @selectedId";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("value", path);
                        sqlCommand.Parameters.AddWithValue("selectedId", Id);
                        sqlCommand.ExecuteScalar();
                    }
                    Bitmap bitmap = new Bitmap(path);
                    Bitmap resizedBitmap = new Bitmap(bitmap, new Size(PictureBoxNhanVien.Width, PictureBoxNhanVien.Height));
                    PictureBoxNhanVien.Image = resizedBitmap;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
        }

        private void ThayDoiThongTinNhanVien_Click(object sender, EventArgs e)
        {
            int Id;
            try
            {
                Id = int.Parse(ListViewDanhSachNhanVien.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception ex)
            {
                return;
            }
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                string query = "select * from Manager where ID_Manager = @value";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    Manager manager = new Manager
                    {
                        Email = dataTable.Rows[0].Field<string>("Email"),
                        ID_Manager = dataTable.Rows[0].Field<int>("ID_Manager"),
                        Name_Manager = dataTable.Rows[0].Field<string>("Name_Manager"),
                        Password = dataTable.Rows[0].Field<string>("Password"),
                        Phone = dataTable.Rows[0].Field<string>("Phone"),
                        Image = dataTable.Rows[0].Field<string>("Image"),
                        DayWork = dataTable.Rows[0].Field<DateTime>("Day_Work"),
                        Salary = dataTable.Rows[0].Field<decimal>("Salary"),
                        Sex = dataTable.Rows[0].Field<bool>("Sex")
                    };
                    BoolClass boolClass = new BoolClass();
                    boolClass.isChanged = false;
                    ChangeInformationManager changeInformationManager = new ChangeInformationManager(manager, boolClass);
                    changeInformationManager.ShowDialog();

                    if (boolClass.isChanged == false)
                    {
                        return;
                    }
                    else
                    {
                        sqlConnection.Open();
                        string query1 = "update Manager set Name_Manager = @name, " +
                                        "Phone = @phone, " +
                                        "Email = @email " +
                                        ",Day_Work = @daywork " +
                                        ",Salary = @salary " +
                                        ",Sex = @sex " +
                                        "where ID_Manager = @old_Id";
                        SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
                        sqlCommand1.Parameters.AddWithValue("name", manager.Name_Manager);
                        sqlCommand1.Parameters.AddWithValue("Phone", manager.Phone);
                        sqlCommand1.Parameters.AddWithValue("Email", manager.Email);
                        //sqlCommand1.Parameters.AddWithValue("Password", manager.Password);
                        sqlCommand1.Parameters.AddWithValue("daywork", manager.DayWork);
                        sqlCommand1.Parameters.AddWithValue("salary", manager.Salary);
                        sqlCommand1.Parameters.AddWithValue("sex", manager.Sex);
                        sqlCommand1.Parameters.AddWithValue("old_Id", Id);
                        sqlCommand1.ExecuteScalar();
                    }
                }
                ListViewDanhSachNhanVien.Items.Clear();
                Load();
                ListViewDanhSachNhanVien_SelectedIndexChanged(ListViewDanhSachNhanVien, null);
            }
        }

        private void TextBoxTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            Load();
            foreach (ListViewItem item in ListViewDanhSachNhanVien.Items)
            {
                if (!item.SubItems[2].Text.ToLower().Contains(TextBoxTimKiemNhanVien.Text.ToLower()))
                {
                    ListViewDanhSachNhanVien.Items.Remove(item);
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemThemNhanVien_Click();
        }
    }
}
