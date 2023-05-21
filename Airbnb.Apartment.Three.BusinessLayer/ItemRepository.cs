

namespace Airbnb.Apartment.Three.BusinessLayer
{
    using Airbnb.Apartment.Three.BusinessLayer.Exceptions;
    using Airbnb.Apartment.Three.BusinessLayer.Utilities;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    public class ItemRepository : IItemRepository
    {
      
        public string Create(string itemName, int quantity, double price, string boughtFrom)
        {
            using var connection = new SqlConnection(Configuration.ConnectionString);
            connection.Open();

            var query = connection.CreateCommand();

            query.CommandText = Quries.InsertItem;
            query.CommandType = CommandType.Text;

            query.Parameters.AddWithValue("@itemName", itemName);
            query.Parameters.AddWithValue("@quantity", quantity);
            query.Parameters.AddWithValue("@price", price);
            query.Parameters.AddWithValue("@placeFrom", boughtFrom);
            
            var affectedRows = query.ExecuteNonQuery();
            if (affectedRows == 0)
                return InvalidExceptions.UpdatingTableWithParams;
            return string.Format(SuccessfulMessages.AddingToTable, itemName, quantity, price, boughtFrom);
        }

        public string UpdateTotalSum()
        {
            using var connection = new SqlConnection(Configuration.ConnectionString);
            connection.Open();

            var query = connection.CreateCommand();

            query.CommandText = Quries.UpdateTotalSum;
            query.CommandType = CommandType.Text;
            var affectedRows = query.ExecuteNonQuery();
            return affectedRows == 0 ? InvalidExceptions.UpdatingTableWithParams : SuccessfulMessages.UpdateTable;
        }
        public double GetTotalSum()
        {
            using var connection = new SqlConnection(Configuration.ConnectionString);
            connection.Open();

            var query = connection.CreateCommand();

            query.CommandText = Quries.GetTotalSum;
            query.CommandType = CommandType.Text;
            var sum = (double)query.ExecuteScalar();
            return sum;
        }

        public List<string> GetItems()
        {
            using var connection = new SqlConnection(Configuration.ConnectionString);
            connection.Open();
            var items = new List<string>();
            var query = connection.CreateCommand();

            query.CommandText = Quries.GetAllItems;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                items.Add(reader["ItemName"].ToString());
            }
            return items;
        }
        
    }
}
