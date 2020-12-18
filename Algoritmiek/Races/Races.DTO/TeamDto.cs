using System;
using System.Collections.Generic;
using System.Text;

namespace Races.DTO
{
    public class TeamDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string MainSponsor { get; set; }
        public string Director { get; set; }
        public int FoundingYear { get; set; }
    }
}
