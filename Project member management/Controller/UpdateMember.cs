using MemberManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManagementDashboard
{
    internal class UpdateMember
    {
        public bool Update(Member member)
        {
            try
            {
                using (var conn = Connect.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Members SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address WHERE Id = @Id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", member.Id);
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@Phone", member.Phone);
                    cmd.Parameters.AddWithValue("@Address", member.Address);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
