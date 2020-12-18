using System;
using System.Security.Cryptography.X509Certificates;

namespace Dobbelsteen_Oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            int dobbelsteen;
            string str;
            

            
                Random worp = new Random();
                dobbelsteen = worp.Next(0, 7);

            Console.WriteLine(dobbelsteen);
            
            
            

            while (dobbelsteen != 7)
            {
                Console.WriteLine("Geen 6 ! Gooi opnieuw");
                Console.WriteLine("Druk op enter om opnieuw te gooien");
                Console.ReadLine();
                Console.WriteLine(dobbelsteen);
                dobbelsteen++;
            }

            if (dobbelsteen == 7)
            {
                Console.WriteLine("GEFELICTEERD JE HEBT 6 GEGOOID");
            }



        }
    }
}
