using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortBody.Models
{
    public class Class : IAssociation
    {
        public Class()
        {
            People = new List<Person>();
        }
        public int ClassId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? ClassLeaderId { get; set; }
        #region Associations

        public int AreaId { get; set; }

        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; }



        public virtual List<Person> People { get; set; }

        #endregion



    }
}
