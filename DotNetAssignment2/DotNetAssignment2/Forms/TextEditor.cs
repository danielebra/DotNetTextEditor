﻿using DotNetAssignment2.Classes;
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

        public TextEditor(User user)
        {
            InitializeComponent();
            UserInstance = user;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            handleUserPerception();
            populateFontSizes();
            rtbManipulator = new RichTextBoxManipulator(ref rtbText);
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
                rtfFile.FilePath = sfd.FileName;
                rtfFile.Save();
            }
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtfFile.FilePath = ofd.FileName;
                rtfFile.Contents = File.ReadAllText(ofd.FileName);
                rtbText.Rtf = rtfFile.Contents;
            }
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rtfFile.FilePath))
            {
                rtfFile.Save();
            }
            else
            {
                tsbtnSaveAs_Click(this, null);
            }

        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            rtfFile.Contents = rtbText.Rtf;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            rtfFile = new RtfFile();
            rtbText.Rtf = string.Empty;
        }
    }
}
