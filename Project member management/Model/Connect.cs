using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MemberManagementDashboard
{
    internal class Connect
    {
        private static string server = "localhost";
        private static string database = "MemberManagementDB";
        private static string uid = "root";
        private static string password = "";
        private static int port = 3306;

        private static string connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
