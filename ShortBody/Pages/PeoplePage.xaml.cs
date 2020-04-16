using ShortBody.MiniPages;
using ShortBody.Models;
using ShortBody.UViewModels;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for PersonPage.xaml
    /// </summary>
    public partial class PeoplePage : Page
    {
        public PersonPageViewModel viewModel;
        public static PeoplePage peoplePage;
        public static Frame expansionFrame;
        Button SaveButton;
        Button EditButton;
        ComboBox AssociationBox;
        TextBlock tbAssociation;
        public PeoplePage()
        {
            InitializeComponent();
            viewModel = new PersonPageViewModel();
            DataContext = viewModel;
            peoplePage = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainPersonGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try
            {
                viewModel.AllPeopleSelectedId = ((Person)grid.SelectedItem)?.PersonId;
                AddPersonWindow.Visibility = Visibility.Collapsed;
                PersonWindow.Visibility = Visibility.Visible;
                PersonWindow.HeaderText = viewModel.SelectedPerson.FirstName + "  " + viewModel.SelectedPerson.LastName;

                //try to reset the ministry combobox in servicesMini
                //btnServices_Click(null,null);
            }
            catch { }

        }



        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {

            viewModel.ResetNewPerson();
            PersonWindow.Visibility = Visibility.Collapsed;
            if (AddPersonWindow.Visibility != Visibility.Visible)
                AddPersonWindow.Resize();

            EditButton.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void AddPersonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddPersonWindow.Visibility = Visibility.Collapsed;
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



        private void cboArea_Loaded(object sender, RoutedEventArgs e)
        {
            var box = sender as ComboBox;
            box.ItemsSource = DashBoardViewModel.db.Areas.ToList();
        }

        private void cboFamily_Loaded(object sender, RoutedEventArgs e)
        {
            var box = sender as ComboBox;
            box.ItemsSource = DashBoardViewModel.db.Families.ToList();
        }
        private void cboAssociation_Loaded(object sender, RoutedEventArgs e)
        {
            AssociationBox = sender as ComboBox;
            AssociationBox.ItemsSource = DashBoardViewModel.db.Groups.ToList();
        }
        private void PersonWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnServices_Click(object sender, RoutedEventArgs e)
        {
            setExpansionFrame<ServicesMini>(ServicesMini.servicesMini);
        }
        private void btnFamily_Click(object sender, RoutedEventArgs e)
        {
            setExpansionFrame<FamilyMini>(null);
        }
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            setExpansionFrame<DetailsMini>(DetailsMini.detailsMini);
        }



        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            expansionFrame = sender as Frame;
            setExpansionFrame<DetailsMini>(null);
        }

        private void btnEditPerson_Click(object sender, RoutedEventArgs e)
        {
            btnAddPerson_Click(null, null);
            viewModel.SetNewPerson();
            SaveButton.Visibility = Visibility.Collapsed;
            EditButton.Visibility = Visibility.Visible;

        }

        public void ToggleNewPersonInterface()
        {

        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content.Equals("Save"))
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
            AddPersonWindow.Resize();
        }


        void setExpansionFrame<T>(UserControl staticMini) where T : UserControl, new()
        {
            expansionFrame.Content = new T();
        }


        private void cboService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = sender as ComboBox;

            string selectedText = (box.SelectedValue as ComboBoxItem)?.Content.ToString();
            AssociationBox.SelectedItem = null;
            switch (selectedText)
            {
                case "Adults":
                    AssociationBox.ItemsSource = DashBoardViewModel.db.Groups.ToList();
                    tbAssociation.Text = "Group :";
                    break;
                case "Children":
                    AssociationBox.ItemsSource = DashBoardViewModel.db.Classes.ToList();
                    tbAssociation.Text = "Class :";
                    break;
            }
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            tbAssociation = sender as TextBlock;
        }

        private void txtSearchBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            viewModel.SearchPerson();
        }
    }
}
