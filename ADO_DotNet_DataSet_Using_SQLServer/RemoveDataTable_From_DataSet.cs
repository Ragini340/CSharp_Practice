using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharp_Practice.ADO_DotNet_DataSet_Using_SQLServer
{
    public class RemoveDataTable_From_DataSet
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

                    dataSet.Tables[0].TableName = "Customers";
                    dataSet.Tables[1].TableName = "Orders";
                    Console.WriteLine("Customers data:");
                    foreach (DataRow row in dataSet.Tables["Customers"].Rows)
                    {
                        Console.WriteLine(row["Id"] + " " + row["Name"] + " " + row["Mobile"]);
                    }

                    Console.WriteLine("\nOrders data:");
                    foreach (DataRow row in dataSet.Tables["Orders"].Rows)
                    {
                        Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
                    }

                    if (dataSet.Tables.Contains("Orders") && dataSet.Tables.CanRemove(dataSet.Tables["Orders"]))
                    {
                        Console.WriteLine("\nDeleting orders data table...");
                        dataSet.Tables.Remove(dataSet.Tables["Orders"]);
                    }

                    if (dataSet.Tables.Contains("Orders"))
                    {
                        Console.WriteLine("Orders data table exits");
                    }
                    else
                    {
                        Console.WriteLine("Orders data table not exits anymore");
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