using System;
using MinistryOfJusticeRealEstateAgentRegistration.Utilities;

namespace MinistryOfJusticeRealEstateAgentRegistration.Workflows
{
    public class RegistrationWorkflow
    {
        public void StartRegistration(string name, string license, string username, string password)
        {
            using (var connection = Helper.GetConnection())
            {
                var query = "INSERT INTO Agents (Name, License, Username, Password) VALUES (@Name, @License, @Username, @Password)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@License", license);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Agent registered successfully.");
                }
                catch (Exception ex)
                {
                    Helper.LogException(ex);
                    Console.WriteLine("Error: Registration failed.");
                }
            }
        }
    }
}
