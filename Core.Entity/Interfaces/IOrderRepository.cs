using System;
using System.Collections.Generic;
using Core.Entity.Models;

namespace Core.Entity.Interfaces
{
    /// <summary>
    /// Represents <see cref="Order"/> repository
    /// </summary>
    public interface IOrderRepository : IRepository<Order>
    {
        /// <summary>
        /// Get <see cref="Order"/> collection with top prices
        /// </summary>
        /// <param name="count">Count collection</param>
        /// <returns><see cref="Order"/> collection descending by price</returns>
        [Obsolete("GetTopPrice is deprecated")]
        IEnumerable<Order> GetTopPrice(int count);


        Order GetOrderById(int id);
    }
}
