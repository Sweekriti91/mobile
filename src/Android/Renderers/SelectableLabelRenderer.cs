using System;
using Android.Content;
using Bit.App.Controls;
using Bit.Droid.Renderers;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SelectableLabel), typeof(SelectableLabelRenderer))]
namespace Bit.Droid.Renderers
{
    public class SelectableLabelRenderer : LabelRenderer
    {
        public SelectableLabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetTextIsSelectable(true);
            }
        }
    }
}
