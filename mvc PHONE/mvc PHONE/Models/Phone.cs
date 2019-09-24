using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_PHONE.Models
{

    public enum TypeContact
     {
        PhoneNumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN,

    }

    public class Phone
    {
       [key]
        public int PhoneID { get; set; }
        [required]
        public string Name { get; set; }
        [required]
        public TypeContact Type { get; set; }
        [required]
        public string Contact { get; set; }




    }
}