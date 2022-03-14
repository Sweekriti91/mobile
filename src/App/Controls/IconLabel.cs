using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Controls
{
    public class IconLabel : Label
    {
        public bool ShouldUpdateFontSizeDynamicallyForAccesibility { get; set; }

        public IconLabel()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    FontFamily = "bwi-font";
                    break;
                case Device.Android:
                    FontFamily = "bwi-font.ttf#bwi-font";
                    break;
            }
        }
    }
}
