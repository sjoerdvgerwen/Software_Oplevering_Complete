using System;
using System.Collections.Generic;
using System.Text;
using Races.Interface;
using Races.DTO;

namespace Races.Data
{
    public class TeamDal : ITeam
    {
        List<TeamDto> TeamDtos = new List<TeamDto>();

        public void Add(TeamDto team)
        {
            TeamDtos.Add(team);
        }

        public TeamDto GetById(int id)
        {
            return new TeamDto
            {
                ID = 1,
                Name = "Redbull Racing",
                Country = "Netherlands",
                City = "Masstricht",
                MainSponsor = "Honda",
                Director = "Sjoerd van Gerwen",
                FoundingYear = 1988
            };
        }
    }
}
