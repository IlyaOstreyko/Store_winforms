
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Date_request { get; set; }
        public string Name_production { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<int?> ProducersId { get; set; }
        public string Price_producer { get; set; }
        public string Price { get; set; }
        public string Payment { get; set; }
        public DateTime Date_delivery { get; set; }
        public string StatusPayment { get; set; }
        public string Status { get; set; }
    }
}
