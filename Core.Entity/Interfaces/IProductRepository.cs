using System.Collections.Generic;
using Core.Entity.Models;

namespace Core.Entity.Interfaces
{
    /// <summary>
    /// Represents <see cref="Product"/> repository
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
        /// <summary>
        /// Get <see cref="Product"/> collection that have most expensive price
        /// </summary>
        /// <param name="count">Count return collection</param>
        /// <returns><see cref="Product"/> collection descending by price</returns>
        IEnumerable<Product> MostExpensiveProduct(int count);
    }
}
