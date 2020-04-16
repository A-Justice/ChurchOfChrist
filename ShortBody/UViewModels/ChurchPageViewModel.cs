using ShortBody.Enums;
using ShortBody.Models;
using ShortBody.Pages;
using ShortBody.Resources.Helper_Methods;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class ChurchPageViewModel : DashBoardViewModel, IDataErrorInfo
    {

        #region privateVariables
        SynchronizationContext currentContext;
        public object logo;
        //  private string strName;
        private string imagePath;
        private string imageName;
        private Church newChurch;

        private ChurchAccountDetail newChurchAccount;
        private Church focusedChurch;
        private string error;
        private string oerror;
        internal int? allOperationSelectedId;
        internal int? allAccDetailSelectedId;
        private string searchBy;
        private string searchString;
        #endregion

        #region PublicVariables

        public int? allChurchSelectedId { get; internal set; }


        #endregion


        #region publicProperties

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

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Duplicate")
                {
                    return "The Item Already Exists";
                }
                if (columnName == "ProvideValues")
                {
                    return "Please Provide Values for all fields";
                }
                return "";
            }
        }


        public string Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;

            }

        }

        public string OError
        {
            get { return oerror; }
            set
            {
                oerror = value;

            }
        }

        public ObservableCollection<Church> AllChurches
        {
            get { return allChurches; }
            set { allChurches = value; }
        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set { imagePath = value; }
        }

        public RelayCommand BrowseCommand { get; set; }

        public RelayCommand SaveChurchCommand { get; set; }
        public RelayCommand SaveOperationCommand { get; set; }
        public RelayCommand SaveAccountCommand { get; set; }

        public RelayCommand ClearBoxes { get; set; }
        public RelayCommand DeleteChurchCommand { get; set; }
        public RelayCommand DeleteAccDetailCommand { get; private set; }
        public RelayCommand DeleteOperationCommand { get; private set; }
        public RelayCommand GeneralCommand { get; private set; }


        public Church FocusedChurch
        {
            get
            {
                return focusedChurch;
            }
            set
            {
                focusedChurch = value;

            }
        }


        public new object Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        public Church NewChurch
        {
            get
            {
                return newChurch;
            }
            set
            {
                newChurch = value;

            }
        }



        public ChurchAccountDetail NewChurchAccount
        {
            get { return newChurchAccount; }
            set { newChurchAccount = value; }
        }

        public RelayCommand SearchChurchCommand { get; private set; }

        public ObservableCollection<Church> allChurches;

        #endregion


        #region constructor

        public ChurchPageViewModel()
        {
            try
            {
                NewChurch = new Church();

                NewChurchAccount = new ChurchAccountDetail();
                BrowseCommand = new RelayCommand(Browse_E, Browse_C);
                SaveChurchCommand = new RelayCommand(SaveChurch_E, SaveChurch_C);

                SaveAccountCommand = new RelayCommand(SaveAccountCommand_E, SaveAccountCommand_C);
                DeleteChurchCommand = new RelayCommand(DeleteChurch_E, General_C);
                GeneralCommand = new RelayCommand(null, General_C);
                DeleteAccDetailCommand = new RelayCommand(DeleteAccDetail_E, General_C);
                ClearBoxes = new RelayCommand(Clear_E);
                AllChurches = new ObservableCollection<Church>(db.Churches);
                currentContext = SynchronizationContext.Current;
                SearchChurchCommand = new RelayCommand(_ =>
                {
                    SearchChurch();
                });
            }
            catch { }

        }



        #endregion

        #region CommandMethods

        public new void refreshCs_E(object parameter)
        {
            Logo = null;
            AllChurches = new ObservableCollection<Church>(db.Churches);
        }

        private void Browse_E(object obj)
        {
            var result = Methods.BrowsePic();
            imageName = result[0].ToString();
            Logo = result[1];
        }

        private bool Browse_C(object obj)
        {
            return true;
        }


        private bool General_C(object obj)
        {
            if (allChurchSelectedId == null)
                return false;
            return true;
        }


        private bool DeleteOperation_C(object obj)
        {
            if (allOperationSelectedId == null)
                return false;
            return true;
        }

        private void DeleteAccDetail_E(object obj)
        {
            try
            {

                if (allAccDetailSelectedId == null || allAccDetailSelectedId < 0)
                {
                    MessageBox.Show("Please select an Account to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Account", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var AccDetail = db.ChurchAccountDetails.Find(allAccDetailSelectedId);
                    focusedChurch.AccountDetails.Remove(AccDetail);
                    db.ChurchAccountDetails.Remove(AccDetail);
                    db.SaveChanges();
                    refreshCs_E(null);

                    SetFocusedChurch();
                    var accountdetails = FocusedChurch.AccountDetails;
                    FocusedChurch.AccountDetails = null;
                    FocusedChurch.AccountDetails = accountdetails;
                }

            }
            catch
            {

            }
        }


        private void DeleteChurch_E(object obj)
        {
            try
            {
                if (allChurchSelectedId == null || allChurchSelectedId < 0)
                {
                    MessageBox.Show("Please select a Church to delete");
                    return;
                }

                if (MessageBox.Show("Deleting a Church would also delete all data about the Church , Including data of all people " +
                                    "and events, Click Okay to Proceed", "Permanent Delete Information", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.Cancel)
                    return;

                if (allChurchSelectedId == 1)
                {
                    MessageBox.Show("Default Church Cannot be deleted", "Invalid Operation", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                var Church = db.Churches.Find(allChurchSelectedId);
                if (Church == SelectedChurch)
                {
                    MessageBox.Show("The Currently Selected Church Cannot be deleted", "Invalid Operation", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                else if (MessageBox.Show("Are you sure you want to delete the selected Church", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    db.Churches.Remove(Church);
                    currentContext.Post(_ =>
                    {
                        AllChurches.Remove(Church);
                    }, null);

                    db.SaveChanges();
                    refreshCs_E(null);
                }

            }
            catch
            {

            }
        }

        private void Clear_E(object parameter)
        {

            NewChurchAccount = new ChurchAccountDetail();
            NewChurch = new Church();
        }

        private void SaveAccountCommand_E(object obj)
        {
            try
            {
                var account = db.ChurchAccountDetails.Where(i => i.AccountName == NewChurchAccount.AccountName && i.AccountNumber == NewChurchAccount.AccountNumber && i.BankBranch == NewChurchAccount.BankBranch).FirstOrDefault();

                bool IsAccountValid = ValidateAccount(NewChurchAccount);
                if (account == null && IsAccountValid)
                {

                    NewChurchAccount.ChurchId = FocusedChurch.ChurchId;
                    focusedChurch.AccountDetails.Add(NewChurchAccount);
                    db.ChurchAccountDetails.Add(NewChurchAccount);
                    db.SaveChanges();
                    NewChurchAccount = new ChurchAccountDetail();
                    refreshCs_E(null);
                    SetFocusedChurch();
                    FocusedChurch.AccountDetails = focusedChurch.AccountDetails;
                    // show messagebox to alert success;
                    MessageBox.Show("Account Detail Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else if (account != null)
                {
                    Error = this["Duplicate"];
                }
                if (!IsAccountValid)
                    return;


            }
            catch
            {  // show Message Box  to alert failure
                MessageBox.Show("Failed to add Account detail", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private bool ValidateAccount(ChurchAccountDetail newChurchAccount)
        {
            if (string.IsNullOrWhiteSpace(newChurchAccount.AccountName) || string.IsNullOrEmpty(newChurchAccount.AccountNumber) || string.IsNullOrEmpty(newChurchAccount.BankName) || string.IsNullOrEmpty(newChurchAccount.BankBranch)
            )
            {
                Error = this["ProvideValues"];
                return false;
            }

            Error = null;
            return true;
        }

        private bool SaveAccountCommand_C(object obj)
        {
            return true;
        }

        private void SaveChurch_E(object obj)
        {
            //Check if the Church has already been added
            var Church = db.Churches.Where(i => i.Name == NewChurch.Name && i.Address == NewChurch.Address && i.Email == NewChurch.Email).FirstOrDefault();
            if (Church == null)//&& ValidateNewClient(NewClient)
            {

                NewChurch.Logo = Methods.GetImageBytes(imageName);
                db.Churches.Add(NewChurch);

                db.SaveChanges();
                NewChurch = new Church();
                refreshCs_E(null);
                // show messagebox to alert success;
                MessageBox.Show("Church Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (Church != null)
            {
                Error = this["Duplicate"];
            }
            else
            {
                Error = this["ProvideValues"];
            }

            // show Message Box  to alert failure
            MessageBox.Show("Church to Add Client", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool SaveChurch_C(object obj)
        {
            return true;
        }


        #endregion





        /// <summary>
        /// Reset the currently focused Church when User Selection Changes
        /// </summary>
        public void SetFocusedChurch() => FocusedChurch = db.Churches.Find(allChurchSelectedId);


        public void ResetChurchLogo()
        {
            try
            {
                Browse_E(null);
                FocusedChurch.Logo = Methods.GetImageBytes(imageName);
                db.SaveChanges();

                if (MessageBox.Show("Church Image was  changed Successfully,Changes would be applied on next login, Would you like to logout Now ?", "Success", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    LoginPage.IsLoggedOut = true;
                    MainWindowViewModel._CurrentPage = ApplicationPage.Login;
                }

            }
            catch
            {
                MessageBox.Show("Church Image was not changed,retry again later", "Operation Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public async void SearchChurch()
        {
            ObservableCollection<Church> searchedChurches = new ObservableCollection<Church>(db.Churches);

            await Task.Run(() =>
            {
                if (SearchBy == "Name")
                    searchedChurches = new ObservableCollection<Church>(db.Churches.Where(i => i.Name.ToLower().StartsWith(SearchString.ToLower())));
            });

            AllChurches = searchedChurches;
        }

    }
}
