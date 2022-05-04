using System.Media;

namespace HW_2022._04._29
{
    public partial class Alarm : Form
    {
        private static System.Windows.Forms.Timer _timer;
        private SoundPlayer player;

        public Alarm()
        {
            InitializeComponent();
        }

        private void ShowTime(object obj, EventArgs e)
        {
            try
            {
                TimeSpan ts = Convert.ToDateTime(MaskedTextBox.Text) - DateTime.Now;
                Timer.Text = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
                if (Convert.ToDateTime(MaskedTextBox.Text).Hour == DateTime.Now.Hour &&
                    Convert.ToDateTime(MaskedTextBox.Text).Minute == DateTime.Now.Minute)
                {
                    _timer.Stop();
                    Timer.Text = "00:00:00";
                    //
                    player = new();
                    player.SoundLocation = "alarm.wav";
                    player.Play();
                    player.Stop();
                    //
                }
            }
            catch
            {
                _timer.Stop();
                Timer.Text = "00:00:00";
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

        private void StopButton_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            Timer.Text = "00:00:00";
        }
    }
}