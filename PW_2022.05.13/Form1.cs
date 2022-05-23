using System.Drawing.Drawing2D;

namespace PW_2022._05._13
{
    public partial class Form1 : Form
    {
        int val1;
        int val2;
        int val3;

        public Form1()
        {
            val1 = 10;
            val2 = 10;
            val3 = 10;
            InitializeComponent();
        }

        private void numericUpDownDiagram1_ValueChanged(object sender, EventArgs e)
        {
            val1 = (int)numericUpDownDiagram1.Value;
            this.Invalidate();
        }

        private void numericUpDownDiagram2_ValueChanged(object sender, EventArgs e)
        {
            val2 = (int)numericUpDownDiagram2.Value;
            this.Invalidate();
        }

        private void numericUpDownDiagram3_ValueChanged(object sender, EventArgs e)
        {
            val3 = (int)numericUpDownDiagram3.Value;
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, 300, 25, (val1 * 2), 10);
            g.FillRectangle(brush, 300, 50, (val2 * 2), 10);
            g.FillRectangle(brush, 300, 75, (val3 * 2), 10);
        }
    }
}