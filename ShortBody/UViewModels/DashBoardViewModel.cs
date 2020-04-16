using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class DashBoardViewModel : ObservableObject
    {
        public static event EventHandler clientChanged;
        public static event EventHandler<DashBoardEventArgs> PageChanged;

        public static LocalAppContext db;
        #region PrivateProperties

        private DashBoardPages dashboardPages;
        public static ObservableCollection<Person> allPeople;
        private object logo;
        protected bool edited;
        private Church selectedChurch;
        private string ChurchName;
        private SynchronizationContext currentContext = SynchronizationContext.Current;
        private User currentUser;
        #endregion

        #region PublicProperties



        public static DashBoardPages dbPage
        {
            set
            {
                OnPageChanged(new DashBoardEventArgs(value));
            }
        }
        public User CurrentUser
        {
            get
            {
                return currentUser;

            }
            set
            {
                currentUser = value;

            }
        }


        public Church SelectedChurch
        {
            get
            {
                return selectedChurch;
            }
            set
            {
                selectedChurch = value;

            }
        }

        public object Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        public RelayCommand RefreshAllPeople { get; set; }
        public ObservableCollection<Person> AllPeople
        {
            get
            {
                return allPeople;
            }
            set
            {
                allPeople = value;
                edited = true;
                OnClientChanged();

            }
        }

        public DashBoardPages DashBoardPage
        {
            get
            {
                return dashboardPages;

            }
            set
            {
                dashboardPages = value;

            }
        }

        public RelayCommand OpenClients { get; set; }

        public RelayCommand OpenServices { get; set; }

        public RelayCommand OpenFamilies { get; set; }

        public RelayCommand OpenAttendance { get; set; }


        public RelayCommand OpenReports { get; set; }


        public RelayCommand OpenChurches { get; set; }
        public RelayCommand OpenUsers { get; set; }

        public RelayCommand LogoutCommand { get; set; }

        #endregion


        public DashBoardViewModel()
        {
            PageChanged += DashBoardViewModel_PageChanged;

            try
            {

                db = MainWindowViewModel.db;

                //set the current Church as the first on in the Church list
                //Change this later

                if (MainWindowViewModel.selectedChurch != null)//currentChurch != null
                {

                    OpenChurches = new RelayCommand(this.oChurches_E, this.Generic_C);
                    SelectedChurch = MainWindowViewModel.selectedChurch;
                    CurrentUser = MainWindowViewModel.currentUser;
                    ChurchName = SelectedChurch.Name;
                    AllPeople = new ObservableCollection<Person>(SelectedChurch.People);
                    OpenClients = new RelayCommand(_ => { OpenPage(DashBoardPages.PeoplePage); }, this.Generic_C);
                    OpenServices = new RelayCommand(_ => { OpenPage(DashBoardPages.GroupsPage); }, this.Generic_C);
                    OpenFamilies = new RelayCommand(_ => { OpenPage(DashBoardPages.FamilyPage); }, Generic_C);
                    OpenReports = new RelayCommand(_ => { OpenPage(DashBoardPages.ReportsPage); }, Generic_C);
                    OpenAttendance = new RelayCommand(_ => { OpenPage(DashBoardPages.AttendancePage); }, Generic_C);

                    RefreshAllPeople = new RelayCommand(this.refreshCs_E, this.refreshCs_C);
                    LogoutCommand = new RelayCommand(t =>
                    {

                        if (MessageBox.Show("Are you sure you want to log out of the Application", "Confirm Logout", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            LoginPage.IsLoggedOut = true;
                            MainWindowViewModel._CurrentPage = ApplicationPage.Login;
                        }
                    });
                    OpenUsers = new RelayCommand(oUsers_E, Generic_C);


                    //GetLogo(SelectedChurch.Logo);
                    Logo = SelectedChurch.Logo;
                }
                else
                {
                    MessageBox.Show("Please Select a Church", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    MainWindowViewModel.currentPage = ApplicationPage.Login;
                }

            }
            catch
            {
                // MessageBox.Show("");
            }

        }

        public void OpenPage(DashBoardPages page)
        {
            DashBoardPage = page;
        }


        private void DashBoardViewModel_PageChanged(object sender, DashBoardEventArgs e)
        {
            DashBoardPage = e.Page;
        }

        private void oUsers_E(object obj)
        {
            currentContext.Post(_ =>
            {

            }, null);
        }

        private bool oUser_C(object obj)
        {
            return true;
        }

        private void oChurches_E(object obj)
        {

            currentContext.Post(_ =>
            {

            }, null);
        }



        #region CommandMethods

        public bool refreshCs_C(object obj)
        {
            return true;
        }

        public void refreshCs_E(object obj)
        {
            db.SaveChanges();

            AllPeople = new ObservableCollection<Person>(SelectedChurch.People);
        }

        #region sideNavCommands

        #region Executes








        #endregion

        #region Canexecutes

        public bool Generic_C(object parameter)
        {
            return true;
        }
        private bool OpenOffertory_C(object obj)
        {
            return true;
        }

        private bool OpenEspenses_C(object obj)
        {
            return true;
        }

        private bool OpenSupplierss_C(object obj)
        {
            return true;
        }

        private bool OpenQuotation_C(object obj)
        {
            return true;
        }

        private bool OpenServices_C(object obj)
        {
            return true;
        }
        #endregion


        #endregion

        #endregion


        #region eventMethod
        protected void OnClientChanged()
        {
            clientChanged?.Invoke(this, null);
        }

        #endregion



        #region HelperMethods

        private void GetLogo(byte[] imgbytes)
        {

            //var task =  GetBitmap(imgbytes);

            //task.ContinueWith(t =>
            //{
            //    Logo = t.Result;
            //},TaskScheduler.FromCurrentSynchronizationContext());



        }


        //public async static Task<BitmapImage> GetBitmap(byte[] imgbytes)
        //{

        //    try
        //    {
        //        BitmapImage bi = new BitmapImage();
        //        //Store binary data read from the database in a byte array
        //        byte[] logo = imgbytes;
        //        MemoryStream stream = new MemoryStream();
        //        stream.Write(logo, 0, logo.Length);
        //        stream.Position = 0;

        //        System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
        //        bi = new BitmapImage();
        //        bi.BeginInit();

        //        MemoryStream ms = new MemoryStream();
        //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
        //        ms.Seek(0, SeekOrigin.Begin);
        //        bi.StreamSource = ms;
        //        bi.EndInit();
        //        return bi;
        //    }
        //    catch { return null; }

        //    //});
        //}



        public void DeleteAssociations<T>(DbSet<T> mainSet, IQueryable<T> items)
            where T : class, new()
        {
            mainSet.RemoveRange(items);
            db.SaveChanges();
        }

        protected static void OnPageChanged(DashBoardEventArgs e)
        {
            PageChanged?.Invoke(null, e);
        }



        #endregion
    }

    public class DashBoardEventArgs : EventArgs
    {
        public DashBoardPages Page { get; set; }

        public DashBoardEventArgs(DashBoardPages page)
        {
            Page = page;
        }


    }


}
