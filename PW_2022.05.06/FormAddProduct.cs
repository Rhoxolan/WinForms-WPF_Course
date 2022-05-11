using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_2022._05._06
{
    public partial class FormAddProduct : Form
    {
        private BindingList<Product>? products;
        int SelectedIndex = -1;

        public FormAddProduct()
        {
            products = null;
            InitializeComponent();
        }

        public FormAddProduct(BindingList<Product>? products)
        {
            this.products = products;
            InitializeComponent();
        }

        public FormAddProduct(BindingList<Product>? products, int index)
        {
            this.products = products;
            this.SelectedIndex = index;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (SelectedIndex != -1 && products != null)
            {
                products[SelectedIndex] = new(textBoxName.Text, (double)numericUpDownPrice.Value);
            }
            else if (products != null)
            {
                products.Add(new(textBoxName.Text, (double)numericUpDownPrice.Value));
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
