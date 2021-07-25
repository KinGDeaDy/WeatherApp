using MySql.Data.MySqlClient;

namespace WeatherApp
{
       class DataBase
        {
        MySqlConnection connection = new MySqlConnection("server=195.88.209.189;username=artem_admin;password=OdSWO89cms;database=artem_base");
        
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
