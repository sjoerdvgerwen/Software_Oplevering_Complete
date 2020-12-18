using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;

namespace ContainerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            
            string inputLength;
            string inputWidth;

            int Length;
            int Width;


            Console.WriteLine("How many rows of containers in lenght?");
            inputLength = Console.ReadLine();
            Length = Int32.Parse(inputLength);
            ship.Xvalue = Length;

            Console.WriteLine("How many rows of containers in width?");
            inputWidth = Console.ReadLine();
            Width = Int32.Parse(inputWidth);
            ship.Yvalue = Width;

            ship.LoadCapacity = ship.Xvalue * ship.Yvalue;

            Console.WriteLine("De beschikbare plaatsen zijn:" + ship.LoadCapacity);
            Console.WriteLine("De hoogte is gelimiteerd tot 120.000 kg");
            Console.ReadLine();


            List<Container> container = new List<Container>();
            container.Add(new Container(20000, false, true));
        }
    }
}