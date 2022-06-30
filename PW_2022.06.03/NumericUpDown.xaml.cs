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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PW_2022._06._03
{
    [ContentProperty(nameof(Value))]
    public partial class NumericUpDown : UserControl
    {
        public static readonly DependencyProperty ValueProperty;

        static NumericUpDown()
        {
            //Подробнее про регистрацию свойств зависимостей https://metanit.com/sharp/wpf/13.php
            ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumericUpDown),
                new FrameworkPropertyMetadata(0));
        }

        public NumericUpDown()
        {
            InitializeComponent();
        }

        public int Value
        {
            get => (int)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        //public event RoutedEventHandler ValueChanged
        //{
        //    add { AddHandler(ValueChangedEvent, value); }
        //    remove { RemoveHandler(ValueChangedEvent, value); }
        //}

        //public static readonly RoutedEvent ValueChangedEvent =
        //    EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler),
        //        typeof(NumericUpDown));

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //e.Handled = true;
            Value = Convert.ToInt32(textBoxPart.Text);
            //RoutedEventArgs args = new RoutedEventArgs(ValueChangedEvent);
            //RaiseEvent(args);
        }
    }
}
