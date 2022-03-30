using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using Microsoft.Maui.Hosting;

namespace Bit.App
{
    public class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                })
                .UseMauiCommunityToolkit();
                //.UseMauiCompatibility()
                //.ConfigureMauiHandlers(handlers =>
                //{
                //    handlers.AddCompatibilityRenderer(typeof(CustomEditorRenderer),
                //        typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.EditorRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(CustomEntryRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.EntryRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(CustomPickerRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat.PickerRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(CustomSearchBarRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.SearchBarRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(CustomSwitchRenderer),
                //        typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat.SwitchRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(CustomTabbedRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat.TabbedPageRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(ExtendedDatePickerRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.DatePickerRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(ExtendedGridRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.ViewRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(ExtendedSliderRenderer),
                //        typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.SliderRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(ExtendedStackLayoutRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.ViewRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(ExtendedStepperRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.StepperRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(ExtendedTimePickerRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.TimePickerRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(HybridWebViewRenderer),
                //       typeof(Microsoft.Maui.Controls.Handlers.Compatibility.ViewRenderer));

                //    handlers.AddCompatibilityRenderer(typeof(SelectableLabelRenderer),
                //       typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.LabelRenderer));

                //});

            return builder.Build();
        }
    }
}
