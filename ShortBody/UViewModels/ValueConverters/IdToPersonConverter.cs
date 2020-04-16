using ShortBody.UViewModels;
using System;
using System.Globalization;

namespace ShortBody.ValueConverters
{
    public class IdToPersonConverter : BaseConverter<IdToPersonConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                int? id = value as int?;
                return DashBoardViewModel.db.People.Find(id).FullName ?? "No Leader";
            }
            catch { return null; }

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
