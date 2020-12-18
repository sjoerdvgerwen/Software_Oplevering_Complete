using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSim1
{
    public class Speler
    {
        public string Name { get; set; }

        public int HitPoints { get; set; }

        public Speler(string name, int hitpoints)
        {
            Name = name;
            HitPoints = hitpoints;
        }


        public int Attack()
        {
            Random rnd = new Random();
            int Damage = rnd.Next(0, 31);

            
            try
            {
                if (Damage >= 25)
                {
                    Console.WriteLine("Crital Hit!");
                }
            }

            catch
            {
                if (Damage == 0)
                {
                    Console.WriteLine("Miss");
                }
                    
            }
            return Damage;
        }
    }
}
