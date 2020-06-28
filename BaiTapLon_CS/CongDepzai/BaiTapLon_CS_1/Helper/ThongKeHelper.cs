using BaiTapLon_CS.Class;
using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapLon_CS.Helper
{
    public class ThongKeHelper
    {
        public static List<MoneyInMonth> GetRevenueInMonths(int year)
        {
            List<MoneyInMonth> revenues = new List<MoneyInMonth>();
            string query = @"exec GetRevenue @year";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("year", year);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    revenues.Add(new MoneyInMonth { Month = row.Field<int>("_Month"), Money = row.Field<decimal>("Revenue"), Year = row.Field<int>("_Year") });
                }
            }
            return revenues;
        }

        public static List<MoneyInMonth> GetSalaryInMonths(int year)
        {
            List<MoneyInMonth> salaries = new List<MoneyInMonth>();
            string query = @"exec GetSalaryInMonth @year";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("year", year);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    salaries.Add(new MoneyInMonth { Month = row.Field<int>("_month"), Money = row.Field<decimal>("TotalSalary"), Year = row.Field<int>("_year") });
                }
            }
            return salaries;
        }

        public static List<MoneyInMonth> GetImportCostInMonth(int year)
        {
            List<MoneyInMonth> importCost = new List<MoneyInMonth>();
            string query = @"exec GetImportCostInMonth @year";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("year", year);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    importCost.Add(new MoneyInMonth { Month = row.Field<int>("_Month"), Money = row.Field<decimal>("Cost"), Year = row.Field<int>("_Year") });
                }
            }
            return importCost;
        }
        public static List<MoneyInMonth> GetMoneyInMonth(int year)
        {
            List<MoneyInMonth> moneyInMonths = new List<MoneyInMonth>();
            string query = @"exec GetMoneyy @year";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("year", year);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    moneyInMonths.Add(new MoneyInMonth { Month = row.Field<int>("_Month"), Money = row.Field<decimal>("Revenue"), Year = row.Field<int>("_Year") });
                }
            }
            return moneyInMonths;
        }

        public static List<StatisticEmployee> GetStatisticEmployees()
        {
            List<StatisticEmployee> statisticEmployees = new List<StatisticEmployee>();

            string query = @"exec GetStatisticEmployees";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    statisticEmployees.Add(new StatisticEmployee
                    {
                        Name_Manager = row.Field<string>("Name_Manager"),
                        Salary = row.Field<decimal>("Luong"),
                        TotalAmount = row.Field<int>("Tong so hang ban"),
                        TotalCost = row.Field<decimal>("Tong so tien ban"),
                        TotalInvoice = row.Field<int>("Total invoice")
                    });
                }
            }
            return statisticEmployees;
        }

        public static List<StatisticCustomer> GetStatisticCustomers()
        {
            List<StatisticCustomer> statisticCustomer = new List<StatisticCustomer>();

            string query = @"exec GetStatisticCustomers";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    statisticCustomer.Add(new StatisticCustomer
                    {
                        Name_Customer = row.Field<string>("Ten khach hang"),
                        Phone = row.Field<string>("So dien thoai"),
                        TotalAmount = row.Field<int>("Tong so hang da mua"),
                        TotalCost = row.Field<decimal>("Tong so tien mua"),
                        TotalInvoice = row.Field<int>("Tong so don hang")
                    });
                }
            }
            return statisticCustomer;
        }

        public static List<StatisticMedicine> GetStatisticMedicines()
        {
            List<StatisticMedicine> statisticMedicines = new List<StatisticMedicine>();
            string query = @"exec GetStatisticMedicines";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    statisticMedicines.Add(new StatisticMedicine
                    {
                        ID_Medicine = row.Field<int>("ID_Medicine"),
                        Image_Medicine = row.Field<string>("Image_Medicine"),
                        Name_Medicine = row.Field<string>("Name_Medicine"),
                        TotalAmount = row.Field<int>("Tong so ban duoc")
                    });
                }
            }
            return statisticMedicines;
        }

        public static float NumberOfCustomerInYear(int year)
        {
            float numberOfCustomer = 0;
            string query = "exec FindNumberOfCustomer @year";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("year", year);
                numberOfCustomer = (int)sqlCommand.ExecuteScalar();
            }

            return numberOfCustomer;
        }

        public static List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();
            string query = "exec GetStatisticExpense";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    expenses.Add(new Expense
                    {
                        Cost = row.Field<decimal>("Salary"),
                        Type = row.Field<string>("Type"),
                        DayCost = row.Field<DateTime>("PaidDate"),
                        Detail = row.Field<string>("Detail"),
                        ID = row.Field<int>("ID")
                    });
                }
            }

            return expenses;
        }

        public static List<ManagerStatistic> GetManagerStatistic()
        {
            List<ManagerStatistic> managers = new List<ManagerStatistic>();
            string query = "exec GetStatisticEmployees";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        managers.Add(new ManagerStatistic
                        {
                            ID_Manager = row.Field<int>("ID_Manager"),
                            Name_Manager = row.Field<string>("Name_Manager"),
                            Salary = row.Field<decimal>("Luong"),
                            TotalInvoice = row.Field<int>("Total invoice"),
                            TotalMedicineSold = row.Field<int>("Tong so hang ban"),
                            TotalMoneySold = row.Field<decimal>("Tong so tien ban")
                        });
                    }
                }
            }
            return managers;
        }

        public static List<CustomerStatistic> GetCustomerStatistic()
        {
            List<CustomerStatistic> customers = new List<CustomerStatistic>();
            string query = "exec GetStatisticCustomers";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        customers.Add(new CustomerStatistic
                        {
                            Name_Customer = row.Field<string>("Ten khach hang"),
                            Phone = row.Field<string>("So dien thoai"),
                            TotalInvoice = row.Field<int>("Tong so don hang"),
                            TotalMoney = row.Field<decimal>("Tong so tien mua")
                        });
                    }
                }
            }
            return customers;
        }

        public static List<MedicineStatistic> GetMedicineStatistic()
        {
            List<MedicineStatistic> medicines = new List<MedicineStatistic>();
            string query = "exec GetStatisticMedicines";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        medicines.Add(new MedicineStatistic
                        {
                            ID_Medicine = row.Field<int>("ID_Medicine"),
                            Name_Medicine = row.Field<string>("Name_Medicine"),
                            Image_Medicine = row.Field<string>("Image_Medicine"),
                            TotalSold = row.Field<int>("Tong so ban duoc")
                        });
                    }
                }
            }
            return medicines;
        }
    }
}
