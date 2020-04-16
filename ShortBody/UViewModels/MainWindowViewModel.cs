using ShortBody.Enums;
using ShortBody.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public static event EventHandler<PageChangedEventArgs> _CurrentPageChanged;

        #region PrivateProperties
        private string ChurchName;
        private string userName;

        private string password;
        public static ApplicationPage currentPage;
        public ObservableCollection<Church> _churches;
        #endregion

        #region PublicProperties

        public static LocalAppContext db;
        public static Church selectedChurch;
        public static User currentUser;


        public ObservableCollection<Church> Churches
        {
            get { return _churches; }
            set
            {
                _churches = value;

            }
        }


        public RelayCommand LoginCommand { get; set; }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static ApplicationPage _CurrentPage
        {
            set
            {
                OnCurrentPageChanged(new PageChangedEventArgs(value));
            }
        }
        public ApplicationPage CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
            }
        }

        public Church SelectedChurch
        {
            get { return selectedChurch; }
            set
            {
                selectedChurch = value;
                if (selectedChurch != null)
                    ChurchName = selectedChurch.Name;

            }
        }

        //Hold the value of the logged in user
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

        #endregion
        private MainWindow mainWindow;

        public MainWindowViewModel()
        {
            // mainWindow = window;
            db = new LocalAppContext();
            try
            {

                var church = db.Churches.FirstOrDefault();
                if (church == null)
                    db.Churches.Add(new Church
                    {
                        Name = "Default",
                        Email = "Default@root.com",
                        Phone = "00000",
                        Address = "#Self",

                    });

                var users = db.Users.FirstOrDefault();
                if (users == null)
                    db.Users.Add(new User
                    {
                        FirstName = "default",
                        LastName = "",
                        Password = "root"
                    });

                var setting = db.Settings.FirstOrDefault();
                if (setting == null)
                    db.Settings.Add(new Setting()
                    {
                        MaxGroupNumber = 5,
                        MaxClassNumber = int.MaxValue,
                    });

                var masterPassword = db.MasterPasswords.FirstOrDefault();
                if (masterPassword == null)
                    db.MasterPasswords.Add(new MasterPassword()
                    {
                        Password = "root"
                    });


                db.SaveChanges();

            }
            catch { }


            LoadChurches();
            LoginCommand = new RelayCommand(Login_E, Login_C);
            CurrentPage = ApplicationPage.Login;
            _CurrentPageChanged += CurrentPage_Changed;

        }

        #region EventMethods

        protected static void OnCurrentPageChanged(PageChangedEventArgs e)
        {
            _CurrentPageChanged?.Invoke(null, e);
        }
        private void CurrentPage_Changed(object sender, PageChangedEventArgs e)
        {
            CurrentPage = e.page;
        }

        #endregion

        private void Login_E(object obj)
        {
            try
            {
                CurrentUser = db.Users.Where(i => i.FirstName == UserName && i.Password == Password).FirstOrDefault();
                if (CurrentUser != null && SelectedChurch != null)
                {

                    CurrentPage = ApplicationPage.DashBoard;

                }
                else if (CurrentUser == null)
                {
                    // CurrentPage = ApplicationPage.DashBoard;
                    MessageBox.Show("Please Enter a valid UserName and Password", "Invalid Credentials", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (SelectedChurch == null)
                {
                    MessageBox.Show("Please select a Church to continue", "Select Church", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch { }


        }

        private bool Login_C(object obj)
        {
            return true;
        }


        #region CommandMethods



        #endregion


        public void LoadChurches()
        {
            Churches = new ObservableCollection<Church>(db.Churches);
        }

        public void ResetCredentials()
        {
            selectedChurch = null;
            UserName = null;
            Password = null;
        }
    }



    public class PageChangedEventArgs : EventArgs
    {
        public ApplicationPage page;
        public PageChangedEventArgs(ApplicationPage _page)
        {
            page = _page;
        }
    }



}
