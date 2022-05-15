using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2022._05._09
{
    public partial class ChildForm : Form
    {
        private string BufferText;

        public ChildForm()
        {
            InitializeComponent();
        }

        //Вырезание текста
        public void Cut()
        {
            this.BufferText = ChildTextBox.SelectedText;
            ChildTextBox.SelectedText = "";
        }

        //копирование текста
        public void Copy()
        {
            this.BufferText = ChildTextBox.SelectedText;
        }

        // вставка
        public void Paste()
        {
            ChildTextBox.SelectedText = this.BufferText;
        }

        // выделение всего текста - используем свойство Selectall элемента управления RichTextBox
        public void SelectAll()
        {
            ChildTextBox.SelectAll();
        }
        // Удаление
        public void Delete()
        {
            ChildTextBox.SelectedText = "";
            this.BufferText = "";
        }

        private void ТoggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ТoggleMenuItem.Checked)
            {
                ТoggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ТoggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
