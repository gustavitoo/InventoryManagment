using InventoryManagment.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryManagment.DAO
{
    public static class ProvidersDAO
    {
        public static List<Provider> GetAll()
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                try
                {
                    con.Open();
                    string sql = "SELECT ProviderId, Name, ContactName, Phone, Email, Address FROM Providers";

                    var list = new List<Provider>();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Provider
                            {
                                ProviderId = reader.GetInt32(reader.GetOrdinal("ProviderId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                ContactName = reader.GetString(reader.GetOrdinal("ContactName")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address"))
                            });
                        }
                    }

                    return list;
                } catch (SqlException)
                {
                    return new List<Provider>();
                }
            }
        }

        public static void Add(Provider provider)
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Providers (Name, ContactName, Phone, Email, Address)
                               VALUES (@Name, @ContactName, @Phone, @Email, @Address)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Name", provider.Name);
                    cmd.Parameters.AddWithValue("@ContactName", provider.ContactName);
                    cmd.Parameters.AddWithValue("@Phone", provider.Phone);
                    cmd.Parameters.AddWithValue("@Email", provider.Email);
                    cmd.Parameters.AddWithValue("@Address", provider.Address);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Provider provider)
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                con.Open();
                string sql = @"UPDATE Providers
                               SET Name=@Name, ContactName=@ContactName, Phone=@Phone, Email=@Email, Address=@Address
                               WHERE ProviderId=@ProviderId";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Name", provider.Name);
                    cmd.Parameters.AddWithValue("@ContactName", provider.ContactName);
                    cmd.Parameters.AddWithValue("@Phone", provider.Phone);
                    cmd.Parameters.AddWithValue("@Email", provider.Email);
                    cmd.Parameters.AddWithValue("@Address", provider.Address);
                    cmd.Parameters.AddWithValue("@ProviderId", provider.ProviderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int providerId)
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM Providers WHERE ProviderId=@ProviderId";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ProviderId", providerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
