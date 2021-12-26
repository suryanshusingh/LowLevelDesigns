using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.BusinessLayer
{
    public abstract class Account : IAccount
    {
        public bool ChangePassword()
        {
            return true;
        }
    }
}
