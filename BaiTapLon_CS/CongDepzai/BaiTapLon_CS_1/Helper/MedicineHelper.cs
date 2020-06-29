using BaiTapLon_CS.Class;
using BaiTapLon_CS.DAO;
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
            string query = "exec FindTheCurrentAmount_v2";
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
                                    Source = item.Field<string>("Source"),
                                    Max_Date_Of_Manufacture = item.Field<DateTime>("Max_Date_Of_Manu"),
                                    Min_Date_Of_Manufacture = item.Field<DateTime>("Min_Date_Of_Manu"),
                                    Max_Expiry = item.Field<DateTime>("Max_Expiry"),
                                    Min_Expiry = item.Field<DateTime>("Min_Expiry"),
                                    Max_Import_Cost = item.Field<decimal>("Max_Import_Cost"),
                                    Min_Import_Cost = item.Field<decimal>("Min_Import_Cost")
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
            string query = "exec FindTheCurreentAmountWithCategory @value";
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
                                    Cost = item.Field<decimal?>("Cost"),
                                    Packing = item.Field<string>("Packing"),
                                    Unit = item.Field<string>("Unit"),
                                    Registration_Number = item.Field<string>("Registration_Number"),
                                    Remain_Amount = item.Field<int?>("Current Amount"),
                                    Source = item.Field<string>("Source"),
                                    Max_Date_Of_Manufacture = item.Field<DateTime>("Max_Date_Of_Manu"),
                                    Min_Date_Of_Manufacture = item.Field<DateTime>("Min_Date_Of_Manu"),
                                    Max_Expiry = item.Field<DateTime>("Max_Expiry"),
                                    Min_Expiry = item.Field<DateTime>("Min_Expiry"),
                                    Max_Import_Cost = item.Field<decimal>("Max_Import_Cost"),
                                    Min_Import_Cost = item.Field<decimal>("Min_Import_Cost")
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

        public static Medicine GetMedicineWithId(int Id)
        {
            Medicine medicine = null;
            string query = "exec FindTheCurreentAmount_v2_SpecifiedID @value";
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
                                    Cost = item.Field<decimal?>("Cost"),
                                    Packing = item.Field<string>("Packing"),
                                    Unit = item.Field<string>("Unit"),
                                    Registration_Number = item.Field<string>("Registration_Number"),
                                    Remain_Amount = item.Field<int?>("Current Amount"),
                                    Source = item.Field<string>("Source"),
                                    Max_Date_Of_Manufacture = item.Field<DateTime>("Max_Date_Of_Manu"),
                                    Min_Date_Of_Manufacture = item.Field<DateTime>("Min_Date_Of_Manu"),
                                    Max_Expiry = item.Field<DateTime>("Max_Expiry"),
                                    Min_Expiry = item.Field<DateTime>("Min_Expiry"),
                                    Max_Import_Cost = item.Field<decimal>("Max_Import_Cost"),
                                    Min_Import_Cost = item.Field<decimal>("Min_Import_Cost")
                                };
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
            string query = "exec GetCategoryFromMedicine @value";
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
                            string query = "exec InsertImportDetail @idCategory,@idMedicine";
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
                            string query = "exec InsertManuFacturerDetail @idManufacturer,@idCategory";
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
                string query = "exec InsertImport @idManager";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Have to modify later
                sqlCommand.Parameters.AddWithValue("idManager", int.Parse(LoginDAO.ID_Manager));
                /*sqlCommand.Parameters.AddWithValue("importDate", medicine.Import_Date);*/
                sqlCommand.ExecuteScalar();
            }
            //Get ID Import
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "exec GetIdImport @idManager";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("idManager", 1);
                //sqlCommand.Parameters.AddWithValue("date", medicine.Import_Date);
                idImport = (int)sqlCommand.ExecuteScalar();
            }
            //Insert Import Detail
            using (SqlConnection sqlConnection = new SqlConnection(Form1.connect))
            {
                sqlConnection.Open();
                string query = "exec InsertImportDetail1 @idImport,@idMedicine,@dateOfManufacturer,@expriryDate,@cost,@amount";
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
            string query = "exec GetImportHistory @value";
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
