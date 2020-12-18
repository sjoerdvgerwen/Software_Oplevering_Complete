using System;
using System.Collections.Generic;
using System.Text;

namespace Races.Logic
{
    public class TeamCollection
    {
        private List<Team> Teams;

        public TeamCollection()
        {
            Teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void RemoveTeam(Team team)
        {
            Teams.Remove(team);
        }

        public Team[] GetAllTeams()
        {
            Team[] teamArray = Teams.ToArray();
            return teamArray;
        }
    }
}
