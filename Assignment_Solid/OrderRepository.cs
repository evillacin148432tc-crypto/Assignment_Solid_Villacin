using System.Data.SqlClient;

namespace Assignment_Solid
{
    public class OrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Save(string email, decimal total)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();
            using var cmd = new SqlCommand("INSERT INTO Orders (Email, Total) VALUES (@e, @t)", conn);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@t", total);
            cmd.ExecuteNonQuery();
        }
    }
}