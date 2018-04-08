using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    class Service
    {        
        //public void DisplayItems(ICollection<Order> Orders)
        //{
        //    foreach (Order order in Orders)
        //    {
        //        Console.WriteLine(order.Name_organization + " (Price: " + order.Price + ")");
        //    }
        //}

        //public string ListInString(ICollection<Item> Items)
        //{
        //    var str = "";
        //    foreach (Item item in Items)
        //    {
        //        str = str + item.Id + " " + item.Name + " (Price: " + item.Price + ")" + "\n";
        //    }
        //    return str;
        //}

        //public void AddItem(ICollection<Item> Items)
        //{
        //    using (var db = new Context())
        //    {
        //        foreach (Item item in Items)
        //        {
        //            db.Items.Add(item);
        //            db.SaveChanges();
        //        }
        //    }
        //    Console.WriteLine("Объекты успешно сохранены");
        //}

        //public List<Item> ListItem()
        //{
        //    using (var db = new Context())
        //    {
        //        List<Item> MyItems = db.Items.ToList();
        //        return MyItems;
        //    }
        //}

        //public List<Item> SearchName(string str)
        //{
        //    using (var db = new Context())
        //    {
        //        var items = db.Items.Where(dbitem => dbitem.Name.Contains(str));
        //        return items.ToList();
        //    }
        //}

        //public void Delete(int id)
        //{
        //    using (var db = new Context())
        //    {
        //        //var items = db.Items.Where(dbitem => dbitem.Name.Contains(str));
        //        var items = db.Items.Where(dbitem => dbitem.Id == id);
        //        if (items != null)
        //        {
        //            db.Items.RemoveRange(items);
        //            db.SaveChanges();
        //        }
        //    }
        //}
    }
}
