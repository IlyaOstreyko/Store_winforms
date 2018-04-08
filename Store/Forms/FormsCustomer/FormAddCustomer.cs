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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                var test = new Notification("Заполните все поля");
                test.Show<FormAddCustomer>(FormAddCustomer.ActiveForm);
            }
            else
            {
                var service = new ServicesCustomer();
                Customer customer = new Customer { Name_customer = textBox1.Text.ToString(), Requisites_customer = textBox2.Text.ToString() };
                service.AddCustomer(customer);
                var test = new Notification(Data.Message);
                test.Show<FormStore>(FormAddCustomer.ActiveForm);           
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
