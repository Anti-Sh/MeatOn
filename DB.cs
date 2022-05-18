using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MeatOn
{
    static class DB
    {
        private static string connectString;
        static MySqlConnection myConnection;
        static string SQLServerName = "localhost";
        static int port = 3306;
        static string dataBase = "meaton";
        static string username = "root";
        static string password = "";
        public static void OpenConnection()
        {
            connectString = "Server=" + SQLServerName + ";Database=" + dataBase
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            myConnection = new MySqlConnection(connectString);
            myConnection.Open();
        }

        public static List<string[]> ExecuteQuery(string query, int col)
        {
            // SELECT многих значений (несколько столбцов или строк)
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> response = new List<string[]>();
            while (reader.Read())
            {
                response.Add(new string[col]);
                for (int i = 0; i < col; i++)
                    response[response.Count - 1][i] = reader[i].ToString();
            }
            reader.Close();
            if (response.Count != 0)
                return response;
            else
                return null;
        }

        public static string ExecuteQuery(string query)
        {
            // SELECT одного значения
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            string response = null;
            while (reader.Read())
            {
                response = reader[0].ToString();
            }
            reader.Close();
            return response;
        }
        public static void ExecuteQueryWithoutResponse(string query)
        {
            // INSERT and EXECUTE
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.ExecuteNonQuery();
        }
        public static void CloseConnection()
        {
            myConnection.Close();
        }
    }
}
