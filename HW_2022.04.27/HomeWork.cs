namespace HW_2022._04._27
{
    public partial class HomeWork : Form
    {
        private Random random;

        public HomeWork()
        {
            random = new();
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что вы так думаете!");
        }

        private void NoButton_MouseEnter(object sender, EventArgs e)
        {
            NoButton.Top = random.Next(ClientSize.Height - NoButton.Height);
            NoButton.Left = random.Next(ClientSize.Width - NoButton.Width);
        }
    }
}