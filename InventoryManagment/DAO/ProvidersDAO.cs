using MySql.Data.MySqlClient;
using InventoryManagment.Models;
using System.Collections.Generic;

namespace InventoryManagment.DAO
{
    public static class ProvidersDAO
    {
        public static List<Provider> GetAll()
        {
            var lista = new List<Provider>();
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "SELECT ProviderId, Name, ContactName, Phone, Email, Address FROM providers";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Provider
                    {
                        ProviderId = reader.GetInt32("ProviderId"),
                        Name = reader.GetString("Name"),
                        ContactName = reader.GetString("ContactName"),
                        Phone = reader.GetString("Phone"),
                        Email = reader.GetString("Email"),
                        Address = reader.GetString("Address")
                    });
                }
            }
            return lista;
        }

        public static void Add(Provider provider)
        {
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "INSERT INTO providers (Name, ContactName, Phone, Email, Address) VALUES (@Name, @ContactName, @Phone, @Email, @Address)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", provider.Name);
                cmd.Parameters.AddWithValue("@ContactName", provider.ContactName);
                cmd.Parameters.AddWithValue("@Phone", provider.Phone);
                cmd.Parameters.AddWithValue("@Email", provider.Email);
                cmd.Parameters.AddWithValue("@Address", provider.Address);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Provider provider)
        {
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "UPDATE providers SET Name=@Name, ContactName=@ContactName, Phone=@Phone, Email=@Email, Address=@Address WHERE ProviderId=@ProviderId";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", provider.Name);
                cmd.Parameters.AddWithValue("@ContactName", provider.ContactName);
                cmd.Parameters.AddWithValue("@Phone", provider.Phone);
                cmd.Parameters.AddWithValue("@Email", provider.Email);
                cmd.Parameters.AddWithValue("@Address", provider.Address);
                cmd.Parameters.AddWithValue("@ProviderId", provider.ProviderId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(int providerId)
        {
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM providers WHERE ProviderId=@ProviderId";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ProviderId", providerId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
