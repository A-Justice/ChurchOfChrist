using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortBody.Models
{
    public class Area
    {
        public int AreaId { get; set; }

        public Area()
        {
            Groups = new List<Group>();
            Classes = new List<Class>();
        }

        public string AreaName { get; set; }

        public string AreaDescription { get; set; }

        public virtual List<Group> Groups { get; set; }
        public virtual List<Class> Classes { get; set; }

        public int? AreaLeaderId { get; set; }
        #region Associations

        public int ZoneId { get; set; }

        [ForeignKey("ZoneId")]
        public virtual Zone Zone { get; set; }


        #endregion
    }
}
