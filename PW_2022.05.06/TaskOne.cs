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
    public partial class TaskOne : Form
    {
        private TextBox? tb;

        public TaskOne()
        {
            tb = null;
            InitializeComponent();
        }

        public TaskOne(TextBox tb)
        {
            this.tb = tb;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb != null)
            {
                tb.Text = textBox1.Text;
            }
        }
    }
}
