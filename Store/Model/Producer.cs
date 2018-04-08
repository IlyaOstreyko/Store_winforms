using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Producer
    {
        public int Id { get; set; }
        public string Name_producer { get; set; }
        public string Requisites_producer { get; set; }
        public List<int?> OrdersId { get; set; }

    }
}
