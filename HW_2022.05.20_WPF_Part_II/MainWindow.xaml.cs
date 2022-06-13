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

namespace HW_2022._05._20_WPF_Part_II
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                Window mainWindow = sender as Window;
                Grid mainGrid = mainWindow.Content as Grid;
                foreach (Button btn in mainGrid.Children.OfType<Button>())
                {
                    switch (btn.Content)
                    {
                        case "q":
                            btn.Content = "Q";
                            break;
                        case "w":
                            btn.Content = "W";
                            break;
                        case "e":
                            btn.Content = "E";
                            break;
                        case "r":
                            btn.Content = "R";
                            break;
                        case "t":
                            btn.Content = "T";
                            break;
                        case "y":
                            btn.Content = "Y";
                            break;
                        case "u":
                            btn.Content = "U";
                            break;
                        case "i":
                            btn.Content = "I";
                            break;
                        case "o":
                            btn.Content = "O";
                            break;
                        case "p":
                            btn.Content = "P";
                            break;
                        case "a":
                            btn.Content = "A";
                            break;
                        case "s":
                            btn.Content = "S";
                            break;
                        case "d":
                            btn.Content = "D";
                            break;
                        case "f":
                            btn.Content = "F";
                            break;
                        case "g":
                            btn.Content = "G";
                            break;
                        case "h":
                            btn.Content = "H";
                            break;
                        case "j":
                            btn.Content = "J";
                            break;
                        case "k":
                            btn.Content = "K";
                            break;
                        case "l":
                            btn.Content = "L";
                            break;
                        case "z":
                            btn.Content = "Z";
                            break;
                        case "x":
                            btn.Content = "X";
                            break;
                        case "c":
                            btn.Content = "C";
                            break;
                        case "v":
                            btn.Content = "V";
                            break;
                        case "b":
                            btn.Content = "B";
                            break;
                        case "n":
                            btn.Content = "N";
                            break;
                        case "m":
                            btn.Content = "M";
                            break;
                        case "Q":
                            btn.Content = "q";
                            break;
                        case "W":
                            btn.Content = "w";
                            break;
                        case "E":
                            btn.Content = "e";
                            break;
                        case "R":
                            btn.Content = "r";
                            break;
                        case "T":
                            btn.Content = "t";
                            break;
                        case "Y":
                            btn.Content = "y";
                            break;
                        case "U":
                            btn.Content = "u";
                            break;
                        case "I":
                            btn.Content = "i";
                            break;
                        case "O":
                            btn.Content = "o";
                            break;
                        case "P":
                            btn.Content = "o";
                            break;
                        case "A":
                            btn.Content = "a";
                            break;
                        case "S":
                            btn.Content = "s";
                            break;
                        case "D":
                            btn.Content = "d";
                            break;
                        case "F":
                            btn.Content = "f";
                            break;
                        case "G":
                            btn.Content = "g";
                            break;
                        case "H":
                            btn.Content = "h";
                            break;
                        case "J":
                            btn.Content = "j";
                            break;
                        case "K":
                            btn.Content = "k";
                            break;
                        case "L":
                            btn.Content = "l";
                            break;
                        case "Z":
                            btn.Content = "z";
                            break;
                        case "X":
                            btn.Content = "x";
                            break;
                        case "C":
                            btn.Content = "c";
                            break;
                        case "V":
                            btn.Content = "v";
                            break;
                        case "B":
                            btn.Content = "b";
                            break;
                        case "N":
                            btn.Content = "n";
                            break;
                        case "M":
                            btn.Content = "m";
                            break;
                    }
                }
            }
        }
    }
}
