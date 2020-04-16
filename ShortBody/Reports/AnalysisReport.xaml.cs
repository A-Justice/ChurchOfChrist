using ShortBody.Pages;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System.Windows;

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for AnalysisReport.xaml
    /// </summary>
    public partial class AnalysisReport : Window
    {
        ReportPageViewModel viewModel;
        public AnalysisReport()
        {
            InitializeComponent();
            viewModel = ReportPage.reportPage.viewModel;
            DataContext = viewModel;

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //  MainDocument.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                TopPanel.Visibility = Visibility.Collapsed;
                await Methods.PrintOnMultiPage(MainBorder);
            }
            catch { }
            finally
            {
                // MainDocument.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                TopPanel.Visibility = Visibility.Visible;
            }



        }
    }
}
