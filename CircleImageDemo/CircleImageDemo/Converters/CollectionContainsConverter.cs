using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace CircleImageDemo.Converters
{
    /// <summary>
    /// Indique si la collection contient un item particulier.
    /// </summary>
    /// <typeparam name="T">Type de l'item</typeparam>
    public class CollectionContainsConverter<T> : IValueConverter
    {
        public T Item { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value ==null || parameter ==null)
                return false;


            if(!(parameter is T item))
            {
               throw new ArgumentException($"{nameof(parameter)} should of type", nameof(parameter));

            }

            if (value is IList collection)
            {
                return collection.Contains(item);
            }

            throw new ArgumentException($"{nameof(value)} should be a collection",nameof(value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
