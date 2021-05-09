using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery_Service
{
    class BoxCollection
    {
        public List<RegularBox> regularBoxCollection = new List<RegularBox>(); 
        public List<TightBox> tightBoxCollection = new List<TightBox>();
        public List<ColorBox> colorBoxCollection = new List<ColorBox>();
        public List<ColoredRibbon> coloredRibbonCollection = new List<ColoredRibbon>();
        public List<Filler> fillerCollection = new List<Filler>();

        public void AddRegularBox(int count)
        {
            var regularBox = new RegularBox();
            for (var i = 0; i < count; i++)
            {
                regularBoxCollection.Add(regularBox);
            }
        }
        public void AddTightBox( int count)
        {
            var tightBox = new TightBox();
            for (var i = 0; i < count; i++)
            {
                tightBoxCollection.Add(tightBox);
            }
        }
        public void AddColorBox( string color, int count)
        {
            var colorBox = new ColorBox(color);
            for (var i = 0; i < count; i++)
            {
                colorBoxCollection.Add(colorBox);
            }
        }
        public void AddColoredRibbon( string color, int count)
        {
            var coloredRibbon = new ColoredRibbon(color);
            for (var i = 0; i < count; i++)
            {
                coloredRibbonCollection.Add(coloredRibbon);
            }
        }
        public void AddFiller( int count)
        {
            var filler = new Filler();
            for (var i = 0; i < count; i++)
            {
                fillerCollection.Add(filler);
            }
        }

        public void RemoveItem(RegularBox item)
        {
            if (regularBoxCollection.Count != 0)
            {
                regularBoxCollection.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Обычные коробки закончились");
            }
        }
        public void RemoveItem(TightBox item)
        {
            if(tightBoxCollection.Count != 0)
            {
                tightBoxCollection.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Плотные коробки закончились");
            }
        }
        public void RemoveItem(ColorBox item)
        {
            for(var i =0; i< colorBoxCollection.Count; i++)
            {
                if(colorBoxCollection[i].Color == item.Color)
                {
                    colorBoxCollection.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine("Цветные коробки закончились");
                }
            }
        }
        public void RemoveItem(ColoredRibbon item)
        {
            for (var i = 0; i <= colorBoxCollection.Count; i++)
            {
                if (coloredRibbonCollection[i].Color == item.Color)
                {
                    coloredRibbonCollection.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine("Цветные ленты закончились");
                }
            }
        }
        public void RemoveItem(Filler item)
        {
            if (fillerCollection.Count != 0)
            {
                fillerCollection.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Наполнитель закончился");
            }
        }
    }
}
