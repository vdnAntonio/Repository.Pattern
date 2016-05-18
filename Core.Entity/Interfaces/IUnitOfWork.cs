using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository People { get; }
        IOrderRepository Orders { get; }
        int Complete();
    }
}
