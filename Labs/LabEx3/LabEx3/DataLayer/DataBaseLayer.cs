using MySql.Data.MySqlClient;
using System.Data;

namespace DataLayer
{
    public class DataBaseLayer
    {
        private static readonly string connectionString = "server=localhost;uid=root;password='';database=users";
        private readonly MySqlConnection connection = new MySqlConnection(connectionString);
        private MySqlCommand command;

        private void OpenCloseConnection()
        {
            switch (connection.State)
            {
                case ConnectionState.Closed:
                    connection.Open();
                    break;
                default:
                    connection.Close();
                    break;
            }
        }

        public void AddToDatabase(string idNumber, string name, string surname, string email, int age)
        {
            //Oppen connection
            OpenCloseConnection();
            string data = $"INSERT INTO user_details (idNumber, name, surname, email, age) VALUES ('{idNumber}','{name}','{surname}','{email}',{age})";
            command = new MySqlCommand(data, connection);
            //Send command to database
            _ = command.ExecuteNonQuery();
            //Close connection
            OpenCloseConnection();

        }

    }
}
