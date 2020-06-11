using BaiTapLon_CS.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace BaiTapLon_CS.Helper
{
    public class MedicineHelper
    {
        public static List<Medicine> GetMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();
            string query = "exec FindTheCurreentAmount";
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    Medicine medicine = null;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow item in dataTable.Rows)
                    {
                        try
                        {
                            {
                                medicine = new Medicine
                                {
                                    ID_Medicine = item.Field<int>("ID_Medicine"),
                                    Name_Medicine = item.Field<string>("Name_Medicine"),
                                    Image_Medicine = item.Field<string>("Image_Medicine"),
                                    Cost = item.Field<decimal?>("Cost"),
                                    Packing = item.Field<string>("Packing"),
                                    Unit = item.Field<string>("Unit"),
                                    Registration_Number = item.Field<string>("Registration_Number"),
                                    Remain_Amount = item.Field<int?>("Current Amount"),
                                    Source = item.Field<string>("Source")
                                };
                                medicines.Add(medicine);
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.ToString());
                        }
                    }
                }
            }
            return medicines;
        }




        public static List<Medicine> GetMedicinesWithCategory(int categoryId)
        {
            List<Medicine> medicines = new List<Medicine>();
            string query = "select medicine.*," +
"import_Detail.Date_Of_Manufacture,import_Detail.Expiry_Date," +
"(Import_Detail.Amount - detail.Amount) as 'Current Amount'," +
" category.Name_Category,category.ID_Category," +
" manufacturer.Name_Manufacturer," +
" import.Import_Date " +
"from Medicine medicine left join Import_Detail import_Detail " +
"on medicine.ID_Medicine = import_Detail.ID_Medicine " +
"left join Import import " +
"on import.ID_Import = import_Detail.ID_Import " +
"left join Invoice_Detail detail " +
"on detail.ID_Medicine = medicine.ID_Medicine " +
"left join Category_Detail category_Detail " +
"on category_Detail.ID_Medicine = medicine.ID_Medicine " +
"left join Category category " +
"on category.ID_Category = category_Detail.ID_Category " +
"left join Manufacturer_Detail manu_Detail " +
"on manu_Detail.ID_Category = category.ID_Category " +
"left join Manufacturer manufacturer " +
"on manufacturer.ID_Manufacturer = manu_Detail.ID_Manufacturer " +
"where category.ID_Category = @value " +
"order by ID_Medicine";
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", categoryId);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    Medicine medicine = null;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow item in dataTable.Rows)
                    {
                        try
                        {
                            if (medicine == null || (medicine != null && item.Field<int>("ID_Medicine") != medicine.ID_Medicine))
                            {
                                medicine = new Medicine
                                {
                                    ID_Medicine = item.Field<int>("ID_Medicine"),
                                    Name_Medicine = item.Field<string>("Name_Medicine"),
                                    Image_Medicine = item.Field<string>("Image_Medicine"),
                                    ID_Category = new List<int?> { item.Field<int?>("ID_Category") },
                                    Cost = item.Field<decimal?>("Cost"),
                                    Date_Of_Manufacture = item.Field<DateTime?>("Date_Of_Manufacture"),
                                    Expiry_Date = item.Field<DateTime?>("Expiry_Date"),
                                    Name_Category = new List<string> { item.Field<string>("Name_Category") },
                                    Packing = item.Field<string>("Packing"),
                                    Unit = item.Field<string>("Unit"),
                                    Registration_Number = item.Field<string>("Registration_Number"),
                                    Import_Date = item.Field<DateTime?>("Import_Date"),
                                    Remain_Amount = item.Field<int?>("Current Amount"),
                                    Source = item.Field<string>("Source"),
                                    //Name_Manufacturer = item.Field<string>("Name_Manufacturer")
                                };
                                medicines.Add(medicine);
                            }
                            else
                            {
                                if (!medicine.ID_Category.Contains(item.Field<int?>("ID_Category")))
                                {
                                    medicine.Name_Category.Add(item.Field<string>("Name_Category"));
                                    medicine.ID_Category.Add(item.Field<int?>("ID_Category"));
                                }

                                if (!medicine.ID_Manufacturer.Contains(item.Field<int?>("ID_Manufacturer")))
                                {
                                    medicine.Name_Manufacturer.Add(item.Field<string>("Name_Manufacturer"));
                                    medicine.ID_Category.Add(item.Field<int?>("ID_Manufacturer"));
                                }

                            }
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.ToString());
                        }
                    }
                }
            }
            return medicines;
        }

        public static Medicine GetMedicineWithId(int Id)
        {
            Medicine medicine = null;
            string query = "select medicine.*," +
"import_Detail.Date_Of_Manufacture,import_Detail.Expiry_Date," +
"(Import_Detail.Amount - detail.Amount) as 'Current Amount'," +
" category.Name_Category,category.ID_Category," +
" manufacturer.Name_Manufacturer," +
" import.Import_Date," +
" manufacturer.ID_Manufacturer " +
"from Medicine medicine left join Import_Detail import_Detail " +
"on medicine.ID_Medicine = import_Detail.ID_Medicine " +
"left join Import import " +
"on import.ID_Import = import_Detail.ID_Import " +
"left join Invoice_Detail detail " +
"on detail.ID_Medicine = medicine.ID_Medicine " +
"left join Category_Detail category_Detail " +
"on category_Detail.ID_Medicine = medicine.ID_Medicine " +
"left join Category category " +
"on category.ID_Category = category_Detail.ID_Category " +
"left join Manufacturer_Detail manu_Detail " +
"on manu_Detail.ID_Category = category.ID_Category " +
"left join Manufacturer manufacturer " +
"on manufacturer.ID_Manufacturer = manu_Detail.ID_Manufacturer " +
"where medicine.ID_Medicine = @value";
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow item in dataTable.Rows)
                    {
                        try
                        {
                            if (medicine == null || (medicine != null && item.Field<int>("ID_Medicine") != medicine.ID_Medicine))
                            {
                                medicine = new Medicine
                                {
                                    ID_Medicine = item.Field<int>("ID_Medicine"),
                                    Name_Medicine = item.Field<string>("Name_Medicine"),
                                    Image_Medicine = item.Field<string>("Image_Medicine"),
                                    ID_Category = new List<int?> { item.Field<int?>("ID_Category") },
                                    Cost = item.Field<decimal?>("Cost"),
                                    Date_Of_Manufacture = item.Field<DateTime?>("Date_Of_Manufacture"),
                                    Expiry_Date = item.Field<DateTime?>("Expiry_Date"),
                                    Name_Category = new List<string> { item.Field<string>("Name_Category") },
                                    Packing = item.Field<string>("Packing"),
                                    Unit = item.Field<string>("Unit"),
                                    Registration_Number = item.Field<string>("Registration_Number"),
                                    Import_Date = item.Field<DateTime?>("Import_Date"),
                                    Remain_Amount = item.Field<int?>("Current Amount"),
                                    Source = item.Field<string>("Source"),
                                    Name_Manufacturer = new List<string>() { item.Field<string>("Name_Manufacturer") },
                                    ID_Manufacturer = new List<int?>() { item.Field<int?>("ID_Manufacturer") }
                                };
                            }
                            else
                            {
                                if (!medicine.ID_Category.Contains(item.Field<int?>("ID_Category")))
                                {
                                    medicine.Name_Category.Add(item.Field<string>("Name_Category"));
                                    medicine.ID_Category.Add(item.Field<int?>("ID_Category"));
                                }

                                try
                                {
                                    if (!medicine.ID_Manufacturer.Contains(item.Field<int?>("ID_Manufacturer")))
                                    {
                                        medicine.Name_Manufacturer.Add(item.Field<string>("Name_Manufacturer"));
                                        medicine.ID_Category.Add(item.Field<int?>("ID_Manufacturer"));
                                    }
                                }
                                catch (Exception e)
                                {
                                    Debug.WriteLine(e.ToString());
                                }

                                if (item.Field<int?>("ID_Manufacturer") != null)
                                {
                                    medicine.Remain_Amount += item.Field<int?>("Current Amount");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.ToString());
                        }
                    }
                }
            }
            return medicine;
        }

        public static void UpdateMedicine(Medicine medicine, int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query1 = "update Medicine" +
                " set Name_Medicine = @name " +
                " , Source = @source ," +
                " Packing = @packing ," +
                " Unit = @unit ," +
                " Registration_Number = @registration_Number, " +
                " Cost = @cost " +
                "where ID_Medicine = @old_Id";

                SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
                sqlCommand1.Parameters.AddWithValue("name", medicine.Name_Medicine);
                sqlCommand1.Parameters.AddWithValue("source", medicine.Source);
                sqlCommand1.Parameters.AddWithValue("packing", medicine.Packing);
                sqlCommand1.Parameters.AddWithValue("unit", medicine.Unit);
                sqlCommand1.Parameters.AddWithValue("registration_Number", medicine.Registration_Number);
                sqlCommand1.Parameters.AddWithValue("cost", medicine.Cost);
                sqlCommand1.Parameters.AddWithValue("old_Id", id);
                sqlCommand1.ExecuteScalar();
            }
        }

        public static void UpdateCategoryWithMedicine(Medicine medicine)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                {
                    sqlConnection.Open();
                    string query = "delete from Category_Detail " +
                        "where ID_Medicine = @Id";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Id", medicine.ID_Medicine);
                    sqlCommand.ExecuteScalar();
                }

                foreach (var x in medicine.ID_Category)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                    {
                        sqlConnection.Open();
                        string query = "insert into Category_Detail values (@idCategory,@idMedicine)";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("idCategory", x);
                        sqlCommand.Parameters.AddWithValue("idMedicine", medicine.ID_Medicine);
                        sqlCommand.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Xảy ra !");
            }
        }


        public static void UpdateImage(int Id, string path)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "update Medicine set Image_Medicine =@value where Id_Medicine = @selectedId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", path);
                sqlCommand.Parameters.AddWithValue("selectedId", Id);
                sqlCommand.ExecuteScalar();
            }
        }

        public static List<Category> GetCategoryOfTheMedicine(int Id)
        {
            string query = "select Category.Name_Category, Category.ID_Category " +
"from Category category inner " +
"join Category_Detail cate_detail " +
"on category.ID_Category = cate_detail.ID_Category " +
"inner join Medicine medicine " +
"on medicine.ID_Medicine = cate_detail.ID_Medicine " +
"where medicine.ID_Medicine = @value";
            List<Category> categories = new List<Category>();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("value", Id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    categories.Add(new Category
                    {
                        CategoryID = dataRow.Field<int>("ID_Category"),
                        NameCategory = dataRow.Field<string>("Name_Category")
                    });
                }
            }
            return categories;
        }

        public static List<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "select * from Category";
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        categories.Add(new Category
                        {
                            CategoryID = dataRow.Field<int>("ID_Category"),
                            NameCategory = dataRow.Field<string>("Name_Category")
                        });
                    }
                }
            }
            return categories;
        }

        public static int GetIdCategoryWithName(string name)
        {
            int i = 0;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                {
                    sqlConnection.Open();
                    string query = "Select ID_Category from Category" +
                        " where Name_Category = @value";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("value", name);
                    i = int.Parse(sqlCommand.ExecuteScalar().ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Xảy ra !");
            }
            return i;
        }

        public static List<Category> GetCategoryFromManufacturerName(string name)
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "select category.* from Category category " +
"left join Manufacturer_Detail detail " +
"on category.ID_Category = detail.ID_Category " +
"left join Manufacturer manufacturer " +
"on manufacturer.ID_Manufacturer = detail.ID_Manufacturer " +
"where manufacturer.Name_Manufacturer = @name";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("name", name);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    foreach (DataRow x in table.Rows)
                    {
                        categories.Add(new Category
                        {
                            CategoryID = x.Field<int>("ID_Category"),
                            NameCategory = x.Field<string>("Name_Category")
                        });
                    }
                }
            }
            return categories;
        }

        public static List<Category> GetCategoryFromManuFacturerID(int? Id)
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "select category.* from Category category " +
"left join Manufacturer_Detail detail " +
"on category.ID_Category = detail.ID_Category " +
"left join Manufacturer manufacturer " +
"on manufacturer.ID_Manufacturer = detail.ID_Manufacturer " +
"where manufacturer.ID_Manufacturer = @id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    foreach (DataRow x in table.Rows)
                    {
                        categories.Add(new Category
                        {
                            CategoryID = x.Field<int>("ID_Category"),
                            NameCategory = x.Field<string>("Name_Category")
                        });
                    }
                }
            }
            return categories;
        }

        public static List<int?> GetCategoryIdFromManuFacturerID(int? Id)
        {
            List<int?> idCategories = new List<int?>();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "select category.* from Category category " +
"left join Manufacturer_Detail detail " +
"on category.ID_Category = detail.ID_Category " +
"left join Manufacturer manufacturer " +
"on manufacturer.ID_Manufacturer = detail.ID_Manufacturer " +
"where manufacturer.ID_Manufacturer = @id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", Id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    foreach (DataRow x in table.Rows)
                    {
                        idCategories.Add(x.Field<int>("ID_Category"));
                    }
                }
            }
            return idCategories;
        }

        public static void ImportMedicine(Medicine medicine)
        {
            // Create a Compare Medicine that is exist in DataBase
            Medicine compareMedicine = new Medicine();
            compareMedicine = GetMedicineWithId(medicine.ID_Medicine);
            //If ID_Category is exist in older ID_Categort List or There's no Id_Category => Insert Category
            try
            {
                foreach (var x in medicine.ID_Category)
                {
                    if (!compareMedicine.ID_Category.Contains(x) || compareMedicine.ID_Category[0] == null)
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                        {
                            sqlConnection.Open();
                            string query = "insert into Category_Detail values (@idCategory,@idMedicine)";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.Parameters.AddWithValue("idCategory", x);
                            sqlCommand.Parameters.AddWithValue("idMedicine", medicine.ID_Medicine);
                            sqlCommand.ExecuteScalar();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            // If ID_Category is exist in ID_Category of Manufacturer
            try
            {
                foreach (var x in medicine.ID_Manufacturer)
                {
                    if (!GetCategoryIdFromManuFacturerID(x).Contains(medicine.ID_Category[0]))
                    {
                        using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
                        {
                            sqlConnection.Open();
                            string query = "insert into Manufacturer_Detail values (@idManufacturer,@idCategory)";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.Parameters.AddWithValue("idManufacturer", x.Value);
                            sqlCommand.Parameters.AddWithValue("idCategory", medicine.ID_Category[0]);
                            sqlCommand.ExecuteScalar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            int idImport = 0;
            // Insert Import
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "insert into Import values (@idManager,getdate(),null)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Have to modify later
                sqlCommand.Parameters.AddWithValue("idManager", 1);
                /*sqlCommand.Parameters.AddWithValue("importDate", medicine.Import_Date);*/
                sqlCommand.ExecuteScalar();
            }
            //Get ID Import
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "select ID_Import from Import where ID_Manager = @idManager order by Import_Date desc";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("idManager", 1);
                //sqlCommand.Parameters.AddWithValue("date", medicine.Import_Date);
                idImport = (int)sqlCommand.ExecuteScalar();
            }
            //Insert Import Detail
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "insert into Import_Detail values (@idImport,@idMedicine,@dateOfManufacturer," +
                    "@expriryDate,@cost,@amount)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("idImport", idImport);
                sqlCommand.Parameters.AddWithValue("idMedicine", medicine.ID_Medicine);
                sqlCommand.Parameters.AddWithValue("dateOfManufacturer", medicine.Date_Of_Manufacture);
                sqlCommand.Parameters.AddWithValue("expriryDate", medicine.Expiry_Date);
                sqlCommand.Parameters.AddWithValue("cost", medicine.Cost);
                sqlCommand.Parameters.AddWithValue("amount", medicine.Remain_Amount);
                sqlCommand.ExecuteScalar();
            }
        }

        public static List<ImportHistory> GetImportHistory(int id)
        {
            string query = "select import.Import_Date, " +
    "detail.Date_Of_Manufacture, " +
    "detail.Expiry_Date, " +
    "import.ID_Import " +
    "from Import import " +
    "inner join Import_Detail detail " +
    "on import.ID_Import = detail.ID_Import " +
    "inner join Medicine medicine " +
    "on detail.ID_Medicine = medicine.ID_Medicine " +
    "where medicine.ID_Medicine = @value";
            List<ImportHistory> histories = new List<ImportHistory>();
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("value", id);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow x in dataTable.Rows)
                    {
                        histories.Add(new ImportHistory
                        {
                            Import_Date = x.Field<DateTime>("Import_Date"),
                            Date_Of_Manufacture = x.Field<DateTime>("Date_Of_Manufacture"),
                            Expiry_Date = x.Field<DateTime>("Expiry_Date"),
                            ID_Import = x.Field<int>("ID_Import")
                        });
                    }
                }
            }
            return histories;
        }
    }
}
