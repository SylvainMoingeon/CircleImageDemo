using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CircleImageDemo.CircleImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible (true)]
    public partial class CircleImage : Image
    {
        public CircleImage()
        {
            InitializeComponent();
        }

        #region ImageSize
        // Bindable property
        public static readonly BindableProperty ImageSizeProperty =
          BindableProperty.Create(
             propertyName: nameof(ImageSize),
             declaringType: typeof(CircleImage),
             returnType: typeof(double),
             defaultValue: 0.0,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });

        // Gets or sets value of this BindableProperty
        public double ImageSize
        {
            get => (double)GetValue(ImageSizeProperty);
            set => SetValue(ImageSizeProperty, value);
        }
        #endregion
    }
}