using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace MinistryOfJusticeRealEstateAgentRegistration
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = Request.Form["name"];
            string license = Request.Form["license"];
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            if (RegisterAgent(name, license, username, password))
            {
                Response.Write($"<p>Agent {name} with license number {license} registered successfully.</p>");
            }
            else
            {
                Response.Write($"<p>Error: Registration failed.</p>");
            }
        }

        private bool RegisterAgent(string name, string license, string username, string password)
        {
            string connectionString = "your_connection_string_here";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Agents (Name, License, Username, Password) VALUES (@Name, @License, @Username, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@License", license);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log the exception
                    return false;
                }
            }
        }
    }
}
