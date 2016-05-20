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

        /// <summary>
        /// Gets single <see cref="Order"/> by Id
        /// </summary>
        /// <param name="id"><see cref="Order"/> Identifier</param>
        /// <returns></returns>
        Order GetOrderById(int id);

        /// <summary>
        /// Gets orders begin current date
        /// </summary>
        /// <param name="dateTime">Current date, if null then thats be today</param>
        /// <returns><see cref="Order"/> collection</returns>
        IList<Order> GetOrdersFromDate(DateTime dateTime);
    }
}
