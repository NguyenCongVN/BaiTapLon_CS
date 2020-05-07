using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace BaiTapLon_CS.DAO
{
     class DataProvider
     {
          public static DataProvider instance;
          public static string connect = @"Data Source=.\SQLEXPRESS;Initial Catalog=BAITAPLON;Integrated Security=True";
          SqlConnection con = new SqlConnection(connect);
          public static DataProvider Instance
          {
               get
               {
                    if(instance== null)
                    {
                         return new DataProvider();
                    }
                    return instance;
               }
               set
               {
                    instance = value;
               }
          }

          public DataTable DisplayListView(string query)
          {
               try
               {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = query;
                    con.Close();
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    if (reader.HasRows)
                    {
                         dt.Load(reader);
                         con.Close();
                         return dt;
                    }
                    else
                    {
                         con.Close();
                         return null;
                    }
               }
               catch (Exception e)
               {
                    MessageBox.Show("Lỗi cú pháp rồi " + e);
                    return null;
               }
          }
          public void Add(string query)
          {
               try
               {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = query;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

               }
               catch (Exception e)
               {
                    MessageBox.Show("Lỗi cú pháp rồi:" + e);
                    return;
               }
          }
     }

}
