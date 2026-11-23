using Microsoft.UI.Xaml.Data;
using clipboard-history-manager-windows.Core;
using clipboard-history-manager-windows.Models;
using System;
using System.Collections.Generic;

namespace clipboard-history-manager-windows.Converters
{
    public partial class ClipDataDictionaryToDataConverter : IValueConverter
    {
        private readonly HashSet<ClipboardFormat> _formatsForDataPreview =
            [
                ClipboardFormat.Text,
                ClipboardFormat.Png,
                ClipboardFormat.Bitmap,
                ClipboardFormat.Files
            ];

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var data = (Dictionary<ClipboardFormat, DataModel>)value;

            foreach (var dataItem in data)
            {
                if (_formatsForDataPreview.Contains(dataItem.Key))
                {
                    return dataItem.Value;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
