using ShortBody.Models;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        
        public static LoginPage loginPage;
        public static bool IsLoggedOut;
        MainWindowViewModel vm;
        public LoginPage()
        {
            InitializeComponent();
          vm = (MainWindowViewModel)MainWindow.mainWindow.DataContext;
            DataContext = vm;
            vm.LoadChurches();        
            vm.ResetCredentials();
            loginPage = this;

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.Footer.Visibility = Visibility.Collapsed;
        }

        private void PbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            vm.Password = (sender as PasswordBox).Password;
        }
    }
}
