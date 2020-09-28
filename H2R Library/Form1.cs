using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace H2R_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDb db = new SqlDb();

            String Usname = textBoxUsername.Text;
            String Password = textBoxPassword.Text;
            String Admin = textBoxAdminID.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Username`= @usn AND `Password` = @pass AND`Admin Id`= @Adi", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Usname;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@Adi", MySqlDbType.VarChar).Value = Admin;


            adapter.SelectCommand = command;

            adapter.Fill(table);
            bool lib = radioButton1.Checked;
            bool stu = radioButton2.Checked;


            if (table.Rows.Count > 0)
            {
                this.Hide();
               HomePage regis = new HomePage();
                regis.Show();
            }
            else
            {
                if (lib)
                {
                    if (Usname.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // check if the password field is empty
                    else if (Password.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Admin.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your Admin Id To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username Or Password or Wrong Admin Id", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (stu)
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f1 = new Form3();
            f1.ShowDialog();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxAdminID.Visible = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAdminID.Visible = false;
            Adl.Visible = false;
           
        }
    }
}
