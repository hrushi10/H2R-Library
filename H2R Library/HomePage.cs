﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2R_Library
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'h2rlibDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.h2rlibDataSet.users);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            Visible = false;
        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalogue Catalogue = new catalogue();
            Catalogue.Show();
            Visible = false;
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
         //   MyAccount.show();
          //  Visible = false;
        }
    }
}
