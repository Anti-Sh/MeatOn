using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatOn
{
    public partial class index : Form
    {
        private int multiplier = 1; // для перевода в секунды
        private int inputValue = 0; // введенное пользователем число
        private List<string[]> orders = new List<string[]>(); // Массив для хранения результата запроса
        public index()
        {
            InitializeComponent();
        }
        private void index_Load(object sender, EventArgs e)
        {
            querySelect.SelectedIndex = 0;
            inputType.SelectedIndex = 0;
            querySelect_SelectionChangeCommitted(null, null);
        }
        private void hideOutputs()
        {
            GroupBox[] outputs = new GroupBox[] { query1, query2, query3 };
            foreach (GroupBox b in outputs) b.Hide();
        }
        private void querySelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            void timePeriod()
            {
                labelForInput.Text = "Период:";
                inputNumber.Minimum = 1;
                inputNumber.Maximum = 60;
                inputNumber.Increment = 1;
                inputNumber.Value = 1;
                inputType.Items.Clear();
                inputType.Items.AddRange(new string[] { "м", "ч", "д" });
                inputType.SelectedIndex = 0;
                inputNumber.Location = new Point(99, 120);
                inputType.Location = new Point(171, 119);
            }
            void maxSum()
            {
                labelForInput.Text = "Предел суммы:";
                inputNumber.Minimum = 100;
                inputNumber.Maximum = 100000;
                inputNumber.Increment = 100;
                inputNumber.Value = 1000;
                inputType.Items.Clear();
                inputType.Items.AddRange(new string[] { "руб" });
                inputType.SelectedIndex = 0;
                inputNumber.Location = new Point(156, 120);
                inputType.Location = new Point(228, 119);
            }
            switch (querySelect.SelectedIndex)
            {
                case 0:
                    timePeriod();
                    hideOutputs();
                    break;
                case 1:
                    maxSum();
                    hideOutputs();
                    break;
                case 2:
                    timePeriod();
                    hideOutputs();
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            void determineMultiplier() // Определение значения множителя
            {
                switch (inputType.SelectedIndex)
                {
                    case 0: // из минут в секунды
                        multiplier = 60;
                        break;
                    case 1: // из часов в секунды
                        multiplier = 60 * 60;
                        break;
                    case 2: // из дней в секунды
                        multiplier = 60 * 60 * 24;
                        break;
                }
            }
            if (querySelect.SelectedIndex != 1) determineMultiplier(); // Для временных запросов определяем значение множителя
            inputValue = Convert.ToInt32((decimal)inputNumber.Value) * multiplier; // Записываем в переменную введенное пользователем значение
            switch (querySelect.SelectedIndex)
            {
                case 0:
                    query1.Show();
                    DoQuery1();
                    break;
                case 1:
                    query2.Show();
                    DoQuery2();
                    break;
                case 2:
                    query3.Show();
                    query3.Visible = true;
                    DoQuery3();
                    break;
            }
        }
        private void selectOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DB.OpenConnection();
            void fillDataGrid(int id)
            {
                orderDishes.Rows.Clear();
                string query = $"SELECT md.name, o.count, o.count*md.cost FROM orders_food o JOIN menu_dishes md ON md.id=o.dish_id WHERE o.order_id={id}";
                var dishes = DB.ExecuteQuery(query, 3);
                foreach (var dish in dishes) orderDishes.Rows.Add(dish);
            }
            var index = selectOrders.SelectedIndex;
            user.Text = orders[index][1] + " " + orders[index][2];
            address.Text = orders[index][3];
            dateto.Text = DateFromTimeStamp(Convert.ToInt64(orders[index][4])).ToString();
            fullcost.Text = orders[index][5];
            tel.Text = orders[index][6];
            fillDataGrid(Convert.ToInt32(orders[index][0]));
            DB.CloseConnection();
        }
        private void DoQuery1()
        {
            DB.OpenConnection();
            string query = $"SELECT o.id, u.surname, u.name, u.address, o.delivery_timestamp, (SELECT SUM(orf.count * md.cost) FROM orders_food orf JOIN menu_dishes md ON orf.dish_id=md.id WHERE orf.order_id = o.id), u.phone FROM orders o JOIN users u ON o.customer = u.id WHERE o.completion=0 AND o.delivery_timestamp<{TimeStampWithAdd(inputValue)}";
            orders = DB.ExecuteQuery(query, 7);
            selectOrders.Items.Clear();
            foreach (var order in orders) selectOrders.Items.Add("Заказ #" + order[0]);

            selectOrders.SelectedIndex = 0;
            selectOrders_SelectionChangeCommitted(null, null);
            DB.CloseConnection();
        }
        private void DoQuery2()
        {
            DB.OpenConnection();
            string query = $"SELECT COUNT(o.id) FROM orders o WHERE(SELECT SUM(orf.count * md.cost) FROM orders_food orf JOIN menu_dishes md ON orf.dish_id = md.id WHERE orf.order_id = o.id) < {inputValue}";
            countOrders.Text = DB.ExecuteQuery(query);
            DB.CloseConnection();
        }
        private void DoQuery3()
        {
            DB.OpenConnection();
            string query = $"SELECT SUM(md.cost*orf.count) FROM orders_food orf JOIN menu_dishes md ON md.id=orf.dish_id JOIN orders o ON orf.order_id = o.id WHERE o.delivery_timestamp < {TimeStampWithAdd(inputValue)}";
            revenue.Text = DB.ExecuteQuery(query);
            DB.CloseConnection();
        }
        private static DateTime DateFromTimeStamp(long unixTimeStamp) // Дата из Timestamp
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 3, 0, 0, 0, DateTimeKind.Local);
            return dateTime.AddSeconds(Convert.ToDouble(unixTimeStamp)).ToLocalTime();
        }
        private static long TimeStampWithAdd(int seconds) // Timestamp текущего времени + добавочные секунды
        {
            DateTime unix = new DateTime(1970, 1, 1, 3, 0, 0, 0, DateTimeKind.Local);
            return (long)((DateTime.Now - unix).TotalSeconds + seconds);
        }
    }
}
