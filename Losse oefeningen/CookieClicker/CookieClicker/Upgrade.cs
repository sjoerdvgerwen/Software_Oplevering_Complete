using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CookieClicker
{
    public class Upgrade
    {
        public string Naam { get; set; }
        public int Kps { get; set; }
        public int Prijs { get; set; }
        public int PrijsInterval { get; set; }
        public int Aantal { get; set; }

        public Upgrade(string naam, int kps, int prijs, int prijsInterval)
        {
            Naam = naam;
            Kps = kps;
            Prijs = prijs;
            PrijsInterval = prijsInterval;
            Aantal = 0;
        }
    }
}
