using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Controls
{
    public class IconButton : Button
    {
        public IconButton()
        {
            Padding = 0;
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
