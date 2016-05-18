using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Interfaces;
using Core.Entity.Models;

namespace Core.Entity.Repositories
{
    public class PeopleRepository : Repository<Person>, IPersonRepository
    {
        public PlutoContext PlutoContext => Context as PlutoContext;
        public PeopleRepository(DbContext context) : base(context)
        {
        }

        public Person GetPersonWithOrders(int id)
        {
            return PlutoContext.People.Include(o => o.Orders).Include("Orders.Product").SingleOrDefault(a => a.Id == id);
        }
    }
}
