namespace HW_2022._04._29
{
    public partial class Alarm : Form
    {
        private static System.Windows.Forms.Timer _timer;

        public Alarm()
        {
            InitializeComponent();
        }

        private void ShowTime(object obj, EventArgs e)
        {
            if (Convert.ToDateTime(MaskedTextBox.Text).Hour == DateTime.Now.Hour &&
                Convert.ToDateTime(MaskedTextBox.Text).Minute == DateTime.Now.Minute)
            {
                _timer.Stop();
            }
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            _timer = new();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _timer.Tick += new EventHandler(ShowTime);
            _timer.Interval = 1000;
            _timer.Start();
        }
    }
}