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

namespace PW_2022._06._01_WPF
{
    public partial class MainWindow : Window
    {
        private BindingList<string> styles;

        public MainWindow()
        {
            InitializeComponent();
            styles = new BindingList<string>();
            styles.Add("Style 1");
            styles.Add("Style 2");
            styles.Add("Style 3");
            comboBoxStyles.ItemsSource = styles;
            comboBoxStyles.SelectedItem = "Style 1";
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
