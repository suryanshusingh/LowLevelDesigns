using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Helpers
{
    public enum BookStatus
    {
        Available,
        Reserved,
        Loaned,
        Lost
    }

    public enum BookFormat
    {
        HardCover,
        PaperBack,
        AudioBook,
        EBook,
        NewsPaper,
        Magazine,
        Journal
    }

    public enum ReservationStatus
    {
        Waiting,
        Pending,
        Cancelled,
        None
    }

    public enum AccountStatus
    {
        Active,
        Closed,
        Cancelled,
        Blacklisted,
        None
    }

    public class Constants
    {
        public static int MAX_BOOKS_ISSUED_TO_A_USER = 5;
        public static int MAX_LENDING_DAYS = 10;
    }

}
