using MemberManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MemberManagementDashboard
{
    internal class Connect
    {
      
        private static string server = "localhost";
        private static string database = "MemberManagementDB";
        private static string uid = "root";       // Default username Laragon
        private static string password = "";      // Default password Laragon (kosong)
        private static int port = 3306;           // Default port MySQL

        private static string connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};";

        // Mendapatkan koneksi database
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Method untuk mengambil semua member dari database
        public static List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Members";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Address = reader["Address"].ToString(),
                                JoinDate = Convert.ToDateTime(reader["JoinDate"])
                            };
                            members.Add(member);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return members;
        }

        // Method untuk menambah member baru
        public static bool AddMember(Member member)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Members (Name, Email, Phone, Address) VALUES " +
                                  "(@Name, @Email, @Phone, @Address)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@Phone", member.Phone);
                    cmd.Parameters.AddWithValue("@Address", member.Address);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method untuk mengupdate data member
        public static bool UpdateMember(Member member)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Members SET Name = @Name, Email = @Email, " +
                                  "Phone = @Phone, Address = @Address WHERE Id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", member.Id);
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@Phone", member.Phone);
                    cmd.Parameters.AddWithValue("@Address", member.Address);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method untuk menghapus member
        public static bool DeleteMember(int id)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Members WHERE Id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method untuk mengecek koneksi database
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
                MessageBox.Show($"Failed to connect to database: {ex.Message}", "Connection Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

