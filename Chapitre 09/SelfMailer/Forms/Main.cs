﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MailServerMenu_Click(object sender, EventArgs e)
        {
            new MailServerSettings().ShowDialog();
        }
    }
}
