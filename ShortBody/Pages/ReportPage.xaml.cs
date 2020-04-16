using ShortBody.Reports;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    /// 

    public partial class ReportPage : Page
    {
        public static ReportPage reportPage;
        public ReportPageViewModel viewModel;
        public ReportPage()
        {
            InitializeComponent();
            viewModel = new ReportPageViewModel();
            DataContext = viewModel;
            reportPage = this;

            stpYear.Visibility = Visibility.Collapsed;
            stpHalf.Visibility = Visibility.Collapsed;
            stpQuarter.Visibility = Visibility.Collapsed;
            stpMonth.Visibility = Visibility.Collapsed;

        }


        private void cboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Text = Methods.GetComboBoxText(sender);


            switch (Text)
            {
                case "Yearly":
                    stpYear.Visibility = Visibility.Visible;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpMonth.Visibility = Visibility.Collapsed;

                    break;
                case "Monthly":
                    stpYear.Visibility = Visibility.Visible;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpMonth.Visibility = Visibility.Visible;
                    break;
                case "Halfly":
                    stpYear.Visibility = Visibility.Visible;
                    stpHalf.Visibility = Visibility.Visible;
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpMonth.Visibility = Visibility.Collapsed;
                    break;
                case "Quarterly":
                    stpYear.Visibility = Visibility.Visible;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpQuarter.Visibility = Visibility.Visible;
                    stpMonth.Visibility = Visibility.Collapsed;
                    break;
                case "TillDate":
                    stpYear.Visibility = Visibility.Collapsed;
                    stpHalf.Visibility = Visibility.Collapsed;
                    stpQuarter.Visibility = Visibility.Collapsed;
                    stpMonth.Visibility = Visibility.Collapsed;
                    break;

                default:
                    break;
            }


        }

        private void btnGenerateZoneReport_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            try
            {
                string TypeText = Methods.GetComboBoxText(cboType);
                if (viewModel.generateReport(TypeText))
                    new ZoneReport().ShowDialog();
            }
            catch (Exception ex) { }
        }

        private void btnGeneratePrintOut_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.CreatePrintOut())
                new PrintOut().ShowDialog();
        }

        private void cboAnalysisType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Text = Methods.GetComboBoxText(sender);

            switch (Text)
            {
                case "Yearly":
                    stpAnalysisYear.Visibility = Visibility.Visible;
                    stpAnalysisMonth.Visibility = Visibility.Collapsed;
                    break;
                case "Monthly":
                    stpAnalysisYear.Visibility = Visibility.Visible;
                    stpAnalysisMonth.Visibility = Visibility.Visible;
                    break;

                case "TillDate":
                    stpAnalysisYear.Visibility = Visibility.Collapsed;
                    stpAnalysisMonth.Visibility = Visibility.Collapsed;
                    break;
            }
        }




        /// <summary>
        /// Get the Text of A passed in ComboBox Only
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>


        private void btnGenerateAnalysis_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.Analyse())

                new AnalysisReport().ShowDialog();
        }
    }
}
