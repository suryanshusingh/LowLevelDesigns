using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.BusinessLayer
{
    interface IMember
    {
        public bool ReserveBookItem(BookItem bookItem);
        public bool CheckOutBookItem(int memberId, BookItem bookItem);
        public void ReturnBookItem(BookItem bookItem);
        public void RenewBookItem(BookItem bookItem);

    }
}
