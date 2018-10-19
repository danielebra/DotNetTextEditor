using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DotNetAssignment2.Classes
{
    public class RichTextBoxManipulator
    {
        private RichTextBox targetRtb;
        // Pass through a reference to a RichTextBox in order to perform accurate updates
        public RichTextBoxManipulator(ref RichTextBox rtb)
        {
            targetRtb = rtb;
        }
        // Basic text manipulation methods
        public void Copy()
        {
            Clipboard.SetText(targetRtb.SelectedRtf, TextDataFormat.Rtf);
        }
        public void Cut()
        {
            this.Copy();
            targetRtb.SelectedText = string.Empty;
        }
        public void Paste()
        {
            //targetRtb.SelectionLength = 0;
            targetRtb.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
        }
        public void BoldSelection()
        {
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, targetRtb.SelectionFont.Style ^ FontStyle.Bold);
        }
        public void ItalicizeSelection()
        {
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, targetRtb.SelectionFont.Style ^ FontStyle.Italic);
        }
        public void UnderlineSelection()
        {
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, targetRtb.SelectionFont.Style ^ FontStyle.Underline);
        }
        public void ChangeSelectionFontSize(float size)
        {
            targetRtb.SelectionFont = new System.Drawing.Font(targetRtb.SelectionFont.Name, size);
        }
    }
}
