using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Interfaces;
using Core.Entity.Repositories;

namespace Core.Entity
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            People = new PeopleRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IPersonRepository People { get; }
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get;}
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
