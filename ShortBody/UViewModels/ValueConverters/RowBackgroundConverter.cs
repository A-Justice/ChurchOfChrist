using System;
using System.Globalization;
using System.Windows.Media;

namespace ShortBody.ValueConverters
{
    public class RowBackgroundConverter : BaseConverter<RowBackgroundConverter>
    {

        static string OldGroupName;
        static bool determiner;
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object brush;
            var newGroupName = ((string)value);

            if (OldGroupName == null)
                OldGroupName = newGroupName;

            if (OldGroupName != newGroupName)
                determiner = !determiner;

            if (determiner)
                brush = Brushes.White;
            else
                brush = new BrushConverter().ConvertFrom("#F8CBAD");

            OldGroupName = newGroupName;
            return brush;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;

        }
    }
}
