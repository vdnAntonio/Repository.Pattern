using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Models
{
    /// <summary>
    /// Represents <see cref="Person"/> entity
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the person id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the person gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the person First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the person Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the person Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the person IpAddress
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the Order Id
        /// </summary>
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or sets the person Orders
        /// </summary>
        public IList<Order> Orders { get; set; }

        public Person()
        {
            Orders = new List<Order>();
        }
    }
}
