using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class FamilyPageViewModel : DashBoardViewModel
    {
        #region privateVariable
        Family newFamily;
        private string error;
        private string pictureName;
        private int? _allFamiliesSelectedId;
        private string searchBy;
        private string searchString;
        private Family selectedFamily;

        #endregion

        #region PublicProperties


        private ObservableCollection<Family> allFamilies;

        public ObservableCollection<Family> AllFamilies
        {
            get { return allFamilies; }
            set { allFamilies = value; }
        }



        public string SearchBy
        {
            get { return searchBy; }
            set
            {
                searchBy = value;

            }
        }

        private byte[] picture;

        public byte[] Picture
        {
            get { return picture; }
            set { picture = value; }
        }


        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; }
        }


        public Family NewFamily
        {
            get
            {
                return newFamily;
            }
            set
            {
                newFamily = value;

            }
        }

        public Ministry NewMinistry { get; set; }

        public RelayCommand DeleteFamilyCommand { get; set; }

        public RelayCommand EditFamilyCommand { get; set; }
        public RelayCommand SaveFamiliesCommand { get; set; }

        public RelayCommand SaveNewFamilyCommand { get; set; }

        public RelayCommand BrowsePicCommand { get; set; }

        public RelayCommand AddToMinistryCommand { get; set; }
        public RelayCommand RemoveFromMinistryCommand { get; set; }

        public int? AllFamiliesSelectedId
        {
            get { return _allFamiliesSelectedId; }
            set
            {
                _allFamiliesSelectedId = value;
                SelectedFamily = GetFamily(value);

            }
        }



        public Family SelectedFamily
        {
            get { return selectedFamily; }
            set { selectedFamily = value; }
        }


        public string Error
        {
            get { return error; }
            set
            {
                error = value;

            }
        }

        public RelayCommand ClearBoxes { get; set; }

        public RelayCommand SearchFamilyCommand { get; private set; }
        public int PMinistrySelectedId { get; set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewFamily")
                {
                    return "Please Provide values for all fields";
                }
                if (columnName == "duplicate")
                {
                    return "User with the same credentials already exists";
                }
                return null;
            }
        }
        #endregion

        #region Constructors
        public FamilyPageViewModel()
        {
            newFamily = new Family();
            BrowsePicCommand = new RelayCommand(BrowsePic_E, BrowsePic_C);
            DeleteFamilyCommand = new RelayCommand(delete_E, pSelected_C);
            EditFamilyCommand = new RelayCommand(Edit_E, pSelected_C);
            SaveFamiliesCommand = new RelayCommand(saveCs_E, saveCs_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            ResetAllFamilies();
            SaveNewFamilyCommand = new RelayCommand(saveNc_E, saveNc_C);
            SearchFamilyCommand = new RelayCommand(_ =>
            {
                SearchFamily();
            });
        }


        private void Edit_E(object obj)
        {
            db.SaveChanges();
            MessageBox.Show("Changes Saved Successfully");
        }

        private bool BrowsePic_C(object obj)
        {

            return true;
        }

        private void BrowsePic_E(object obj)
        {
            var result = Methods.BrowsePic();
            if (result != null)
            {

                pictureName = result[0].ToString();
                NewFamily.Picture = Methods.GetImageBytes(pictureName);
            }
        }



        #endregion

        #region EventMethods
        private void FamilyPageViewModel_FamilyChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region CommandMethods
        private void cBoxes_E(object obj)
        {
            NewFamily = new Family();
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Can Execute Method for saving a new Family
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNc_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new Family
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNc_E(object obj)
        {

            //Check if the Family has already been added
            var Family = db.Families.Where(i => i.FamilyName == newFamily.FamilyName && i.FamilyPhone == newFamily.FamilyPhone).FirstOrDefault();
            bool IsFamilyValid = ValidateNewFamily(NewFamily);
            if (Family == null && IsFamilyValid)
            {
                NewFamily.ChurchId = SelectedChurch.ChurchId;
                // add the new Family




                db.Families.Add(NewFamily);

                db.SaveChanges();
                NewFamily = new Family();
                ResetAllFamilies();
                // show messagebox to alert success;
                MessageBox.Show("Family Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (Family != null)
            {
                Error = this["duplicate"];
            }
            else if (!IsFamilyValid)
                return;
            else
                MessageBox.Show("Failed to Add Family", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void saveCs_E(object obj)
        {
            ResetAllFamilies();
            db.SaveChanges();
        }

        private bool pSelected_C(object obj)
        {
            if (AllFamiliesSelectedId == null || AllFamiliesSelectedId < 0)
                return false;
            else
                return true;
        }

        private void delete_E(object obj)
        {
            try
            {

                if (AllFamiliesSelectedId == null || AllFamiliesSelectedId < 0)
                {
                    MessageBox.Show("Please select a Family to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Family", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Family Family = db.Families.Find(AllFamiliesSelectedId);
                    db.Families.Remove(Family);

                    db.SaveChanges();
                    refreshCs_E(null);
                }

            }
            catch
            {

            }
        }
        #endregion


        #region Methods

        public bool ValidateNewFamily(Family Family)
        {
            if (string.IsNullOrWhiteSpace(Family.FamilyName) || string.IsNullOrEmpty(Family.FamilyPhone))
            {
                Error = this["NewFamily"];
                return false;
            }

            Error = null;
            return true;

        }


        public async void SearchFamily()
        {
            try
            {

                ObservableCollection<Family> searchedFamilies = new ObservableCollection<Family>(db.Families.Where(i => i.ChurchId == SelectedChurch.ChurchId));

                await Task.Run(() =>
                {
                    if (SearchBy == "Name")
                        searchedFamilies = new ObservableCollection<Family>(db.Families.Where(i => i.FamilyName.ToLower().StartsWith(SearchString.ToLower())));
                });

                AllFamilies = searchedFamilies;
            }
            catch
            {


            }
        }


        public Family GetFamily(int? id)
        {
            try
            {
                return db.Families.Find(id);
            }
            catch { return null; }

        }


        public void SetNewFamily()
        {
            NewFamily = db.Families.Find(_allFamiliesSelectedId);
        }

        public void ResetNewFamily()
        {
            NewFamily = new Family();
        }


        public void ResetAllFamilies()
        {
            AllFamilies = new ObservableCollection<Family>(db.Families);
        }

        #endregion

    }
}

