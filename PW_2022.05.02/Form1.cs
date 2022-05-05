using System.Xml.Serialization;
using System.Text.Json;
using System.Collections;

namespace PW_2022._05._02
{
    public partial class Form1 : Form
    {
        private string docPath;
        List<Person>? l2;

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
            //https://metanit.com/sharp/tutorial/6.4.php

            List<Person> l = new();
            foreach (var i in ListBoxForm.Items)
            {
                l.Add(i as Person);
            }
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(Path.Combine(docPath, "personInfo.xml"), FileMode.Create))
            {
                formatter.Serialize(fs, l);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            l2 = null;
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(Path.Combine(docPath, "personInfo.xml"), FileMode.OpenOrCreate))
            {
                l2 = formatter.Deserialize(fs) as List<Person>;
            }
            //Привязка данных (менять элементы мы уже не сможем!)
            ListBoxForm.DataSource = l2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Person() { }

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