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
            state = new State();
            fileManipulator = new FileManipulator("login.txt");
            authentication = new Authentication(ref state);
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            state.Users = fileManipulator.GetAllUserDetails();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (authentication.areCredentialsValid(tbUsername.Text, tbPassword.Text))
            {
                TextEditor textEditor = new TextEditor();
                textEditor.FormClosing += ShowLoginScreen;
                textEditor.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please check that your credentials are correct", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            newUserScreen.Show();
            this.Hide();
        }
    }
}
