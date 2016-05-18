using Core.Entity.Models;

namespace Core.Entity.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetPersonWithOrders(int id);
    }
}
