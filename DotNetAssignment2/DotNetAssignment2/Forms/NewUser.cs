﻿using System;
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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        public event EventHandler Closed;
        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}