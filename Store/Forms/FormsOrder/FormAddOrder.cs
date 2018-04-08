using Store.Model;
using Store.Services;
using Store.Services.ServicesCustomer;
using Store.Services.ServicesProducer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Store
{
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
            var servicesCustomer = new ServicesCustomer();
            var servicesProducer = new ServicesProducer();
            var customer = servicesCustomer.GetCustomerOnId(Data.Id_selected);
            textBox1.Text = customer.Name_customer;
            checkedListBox1.Items.Clear();
            List<Producer> producers = servicesProducer.AllProducers();
            foreach (Producer producer in producers)
            {
                checkedListBox1.Items.Add(producer.Id + "  ||||||  Производитель: " + producer.Name_producer + "  ||||||  Ревизиты: " + producer.Requisites_producer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                var test = new Notification("Заполните все поля");
                test.Show<FormAddOrder>(FormAddOrder.ActiveForm);
            }
            else
            {
                var servicesOrder = new ServicesOrder();
                var servicesCustomer = new ServicesCustomer();
                var servicesProducer = new ServicesProducer();
                var customer = servicesCustomer.GetCustomerOnId(Data.Id_selected);
                var checkedButtonST = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
                var checkedButtonPay = groupPayment.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
                var listIdSelectedProducer = new List<int?>();
                foreach (object listCheckedItems in checkedListBox1.CheckedItems)
                {
                    listIdSelectedProducer.Add(int.Parse(listCheckedItems.ToString().Split('|')[0]));
                }
                //List<Producer> producersSelected = servicesProducer.GetProducersOnId(listIdSelectedProducer);
                Order order = new Order { CustomerId = customer.Id, Date_request = DateTime.Now, Date_delivery = dateTimePicker1.Value, Status = checkedButtonST.Text, StatusPayment = checkedButtonPay.Text, Name_production = textBox2.Text, Price = textBoxPrice.Text, Payment = textBoxPayment.Text, Price_producer = textBoxPriceProducer.Text, ProducersId = listIdSelectedProducer };
                //order.ProducersId = listIdSelectedProducer;
                //foreach (int id in listIdSelectedProducer)
                //{
                //    order.ProducersId.Add(id);
                //}
                servicesOrder.AddOrder(order);
                //customer.OrdersId = listIdSelectedProducer;
                servicesCustomer.UpdateCustomer(customer);
                //foreach (Producer producer in producersSelected)
                //{
                //    producer.OrdersId.Add(order.Id);
                //    servicesProducer.UpdateProducer(producer);
                //}
                var test = new Notification("Заказ успешно сохранен");
                test.Show<FormStore>(FormAddOrder.ActiveForm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddOrder.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
