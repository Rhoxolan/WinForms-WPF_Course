using System.Drawing.Drawing2D;

namespace HW_2022._05._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            string name = "ИЗОЛЕНТА ПРО МАКС 2023+";
            string tagline = "Изолента для заземления нового поколения!!!";
            Font fname = new Font("Comic Sans MS", 32, FontStyle.Bold);
            Font ftagline = new Font("Comic Sans MS", 16, FontStyle.Bold);
            LinearGradientBrush lgBrush = new LinearGradientBrush(rect, Color.Yellow, Color.Green, 0.0f, true);
            g.DrawString(name, fname, lgBrush, 30, 55);
            g.DrawString(tagline, ftagline, lgBrush, 90, 115);
            Image im = new Bitmap("СЖИзолента.bmp");
            g.DrawImage(im, 210, 175);
        }
    }
}