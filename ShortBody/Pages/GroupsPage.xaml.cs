using ShortBody.Models;
using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for GroupsPage.xaml
    /// </summary>
    public partial class GroupsPage : Page
    {
        public static GroupsPage servicesPage;
        GroupsViewModel viewModel;
        public GroupsPage()
        {
            InitializeComponent();
            viewModel = new GroupsViewModel();
            DataContext = viewModel;
            servicesPage = this;
        }



        private async void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            await DashBoardViewModel.db.SaveChangesAsync();
        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            switch (grid.Name)
            {
                case "MinistryGrid":
                    var ministry = grid.SelectedItem as Ministry;
                    if (ministry != null)
                        viewModel.AllMinistrySelectedId = ministry.MinistryId;
                    break;
                case "ZoneGrid":
                    var zone = grid.SelectedItem as Zone;
                    if (zone != null)
                        viewModel.AllZoneSelectedId = zone.ZoneId;
                    break;
                case "AreaGrid":
                    var area = grid.SelectedItem as Area;
                    if (area != null)
                        viewModel.AllAreaSelectedId = area.AreaId;
                    break;
                case "GroupGrid":
                    var group = grid.SelectedItem as Group;
                    if (group != null)
                        viewModel.AllGroupSelectedId = group.GroupId;
                    break;
                case "ClassGrid":
                    var _class = grid.SelectedItem as Class;
                    if (_class != null)
                        viewModel.AllClassSelectedId = _class.ClassId;
                    break;
            }

        }

        private void Grids_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.SelectedLeaderId = 0;
        }



    }
}
