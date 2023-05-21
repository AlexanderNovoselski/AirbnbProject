namespace Airbnb.Apartment.Three.BusinessLayer
{
    using System.Data;
    using System.Data.SqlClient;

    public static class Extension
    {
        public static void ExecuteSqlCommand(string connectionString, string queryString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = connection.CreateCommand();
                query.CommandText = queryString;
                query.CommandType = CommandType.Text;
                query.ExecuteNonQuery();
            }
        }
    }
}
