using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HW_2022._06._01_WPF
{
    public partial class MainWindow : Window
    {
        private BindingList<Transaction> transaction;

        public MainWindow()
        {
            InitializeComponent();
            transaction = new BindingList<Transaction>();
            lb.ItemsSource = transaction;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(nameTB.Text != String.Empty &&
                sumTB.Text != String.Empty)
            {
                transaction.Add(new Transaction(nameTB.Text, Convert.ToDouble(sumTB.Text)));
            }
        }
    }
}
