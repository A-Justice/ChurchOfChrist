using ShortBody.Enums;
using ShortBody.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.ValueConverters
{
    public class EnumToPageConverter : BaseConverter<EnumToPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
             // Test for appopriate application page value and return the appopriate page
            switch ((ApplicationPage)value)
            {

                case ApplicationPage.Login:
                    return new LoginPage();
                case ApplicationPage.DashBoard:
                    return new DashBoard();
                    
                default:
                    Debugger.Break();
                    break;
                    
            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
