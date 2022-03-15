using Bit.App.Utilities;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Controls
{
    public class ExtendedSearchBar : SearchBar
    {
        public ExtendedSearchBar()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                if (ThemeManager.UsingLightTheme)
                {
                    TextColor = Colors.Black;
                }
            }
        }
    }
}
