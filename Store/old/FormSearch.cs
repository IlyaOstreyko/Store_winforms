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
using System.Windows.Forms;

namespace Store
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    FormSearch.ActiveForm.Hide();
            //    var MyForm2 = new FormSearch();
            //    MyForm2.ShowDialog();
            //    Close();

            //}
            //else
            //{
            //    var service = new Service();
            //    var str = textBox1.Text;
            //    label2.Text = service.ListInString(service.SearchName(str));
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSearch.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
