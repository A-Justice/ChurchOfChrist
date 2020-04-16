using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
   public class Church :ObservableObject
    {
        private List<ChurchAccountDetail> accountDetails;

        public Church()
        {
            People = new List<Person>();
            

            //Expenses = new List<Expense>();

            //Offertorys = new List<Offertory>();

            AccountDetails = new List<ChurchAccountDetail>();

            Families = new List<Family>();

            Zones = new List<Zone>();
        }
        [AutoHideColumn]
        public int ChurchId { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }


        public string Slogan { get; set; }

        [AutoHideColumn]
        [MaxLength]
        public byte[] Logo { get; set; }


        //Associations

        [AutoHideColumn]
        public virtual List<ChurchAccountDetail> AccountDetails
        {
            get { return accountDetails; }
            set { accountDetails = value; }
        }

        [AutoHideColumn]
        public virtual List<Person> People { get; set; }
        

        //[AutoHideColumn]
        //public virtual List<Expense> Expenses { get; set; }

        //[AutoHideColumn]
        //public virtual List<Offertory> Offertorys { get; set; }

        [AutoHideColumn]
        public virtual List<Family> Families { get; set; }

        [AutoHideColumn]
        public virtual List<Zone> Zones { get; set; }
    }
}
