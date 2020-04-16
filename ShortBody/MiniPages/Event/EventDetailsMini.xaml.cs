using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ShortBody.MiniPages.Event
{
    /// <summary>
    /// Interaction logic for EventDetailsMini.xaml
    /// </summary>
    public partial class EventDetailsMini : UserControl
    {
        EventsPageViewModel viewModel;
        public EventDetailsMini()
        {
            InitializeComponent();
            viewModel = EventsPage.eventsPage.viewModel;
            DataContext = viewModel;
        }

        private void AllPeopleGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.allMembersSelectedId = ReturnSelectedPersonId(sender);
        }

        private void AttendeesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.allAttendantsSelectedId = ReturnSelectedPersonId(sender);
        }

        public int? ReturnSelectedPersonId(object sender)
        {
            var grid = sender as DataGrid;
            var person = grid.SelectedItem as Person;
            return person?.PersonId;
        }

        private void cboSearchMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSearchMembers.SelectedIndex == 0)
            {
                txtSearchMembers.Visibility = Visibility.Collapsed;
                return;
            }
            txtSearchMembers.Visibility = Visibility.Visible;
        }

        private void cboSearchAttendants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSearchAttendants.SelectedIndex == 0)
            {
                txtSearchAttendants.Visibility = Visibility.Collapsed;
                return;
            }
            txtSearchAttendants.Visibility = Visibility.Visible;
        }

        private void txtSearchMembers_KeyUp(object sender, KeyEventArgs e)
        {
            viewModel.SearchEvent(SearchParameter.Members);
        }

        private void txtSearchAttendants_KeyUp(object sender, KeyEventArgs e)
        {
            viewModel.SearchEvent(SearchParameter.Attendants);
        }
    }
}
