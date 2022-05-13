namespace PW_2022._05._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Text Files(*.txt)|*.txt"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(ofd.FileName);
                textBoxTextRedactor.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                Filter = "Text Files(*.txt)|*.txt"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);
                writer.Write(textBoxTextRedactor.Text);
                writer.Close();
            }
        }
    }
}