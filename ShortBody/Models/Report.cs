using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortBody.Models
{
    public enum ReportType
    {
        Yearly,
        Halfly,
        Quarterly,
        Monthly
    }
    public class Report
    {
        public int ReportId { get; set; }

        public int Sundays { get; set; }


        public int Tuesdays { get; set; }


        public int Fridays { get; set; }

        public int Total => Tuesdays + Fridays + Sundays;

        public DateTime ReportDate { get; set; }


        public ReportType ReportType { get; set; }


        public string Remark { get; set; }

        public int PersonId { get; set; }


        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
