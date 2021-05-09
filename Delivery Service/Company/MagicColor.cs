using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class MagicColor : Company
    {
        public string ColorBox { get; private set; }
        public string ColorRibbon { get; private set; }
        public MagicColor(string adress, string telephone, string colorBox, string colorRibbon)
            : base(adress, telephone)
        {
            Adress = adress;
            Telephone = telephone;
            Name = "Magic Color";
            ColorBox = colorBox;
            ColorRibbon = colorRibbon;
        }
    }
}
