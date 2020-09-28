using MySql.Data.MySqlClient;
namespace H2R_Library
{
    internal class SqlDb
    {
        public SqlDb()
        {
        }
            private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=bookstore");
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            public MySqlConnection getConnection()
            {
                return connection;
            }
        }
    }
