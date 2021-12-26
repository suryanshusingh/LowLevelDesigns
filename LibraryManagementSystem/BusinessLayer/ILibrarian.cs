using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.BusinessLayer
{
    interface ILibrarian
    {
        bool AddBookItem(BookItem bookItem);
        bool BlockMember(string id);
        bool UnblockMember(string id);
    }
}
