using Core.Entity.Models;

namespace Core.Entity.Interfaces
{
    /// <summary>
    /// Represents <see cref="Person"/> repository
    /// </summary>
    public interface IPersonRepository : IRepository<Person>
    {
        /// <summary>
        /// Gte single <see cref="Person"/> by Id
        /// </summary>
        /// <param name="id"><see cref="Person"/> Identifier</param>
        /// <returns>Single <see cref="Person"/></returns>
        Person GetPersonWithOrders(int id);
    }
}
