using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class SimpleFirm : Company
    {
        public SimpleFirm(string adress, string telephone)
            : base(adress, telephone)
        {
            Adress = adress;
            Telephone = telephone;
            Name = "Simple Firm";
        }
    }
}
