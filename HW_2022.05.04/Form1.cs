using System.Text;

namespace HW_2022._05._04
{
    public partial class Form1 : Form
    {
        private class CafeProduct //Класс для хранения данных о товаре
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public double TotalPrice { get; set; }
            public CafeProduct(string name, double price, double totalPrice)
            {
                Name = name;
                Price = price;
                TotalPrice = totalPrice;
            }
        }

        private Dictionary<string, (string Name, double Price)> price; //Коллекция для хранения видов бензина
        private Dictionary<string, CafeProduct> cafePrices; //Коллекция для хранения товаров в кафе
        private double petrolSum;
        private double petrolSumLitres;
        private double cafeSum;
        private double totalSum;
        private List<Cheque> cheques;
        private static System.Windows.Forms.Timer _timer; //Таймер для вывода запроса об очистке формы

        public Form1()
        {
            InitializeComponent();
            cheques = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer = new();
            petrolSum = 0;
            cafeSum = 0;
            petrolSumLitres = 0;
            totalSum = 0;

            //АЗС
            price = new Dictionary<string, (string name, double price)>()
            {
                ["Бензин премиум"] = ("Бензин премиум", 95),
                ["Бензин люкс"] = ("Бензин люкс", 80),
                ["Бензин стандарт"] = ("Бензин стандарт", 70),
                ["Бензин эконом"] = ("Бензин эконом", 50),
                ["Самогон"] = ("Самогон", 35)
                //В коллекцию price мы можем добавлять новые виды бензина, либо же редактировать или удалять
                //имеющиеся. Изменения в коде проводить не нужно, все автоматизировано.
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
            cafePrices = new Dictionary<string, CafeProduct>()
            {
                ["Хот-Дог"] = new("Хот-Дог", 27, 0),
                ["Пиво"] = new("Пиво", 30, 0),
                ["Вода"] = new("Вода", 10, 0),
                ["Я от шерифа"] = new("Я от шерифа", 100, 0)
            };
            checkBoxHotDog.Text = cafePrices["Хот-Дог"].Name;
            checkBoxBeer.Text = cafePrices["Пиво"].Name;
            checkBoxWater.Text = cafePrices["Вода"].Name;
            checkBoxSomeOther.Text = cafePrices["Я от шерифа"].Name;
            textBoxHotDogPrice.Text = cafePrices["Хот-Дог"].Price.ToString();
            textBoxBeerPrice.Text = cafePrices["Пиво"].Price.ToString();
            textBoxWaterPrice.Text = cafePrices["Вода"].Price.ToString();
            textBoxSomeOtherPrice.Text = cafePrices["Я от шерифа"].Price.ToString();

            labelTotalSum.Text = totalSum.ToString("F" + 2) + " грн";
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
                        petrolSum = Convert.ToDouble(textBoxInputBenzinLitres.Text) * i.Value.Price;
                        SUM.Text = petrolSum.ToString("F" + 2) + " грн.";
                    }
                    if (!String.IsNullOrEmpty(textBoxInputBenzinPrice.Text))
                    {
                        petrolSumLitres = Convert.ToDouble(textBoxInputBenzinPrice.Text) / i.Value.Price;
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
                textBoxInputBenzinPrice.Text = "";
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
                textBoxInputBenzinLitres.Text = "";
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
                numericUpDownHotDog.Value = 0;
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
                numericUpDownBeer.Value = 0;
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
                numericUpDownWater.Value = 0;
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
                numericUpDownSomeOther.Value = 0;
                numericUpDownSomeOther.Enabled = false;
            }
        }

        private void numericUpDownHotDog_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["Хот-Дог"].TotalPrice = cafePrices["Хот-Дог"].Price * (double)numericUpDownHotDog.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " грн";
        }

        private void numericUpDownBeer_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["Пиво"].TotalPrice = cafePrices["Пиво"].Price * (double)numericUpDownBeer.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " грн";
        }

        private void numericUpDownWater_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["Вода"].TotalPrice = cafePrices["Вода"].Price * (double)numericUpDownWater.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " грн";
        }

        private void numericUpDownSomeOther_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["Я от шерифа"].TotalPrice = cafePrices["Я от шерифа"].Price * (double)numericUpDownSomeOther.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " грн";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            totalSum = cafeSum + petrolSum;
            labelTotalSum.Text = totalSum.ToString("F" + 2) + " грн";
            cheques.Add(new(DateTime.Now, totalSum));
            _timer.Tick += _timer_Tick;
            _timer.Interval = 10000;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            if(MessageBox.Show("Очистить форму?", "Очистка формы", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1_Load(null, null);
            }
            else
            {
                _timer.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder showChecks = new();
            foreach(var i in cheques)
            {
                showChecks.AppendLine(i.ToString());
            }
            if (!String.IsNullOrEmpty(showChecks.ToString()))
            {
                MessageBox.Show(showChecks.ToString(), "Чеки за эту сессию");
            }
        }

        private void buttonCleaned_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            Form1_Load(null, null);
        }
    }

    internal record Cheque(DateTime CheckTime, double CheckSum) //Запись для зранения данных чека
    {
        public override string ToString()
        {
            return $"{CheckTime}: {CheckSum} UAH";
        }
    }
}