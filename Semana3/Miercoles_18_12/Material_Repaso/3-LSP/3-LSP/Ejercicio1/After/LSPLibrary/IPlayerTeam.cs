using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public interface IPlayerTeam : IPlayer
    {
        Team Team { get; set; }
        void AssignTeam(Team team);
        string GetTeam();
    }
}
