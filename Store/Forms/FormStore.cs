using Store.Forms.FormsOrder;
using Store.Forms.FormsProducer;
using Store.Model;
using Store.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Store
{
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();
        }
     

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormStore.ActiveForm.Hide();
            var MyForm2 = new FormAddCustomer();
            MyForm2.ShowDialog();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormStore.ActiveForm.Hide();
            var MyForm2 = new FormSearchCustomer();
            MyForm2.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormStore.ActiveForm.Hide();
            var MyForm2 = new FormAddProducer();
            MyForm2.ShowDialog();
            Close();
        }

        private void search_producer_Click(object sender, EventArgs e)
        {
            FormStore.ActiveForm.Hide();
            var MyForm2 = new FormSearchProducer();
            MyForm2.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStore.ActiveForm.Hide();
            var MyForm2 = new FormSearchOrder();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
