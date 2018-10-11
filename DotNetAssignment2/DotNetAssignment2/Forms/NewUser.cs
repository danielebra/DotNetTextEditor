using DotNetAssignment2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAssignment2
{
    
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        //public delegate void AccountCreated(object sender, AccountCreatedArgs e);
        public event EventHandler AccountCreated;
        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var foo = mcDoB.TodayDate;
            if (AccountCreated != null)
            {
                AccountCreated(this, new AccountCreatedArgs(createUserFromForm()));
            }
        }

        private User createUserFromForm()
        {
            User user = new User();
            
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            user.DateOfBirth = mcDoB.SelectionStart;
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.canEdit = String.Equals(cbUserType.Text, User.EditMode);

            return user;
        }

        
    }
    public class AccountCreatedArgs : EventArgs
    {
        public AccountCreatedArgs(User user)
        {
            this.User = user;
        }
        public User User { get; set; }
    }
}
