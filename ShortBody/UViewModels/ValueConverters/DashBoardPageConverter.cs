using ShortBody.Enums;
using ShortBody.Pages;
using ShortBody.UViewModels;
using System;
using System.Globalization;

namespace ShortBody.ValueConverters
{
    public class DashBoardPageConverter : BaseConverter<DashBoardPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (LoginPage.IsLoggedOut)
            {
                PeoplePage.peoplePage = null;
                GroupsPage.servicesPage = null;
                EventsPage.eventsPage = null;
                FamiliesPage.familiesPage = null;
                ChurchPage.churchPage = null;
                UsersPage.usersPage = null;

                LoginPage.IsLoggedOut = false;
            }

            switch ((DashBoardPages)value)
            {
                case DashBoardPages.PeoplePage:
                    DashBoard.dashBoard.TopHeader.Text = "MEMBERS";
                    if (PeoplePage.peoplePage != null)
                    {
                        ((dynamic)(PeoplePage.peoplePage.DataContext)).AllPeople = DashBoardViewModel.allPeople;

                        return PeoplePage.peoplePage;

                    }
                    return new PeoplePage();
                case DashBoardPages.GroupsPage:
                    DashBoard.dashBoard.TopHeader.Text = "GROUPS";
                    if (GroupsPage.servicesPage != null)
                    {
                        ((dynamic)(GroupsPage.servicesPage.DataContext)).AllPeople = GroupsViewModel.allPeople;

                        return GroupsPage.servicesPage;
                    }

                    return new GroupsPage();
                case DashBoardPages.AttendancePage:
                    DashBoard.dashBoard.TopHeader.Text = "DAYS";
                    if (EventsPage.eventsPage != null)
                    {
                        ((dynamic)(EventsPage.eventsPage.DataContext)).AllPeople = EventsPageViewModel.allPeople;

                        return EventsPage.eventsPage;
                    }
                    return EventsPage.eventsPage ?? new EventsPage();
                case DashBoardPages.FamilyPage:
                    DashBoard.dashBoard.TopHeader.Text = "ATTENDACE";
                    if (FamiliesPage.familiesPage != null)
                    {
                        ((dynamic)(FamiliesPage.familiesPage.DataContext)).AllPeople = EventsPageViewModel.allPeople;

                        return FamiliesPage.familiesPage;
                    }
                    return FamiliesPage.familiesPage ?? new FamiliesPage();

                case DashBoardPages.ReportsPage:
                    DashBoard.dashBoard.TopHeader.Text = "REPORTS";
                    if (ReportPage.reportPage != null)
                        return ReportPage.reportPage;
                    return new ReportPage();

                case DashBoardPages.ChurchesPage:
                    DashBoard.dashBoard.TopHeader.Text = "CHURCHES";
                    if (ChurchPage.churchPage != null)
                        return ChurchPage.churchPage;
                    return new ChurchPage();

                case DashBoardPages.UsersPage:
                    DashBoard.dashBoard.TopHeader.Text = "USERS";
                    if (UsersPage.usersPage != null)
                        return UsersPage.usersPage;
                    return new UsersPage();

                    //    case DashBoardPages.PaymentAdvicePage:

                    //        DashBoard.dashBoard.TopHeader.Text = "PAYMENT ADVICES";
                    //        if (PaymentAdvicePage.paymentAdvicePage != null)
                    //            return PaymentAdvicePage.paymentAdvicePage;
                    //        return new PaymentAdvicePage();

            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
