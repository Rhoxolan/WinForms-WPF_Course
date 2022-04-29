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
            using (FileStream fs = new(Path.Combine(docPath, "personInfo.bin"), FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<PersonInfo?>(fs, personInfo);
            }
            MessageBox.Show("Данные успешно внесены!");
        }

        private void LoadNReadClick_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (FileStream fs = new(Path.Combine(docPath, "personInfo.bin"), FileMode.OpenOrCreate))
            {
                personInfo = JsonSerializer.Deserialize<PersonInfo>(fs);
            }
        }
    }
}