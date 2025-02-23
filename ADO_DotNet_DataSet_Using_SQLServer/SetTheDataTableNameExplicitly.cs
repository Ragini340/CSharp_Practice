using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharp_Practice.ADO_DotNet_DataSet_Using_SQLServer
{
    public class SetTheDataTableNameExplicitly
    {
        public static void Main(string[] args)
        {
            try
            {
                string ConnectionString = @"data source=LAPTOP-ICA2LCQL\SQLEXPRESS; database=ShoppingCartDB; integrated security=SSPI";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from customers; select * from orders", connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataSet.Tables[0].TableName = "Customers";
                    dataSet.Tables[1].TableName = "Orders";

                    Console.WriteLine("Table 1 data:");
                    foreach (DataRow row in dataSet.Tables["Customers"].Rows)
                    {
                        Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                    }

                    Console.WriteLine("\nTable 2 data:");
                    foreach (DataRow row in dataSet.Tables["Orders"].Rows)
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