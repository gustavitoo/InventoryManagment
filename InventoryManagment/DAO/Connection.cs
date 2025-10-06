using System.Data.SqlClient;

namespace InventoryManagment.Data
{
    public class Connection
    {
        private static string connectionString = "Data Source=.;Initial Catalog=InventoryDB;Integrated Security=True";
        // Data Source=.;Initial Catalog=InventoryDB;User ID=;Password=.

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
