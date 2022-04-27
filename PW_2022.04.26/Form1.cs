namespace PW_2022._04._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            const int string_count = 3;
            string str1 = "��������� �����";
            string str2 = "C# developer";
            string str3 = "������������ �������� ���, �. ������ ���";
            int stringcount = (str1.Length + str2.Length + str3.Length) / string_count;
            if (MessageBox.Show("�������� ������?", "������", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) //������ ������ � DialogResult
            {
                MessageBox.Show(str1, "������");
                MessageBox.Show(str2, "������");
                MessageBox.Show($"{str3}{Environment.NewLine}(� ������ {stringcount} ��������.)", "������");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (e.X > 10 && e.Y > 10 &&
                e.Y < (this.ClientSize.Height - 10) && e.X < (this.ClientSize.Width - 10))
                {
                    //MessageBox.Show("������ � �������", "������� ������",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("������ � �������");
                }
                else if (e.X == 10 || e.Y == 10 ||
                e.Y == (this.ClientSize.Height - 10) || e.X == (this.ClientSize.Width - 10))
                {
                    //MessageBox.Show("�� ������ �� ������� ��������", "������� ������",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("�� ������ �� ������� ��������");
                }
                else
                {
                    //MessageBox.Show("�� ������ � �������", "������� ������",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("�� ������ � �������");
                }
            }
            if(e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"������ ������� �������: {this.ClientSize.Width}," +
                    $"������ ������� �������:{this.ClientSize.Height}.", "���������� ��� ������� �������");
            }
            if(e.Button == MouseButtons.Middle)
            {
                MessageBox.Show($"�� ��������: X{e.X} Y{e.Y}.", "���������� ��� ���� ������");
            }
        }
    }
}