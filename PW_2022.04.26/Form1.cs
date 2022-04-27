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
            if(e.X > 10 && e.Y > 10)
            {
                MessageBox.Show("Больше 10-и");
            }
            else
            {
                MessageBox.Show("Меньше 10-и");
            }
        }
    }
}