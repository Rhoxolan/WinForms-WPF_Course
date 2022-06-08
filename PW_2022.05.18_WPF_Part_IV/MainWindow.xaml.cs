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

namespace PW_2022._05._18_WPF_Part_IV
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
        Grid grid;

        public MainWindow()
        {
            InitializeComponent();
            button1 = new Button { Content = 1 };
            button2 = new Button { Content = 2 };
            button3 = new Button { Content = 3 };
            button4 = new Button { Content = 4 };
            button5 = new Button { Content = 5 };
            grid = new Grid();
            this.Content = grid;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.Children.Add(button1);
            grid.Children.Add(button2);
            grid.Children.Add(button3);
            grid.Children.Add(button4);
            grid.Children.Add(button5);
            Grid.SetColumn(button1, 0);
            Grid.SetRow(button1, 0);
            Grid.SetColumn(button2, 2);
            Grid.SetRow(button2, 0);
            Grid.SetColumn(button3, 0);
            Grid.SetRow(button3, 1);
            Grid.SetColumn(button4, 1);
            Grid.SetRow(button4, 1);
            Grid.SetColumn(button5, 0);
            Grid.SetRow(button5, 2);
            Grid.SetColumnSpan(button1, 2);
            Grid.SetColumnSpan(button5, 3);
            Grid.SetRowSpan(button2, 2);
        }
    }
}
