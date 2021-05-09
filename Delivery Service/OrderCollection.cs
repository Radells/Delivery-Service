using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class OrderCollection
    {
        public List<Order> ordersCollection = new List<Order>();
        public BoxCollection BoxCollection { get; private set; }

        public OrderCollection(BoxCollection boxCollection)
        {
            BoxCollection = boxCollection;
        }

        public void CreateNewOrder(Company company, string address)
        {
            Order order = new Order(company, address);
            switch (order.CompanyCustomer.Name)
            {
                case "Gold Secret":
                    var gold = order.CompanyCustomer as GoldSecret;
                    var tightBox = new TightBox();
                    BoxCollection.RemoveItem(tightBox);
                    order.FullPrice += tightBox.Cost;
                    if (gold.FragilityPackage == true)
                    {
                        var filler = new Filler();
                        BoxCollection.RemoveItem(filler);
                        order.FullPrice += filler.Cost;
                    }
                    ordersCollection.Add(order);
                    break;
                case "Simple Firm":
                    var Simple = order.CompanyCustomer as SimpleFirm;
                    var regularBox = new RegularBox();
                    BoxCollection.RemoveItem(regularBox);
                    order.FullPrice += regularBox.Cost;
                    ordersCollection.Add(order);
                    break;
                case "Magic Color":
                    var Magic = order.CompanyCustomer as MagicColor;
                    var colorBox = new ColorBox(Magic.ColorBox);
                    var colorRibbon = new ColoredRibbon(Magic.ColorRibbon);
                    BoxCollection.RemoveItem(colorBox);
                    order.FullPrice += colorBox.Cost;
                    order.FullPrice += colorRibbon.Cost;
                    ordersCollection.Add(order);
                    break;
            }
            QueueOrders.AddQueue(order);
        }
        public void PrintAllOrders()
        {
            for(var i = 0; i < ordersCollection.Count; i++)
            {
                Console.WriteLine($"Компания {ordersCollection[i].CompanyCustomer.Name} сделала заказ");
                Console.WriteLine($"Адрес доставки: {ordersCollection[i].DeliveryAddress}");
                Console.WriteLine($"Цена услуги: {ordersCollection[i].FullPrice}");
            }
        }

    }
}
