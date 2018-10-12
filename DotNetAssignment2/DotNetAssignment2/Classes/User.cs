using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    public class User
    {
        // Edit Modes
        public const string EditMode = "Edit";
        public const string ViewMode = "View";

        // User attributes
        public string Username { get; set; }
        public string Password { get; set; }
        public bool canEdit { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public User()
        {

        }

        public User(string username, string password, bool canEdit, 
            string firstName, string lastName, DateTime dateOfBirth)
        {
            this.Username = username;
            this.Password = password;
            this.canEdit = canEdit;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }
        // ToString is used to convert the object into the formatting used by the file system
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", 
                            this.Username, this.Password,
                            this.canEdit ? User.EditMode : User.ViewMode,
                            this.FirstName, this.LastName, 
                            string.Format("{0}-{1}-{2}", this.DateOfBirth.Day, 
                                                         this.DateOfBirth.Month, 
                                                         this.DateOfBirth.Year));
        }
    }
    
}
