using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class ColoredRibbon
    {
        public int Cost { get; private set; }
        public string Color { get; private set; }
        public ColoredRibbon(string color)
        {
            Color = color;
            Cost = 15;
        }
    }
}
