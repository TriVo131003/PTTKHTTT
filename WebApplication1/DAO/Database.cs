using System.Data;
using MySql.Data.MySqlClient;

namespace WebApplication1.DAO
{
    public class Database
    {
        string path = $"Server=byurnw82eioyoixoulvr-mysql.services.clever-cloud.com;Database=byurnw82eioyoixoulvr;" +
                $"Uid=uv0jgbeuvv7iffkb;Pwd=ZL8n6wKDCrAqgQ9bWsya;";

        protected DataTable getDataTable(string sql)
        {
            MySqlConnection connection = new MySqlConnection(path);
            //connection.Open();
            //cmd.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        protected int ExecuteNonQuery(string sql)
        {
            MySqlConnection connection = new MySqlConnection(path);
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            var rs = command.ExecuteNonQuery();
            connection.Close();
            return rs;
        }
    }
}