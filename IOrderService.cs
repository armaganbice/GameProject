using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        void Add(Gamer gamer, Order order);

        void Delete(Order order);

        void Update(Order order);
    }
}
