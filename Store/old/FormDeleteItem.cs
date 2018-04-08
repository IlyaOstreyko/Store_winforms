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
    public partial class FormDeleteItem : Form
    {
        public FormDeleteItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDeleteItem.ActiveForm.Hide();
            if(textBox1.Text == "")
            {
                var MyForm2 = new FormDeleteItem();
                MyForm2.ShowDialog();
                Close();

            }
            else
            {
                //var service = new Service();
                //service.Delete(Convert.ToInt32(textBox1.Text));
                //var MyForm2 = new FormStore();
                //MyForm2.ShowDialog();
                //Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDeleteItem.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
