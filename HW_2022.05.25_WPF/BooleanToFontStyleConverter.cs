using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace HW_2022._05._25_WPF
{
    public class BooleanToFontStyleConverter : IValueConverter
    {
        //Подробнее https://www.cyberforum.ru/wpf-silverlight/thread2427817.html
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                return FontStyles.Italic;
            }
            else
            {
                return FontStyles.Normal;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
