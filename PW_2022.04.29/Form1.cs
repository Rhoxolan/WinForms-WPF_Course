using System.Text;

namespace PW_2022._04._29
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "+";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "-";
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "*";
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "/";
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += ",";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] operands = TextBox.Text.Split('+', '-', '*', '/');
                int rightoperand = 1;
                decimal sum = Convert.ToDecimal(operands[0]);
                foreach(var o in TextBox.Text)
                {
                    if(o == '+')
                    {
                        sum += Convert.ToDecimal(operands[rightoperand]);
                        rightoperand++;
                        continue;
                    }
                    if (o == '-')
                    {
                        sum -= Convert.ToDecimal(operands[rightoperand]);
                        rightoperand++;
                        continue;
                    }
                    if (o == '*')
                    {
                        sum *= Convert.ToDecimal(operands[rightoperand]);
                        rightoperand++;
                        continue;
                    }
                    if (o == '/')
                    {
                        sum /= Convert.ToDecimal(operands[rightoperand]);
                        rightoperand++;
                        continue;
                    }
                }
                TextBox.Text = sum.ToString();
            }
            catch
            {
                TextBox.Text = "Ошибка ввода! Проверьте, пожалуйста, строку на корректность ввода.";
            }
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new(TextBox.Text);
            sb.Remove(sb.Length - 1, 1);
            TextBox.Text = sb.ToString();
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