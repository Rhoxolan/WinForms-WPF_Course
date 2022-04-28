namespace HW_2022._04._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            while(true)
            {
                DialogResult dr;
                dr = MessageBox.Show("Загадайте число от 1 до 2000!", "Игра", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    DialogResult dr2;
                    while (true)
                    {
                        DialogResult dr3;
                        dr2 = MessageBox.Show($"Вы загадали число {random.Next(0,2001)}?", "Игра",
                            MessageBoxButtons.YesNoCancel);
                        if(dr2 == DialogResult.Yes)
                        {
                            dr3 = MessageBox.Show($"Продолжить игру?", "Игра",
                            MessageBoxButtons.YesNoCancel);
                            if (dr3 == DialogResult.Yes)
                            {
                                break;
                            }
                            if (dr3 == DialogResult.No)
                            {
                                return;
                            }
                            if (dr3 == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                        if (dr2 == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }
        }
    }
}