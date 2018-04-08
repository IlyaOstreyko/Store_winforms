using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    class ServicesOrder
    {
        //public List<Order> SearchOrder(string str)
        //{
        //    using (var db = new Context())
        //    {
        //        var orders = db.Orders.Where(dborder => dborder.Name_customer.Contains(str));
        //        return orders.ToList();
        //    }
        //}
        //public void AddOrders(ICollection<Order> Orders)
        //{
        //    using (var db = new Context())
        //    {
        //        foreach (Order order in Orders)
        //        {
        //            order.Date_request = DateTime.Now;
        //            db.Orders.Add(order);
        //            db.SaveChanges();
        //            Data.Message = "Заказ успешно сохранен";
        //        }
        //    }
        //}
        public void AddOrder(Order order)
        {
            using (var db = new Context())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                Data.Message = "Заказ успешно сохранен";
            }
        }


        //public string OrdersInString(ICollection<Order> Orders)
        //{
        //    var str = "";
        //    foreach (Order order in Orders)
        //    {
        //        str = str + order.Id + " " + order.Customer + order.Date_request + order.Name_production + order.payment + order.+ "\n";
        //    }
        //    return str;
        //}
        public void DeleteOrder(int id)
        {
            using (var db = new Context())
            {
                var order = db.Orders.Where(dborder => dborder.Id == id);
                if (order != null)
                {
                    db.Orders.RemoveRange(order);
                    db.SaveChanges();
                    Data.Message = "Объект успешно удален";
                }
            }
        }

        public void UpdateCustomer(Order order)
        {
            using (var db = new Context())
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                Data.Message = "Объект успешно изменен";
            }
        }

        public Order GetOrderOnId(int id)
        {

            using (var db = new Context())
            {

                return db.Orders.Find(id);
            }
        }

    }
}
