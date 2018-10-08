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
        public RichTextBoxManipulator(ref RichTextBox rtb)
        {
            targetRtb = rtb;
        }

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
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, FontStyle.Bold);
        }
        public void ItalicizeSelection()
        {
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, FontStyle.Italic);

        }
        public void UnderlineSelection()
        {
            targetRtb.SelectionFont = new Font(targetRtb.SelectionFont, FontStyle.Underline);

        }
        public void ChangeSelectionFontSize(float size)
        {
            targetRtb.SelectionFont = new System.Drawing.Font(targetRtb.SelectionFont.Name, size);
        }
    }
}
