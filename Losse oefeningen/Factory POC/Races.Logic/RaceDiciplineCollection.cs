using System;
using System.Collections.Generic;
using System.Text;

namespace Races.Logic
{
    public class RaceDiciplineCollection
    {
        // List<RaceDicipline> RaceDiciplines = new List<RaceDicipline>();

        private List<RaceDicipline> RaceDiciplines { get; set; }
        public RaceDiciplineCollection()
        {
            RaceDiciplines = new List<RaceDicipline>();
        }
        public void AddRaceDicipline(RaceDicipline racedicipline)
        {
            RaceDiciplines.Add(racedicipline);
        }

        public void RemoveRaceDicipline(RaceDicipline racedicipline)
        {
            RaceDiciplines.Remove(racedicipline);
        }
    }
}
