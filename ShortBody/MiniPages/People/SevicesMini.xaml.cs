using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.UViewModels;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.MiniPages
{
    /// <summary>
    /// Interaction logic for ServicesMini.xaml
    /// </summary>
    public partial class ServicesMini : UserControl
    {

        public static UserControl servicesMini;
        PersonPageViewModel viewModel;
        string oldBoxContent;
        public ServicesMini()
        {
            InitializeComponent();
            viewModel = PeoplePage.peoplePage.viewModel;
            DataContext = viewModel;
            servicesMini = this;
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var cbo = sender as ComboBox;
            switch (cbo.Name)
            {

                case "cboClass":
                    cbo.ItemsSource = DashBoardViewModel.db.Classes.ToList();
                    break;
                case "cboGroup":
                    cbo.ItemsSource = DashBoardViewModel.db.Groups.ToList();
                    break;
                case "cboMinistry":
                    cbo.ItemsSource = DashBoardViewModel.db.Ministries.ToList();
                    break;
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn.Name == "btnSaveService")
            {

                respondToButtonText(cboService);

            }
            else if (btn.Name == "btnSaveClass")
                respondToButtonText(cboClass);
            else if (btn.Name == "btnSaveGroup")
                respondToButtonText(cboGroup);
            else if (btn.Name == "")
                cboMinistry.Text = "";

            void respondToButtonText(ComboBox box)
            {
                if ((string)btn.Content == "Change")
                {
                    box.IsEnabled = true;
                    btn.Content = "Save";


                }
                else if ((string)btn.Content == "Save")
                {
                    if (viewModel.SelectedPerson.Service == "Adults")
                        viewModel.SelectedPerson.Class = null;
                    else
                        viewModel.SelectedPerson.Group = null;
                    DashBoardViewModel.db.SaveChanges();
                    box.IsEnabled = false;
                    btn.Content = "Change";
                }


                if (oldBoxContent == viewModel.SelectedPerson.Service)
                    return;
                else
                {
                    //Change which stackpanel shows when the person's service is changed
                    switch (viewModel.SelectedPerson.Service)
                    {
                        case "Adults":
                            stpClass.Visibility = Visibility.Collapsed;
                            stpGroup.Visibility = Visibility.Visible;
                            break;
                        case "Children":
                            stpClass.Visibility = Visibility.Visible;
                            stpGroup.Visibility = Visibility.Collapsed;
                            break;
                    }
                }
            }

            oldBoxContent = (cboService.SelectedValue as ComboBoxItem).Content.ToString();
        }

        private void dgPMinistries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            var ministry = grid.SelectedItem as Ministry;
            if (ministry != null)
                viewModel.PMinistrySelectedId = ministry.MinistryId;
        }

        private void cboService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
