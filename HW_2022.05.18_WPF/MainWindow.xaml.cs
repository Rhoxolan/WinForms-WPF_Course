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

namespace HW_2022._05._18_WPF
{
    public partial class MainWindow : Window
    {
        Button button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19,
            button20, button21;
        DockPanel dockPanel;

        public MainWindow()
        {
            InitializeComponent();
            button1 = new Button { BorderThickness = new Thickness(0), Content = "1", Background = Brushes.Black, Foreground = Brushes.White };
            button2 = new Button { BorderThickness = new Thickness(0), Content = "2", Background = Brushes.Black, Foreground = Brushes.White };
            button3 = new Button { BorderThickness = new Thickness(0), Content = "3", Background = Brushes.Black, Foreground = Brushes.White };
            button4 = new Button { BorderThickness = new Thickness(0), Content = "4", Background = Brushes.White, Foreground = Brushes.Black };
            button5 = new Button { BorderThickness = new Thickness(0), Content = "5", Background = Brushes.Black, Foreground = Brushes.White };
            button6 = new Button { BorderThickness = new Thickness(0), Content = "6", Background = Brushes.White, Foreground = Brushes.Black };
            button7 = new Button { BorderThickness = new Thickness(0), Content = "7", Background = Brushes.White, Foreground = Brushes.Black };
            button8 = new Button { BorderThickness = new Thickness(0), Content = "8", Background = Brushes.Black, Foreground = Brushes.White };
            button9 = new Button { BorderThickness = new Thickness(0), Content = "9", Background = Brushes.Black, Foreground = Brushes.White };
            button10 = new Button { BorderThickness = new Thickness(0), Content = "10", Background = Brushes.White, Foreground = Brushes.Black };
            button11 = new Button { BorderThickness = new Thickness(0), Content = "11", Background = Brushes.Black, Foreground = Brushes.White };
            button12 = new Button { BorderThickness = new Thickness(0), Content = "12", Background = Brushes.White, Foreground = Brushes.Black };
            button13 = new Button { BorderThickness = new Thickness(0), Content = "13", Background = Brushes.Black, Foreground = Brushes.White };
            button14 = new Button { BorderThickness = new Thickness(0), Content = "14", Background = Brushes.White, Foreground = Brushes.Black };
            button15 = new Button { BorderThickness = new Thickness(0), Content = "15", Background = Brushes.Black, Foreground = Brushes.White };
            button16 = new Button { BorderThickness = new Thickness(0), Content = "16", Background = Brushes.White, Foreground = Brushes.Black };
            button17 = new Button { BorderThickness = new Thickness(0), Content = "17", Background = Brushes.Black, Foreground = Brushes.White };
            button18 = new Button { BorderThickness = new Thickness(0), Content = "18", Background = Brushes.White, Foreground = Brushes.Black };
            button19 = new Button { BorderThickness = new Thickness(0), Content = "19", Background = Brushes.Black, Foreground = Brushes.White };
            button20 = new Button { BorderThickness = new Thickness(0), Content = "20", Background = Brushes.White, Foreground = Brushes.Black };
            button21 = new Button { BorderThickness = new Thickness(0), Content = "21", Background = Brushes.Black, Foreground = Brushes.White };
            dockPanel = new DockPanel { LastChildFill = false };
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
            dockPanel.Children.Add(button6);
            dockPanel.Children.Add(button7);
            dockPanel.Children.Add(button8);
            dockPanel.Children.Add(button9);
            dockPanel.Children.Add(button10);
            dockPanel.Children.Add(button11);
            dockPanel.Children.Add(button12);
            dockPanel.Children.Add(button13);
            dockPanel.Children.Add(button14);
            dockPanel.Children.Add(button15);
            dockPanel.Children.Add(button16);
            dockPanel.Children.Add(button17);
            dockPanel.Children.Add(button18);
            dockPanel.Children.Add(button19);
            dockPanel.Children.Add(button20);
            dockPanel.Children.Add(button21);
            DockPanel.SetDock(button1, Dock.Left);
            DockPanel.SetDock(button2, Dock.Bottom);
            DockPanel.SetDock(button3, Dock.Right);
            DockPanel.SetDock(button4, Dock.Left);
            DockPanel.SetDock(button5, Dock.Top);
            DockPanel.SetDock(button6, Dock.Bottom);
            DockPanel.SetDock(button7, Dock.Right);
            DockPanel.SetDock(button8, Dock.Left);
            DockPanel.SetDock(button9, Dock.Bottom);
            DockPanel.SetDock(button10, Dock.Top);
            DockPanel.SetDock(button11, Dock.Right);
            DockPanel.SetDock(button12, Dock.Left);
            DockPanel.SetDock(button13, Dock.Top);
            DockPanel.SetDock(button14, Dock.Bottom);
            DockPanel.SetDock(button15, Dock.Left);
            DockPanel.SetDock(button16, Dock.Right);
            DockPanel.SetDock(button17, Dock.Bottom);
            DockPanel.SetDock(button18, Dock.Top);
            DockPanel.SetDock(button19, Dock.Right);
            DockPanel.SetDock(button20, Dock.Left);
            DockPanel.SetDock(button21, Dock.Top);
        }
    }
}
