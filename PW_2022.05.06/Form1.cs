namespace PW_2022._05._06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTaskOne_Click(object sender, EventArgs e)
        {
            textBoxTaskOne.Enabled = true;
            TaskOne taskOne = new TaskOne(textBoxTaskOne);
            taskOne.Show();
        }
    }
}