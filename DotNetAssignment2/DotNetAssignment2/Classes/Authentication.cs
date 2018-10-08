using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    class Authentication
    {
        private State state;
        public Authentication(ref State state)
        {
            this.state = state;
        }

        public bool areCredentialsValid(string username, string password)
        {
            User user = this.state.Users.Where(u => string.Equals(u.Username, username)).FirstOrDefault();
            if (user == null)
                return false;
            if (String.Equals(user.Password, password))
                return true;
            return false;
        }
    }
}
