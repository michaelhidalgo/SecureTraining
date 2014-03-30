using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSRFDemo.Models
{
    public class User
    {
        public string  Name { get; set; }
        public string  LastName { get; set; }
        public String  Email { get; set; }
        public string  Address { get; set; }
        public bool IsAdmin { get; set; }
    }
}