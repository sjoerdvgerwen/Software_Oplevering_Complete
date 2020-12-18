using System;
using System.Collections.Generic;
using System.Text;

namespace Races.Logic
{

    public class RaceDicipline
    {
        public string name { get; set; }
        public int StartYear { get; set; }
        public bool isActive { get; set; }


        private List<Season> Seasons { get; set; }

        public RaceDicipline()
        {
            Seasons = new List<Season>();
        }

        public void Addseason(Season season)
        {
            Seasons.Add(season);
        }
    }
}
