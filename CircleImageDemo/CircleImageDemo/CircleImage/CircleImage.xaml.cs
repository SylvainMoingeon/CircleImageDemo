
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace CircleImageDemo.CircleImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class CircleImage : Grid
    {
        public CircleImage()
        {
            InitializeComponent();
        }

        #region MainImageSource
        // Bindable property
        public static readonly BindableProperty MainImageSourceProperty =
          BindableProperty.Create(
             propertyName: nameof(MainImageSource),
             declaringType: typeof(CircleImage),
             returnType: typeof(ImageSource),
             defaultValue: null,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) => { });

        // Gets or sets value of this BindableProperty
        public ImageSource MainImageSource
        {
            get => (ImageSource)GetValue(MainImageSourceProperty);
            set => SetValue(MainImageSourceProperty, value);
        }
        #endregion

        #region PlaceholderImageSource
        // Bindable property
        public static readonly BindableProperty PlaceholderImageSourceProperty =
          BindableProperty.Create(
             propertyName: nameof(PlaceholderImageSource),
             declaringType: typeof(CircleImage),
             returnType: typeof(ImageSource),
             defaultValue: null,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });

        // Gets or sets value of this BindableProperty
        public ImageSource PlaceholderImageSource
        {
            get => (ImageSource)GetValue(PlaceholderImageSourceProperty);
            set => SetValue(PlaceholderImageSourceProperty, value);
        }
        #endregion

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
             {
                 if (newValue is double imageSize && bindable is CircleImage circleImage)
                 {
                     double radius = imageSize / 2;

                     // Clipping
                     Point center = new Point(radius, radius);
                     EllipseGeometry ellipseGeometry = new EllipseGeometry()
                     {
                         Center = center,
                         RadiusX = radius,
                         RadiusY = radius
                     };

                     circleImage.Image.Clip = ellipseGeometry;
                     circleImage.Placeholder.Clip = ellipseGeometry;
                 }
             });

        // Gets or sets value of this BindableProperty
        public double ImageSize
        {
            get => (double)GetValue(ImageSizeProperty);
            set => SetValue(ImageSizeProperty, value);
        }
        #endregion

        #region BorderColor
        // Bindable property
        public static readonly BindableProperty BorderColorProperty =
          BindableProperty.Create(
             propertyName: nameof(BorderColor),
             declaringType: typeof(CircleImage),
             returnType: typeof(Color),
             defaultValue: Color.Transparent,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });


        // Gets or sets value of this BindableProperty
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        #endregion

        #region BorderThickness
        // Bindable property
        public static readonly BindableProperty BorderThicknessProperty =
          BindableProperty.Create(
             propertyName: nameof(BorderThickness),
             declaringType: typeof(CircleImage),
             returnType: typeof(double),
             defaultValue: 0.0,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });


        // Gets or sets value of this BindableProperty
        public double BorderThickness
        {
            get => (double)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        #endregion

        #region ShowBorder
        // Bindable property
        public static readonly BindableProperty ShowBorderProperty =
          BindableProperty.Create(
             propertyName: nameof(ShowBorder),
             declaringType: typeof(CircleImage),
             returnType: typeof(bool),
             defaultValue: false,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });


        // Gets or sets value of this BindableProperty
        public bool ShowBorder
        {
            get => (bool)GetValue(ShowBorderProperty);
            set => SetValue(ShowBorderProperty, value);
        }
        #endregion

        #region ShowLoader
        // Bindable property
        public static readonly BindableProperty ShowLoaderProperty =
          BindableProperty.Create(
             propertyName: nameof(ShowLoader),
             declaringType: typeof(CircleImage),
             returnType: typeof(bool),
             defaultValue: false,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });


        // Gets or sets value of this BindableProperty
        public bool ShowLoader
        {
            get => (bool)GetValue(ShowLoaderProperty);
            set => SetValue(ShowLoaderProperty, value);
        }
        #endregion
    }
}