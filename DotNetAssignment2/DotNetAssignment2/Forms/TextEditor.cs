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
    public partial class TextEditor : Form
    {
        public User UserInstance { get; set; }
        public TextEditor()
        {
            InitializeComponent();
        }
        
        public TextEditor(User user)
        {
            InitializeComponent();
            UserInstance = user;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            handleUserPerception();
        }

        private void handleUserPerception()
        {
            rtbText.ReadOnly = !UserInstance.canEdit;
            tslblUsername.Text = "Username: " + UserInstance.Username;
        }
    }
}
