using System.Collections.Generic;
using InventoryManagment.Models;
using InventoryManagment.DAO;

namespace InventoryManagment.Services
{
    public static class ProvidersService
    {
        public static List<Provider> GetAll() => ProvidersDAO.GetAll();
        public static void Add(Provider provider) => ProvidersDAO.Add(provider);
        public static void Update(Provider provider) => ProvidersDAO.Update(provider);
        public static void Delete(int providerId) => ProvidersDAO.Delete(providerId);
    }
}
