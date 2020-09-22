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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery() {
            string query = textBox1.Text;
            string MysqlConnectionstring = "datasource = 127.0.0.1;port=3306;username=root;password=mysql;database=hp";

            MySqlConnection connection = new MySqlConnection(MysqlConnectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }

        }
    }
}
