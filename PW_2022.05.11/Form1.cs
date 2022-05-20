namespace PW_2022._05._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode tn = treeViewExplorer.Nodes.Add(drive.Name);
                tn.Nodes.Add("Пример");
            }
        }
    }
}