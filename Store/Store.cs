using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Store<T>
    {
        public string Name { get; set; }
        public ICollection<T> Orders { get; set; }
        public ICollection<T> Customers { get; set; }
        public ICollection<T> Producers { get; set; }
    }
}
