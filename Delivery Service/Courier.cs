using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class Courier
    {
        public string FIO { get; private set; }
        public string Telephone { get; private set; }
        public Courier(string fio, string telephone)
        {
            FIO = fio;
            Telephone = telephone;
        }
       public void SendingOrder()
        {
            for(var i = 0; i < 4; i++)
            {
                if (QueueOrders.vipOrderQueue.Count != 0)
                {
                    Console.WriteLine($"заказ от компании {QueueOrders.vipOrderQueue.Peek().CompanyCustomer.Name} отправлен");
                    Console.WriteLine($"Адрес доставки: {QueueOrders.vipOrderQueue.Peek().DeliveryAddress}");
                    Console.WriteLine($"Цена доставки: {QueueOrders.vipOrderQueue.Peek().FullPrice}");
                    QueueOrders.vipOrderQueue.Dequeue();
                }
                else
                {
                    if(QueueOrders.orderQueue.Count != 0)
                    {
                        Console.WriteLine($"заказ от компании {QueueOrders.orderQueue.Peek().CompanyCustomer.Name} отправлен");
                        Console.WriteLine($"Адрес доставки: {QueueOrders.orderQueue.Peek().DeliveryAddress}");
                        Console.WriteLine($"Цена доставки: {QueueOrders.orderQueue.Peek().FullPrice}");
                        QueueOrders.orderQueue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
