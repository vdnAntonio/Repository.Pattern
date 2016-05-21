using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Models
{
    /// <summary>
    /// Represents <see cref="Order"/> entity
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the order id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the persone id
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the order date
        /// </summary>
        public DateTime DateTime { get; set; }


        /// <summary>
        /// Gets or sets product order
        /// </summary>
        public Product Product { get; set; }


        /// <summary>
        /// Gets or sets product id
        /// </summary>
        public int ProductId { get; set; }
    }
}
