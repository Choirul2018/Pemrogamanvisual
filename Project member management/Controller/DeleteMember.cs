using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagementDashboard
{
    internal class DeleteMember
    {
        public bool Delete(int id)
        {
            try
            {
                using (var conn = Connect.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Members WHERE Id = @Id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
