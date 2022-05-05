using System.Xml.Serialization;
using System.Text.Json;
using System.Collections;

namespace PW_2022._05._02
{
    public partial class Form1 : Form
    {
        private string docPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && SurnameTextBox.Text.Length > 0 &&
                EmailTextBox.Text.Length > 0 && PhoneNumberTextBox.Text.Length > 0)
            {
                ListBoxForm.Items.Add(new Person(NameTextBox.Text, SurnameTextBox.Text, EmailTextBox.Text,
                PhoneNumberTextBox.Text));
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (ListBoxForm.SelectedIndex != -1)
            {
                ListBoxForm.Items.RemoveAt(ListBoxForm.SelectedIndex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ListBoxForm.SelectedIndex != -1)
            {
                ListBoxForm.Items[ListBoxForm.SelectedIndex] = new Person(NameTextBox.Text, SurnameTextBox.Text, EmailTextBox.Text,
                PhoneNumberTextBox.Text);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ArrayList al = new(ListBoxForm.Items);
            //Попробовать это сериализовать

            //Отлично сериализуется
            //using (FileStream fs = new(Path.Combine(docPath, "personInfo.json"), FileMode.Create))
            //{
            //    JsonSerializer.Serialize(fs, ListBoxForm.Items);
            //}

            //Попробовать десиаризовать в аррей лист, затем привязать к листбоксу
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Person(string name, string surname, string email, string phone)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, {Email} {Phone}";
        }
    }
}