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

namespace Store.Forms.FormsCustomer
{
    public partial class FormUpdateCustomer : Form
    {
        public FormUpdateCustomer()
        {
            InitializeComponent();
            var service = new ServicesCustomer();
            var customer = service.GetCustomerOnId(Data.Id_selected);
            textBox1.Text = customer.Name_customer;
            textBox2.Text = customer.Requisites_customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                var test = new Notification("Заполните все поля");
                test.Show<FormUpdateCustomer>(FormUpdateCustomer.ActiveForm);
            }
            else
            {
                var service = new ServicesCustomer();
                var customer = service.GetCustomerOnId(Data.Id_selected);
                customer.Name_customer = textBox1.Text;
                customer.Requisites_customer = textBox2.Text.ToString();
                service.UpdateCustomer(customer);
                var test = new Notification(Data.Message);
                test.Show<FormStore>(FormUpdateCustomer.ActiveForm);       
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddCustomer.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
