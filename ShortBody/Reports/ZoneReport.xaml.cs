using ShortBody.Pages;
using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for ZoneReport.xaml
    /// </summary>
    public partial class ZoneReport : Window
    {
        //string TypeText;
        TextBlock stpTertiary = null;
        StackPanel stpPrimary = null;
        StackPanel stpHalf = null;
        StackPanel stpQuarter = null;
        ReportPageViewModel viewModel = null;
        public ZoneReport()
        {
            InitializeComponent();
            viewModel = ReportPage.reportPage.viewModel;
            DataContext = viewModel;
            // TypeText = typeText;

        }

        private void stpTertiary_Loaded(object sender, RoutedEventArgs e)
        {
            stpTertiary = (sender as TextBlock);
            switch (viewModel.Type)
            {
                case "Yearly":

                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "Monthly":

                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "Halfly":

                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "Quarterly":

                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "TillDate":

                    break;

                default:
                    break;
            }

        }

        private void stpPrimary_Loaded(object sender, RoutedEventArgs e)
        {
            stpPrimary = (sender as StackPanel);
            switch (viewModel.Type)
            {
                case "Yearly":

                    break;
                case "Monthly":

                    break;
                case "Halfly":

                    stpPrimary.Visibility = Visibility.Collapsed;

                    break;
                case "Quarterly":
                    stpPrimary.Visibility = Visibility.Collapsed;
                    break;
                case "TillDate":
                    stpPrimary.Visibility = Visibility.Collapsed;
                    break;

                default:
                    break;
            }

        }

        private void stpHalf_Loaded(object sender, RoutedEventArgs e)
        {
            stpHalf = (sender as StackPanel);
            switch (viewModel.Type)
            {
                case "Yearly":

                    stpHalf.Visibility = Visibility.Collapsed;

                    break;
                case "Monthly":

                    stpHalf.Visibility = Visibility.Collapsed;

                    break;
                case "Halfly":
                    break;
                case "Quarterly":

                    stpHalf.Visibility = Visibility.Collapsed;

                    break;
                case "TillDate":

                    stpHalf.Visibility = Visibility.Collapsed;

                    break;

                default:
                    break;
            }

        }

        private void stpQuarter_Loaded(object sender, RoutedEventArgs e)
        {
            stpQuarter = (sender as StackPanel);
            switch (viewModel.Type)
            {
                case "Yearly":
                    stpQuarter.Visibility = Visibility.Collapsed;
                    break;
                case "Monthly":
                    stpQuarter.Visibility = Visibility.Collapsed;

                    break;
                case "Halfly":
                    stpQuarter.Visibility = Visibility.Collapsed;

                    break;
                case "Quarterly":

                    break;
                case "TillDate":
                    stpQuarter.Visibility = Visibility.Collapsed;

                    break;

                default:
                    break;
            }

        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            DashBoardViewModel.db.SaveChanges();

        }
    }
}


/*
             switch (viewModel.Type)
            {
                case "Yearly":
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "Monthly":
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "Halfly":
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpPrimary.Visibility = Visibility.Collapsed;
                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "Quarterly":
                    stpPrimary.Visibility = Visibility.Collapsed;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpTertiary.Visibility = Visibility.Collapsed;
                    break;
                case "TillDate":
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpPrimary.Visibility = Visibility.Collapsed;
                    break;

                default:
                    break;
            }

 */
