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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {

            SqlDb db = new SqlDb();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`Username`, `Name`, `Email-Id`,`Password`,`Admin Id`) VALUES (@usn, @nam, @email, @pass,@Adi)", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Username.Text;
            command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = NameU.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@Adi", MySqlDbType.VarChar).Value = AdiD.Text;

            db.openConnection();
            if (!checkTextBoxesValues())
            {
                if (Password.Text.Equals(PasswordConf.Text))
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else

                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form1 log = new Form1();
                            log.Show();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



            db.closeConnection();

        }

        public Boolean checkUsername()
        {
            SqlDb db = new SqlDb();

            String username = Username.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean checkTextBoxesValues()
        {
            String fname = NameU.Text;
            String Uname = Username.Text;
            String uname = AdiD.Text;
            String pass = Password.Text;

            if (fname.Trim().Equals("") || Uname.Trim().Equals("")
                 || pass.Trim().Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }




        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void rad_lib_CheckedChanged(object sender, EventArgs e)
        {
            AdiD.Visible = true;
            Adl.Visible = true;
        }

        private void rad_std_CheckedChanged(object sender, EventArgs e)
        {
            AdiD.Visible = false;
            Adl.Visible = false;
        }
        private void NameU_Enter(object sender, EventArgs e)
        {
            string Uname = NameU.Text;
            if (Uname.ToLower().Trim().Equals("Name"))
            {
                NameU.Text = "";
                NameU.ForeColor = Color.Black;
            }
        }
        private void NameU_Leave(object sender, EventArgs e)
        {
            String Uname = NameU.Text;
            if (Uname.ToLower().Trim().Equals("Uname") || Uname.Trim().Equals(""))
            {
                NameU.Text = "first name";
                NameU.ForeColor = Color.Gray;
            }
        }
        private void Username_Enter(object sender, EventArgs e)
        {
            String Usrname = Username.Text;
            if (Usrname.ToLower().Trim().Equals("last name"))
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }
        private void Username_Leave(object sender, EventArgs e)
        {
            String Usrname = Username.Text;
            if (Usrname.ToLower().Trim().Equals("User name") || Usrname.Trim().Equals(""))
            {
                Username.Text = "User name";
                Username.ForeColor = Color.Gray;
            }
        }
        private void AdiD_Enter(object sender, EventArgs e)
        {
            String username = AdiD.Text;
            if (username.ToLower().Trim().Equals("Admin Id"))
            {
                AdiD.Text = "";
                AdiD.ForeColor = Color.Black;
            }
        }
        private void AdiD_Leave(object sender, EventArgs e)
        {
            String username = AdiD.Text;
            if (username.ToLower().Trim().Equals("Admin Id") || username.Trim().Equals(""))
            {
                AdiD.Text = "Admin Id";
                AdiD.ForeColor = Color.Gray;
            }
        }
        private void Password_Enter(object sender, EventArgs e)
        {
            String pass = Password.Text;
            if (pass.ToLower().Trim().Equals("password"))
            {
                Password.Text = "";
                Password.UseSystemPasswordChar = true;
                Password.ForeColor = Color.Black;
            }
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            String pass = Password.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Trim().Equals(""))
            {
                Password.Text = "password";
                Password.UseSystemPasswordChar = false;
                Password.ForeColor = Color.Gray;
            }
        }
        private void PasswordConf_Enter(object sender, EventArgs e)
        {
            String cpassword = PasswordConf.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                PasswordConf.Text = "";
                PasswordConf.UseSystemPasswordChar = true;
                PasswordConf.ForeColor = Color.Black;
            }
        }
        private void PasswordConf_Leave(object sender, EventArgs e)
        {
            String cpassword = PasswordConf.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                PasswordConf.Text = "confirm password";
                PasswordConf.UseSystemPasswordChar = false;
                PasswordConf.ForeColor = Color.Gray;
            }

        }
    }
}

