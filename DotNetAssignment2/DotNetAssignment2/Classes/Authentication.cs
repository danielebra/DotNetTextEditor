using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    class Authentication
    {
        // Pass state into this instanse to see the current users loaded into the system
        private State state;
        public Authentication(ref State state)
        {
            this.state = state;
        }

        public bool areCredentialsValid(string username, string password)
        {
            // Check if the password matches the password associated to that user

            User user = this.state.Users.Where(u => string.Equals(u.Username, username)).FirstOrDefault();
            if (user == null) // return false if user doesn't exist
                return false;
            if (String.Equals(user.Password, password)) //return true if passwords match
                return true;
            return false;
        }
    }
}
