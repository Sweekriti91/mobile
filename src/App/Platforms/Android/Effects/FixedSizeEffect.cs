using Android.Widget;
using Bit.Droid.Effects;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform;

[assembly: ExportEffect(typeof(FixedSizeEffect), "FixedSizeEffect")]
namespace Bit.Droid.Effects
{
    public class FixedSizeEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Element is Label label && Control is TextView textView)
            {
                textView.SetTextSize(Android.Util.ComplexUnitType.Pt, (float)label.FontSize);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}
