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
            
            runQuery();
            MessageBox.Show("Sign Up Successfull");
        }

        private void runQuery()
        {
            string ids = txt_id.Text;
            int id = Int32.Parse(ids);
            string name = txt_name.Text;
            string pass = txt_pass.Text;
            string cpass = txt_cpass.Text;
            string type = null;
            

            if (rad_std.Checked == true)
            {
                type = "student";
                signup.Enabled = true;
            }
            else if (rad_lib.Checked == true)
            {
                type = "Librarian";
                signup.Enabled = true;
            }

            if (pass == cpass)
            {

                string query = ("insert into users values("+id+",'" + name + "','" + pass + "','" + type + "')");
                string MysqlConnectionstring = "datasource = 127.0.0.1;port=3306;username=root;password=mysql;database=h2rLib";

                MySqlConnection connection = new MySqlConnection(MysqlConnectionstring);
                MySqlCommand commandDatabase = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = commandDatabase.ExecuteReader();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            } else 
            if(rad_lib.Checked == false && rad_std.Checked == false) {
                MessageBox.Show("Select a User Type");
            }
            else {
                MessageBox.Show("Password and confirm Password does not match !!");
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
    }
}
