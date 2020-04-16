using ShortBody.Resources.Helper_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortBody.Models
{
    public class User
    {
        [AutoHideColumn]
        public int UserId { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Password { get; set; }

        [AutoHideColumn]
        [MaxLength]
        public byte[] UserImage { get; set; } 
        
    }
}
