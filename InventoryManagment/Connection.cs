using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventoryManagment.DAO
{
    internal class Connection
    {
        private static string connection = "Server=localhost;Database=inventory_managment;Uid=root;Pwd=;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connection);
        }
    }
}