using System.Media;
using WMPLib;

namespace HW_2022._04._29
{
    public partial class Alarm : Form
    {
        private static System.Windows.Forms.Timer _timer;
        private SoundPlayer player;
        private WindowsMediaPlayer wmplayer;
        private Settings settings; //Вторая форма для настроек
        private string docPath;

        public Alarm()
        {
            InitializeComponent();
        }

        private void ShowTime(object obj, EventArgs e)
        {
            try
            {
                TimeSpan ts = Convert.ToDateTime(MaskedTextBox.Text) - DateTime.Now;
                if (ts < TimeSpan.Zero)
                {
                    Timer.Text = $"{ts.Hours + 24}:{ts.Minutes + 60}:{ts.Seconds + 60}";
                }
                else
                {
                    Timer.Text = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
                }
                if (Convert.ToDateTime(MaskedTextBox.Text).Hour == DateTime.Now.Hour &&
                    Convert.ToDateTime(MaskedTextBox.Text).Minute == DateTime.Now.Minute)
                {
                    _timer.Stop();
                    Timer.Text = "00:00:00";
                    if(settings.WMPEnabled())
                    {
                        wmplayer.URL = Path.Combine(docPath, "alarm.mp3");
                        wmplayer.controls.play();
                    }
                    else
                    {
                        player.SoundLocation = Path.Combine(docPath, "alarm.wav");
                        player.Play();
                    }
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
            player = new();
            wmplayer = new();
            settings = new();
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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
            player.Stop();
            wmplayer.controls.stop();
            Timer.Text = "00:00:00";
        }

        private void SettingsButtom_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }
    }
}