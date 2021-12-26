using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
