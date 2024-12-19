using System;

namespace LSPLibrary
{
    public abstract class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Team Team { get; set; } = new Team();

        //Enum con las categorías (amateur, Profesional). 
        public PlayerCategory  Category { get; set; }

        //Obtener y Asignar Equipo
        public string GetTeam() => Team.Name;
        public virtual void AssignTeam(Team team)
        {
            Team = team;
        }

        //Método para cambiar la categoria
        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }

        //Método para obtener el valor de mercado
        public abstract string GetMarketValue(PlayerCategory category);

    }

    public class Team
    {
        public string Name { get; set; }
    }
}
