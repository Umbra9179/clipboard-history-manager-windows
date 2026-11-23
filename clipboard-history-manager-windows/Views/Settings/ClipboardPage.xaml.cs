using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using clipboard-history-manager-windows.ViewModels.Settings;

namespace clipboard-history-manager-windows.Views.Settings
{
    public sealed partial class ClipboardPage : Page
    {
        public readonly ClipboardPageViewModel ViewModel = new();

        public ClipboardPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            Bindings.StopTracking();
            DataContext = null;
        }
    }
}
