using ShortBody.MiniPages.Family;
using ShortBody.Models;
using ShortBody.UViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ShortBody.Pages
{
    /// <summary>
    /// Interaction logic for FamiliesPage.xaml
    /// </summary>

    public partial class FamiliesPage : Page
    {
        public FamilyPageViewModel viewModel;
        public static PeoplePage peoplePage;
        public static Frame expansionFrame;
        Button SaveButton;
        Button EditButton;
        public static FamiliesPage familiesPage;

        public FamiliesPage()
        {
            InitializeComponent();
            viewModel = new FamilyPageViewModel();
            DataContext = viewModel;
            familiesPage = this;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainFamilyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            try
            {
                viewModel.AllFamiliesSelectedId = ((Family)grid.SelectedItem)?.FamilyId;
                AddFamilyWindow.Visibility = Visibility.Collapsed;
                FamilyWindow.Visibility = Visibility.Visible;
                FamilyWindow.HeaderText = viewModel.SelectedFamily.FamilyName;


                btnFamilyDetails_Click(null, null);
            }
            catch { }

        }



        private void btnAddFamily_Click(object sender, RoutedEventArgs e)
        {

            viewModel.ResetNewFamily();
            FamilyWindow.Visibility = Visibility.Collapsed;
            if (AddFamilyWindow.Visibility != Visibility.Visible)
                AddFamilyWindow.Resize();

            EditButton.Visibility = Visibility.Collapsed;
            SaveButton.Visibility = Visibility.Visible;
        }

        private void AddFamilyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AddFamilyWindow.Visibility = Visibility.Collapsed;
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

        //private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var box = sender as ComboBox;
        //    box.ItemsSource = DashBoardViewModel.db.Services.ToList();
        //}

        //private void cboArea_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var box = sender as ComboBox;
        //    box.ItemsSource = DashBoardViewModel.db.Areas.ToList();
        //}

        private void FamilyWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            expansionFrame = sender as Frame;
            btnFamilyDetails_Click(null, null);
        }

        private void btnEditFamily_Click(object sender, RoutedEventArgs e)
        {
            btnAddFamily_Click(null, null);
            viewModel.SetNewFamily();
            SaveButton.Visibility = Visibility.Collapsed;
            EditButton.Visibility = Visibility.Visible;

        }

        public void ToggleNewFamilyInterface()
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
            AddFamilyWindow.Resize();
        }

        private void btnFamilyDetails_Click(object sender, RoutedEventArgs e)
        {
            setExpansionFrame<FamilyDetailsMini>(null);
        }


        void setExpansionFrame<T>(UserControl staticMini) where T : UserControl, new()
        {
            expansionFrame.Content = new T();
        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                viewModel.SearchBy = viewModel.SearchString == "" ? "All" : viewModel.SearchBy;
                viewModel.SearchFamily();
            }
            catch { }
        }
    }
}
