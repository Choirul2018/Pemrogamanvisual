using MemberManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MemberManagementDashboard
{
    public class AddMember
    {
        public bool Add(Member member)
        {
            try
            {
                using (var conn = Connect.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Members (Name, Email, Phone, Address) VALUES (@Name, @Email, @Phone, @Address)";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@Phone", member.Phone);
                    cmd.Parameters.AddWithValue("@Address", member.Address);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
