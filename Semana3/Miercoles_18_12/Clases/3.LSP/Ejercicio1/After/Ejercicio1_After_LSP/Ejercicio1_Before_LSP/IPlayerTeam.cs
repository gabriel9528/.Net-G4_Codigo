using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    internal interface IPlayerTeam : IPlayer
    {
        public Team Team { get; set; }
        string GetTeam();
        void AssigTeam(Team team);
    }
}
