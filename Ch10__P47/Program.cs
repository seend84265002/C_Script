using System;

namespace Ch10__P47
{
    class Program
    {
        static void Main(string[] args)
        {
            Order ord1 = new Order("ID_001", true, true);
            Console.WriteLine("Order ID: "+ord1.OrderNo+" "+ ord1.status.GetStatus());

            Order ord2 = new Order("ID_002", false, true);
            Console.WriteLine("Order ID: " + ord2.OrderNo + " " + ord2.status.GetStatus());
        }
    }
    class Order
    {
        public string OrderNo;
        public OrderStatus status;

        public class OrderStatus
        {
            public bool IsShipeed;
            public bool IsPaied;
            public string GetStatus()
            {
                return "Shipped: " + IsShipeed + " " + "IsPaied: " + IsPaied;
            }
            public OrderStatus(bool s,bool p)
            {
                IsShipeed = s;
                IsPaied = p;
            }
        }
        public Order(string no ,bool ship,bool paied)
        {
            OrderNo = no;
            status = new OrderStatus(ship, paied);
        }
    }
}
