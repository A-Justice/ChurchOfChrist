using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Windows
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        SettingsViewModel viewModel;
        public SettingsWindow()
        {
            InitializeComponent();
            viewModel = new SettingsViewModel();
            DataContext = viewModel;
        }

        private void btnChangeMaxGroupPeople_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn.Content == "Change")
            {
                cboMaxGroupPeople.IsEnabled = true;
                btn.Content = "Save";
            }
            else
            {
                viewModel.ChangeMaxGroupNumber();
                cboMaxGroupPeople.IsEnabled = false;
                btn.Content = "Change";

            }
        }

        private void btnChangeMaxClassPeople_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn.Content == "Change")
            {
                cboMaxClassPeople.IsEnabled = true;
                btn.Content = "Save";
            }
            else
            {
                viewModel.ChangeMaxClassNumber();
                cboMaxClassPeople.IsEnabled = false;
                btn.Content = "Change";

            }
        }
    }
}
