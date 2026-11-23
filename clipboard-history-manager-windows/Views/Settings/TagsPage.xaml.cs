using CommunityToolkit.WinUI.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using clipboard-history-manager-windows.Helper;
using clipboard-history-manager-windows.Models;
using clipboard-history-manager-windows.ViewModels.Settings;
using clipboard-history-manager-windows.Views.Settings.Controls;
using System;

namespace clipboard-history-manager-windows.Views.Settings
{
    public sealed partial class TagsPage : Page
    {
        public readonly TagsPageViewModel ViewModel = new();

        private readonly ContentDialog _tagEditorDialog;

        public TagsPage()
        {
            InitializeComponent();

            _tagEditorDialog = new()
            {
                Title = "/Settings/TagDialog_Title/Text".GetLocalizedResource(),
                PrimaryButtonText = "Save".GetLocalizedResource(),
                CloseButtonText = "Cancel".GetLocalizedResource(),
                DefaultButton = ContentDialogButton.Primary
            };
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _tagEditorDialog.XamlRoot = XamlRoot;
        }

        private async void AddTagButton_Click(object sender, RoutedEventArgs e)
        {
            var dialogContent = new TagEditorDialog();
            _tagEditorDialog.RequestedTheme = App.Current.ThemeService.Theme;
            _tagEditorDialog.IsPrimaryButtonEnabled = false;
            _tagEditorDialog.Content = dialogContent;
            var dialogResult = await _tagEditorDialog.ShowAsync();

            if (dialogResult == ContentDialogResult.Primary)
            {
                ViewModel.AddTag(dialogContent.TagName, dialogContent.SelectedColor.Color.ToHex(), dialogContent.IsCleaningEnabled);
            }
        }

        private async void EditTagButton_Click(object sender, RoutedEventArgs e)
        {
            var tag = (TagModel)((Button)sender).DataContext;
            var dialogContent = new TagEditorDialog()
            {
                TagName = tag.Name,
                SelectedColor = tag.ColorBrush,
                IsCleaningEnabled = tag.IsCleaningEnabled
            };
            _tagEditorDialog.RequestedTheme = App.Current.ThemeService.Theme;
            _tagEditorDialog.Content = dialogContent;
            var dialogResult = await _tagEditorDialog.ShowAsync();

            if (dialogResult == ContentDialogResult.Primary)
            {
                ViewModel.EditTag(tag, dialogContent.TagName, dialogContent.SelectedColor.Color.ToHex(), dialogContent.IsCleaningEnabled);
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            Bindings.StopTracking();
            DataContext = null;
        }
    }
}
