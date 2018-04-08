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

namespace Store.Forms.FormsProducer
{
    public partial class FormUpdateProducer : Form
    {
        public FormUpdateProducer()
        {
            InitializeComponent();
            var service = new ServicesProducer();
            var producer = service.GetProducerOnId(Data.Id_selected);
            textBox1.Text = producer.Name_producer;
            textBox2.Text = producer.Requisites_producer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                var test = new Notification("Заполните все поля");
                test.Show<FormUpdateProducer>(FormUpdateProducer.ActiveForm);
            }
            else
            {
                var service = new ServicesProducer();
                var producer = service.GetProducerOnId(Data.Id_selected);
                producer.Name_producer = textBox1.Text;
                producer.Requisites_producer = textBox2.Text.ToString();
                service.UpdateProducer(producer);
                var test = new Notification(Data.Message);
                test.Show<FormStore>(FormUpdateProducer.ActiveForm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUpdateProducer.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
