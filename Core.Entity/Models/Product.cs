using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Models
{
    public class Product
    {
        /// <summary>
        /// Gets or sets products id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets product price
        /// </summary>
        public double Price { get; set; }
    }
}
