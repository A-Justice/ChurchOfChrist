using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortBody.Models
{
    public class Zone
    {

        public Zone()
        {
            Areas = new List<Area>();
        }
        public int ZoneId { get; set; }

        public string ZoneName { get; set; }

        public string ZoneDescription { get; set; }

        public int? ZoneLeaderId { get; set; }

        #region Associations

        public virtual List<Area> Areas { get; set; }

        public int ChurchId { get; set; }

        [ForeignKey("ChurchId")]
        public virtual Church Church { get; set; }
        #endregion
    }
}
