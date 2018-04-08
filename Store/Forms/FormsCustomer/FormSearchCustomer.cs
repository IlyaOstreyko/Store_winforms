using Store.Forms.FormsCustomer;
using Store.Model;
using Store.Services;
using Store.Services.ServicesCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Store
{
    public partial class FormSearchCustomer : Form
    {
        ServicesCustomer service = new ServicesCustomer();
        public FormSearchCustomer()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                var test = new Notification("Введите ключевое слово");
                test.Show<FormSearchCustomer>(FormSearchCustomer.ActiveForm);

            }
            else
            {
                listBox1.Items.Clear();
                var str = textBox1.Text;
                List<Customer> customers = service.SearchCustomers(str);
                foreach (Customer customer in customers)
                {
                    listBox1.Items.Add(customer.Id + "  |||  Название организации: " + customer.Name_customer + "  |||  Реквизиты: " + customer.Requisites_customer);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSearchCustomer.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Data.Id_selected = int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]);
            FormSearchCustomer.ActiveForm.Hide();
            FormAddOrder MyForm2 = new FormAddOrder();
            MyForm2.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                var test = new Notification("Выберите заказчика");
                test.Show<FormSearchCustomer>(FormSearchCustomer.ActiveForm);
            }
            else
            {                
                service.DeleteCustomer(int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]));
                var test = new Notification(Data.Message);
                test.Show<FormSearchCustomer>(FormSearchCustomer.ActiveForm);           
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                var test = new Notification("Выберите заказчика");
                test.Show<FormSearchCustomer>(FormSearchCustomer.ActiveForm);
            }
            else
            {
                Data.Id_selected = int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]);
                FormSearchCustomer.ActiveForm.Hide();
                FormUpdateCustomer MyForm2 = new FormUpdateCustomer();
                MyForm2.ShowDialog();
                Close();
            }
        }
    }
}
