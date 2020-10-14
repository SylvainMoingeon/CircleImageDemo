using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CircleImageDemo.CircleImage
{
    public class ColorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Color color)
            {
                return new SolidColorBrush(color);
            }

            throw new ArgumentException($"{nameof(value)} should be a {nameof(Color)}");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is SolidColorBrush brush)
            {
                return brush.Color;
            }

            throw new ArgumentException($"{nameof(value)} should be a {nameof(SolidColorBrush)}");
        }
    }
}
