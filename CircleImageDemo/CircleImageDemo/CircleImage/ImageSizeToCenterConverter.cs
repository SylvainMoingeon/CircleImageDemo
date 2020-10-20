using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CircleImageDemo.CircleImage
{
    public class ImageSizeToCenterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double imageSize)
            {
                return new Point(imageSize / 2, imageSize / 2);
            }

            throw new ArgumentException($"{nameof(value)} should be of type double");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
