using System;
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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           HomePage form = new HomePage();
            form.Show();
            Visible = false;
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Show();
            Visible = false;
        }
    }
}
