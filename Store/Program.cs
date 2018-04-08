using Store.Model;
using Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    var service = new Service();
        //    Item Item1 = new Item {Name = "HTC626" , Price = 150 };
        //    Item Item2 = new Item {Name = "Nokia6520", Price = 100 };
        //    List<Item> Items = new List<Item> {Item1 , Item2 };
        //    //var Store = new Store<Item> { Name = "Shop", Items = Items };
        //    service.AddItem(Items);
        //    //service.DisplayItems(Items);
        //    //var str = "6";
        //    //var search = service.SearchName(Items, str);

        //    List<Item> ItemsInDB = service.ListItem();
        //    service.DisplayItems(ItemsInDB);
        //    ////service.Delete(str);
        //    //Console.ReadLine();

        //}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStore());
        }
        
    }
    public class Notification
    {
        public string _text;
        public Notification(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new Exception();
            }
            this._text = text;
        }

        public void Show<T>(Form a) where T : Form
        {
            DialogResult result = MessageBox.Show(_text, "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                a.Hide();
                var form = Activator.CreateInstance<T>();
                form.ShowDialog();
                form.Close();
            }
            
        }


    }
    static class Data
    {
        public static int Id_selected { get; set; }
        public static string Message { get; set; }

    }
}
