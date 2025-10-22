using System;
using System.Data;
using System.Data.SqlClient; // .NET Framework uses System.Data.SqlClient (built-in)
using System.Windows.Forms;

namespace SimpleHMS
{
    // Database operations class
    // This class handles all database connections and queries
    public class DB
    {
        // Connection string - Update the Data Source to match your SQL Server
        // For default instance: localhost
        // For SQL Express: localhost\\SQLEXPRESS
        // For named instance: localhost\\YOUR_INSTANCE_NAME
        static string conn = "Data Source=localhost;Initial Catalog=SimpleHospitalDB;Integrated Security=True;";

        // Method to get data from database (for SELECT queries)
        // Returns: DataTable with query results
        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable(); // Create empty DataTable to store results

            try
            {
                // Create connection to database
                SqlConnection connection = new SqlConnection(conn);
                
                // Create command with query
                SqlCommand cmd = new SqlCommand(query, connection);
                
                // Create adapter to fill DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                // Fill the DataTable with query results
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt; // Return the DataTable with results
        }

        // Method to execute INSERT, UPDATE, DELETE queries
        // Returns: Number of rows affected
        public static int SetData(string query)
        {
            int rowsAffected = 0; // Variable to store number of rows affected

            try
            {
                // Create connection to database
                SqlConnection connection = new SqlConnection(conn);
                
                // Create command with query
                SqlCommand cmd = new SqlCommand(query, connection);
                
                // Open the connection
                connection.Open();
                
                // Execute the query and get rows affected
                rowsAffected = cmd.ExecuteNonQuery();
                
                // Close the connection
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rowsAffected; // Return number of rows affected
        }
    }
}

