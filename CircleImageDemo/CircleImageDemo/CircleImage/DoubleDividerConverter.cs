using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CircleImageDemo.CircleImage
{
    public class DoubleDividerConverter : IValueConverter
    {
        public readonly static DoubleDividerConverter Instance = new DoubleDividerConverter();

        public int Divider { get; set; } = 1;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleToDivide)
            {
                return doubleToDivide / Divider;
            }

            throw new ArgumentException($"{nameof(value)} should be of type double");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleToMultiply)
            {
                return doubleToMultiply * Divider;
            }

            throw new ArgumentException($"{nameof(value)} should be of type double");
        }
    }
}
