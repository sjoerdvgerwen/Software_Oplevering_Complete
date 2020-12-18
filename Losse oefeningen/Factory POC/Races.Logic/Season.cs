using System;
using System.Collections.Generic;
using System.Text;

namespace Races.Logic
{

    public class Season
    {
        public int numberOfRaces { get; set; }
        public string Champion { get; set; }
        public int year { get; set; }

        private List<Team> Teams { get; set; }

        public Season()
        {
            Teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);

            IAddTeamDal dal = TeamFactory.GetTeamDal();

        }

        public void RemoveTeam(Team team)
        {
            Teams.Remove(team);
        }

        public void AddChampion(string champion)
        {
            Champion = champion;
        }
    }
} 