using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.Resources.Helper_Methods
{
    public class DateEventArgs :EventArgs
    {
        public int Month { get; set; }

        public DateTime? Date { get; set; }
        public int Year { get; set; }

        public DateEventArgs(int month,int year)
        {
            Month = month;
            Year = year;
            if (month > 0 && year > 0)
                Date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            else if (year > 0 && month < 1)
            {
                Date = new DateTime(year, 1, 1);
            }
            else if(month > 0 && year < 1)
            {
                Date = new DateTime(1990, month, 1);
            }
            else
                Date = null;
        }

  
    }
}
