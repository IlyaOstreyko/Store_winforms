using Store.Model;
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
    public partial class FormSearchProducer : Form
    {
        public FormSearchProducer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                var test = new Notification("Введите ключевое слово");
                test.Show<FormSearchProducer>(FormSearchProducer.ActiveForm);
            }
            else
            {
                listBox1.Items.Clear();
                var service = new ServicesProducer();
                var str = textBox1.Text;
                List<Producer> producers = service.SearchProducers(str);
                foreach (Producer producer in producers)
                {
                    listBox1.Items.Add(producer.Id + "  ||||||  Производитель: " + producer.Name_producer + "  ||||||  Ревизиты: " + producer.Requisites_producer);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSearchProducer.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Data.Id_selected = int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]);
            FormSearchProducer.ActiveForm.Hide();
            FormAddOrder MyForm2 = new FormAddOrder();
            MyForm2.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                var test = new Notification("Выберите производителя");
                test.Show<FormSearchProducer>(FormSearchProducer.ActiveForm);
            }
            else
            {
                var service = new ServicesProducer();
                service.DeleteProducer(int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]));
                var test = new Notification(Data.Message);
                test.Show<FormSearchProducer>(FormSearchProducer.ActiveForm);                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || listBox1.SelectedItem == null)
            {
                var test = new Notification("Выберите производителя");
                test.Show<FormSearchProducer>(FormSearchProducer.ActiveForm);
            }
            else
            {
                Data.Id_selected = int.Parse(listBox1.SelectedItem.ToString().Split('|')[0]);
                FormSearchProducer.ActiveForm.Hide();
                FormUpdateProducer MyForm2 = new FormUpdateProducer();
                MyForm2.ShowDialog();
                Close();
            }
        }
    }
}
