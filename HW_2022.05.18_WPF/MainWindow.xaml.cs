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
            button1 = new Button { Content = "1", Background = Brushes.Black, Foreground = Brushes.White };
            button2 = new Button { Content = "2", Background = Brushes.Black, Foreground = Brushes.White };
            button3 = new Button { Content = "3", Background = Brushes.Black, Foreground = Brushes.White };
            button4 = new Button { Content = "4", Background = Brushes.White, Foreground = Brushes.Black };
            button5 = new Button { Content = "5", Background = Brushes.Black, Foreground = Brushes.White };
            button6 = new Button { Content = "6", Background = Brushes.White, Foreground = Brushes.Black };
            button7 = new Button { Content = "7", Background = Brushes.White, Foreground = Brushes.Black };
            button8 = new Button { Content = "8", Background = Brushes.Black, Foreground = Brushes.White };
            button9 = new Button { Content = "9", Background = Brushes.Black, Foreground = Brushes.White };
            button10 = new Button { Content = "10", Background = Brushes.White, Foreground = Brushes.Black };
            button11 = new Button { Content = "11", Background = Brushes.Black, Foreground = Brushes.White };
            button12 = new Button { Content = "12", Background = Brushes.White, Foreground = Brushes.Black };
            button13 = new Button { Content = "13", Background = Brushes.Black, Foreground = Brushes.White };
            button14 = new Button { Content = "14", Background = Brushes.White, Foreground = Brushes.Black };
            button15 = new Button { Content = "15", Background = Brushes.Black, Foreground = Brushes.White };
            button16 = new Button { Content = "16", Background = Brushes.White, Foreground = Brushes.Black };
            button17 = new Button { Content = "17", Background = Brushes.Black, Foreground = Brushes.White };
            button18 = new Button { Content = "18", Background = Brushes.White, Foreground = Brushes.Black };
            button19 = new Button { Content = "19", Background = Brushes.Black, Foreground = Brushes.White };
            button20 = new Button { Content = "20", Background = Brushes.White, Foreground = Brushes.Black };
            button21 = new Button { Content = "21", Background = Brushes.Black, Foreground = Brushes.White };
            dockPanel = new DockPanel { LastChildFill = false };
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
