using ShortBody.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class GroupsViewModel : DashBoardViewModel, IDataErrorInfo
    {
        #region PrivateVariables

        //private ObservableCollection<Person> groupMembers;
        //private int? allgroupsSelectedId;
        //private string newGroupName;
        //private string newGroupDescription;
        //private string newMinistryName;
        //private string newMinistryDescription;
        //private ObservableCollection<Person> ministryMembers;
        //private ObservableCollection<Ministry> ministries;
        private int? allAreasSelectedId;
        private int? allMinistriesSelectedId;
        private int? allGroupsSelectedId;
        private int? allZonesSelectedId;
        private int? allClassesSelectedId;

        //private string newAreaName;
        //private string newAreaDescription;
        //private ObservableCollection<Person> areaMembers;
        //private ObservableCollection<Area> areas;

        #endregion

        #region publicProperties
        public int? SelectedLeaderId { get; set; }
        public Person ZoneLeader { get; set; }
        public Person AreaLeader { get; set; }
        public Person GroupLeader { get; set; }
        public Person ClassLeader { get; set; }
        public Person MinistryLeader { get; set; }


        public ObservableCollection<Ministry> Ministries { get; set; }

        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Zone> Zones { get; set; }

        public ObservableCollection<Area> Areas { get; set; }
        public ObservableCollection<Class> Classes { get; private set; }



        public ObservableCollection<Person> GroupMembers { get; set; }

        public ObservableCollection<Person> MinistryMembers { get; set; }
        public ObservableCollection<Person> AreaMembers { get; set; }

        public ObservableCollection<Person> ZoneMembers { get; set; }


        public ObservableCollection<Person> ClassMembers { get; set; }



        public Zone AreaZone { get; set; }

        public Area GroupArea { get; set; }

        public Area ClassArea { get; set; }



        public int? AllClassSelectedId
        {
            get
            {
                return allClassesSelectedId;
            }
            set
            {
                allClassesSelectedId = value;
                var _class = db.Classes.Find(value);
                var people = _class.People;

                ClassLeader = GetLeader(_class.ClassLeaderId);
                if (people != null)
                    ClassMembers = new ObservableCollection<Person>(people);

            }
        }
        public int? AllAreaSelectedId
        {
            get
            {
                return allAreasSelectedId;
            }
            set
            {
                allAreasSelectedId = value;
                var area = db.Areas.Find(value);
                var people = db.People.Where(i => i.Group.AreaId == area.AreaId || i.Class.AreaId == area.AreaId);

                AreaLeader = GetLeader(area.AreaLeaderId);
                if (people != null)
                    AreaMembers = new ObservableCollection<Person>(people);

            }
        }
        public int? AllZoneSelectedId
        {
            get { return allZonesSelectedId; }
            set
            {
                allZonesSelectedId = value;
                var zone = db.Zones.Find(value);
                var people = db.People.Where(i => i.Class.Area.ZoneId == zone.ZoneId || i.Group.Area.ZoneId == zone.ZoneId);

                ZoneLeader = GetLeader(zone.ZoneLeaderId);

                if (people != null)
                    ZoneMembers = new ObservableCollection<Person>(people);
            }
        }
        public int? AllGroupSelectedId
        {
            get
            {
                return allGroupsSelectedId;
            }
            set
            {
                allGroupsSelectedId = value;
                var group = db.Groups.Find(value);
                var people = group.People;

                GroupLeader = GetLeader(group.GroupLeaderId);
                if (people != null)
                    GroupMembers = new ObservableCollection<Person>(people);
            }
        }
        public int? AllMinistrySelectedId
        {
            get { return allMinistriesSelectedId; }
            set
            {
                allMinistriesSelectedId = value;
                var ministry = db.Ministries.Find(value);
                var people = ministry.People;

                MinistryLeader = GetLeader(ministry.MinistryLeaderId);
                if (people != null)
                    MinistryMembers = new ObservableCollection<Person>(people);
            }
        }


        #region NewFieldProperties
        public string NewClassName { get; set; }
        public string NewClassDescription { get; set; }
        public string NewZoneName { get; set; }
        public string NewZoneDescription { get; set; }
        public string NewGroupName { get; set; }

        public string NewGroupDescription { get; set; }

        public string NewMinistryName { get; set; }

        public string NewMinistryDescription { get; set; }
        public string NewAreaName { get; set; }
        public string NewAreaDescription { get; set; }

        #endregion



        #region CommandProperties
        public RelayCommand SetAsLeaderCommand { get; set; }
        public RelayCommand AddAssociationCommand { get; set; }
        public RelayCommand DeleteAssociationCommand { get; set; }
        // public RelayCommand DeleteGroupCommand { get; set; }


        //  public RelayCommand DeleteMinistryCommand { get; set; }



        //   public RelayCommand DeleteAreaCommand { get; set; }

        //    public RelayCommand DeleteZoneCommand { get; private set; }

        //   public RelayCommand DeleteClassCommand { get; private set; }
        #endregion

        #endregion


        public GroupsViewModel()
        {
            Zones = new ObservableCollection<Zone>(db.Zones);
            Areas = new ObservableCollection<Area>(db.Areas);
            Classes = new ObservableCollection<Class>(db.Classes);
            Groups = new ObservableCollection<Group>(db.Groups);
            Ministries = new ObservableCollection<Ministry>(db.Ministries);



            AddAssociationCommand = new RelayCommand(Add);

            DeleteAssociationCommand = new RelayCommand(Delete);

            //DeleteGroupCommand = new RelayCommand((obj) => Delete("Group", obj));

            //DeleteMinistryCommand = new RelayCommand((obj) => Delete("Ministry", obj));

            //DeleteAreaCommand = new RelayCommand((obj) => Delete("Area", obj));

            //DeleteZoneCommand = new RelayCommand((obj) => Delete("Zone", obj));

            //DeleteClassCommand = new RelayCommand((obj) => Delete("Class", obj));

            SetAsLeaderCommand = new RelayCommand(setLeader_E, setLeader_C);
        }

        private bool setLeader_C(object obj)
        {
            return true;
        }

        private void setLeader_E(object obj)
        {
            var association = obj as DataGrid;



            // Person person = db.People.Find(SelectedLeaderId);
            Person person = null;

            association.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        person = ((Person)association.SelectedItem);
                        try
                        {
                            switch (association.Name)
                            {
                                case "dgZoneMembers":
                                    var currentZone = db.Zones.Find(AllZoneSelectedId);
                                    currentZone.ZoneLeaderId = person.PersonId;
                                    ZoneLeader = person;
                                    break;
                                case "dgAreaMembers":
                                    var currentArea = db.Areas.Find(AllAreaSelectedId);
                                    currentArea.AreaLeaderId = person.PersonId;
                                    AreaLeader = person;
                                    break;
                                case "dgGroupMembers":
                                    var currentGroup = db.Groups.Find(AllGroupSelectedId);
                                    currentGroup.GroupLeaderId = person.PersonId;
                                    GroupLeader = person;
                                    break;
                                case "dgClassMembers":
                                    var currentClass = db.Classes.Find(AllClassSelectedId);
                                    currentClass.ClassLeaderId = person.PersonId;
                                    ClassLeader = person;
                                    break;
                                case "dgMinistryMembers":
                                    var currentMinistry = db.Ministries.Find(AllMinistrySelectedId);
                                    currentMinistry.MinistryLeaderId = person.PersonId;
                                    MinistryLeader = person;
                                    break;
                            }
                        }
                        catch { }
                    }));
            db.SaveChanges();

            SelectedLeaderId = null;

        }





        #region CommandMethods

        private void Add(object obj)
        {
            try
            {
                string parameter = obj as string;
                //int id = (int)obj;
                switch (parameter)
                {
                    case "Group":
                        if (GroupArea == null)
                        {
                            MessageBox.Show("Please select an Area for this Group");
                            break;
                        }
                        db.Groups.Add(new Group
                        {
                            Name = NewGroupName,
                            Description = NewGroupDescription,
                            AreaId = GroupArea.AreaId
                        });
                        GroupArea = null;
                        NewGroupName = "";
                        NewGroupDescription = "";

                        db.SaveChanges();

                        //Assign to allMinistriesselectedId to reset the Ministries
                        Groups = new ObservableCollection<Group>(db.Groups);
                        break;


                    case "Ministry":
                        db.Ministries.Add(new Ministry
                        {
                            MinistryName = NewMinistryName,
                            MinistryDescription = NewMinistryDescription
                        });
                        NewMinistryName = "";
                        NewMinistryDescription = "";

                        db.SaveChanges();

                        //Assign to allMinistriesselectedId to reset the Ministries
                        Ministries = new ObservableCollection<Ministry>(db.Ministries);
                        break;


                    case "Area":
                        if (AreaZone == null)
                        {
                            MessageBox.Show("Please select a zone for this area");
                            break;
                        }

                        db.Areas.Add(new Area
                        {
                            AreaName = NewAreaName,
                            AreaDescription = NewAreaDescription,
                            ZoneId = AreaZone.ZoneId
                        });
                        AreaZone = null;
                        NewAreaName = "";
                        NewAreaDescription = "";

                        db.SaveChanges();

                        //Assign to allMinistriesselectedId to reset the Ministries
                        Areas = new ObservableCollection<Area>(db.Areas);

                        break;

                    case "Class":
                        if (ClassArea == null)
                        {
                            MessageBox.Show("Please select an Area for this Class");
                            break;
                        }
                        db.Classes.Add(new Class
                        {
                            Name = NewClassName,
                            Description = NewClassDescription,
                            AreaId = ClassArea.AreaId
                        });
                        ClassArea = null;
                        NewClassName = "";
                        NewClassDescription = "";

                        db.SaveChanges();

                        //Assign to allClassesselectedId to reset the Classes
                        Classes = new ObservableCollection<Class>(db.Classes);
                        break;

                    case "Zone":
                        db.Zones.Add(new Zone
                        {
                            ZoneName = NewZoneName,
                            ZoneDescription = NewZoneDescription,
                            ChurchId = SelectedChurch.ChurchId
                        });
                        NewZoneName = "";
                        NewZoneDescription = "";

                        db.SaveChanges();

                        //Assign to allZonesselectedId to reset the Zones
                        Zones = new ObservableCollection<Zone>(db.Zones);

                        break;
                }
            }
            catch (Exception ex) { }
        }
        private void Delete(object obj)
        {
            string parameter = obj as string;
            try
            {
                if (deletePrompt(parameter))
                {
                    switch (parameter)
                    {
                        case "Group":
                            db.Groups.Remove(db.Groups.Find(AllGroupSelectedId));
                            db.SaveChanges();
                            Groups = new ObservableCollection<Group>(db.Groups);
                            break;
                        case "Ministry":
                            db.Ministries.Remove(db.Ministries.Find(AllMinistrySelectedId));
                            db.SaveChanges();
                            Ministries = new ObservableCollection<Ministry>(db.Ministries);

                            break;
                        case "Area":
                            db.Areas.Remove(db.Areas.Find(allAreasSelectedId));

                            db.SaveChanges();
                            Areas = new ObservableCollection<Area>(db.Areas);
                            break;
                        case "Class":
                            db.Classes.Remove(db.Classes.Find(allClassesSelectedId));

                            db.SaveChanges();
                            Classes = new ObservableCollection<Class>(db.Classes);
                            break;
                        case "Zone":
                            db.Zones.Remove(db.Zones.Find(AllZoneSelectedId));

                            db.SaveChanges();
                            Zones = new ObservableCollection<Zone>(db.Zones);
                            break;
                    }

                }
            }
            catch { }
        }

        #endregion

        #region IDataErrorInfo
        public string this[string columnName]
        {
            get
            {
                if (columnName == "")
                    return "";
                return null;
            }

        }

        public string Error => null;


        private bool deletePrompt(string parameter)
        {

            return MessageBox.Show($"Are you sure u want to delete the Selected {parameter}", "Approve Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes ? true : false;
        }

        #endregion


        #region OtherMethods

        /// <summary>
        /// Get a Leader based on the leader's Id
        /// </summary>
        /// <param name="LeaderId"></param>
        /// <returns></returns>
        public Person GetLeader(int? LeaderId)
        {
            return LeaderId != null ? db.People.Find(LeaderId) : null;
        }

        #endregion
    }
}
