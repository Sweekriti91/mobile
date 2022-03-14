﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Bit.App.Pages
{
    public class SettingsPageListItemSelector : DataTemplateSelector
    {
        public DataTemplate RegularTemplate { get; set; }
        public DataTemplate TimePickerTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is SettingsPageListItem listItem)
            {
                if (listItem.ShowTimeInput)
                {
                    return TimePickerTemplate;
                }
                else
                {
                    return RegularTemplate;
                }
            }
            return null;
        }
    }
}
