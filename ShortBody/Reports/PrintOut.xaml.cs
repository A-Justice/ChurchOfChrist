using ShortBody.Pages;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShortBody.Reports
{
    /// <summary>
    /// Interaction logic for PrintOut.xaml
    /// </summary>
    public partial class PrintOut : Window
    {
        ReportPageViewModel viewModel = null;
        public PrintOut()
        {
            InitializeComponent();
            List<DateTime> dates = new List<DateTime>();

            viewModel = ReportPage.reportPage.viewModel;
            DataContext = viewModel;
            var currentMonth = viewModel.PrintOutDates[0].Month;

            foreach (var date in viewModel.PrintOutDates)
            {
                TextBlock day = new TextBlock
                {
                    Text = date.DayOfWeek.ToString().Substring(0, 3),
                    TextAlignment = TextAlignment.Center,
                    Width = 30,
                    Background = new BrushConverter().ConvertFrom("#D9D9D9") as SolidColorBrush,
                    Foreground = new BrushConverter().ConvertFrom("#FF2A55") as SolidColorBrush
                };

                TextBlock dayNumber = new TextBlock
                {
                    Text = date.Day.ToString(),
                    TextAlignment = TextAlignment.Center,
                    Width = 30,
                    Background = Brushes.White
                };

                StackPanel container = new StackPanel();
                container.Children.Add(day);
                container.Children.Add(dayNumber);

                switch (date)
                {
                    case DateTime n when (n.Day >= 1 && n.Day <= 7 && n.Month == currentMonth):
                        stpWeek1.Children.Add(container);
                        break;
                    case DateTime n when (n.Day >= 8 && n.Day <= 14):
                        stpWeek2.Children.Add(container);
                        break;
                    case DateTime n when (n.Day >= 15 && n.Day <= 21):
                        stpWeek3.Children.Add(container);
                        break;
                    case DateTime n when (n.Day >= 22 && n.Day <= 28):
                        stpWeek4.Children.Add(container);
                        break;
                    case DateTime n when (n.Day >= 29 && n.Day <= 31):
                        stpWeek5.Children.Add(container);
                        break;
                    case DateTime n when (n.Day >= 1 && n.Day <= 7 && n.Month != currentMonth):
                        stpWeek_1.Children.Add(container);
                        break;
                }


            }
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
