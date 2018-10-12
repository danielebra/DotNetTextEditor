using DotNetAssignment2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DotNetAssignment2.Classes.CustomEventArgs;

namespace DotNetAssignment2
{
    
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        public event EventHandler AccountCreated;
        private void NewUser_Load(object sender, EventArgs e)
        {
            cbUserType.DataSource = retrieveAllEditModes();
        }
        private List<String> retrieveAllEditModes()
        {
            // Inspect the User class and look for all static strings
            // Then check that is follows the naming convention used in this project
            // All results are then considered a valid mode
            var u = new User();
            List<String> editModes = new List<string>();
            foreach (FieldInfo p in u.GetType().GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if (p.Name.Contains("Mode"))
                    editModes.Add(p.GetValue(null).ToString());
            }
            return editModes;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormCompleted())
                {
                    AccountCreated?.Invoke(this, new AccountCreatedArgs(createUserFromForm()));
                    MessageBox.Show(string.Format("Account created for {0} {1}", tbFirstName.Text, tbLastName.Text), 
                        "Successfully created account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to create account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private bool isFormCompleted()
        {
            // Check that passwords match
            if (!String.Equals(tbPassword.Text, tbPasswordConfirm.Text))
            {
                throw Exceptions.PasswordsDontMatch;
            }
            // Check that fields wern't left blank
            foreach (TextBox tb in Utils.GetControlsFromControl(this, typeof(TextBox)))
            {
                if (String.IsNullOrEmpty(tb.Text))
                    throw Exceptions.FieldsAreBlank;
            }
            return true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
