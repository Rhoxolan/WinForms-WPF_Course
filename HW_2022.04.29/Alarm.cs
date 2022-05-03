namespace HW_2022._04._29
{
    public partial class Alarm : Form
    {
        private static System.Windows.Forms.Timer _timer;
        private DateTime dateTime;

        public Alarm()
        {
            InitializeComponent();
        }

        private void ShowTime(object obj, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(MaskedTextBox.Text);
            DateTime dt2 = DateTime.Now;
            if (dt1.Hour == dt2.Hour && dt1.Minute == dt2.Minute)
            {
                MessageBox.Show("Да");
                _timer.Stop();
            }
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            _timer = new();
            dateTime = new();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _timer.Tick += new EventHandler(ShowTime);
            _timer.Interval = 1;
            _timer.Start();
        }
    }
}