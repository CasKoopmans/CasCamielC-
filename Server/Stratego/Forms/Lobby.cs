﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego.Forms
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            FormClosing += formClosing;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
