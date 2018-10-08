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
        private string filePath { get; set; }
        public FileManipulator(string path)
        {
            this.filePath = path;
        }
        public List<User> GetAllUserDetails()
        {
            List<User> userList = new List<User>();
            foreach (string line in File.ReadLines(this.filePath))
                userList.Add(CreateUserFromString(line));
            return userList;
        }
        private User CreateUserFromString(string userString)
        {
            User user = new User();
            string[] data = userString.Split(',');
            user.Username = data[0];
            user.Password = data[1];
            user.canEdit = String.Equals(data[2], User.EditMode);
            user.FirstName = data[3];
            user.LastName = data[4];
            string dateOfBirth = data[5]; // dd-mm-yyyy
            string[] dateOfBirthSegments = dateOfBirth.Split('-');
            user.DateOfBirth = new DateTime(int.Parse(dateOfBirthSegments[2]),
                                            int.Parse(dateOfBirthSegments[1]),
                                            int.Parse(dateOfBirthSegments[0]));
            return user;
        }
    }
}
