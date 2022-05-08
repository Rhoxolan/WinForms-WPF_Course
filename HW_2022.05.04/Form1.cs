namespace HW_2022._05._04
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> price;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            price = new Dictionary<string, double>()
            {
                ["Бензин премиум"] = 95,
                ["Бензин люкс"] = 80,
                ["Бензин стандарт"] = 70,
                ["Бензин эконом"] = 50,
                ["Самогон"] = 35
            };
            comboBoxBenzin.SelectedItem = "Бензин премиум";
        }

        private void comboBoxBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBenzin.SelectedItem.ToString() == "Бензин премиум")
            {
                textBoxBenzinPrice.Text = price["Бензин премиум"].ToString();
            }
            else if (comboBoxBenzin.SelectedItem.ToString() == "Бензин люкс")
            {
                textBoxBenzinPrice.Text = price["Бензин люкс"].ToString();
            }
            else if (comboBoxBenzin.SelectedItem.ToString() == "Бензин стандарт")
            {
                textBoxBenzinPrice.Text = price["Бензин стандарт"].ToString();
            }
            else if (comboBoxBenzin.SelectedItem.ToString() == "Бензин эконом")
            {
                textBoxBenzinPrice.Text = price["Бензин эконом"].ToString();
            }
            else if (comboBoxBenzin.SelectedItem.ToString() == "Самогон")
            {
                textBoxBenzinPrice.Text = price["Самогон"].ToString();
            }
        }
    }
}