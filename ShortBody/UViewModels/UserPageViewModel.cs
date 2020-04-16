using Microsoft.Win32;
using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModel
{
    public class UserPageViewModel : DashBoardViewModel, IDataErrorInfo
    {


        #region privateVariable
        User newUser;
        public ObservableCollection<User> allUsers;
        private string error;
        private object userImage;
        private string strName;
        private string imageName;
        private string searchBy;
        private string searchString;
        #endregion

        #region PublicProperties

        public string SearchBy
        {
            get { return searchBy; }
            set
            {
                searchBy = value;

            }
        }

        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; }
        }


        public object UserImage
        {
            get { return userImage; }
            set { userImage = value; }
        }

        public ObservableCollection<User> AllUsers
        {
            get { return allUsers; }
            set { allUsers = value; }
        }
        public User NewUser
        {
            get
            {
                return newUser;
            }
            set
            {
                newUser = value;

            }
        }

        public RelayCommand DeleteUserCommand { get; set; }

        public RelayCommand SaveNewUserCommand { get; set; }


        public int? allUsersSelectedId { get; set; }

        public string Error
        {
            get { return error; }
            set
            {
                error = value;

            }
        }

        public RelayCommand BrowseCommand { get; set; }
        public RelayCommand ClearBoxes { get; set; }
        public RelayCommand SearchUserCommand { get; private set; }
        public RelayCommand ChangeUserImageCommand { get; private set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewUser")
                {
                    return "Please provide values for all fields";
                }
                if (columnName == "Duplicate")
                {
                    return "A User with the same credentials already exists";
                }
                return null;
            }
        }
        #endregion

        #region Constructors
        public UserPageViewModel()
        {
            newUser = new User();
            BrowseCommand = new RelayCommand(Browse_E, Browse_C);
            DeleteUserCommand = new RelayCommand(delete_E, delete_C);
            SaveNewUserCommand = new RelayCommand(saveNc_E, saveNc_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            AllUsers = new ObservableCollection<User>(db.Users);
            ChangeUserImageCommand = new RelayCommand(null, _ =>
            {
                if (allUsersSelectedId < 0 || allUsersSelectedId == null)
                    return false;
                return true;
            });
            SearchUserCommand = new RelayCommand(_ =>
            {
                SearchUsers();
            });
        }

        #endregion

        #region EventMethods
        private void UserPageViewModel_UserChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region CommandMethods
        private void cBoxes_E(object obj)
        {
            NewUser = new User();
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Can Execute Method for saving a new User
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNc_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new User
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNc_E(object obj)
        {

            //Check if the User has already been added
            var User = db.Users.Where(i => i.FirstName == newUser.FirstName && i.LastName == newUser.LastName && i.Password == newUser.Password).FirstOrDefault();
            bool IsUserValid = ValidateNewUser(NewUser);
            if (User == null && IsUserValid)
            {
                // NewUser.ChurchId = SelectedChurch.ChurchId;
                // add the new User
                db.Users.Add(NewUser);
                //NewUser.UserImage = ChurchPageViewModel.GetImageBytes(imageName);
                db.SaveChanges();
                NewUser = new User();
                refreshCs_E(null);
                // show messagebox to alert success;
                MessageBox.Show("User Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (User != null)
            {
                Error = this["Duplicate"];
                return;
            }
            if (!IsUserValid)
                return;
            // show Message Box  to alert failure
            MessageBox.Show("Failed to Add User", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private new void refreshCs_E(object parameter)
        {
            UserImage = null;
            AllUsers = new ObservableCollection<User>(db.Users);
        }

        private bool saveCs_C(object obj)
        {
            if (edited == false)
                return false;
            else
            {
                edited = false;
                return true;
            }

        }



        private bool delete_C(object obj)
        {
            if (allUsersSelectedId == null || allUsersSelectedId < 0)
                return false;
            else
                return true;
        }

        private void delete_E(object obj)
        {
            try
            {

                if (allUsersSelectedId == null || allUsersSelectedId < 0)
                {
                    MessageBox.Show("Please select a User to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected User", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    db.Users.Remove(db.Users.Find(allUsersSelectedId));
                    // AllUsers.Remove(db.Users.Find(allUsersSelectedId));
                    AllUsers = new ObservableCollection<User>(db.Users);
                    db.SaveChanges();
                    refreshCs_E(null);
                }

            }
            catch
            {

            }
        }

        #region CommandMethods

        private void Browse_E(object obj)
        {

            try
            {
                FileDialog fldlg = new OpenFileDialog();
                fldlg.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                fldlg.ShowDialog();
                {
                    strName = fldlg.SafeFileName;
                    imageName = fldlg.FileName;
                    ImageSourceConverter isc = new ImageSourceConverter();
                    UserImage = isc.ConvertFromString(imageName);
                    //  imgBox.SetValue(Image.SourceProperty,);
                }
                fldlg = null;
            }
            catch
            {

            }
        }

        private bool Browse_C(object obj)
        {
            return true;
        }


        #endregion


        #endregion




        #region Methods

        public bool ValidateNewUser(User User)
        {
            if (User.FirstName == null || User.Password == null)
            {
                Error = this["NewUser"];
                return false;
            }

            Error = null;
            return true;

        }

        public void ResetUserImage()
        {
            try
            {
                Browse_E(null);

                db.Users.Find(allUsersSelectedId).UserImage = Methods.GetImageBytes(imageName);
                db.SaveChanges();

                if (MessageBox.Show("User Image was  changed Successfully,Changes would be applied on next login, Would you like to logout Now ?", "Success", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    LoginPage.IsLoggedOut = true;
                    MainWindowViewModel._CurrentPage = ApplicationPage.Login;
                }

            }
            catch
            {
                MessageBox.Show("User Image was not changed,retry again later", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        public async void SearchUsers()
        {
            ObservableCollection<User> searchedUsers = new ObservableCollection<User>(db.Users.ToList());

            await Task.Run(() =>
            {
                if (SearchBy == "FirstName")
                    searchedUsers = new ObservableCollection<User>(searchedUsers.Where(i => i.FirstName.ToLower().StartsWith(SearchString.ToLower())));
                else if (SearchBy == "LastName")
                    searchedUsers = new ObservableCollection<User>(searchedUsers.Where(i => i.LastName.ToLower().StartsWith(SearchString.ToLower())));
            });

            AllUsers = searchedUsers;
        }

        #endregion
    }
}