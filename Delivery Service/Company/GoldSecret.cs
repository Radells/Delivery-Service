using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class GoldSecret : Company
    {
        public bool FragilityPackage { get; private set; }
        public GoldSecret(string adress, string telephone, bool fragilityPackage)
            : base(adress, telephone)
        {
            Adress = adress;
            Telephone = telephone;
            Name = "Gold Secret";
            FragilityPackage = fragilityPackage;
        }
    }
}
