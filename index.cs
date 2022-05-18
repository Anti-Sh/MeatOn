using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MeatOn
{
    public partial class index : Form
    {
        private int multiplier = 1; // для перевода в секунды
        private int inputValue = 0; // введенное пользователем число
        private List<string[]> orders = new List<string[]>(); // Массив для хранения результата запроса
        public index() // Конструктор Формы
        {
            InitializeComponent(); // Инициализация компонентов
        }
        private void index_Load(object sender, EventArgs e) // Обработчик события "Загрузка формы"
        {
            querySelect.SelectedIndex = 0; // Изменение выбранного индекса
            inputType.SelectedIndex = 0; // Изменение выбранного индекса
            querySelect_SelectionChangeCommitted(null, null); // Вызов обработчика событий
        }
        private void hideOutputs() // Метод для скрытия всех Областей вывода данных
        {
            GroupBox[] outputs = new GroupBox[] { query1, query2, query3 }; // Список всех Областей вывода данных
            foreach (GroupBox b in outputs) b.Hide(); // Скрытие каждого элеметна из списка
        }
        private void querySelect_SelectionChangeCommitted(object sender, EventArgs e) // Обработчик события "Изменение выделения зафиксировано"
        {
            void timePeriod() // Локальная функция. Изменение области входных данных
            {
                labelForInput.Text = "Период:"; // Текст надписи
                inputNumber.Minimum = 1; // Минимальное значение NumericUpDown
                inputNumber.Maximum = 60; // Максимальное значение NumericUpDown
                inputNumber.Increment = 1; // Шаг увеличения/уменьшения
                inputNumber.Value = 1;    // Значения
                inputType.Items.Clear(); // Очистка выпадающего списка 
                inputType.Items.AddRange(new string[] { "м", "ч", "д" }); // Добавление элементов
                inputType.SelectedIndex = 0; // Изменение выбранного индекса
                inputNumber.Location = new Point(99, 120); // Координаты 
                inputType.Location = new Point(171, 119); // Координаты 
            }
            void maxSum() // Локальная функция. Изменение области входных данных
            {
                labelForInput.Text = "Предел суммы:"; // Текст надписи
                inputNumber.Minimum = 100; // Минимальное значение NumericUpDown
                inputNumber.Maximum = 100000; // Максимальное значение NumericUpDown
                inputNumber.Increment = 100; // Шаг увеличения/уменьшения
                inputNumber.Value = 1000;    // Значения
                inputType.Items.Clear(); // Очистка выпадающего списка 
                inputType.Items.AddRange(new string[] { "руб" }); // Добавление элементов
                inputType.SelectedIndex = 0; // Изменение выбранного индекса
                inputNumber.Location = new Point(156, 120); // Координаты 
                inputType.Location = new Point(228, 119); // Координаты 
            }
            switch (querySelect.SelectedIndex) // Действие в зависимости от выбранного пункта выпадающего меню
            {
                case 0: // выбран первый элемент
                    timePeriod(); // функция изменения элементов ввода
                    hideOutputs(); // скрытие всех областей вывода
                    break;
                case 1: // выбран второй элемент
                    maxSum(); // функция изменения элементов ввода
                    hideOutputs(); // скрытие всех областей вывода
                    break;
                case 2: // выбран третий элемент
                    timePeriod(); // функция изменения элементов ввода
                    hideOutputs(); // скрытие всех областей вывода
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e) // Обработчик события "Изменение выделения зафиксировано"
        {
            void determineMultiplier() // Определение значения множителя
            {
                switch (inputType.SelectedIndex) // Действие в зависимости от выбранного пункта выпадающего меню
                {
                    case 0: // из минут в секунды
                        multiplier = 60; // множитель
                        break;
                    case 1: // из часов в секунды
                        multiplier = 60 * 60; // множитель
                        break;
                    case 2: // из дней в секунды
                        multiplier = 60 * 60 * 24; // множитель
                        break;
                }
            }
            if (querySelect.SelectedIndex != 1) determineMultiplier(); // Для временных запросов определяем значение множителя
            inputValue = Convert.ToInt32((decimal)inputNumber.Value) * multiplier; // Записываем в переменную введенное пользователем значение
            switch (querySelect.SelectedIndex) // Действие в зависимости от выбранного пункта выпадающего меню
            {
                case 0: // выбран первый элемент
                    query1.Show(); // Включение видимости первой области вывода
                    DoQuery1(); // Выполнение первого запроса
                    break;
                case 1: // выбран второй элемент
                    query2.Show(); // Включение видимости второй области вывода
                    DoQuery2(); // Выполнение второго запроса
                    break;
                case 2: // выбран третий элемент
                    query3.Show(); // Включение видимости третий области вывода
                    DoQuery3(); // Выполнение третьего запроса
                    break;
            }
        }
        private void selectOrders_SelectionChangeCommitted(object sender, EventArgs e) // Обработчик события "Изменение выделения зафиксировано"
        {
            DB.OpenConnection(); // Открытие соединения с БД
            void fillDataGrid(int id) // Локальная функция заполнения DataGrid
            {
                orderDishes.Rows.Clear(); // Удаление уже имеющихся записей
                string query = $"SELECT md.name, o.count, o.count*md.cost FROM orders_food o JOIN menu_dishes md ON md.id=o.dish_id WHERE o.order_id={id}"; // Запрос
                var dishes = DB.ExecuteQuery(query, 3); // Извлечение результатов выполнения запросов
                foreach (var dish in dishes) orderDishes.Rows.Add(dish); // Добавление записей в DataGrid
            }
            var index = selectOrders.SelectedIndex; // Номер выбранного заказа
            user.Text = orders[index][1] + " " + orders[index][2]; // Заполнение полей вывода
            address.Text = orders[index][3]; // Заполнение полей вывода
            dateto.Text = DateFromTimeStamp(Convert.ToInt64(orders[index][4])).ToString(); // Заполнение полей вывода
            fullcost.Text = orders[index][5]; // Заполнение полей вывода
            tel.Text = orders[index][6]; // Заполнение полей вывода
            fillDataGrid(Convert.ToInt32(orders[index][0])); // Заполнение DataGrid
            DB.CloseConnection(); // Закрытие соединения с БД
        }
        private void DoQuery1() // Функция первого запроса
        {
            DB.OpenConnection(); // Открытие соединения с БД
            string query = $"SELECT o.id, u.surname, u.name, u.address, o.delivery_timestamp, (SELECT SUM(orf.count * md.cost) FROM orders_food orf JOIN menu_dishes md ON orf.dish_id=md.id WHERE orf.order_id = o.id), u.phone FROM orders o JOIN users u ON o.customer = u.id WHERE o.completion=0 AND o.delivery_timestamp<{TimeStampWithAdd(inputValue)}";
            orders = DB.ExecuteQuery(query, 7); // Извлечение результатов выполнения запросов
            selectOrders.Items.Clear(); // Удаление всех пунктов выпадающего списка
            foreach (var order in orders) selectOrders.Items.Add("Заказ #" + order[0]); // Добавление найденных заказов в выпадающий список

            selectOrders.SelectedIndex = 0; // изменение выбранного элемента
            selectOrders_SelectionChangeCommitted(null, null); // Вызов обработчика изменения выбранного элемента выпадающего списка
            DB.CloseConnection(); // Закрытие соединения с БД
        }
        private void DoQuery2() // Функция второго запроса
        {
            DB.OpenConnection(); // Открытие соединения с БД
            string query = $"SELECT COUNT(o.id) FROM orders o WHERE(SELECT SUM(orf.count * md.cost) FROM orders_food orf JOIN menu_dishes md ON orf.dish_id = md.id WHERE orf.order_id = o.id) < {inputValue}";
            countOrders.Text = DB.ExecuteQuery(query); // Извлечение результата выполнения запросов
            DB.CloseConnection(); // Закрытие соединения с БД
        }
        private void DoQuery3() // Функция третьего запроса
        {
            DB.OpenConnection(); // Открытие соединения с БД
            string query = $"SELECT SUM(md.cost*orf.count) FROM orders_food orf JOIN menu_dishes md ON md.id=orf.dish_id JOIN orders o ON orf.order_id = o.id WHERE o.delivery_timestamp < {TimeStampWithAdd(inputValue)}";
            revenue.Text = DB.ExecuteQuery(query); // Извлечение результата выполнения запросов
            DB.CloseConnection(); // Закрытие соединения с БД
        }
        private static DateTime DateFromTimeStamp(long unixTimeStamp) // Дата из Timestamp
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 3, 0, 0, 0, DateTimeKind.Local); // Timestamp - количество секунд с 1970-01-01 00:00:00
            return dateTime.AddSeconds(Convert.ToDouble(unixTimeStamp)).ToLocalTime();
        }
        private static long TimeStampWithAdd(int seconds) // Timestamp текущего времени + добавочные секунды
        {
            DateTime unix = new DateTime(1970, 1, 1, 3, 0, 0, 0, DateTimeKind.Local); // Timestamp - количество секунд с 1970-01-01 00:00:00
            return (long)((DateTime.Now - unix).TotalSeconds + seconds);
        }
    }
}
