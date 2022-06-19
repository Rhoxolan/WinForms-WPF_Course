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

namespace HW_2022._05._25_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //!! Подробнее https://www.wpf-tutorial.com/ru/73/списочные-элементы-управления/элемент-управления-combobox/
            // https://www.cyberforum.ru/wpf-silverlight/thread3000860.html
            foregroundComboBox.ItemsSource = typeof(Brushes).GetProperties();
        }
    }
}
