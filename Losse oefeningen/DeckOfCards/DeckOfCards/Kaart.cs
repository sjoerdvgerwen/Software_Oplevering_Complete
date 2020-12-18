using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Kaart
    {
        //Properties
        string kaart;
        public string waardes { get; set; }
        public string soort { get; set; }


        //Constructor
        public Kaart(string Waardes, string Soort) 
        {
            waardes = Waardes;
            soort = Soort;
        }
        public override string ToString()
        {
            return kaart = waardes + " " + soort;
        }
    }
}
