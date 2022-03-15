using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Controls
{
    public class ExtendedSlider : Slider
    {
        public static readonly BindableProperty ThumbBorderColorProperty = BindableProperty.Create(
            nameof(ThumbBorderColor), typeof(Color), typeof(ExtendedSlider), null);

        public Color ThumbBorderColor
        {
            get => (Color)GetValue(ThumbBorderColorProperty);
            set => SetValue(ThumbBorderColorProperty, value);
        }
    }
}
