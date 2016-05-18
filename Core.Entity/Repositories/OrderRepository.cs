﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Interfaces;
using Core.Entity.Models;

namespace Core.Entity.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public PlutoContext PlutoContext => Context as PlutoContext;
        public OrderRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Order> GetTopPrice(int count)
        {
            return PlutoContext.Orders.Include(q => q.Product).OrderByDescending(q => q.Product.Price).Take(count).ToList();
        }

        public Order GetOrderById(int id)
        {
            return PlutoContext.Orders.SingleOrDefault(q => q.Id == id);
        }
    }
}
