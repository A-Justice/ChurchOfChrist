using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using ShortBody.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace ShortBody
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        //AppContext db = new AppContext();
        public static Border Footer = null;
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            Footer = footer;
            mainWindow = this;

        }

        private void btnBackup_Click(object sender, RoutedEventArgs e)
        {
            if(new MasterPasswordWindow(DashBoardPages.PeoplePage,false).ShowDialog()==true)
            Methods.Backup(true);
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (new MasterPasswordWindow(DashBoardPages.PeoplePage, false).ShowDialog() == true)
            {
                Methods.Backup();
                Methods.Restore(true);
            }
        
        }

        private void btnRevert_Click(object sender, RoutedEventArgs e)
        {
            if (new MasterPasswordWindow(DashBoardPages.PeoplePage, false).ShowDialog() == true)
                Methods.Restore();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DashBoardViewModel.db?.SaveChanges();
            try
            {
                Methods.Backup();
            }
            catch { }
        }
    }
}
