namespace Airbnb.Apartment.Three.BusinessLayer
{
    public static class Quries
    {
       public const string InsertItem = "INSERT INTO Items (ItemName, Quantity, Price, PlaceFrom) VALUES (@itemName, @quantity, @price, @placeFrom)";
       public const string UpdateTotalSum = "UPDATE Items_Sum SET TotalSum = (SELECT SUM(TotalPrice) FROM Items);";
       public const string GetTotalSum = "SELECT TotalSum FROM Items_Sum";
       public const string GetAllItems = "SELECT ItemName FROM Items";
    }
}
