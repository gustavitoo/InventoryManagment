using InventoryManagment.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.DAO
{
    internal class ProductsDAO
    {
        public static List<Product> GetAll()
        {
            var lista = new List<Product>();
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "SELECT p.ProductId, p.Name, p.Category, p.Stock, p.UnitPrice, p.CostPrice, p.ProviderId, pr.Name AS ProviderName " +
                             "FROM products p LEFT JOIN providers pr ON p.ProviderId = pr.ProviderId";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Product
                    {
                        ProductId = reader.GetInt32("ProductId"),
                        Name = reader.GetString("Name"),
                        Category = reader.GetString("Category"),
                        Stock = reader.GetInt32("Stock"),
                        UnitPrice = reader.GetDecimal("UnitPrice"),
                        CostPrice = reader.GetDecimal("CostPrice"),
                        ProviderId = reader.IsDBNull(reader.GetOrdinal("ProviderId")) ? 0 : reader.GetInt32("ProviderId"),
                        ProviderName = reader.IsDBNull(reader.GetOrdinal("ProviderName")) ? "N/A" : reader.GetString("ProviderName")
                    });
                }
            }
            return lista;
        }

        public static void Add(Product prod)
        {
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "INSERT INTO products (Name, Category, UnitPrice, CostPrice, Stock, ProviderId) " +
                             "VALUES (@name, @category, @unitPrice, @costPrice, @stock, @prov)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", prod.Name);
                cmd.Parameters.AddWithValue("@category", prod.Category);
                cmd.Parameters.AddWithValue("@unitPrice", prod.UnitPrice);
                cmd.Parameters.AddWithValue("@costPrice", prod.CostPrice);
                cmd.Parameters.AddWithValue("@stock", prod.Stock);
                cmd.Parameters.AddWithValue("@prov", prod.ProviderId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Product prod)
        {
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "UPDATE products SET Name=@name, Category=@category, UnitPrice=@unitPrice, " +
                             "CostPrice=@costPrice, Stock=@stock, ProviderId=@prov WHERE ProductId=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", prod.Name);
                cmd.Parameters.AddWithValue("@category", prod.Category);
                cmd.Parameters.AddWithValue("@unitPrice", prod.UnitPrice);
                cmd.Parameters.AddWithValue("@costPrice", prod.CostPrice);
                cmd.Parameters.AddWithValue("@stock", prod.Stock);
                cmd.Parameters.AddWithValue("@prov", prod.ProviderId);
                cmd.Parameters.AddWithValue("@id", prod.ProductId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(int id)
        {
            using (var con = Connection.GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM products WHERE ProductId=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
