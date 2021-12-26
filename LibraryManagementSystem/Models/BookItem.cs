using LibraryManagementSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Models
{
    public class BookItem
    {
        public string Barcode;
        public bool IsReferenceOnly;
        public DateTime Borrowed;
        public DateTime DueDate;
        public double Price;
        public BookFormat Format;
        public BookStatus Status;
        public DateTime DateOfPurchase;
        public DateTime PublicationDate;
        public Rack PlacedAt;
    }

    public class Rack
    {
        private int number;
        private string locationIdentifier;
    }
}
