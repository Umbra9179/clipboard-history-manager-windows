using CommunityToolkit.WinUI.Converters;
using Microsoft.UI.Xaml.Data;
using clipboard-history-manager-windows.Helper;
using System;

namespace clipboard-history-manager-windows.Converters
{
    public partial class StringFormatResourceConverter : StringFormatConverter, IValueConverter
    {
        public new object Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter is string resourceName)
            {
                return base.Convert(value, targetType, resourceName.GetLocalizedResource(), language);
            }

            return parameter;
        }
    }
}
