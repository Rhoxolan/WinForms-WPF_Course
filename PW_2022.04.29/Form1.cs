using System.Text;
using System.Data;

namespace PW_2022._04._29
{
    public partial class Calculator : Form
    {
        private bool isEqualsOut;

        public Calculator()
        {
            InitializeComponent();
            isEqualsOut = false;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "1";
            }
            else
            {
                TextBox.Text = "1";
                isEqualsOut = true;
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "2";
            }
            else
            {
                TextBox.Text = "2";
                isEqualsOut = true;
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "3";
            }
            else
            {
                TextBox.Text = "3";
                isEqualsOut = true;
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "4";
            }
            else
            {
                TextBox.Text = "4";
                isEqualsOut = true;
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "5";
            }
            else
            {
                TextBox.Text = "5";
                isEqualsOut = true;
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "6";
            }
            else
            {
                TextBox.Text = "6";
                isEqualsOut = true;
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "7";
            }
            else
            {
                TextBox.Text = "7";
                isEqualsOut = true;
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "8";
            }
            else
            {
                TextBox.Text = "8";
                isEqualsOut = true;
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "9";
            }
            else
            {
                TextBox.Text = "9";
                isEqualsOut = true;
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "0";
            }
            else
            {
                TextBox.Text = "0";
                isEqualsOut = true;
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "+";
            }
            else
            {
                TextBox.Text = "+";
                isEqualsOut = true;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "-";
            }
            else
            {
                TextBox.Text = "-";
                isEqualsOut = true;
            }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "*";
            }
            else
            {
                TextBox.Text = "*";
                isEqualsOut = true;
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += "/";
            }
            else
            {
                TextBox.Text = "/";
                isEqualsOut = true;
            }
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (isEqualsOut)
            {
                TextBox.Text += ".";
            }
            else
            {
                TextBox.Text = ".";
                isEqualsOut = true;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), TextBox.Text);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                TextBox.Text = (string)row["expression"];
                isEqualsOut = false;
            }
            catch
            {
                TextBox.Text = "Ошибка ввода! Пожалуйста, проверьте корректность ввода";
                isEqualsOut = false;
            }
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length != 0)
            {
                StringBuilder sb = new(TextBox.Text);
                sb.Remove(sb.Length - 1, 1);
                TextBox.Text = sb.ToString();
            }
        }

        //Меняем последний знак
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new(TextBox.Text);
            for (int i = TextBox.Text.Length - 1; i >= 0; i--)
            {
                if (sb[i] == '+')
                {
                    sb[i] = '-';
                    TextBox.Text = sb.ToString();
                    break;
                }
                if (sb[i] == '-')
                {
                    sb[i] = '+';
                    TextBox.Text = sb.ToString();
                    break;
                }
            }
        }
    }
}