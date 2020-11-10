
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace CircleImageDemo.CircleImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class AdvancedCircleImage : Grid
    {
        public AdvancedCircleImage()
        {
            InitializeComponent();
        }

        #region MainImageSource
        // Bindable property
        public static readonly BindableProperty MainImageSourceProperty =
          BindableProperty.Create(
             propertyName: nameof(MainImageSource),
             declaringType: typeof(AdvancedCircleImage),
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
             declaringType: typeof(AdvancedCircleImage),
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
             declaringType: typeof(AdvancedCircleImage),
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

        #region BorderColor
        // Bindable property
        public static readonly BindableProperty BorderColorProperty =
          BindableProperty.Create(
             propertyName: nameof(BorderColor),
             declaringType: typeof(AdvancedCircleImage),
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
             declaringType: typeof(AdvancedCircleImage),
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

        #region IsBorderVisible
        // Bindable property
        public static readonly BindableProperty IsBorderVisibleProperty =
          BindableProperty.Create(
             propertyName: nameof(IsBorderVisible),
             declaringType: typeof(AdvancedCircleImage),
             returnType: typeof(bool),
             defaultValue: false,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });


        // Gets or sets value of this BindableProperty
        public bool IsBorderVisible
        {
            get => (bool)GetValue(IsBorderVisibleProperty);
            set => SetValue(IsBorderVisibleProperty, value);
        }
        #endregion

        #region ShowLoader
        // Bindable property
        public static readonly BindableProperty IsLoaderEnabledProperty =
          BindableProperty.Create(
             propertyName: nameof(IsLoaderEnabled),
             declaringType: typeof(AdvancedCircleImage),
             returnType: typeof(bool),
             defaultValue: false,
             defaultBindingMode: BindingMode.OneWay,
             propertyChanged: (bindable, oldValue, newValue) =>
             { });


        // Gets or sets value of this BindableProperty
        public bool IsLoaderEnabled
        {
            get => (bool)GetValue(IsLoaderEnabledProperty);
            set => SetValue(IsLoaderEnabledProperty, value);
        }
        #endregion
    }
}