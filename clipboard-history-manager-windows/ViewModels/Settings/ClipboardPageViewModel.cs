using CommunityToolkit.Mvvm.ComponentModel;
using clipboard-history-manager-windows.Models;

namespace clipboard-history-manager-windows.ViewModels.Settings
{
    public partial class ClipboardPageViewModel : ObservableObject
    {
        public SettingsContext SettingsContext { get; } = App.Current.SettingsContext;
    }
}
