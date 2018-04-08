using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Customer
    {
        public int Id { get; set; }
        public string Name_customer { get; set; }
        public string Requisites_customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
        public override string ToString()
        {
            return Name_customer;
        }
    }
}
