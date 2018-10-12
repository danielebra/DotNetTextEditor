using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    class CustomEventArgs
    {
        // Custom arguments to pass to an event handler that contains a User object
        public class AccountCreatedArgs : EventArgs
        {
            public AccountCreatedArgs(User user)
            {
                this.User = user;
            }
            public User User { get; set; }
        }
    }
}
