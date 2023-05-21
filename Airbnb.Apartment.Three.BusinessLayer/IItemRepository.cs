namespace Airbnb.Apartment.Three.BusinessLayer
{
    public interface IItemRepository
    {
        string Create(string ItemName, int quantity, double price, string boughtFrom);

        string UpdateTotalSum();
        double GetTotalSum();
        List<string> GetItems();

    }
}

