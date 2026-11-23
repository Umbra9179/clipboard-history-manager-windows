using CommunityToolkit.Mvvm.ComponentModel;
using clipboard-history-manager-windows.Helper.WindowBackdrop;
using clipboard-history-manager-windows.Models;
using clipboard-history-manager-windows.Views.Clipboard;
using System;
using System.ComponentModel;

namespace clipboard-history-manager-windows.ViewModels.Settings
{
    public partial class PersonalizationPageViewModel : ObservableObject, IDisposable
    {
        public SettingsContext SettingsContext { get; } = App.Current.SettingsContext;
        public bool IsBackgropSupported { get; } = WindowBackdropHelper.IsSystemBackdropSupported;
        public bool IsWindowHeightEditorEnabled => SettingsContext.WindowPosition != ClipboardWindowPosition.Right;
        public bool IsWindowMarginEditorEnabled => SettingsContext.WindowPosition != ClipboardWindowPosition.ScreenCenter
            && SettingsContext.WindowPosition != ClipboardWindowPosition.LastPosition;

        public PersonalizationPageViewModel()
        {
            SettingsContext.PropertyChanged += SettingsContext_PropertyChanged;
        }

        public void Dispose()
        {
            SettingsContext.PropertyChanged -= SettingsContext_PropertyChanged;
        }

        private void SettingsContext_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SettingsContext.WindowPosition))
            {
                OnPropertyChanged(nameof(IsWindowHeightEditorEnabled));
                OnPropertyChanged(nameof(IsWindowMarginEditorEnabled));
            }
        }
    }
}
