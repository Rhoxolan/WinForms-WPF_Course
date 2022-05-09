namespace HW_2022._05._04
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string Name, double Price)> price; //Коллекция для хранения видов бензина
        private double petrolSum;
        private double petrolSumLitres;
        private double cafeSum;


        public Form1()
        {
            InitializeComponent();
            petrolSum = 0;
            cafeSum = 0;
            petrolSumLitres = 0;
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
            foreach (var i in price) //Добавляем на комбоБокс виды бензина
            {
                comboBoxBenzin.Items.Add(i.Value.Name);
            }
            comboBoxBenzin.SelectedItem = "Бензин премиум";
            radioButtonAmount.Checked = true;
            SUM.Text = petrolSum.ToString("F" + 2) + " грн";

            //Кафе
            numericUpDownHotDog.Enabled = false;
            numericUpDownWater.Enabled = false;
            numericUpDownSomeOther.Enabled = false;
            numericUpDownBeer.Enabled = false;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " грн";
        }

        private void comboBoxBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in price)
            {
                if (comboBoxBenzin.SelectedItem.ToString() == i.Value.Name)
                {
                    textBoxBenzinPrice.Text = i.Value.Price.ToString();
                    if (!String.IsNullOrEmpty(textBoxInputBenzinLitres.Text)) //Также меняем вывод цены при смене выбранного вида бензина
                    {
                        SUM.Text = petrolSum.ToString("F" + 2) + " грн.";
                    }
                    if (!String.IsNullOrEmpty(textBoxInputBenzinPrice.Text))
                    {
                        SUM.Text = petrolSumLitres.ToString("F" + 2) + " л.";
                    }
                    break;
                }
            }
        }

        private void radioButtonAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAmount.Checked)
            {
                textBoxInputBenzinPrice.Enabled = false;
                textBoxInputBenzinLitres.Enabled = true;
                groupBoxPetrolChecksum.Text = "К оплате";
                petrolSum = 0;
                SUM.Text = petrolSum.ToString("F" + 2) + " грн.";
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
                    if (comboBoxBenzin.SelectedItem.ToString() == i.Value.Name)
                    {
                        petrolSum = Convert.ToDouble(textBoxInputBenzinLitres.Text) * i.Value.Price;
                        SUM.Text = petrolSum.ToString("F" + 2) + " грн.";
                        break;
                    }
                }
            }
            catch
            {
                petrolSum = 0;
                SUM.Text = petrolSum.ToString("F" + 2) + " грн.";
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
                        petrolSumLitres = Convert.ToDouble(textBoxInputBenzinPrice.Text) / i.Value.Price;
                        petrolSum = petrolSumLitres * i.Value.Price;
                        SUM.Text = petrolSumLitres.ToString("F" + 2) + " л.";
                        break;
                    }
                }
            }
            catch
            {
                petrolSumLitres = 0;
                petrolSum = 0;
                SUM.Text = petrolSumLitres.ToString("F" + 2) + " л.";
            }
        }

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked)
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
            if (checkBoxBeer.Checked)
            {
                numericUpDownBeer.Enabled = true;
            }
            else
            {
                numericUpDownBeer.Enabled = false;
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
            //Вверху вроде сделано, единственное при изменение вида бензина цена остается старая
        }
    }
}