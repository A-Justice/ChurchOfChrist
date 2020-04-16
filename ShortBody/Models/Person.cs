
using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.BaseClasses;

namespace ShortBody.Models
{
    public class Person : ObservableObject
    {
        private byte[] picture;
        private List<Ministry> ministries;

        public Person()
        {
            //  Tithes = new List<Tithe>();
            Reports = new List<Report>();
            Ministries = new List<Ministry>();
            //EventsAttended = new List<Event>();
        }
        [Key]
        [AutoHideColumn]
        public int PersonId { get; set; }

        public string FirstName { get; set; } = "";

        public string OtherNames { get; set; } = "";

        public string FullName => FirstName + " " + OtherNames + " " + LastName;

        public string LastName { get; set; } = "";

        public string BloodGroup { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Parse("1/1/1990");

        public string AgeCategory { get; set; }

        public string Phone { get; set; }

        public string Gender { get; set; }

        public string Service { get; set; }

        public string MembershipType { get; set; }

        public string MaritalStatus { get; set; }

        [MaxLength]
        public byte[] Picture { get { return picture; } set { picture = value; } }

        [DataType(DataType.Date)]
        public DateTime? MembershipDate { get; set; } = DateTime.Now;



        [DataType(DataType.Date)]
        public DateTime? BaptismDate { get; set; } = DateTime.Now;

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public string Address { get; set; }

        /// <summary>
        /// Indicate wether the person is a member or visitor
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Wether the person is active or inactive
        /// </summary>
        public string Status { get; set; }

        public string PlaceOfBaptism { get; set; }
        public string GhanaCardId { get; set; }

        public string HomeAddressGps { get; set; }

        public string HomeTownAddressGps { get; set; }

        public string ResidentialArea { get; set; }

        #region Associations
        //  public virtual Shape Shape { get; set; }

        [AutoHideColumn]
        public int ChurchId { get; set; }

        [AutoHideColumn]
        [ForeignKey("ChurchId")]
        public virtual Church AssociatedChurch { get; set; }



        public int? FamilyId { get; set; }

        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }

        public int? GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }


        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }


        //  public virtual List<Tithe> Tithes { get; set; }


        public virtual List<Event> EventsAttended { get; set; }



        public virtual List<Ministry> Ministries
        {
            get { return ministries; }
            set { ministries = value; }
        }


        public virtual List<Report> Reports { get; set; }


        #endregion
    }
}