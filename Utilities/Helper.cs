using System;
using System.Data.SqlClient;

namespace MinistryOfJusticeRealEstateAgentRegistration.Utilities
{
    public static class Helper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "your_connection_string_here";
            return new SqlConnection(connectionString);
        }
        public static void LogException(Exception ex)
        {
            // Implement logging logic here
        }
    }
}
