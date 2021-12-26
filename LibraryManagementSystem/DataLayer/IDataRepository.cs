using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.DataLayer
{
    public interface IDataRepository
    {
        public int GetTotalBooksCheckedOut(int memberId);
        public BookReservationDetails GetBookReservationDetails(string barcode);
        public bool UpdateLendDetails(int memberId, BookItem bookItem);
    }
}
