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
    public partial class FormViewAllItem : Form
    {
        public FormViewAllItem()
        {
            //InitializeComponent();
            //var service = new Service();
            //List<Item> Items = service.ListItem();
            //label1.Text = service.ListInString(Items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormViewAllItem.ActiveForm.Hide();
            FormStore MyForm2 = new FormStore();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
