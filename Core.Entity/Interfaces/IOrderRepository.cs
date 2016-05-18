using System.Collections.Generic;
using Core.Entity.Models;

namespace Core.Entity.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetTopPrice(int count);

        Order GetOrderById(int id);
    }
}
