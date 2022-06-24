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

namespace PW_2022._05._30_WPF
{
    public partial class MainWindow : Window
    {
        byte move;
        public MainWindow()
        {
            InitializeComponent();
            move = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(move == 1)
            {
                Button thisBtn = (Button)sender;
                thisBtn.Style = (Style)gameTable.Resources["Xs button"];
                thisBtn.Content = "X";
                move = 2;
            }
            else
            {
                Button thisBtn = (Button)sender;
                thisBtn.Content = "0";
                move = 1;
            }
        }
    }
}
