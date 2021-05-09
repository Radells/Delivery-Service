using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class Order
    {
        public Company CompanyCustomer { get; private set; }
        public string DeliveryAddress { get; private set; }
        public int FullPrice { get; set; }

        public Order( Company company, string deliveryAddress)
        {
            CompanyCustomer = company;
            DeliveryAddress = deliveryAddress;
            FullPrice = 0;
        }
    }
}
