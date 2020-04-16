using ShortBody.MiniPages.Event;
using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for AttendancePage.xaml
    /// </summary>
    /// 

    public partial class EventsPage : Page
    {
        public EventsPageViewModel viewModel;
        public static EventsPage eventsPage;
        public static Frame expansionFrame;
        Button SaveButton;
        Button EditButton;
        public EventsPage()
        {
            InitializeComponent();
            viewModel = new EventsPageViewModel();
            DataContext = viewModel;
            eventsPage = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainEventGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try
            {
                var _event = grid.SelectedItem as Event;
                AddEventWindow.Visibility = Visibility.Collapsed;
                EventWindow.Visibility = Visibility.Visible;
                viewModel.AllEventsSelectedId = _event.EventId;
                EventWindow.HeaderText = viewModel.SelectedEvent.Date.ToLongDateString();

                //try to reset the ministry combobox in servicesMini
                //btnServices_Click(null,null);
            }
            catch (Exception ex) { }

        }



        private void btnAddEvent_Click(object sender, RoutedEventArgs e)
        {

            viewModel.ResetNewEvent();
            EventWindow.Visibility = Visibility.Collapsed;
            if (AddEventWindow.Visibility != Visibility.Visible)
                AddEventWindow.Resize();

            EditButton.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void AddEventWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddEventWindow.Visibility = Visibility.Collapsed;
        }

        private void cboSearchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var text = Methods.GetComboBoxText(sender);

            switch (text)
            {
                case "All":
                    viewModel.SearchString = ",";
                    cboSearchYear.Visibility = Visibility.Collapsed;
                    cboSearchMonth.Visibility = Visibility.Collapsed;
                    cboSearchDay.Visibility = Visibility.Collapsed;
                    break;
                case "Day":
                    cboSearchYear.Visibility = Visibility.Collapsed;
                    cboSearchMonth.Visibility = Visibility.Collapsed;
                    cboSearchDay.Visibility = Visibility.Visible;
                    break;
                case "Month":
                    cboSearchYear.Visibility = Visibility.Collapsed;
                    cboSearchMonth.Visibility = Visibility.Visible;
                    cboSearchDay.Visibility = Visibility.Collapsed;
                    break;
                case "Year":
                    cboSearchYear.Visibility = Visibility.Visible;
                    cboSearchMonth.Visibility = Visibility.Collapsed;
                    cboSearchDay.Visibility = Visibility.Collapsed;
                    break;
            }
        }




        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            setExpansionFrame<EventDetailsMini>(null);
        }



        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            expansionFrame = sender as Frame;
            setExpansionFrame<EventDetailsMini>(null);
        }

        private void btnEditEvent_Click(object sender, RoutedEventArgs e)
        {
            btnAddEvent_Click(null, null);
            viewModel.SetNewEvent();
            SaveButton.Visibility = Visibility.Collapsed;
            EditButton.Visibility = Visibility.Visible;

        }

        public void ToggleNewEventInterface()
        {

        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content.Equals("Add"))
            {
                SaveButton = btn;
            }
            else
            {
                EditButton = btn;
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEventWindow.Resize();
        }


        void setExpansionFrame<T>(UserControl staticMini) where T : UserControl, new()
        {
            expansionFrame.Content = new T();
        }

        private void cboSearchBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
