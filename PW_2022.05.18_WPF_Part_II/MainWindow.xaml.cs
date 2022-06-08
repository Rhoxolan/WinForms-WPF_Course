using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PW_2022._05._18_WPF_Part_II
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        DockPanel dockPanel;

        public MainWindow()
        {
            InitializeComponent();
            button1 = new Button { Content = "Button 1" };
            button2 = new Button { Content = "Button 2" };
            button3 = new Button { Content = "Button 3" };
            button4 = new Button { Content = "Button 4" };
            button5 = new Button { Content = "Button 5" };
            dockPanel = new DockPanel();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Content = dockPanel;
            dockPanel.Children.Add(button1);
            dockPanel.Children.Add(button2);
            dockPanel.Children.Add(button3);
            dockPanel.Children.Add(button4);
            dockPanel.Children.Add(button5);
            DockPanel.SetDock(button1, Dock.Top);
            DockPanel.SetDock(button2, Dock.Bottom);
            DockPanel.SetDock(button3, Dock.Left);
            DockPanel.SetDock(button4, Dock.Top);
        }
    }
}
