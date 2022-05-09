namespace HW_2022._05._04
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string Name, double Price)> price; //Коллекция для хранения видов бензина

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //АЗС
            price = new Dictionary<string, (string name, double price)>()
            {
                ["Бензин премиум"] = ("Бензин премиум", 95),
                ["Бензин люкс"] = ("Бензин люкс", 80),
                ["Бензин стандарт"] = ("Бензин стандарт", 70),
                ["Бензин эконом"] = ("Бензин эконом", 50),
                ["Самогон"] = ("Самогон", 35)
            };
            foreach(var i in price) //Добавляем на комбоБокс виды бензина
            {
                comboBoxBenzin.Items.Add(i.Value.Name);
            }
            comboBoxBenzin.SelectedItem = "Бензин премиум";
            radioButtonAmount.Checked = true;

            //Кафе
            numericUpDownHotDog.Enabled = false;
            numericUpDownWater.Enabled = false;
            numericUpDownSomeOther.Enabled = false;
            numericUpDownBeer.Enabled = false;

        }

        private void comboBoxBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in price)
            {
                if(comboBoxBenzin.SelectedItem.ToString() == i.Value.Name)
                {
                    textBoxBenzinPrice.Text = i.Value.Price.ToString();
                    if(!String.IsNullOrEmpty(textBoxInputBenzinLitres.Text)) //Также меняем вывод цены при смене выбранного вида бензина
                    {
                        SUM.Text = (Convert.ToDouble(textBoxInputBenzinLitres.Text) * i.Value.Price).ToString() + " грн.";
                    }
                    if (!String.IsNullOrEmpty(textBoxInputBenzinPrice.Text))
                    {
                        SUM.Text = (Convert.ToDouble(textBoxInputBenzinPrice.Text) / i.Value.Price).ToString() + " л.";
                    }
                    break;
                }
            }
        }

        private void radioButtonAmount_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAmount.Checked)
            {
                textBoxInputBenzinPrice.Enabled = false;
                textBoxInputBenzinLitres.Enabled = true;
                groupBoxPetrolChecksum.Text = "К оплате";
                SUM.Text = "0 грн";
            }
        }

        private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrice.Checked)
            {
                textBoxInputBenzinLitres.Enabled = false;
                textBoxInputBenzinPrice.Enabled = true;
                groupBoxPetrolChecksum.Text = "К выдаче";
                SUM.Text = "0 л.";
            }
        }

        private void textBoxInputBenzinLitres_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var i in price)
                {
                    if(comboBoxBenzin.SelectedItem.ToString() == i.Value.Name)
                    {
                        SUM.Text = (Convert.ToDouble(textBoxInputBenzinLitres.Text) * i.Value.Price).ToString() + " грн.";
                        break;
                    }
                }
            }
            catch
            {
                SUM.Text = "0 грн";
            }
        }

        private void textBoxInputBenzinPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var i in price)
                {
                    if (comboBoxBenzin.SelectedItem.ToString() == i.Value.Name)
                    {
                        SUM.Text = (Convert.ToDouble(textBoxInputBenzinPrice.Text) / i.Value.Price).ToString("F" + 2) + " л.";
                        break;
                    }
                }
            }
            catch
            {
                SUM.Text = "0 л";
            }
        }

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHotDog.Checked)
            {
                numericUpDownHotDog.Enabled = true;
            }
            else
            {
                numericUpDownHotDog.Enabled = false;
            }
        }

        private void checkBoxBeer_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBeer.Checked)
            {
                numericUpDownBeer.Enabled = true;
            }
            else
            {
                numericUpDownBeer.Enabled= false;
            }
        }

        private void checkBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWater.Checked)
            {
                numericUpDownWater.Enabled = true;
            }
            else
            {
                numericUpDownWater.Enabled = false;
            }
        }

        private void checkBoxSomeOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSomeOther.Checked)
            {
                numericUpDownSomeOther.Enabled = true;
            }
            else
            {
                numericUpDownSomeOther.Enabled = false;
            }
        }

        private void numericUpDownHotDog_ValueChanged(object sender, EventArgs e)
        {
            CAFESUM.Text = (Convert.ToDecimal(CAFESUM.Text) + (numericUpDownHotDog.Value * 27)).ToString("F" + 2);
            //Ты тут. Создать переменные с суммами и оперировать ими. Решить проблему с обнулением цены.
        }
    }
}