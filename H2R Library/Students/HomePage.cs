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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'h2rlibDataSet1.users' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'h2rlibDataSet.users' table. You can move, or remove it, as needed.
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog form = new Catalog();
            form.Show();
            Visible = false;
        }
    }
}
