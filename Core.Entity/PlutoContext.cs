using System.Data.Entity;
using Core.Entity.Models;

namespace Core.Entity
{
    public class PlutoContext : DbContext
    {
        public PlutoContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}
