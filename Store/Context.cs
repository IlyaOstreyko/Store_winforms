using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Context : DbContext
    {
        public Context()
            : base("DbConnection")
        { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
