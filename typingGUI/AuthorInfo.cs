﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typingGUI
{
    public partial class AuthorInfo : Form
    {
        public AuthorInfo()
        {
            InitializeComponent();
        }

        private void AuthorInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
