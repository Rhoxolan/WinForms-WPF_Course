using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace PW_2022._04._27
{
    record PersonInfo(string? Name, string? Surname, string? Patronymic, byte? Gender, DateTime? Date_Time,
        byte? MaritalStatus, string? AddInfo);

    public partial class Practical_Work : Form
    {
        private PersonInfo? personInfo;

        public Practical_Work()
        {
            personInfo = null;
            InitializeComponent();
        }

        private void SaveClick_Click(object sender, EventArgs e)
        {
            byte? gender = null;
            if (checkBox1.Checked)
            {
                gender = 1;
            }
            if (checkBox2.Checked)
            {
                gender = 2;
            }
            byte? marital_status = null;
            if (checkBox3.Checked)
            {
                marital_status = 1;
            }
            if (checkBox4.Checked)
            {
                marital_status = 2;
            }
            DateTime? date = dateTimePicker1.Value;
            personInfo = new(textBox1.Text, textBox2.Text, textBox3.Text, gender, date, marital_status,
                textBox4.Text);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (FileStream fs = new(Path.Combine(docPath, "personInfo.json"), FileMode.Create))
            {
                JsonSerializer.Serialize<PersonInfo?>(fs, personInfo);
            }
            MessageBox.Show("Данные успешно внесены!");
        }

        private void LoadNReadClick_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (FileStream fs = new(Path.Combine(docPath, "personInfo.json"), FileMode.OpenOrCreate))
            {
                personInfo = JsonSerializer.Deserialize<PersonInfo?>(fs);
            }

            string? gender = null, marital_status = null;
            if (personInfo.Gender == 1)
            {
                gender = "Муж";
            }
            if (personInfo.Gender == 2)
            {
                gender = "Жен";
            }
            if (personInfo.MaritalStatus == 1)
            {
                marital_status = "Замужем (женат)";
            }
            if (personInfo.MaritalStatus == 2)
            {
                marital_status = "Свободен(на)";
            }
            MessageBox.Show($"Имя: {personInfo.Name}{Environment.NewLine}" +
                $"Фамилия: {personInfo.Surname}{Environment.NewLine}" +
                $"Отчество: {personInfo.Patronymic}{Environment.NewLine}" +
                $"Пол: {gender}{Environment.NewLine}" +
                $"Дата рождения: {personInfo.Date_Time}{Environment.NewLine}" +
                $"Семейное положение: {marital_status}{Environment.NewLine}" +
                $"Дополнительная информация: {personInfo.AddInfo}{Environment.NewLine}",
                "Информация");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
            }
            if (!checkBox1.Checked)
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
            }
            if (!checkBox2.Checked)
            {
                checkBox1.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Enabled = false;
            }
            if (!checkBox3.Checked)
            {
                checkBox4.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Enabled = false;
            }
            if (!checkBox4.Checked)
            {
                checkBox3.Enabled = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(new(Convert.ToInt32(YearBox.Text), Convert.ToInt32(MonthBox.Text),
                Convert.ToInt32(DayBox.Text)));
        }
    }
}