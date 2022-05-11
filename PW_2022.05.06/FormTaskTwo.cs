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
    public partial class FormTaskTwo : Form
    {
        private TextBox? tb;

        public FormTaskTwo()
        {
            tb = null;
            InitializeComponent();
        }

        public FormTaskTwo(TextBox tb)
        {
            this.tb = tb;
            InitializeComponent();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (tb != null)
            {
                tb.Text = $"{textBoxFullName.Text}, {numericUpDownYear.Value.ToString()} г.р. " +
                    $"{numericUpDownHeight.Value.ToString()} см.";
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
