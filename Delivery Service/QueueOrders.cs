using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    static class QueueOrders
    {
        public static Queue<Order> orderQueue = new Queue<Order>();
        public static Queue<Order> vipOrderQueue = new Queue<Order>();
        public static List<Order> listDeliveries = new List<Order>();

        public static void AddQueue(Order customer)
        {
            if(customer.CompanyCustomer is GoldSecret)
            {
                vipOrderQueue.Enqueue(customer);
            }
            else
            {
                orderQueue.Enqueue(customer);
            }
        }
       
    }
}
