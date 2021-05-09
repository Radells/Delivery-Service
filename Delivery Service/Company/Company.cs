using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class Company
    {
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string Name { get; set; }
        
        public Company(string adress, string telephone)
        {
            Adress = adress;
            Telephone = telephone;
        }
    }
}
