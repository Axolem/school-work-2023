using MySql.Data.MySqlClient;
using System.Data;

namespace DataLayer
{
    public class DataLayerClass
    {
        private static readonly string connectionString = "server=localhost;uid=root;password='';database=lab5";
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
        public void SaveToDatabase(string expression)
        {
            string query = $"INSERT INTO calculations (id, recent, timestamp) values (default,'{expression}',default)";

            OpenCloseDBConnection();

            command = new MySqlCommand(query, connection);
            _ = command.ExecuteNonQuery();

            OpenCloseDBConnection();
        }

        //method to read data from database
        public DataTable ReadDataBase()
        {
            string query = "SELECT * FROM calculations";

            OpenCloseDBConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();
            _ = adapter.Fill(dataTable);

            OpenCloseDBConnection();

            return dataTable;
        }
    }
}
