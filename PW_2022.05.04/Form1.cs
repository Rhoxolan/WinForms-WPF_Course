using System.Runtime.InteropServices;

namespace PW_2022._05._04
{
    public partial class Form1 : Form
    {
        private string docPath;

        //_________________________________________
        //Необходимо для изменения ProgressBar.Value по прокрутке ScrollBar
        //Взято отсюда: https://ru.stackoverflow.com/questions/12990/Управление-scrollbar-на-c-в-visual-studio
        private const int SB_HORZ = 0x0;
        private const int SB_VERT = 0x1;
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int SB_THUMBPOSITION = 4;
        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);
        [DllImport("user32.dll")]
        private static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);
        [DllImport("user32.dll")]
        private static extern bool PostMessageA(IntPtr hWnd, int nBar, int wParam, int lParam);
        //_________________________________________

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textBoxFileText.Text = File.ReadAllText(Path.Combine(docPath, "File.txt"));
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if(GetScrollPos(textBoxFileText.Handle, SB_VERT) > 12)
            {
                progressBar1.Value = 100;
            }
            else if (GetScrollPos(textBoxFileText.Handle, SB_VERT) > 8)
            {
                progressBar1.Value = 75;
            }
            else if (GetScrollPos(textBoxFileText.Handle, SB_VERT) > 4)
            {
                progressBar1.Value = 50;
            }
            else if (GetScrollPos(textBoxFileText.Handle, SB_VERT) > 0)
            {
                progressBar1.Value = 0;
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar2.Value = i;
                //Thread.Sleep(100); //Это не асинхронно
                await Task.Delay(100); //Это асинхронно
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value > 7)
            {
                this.BackColor = Color.Cyan;
            }
            else if (trackBar2.Value > 5)
            {
                this.BackColor = SystemColors.AppWorkspace;
            }
            else if (trackBar2.Value > 2)
            {
                this.BackColor = Color.LightYellow;
            }
            else if (trackBar2.Value > 0)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 7)
            {
                this.Opacity = 0.3;
            }
            else if (trackBar1.Value > 5)
            {
                this.Opacity = 0.7;
            }
            else if (trackBar1.Value > 2)
            {
                this.Opacity = 0.8;
            }
            else if (trackBar1.Value > 0)
            {
                this.Opacity = 1.0;
            }
        }
    }
}