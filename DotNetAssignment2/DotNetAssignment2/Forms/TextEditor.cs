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
        private string fontName = "Microsoft Sans Serif";
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
            populateFontSizes();
        }

        private void handleUserPerception()
        {
            rtbText.ReadOnly = !UserInstance.canEdit;
            tslblUsername.Text = "Username: " + UserInstance.Username;
        }

        private void populateFontSizes()
        {
            for (int i = 8; i <= 20; i++)
            {
                tscbFontSize.Items.Add(i);
            }
        }

        private void tscbFontSize_TextChanged(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(this.fontName, float.Parse(tscbFontSize.Text));
        }

        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(rtbText.SelectionFont, FontStyle.Bold);
        }

        private void tsbtnItalics_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(rtbText.SelectionFont, FontStyle.Italic);
        }

        private void tsbtnUnderline_Click(object sender, EventArgs e)
        {
            rtbText.SelectionFont = new Font(rtbText.SelectionFont, FontStyle.Underline);
        }

        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            tsbtnCopy_Click(this, null);
            rtbText.SelectedText = string.Empty;
        }

        private void tsbtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbText.SelectedRtf, TextDataFormat.Rtf);
        }

        private void tsbtnPaste_Click(object sender, EventArgs e)
        {
            //rtbText.SelectionLength = 0;
            rtbText.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
        }
    }
}
