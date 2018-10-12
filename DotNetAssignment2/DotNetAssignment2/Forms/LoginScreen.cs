using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetAssignment2.Classes;
using static DotNetAssignment2.Classes.CustomEventArgs;

namespace DotNetAssignment2
{
    public partial class LoginScreen : Form
    {
        State state;
        FileManipulator fileManipulator;
        Authentication authentication;

        public LoginScreen()
        {
            InitializeComponent();
            // Create instances of important objects
            state = new State();
            fileManipulator = new FileManipulator("login.txt");
            authentication = new Authentication(ref state);
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            // Load users from the account file into the system
            try
            {
                state.Users = fileManipulator.GetAllUserDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading user accounts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (authentication.areCredentialsValid(tbUsername.Text, tbPassword.Text))
            {
                // Match a user by Username to a User object
                User user = this.state.Users.Where(u => string.Equals(u.Username, tbUsername.Text)).FirstOrDefault();
                // Pass the user object to the TextEditor screen
                TextEditor textEditor = new TextEditor(user);
                textEditor.FormClosing += ShowLoginScreen;
                textEditor.Show();
                // Clear text fields
                clearInputFields();
                this.Hide();
            }
            else
                MessageBox.Show("Please check that your credentials are correct", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void clearInputFields()
        {
            tbUsername.Text = String.Empty;
            tbPassword.Text = String.Empty;
            tbUsername.Focus();
        }
        private void ShowLoginScreen(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUser newUserScreen = new NewUser();
            // Make this form reappear when the new one is closed
            newUserScreen.FormClosing += ShowLoginScreen;
            // Add the new account to state
            newUserScreen.AccountCreated += NewUserScreen_AccountCreated;
            newUserScreen.Show();
            this.Hide();
        }

        private void NewUserScreen_AccountCreated(object sender, EventArgs e)
        {
            // Event is triggede when a new account is created from the NewUserScreen
            state.Users.Add(((AccountCreatedArgs)e).User);
            fileManipulator.WriteUserDetails(state.Users);
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Write accounts to file when login screen is closed
            fileManipulator.WriteUserDetails(this.state.Users);
        }
    }
}
