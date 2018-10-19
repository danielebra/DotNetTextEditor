using DotNetAssignment2.Classes;
using DotNetAssignment2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAssignment2
{
    public partial class TextEditor : Form
    {
        public User UserInstance { get; set; }
        private RichTextBoxManipulator rtbManipulator;
        private RtfFile rtfFile = new RtfFile();

        public TextEditor()
        {
            InitializeComponent();
        }
        // Retrieve a user instanse so approriate decisions can be made
        // Such as: displaying username and enabling or disabling editing
        public TextEditor(User user)
        {
            InitializeComponent();
            UserInstance = user;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // I later realized that hotkeys are natively supported in the menu strip buttons...
            // I will still keep and use this implementation.

            // Handle file manipulation hotkeys
            if (HotKeys.Save(keyData))
            {
                tsbtnSave_Click(this, null);
                return true;
            }
            else if (HotKeys.Open(keyData))
            {
                tsbtnOpen_Click(this, null);
                return true;
            }
            else if (HotKeys.New(keyData))
            {
                tsbtnNew_Click(this, null);
                return true;
            }
            // Handle text manipulation hotkeys
            else if (HotKeys.Cut(keyData))
            {
                tsbtnCut_Click(this, null);
                return true;
            }
            else if (HotKeys.Copy(keyData))
            {
                tsbtnCopy_Click(this, null);
                return true;
            }
            else if (HotKeys.Paste(keyData))
            {
                tsbtnPaste_Click(this, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void TextEditor_Load(object sender, EventArgs e)
        {
            handleUserPerception();
            populateFontSizes();
            // Connect the rich text box to the RichTextBoxManipulator
            rtbManipulator = new RichTextBoxManipulator(ref rtbText, this.UserInstance.canEdit);
        }

        private void handleUserPerception()
        {
            // Handle edit mode
            rtbText.ReadOnly = !UserInstance.canEdit;
            // Display username
            tslblUsername.Text = "Username: " + UserInstance.Username;
        }

        private void populateFontSizes()
        {
            // Create items in the combo box for font sizes
            for (int i = 8; i <= 20; i++)
            {
                tscbFontSize.Items.Add(i);
            }
        }

        private void tscbFontSize_TextChanged(object sender, EventArgs e)
        {
            rtbManipulator.ChangeSelectionFontSize(float.Parse(tscbFontSize.Text));
        }

        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            rtbManipulator.BoldSelection();
        }

        private void tsbtnItalics_Click(object sender, EventArgs e)
        {
            rtbManipulator.ItalicizeSelection();
        }

        private void tsbtnUnderline_Click(object sender, EventArgs e)
        {
            rtbManipulator.UnderlineSelection();
        }

        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            rtbManipulator.Cut();
        }

        private void tsbtnCopy_Click(object sender, EventArgs e)
        {
            rtbManipulator.Copy();
        }

        private void tsbtnPaste_Click(object sender, EventArgs e)
        {
            rtbManipulator.Paste();
        }

        private void tsbtnSaveAs_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Update file path to the results of the dialog box
                rtfFile.FilePath = sfd.FileName;
                rtfFile.Save();
            }
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load contents of rtf file into the system
                    rtfFile.FilePath = ofd.FileName;
                    rtfFile.Contents = File.ReadAllText(ofd.FileName);
                    rtbText.Rtf = rtfFile.Contents;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error loading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            // Check if we know where we can save the file
            if (!String.IsNullOrEmpty(rtfFile.FilePath))
            {
                rtfFile.Save();
            }
            else
            {
                // We don't know where to save the file, so execute the Save As process
                tsbtnSaveAs_Click(this, null);
            }

        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            // Keep the rtfFile in sync with the interface
            rtfFile.Contents = rtbText.Rtf;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the About page
            About about = new About();
            about.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            // Ask the user to confirm that the text editor should be reset
            if (MessageBox.Show("Are you sure you want to create a new file? Any unsaved changes will be lost.",
                "Confirm New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Clear the editor
                rtfFile = new RtfFile();
                rtbText.Rtf = string.Empty;
            }
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask the user to confirm before closing
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logging Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
