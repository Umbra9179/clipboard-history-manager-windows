using Microsoft.UI.Xaml;
using clipboard-history-manager-windows.Helper.WindowBackdrop;
using Windows.Foundation;

namespace clipboard-history-manager-windows.Contracts
{
    public interface IThemeService
    {
        event TypedEventHandler<IThemeService, ElementTheme> ThemeChanged;
        event TypedEventHandler<IThemeService, WindowBackdropType> WindowBackdropChanged;
        ElementTheme Theme { get; }
        WindowBackdropType WindowBackdrop { get; }
        void ApplyTheme();
        void ApplyWindowBackdrop();
    }
}
