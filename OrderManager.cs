using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Add(Gamer gamer, Order order)
        {
            Console.WriteLine(gamer.SurName + " Ordered "+order.OrderId);
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Order deleted");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Order Update");
        }
    }
}
