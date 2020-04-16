using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.Resources.UserControls;
using ShortBody.UViewModels;
using ShortBody.Windows;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace ShortBody
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : UserControl
    {
        bool opened;
        LinedButton previousButton;
        DashBoardViewModel viewModel;
        public static DashBoard dashBoard;
        public static event EventHandler BirthDayCountChanged;
        public static LocalAppContext db1;
        public DashBoard()
        {
            InitializeComponent();
            opened = false;
            viewModel = new DashBoardViewModel();
            this.DataContext = viewModel;
            previousButton = btnShowPeople;

            BirthDayCountChanged += DashBoardViewModel_BirthDayCountCountChanged;

            OnBirthDayCountChanged();
            dashBoard = this;
            //var m = new TextBlock();
        }



        private void btnSideNavToggler_Click(object sender, RoutedEventArgs e)
        {

            PaneAnimation(opened);

            if (opened)
                opened = false;
            else
                opened = true;
        }


        public void PaneAnimation(bool opened)
        {
            int from, to;
            if (opened)
            {
                from = 155;
                to = 45;
            }
            else
            {
                from = 45;
                to = 155;
            }


            var sb = new Storyboard();

            var da = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(.5)),
                DecelerationRatio = 0.9f
            };

            Storyboard.SetTargetProperty(da, new PropertyPath("Width"));
            sb.Children.Add(da);
            sb.Begin(SideNav);
        }

        private void LinedButton_Click(object sender, RoutedEventArgs e)
        {

            LinedButton currentButton = sender as LinedButton;


            try
            {
                MasterPasswordWindow mWindow = null;

                if (currentButton.Name == "btnChurches")
                {
                    mWindow = new MasterPasswordWindow(DashBoardPages.ChurchesPage);

                }
                else if (currentButton.Name == "btnUsers")
                {
                    mWindow = new MasterPasswordWindow(DashBoardPages.UsersPage);
                }

                if (mWindow.ShowDialog() == true)
                {
                    previousButton.ShowLine = false;

                    currentButton.ShowLine = true;

                    previousButton = currentButton;
                    return;
                }
                else
                    return;

            }
            catch
            {
            }



            previousButton.ShowLine = false;

            currentButton.ShowLine = true;

            previousButton = currentButton;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.Footer.Visibility = Visibility.Visible;
        }

        private async void DashBoardViewModel_BirthDayCountCountChanged(object sender, EventArgs e)
        {
            int tempNumber = 0;
            await Task.Run(() =>
            {

                try
                {
                    tempNumber = new LocalAppContext().People.Where(p => p.DateOfBirth.Day == DateTime.Now.Day && p.DateOfBirth.Month == DateTime.Now.Month).Count();

                }
                catch (Exception ex) { }
            });

            if (tempNumber != 0)
                btnBirthDayNotification.Count = tempNumber.ToString();
            else if (tempNumber == 0)
                btnBirthDayNotification.Count = "";
        }


        //private void StackPanel_Unloaded(object sender, RoutedEventArgs e)
        //{
        //    viewModel.db.SaveChanges();
        //}

        private void btnBirthDayNotification_Click(object sender, RoutedEventArgs e)
        {
            LinedButton_Click(btnShowPeople, null);
            viewModel.DashBoardPage = DashBoardPages.PeoplePage;
            PeoplePage.peoplePage.viewModel.SearchBy = "BirthDate";
            PeoplePage.peoplePage.viewModel.SearchString = DateTime.Now.Date.ToShortDateString();

            try
            {
                PeoplePage.peoplePage.viewModel.SearchPerson(true);
                //if (db1 != null)
                //    viewModel.SaveSearch(ref db1);

                //db1 = new LocalAppContext();
                //PeoplePage.peoplePage.viewModel.SearchPerson(db1.People.Where(i => i.ChurchId == viewModel.SelectedChurch.ChurchId).ToList(),
                //new LocalAppContext().People.Where(i => i.ChurchId == viewModel.SelectedChurch.ChurchId).ToList());
            }
            finally { }


        }


        protected virtual void OnBirthDayCountChanged()
        {
            BirthDayCountChanged.Invoke(null, null);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            new SettingsWindow().ShowDialog();
        }
    }
}
