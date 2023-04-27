using MySql.Data.MySqlClient;
using System.Data;

namespace Question2
{
    internal class DataLayer
    {
        private static readonly string connectionString = "server=localhost;uid=root;password='';database=tutorial4";
        private readonly MySqlConnection connection = new MySqlConnection(connectionString);
        private MySqlCommand command;

        //open and close the database connection
        private void OpenCloseDBConnection()
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

        // method to insert values into database
        public void SaveToDatabase(string name, string surname, string gender, string email)
        {
            string query = $"INSERT INTO users (name, surname, gender, email) values ('{name}','{surname}','{gender}','{email}')";

            OpenCloseDBConnection();

            command = new MySqlCommand(query, connection);
            _ = command.ExecuteNonQuery();

            OpenCloseDBConnection();
        }

        //method to read data from database
        public DataTable ReadDataBase()
        {
            string query = "SELECT * FROM users";

            OpenCloseDBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            _ = adapter.Fill(dataTable);

            OpenCloseDBConnection();

            return dataTable;
        }

        //mETHOD TO DELETE A ROW BU ID
        public void DeleteRow(int id)
        {
            string query = $"DELETE FROM USERS WHERE id={id}";

            OpenCloseDBConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            _ = command.ExecuteNonQuery();

            OpenCloseDBConnection();

        }

        //METHOD TO UPDAE A ROW BY ID
        public void UpdateRow(int id, string name, string surname, string gender, string email)
        {
            string query = $"UPDATE users SET name='{name}',surname='{surname}',gender='{gender}',email='{email}' WHERE id={id}";

            OpenCloseDBConnection();

            MySqlCommand command = new MySqlCommand(query, connection);
            _ = command.ExecuteNonQuery();

            OpenCloseDBConnection();

        }
    }
}
