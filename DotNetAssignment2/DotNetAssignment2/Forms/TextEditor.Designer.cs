namespace DotNetAssignment2
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBold = new System.Windows.Forms.ToolStripButton();
            this.tsbtnItalics = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tscbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblUsername = new System.Windows.Forms.ToolStripLabel();
            this.tsLeft = new System.Windows.Forms.ToolStrip();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.tsLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::DotNetAssignment2.Properties.Resources.NewFile_16x;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::DotNetAssignment2.Properties.Resources.OpenFolder_16x;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::DotNetAssignment2.Properties.Resources.Save_16x;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::DotNetAssignment2.Properties.Resources.SaveAs_16x;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::DotNetAssignment2.Properties.Resources.ShutDown_16x;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmbtnCut,
            this.tsmbtnCopy,
            this.tsmPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tsmbtnCut
            // 
            this.tsmbtnCut.Image = global::DotNetAssignment2.Properties.Resources.Cut_16x;
            this.tsmbtnCut.Name = "tsmbtnCut";
            this.tsmbtnCut.Size = new System.Drawing.Size(152, 22);
            this.tsmbtnCut.Text = "Cut";
            this.tsmbtnCut.Click += new System.EventHandler(this.tsbtnCut_Click);
            // 
            // tsmbtnCopy
            // 
            this.tsmbtnCopy.Image = global::DotNetAssignment2.Properties.Resources.Copy_16x;
            this.tsmbtnCopy.Name = "tsmbtnCopy";
            this.tsmbtnCopy.Size = new System.Drawing.Size(152, 22);
            this.tsmbtnCopy.Text = "Copy";
            this.tsmbtnCopy.Click += new System.EventHandler(this.tsbtnCopy_Click);
            // 
            // tsmPaste
            // 
            this.tsmPaste.Image = global::DotNetAssignment2.Properties.Resources.Paste_16x;
            this.tsmPaste.Name = "tsmPaste";
            this.tsmPaste.Size = new System.Drawing.Size(152, 22);
            this.tsmPaste.Text = "Paste";
            this.tsmPaste.Click += new System.EventHandler(this.tsbtnPaste_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // tsTop
            // 
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tsbtnOpen,
            this.tsbtnSave,
            this.tsbtnSaveAs,
            this.toolStripSeparator1,
            this.tsbtnBold,
            this.tsbtnItalics,
            this.tsbtnUnderline,
            this.tscbFontSize,
            this.tsbtnHelp,
            this.toolStripSeparator3,
            this.tslblUsername});
            this.tsTop.Location = new System.Drawing.Point(0, 24);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(487, 25);
            this.tsTop.TabIndex = 1;
            this.tsTop.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNew.Image = global::DotNetAssignment2.Properties.Resources.NewFile_16x;
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNew.Text = "New";
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = global::DotNetAssignment2.Properties.Resources.OpenFolder_16x;
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbtnOpen.Text = "Open";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = global::DotNetAssignment2.Properties.Resources.Save_16x;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSave.Text = "Save";
            // 
            // tsbtnSaveAs
            // 
            this.tsbtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSaveAs.Image = global::DotNetAssignment2.Properties.Resources.SaveAs_16x;
            this.tsbtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSaveAs.Name = "tsbtnSaveAs";
            this.tsbtnSaveAs.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSaveAs.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnBold
            // 
            this.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBold.Image = global::DotNetAssignment2.Properties.Resources.Bold_16x;
            this.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBold.Name = "tsbtnBold";
            this.tsbtnBold.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBold.Text = "Bold";
            this.tsbtnBold.Click += new System.EventHandler(this.tsbtnBold_Click);
            // 
            // tsbtnItalics
            // 
            this.tsbtnItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnItalics.Image = global::DotNetAssignment2.Properties.Resources.Italic_16x;
            this.tsbtnItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnItalics.Name = "tsbtnItalics";
            this.tsbtnItalics.Size = new System.Drawing.Size(23, 22);
            this.tsbtnItalics.Text = "Italics";
            this.tsbtnItalics.Click += new System.EventHandler(this.tsbtnItalics_Click);
            // 
            // tsbtnUnderline
            // 
            this.tsbtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUnderline.Image = global::DotNetAssignment2.Properties.Resources.Underline_16x;
            this.tsbtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnderline.Name = "tsbtnUnderline";
            this.tsbtnUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUnderline.Text = "Underline";
            this.tsbtnUnderline.Click += new System.EventHandler(this.tsbtnUnderline_Click);
            // 
            // tscbFontSize
            // 
            this.tscbFontSize.Name = "tscbFontSize";
            this.tscbFontSize.Size = new System.Drawing.Size(121, 25);
            this.tscbFontSize.Text = "Font Size";
            this.tscbFontSize.ToolTipText = "Font Size";
            this.tscbFontSize.TextChanged += new System.EventHandler(this.tscbFontSize_TextChanged);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnHelp.Image = global::DotNetAssignment2.Properties.Resources.Question_16x;
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbtnHelp.Text = "Help";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblUsername
            // 
            this.tslblUsername.Name = "tslblUsername";
            this.tslblUsername.Size = new System.Drawing.Size(63, 22);
            this.tslblUsername.Text = "Username:";
            // 
            // tsLeft
            // 
            this.tsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCut,
            this.tsbtnCopy,
            this.tsbtnPaste});
            this.tsLeft.Location = new System.Drawing.Point(0, 49);
            this.tsLeft.Name = "tsLeft";
            this.tsLeft.Size = new System.Drawing.Size(24, 455);
            this.tsLeft.TabIndex = 2;
            this.tsLeft.Text = "toolStrip2";
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCut.Image = global::DotNetAssignment2.Properties.Resources.Cut_16x;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(21, 20);
            this.tsbtnCut.Text = "Cut";
            this.tsbtnCut.Click += new System.EventHandler(this.tsbtnCut_Click);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopy.Image = global::DotNetAssignment2.Properties.Resources.Copy_16x;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(21, 20);
            this.tsbtnCopy.Text = "Copy";
            this.tsbtnCopy.Click += new System.EventHandler(this.tsbtnCopy_Click);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPaste.Image = global::DotNetAssignment2.Properties.Resources.Paste_16x;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(21, 20);
            this.tsbtnPaste.Text = "Paste";
            this.tsbtnPaste.Click += new System.EventHandler(this.tsbtnPaste_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(24, 49);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(463, 455);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = resources.GetString("rtbText.Text");
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 504);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tsLeft);
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.tsLeft.ResumeLayout(false);
            this.tsLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmbtnCut;
        private System.Windows.Forms.ToolStripMenuItem tsmbtnCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmPaste;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStrip tsLeft;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnBold;
        private System.Windows.Forms.ToolStripButton tsbtnItalics;
        private System.Windows.Forms.ToolStripButton tsbtnUnderline;
        private System.Windows.Forms.ToolStripComboBox tscbFontSize;
        private System.Windows.Forms.ToolStripButton tsbtnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslblUsername;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
    }
}