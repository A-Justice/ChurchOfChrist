using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
    public class Family : ObservableObject
    {
        private byte[] picture;
        [Key]
        public int FamilyId { get; set; }


        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        [MaxLength]
        public byte[] Picture { get { return picture; } set { picture = value; } }

        public string FamilyName { get; set; }

        public string Address { get; set; }


        public string FamilyPhone { get; set; }


        public string FamilyHeadName { get; set; }

        public string FamilyHeadContact { get; set; }

        public string Clan { get; set; }


        #region Associations
        public virtual List<Person> FamilyMembers { get; set; }
        public int ChurchId { get; internal set; }

        [ForeignKey("ChurchId")]
        public virtual Church Church { get; set; }

        #endregion
    }
}
