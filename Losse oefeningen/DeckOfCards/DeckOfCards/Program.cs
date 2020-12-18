using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DeckOfCards
{
    public class Program
    {
        public enum Waardes
        {
            twee, drie, vier, vijf, zes, zeven, acht, negen, tien, boer, vrouw, heer, aas
        };

        public enum Soort
        {
            schoppen, klaveren, harten, ruiten
        };
        static void Main(string[] args)
        {

            List<string> waardes = new List<string>();
            waardes.Add("twee");
            waardes.Add("drie");
            waardes.Add("vier");
            waardes.Add("vijf");
            waardes.Add("zes");
            waardes.Add("zeven");
            waardes.Add("acht");
            waardes.Add("negen");
            waardes.Add("tien");
            waardes.Add("boer");
            waardes.Add("vrouw");
            waardes.Add("heer");
            waardes.Add("aas");



            List<string> soort = new List<string>();
            soort.Add("schoppen");
            soort.Add("klaveren");
            soort.Add("harten");
            soort.Add("ruiten");

            int i;
            int j;
            string nieuwWaardes;
            string nieuwSoort;

            //for (i = 0, j = 0; (i < waardes.Count) && (j < soort.Count); i++, j++) // opslitten

            for (i = 0; i < 13; i++)
            {
                nieuwWaardes = waardes[i];
                for (j = 0; j < 4; j++)
                {
                    nieuwSoort = soort[j];
                    Kaart kaart = new Kaart(nieuwWaardes, nieuwSoort);
                    List<Kaart> kaarten = new List<Kaart>();
                    kaarten.Add(kaart);

                    foreach (Kaart k in kaarten)
                    {
                        Console.WriteLine(kaart);

                        Random rndkaart = new Random(kaarten);

                    }
                }
            }
        }
    }
}

//List<Kaarten> lijstkaarten = new List<Kaarten>();

//for (int i = 0; i < 13; i++)
//{
//for (int j = 0; j < 4; j++)
//   {
//  DeckOfCards.Kaarten kaart = new DeckOfCards.Kaarten(Waardes.[i], Soort.[j]);
//  lijstkaarten.Add(kaart);
//  Console.WriteLine(lijstkaarten);
//   }
// }

//int c;
//int d;
//for (c = 0, d = 0; (c < 13) && (d < 4); c++, d++){
// Kaarten kaart = new Kaarten(Waardes.[c], Soort.[d]);
// DeckOfCards.Kaarten obj = new DeckOfCards.Kaarten(Waardes.[c], Soort.[d]);
// lijstkaarten.Add(obj);

//}



// Console.WriteLine();
//Kaarten kaart = new Kaarten();

