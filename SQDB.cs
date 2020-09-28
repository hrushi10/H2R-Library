using System;
using MySql.Data.MySqlClient;

public class SqlDb
{
    private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=bookstore");


    // create a function to open the connection
    public void openConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    // create a function to close the connection
    public void closeConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // create a function to return the connection
    public MySqlConnection getConnection()
    {
        return connection;
    }
}
