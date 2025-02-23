using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharp_Practice.ADO_DotNet_DataSet_Using_SQLServer
{
    public class Accessing_DataTable_FromDataSet_Using_DefaultTableName
    {
        public static void Main(string[] args)
        {
            try
            {
                string ConnectionString = @"data source=DESKTOP-LBBRO23\SQLEXPRESS; database=ShoppingCartDB; TrustServerCertificate=True; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from customers; select * from orders", connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    Console.WriteLine("Table 1 data:");
                    foreach (DataRow row in dataSet.Tables["Table"].Rows)
                    {
                        Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                    }

                    Console.WriteLine("\nTable 2 data:");
                    foreach (DataRow row in dataSet.Tables["Table1"].Rows)
                    {
                        Console.WriteLine(row[0] + ",  " + row[1] + ",  " + row[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
            }
        }

    }
}