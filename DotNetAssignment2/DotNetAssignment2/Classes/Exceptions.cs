using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    // Formatted exceptions that are used in the project
    public static class Exceptions
    {
        public static Exception PasswordsDontMatch = new Exception(Style("Passwords don't match.", "Please re-enter your passwords to check that they are correct"));
        public static Exception FieldsAreBlank = new Exception(Style("Not all fields have been filled out."));
        public static Exception InvalidUserFormat = new Exception(Style("Unable to read user data", "Try modifying the login file"));

        private static string Style(string message)
        {
            return string.Format("{0}", message);
        }
        private static string Style(string message, string suggestion)
        {
            return string.Format("{0}\n{1}", message, suggestion);
        }
    }
}
