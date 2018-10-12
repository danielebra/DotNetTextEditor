using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment2.Classes
{
    public class FileManipulator
    {
        // This is the path used to access the text file
        private string filePath { get; set; }

        public FileManipulator(string path)
        {
            this.filePath = path;  
        }
        public List<User> GetAllUserDetails()
        {
            // Returns a list of user objects that comes from the text file

            List<User> userList = new List<User>();
            foreach (string line in File.ReadLines(this.filePath))
                userList.Add(CreateUserFromString(line));
            return userList;
        }
        public void WriteUserDetails(List<User> users)
        {
            // Save a user list to the text file

            List<String> userDetailList = new List<string>();
            foreach (User user in users)
            {
                userDetailList.Add(user.ToString());
            }
            File.WriteAllLines(this.filePath, userDetailList);
        }
        private User CreateUserFromString(string userString)
        {
            // Deconstructs a string into 6 parts in order to reproduce it as a User object
            User user = new User();
            string[] data = userString.Split(',');

            // The data structure requires 6 portions, raise an error if it doesn't match
            if (data.Length != 6)
                throw Exceptions.InvalidUserFormat;

            user.Username = data[0];
            user.Password = data[1];
            user.canEdit = String.Equals(data[2], User.EditMode);
            user.FirstName = data[3];
            user.LastName = data[4];

            // Break down date of birth to match the dd-mm-yyyy format
            string dateOfBirth = data[5];
            string[] dateOfBirthSegments = dateOfBirth.Split('-');
            user.DateOfBirth = new DateTime(int.Parse(dateOfBirthSegments[2]),
                                            int.Parse(dateOfBirthSegments[1]),
                                            int.Parse(dateOfBirthSegments[0]));
            return user;
        }
    }
}
