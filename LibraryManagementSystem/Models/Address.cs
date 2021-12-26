using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Models
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}
