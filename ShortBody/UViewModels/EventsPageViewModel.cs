using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class EventsPageViewModel : DashBoardViewModel
    {
        #region privateVariable
        Event newEvent;
        private string error;
        private string pictureName;
        private int? _allEventsSelectedId;
        private Event selectedEvent;

        #endregion

        #region PublicProperties

        public int? allMembersSelectedId { get; set; }

        public int? allAttendantsSelectedId { get; set; }

        private ObservableCollection<Event> allEvents;

        public ObservableCollection<Event> AllEvents
        {
            get { return allEvents; }
            set { allEvents = value; }
        }


        public string MTickString { get; set; }
        public string AttTickString { get; set; }



        public IEnumerable<int> MembersAutoTickString => MTickString.Split(',').Select(i => Convert.ToInt32(i));

        public IEnumerable<int> AttendantsAutoTickString => AttTickString.Split(',').Select(i => Convert.ToInt32(i));




        public byte[] Picture { get; set; }

        public string SearchBy { get; set; }
        public string SearchString { get; set; }


        public IEnumerable<int> Years { get; set; }



        public string SearchMembersBy { get; set; }
        public string SearchMembersString { get; set; }

        public string SearchAttendantsBy { get; set; }
        public string SearchAttendantsString { get; set; }


        public Event NewEvent
        {
            get
            {
                return newEvent;
            }
            set
            {
                newEvent = value;

            }
        }

        public RelayCommand DeleteEventCommand { get; set; }


        public RelayCommand Tick { get; set; }


        public RelayCommand UnTick { get; set; }

        public RelayCommand EditEventCommand { get; set; }
        public RelayCommand SaveEventsCommand { get; set; }

        public RelayCommand SaveNewEventCommand { get; set; }

        public RelayCommand AddCommand { get; set; }

        public RelayCommand RemoveCommand { get; set; }


        public RelayCommand EditClickCommand { get; set; }

        public int? AllEventsSelectedId
        {
            get { return _allEventsSelectedId; }
            set
            {
                _allEventsSelectedId = value;
                SelectedEvent = GetEvent(value);

                CreateMonthsReport();
            }
        }



        public Event SelectedEvent
        {
            get { return selectedEvent; }
            set
            {
                selectedEvent = value;

                ResetAttendanceDetails();
            }
        }

        private ObservableCollection<Person> attendants;

        public ObservableCollection<Person> Attendants
        {
            get { return attendants; }
            set { attendants = value; }
        }


        private ObservableCollection<Person> members;

        public ObservableCollection<Person> Members
        {
            get { return members; }
            set { members = value; }
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
        public RelayCommand SearchEventCommand { get; private set; }

        public RelayCommand SearchMembersCommand { get; private set; }

        public RelayCommand SearchAttendantsCommand { get; private set; }
        public int PMinistrySelectedId { get; set; }


        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewEvent")
                {
                    return "Please Provide values for all fields";
                }
                if (columnName == "duplicate")
                {
                    return "This Date Has Already Been Added";
                }
                return null;
            }
        }
        #endregion

        #region Constructors
        public EventsPageViewModel()
        {
            //Fill AllPeople from the database
            Years = Methods.GenerateYears();
            refreshCs_E(null);
            Members = allPeople;
            newEvent = new Event();
            ResetEvent();
            DeleteEventCommand = new RelayCommand(delete_E, pSelected_C);
            EditEventCommand = new RelayCommand(Edit_E, pSelected_C);
            SaveEventsCommand = new RelayCommand(saveCs_E, saveCs_C);
            ClearBoxes = new RelayCommand(cBoxes_E, cBoxes_C);
            AddCommand = new RelayCommand(add_E);
            RemoveCommand = new RelayCommand(Remove_E);
            EditClickCommand = new RelayCommand(_ => { }, pSelected_C);

            AllEvents = new ObservableCollection<Event>(db.Events);
            SaveNewEventCommand = new RelayCommand(saveNc_E, saveNc_C);
            SearchEventCommand = new RelayCommand(_ =>
            {
                SearchEvent(SearchParameter.Events);
            });
            SearchMembersCommand = new RelayCommand(_ =>
            {
                SearchEvent(SearchParameter.Members);
            });
            SearchAttendantsCommand = new RelayCommand(_ =>
            {
                SearchEvent(SearchParameter.Attendants);
            });

            Tick = new RelayCommand(_ =>
            {
                TickMembers();
            });

            UnTick = new RelayCommand(_ =>
            {
                UnTickAttendants();
            });

        }

        private void Remove_E(object obj)
        {
            var person = db.People.Find(allAttendantsSelectedId);
            SelectedEvent.People.Remove(person);
            person.EventsAttended.Remove(SelectedEvent);
            db.SaveChanges();
            ResetAttendanceDetails();
        }

        private void add_E(object obj)
        {
            var person = db.People.Find(allMembersSelectedId);
            SelectedEvent.People.Add(person);
            person.EventsAttended.Add(SelectedEvent);
            //db.SaveChanges();
            ResetAttendanceDetails();


            //Date of the currently selected Event
            var selectedEventDate = SelectedEvent.Date;

            //Check if a report for the month has already been created
            Report Existing = person.Reports.Where(r => r.ReportDate.Year == selectedEventDate.Year && r.ReportDate.Month == selectedEventDate.Month).FirstOrDefault();

            //Check all event the person has been to for the month
            var filter = person.EventsAttended.Where(e => e.Date.Year == selectedEventDate.Year && e.Date.Month == selectedEventDate.Month);

            //Create a new report if person hasnt attended any event
            if (Existing == null)
            {
                db.Reports.Add(new Report
                {
                    Person = person,
                    Sundays = filter.Where(e => e.Date.DayOfWeek == DayOfWeek.Sunday).Count(),
                    Tuesdays = filter.Where(e => e.Date.DayOfWeek == DayOfWeek.Tuesday).Count(),
                    Fridays = filter.Where(e => e.Date.DayOfWeek == DayOfWeek.Friday).Count(),
                    ReportDate = Convert.ToDateTime($"{selectedEventDate.Month}/{1}/{selectedEventDate.Year}")
                });
            }
            else
            {
                Existing.Sundays = filter.Where(e => e.Date.DayOfWeek == DayOfWeek.Sunday).Count();
                Existing.Tuesdays = filter.Where(e => e.Date.DayOfWeek == DayOfWeek.Tuesday).Count();
                Existing.Fridays = filter.Where(e => e.Date.DayOfWeek == DayOfWeek.Friday).Count();
            }


            db.SaveChanges();

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




        #endregion

        #region EventMethods
        private void EventPageViewModel_EventChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region CommandMethods
        private void cBoxes_E(object obj)
        {
            Error = null;
            NewEvent = new Event { Date = DateTime.Now };
        }

        private bool cBoxes_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Can Execute Method for saving a new Event
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private bool saveNc_C(object obj)
        {
            return true;
        }

        /// <summary>
        /// Execute Method for saving a new Event
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>whether the binder should be enabled</returns>
        private void saveNc_E(object obj)
        {

            //Check if the Event has already been added

            var newEventDate = newEvent.Date.Date;
            var Event = db.Events.Where(i => DbFunctions.TruncateTime(i.Date) == newEventDate).ToList().FirstOrDefault();
            bool IsEventValid = ValidateNewEvent(NewEvent);
            if (Event == null && IsEventValid)
            {



                db.Events.Add(NewEvent);



                db.SaveChanges();
                ResetNewEvent();
                ResetEvent();
                // show messagebox to alert success;
                MessageBox.Show("Day Added Successfully", "Success !! ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (Event != null)
            {
                Error = this["duplicate"];
            }
            else if (!IsEventValid)
                return;
            else
                MessageBox.Show("Failed to Add Event", "Failure !! ", MessageBoxButton.OK, MessageBoxImage.Error);
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
            if (AllEventsSelectedId == null || AllEventsSelectedId < 0)
                return false;
            else
                return true;
        }

        private void delete_E(object obj)
        {
            try
            {

                if (AllEventsSelectedId == null || AllEventsSelectedId < 0)
                {
                    MessageBox.Show("Please select a Day to delete");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete the selected Day", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Event Event = db.Events.Find(AllEventsSelectedId);
                    db.Events.Remove(Event);

                    db.SaveChanges();
                    MessageBox.Show("Day Successfully Deleted");
                    AllEvents = new ObservableCollection<Event>(db.Events);
                    refreshCs_E(null);
                }

            }
            catch
            {

            }
        }
        #endregion


        #region Methods

        public void TickMembers()
        {
            try
            {

                foreach (var item in MembersAutoTickString)
                {
                    try
                    {

                        allMembersSelectedId = item;
                        add_E(null);
                    }
                    catch { }
                }
                MTickString = null;
                allMembersSelectedId = null;
            }
            catch { }
        }

        public void UnTickAttendants()
        {
            try
            {
                foreach (var item in AttendantsAutoTickString)
                {
                    try
                    {
                        allAttendantsSelectedId = item;
                        Remove_E(null);
                    }
                    catch { }
                }
                AttTickString = null;
                allAttendantsSelectedId = null;
            }
            catch
            {
            }
        }

        void CreateMonthsReport()
        {

            Task.Run(async () =>
            {
                var selectedEventDate = SelectedEvent.Date;
                foreach (var member in db.People)
                {
                    Report existingReport = member.Reports.Where(r => r.ReportDate.Year == selectedEventDate.Year && r.ReportDate.Month == selectedEventDate.Month).FirstOrDefault();
                    if (existingReport == null)
                    {
                        db.Reports.Add(new Report
                        {
                            Person = member,
                            ReportDate = Convert.ToDateTime($"{selectedEventDate.Month}/{1}/{selectedEventDate.Year}")
                        });
                    }
                }
                await db.SaveChangesAsync();
            });
        }

        public bool ValidateNewEvent(Event _event)
        {
            if (_event.Date == null)
            {
                Error = this["NewEvent"];
                return false;
            }

            Error = null;
            return true;

        }


        public async void SearchEvent(SearchParameter parmeter)
        {
            try
            {
                switch (parmeter)
                {
                    case SearchParameter.Events:
                        ObservableCollection<Event> searchedEvents = new ObservableCollection<Event>(db.Events/*.Where(i => i.ChurchId == SelectedChurch.ChurchId)*/);

                        await Task.Run(() =>
                        {
                            searchedEvents = new ObservableCollection<Event>(searchedEvents.Where(i => i.Date.ToLongDateString().ToLower().Contains(SearchString.ToLower())));
                        });

                        AllEvents = searchedEvents;
                        break;
                    case SearchParameter.Members:
                        ResetAttendanceDetails();
                        ObservableCollection<Person> searchedMembers = Members;

                        await Task.Run(() =>
                        {

                            if (SearchMembersBy == "Name")
                                searchedMembers = new ObservableCollection<Person>(searchedMembers.Where(i => (i.FirstName + i.LastName + i.OtherNames).ToLower().Contains(SearchString.ToLower())));
                            if (SearchMembersBy == "Area")
                                searchedMembers = new ObservableCollection<Person>(searchedMembers.Where(i => i.Group.Area.AreaName.ToLower().StartsWith(SearchMembersString.ToLower())));

                            if (SearchMembersBy == "All")
                                searchedMembers = new ObservableCollection<Person>(db.People.ToList().Where(e => !selectedEvent.People.Contains(e)));


                        });
                        Members = searchedMembers;
                        break;
                    case SearchParameter.Attendants:
                        ResetAttendanceDetails();
                        ObservableCollection<Person> searchedAttendants = Attendants;

                        await Task.Run(() =>
                        {

                            if (SearchAttendantsBy == "FirstName")
                                searchedAttendants = new ObservableCollection<Person>(searchedAttendants.Where(i => i.FirstName.ToLower().StartsWith(SearchAttendantsString.ToLower()) || i.OtherNames.ToLower().StartsWith(SearchAttendantsString.ToLower()) || i.LastName.ToLower().StartsWith(SearchAttendantsString.ToLower())));
                            if (SearchMembersBy == "Area")
                                searchedAttendants = new ObservableCollection<Person>(searchedAttendants.Where(i => i.Group.Area.AreaName.StartsWith(SearchAttendantsString)));

                            if (SearchAttendantsBy == "All")
                                searchedAttendants = new ObservableCollection<Person>(selectedEvent.People);
                        });

                        Attendants = searchedAttendants;
                        break;
                }
            }
            catch { }

        }


        public Event GetEvent(int? id)
        {
            try
            {
                return db.Events.Find(id);
            }
            catch { return null; }

        }


        public void SetNewEvent()
        {
            NewEvent = db.Events.Find(_allEventsSelectedId);
        }

        public void ResetNewEvent()
        {
            NewEvent = new Event { Date = DateTime.Now };
        }


        public void ResetEvent()
        {
            AllEvents = new ObservableCollection<Event>(db.Events);
        }

        public void ResetAttendanceDetails()
        {
            Members = new ObservableCollection<Person>(db.People.ToList().Where(e => !selectedEvent.People.Contains(e)));
            Attendants = new ObservableCollection<Person>(selectedEvent.People);
        }

        #endregion


    }

    public enum SearchParameter
    {
        Events,
        Members,
        Attendants
    }
}
