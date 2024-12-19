using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    public abstract class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Team Team { get; set; } = new Team();

        //Enum con las categorias(Amateur y profesional)
        public PlayerCategory Category { get; set; }

        //obtener y asignar Equipo
        public string GetTeam()
        {
            string name = Team.Name;
            return name;
        }
        public virtual void AssigTeam(Team team)
        {
            Team = team;
        }

        //Metodo para cambiar la categoria
        public virtual void SetCategory(PlayerCategory playerCategory)
        {
            Category = playerCategory;
        }

        //Metodo para obtener el valor del mercado del jugador
        public abstract string GetMarketValue(PlayerCategory playerCategory);

    }

    public class Team
    {
        public string Name { get; set; }
    }
}
