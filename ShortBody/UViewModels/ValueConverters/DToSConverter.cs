using ShortBody.ValueConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ShortBody.ValueConverters
{
    public class DToSConverter : BaseConverter<DToSConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format("{0:n}", value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDecimal((value.ToString()).Replace(",",""));
        }
    }
}
