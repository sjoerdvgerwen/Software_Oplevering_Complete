using System;
using System.Collections.Generic;
using System.Text;

namespace CookieClicker
{
    public class KoekjesController
    {
        //public int Kps = 0;

        //public int Koekjes = 0;

        //public int KoekjesPerKlik = 10;

        //public KoekjesController()
        //{
        //    Upgrade Bakker = new Upgrade("Bakker", 10, 100, 150);
        //    Upgrade Oven = new Upgrade("Oven", 50, 2000, 450);
        //    Upgrade DeegRoller = new Upgrade("DeegRoller", 0, 3500, 700);
        //}




        public int Kps { get; set; }
        public int Koekjes { get; set; }
        public int KoekjesPerKlik { get; set; }

        public KoekjesController()
        {
            Kps = 10;
            Koekjes = 0;
            KoekjesPerKlik = 10;
        }
    }
}
