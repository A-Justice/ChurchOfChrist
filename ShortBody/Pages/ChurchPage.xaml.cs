using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for ChurchPage.xaml
    /// </summary>
    public partial class ChurchPage : UserControl
    {

        ChurchPageViewModel viewModel;
        public static ChurchPage churchPage;
        public ChurchPage()
        {

            InitializeComponent();
            viewModel = new ChurchPageViewModel();
            DataContext = viewModel;

            churchPage = this;

        }



        private void MainChurchGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try { viewModel.allChurchSelectedId = ((Church)grid.SelectedItem)?.ChurchId; } catch { }
            viewModel.SetFocusedChurch();
        }




        private void btnAddChurch_Click(object sender, RoutedEventArgs e)
        {
            if (AddChurchWindow.Visibility != Visibility.Visible)
            {

                AddAccDetailWindow.Visibility = Visibility.Collapsed;
                AddChurchWindow.Visibility = Visibility.Visible;


            }

        }

        private void churchWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddChurchWindow.Visibility = Visibility.Collapsed;
            AddAccDetailWindow.Visibility = Visibility.Collapsed;
            ViewAccWindow.Visibility = Visibility.Collapsed;
        }


        private void AccountGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var grid = sender as DataGrid;
            //try { viewModel.allAccDetailSelectedId = ((ChurchAccountDetail)grid.SelectedItem)?.ChurchAccountDetailId; } catch { }
        }

        private void ViewAccDetail_Click(object sender, RoutedEventArgs e)
        {
            if (ViewAccWindow.Visibility != Visibility.Visible)
            {
                ViewAccWindow.Resize();
            }
        }

        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ResetChurchLogo();
        }

        private void DataGrid_TargetUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Methods.PreviewMouseWheelEventHandler(sender, e);
        }

        private void cboSearchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSearchBox.SelectedIndex == 0)
            {
                txtSearchBox.Visibility = Visibility.Collapsed;
                return;
            }
            txtSearchBox.Visibility = Visibility.Visible;
        }

        private void AddAccDetail_Click(object sender, RoutedEventArgs e)
        {
            if (AddAccDetailWindow.Visibility != Visibility.Visible)
            {
                AddChurchWindow.Visibility = Visibility.Collapsed;
                AddAccDetailWindow.Visibility = Visibility.Visible;


            }
        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            viewModel.SearchBy = viewModel.SearchString == "" ? "All" : viewModel.SearchBy;
            viewModel.SearchChurch();
        }
    }
}
