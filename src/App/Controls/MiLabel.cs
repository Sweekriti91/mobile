using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Controls
{
    public class MiLabel : Label
    {
        public MiLabel()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    FontFamily = "Material Icons";
                    break;
                case Device.Android:
                    FontFamily = "MaterialIcons_Regular.ttf#Material Icons";
                    break;
            }
        }
    }
}
