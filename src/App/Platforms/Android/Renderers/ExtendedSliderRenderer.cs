using System.ComponentModel;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using AndroidX.Core.Content.Resources;
using Bit.App.Controls;
using Bit.Droid.Renderers;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using Bit.App;
using Color = Android.Graphics.Color;

namespace Bit.Droid.Renderers
{
    public class ExtendedSliderRenderer : SliderRenderer
    {
        public ExtendedSliderRenderer(Context context)
            : base(context)
        {}

        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);
            UpdateColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ExtendedSlider.ThumbBorderColorProperty.PropertyName)
            {
                UpdateColor();
            }
        }
        
        private void UpdateColor()
        {
            if (Control != null && Element is ExtendedSlider view)
            {
                var t = ResourcesCompat.GetDrawable(Resources, Android.Resource.Drawable.slider_thumb, null);
                if (t is GradientDrawable thumb)
                {
                    if (view.ThumbColor == null)
                    {
                        thumb.SetColor(Color.White);
                    }
                    else
                    {
                        thumb.SetColor(view.ThumbColor.ToAndroid());
                    }
                    thumb.SetStroke(3, view.ThumbBorderColor.ToAndroid());
                    Control.SetThumb(thumb);
                }
            }
        }
    }
}
