using CafeMenu;
using MySql.Data.MySqlClient;
using System;
using CafeMenu.General;
public static class OrderService
{
    private static string GetConnectionString()
    {
        var connector = new SqlConnector();
        return connector.GetConnect();
    }

    public static int SaveOrder(Order order)
    {
        string connectionString = GetConnectionString();

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            var countCmd = new MySqlCommand("SELECT COUNT(*) FROM orders WHERE DATE(OrderDate) = CURDATE();", connection);
            int todayCount = Convert.ToInt32(countCmd.ExecuteScalar());

            order.DailyNumber = todayCount + 1;

            var insertCmd = new MySqlCommand(
                "INSERT INTO orders (DailyNumber, OrderDate, TableNumber, TotalAmount, Discount, PaymentMethod) " +
                "VALUES (@num, @date, @table, @total, @discount, @method); SELECT LAST_INSERT_ID();", connection);

            insertCmd.Parameters.AddWithValue("@num", order.DailyNumber);
            insertCmd.Parameters.AddWithValue("@date", order.OrderDate);
            insertCmd.Parameters.AddWithValue("@table", order.TableNumber);
            insertCmd.Parameters.AddWithValue("@total", order.TotalAmount);
            insertCmd.Parameters.AddWithValue("@discount", order.Discount);
            insertCmd.Parameters.AddWithValue("@method", order.PaymentMethod);

            order.ID = Convert.ToInt32(insertCmd.ExecuteScalar());
        }

        return order.ID;
    }
}