using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace clipboard-history-manager-windows.Views.Settings.Controls.Shortcut
{
    public sealed partial class KeyCharPresenter : Control
    {
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register(nameof(Content), typeof(object), typeof(KeyCharPresenter), new PropertyMetadata(default(string)));
        
        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        public KeyCharPresenter()
        {
            DefaultStyleKey = typeof(KeyCharPresenter);
        }
    }
}
