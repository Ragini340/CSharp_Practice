using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharp_Practice.ADO_DotNet_DataSet_Using_SQLServer
{
    public class CopyCloneClearMethodsOfDataSetObject
    {
        public static void Main(string[] args)
        {
            try
            {
                string ConnectionString = @"data source=DESKTOP-LBBRO23\SQLEXPRESS; database=master; TrustServerCertificate=True; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from Student", connection);
                    DataSet originalDataSet = new DataSet();
                    da.Fill(originalDataSet);

                    Console.WriteLine("Original data set:");
                    foreach (DataRow row in originalDataSet.Tables[0].Rows)
                    {
                        Console.WriteLine(row["Roll_No"] + " " + row["Name"] + " " + row["Batch"] + " " + row["Phone_No"] + " " + row["Citizen_Id"]);
                    }

                    Console.WriteLine("\nCopy data set:");
                    DataSet copyDataSet = originalDataSet.Copy();
                    if (copyDataSet.Tables != null)
                    {
                        foreach (DataRow row in copyDataSet.Tables[0].Rows)
                        {
                            Console.WriteLine(row["Roll_No"] + " " + row["Name"] + " " + row["Batch"] + " " + row["Phone_No"] + " " + row["Citizen_Id"]);
                        }
                    }

                    Console.WriteLine("\nClone data set");
                    DataSet cloneDataSet = originalDataSet.Clone();
                    if (cloneDataSet.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in cloneDataSet.Tables[0].Rows)
                        {
                            Console.WriteLine(row["Roll_No"] + " " + row["Name"] + " " + row["Batch"] + " " + row["Phone_No"] + " " + row["Citizen_Id"]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nClone data set is empty");
                        Console.WriteLine("Adding data to Clone data set table");
                        cloneDataSet.Tables[0].Rows.Add(101, "Test1", "Test1@gmail.com", "1234567890");
                        cloneDataSet.Tables[0].Rows.Add(101, "Test2", "Test1@gmail.com", "1234567890");

                        foreach (DataRow row in cloneDataSet.Tables[0].Rows)
                        {
                            Console.WriteLine(row["Roll_No"] + " " + row["Name"] + " " + row["Batch"] + " " + row["Phone_No"] + " " + row["Citizen_Id"]);
                        }
                    }

                    Console.WriteLine();
                    copyDataSet.Clear();
                    if (copyDataSet.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in copyDataSet.Tables[0].Rows)
                        {
                            Console.WriteLine(row["Roll_No"] + " " + row["Name"] + " " + row["Batch"] + " " + row["Phone_No"] + " " + row["Citizen_Id"]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("After Clear no data is there");
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