
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ShortBody.ValueConverters
{
    public class SRemover : BaseConverter<SRemover>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string obj = (string)value;
                obj = obj.TrimEnd('s') + " :";
                return obj;
            }
            return null;
          
        }

     

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
        
    }
}
