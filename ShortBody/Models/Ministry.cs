using System.Collections.Generic;

namespace ShortBody.Models
{
    public class Ministry
    {
        public int MinistryId { get; set; }

        public Ministry()
        {
            People = new List<Person>();
        }

        public string MinistryName { get; set; }

        public string MinistryDescription { get; set; }

        public int? MinistryLeaderId { get; set; }

        public virtual List<Person> People { get; set; }
    }
}
