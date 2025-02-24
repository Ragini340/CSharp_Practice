using System.Data;
using Microsoft.Data.SqlClient;

namespace CSharp_Practice.ADO_DotNet_Using_StoredProcedures
{
    public class CallAStoredProcedureWithoutParameters
    {
        public static void Main(string[] args)
        {
            try
            {
                string ConnectionString = @"data source=DESKTOP-LBBRO23\SQLEXPRESS; database=master; TrustServerCertificate=True; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetStudents", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    connection.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["Roll_No"] + " " + sdr["Name"] + " " + sdr["Batch"] + " " + sdr["Phone_No"] + " " + sdr["Citizen_Id"]);
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