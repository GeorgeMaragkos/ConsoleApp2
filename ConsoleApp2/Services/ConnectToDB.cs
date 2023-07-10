using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class ConnectToDB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection...");
            //Your Connection string here
            string connString = @"Data Source=DESKTOP-BJT7OC9\MSSQLSERVER2023; Initial Catalog=FundRaiser; User Id=sa; password=*********; TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            ;
        }
    }
}
