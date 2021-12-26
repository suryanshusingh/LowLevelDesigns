using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Models
{
    public class BookLendDetails
    {
        public string BarCode;
        public int MemberId;
        public DateTime LendDate;
        public DateTime DueDate;
    }
}
