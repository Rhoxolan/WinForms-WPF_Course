using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_2022._05._09
{
    public partial class Form2 : Form
    {
        private TextBox? parentalTextBox;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(TextBox textBox)
        {
            parentalTextBox = textBox;  //Ссылка на ТекстБокс вызывающей (родительской) формы
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (parentalTextBox != null)
            {
                parentalTextBox.Text = "";
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (parentalTextBox != null)
            {
                parentalTextBox.Text = textBox1.Text;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
