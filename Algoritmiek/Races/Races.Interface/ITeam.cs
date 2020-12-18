using System;
using System.Collections.Generic;
using System.Text;
using Races.DTO;

namespace Races.Interface
{
    public interface ITeam
    {
        TeamDto GetById(int id);

        void Add(TeamDto team);
    }
}
