using Store.Forms.FormsCustomer;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.ServicesCustomer
{
    class ServicesCustomer
    {
        public List<Customer> SearchCustomers(string str)
        {
            using (var db = new Context())
            {
                //var timer = new Stopwatch();
                //timer.Start();
                var customers = db.Customers.Where(dbcustomer => dbcustomer.Name_customer.Contains(str));
                //timer.Stop();
                if (customers.Count() == 0)
                {
                    var test = new Notification("Ничего не найдено");
                    test.Show<FormSearchCustomer>(FormSearchCustomer.ActiveForm);
                    return customers.ToList();
                }
                else
                {
                    return customers.ToList();
                }                
            }
        }
        public void AddCustomer(Customer customer)
        {
            using (var db = new Context())
            {
                var services = new ServicesCustomer();
                var list = db.Customers.Where(dbcustomer => dbcustomer.Name_customer == customer.Name_customer);
                if (list.Count() == 0)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    Data.Message = "Объект успешно сохранен";
                }
                else
                {
                    Data.Message = "Такой заказчик уже существует";
                }
            }
        }
        //public void AddCustomers(ICollection<Customer> Customers)
        //{
        //    using (var db = new Context())
        //    {
        //        foreach (Customer customer in Customers)
        //        {
        //            var services = new ServicesCustomer();
        //            var list = db.Customers.Where(dbcustomer => dbcustomer.Name_customer == customer.Name_customer);
        //            if (list.Count() == 0)
        //            {
        //                db.Customers.Add(customer);
        //                db.SaveChanges();
        //                Data.Message = "Объект успешно сохранен";
        //            }
        //            else
        //            {
        //                Data.Message = "Такой заказчик уже существует";
        //            }                    
        //        }
        //    }
        //}

        public string CustomersInString(ICollection<Customer> Customers)
        {
            var str = "";
            foreach (Customer customer in Customers)
            {
                str = str + customer.Id + " " + customer.Name_customer + " (Реквизиты: " + customer.Requisites_customer + ")" + "\n";
            }
            return str;
        }
        public void DeleteCustomer(int id)
        {
            using (var db = new Context())
            {
                var castomer = db.Customers.Where(dbcastomer => dbcastomer.Id == id);
                if (castomer != null)
                {
                    db.Customers.RemoveRange(castomer);
                    db.SaveChanges();
                    Data.Message = "Объект успешно удален";
                }
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            using (var db = new Context())
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                Data.Message = "Объект успешно изменен";
            }
        }

        public Customer GetCustomerOnId(int id)
        {

            using (var db = new Context())
            {

                return db.Customers.Find(id);
            }
        }
    }
}
