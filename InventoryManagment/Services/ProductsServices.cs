using System.Collections.Generic;
using InventoryManagment.Models;
using InventoryManagment.DAO;

namespace InventoryManagment.Services
{
    public static class ProductsService
    {
        public static List<Product> GetAll() => ProductsDAO.GetAll();

        public static void Add(Product product) => ProductsDAO.Add(product);

        public static void Update(Product product) => ProductsDAO.Update(product);

        public static void Delete(int productId) => ProductsDAO.Delete(productId);
    }
}
