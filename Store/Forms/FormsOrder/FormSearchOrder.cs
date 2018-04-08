using Store.Model;
using Store.Services.ServicesCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms.FormsOrder
{
    public partial class FormSearchOrder : Form
    {
        public FormSearchOrder()
        {
            InitializeComponent();
            ServicesCustomer service = new ServicesCustomer();
            List<Customer> customers = service.SearchCustomers("т");
            for (int i = 0; i < customers.Count; i++)
            {

                TextBox b = textBox1;
                TextBox Name_customer = new TextBox();
                Name_customer.Width = 300;
                Name_customer.Height = 72;
                Name_customer.ScrollBars = ScrollBars.Both;
                Name_customer.ReadOnly = true;
                Name_customer.Multiline = true;
                Name_customer.Text = customers[i].Name_customer;
                TextBox Requisites_customer = new TextBox();
                Requisites_customer.Width = 300;
                Requisites_customer.Height = 72;
                Requisites_customer.ReadOnly = true;
                Requisites_customer.Multiline = true;
                Requisites_customer.ScrollBars = ScrollBars.Both;
                Requisites_customer.Text = customers[i].Requisites_customer;
                Name_customer.Location = new Point(b.Location.X, b.Location.Y + b.Height + 5 + (72 + 5) * i);
                Requisites_customer.Location = new Point(Name_customer.Location.X + Name_customer.Width + 5, b.Location.Y + b.Height + 5 + (72 + 5) * i);
                this.Controls.Add(Name_customer);
                this.Controls.Add(Requisites_customer);
            }
        }
    }
}
