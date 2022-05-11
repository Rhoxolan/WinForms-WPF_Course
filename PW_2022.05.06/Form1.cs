using System.ComponentModel;

namespace PW_2022._05._06
{
    public partial class Form1 : Form
    {
        private BindingList<Product>? products;

        public Form1()
        {
            products = null;
            InitializeComponent();
        }

        private void buttonTaskOne_Click(object sender, EventArgs e)
        {
            textBoxTaskOne.Enabled = true;
            TaskOne taskOne = new TaskOne(textBoxTaskOne);
            taskOne.Show();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            textBoxTaskTwo.Enabled = true;
            FormTaskTwo formTaskTwo = new FormTaskTwo(textBoxTaskTwo);
            formTaskTwo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = new();
            listBoxTaskThree.DataSource = products;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct addProduct = new(products);
            addProduct.ShowDialog();
            listBoxTaskThree.Refresh();
        }
    }

    public record Product(string Name, double Price)
    {
        public override string ToString()
        {
            return Name + " " + Price;
        }
    }
}