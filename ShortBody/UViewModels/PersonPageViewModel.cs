using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class PersonPageViewModel : DashBoardViewModel, IDataErrorInfo
    {


        #region privateVariable
        Person newPerson;

        private string pictureName;
        private int? _allPeopleSelectedId;


        #endregion

        #region PublicProperties

        private ObservableCollection<Ministry> personMinistries;

        public ObservableCollection<Ministry> PersonMinistries
        {
            get { return personMinistries; }
            set
            {
                personMinistries = value;

            }
        }

        public IAssociation Association { get; set; }

        public string SearchBy { get; set; }

        private byte[] picture;

        public byte[] Picture
        {
            get { return picture; }
            set { picture = value; }
        }


        public string SearchString
        {
            get; set;
        }


        public Person NewPerson
        {
            get
            {
                return newPerson;
            }
            set
            {
                newPerson = value;

            }
        }

        public Ministry NewMinistry { get; set; }

        public RelayCommand DeletePersonCommand { get; set; }

        public RelayCommand EditPersonCommand { get; set; }
        public RelayCommand SavePeopleCommand { get; set; }

        public RelayCommand SaveNewPersonCommand { get; set; }

        public RelayCommand BrowsePicCommand { get; set; }

        public RelayCommand AddToMinistryCommand { get; set; }
        public RelayCommand EditClickCommand { get; set; }
        public RelayCommand RemoveFromMinistryCommand { get; set; }

        public int? AllPeopleSelectedId
        {
            get { return _allPeopleSelectedId; }
            set
            {
                _allPeopleSelectedId = value;
                SelectedPerson = GetPerson(value);
                PersonMinistries = new ObservableCollection<Ministry>(SelectedPerson.Ministries.ToList());
            }
        }



        public Person SelectedPerson { get; set; }


        public string Error { get; set; }

        public RelayCommand ClearBoxes { get; set; }
        public RelayCommand SearchPersonCommand { get; private set; }
        public int PMinistrySelectedId { get; set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewPerson")
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
        public PersonPageViewModel()
        {
            newPerson = new Person();
            BrowsePicCommand = new RelayCommand(BrowsePic_E, BrowsePic_C);
            DeletePersonCommand = new RelayCommand(delete_E, pSelected_C);
            EditPersonCommand = new RelayCommand(Edit_E, pSelected_C);
            SavePeopleCommand = new RelayCommand(saveCs_E, saveCs_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            AddToMinistryCommand = new RelayCommand(AddToMinistry_E, AddToMinistry_C);
            EditClickCommand = new RelayCommand(_ => { Association = (IAssociation)SelectedPerson.Group ?? SelectedPerson.Class; }, pSelected_C);
            RemoveFromMinistryCommand = new RelayCommand(RemoveFromMinistryCommand_E);
            AllPeople = allPeople;
            SaveNewPersonCommand = new RelayCommand(saveNc_E, saveNc_C);
            SearchPersonCommand = new RelayCommand(_ =>
            {
                SearchPerson();
            });
        }



        private void RemoveFromMinistryCommand_E(object obj)
        {
            SelectedPerson.Ministries.Remove(db.Ministries.Find(PMinistrySelectedId));
            ResetPersonMinistries();
            db.SaveChanges();

        }

        private void ResetPersonMinistries()
        {
            PersonMinistries = new ObservableCollection<Ministry>(SelectedPerson.Ministries);
        }

        private void AddToMinistry_E(object obj)
        {


            if (NewMinistry != null)
            {
                if (SelectedPerson.Ministries.Contains(NewMinistry))
                {
                    MessageBox.Show("This Member is already a part of this ministry");
                    return;
                }
                SelectedPerson.Ministries.Add(NewMinistry);
                ResetPersonMinistries();
                NewMinistry = null;
            }
            else
            {
                MessageBox.Show("No Ministry Selected");
            }
            db.SaveChanges();
        }

        private bool AddToMinistry_C(object obj)
        {

            return NewMinistry == null ? false : true;
        }

        private void Edit_E(object obj)
        {
            if (NewPerson.Service == "Children")
                NewPerson.Class = Association as Class;
            else
                NewPerson.Group = Association as Group;
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

            pictureName = result[0].ToString();
            //Picture = Methods.GetImageBytes(pictureName);
            NewPerson.Picture = Methods.GetImageBytes(pictureName);
        }



        #endregion

        #region EventMethods
        private void PersonPageViewModel_PersonChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region CommandMethods
        private void cBoxes_E(object obj)
        {
            NewPerson = new Person();
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Can Execute Method for saving a new Person
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNc_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new Person
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNc_E(object obj)
        {

            //Check if the Person has already been added
            try
            {
                var Person = db.People.Where(i => i.Email == newPerson.Email && i.Phone == newPerson.Phone && i.FirstName == newPerson.FirstName).FirstOrDefault();
                bool IsPersonValid = ValidateNewPerson(NewPerson);
                if (Person == null && IsPersonValid)
                {
                    NewPerson.Status = "Active";
                    NewPerson.ChurchId = SelectedChurch.ChurchId;
                    // add the new Person



                    switch (NewPerson.Service)
                    {
                        case "Adults":
                            var group = Association as Group;
                            int maxGroupMembers = db.Settings.First().MaxGroupNumber;
                            if (group.People.Count() == maxGroupMembers)
                            {
                                MessageBox.Show("This Selected Group is full,Consider changing the maximum Number of people allowed in a group" +
                                    "in the settings menu or add a new group", $"{group.Name} is full", MessageBoxButton.OK, MessageBoxImage.Information);
                                throw new Exception();
                            }

                            NewPerson.Group = group;
                            break;
                        case "Children":
                            var _class = Association as Class;
                            int maxClassMembers = db.Settings.First().MaxClassNumber;
                            if (_class.People.Count() == maxClassMembers)
                            {
                                MessageBox.Show("This Selected Class is full,Consider changing the maximum Number of people allowed in a _class" +
                                    "in the settings menu or add a new class", $"{_class.Name} is full", MessageBoxButton.OK, MessageBoxImage.Information);
                                throw new Exception();
                            }
                            NewPerson.Class = _class;
                            break;
                    }


                    db.People.Add(NewPerson);

                    db.SaveChanges();
                    NewPerson = new Person();
                    refreshCs_E(null);
                    // show messagebox to alert success;
                    MessageBox.Show("Person Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else if (Person != null)
                {
                    Error = this["duplicate"];
                }
                else if (!IsPersonValid)
                    return;
                else
                    MessageBox.Show("Failed to Add Person", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {


            }
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
            db.SaveChanges();
        }

        private bool pSelected_C(object obj)
        {
            if (AllPeopleSelectedId == null || AllPeopleSelectedId < 0)
                return false;
            else
                return true;
        }

        private void delete_E(object obj)
        {
            try
            {

                if (AllPeopleSelectedId == null || AllPeopleSelectedId < 0)
                {
                    MessageBox.Show("Please select a Person to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Person", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Person Person = db.People.Find(AllPeopleSelectedId);
                    db.People.Remove(Person);

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

        public bool ValidateNewPerson(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName) || string.IsNullOrEmpty(person.LastName)
                 || string.IsNullOrEmpty(person.Phone) || string.IsNullOrEmpty(person.Gender))
            {
                Error = this["NewPerson"];
                return false;
            }

            Error = null;
            return true;

        }


        public async void SearchPerson(bool IsBirthDay = false)
        {
            try
            {
                SearchBy = SearchString == "" ? "All" : SearchBy;
                ObservableCollection<Person> searchedPeople = new ObservableCollection<Person>(db.People.Where(i => i.ChurchId == SelectedChurch.ChurchId));

                await Task.Run(() =>
                {
                    if (SearchBy == "Name")
                        searchedPeople = new ObservableCollection<Person>(db.People.Where(i => i.FirstName.ToLower().StartsWith(SearchString.ToLower()) || i.LastName.ToLower().StartsWith(SearchString.ToLower()) || i.OtherNames.ToLower().StartsWith(SearchString.ToLower())));
                    if (SearchBy == "Area")
                        searchedPeople = new ObservableCollection<Person>(db.People.Where(i => i.Group.Area.AreaName.ToLower().StartsWith(SearchString.ToLower())));
                    if (SearchBy == "Ministry")
                    {
                        var ministry = db.Ministries.Where(i => i.MinistryName.ToLower().StartsWith(SearchString.ToLower())).First();
                        searchedPeople = new ObservableCollection<Person>(db.People.Where(i => i.Ministries.Contains(ministry)));
                    }
                    if (SearchBy == "FamilyName")
                        searchedPeople = new ObservableCollection<Person>(db.People.Where(i => i.Family.FamilyName.ToLower().StartsWith(SearchString.ToLower())));

                    else if (SearchBy == "BirthDate")
                    {

                        try
                        {
                            DateTime dt = Convert.ToDateTime(SearchString);

                            if (IsBirthDay)
                                searchedPeople = new ObservableCollection<Person>(db.People.Where(p => p.DateOfBirth.Day == dt.Day && p.DateOfBirth.Month == dt.Month));
                            else
                                searchedPeople = new ObservableCollection<Person>(db.People.Where(p => DbFunctions.TruncateTime(p.DateOfBirth) == DbFunctions.TruncateTime(dt)));

                        }
                        catch (Exception ex) { }
                    }
                });

                AllPeople = searchedPeople;

            }
            catch { }
        }

        /// <summary>
        /// Get Person Based On Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetPerson(int? id)
        {
            try
            {
                return db.People.Find(id);
            }
            catch { return null; }

        }


        public void SetNewPerson()
        {
            NewPerson = db.People.Find(_allPeopleSelectedId);
        }

        public void ResetNewPerson()
        {
            NewPerson = new Person();
        }



        #endregion
    }
}
