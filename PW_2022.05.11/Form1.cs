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
            //TreeView
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode tn = treeViewExplorer.Nodes.Add(drive.Name);
                if (drive.IsReady)
                {
                    foreach (var folder in new DirectoryInfo(@$"{drive.Name}").GetDirectories())
                    {
                        tn.Nodes.Add(folder.FullName);
                    }
                }
            }

            //ListView
            listViewExplorer.SmallImageList = imageList;
            listViewExplorer.LargeImageList = imageList;
            listViewExplorer.StateImageList = imageList;
            listViewExplorer.GroupImageList = imageList;
            listViewExplorer.Columns.Add("Title");
            listViewExplorer.Columns.Add("Type");
            listViewExplorer.Columns.Add("Size");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                ListViewItem driveItem = listViewExplorer.Items.Add(drive.Name);
                driveItem.ImageIndex = 0;
                if (drive.IsReady)
                {
                    driveItem.SubItems.Add(drive.DriveType.ToString());
                    driveItem.SubItems.Add(drive.TotalSize.ToString());
                }
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExplorer.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExplorer.View = View.Details;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExplorer.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExplorer.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewExplorer.View = View.Tile;
        }
    }
}