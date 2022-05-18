using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MeatOn
{
    static class DB
    {
        private static string connectString; // Объявление Строки подключения - статического поля класса 
        static MySqlConnection myConnection; // Объявление переменной подключения - статического поля класса 
        static string SQLServerName = "localhost"; // ip хоста MySqlServer
        static int port = 3306; // порт MySqlServer
        static string dataBase = "meaton"; // Название БД
        static string username = "root"; // Имя пользователя
        static string password = ""; // Пароль
        public static void OpenConnection() // Статический метод, открывающий соединение с БД
        {
            connectString = "Server=" + SQLServerName + ";Database=" + dataBase
                + ";port=" + port + ";User Id=" + username + ";password=" + password; // Строка подключения к базе данных

            myConnection = new MySqlConnection(connectString); // Создание экземпляра класса MySqlConnection
            myConnection.Open(); // Открытие соединения
        }

        public static List<string[]> ExecuteQuery(string query, int col) // Статический Метод для выполнения запроса, где возвращаемым элементом является массив полей и строк
        {
            MySqlCommand command = new MySqlCommand(query, myConnection); // Создание экземпляра класса MySqlCommand
            MySqlDataReader reader = command.ExecuteReader(); // Объявление объекта класса MySqlDataReader
            List<string[]> response = new List<string[]>(); // Список, в который будут помещаться массивы полей
            while (reader.Read())
            {
                response.Add(new string[col]); // Добавление в список массива с "col" элементов
                for (int i = 0; i < col; i++)
                    response[response.Count - 1][i] = reader[i].ToString(); // Заполнение добавленного массива
            }
            reader.Close(); // Закрытие Reader'a
            if (response.Count != 0) // Если список response пустой, тогда вывод NULL
                return response;
            else
                return null;
        }

        public static string ExecuteQuery(string query) // Статический Метод для выполнения запроса, где возвращаемым элементом является только одно поле
        {
            MySqlCommand command = new MySqlCommand(query, myConnection); // Создание экземпляра класса MySqlCommand
            MySqlDataReader reader = command.ExecuteReader(); // Объявление объекта класса MySqlDataReader
            string response = null; // Строка, в которую будет записан результат выполнения запроса
            while (reader.Read())
            {
                response = reader[0].ToString();
            }
            reader.Close();  // Закрытие Reader'a
            return response; // Возвращение полученной строки (поля)
        }
        public static void ExecuteQueryWithoutResponse(string query) // Статический Метод для выполнения запроса, который не возвращает поля (INSERT, EXECUTE)
        {
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.ExecuteNonQuery();
        }
        public static void CloseConnection() // Закрытие соединения с БД
        {
            myConnection.Close();
        }
    }
}
