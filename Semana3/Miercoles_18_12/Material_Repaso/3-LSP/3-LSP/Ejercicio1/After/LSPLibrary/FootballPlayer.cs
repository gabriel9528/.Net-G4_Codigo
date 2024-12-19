using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class FootballPlayer : Player, IPlayerTeam
    {
        public Team Team { get; set; }

        public void AssignTeam(Team team)
        {
            Team = team;
        }
        public string GetTeam()
        {
            return Team.Name;
        }

    }
}