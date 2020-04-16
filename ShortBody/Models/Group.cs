using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortBody.Models
{
    public class Group : IAssociation
    {
        public Group()
        {
            People = new List<Person>();
        }
        public int GroupId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int? GroupLeaderId { get; set; }
        #region Associations

        public int AreaId { get; set; }

        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; }

        public virtual List<Person> People { get; set; }


        #endregion



    }
}
