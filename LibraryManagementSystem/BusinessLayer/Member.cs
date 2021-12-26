using LibraryManagementSystem.DataLayer;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.BusinessLayer
{
    public class Member : Account, IMember
    {
        private readonly IDataRepository dataRepository;
        public Member(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public bool CheckOutBookItem(int memberId, BookItem bookItem)
        {
            if (dataRepository.GetTotalBooksCheckedOut(memberId) >= Constants.MAX_BOOKS_ISSUED_TO_A_USER)
            {
                Console.WriteLine("Max books has been issued to you");
                return false;
            }

            var bookReservationDetails = dataRepository.GetBookReservationDetails(bookItem.Barcode);

            if (bookReservationDetails != null && bookReservationDetails.MemberId != memberId)
            {
                // Book is reserved by another member. Cannot be issued.
                Console.WriteLine("Book is reserved by another member. Cannot be issued.");
                return false;
            }

            // Update book lend details for this user.
            if (!dataRepository.UpdateLendDetails(memberId, bookItem)) return false;

            return true;
        }

        public bool RenewBookItem(int memberId, BookItem bookItem)
        {
            var bookLendDetails = dataRepository.GetBookLendDetails(memberId, bookItem);
            GetAndCollectFine(bookLendDetails);

            var bookReservationDetails = dataRepository.GetBookReservationDetails(bookItem.Barcode);
            if (bookReservationDetails != null && bookReservationDetails.MemberId != memberId)
            {
                // Book is reserved by another member. Cannot be renewed.
                Console.WriteLine("Book is reserved by another member. Cannot be renewed.");
                
                // Notify other member about availability of book
                dataRepository.UpdateStatus(bookItem, BookStatus.Reserved);
                return false;
            }

            // Update book lend details for this user.
            if (!dataRepository.UpdateLendDetails(memberId, bookItem)) return false;

            return true;
        }

        private void GetAndCollectFine(BookLendDetails bookLendDetails)
        {
            if(bookLendDetails.DueDate > DateTime.Today.Date)
            {
                // collect fine
            }
        }

        public void ReturnBookItem(int memberId, BookItem bookItem)
        {
            var bookLendDetails = dataRepository.GetBookLendDetails(memberId, bookItem);
            GetAndCollectFine(bookLendDetails);

            var bookReservationDetails = dataRepository.GetBookReservationDetails(bookItem.Barcode);
            if(bookReservationDetails != null)
            {
                dataRepository.UpdateStatus(bookItem, BookStatus.Reserved);
                // Notify other member about availability of book
            }

            dataRepository.UpdateStatus(bookItem, BookStatus.Available);
        }
    }
}
