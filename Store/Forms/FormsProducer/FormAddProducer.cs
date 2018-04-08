using Store.Model;
using Store.Services;
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

namespace Store
{
    public partial class FormAddProducer : Form
    {
        public FormAddProducer()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                var test = new Notification("Заполните все поля");
                test.Show<FormAddProducer>(FormAddProducer.ActiveForm);
            }
            else
            {
                var service = new ServicesProducer();
                Producer producer = new Producer { Name_producer = textBox1.Text.ToString(), Requisites_producer = textBox2.Text.ToString() };
                service.AddProducer(producer);
                var test = new Notification(Data.Message);
                test.Show<FormStore>(FormAddProducer.ActiveForm);              
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormAddProducer.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
