using BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapLon_CS.CongDepzai.BaiTapLon_CS_1.Helper
{
    public class InvoiceHelper
    {
        public static List<Invoice> FindInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "exec FindInvoices";
            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        invoices.Add(new Invoice
                        {
                            NameManager = dataRow.Field<string>("Name_Manager"),
                            NameCustomer = dataRow.Field<string>("Name_Customer"),
                            Cost = dataRow.Field<decimal>("Cost"),
                            ID = dataRow.Field<int>("ID_Invoice"),
                            Time_Of_Purchase = dataRow.Field<DateTime>("Time_Of_Purchase")
                        });
                    }
                }
            }
            return invoices;
        }

        public static List<MedicineInvoiceDetail> FindMedicineInvoiceDetails(int ID)
        {
            List<MedicineInvoiceDetail> details = new List<MedicineInvoiceDetail>();


            using (SqlConnection connection = new SqlConnection(Form1.connect))
            {
                string query = "exec FindInvoiceDetail @value";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("value", ID);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        details.Add(new MedicineInvoiceDetail
                        {
                            Name_Medicine = row.Field<string>("Name_Medicine"),
                            Cost = row.Field<decimal>("Cost"),
                            Amount = row.Field<int>("Amount")
                        });
                    }
                }
            }
            return details;
        }
    }
}
