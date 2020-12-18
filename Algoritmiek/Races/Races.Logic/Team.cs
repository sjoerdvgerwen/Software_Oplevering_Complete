using System;
using System.Collections.Generic;
using System.Text;

namespace Races.Logic
{
    public class Team
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string MainSponsor { get; set; }

        public int FoundingYear { get; set; }

        public string Director { get; set; }

        public Team(string name, string city, string country, string mainSponsor, int foundingYear, string director)
        {
            Name = name;
            City = city;
            Country = country;
            MainSponsor = mainSponsor;
            FoundingYear = foundingYear;
            Director = Director;
        }

        public void UpdateTeam()
        {

        }
    }
}
