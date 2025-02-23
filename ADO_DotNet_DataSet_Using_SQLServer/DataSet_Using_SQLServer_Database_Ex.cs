using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharp_Practice.ADO_DotNet_DataSet_Using_SQLServer
{
    public class DataSet_Using_SQLServer_Database_Ex
    {
        public static void Main(string[] args)
        {
            try
            {
                string ConnectionString = @"data source=DESKTOP-LBBRO23\SQLEXPRESS; database=ShoppingCartDB; TrustServerCertificate=True; Integrated Security=SSPI";
                //"Integrated Security=SSPI" in a database connection string means that the application will use Windows
                //Authentication to connect to the database server, leveraging the Security Support Provider Interface (SSPI) on the
                //operating system to verify user credentials without requiring a separate username and password in the connection
                //string; essentially, it uses the currently logged-in Windows user for authentication. 

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from customers", connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
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