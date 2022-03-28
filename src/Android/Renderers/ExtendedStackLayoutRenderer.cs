using Android.Content;
using Bit.App.Controls;
using Bit.Droid.Renderers;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat;
using Microsoft.Maui.Controls.Platform;

namespace Bit.Droid.Renderers
{
    public class ExtendedStackLayoutRenderer : ViewRenderer
    {
        public ExtendedStackLayoutRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<View> elementChangedEvent)
        {
            base.OnElementChanged(elementChangedEvent);
            if (elementChangedEvent.NewElement != null)
            {
                SetBackgroundResource(Android.Resource.Drawable.list_item_bg);
            }
        }
    }
}
