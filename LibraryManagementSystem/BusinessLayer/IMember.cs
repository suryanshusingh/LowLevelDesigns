using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.BusinessLayer
{
    interface IMember
    {
        public bool CheckOutBookItem(int memberId, BookItem bookItem);
        public void ReturnBookItem(int memberId, BookItem bookItem);
        public bool RenewBookItem(int memberId, BookItem bookItem);
    }
}
