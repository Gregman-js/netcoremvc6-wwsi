using Domain;

namespace Persistence;

public class OrdersRepository
{
    private readonly List<Order> _database;

    public OrdersRepository()
    {
        _database = new List<Order>();
    }

    public void Insert(Order order)
    {
        _database.Add(order);
    }

    public List<Order> GetAll()
    {
        return _database;
    }
}