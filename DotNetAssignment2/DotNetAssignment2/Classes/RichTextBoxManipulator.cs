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
        // Respect editing permissions
        private bool canEdit;

        // Pass through a reference to a RichTextBox in order to perform accurate updates
        public RichTextBoxManipulator(ref RichTextBox rtb, bool canEdit)
        {
            this.targetRtb = rtb;
            this.canEdit = canEdit;
        }
        // Basic text manipulation methods
        public void Copy()
        {
            Clipboard.SetText(targetRtb.SelectedRtf, TextDataFormat.Rtf);
        }
        public void Cut()
        {
            if (!canEdit) return;
            this.Copy();
            targetRtb.SelectedText = string.Empty;
        }
        public void Paste()
        {
            if (!canEdit) return;
            //targetRtb.SelectionLength = 0;
            targetRtb.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
        }
        public void BoldSelection()
        {
            if (!canEdit) return;
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, targetRtb.SelectionFont.Style ^ FontStyle.Bold);
        }
        public void ItalicizeSelection()
        {
            if (!canEdit) return;
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, targetRtb.SelectionFont.Style ^ FontStyle.Italic);
        }
        public void UnderlineSelection()
        {
            if (!canEdit) return;
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, targetRtb.SelectionFont.Style ^ FontStyle.Underline);
        }
        public void ChangeSelectionFontSize(float size)
        {
            if (!canEdit) return;
            targetRtb.SelectionFont = new System.Drawing.Font(targetRtb.SelectionFont.Name, size);
        }
    }
}
