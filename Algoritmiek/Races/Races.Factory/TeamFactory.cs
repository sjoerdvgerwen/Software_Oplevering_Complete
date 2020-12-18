using System;
using System.Collections.Generic;
using System.Text;
using Races.Data;
using Races.Interface;

namespace Races.Factory
{
    public class TeamFactory
    {
        public static ITeam GetTeamDal()
        {
            return new TeamDal();
        }
        
    }
}
