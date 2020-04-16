using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShortBody.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public Event()
        {
            People = new List<Person>();
        }

        public DateTime Date { get; set; }



        #region Associations

        public virtual List<Person> People { get; set; }


        //public int ChurchId { get; set; }

        //[ForeignKey("ChurchId")]
        //public Church Church { get; set; }



        #endregion
    }
}
