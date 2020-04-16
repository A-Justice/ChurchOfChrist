using ShortBody.Models;
using ShortBody.Resources.Helper_Methods;
using ShortBody.UViewModels.UIViewModels;
using ShortBody.ValueConverters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using ViewModels.BaseClasses;

namespace ShortBody.UViewModels
{
    public class ReportPageViewModel : DashBoardViewModel
    {

        #region PublicProperties

        #region BindedProperties
        private string type;

        public List<int> Years { get; set; }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;

                switch (value)
                {
                    case "Yearly":
                        Month = -1;
                        break;
                    case "Monthly":

                        break;
                    case "Halfly":

                        break;
                    case "Quarterly":

                        break;
                    case "TillDate":

                        break;

                    default:
                        break;
                }

            }
        }

        public int Year { get; set; }
        public int PrintYear { get; set; }
        public int NextPrintYear
        {
            get
            {
                if (PrintMonth == 12)
                    return PrintYear + 1;

                return PrintYear;
            }
        }



        public string Half { get; set; }


        public string Quarter { get; set; }

        private int month = -1;

        public int Month
        {
            get { return month + 1; }
            set { month = value; }
        }

        private int printMonth;

        public int PrintMonth
        {
            get { return printMonth; }
            set
            {
                printMonth = value + 1;

                NextPrintMonth = PrintMonth == 12 ? 1 : value + 2;
            }
        }

        public int NextPrintMonth { get; set; }


        public List<Zone> Zones { get; set; }

        public List<Area> Areas { get; set; }

        public List<Group> Groups { get; set; }
        private Zone zone;

        public Zone Zone
        {
            get { return zone; }
            set
            {
                zone = value;
                //ZoneMembers = new ObservableCollection<Person>(db.People.Where(z => z.Group.Area.ZoneId == zone.ZoneId));

            }
        }

        public Area PrintArea { get; set; }


        public List<DateTime> PrintOutDates { get; set; } = new List<DateTime>();

        /// <summary>
        /// Binds the generated report to the view
        /// </summary>
        public ListCollectionView Report { get; set; }

        #region AnalysisProperties

        public int TotalDays { get; set; }

        private string analysisNature;

        public string AnalysisNature
        {
            get
            {

                switch (AnalysisType)
                {
                    case "Monthly":
                        analysisNature = $"{AnalysisType} {AnalysisKind} Analysis For {AnalysisYear}, " + IntToMonthConverter.GetMonth(AnalysisMonth);
                        break;
                    case "Yearly":
                        analysisNature = $"{AnalysisType} {AnalysisKind} Analysis For {AnalysisYear}";
                        break;
                    case "TillDate":
                        analysisNature = $"{AnalysisType} {AnalysisKind} Analysis TillDate";
                        break;
                }
                return analysisNature;

            }
            set
            {

            }
        }

        public string AnalysisType { get; set; }

        public string AnalysisKind { get; set; }

        public int AnalysisYear { get; set; }

        private int analysisMonth;

        public int AnalysisMonth
        {
            get { return analysisMonth + 1; }
            set { analysisMonth = value; }
        }


        #endregion

        #endregion

        #region CommandProperties
        public RelayCommand GenerateReportCommand { get; set; }
        public RelayCommand GeneratePrintOutCommand { get; set; }
        public ObservableCollection<Report> PrintOut { get; set; }

        public ObservableCollection<Analysis> AllAnalysis { get; set; }
        #endregion

        #endregion

        #region Contstructor
        public ReportPageViewModel()
        {
            Zones = db.Zones.ToList();
            Areas = db.Areas.ToList();
            Groups = db.Groups.ToList();

            GenerateReportCommand = new RelayCommand(_ =>
            {
            });
            GeneratePrintOutCommand = new RelayCommand(_ =>
            {
                //  CreatePrint(PrintZone, new DateTime(PrintYear, PrintMonth, 1));
            });
            //var years = new List<int>();
            //for (int i = 2015; i <= DateTime.Now.Year; i++)
            //{
            //    years.Add(i);
            //}
            Years = Methods.GenerateYears().ToList();

        }


        #endregion

        #region HelperMethods
        public bool generateReport(string period, Area area = null)
        {
            if (period != "TillDate")
                if (HasErrors("report"))
                    return false;

            DateTime ReportDate;
            ReportType type;
            IEnumerable<Report> ReportedPeople = new List<Report>();
            setReportedPeople();

            if (area == null)
            {
                var collection = new ListCollectionView(new ObservableCollection<Report>(ReportedPeople));
                collection.GroupDescriptions.Add(new PropertyGroupDescription("Person.Group.Area"));
                Report = collection;
            }

            //Checks if the passed in Date conforms to the report to be generated
            bool IsInTime(DateTime Date)
            {
                bool allowed = false;
                switch (period)
                {
                    case "Yearly":
                        type = ReportType.Yearly;
                        if (Date != null)
                            allowed = Date.Year == Year;
                        break;
                    case "Monthly":
                        if (Date != null)
                            allowed = Date.Year == Year && Date.Month == Month;
                        type = ReportType.Monthly;
                        break;
                    case "Halfly":
                        type = ReportType.Halfly;
                        if (Date != null)
                            if (Half == "1st")
                                allowed = Date.Year == Year && Date.Month > 0 && Date.Month <= 6;
                            else if (Half == "2nd")
                                allowed = Date.Year == Year && Date.Month > 6 && Date.Month <= 12;
                        break;
                    case "Quarterly":
                        type = ReportType.Halfly;
                        if (Date != null)
                            if (Quarter == "1st")
                                allowed = Date.Year == Year && Date.Month > 0 && Date.Month <= 3;
                            else if (Quarter == "2nd")
                                allowed = Date.Year == Year && Date.Month > 3 && Date.Month <= 6;
                            else if (Quarter == "3rd")
                                allowed = Date.Year == Year && Date.Month > 6 && Date.Month <= 9;
                            else if (Quarter == "4th")
                                allowed = Date.Year == Year && Date.Month > 9 && Date.Month <= 12;
                        break;
                    case "TillDate":
                        if (Date != null)
                            allowed = Date.Year >= 2015 && Date.Year <= DateTime.Now.Year;
                        break;
                    default:
                        break;
                }
                return allowed;
            }

            //Sets The Report to be displayed on the UI
            void setReportedPeople()
            {
                if (area != null)
                {
                    var rawReports = new LocalAppContext().Reports.ToList().Where(r => IsInTime(r.ReportDate) && r.Person.Group.Area.AreaId == area.AreaId && r.Person.Service == "Adults");

                    ReportedPeople = FlattenReports(rawReports, true);
                    PrintOut = new ObservableCollection<Report>(ReportedPeople);
                }
                else
                {
                    var rawReports = db.Reports.ToList().Where(r => IsInTime(r.ReportDate) && r.Person.Group.Area.ZoneId == zone.ZoneId && r.Person.Service == "Adults");

                    ReportedPeople = FlattenReports(rawReports);
                }

                IEnumerable<Report> FlattenReports(IEnumerable<Report> Reports, bool isPrintOut = false)
                {
                    var reports = new List<Report>();
                    foreach (var report in Reports)
                    {

                        if (isPrintOut)
                            report.Remark = "";
                        //Check if a report of this person has already been added
                        var tempReport = reports.Where(r => r.PersonId == report.PersonId).FirstOrDefault();

                        if (tempReport == null)
                        {
                            reports.Add(report);
                        }
                        else
                        {
                            tempReport.Sundays += report.Sundays;
                            tempReport.Fridays += report.Fridays;
                            tempReport.Sundays += report.Sundays;
                            tempReport.Remark = report.Remark;
                        }


                    }
                    return reports.OrderBy(p => p, new CompareReportedPeople());
                }
            }

            return true;
        }

        public bool CreatePrintOut()
        {
            try
            {
                if (HasErrors("printOut"))
                    return false;
                var area = PrintArea;
                var date = new DateTime(PrintYear, PrintMonth, 1);
                PrintOutDates = GetDates(date, NextPrintMonth, NextPrintYear);

                return generateReport("TillDate", area);

            }
            catch { return false; }

        }


        public bool Analyse()
        {
            try
            {
                if (HasErrors())
                    return false;

                bool IsInDate(DateTime Date)
                {
                    bool allowed = false;
                    switch (AnalysisType)
                    {
                        case "Yearly":
                            if (Date != null)
                                allowed = Date.Year == AnalysisYear;
                            break;
                        case "Monthly":
                            if (Date != null)
                                allowed = Date.Year == AnalysisYear && Date.Month == AnalysisMonth;

                            break;

                        case "TillDate":
                            if (Date != null)
                                allowed = Date.Year >= 2015 && Date.Year <= DateTime.Now.Year;
                            break;
                        default:
                            break;
                    }
                    return allowed;
                }
                List<Analysis> tempAnalyses = new List<Analysis>();
                var events = db.Events.ToList().Where(e => IsInDate(e.Date));
                switch (AnalysisKind)
                {

                    case "Zone":

                        foreach (var zone in db.Zones)
                        {
                            int sundays = 0;
                            int tuesdays = 0;
                            int fridays = 0;
                            int possibleSundays = 0;
                            int possibleTuesdays = 0;
                            int possibleFridays = 0;
                            int zoneMembers = db.People.Where(p => p.Group.Area.ZoneId == zone.ZoneId).Count();
                            foreach (var _event in events)
                            {


                                if (_event.Date.DayOfWeek == DayOfWeek.Sunday)
                                    possibleSundays += 1;
                                if (_event.Date.DayOfWeek == DayOfWeek.Tuesday)
                                    possibleTuesdays += 1;
                                if (_event.Date.DayOfWeek == DayOfWeek.Friday)
                                    possibleFridays += 1;



                                //These variables indicate the people who actally attended on these specific day ... The 
                                //word people can be prepended on each of the variables
                                sundays += _event.People.Where(p => p.Group.Area.ZoneId == zone.ZoneId && _event.Date.DayOfWeek == DayOfWeek.Sunday).Count();
                                tuesdays += _event.People.Where(p => p.Group.Area.ZoneId == zone.ZoneId && _event.Date.DayOfWeek == DayOfWeek.Tuesday).Count();
                                fridays += _event.People.Where(p => p.Group.Area.ZoneId == zone.ZoneId && _event.Date.DayOfWeek == DayOfWeek.Friday).Count();

                            }
                            var sundayDenominator = possibleSundays == 0 ? 1 : possibleSundays;
                            var tuesdayDenominator = possibleTuesdays == 0 ? 1 : possibleTuesdays;
                            var fridayDenominator = possibleFridays == 0 ? 1 : possibleFridays;

                            var adjustedZoneMembers = zoneMembers == 0 ? 1 : zoneMembers;
                            tempAnalyses.Add(
                                new Analysis
                                {
                                    Name = zone.ZoneName,
                                    TotalMembers = zoneMembers,
                                    SundaysAttendants = sundays,
                                    TuesdaysAttendants = tuesdays,
                                    FridaysAttendants = fridays,
                                    Total = sundays + tuesdays + fridays,
                                    ExpectedAttendance = (possibleTuesdays + possibleFridays + possibleSundays) * zoneMembers,
                                    SunPercent = (sundays / Convert.ToDouble(sundayDenominator * adjustedZoneMembers)) * 100.0,
                                    TuePercent = (tuesdays / Convert.ToDouble(tuesdayDenominator * adjustedZoneMembers)) * 100.0,
                                    FriPercent = (fridays / Convert.ToDouble(fridayDenominator * adjustedZoneMembers)) * 100.0

                                }
                            );
                        }

                        break;
                    case "Group":
                        foreach (var group in db.Groups)
                        {
                            int sundays = 0;
                            int tuesdays = 0;
                            int fridays = 0;
                            int possibleSundays = 0;
                            int possibleTuesdays = 0;
                            int possibleFridays = 0;
                            int groupMembers = db.People.Where(p => p.Group.GroupId == group.GroupId).Count();
                            foreach (var _event in events)
                            {




                                if (_event.Date.DayOfWeek == DayOfWeek.Sunday)
                                    possibleSundays += 1;
                                if (_event.Date.DayOfWeek == DayOfWeek.Tuesday)
                                    possibleTuesdays += 1;
                                if (_event.Date.DayOfWeek == DayOfWeek.Friday)
                                    possibleFridays += 1;




                                sundays += _event.People.Where(p => p.Group.GroupId == group.GroupId && _event.Date.DayOfWeek == DayOfWeek.Sunday).Count();
                                tuesdays += _event.People.Where(p => p.Group.GroupId == group.GroupId && _event.Date.DayOfWeek == DayOfWeek.Tuesday).Count();
                                fridays += _event.People.Where(p => p.Group.GroupId == group.GroupId && _event.Date.DayOfWeek == DayOfWeek.Friday).Count();

                            }
                            var sundayDenominator = possibleSundays == 0 ? 1 : possibleSundays;
                            var tuesdayDenominator = possibleTuesdays == 0 ? 1 : possibleTuesdays;
                            var fridayDenominator = possibleFridays == 0 ? 1 : possibleFridays;

                            var adjustedGroupMembers = groupMembers == 0 ? 1 : groupMembers;
                            tempAnalyses.Add(
                                new Analysis
                                {
                                    Name = group.Name,
                                    TotalMembers = groupMembers,
                                    SundaysAttendants = sundays,
                                    TuesdaysAttendants = tuesdays,
                                    FridaysAttendants = fridays,
                                    Total = sundays + tuesdays + fridays,
                                    ExpectedAttendance = (possibleTuesdays + possibleFridays + possibleSundays) * groupMembers,
                                    SunPercent = (sundays / Convert.ToDouble(sundayDenominator * adjustedGroupMembers)) * 100.0,
                                    TuePercent = (tuesdays / Convert.ToDouble(tuesdayDenominator * adjustedGroupMembers)) * 100.0,
                                    FriPercent = (fridays / Convert.ToDouble(fridayDenominator * adjustedGroupMembers)) * 100.0

                                }
                            );
                        }
                        break;
                    case "Area":
                        foreach (var area in db.Areas)
                        {
                            int sundays = 0;
                            int tuesdays = 0;
                            int fridays = 0;
                            int possibleSundays = 0;
                            int possibleTuesdays = 0;
                            int possibleFridays = 0;
                            int areaMembers = db.People.Where(p => p.Group.Area.AreaId == area.AreaId).Count();
                            foreach (var _event in events)
                            {




                                if (_event.Date.DayOfWeek == DayOfWeek.Sunday)
                                    possibleSundays += 1;
                                if (_event.Date.DayOfWeek == DayOfWeek.Tuesday)
                                    possibleTuesdays += 1;
                                if (_event.Date.DayOfWeek == DayOfWeek.Friday)
                                    possibleFridays += 1;




                                sundays += _event.People.Where(p => p.Group.Area.AreaId == area.AreaId && _event.Date.DayOfWeek == DayOfWeek.Sunday).Count();
                                tuesdays += _event.People.Where(p => p.Group.Area.AreaId == area.AreaId && _event.Date.DayOfWeek == DayOfWeek.Tuesday).Count();
                                fridays += _event.People.Where(p => p.Group.Area.AreaId == area.AreaId && _event.Date.DayOfWeek == DayOfWeek.Friday).Count();

                            }
                            var sundayDenominator = possibleSundays == 0 ? 1 : possibleSundays;
                            var tuesdayDenominator = possibleTuesdays == 0 ? 1 : possibleTuesdays;
                            var fridayDenominator = possibleFridays == 0 ? 1 : possibleFridays;
                            var adjustedAreaMembers = areaMembers == 0 ? 1 : areaMembers;
                            tempAnalyses.Add(
                                new Analysis
                                {
                                    Name = area.AreaName,
                                    TotalMembers = areaMembers,
                                    SundaysAttendants = sundays,
                                    TuesdaysAttendants = tuesdays,
                                    FridaysAttendants = fridays,
                                    Total = sundays + tuesdays + fridays,
                                    ExpectedAttendance = (possibleTuesdays + possibleFridays + possibleSundays) * areaMembers,
                                    SunPercent = (sundays / Convert.ToDouble(sundayDenominator * adjustedAreaMembers)) * 100.0,
                                    TuePercent = (tuesdays / Convert.ToDouble(tuesdayDenominator * adjustedAreaMembers)) * 100.0,
                                    FriPercent = (fridays / Convert.ToDouble(fridayDenominator * adjustedAreaMembers)) * 100.0

                                }
                            );
                        }
                        break;
                }
                TotalDays = events.Where(e => (e.Date.DayOfWeek == DayOfWeek.Sunday || e.Date.DayOfWeek == DayOfWeek.Tuesday || e.Date.DayOfWeek == DayOfWeek.Sunday)).Count();
                AllAnalysis = new ObservableCollection<Analysis>(tempAnalyses);
                return true;
            }
            catch { return false; }
        }

        List<DateTime> GetDates(DateTime baseDate, int NextMonth, int NextYear)
        {
            var currentMonthDates = Enumerable.Range(1, DateTime.DaysInMonth(baseDate.Year, baseDate.Month))
                .Select(day => new DateTime(baseDate.Year, baseDate.Month, day))
                .Where(d => d.DayOfWeek == DayOfWeek.Tuesday || d.DayOfWeek == DayOfWeek.Friday || d.DayOfWeek == DayOfWeek.Sunday).ToList();

            var NextMonthDates = Enumerable.Range(1, DateTime.DaysInMonth(NextYear, NextMonth))
                .Select(day => new DateTime(NextYear, NextMonth, day)).Take(7)
                .Where(d => d.DayOfWeek == DayOfWeek.Tuesday || d.DayOfWeek == DayOfWeek.Friday || d.DayOfWeek == DayOfWeek.Sunday).ToList();


            currentMonthDates.AddRange(NextMonthDates);

            return currentMonthDates;
        }


        public bool HasErrors(string whichReport = "")
        {
            string ErrorMessage = null;
            if (whichReport == "report")
            {
                if (Zone == null)
                    ErrorMessage = "Please Choose a Zone";
                else if (Type == null)
                    ErrorMessage = "Please Choose a Type";
                else
                {
                    switch (Type)
                    {
                        case "Yearly":
                            if (Year < 2014)
                                ErrorMessage = "Please Choose a Year";
                            break;
                        case "Monthly":
                            if (Month < 1)
                                ErrorMessage = "Please Choose a Month";

                            break;
                        case "Halfly":
                            if (Half == null)
                                ErrorMessage = "Please Choose a Half";

                            break;
                        case "Quarterly":
                            if (Quarter == null)
                                ErrorMessage = "Please Choose a Quarter";
                            break;
                    }
                }
            }
            else if (whichReport == "printOut")
            {
                if (PrintArea == null)
                    ErrorMessage = "Please Choose an Area";
                else if (PrintMonth < 1)
                    ErrorMessage = "Please Choose a Month";
                else if (PrintYear < 2014)
                    ErrorMessage = "Please Choose a Year";
            }
            else
            {

                if (AnalysisKind == null)
                    ErrorMessage = "Please Select an Analysis Kind";
                if (AnalysisType == null)
                    ErrorMessage = "Please Select an Analysis Type";
                else
                {
                    switch (AnalysisType)
                    {
                        case "Yearly":
                            if (AnalysisYear < 2014)
                                ErrorMessage = "Please Select a Year";
                            break;
                        case "Monthly":
                            if (AnalysisYear < 2014)
                                ErrorMessage = "Please Select a Year";
                            if (AnalysisMonth < 1)
                                ErrorMessage = "Please Select a Month";
                            break;
                    }
                }

            }

            if (ErrorMessage != null)
                MessageBox.Show(ErrorMessage);

            return ErrorMessage == null ? false : true;
        }
        #endregion

    }


    /// <summary>
    /// Implementation of ICompare to compare reports
    /// </summary>
    class CompareReportedPeople : IComparer<Report>
    {
        public int Compare(Report x, Report y)
        {
            //If the first is greater than the second
            if (x.Person.Group.GroupId > y.Person.Group.GroupId)
            {
                return 1;
            }
            //if the second is greater than the first
            else if (x.Person.Group.GroupId < y.Person.Group.GroupId)
            {
                return -1;
            }
            else
            {
                var leaderId = x.Person.Group.GroupLeaderId;
                if (x.PersonId == y.PersonId)
                    return 0;
                if (x.PersonId == leaderId)
                    return -1;
                else if (y.PersonId == leaderId)
                    return 1;
                else return 0;
            }

        }
    }

}
