using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Interfaces
{
    /// <summary>
    /// Abtraction layer between functional and database context
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets <see cref="People"/> context
        /// </summary>
        IPersonRepository People { get; }

        /// <summary>
        /// Gets <see cref="Orders"/> context
        /// </summary>
        IOrderRepository Orders { get; }

        /// <summary>
        /// Gets <see cref="Products"/> context
        /// </summary>
        IProductRepository Products { get; }
        int Complete();
    }
}
