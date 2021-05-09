using System;

namespace Delivery_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxCollection box = new BoxCollection();
            box.AddRegularBox(10);
            box.AddTightBox(10);
            box.AddFiller(10);
            box.AddColorBox("blue",10);
            box.AddColoredRibbon("blue",10);
            var magicColor = new MagicColor("Address", "89085464576", "blue", "blue");
            var simpleFimt = new SimpleFirm("Address", "89025566535"); 
            var goldSecret = new GoldSecret("Address", "89923457541", true);
            OrderCollection orderCollection = new OrderCollection(box);
            orderCollection.CreateNewOrder(magicColor, "Address");
            orderCollection.CreateNewOrder(goldSecret, "Address");
            orderCollection.CreateNewOrder(simpleFimt, "Address");
            orderCollection.CreateNewOrder(simpleFimt, "Address");
            orderCollection.CreateNewOrder(simpleFimt, "Address");
            orderCollection.CreateNewOrder(simpleFimt, "Address");
            orderCollection.CreateNewOrder(simpleFimt, "Address");
            Courier courier = new Courier("Алексей Просеков", "89090009878");
            courier.SendingOrder();
        }
    }
}
