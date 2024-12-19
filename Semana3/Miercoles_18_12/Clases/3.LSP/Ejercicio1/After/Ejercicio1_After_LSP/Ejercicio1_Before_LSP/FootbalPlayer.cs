using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    internal class FootbalPlayer : Player, IPlayerTeam
    {
        public Team Team { get; set; }

        public void AssigTeam(Team team)
        {
            Team = team;
        }

        public string GetTeam()
        {
            return Team.Name;
        }
    }
}
