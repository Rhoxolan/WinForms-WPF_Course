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
            MessageBox.Show(str1, "������");
            MessageBox.Show(str2, "������");
            MessageBox.Show($"{str3}{Environment.NewLine}(� ������ {stringcount} ��������.)", "������");
        }
    }
}