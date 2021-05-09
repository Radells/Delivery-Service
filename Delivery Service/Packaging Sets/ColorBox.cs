using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class ColorBox
    {
        public int Cost { get; private set; }
        public string Color { get; private set; }
        public ColorBox(string color)
        {
            Color = color;
            Cost = 40;
        }
    }
}
