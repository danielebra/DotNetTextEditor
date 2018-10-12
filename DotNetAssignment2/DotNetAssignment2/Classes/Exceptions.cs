using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    public static class Exceptions
    {
        public static Exception PasswordsDontMatch = new Exception(Style("Passwords don't match.", "Please re-enter your passwords to check that they are correct"));
        public static Exception FieldsAreBlank = new Exception(Style("Not all fields have been filled out."));

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
