using Store.Forms.FormsProducer;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.ServicesProducer
{
    class ServicesProducer
    {
        public void DeleteProducer(int id)
        {
            using (var db = new Context())
            {
                var producers = db.Producers.Where(dbproducers => dbproducers.Id == id);
                if (producers != null)
                {
                    db.Producers.RemoveRange(producers);
                    db.SaveChanges();
                    Data.Message = "Объект успешно удален";
                }
            }
        }
        public void UpdateProducer(Producer producer)
        {
            using (var db = new Context())
            {
                db.Entry(producer).State = EntityState.Modified;
                db.SaveChanges();
                Data.Message = "Объект успешно изменен";
            }
        }
        public void AddProducer(Producer producer)
        {
            using (var db = new Context())
            {
                var services = new ServicesProducer();
                var list = db.Producers.Where(dbproducer => dbproducer.Name_producer == producer.Name_producer);
                if (list.Count() == 0)
                {
                    db.Producers.Add(producer);
                    db.SaveChanges();
                    Data.Message = "Объект успешно сохранен";
                }
                else
                {
                    Data.Message = "Такой производитель уже существует";
                }
            }
        }
        //public void AddProducers(ICollection<Producer> Producers)
        //{
        //    using (var db = new Context())
        //    {
        //        foreach (Producer producer in Producers)
        //        {
        //            var services = new ServicesProducer();
        //            var list = db.Producers.Where(dbproducer => dbproducer.Name_producer == producer.Name_producer);
        //            if (list.Count() == 0)
        //            {
        //                db.Producers.Add(producer);
        //                db.SaveChanges();
        //                Data.Message = "Объект успешно сохранен";
        //            }
        //            else
        //            {
        //                Data.Message = "Такой производитель уже существует";
        //            }                  
        //        }
        //    }
        //}
        public Producer GetProducerOnId(int id)
        {
            using (var db = new Context())
            {
                return db.Producers.Find(id);
            }
        }
        public List<Producer> GetProducersOnId(List<int> id)
        {
            var listProducers = new List<Producer>();
            using (var db = new Context())
            {
                foreach (int a in id)
                {
                    listProducers.Add(db.Producers.Find(a));
                }                
            }
            return listProducers;
        }
        public List<Producer> SearchProducers(string str)
        {
            using (var db = new Context())
            {
                var producers = db.Producers.Where(dbproducer => dbproducer.Name_producer.Contains(str));
                if (producers.Count() == 0)
                {
                    var test = new Notification("Ничего не найдено");
                    test.Show<FormSearchProducer>(FormSearchProducer.ActiveForm);
                    return producers.ToList();
                }
                else
                {
                    return producers.ToList();
                }
            }
        }
        public List<Producer> AllProducers()
        {
            using (var db = new Context())
            {
                var producers = new List<Producer>();
                foreach (Producer producer in db.Producers)
                {
                    producers.Add(producer);
                }
                return producers.ToList();
            }
        }
        public string ProducersInString(ICollection<Producer> Producers)
        {
            var str = "";
            foreach (Producer producer in Producers)
            {
                str = str + producer.Id + " " + producer.Name_producer + " (Реквизиты: " + producer.Requisites_producer + ")" + "\n";
            }
            return str;
        }
    }
}
