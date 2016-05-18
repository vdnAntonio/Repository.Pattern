using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Core.Entity.Interfaces;
using Core.Entity.Models;

namespace Core.Entity.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private PlutoContext PlutoContext => Context as PlutoContext;
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Product> MostExpensiveProduct(int count)
        {
            var maxPrice = PlutoContext.Products.Max(price => price.Price);

            return PlutoContext.Products
                .Where(p => Math.Abs(p.Price - maxPrice) < p.Price)
                .Take(count)
                .OrderByDescending(d => d.Price)
                .ToList();
        }
    }
}
