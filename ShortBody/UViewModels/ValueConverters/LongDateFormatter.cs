
using System;
using System.Globalization;

namespace ShortBody.ValueConverters
{
    public class LongDateFormatter : BaseConverter<LongDateFormatter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return ((DateTime)value).ToLongDateString();
            }
            catch
            {
                return value;
            }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
