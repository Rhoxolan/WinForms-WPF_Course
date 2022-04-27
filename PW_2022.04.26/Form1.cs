namespace PW_2022._04._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            const int string_count = 3;
            string str1 = "Бацемакин Павел";
            string str2 = "C# developer";
            string str3 = "Компьютерная академия ШАГ, г. Кривой Рог";
            int stringcount = (str1.Length + str2.Length + str3.Length) / string_count;
            MessageBox.Show(str1, "Резюме");
            MessageBox.Show(str2, "Резюме");
            MessageBox.Show($"{str3}{Environment.NewLine}(В резюме {stringcount} символов.)", "Резюме");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (e.X > 10 && e.Y > 10 &&
                e.Y < (this.Height - 50) && e.X < (this.Width - 50))
                {
                    //MessageBox.Show("Попали в квадрат", "Нажатие мышкой",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Попали в квадрат");
                }
                else if (e.X == 10 || e.Y == 10 ||
                e.Y == (this.Height - 50) || e.X == (this.Width - 50))
                {
                    //MessageBox.Show("Вы нажали на границу квадрата", "Нажатие мышкой",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Вы нажали на границу квадрата");
                }
                else
                {
                    //MessageBox.Show("Не попали в квадрат", "Нажатие мышкой",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Не Попали в квадрат");
                }
            }
        }
    }
}