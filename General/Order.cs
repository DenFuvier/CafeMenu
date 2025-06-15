using System;

namespace CafeMenu.General
{
    public class Order
    {
        public int ID { get; set; }
        public int DailyNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int TableNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public int Discount { get; set; }
        public string PaymentMethod { get; set; }
    }
}
