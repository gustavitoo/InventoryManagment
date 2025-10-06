using InventoryManagment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryManagment.DAO
{
    internal class ProductsDAO
    {
        public static List<Product> GetAll()
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                try
                {
                    var list = new List<Product>();

                    con.Open();
                    string sql = @"SELECT p.ProductId, p.Name, p.Category, p.Stock, 
                                          p.UnitPrice, p.CostPrice, p.ProviderId, 
                                          pr.Name AS ProviderName
                                   FROM Products p
                                   LEFT JOIN Providers pr ON p.ProviderId = pr.ProviderId";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Product
                            {
                                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Category = reader.GetString(reader.GetOrdinal("Category")),
                                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                                CostPrice = reader.GetDecimal(reader.GetOrdinal("CostPrice")),
                                ProviderId = reader.IsDBNull(reader.GetOrdinal("ProviderId")) ? 0 : reader.GetInt32(reader.GetOrdinal("ProviderId")),
                                ProviderName = reader.IsDBNull(reader.GetOrdinal("ProviderName")) ? "N/A" : reader.GetString(reader.GetOrdinal("ProviderName"))
                            });
                        }
                    }
                    return list;
                }
                catch (SqlException)
                {
                    return new List<Product>();
                }
            }
        }

        public static void Add(Product prod)
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Products (Name, Category, UnitPrice, CostPrice, Stock, ProviderId)
                               VALUES (@name, @category, @unitPrice, @costPrice, @stock, @prov)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", prod.Name);
                    cmd.Parameters.AddWithValue("@category", prod.Category);
                    cmd.Parameters.AddWithValue("@unitPrice", prod.UnitPrice);
                    cmd.Parameters.AddWithValue("@costPrice", prod.CostPrice);
                    cmd.Parameters.AddWithValue("@stock", prod.Stock);
                    cmd.Parameters.AddWithValue("@prov", prod.ProviderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Product prod)
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                con.Open();
                string sql = @"UPDATE Products 
                               SET Name=@name, Category=@category, UnitPrice=@unitPrice, 
                                   CostPrice=@costPrice, Stock=@stock, ProviderId=@prov 
                               WHERE ProductId=@id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
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
        }

        public static void Delete(int id)
        {
            using (var con = InventoryManagment.Data.Connection.GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM Products WHERE ProductId=@id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
