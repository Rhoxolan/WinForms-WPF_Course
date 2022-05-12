using System.Text;

namespace HW_2022._05._06
{
    public partial class Form1 : Form
    {
        private class CafeProduct //����� ��� �������� ������ � ������
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

        private Dictionary<string, (string Name, double Price)> price; //��������� ��� �������� ����� �������
        private Dictionary<string, CafeProduct> cafePrices; //��������� ��� �������� ������� � ����
        private double petrolSum;
        private double petrolSumLitres;
        private double cafeSum;
        private double totalSum;
        private List<Cheque> cheques;
        private static System.Windows.Forms.Timer _timer; //������ ��� ������ ������� �� ������� �����

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

            //���
            price = new Dictionary<string, (string name, double price)>()
            {
                ["������ �������"] = ("������ �������", 95),
                ["������ ����"] = ("������ ����", 80),
                ["������ ��������"] = ("������ ��������", 70),
                ["������ ������"] = ("������ ������", 50),
                ["�������"] = ("�������", 35)
                //� ��������� price �� ����� ��������� ����� ���� �������, ���� �� ������������� ��� �������
                //���������. ��������� � ���� ��������� �� �����, ��� ����������������.
            };
            foreach (var i in price) //��������� �� ��������� ���� �������
            {
                comboBoxBenzin.Items.Add(i.Value.Name);
            }
            comboBoxBenzin.SelectedItem = "������ �������";
            radioButtonAmount.Checked = true;
            SUM.Text = petrolSum.ToString("F" + 2) + " ���";

            //����
            numericUpDownHotDog.Enabled = false;
            numericUpDownWater.Enabled = false;
            numericUpDownSomeOther.Enabled = false;
            numericUpDownBeer.Enabled = false;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " ���";
            cafePrices = new Dictionary<string, CafeProduct>()
            {
                ["���-���"] = new("���-���", 27, 0),
                ["����"] = new("����", 30, 0),
                ["����"] = new("����", 10, 0),
                ["� �� ������"] = new("� �� ������", 100, 0)
            };
            checkBoxHotDog.Text = cafePrices["���-���"].Name;
            checkBoxBeer.Text = cafePrices["����"].Name;
            checkBoxWater.Text = cafePrices["����"].Name;
            checkBoxSomeOther.Text = cafePrices["� �� ������"].Name;
            textBoxHotDogPrice.Text = cafePrices["���-���"].Price.ToString();
            textBoxBeerPrice.Text = cafePrices["����"].Price.ToString();
            textBoxWaterPrice.Text = cafePrices["����"].Price.ToString();
            textBoxSomeOtherPrice.Text = cafePrices["� �� ������"].Price.ToString();

            labelTotalSum.Text = totalSum.ToString("F" + 2) + " ���";
        }

        private void comboBoxBenzin_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in price)
            {
                if (comboBoxBenzin.SelectedItem.ToString() == i.Value.Name)
                {
                    textBoxBenzinPrice.Text = i.Value.Price.ToString();
                    if (!String.IsNullOrEmpty(textBoxInputBenzinLitres.Text)) //����� ������ ����� ���� ��� ����� ���������� ���� �������
                    {
                        petrolSum = Convert.ToDouble(textBoxInputBenzinLitres.Text) * i.Value.Price;
                        SUM.Text = petrolSum.ToString("F" + 2) + " ���.";
                    }
                    if (!String.IsNullOrEmpty(textBoxInputBenzinPrice.Text))
                    {
                        petrolSumLitres = Convert.ToDouble(textBoxInputBenzinPrice.Text) / i.Value.Price;
                        SUM.Text = petrolSumLitres.ToString("F" + 2) + " �.";
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
                groupBoxPetrolChecksum.Text = "� ������";
                petrolSum = 0;
                SUM.Text = petrolSum.ToString("F" + 2) + " ���.";
            }
        }

        private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrice.Checked)
            {
                textBoxInputBenzinLitres.Text = "";
                textBoxInputBenzinLitres.Enabled = false;
                textBoxInputBenzinPrice.Enabled = true;
                groupBoxPetrolChecksum.Text = "� ������";
                SUM.Text = "0 �.";
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
                        SUM.Text = petrolSum.ToString("F" + 2) + " ���.";
                        break;
                    }
                }
            }
            catch
            {
                petrolSum = 0;
                SUM.Text = petrolSum.ToString("F" + 2) + " ���.";
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
                        SUM.Text = petrolSumLitres.ToString("F" + 2) + " �.";
                        break;
                    }
                }
            }
            catch
            {
                petrolSumLitres = 0;
                petrolSum = 0;
                SUM.Text = petrolSumLitres.ToString("F" + 2) + " �.";
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
            cafePrices["���-���"].TotalPrice = cafePrices["���-���"].Price * (double)numericUpDownHotDog.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " ���";
        }

        private void numericUpDownBeer_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["����"].TotalPrice = cafePrices["����"].Price * (double)numericUpDownBeer.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " ���";
        }

        private void numericUpDownWater_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["����"].TotalPrice = cafePrices["����"].Price * (double)numericUpDownWater.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " ���";
        }

        private void numericUpDownSomeOther_ValueChanged(object sender, EventArgs e)
        {
            cafePrices["� �� ������"].TotalPrice = cafePrices["� �� ������"].Price * (double)numericUpDownSomeOther.Value;
            double totalPrice = 0;
            foreach (var i in cafePrices)
            {
                totalPrice += i.Value.TotalPrice;
            }
            cafeSum = totalPrice;
            CAFESUM.Text = cafeSum.ToString("F" + 2) + " ���";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            totalSum = cafeSum + petrolSum;
            labelTotalSum.Text = totalSum.ToString("F" + 2) + " ���";
            cheques.Add(new(DateTime.Now, totalSum));
            _timer.Tick += _timer_Tick;
            _timer.Interval = 10000;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            if (MessageBox.Show("�������� �����?", "������� �����", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            foreach (var i in cheques)
            {
                showChecks.AppendLine(i.ToString());
            }
            if (!String.IsNullOrEmpty(showChecks.ToString()))
            {
                MessageBox.Show(showChecks.ToString(), "���� �� ��� ������");
            }
        }

        private void buttonCleaned_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            Form1_Load(null, null);
        }
    }

    internal record Cheque(DateTime CheckTime, double CheckSum) //������ ��� �������� ������ ����
    {
        public override string ToString()
        {
            return $"{CheckTime}: {CheckSum} UAH";
        }
    }
}