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
                dr = MessageBox.Show("��������� ����� �� 1 �� 2000!", "����", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    DialogResult dr2;
                    while (true)
                    {
                        DialogResult dr3;
                        dr2 = MessageBox.Show($"�� �������� ����� {random.Next(0,2001)}?", "����",
                            MessageBoxButtons.YesNoCancel);
                        if(dr2 == DialogResult.Yes)
                        {
                            dr2 = MessageBox.Show($"���������� ����?", "����",
                            MessageBoxButtons.YesNoCancel);
                            if (dr2 == DialogResult.Yes)
                            {
                                break;
                            }
                            if (dr2 == DialogResult.No)
                            {
                                return;
                            }
                            if (dr2 == DialogResult.Cancel)
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